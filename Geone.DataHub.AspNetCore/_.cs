using Geone.AuthorisationFilter;
using Geone.DataHub.AspNetCore.Auth;
using Geone.DataHub.AspNetCore.Config;
using Geone.DataHub.Core;
using Geone.DataHub.Core.Repository;
using Geone.DataHub.Core.Service;
using Geone.DataHub.Core.Service.Aggregate;
using Geone.DataHub.Core.Service.DBaaS;
using Geone.DataHub.Core.Service.REST;
using Geone.DataHub.Core.Service.SOAP;
using Geone.IdentityServer4.Client;
using Geone.IdentityServer4.Client.Models;
using Microsoft.AspNetCore.Builder;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class _
    {
        public static IServiceCollection AddDataHub(this IServiceCollection services, string webRootPath)
        {
            AddMetadataDb(services, webRootPath);
            AddAuthorisationProlicyProvider(services);

            services.AddSingleton(AppSettings.Value);
            services.AddSingleton<MetaRepository>();
            services.AddSingleton<DBaaSExcutor>();
            services.AddSingleton<SoapExcutor>();
            services.AddSingleton<RestExcutor>();
            services.AddSingleton<SingleServiceExcutor>();
            services.AddSingleton<AggregateExcutor>();
            services.AddSingleton<ServiceExcutor>();
            return services;
        }

        private static void AddAuthorisationProlicyProvider(IServiceCollection services)
        {
            if (string.IsNullOrWhiteSpace(AppSettings.Value.Server.ApiProtectionProvider))
            {
                services.AddAuthorisationProlicy((sp) => new ApiProtectionProlicyProvider(false));
            }
            else if (AppSettings.Value.Server.ApiProtectionProvider == "identityserver")
            {
                services.AddAuthorisationProlicy((sp) => new ApiProtectionProlicyIdentityServerProvider(AppSettings.Value));
            }
            else if (AppSettings.Value.Server.ApiProtectionProvider == "jsonfile")
            {
                services.AddAuthorisationProlicy((sp) => new ApiProtectionProlicyJsonFileProvider());
            }
        }

        private static void AddMetadataDb(IServiceCollection services, string webRootPath)
        {
            IOrmLiteDialectProvider ormLiteDialect;
            string connectionString = AppSettings.Value.MetadataDb?.ConnectionString;

            switch (AppSettings.Value.MetadataDb?.Type?.ToLower())
            {
                case "mssql":
                    ormLiteDialect = SqlServerDialect.Provider;
                    break;
                case "mssql2008":
                    ormLiteDialect = SqlServer2008Dialect.Provider;
                    break;
                case "mssql2012":
                    ormLiteDialect = SqlServer2012Dialect.Provider;
                    break;
                case "mssql2016":
                    ormLiteDialect = SqlServer2016Dialect.Provider;
                    break;
                case "mysql":
                    ormLiteDialect = MySqlDialect.Provider;
                    break;
                case "pgsql":
                    ormLiteDialect = PostgreSqlDialect.Provider;
                    break;
                default:
                case "sqlite":
                    ormLiteDialect = SqliteDialect.Provider;
                    if (string.IsNullOrWhiteSpace(connectionString))
                    {
                        connectionString = "meta.db";
                    }
                    break;
            }

            if (ormLiteDialect != SqliteDialect.Provider && string.IsNullOrWhiteSpace(connectionString))
            {
                throw new Exception("元数据存储库配置错误");
            }

            services.AddSingleton((Func<IServiceProvider, IDbConnectionFactory>)(c => new OrmLiteConnectionFactory(connectionString, ormLiteDialect)));
        }

        public static IApplicationBuilder SetupDataHub(this IApplicationBuilder app)
        {
            IDbConnectionFactory dbFactory = app.ApplicationServices.GetService(typeof(IDbConnectionFactory)) as IDbConnectionFactory;
            DatahubSetup setup = new DatahubSetup(dbFactory);
            setup.Initialize();
            return app;
        }

        public static IApplicationBuilder RegisteSwagger2IdentityServer(this IApplicationBuilder app)
        {
            AppSettings config = AppSettings.Value;
            if (string.IsNullOrWhiteSpace(config.IdentityServer?.ApiBaseUrl))
            {
                return app;
            }

            MetaRepository repository = (MetaRepository)app.ApplicationServices.GetService(typeof(MetaRepository));
            var scopes = repository.Query(x => x.MetaType == MetaType.Service)
                .Select(x => $"{config.Server.Name.ToLower()}.{x.Name.ToLower()}").ToList();

            scopes.Add("roles");

            IdSAdminClient client = new IdSAdminClient(config.IdentityServer);
            ClientRegistry clientRegistry = new ClientRegistry()
            {
                AllowedGrantTypes = new List<string>() { "implicit" },
                AllowOfflineAccess = false,
                BaseURL = config.Server.BaseUrl,
                AllowAccessTokensViaBrowser = true,
                AllowedScopes = scopes,
                ClientUri = $"{config.Server.BaseUrl}/swagger",
                ClientId = config.Server.Name + "-swagger",
                ClientName = config.Server.Name + " swagger",
                Description = $"数据服务Swagger[{config.Server.BaseUrl}/swagger]",
                RedirectUris = new List<string>() { $"{config.Server.BaseUrl}/swagger/oauth2-redirect.html" },
                RequireClientSecret = false
            };

            try
            {
                client.SaveClient(clientRegistry);
            }
            catch (IdSException)
            {
            }

            return app;
        }
    }
}
