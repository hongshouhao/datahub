using Geone.AuthorisationFilter.ResourceAuth;
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
using Microsoft.Extensions.Configuration;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System.Linq;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class _
    {
        public static IServiceCollection AddDataHub(this IServiceCollection services)
        {
            services.AddSingleton(RootConfig.Value);
            services.AddSingleton<IDbConnectionFactory>(c => new OrmLiteConnectionFactory("meta.db", SqliteDialect.Provider));
            services.AddSingleton<MetaRepository>();
            services.AddSingleton<DBaaSExcutor>();
            services.AddSingleton<SoapExcutor>();
            services.AddSingleton<RestExcutor>();
            services.AddSingleton<SingleServiceExcutor>();
            services.AddSingleton<AggregateExcutor>();
            services.AddSingleton<ServiceExcutor>();

            var openauthSection = configuration.GetSection("OpenAuth");
            string host = openauthSection["Host"];
            string role = openauthSection["AdminRole"];
            string appKey = openauthSection["AppKey"];

            //services.AddAuthorisationProlicy((sp) => new ApiProtectionProvider("apiprotection.json"));
            services.AddAuthorisationProlicy((sp) => new ApiAuthProlicyResourceAuthProvider(configuration));
            return services;
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
            RootConfig config = (RootConfig)app.ApplicationServices.GetService(typeof(RootConfig));
            if (string.IsNullOrWhiteSpace(config.IdSAdmin?.BaseUrl))
            {
                return app;
            }

            MetaRepository repository = (MetaRepository)app.ApplicationServices.GetService(typeof(MetaRepository));
            var scopes = repository.Query(x => x.MetaType == MetaType.Service)
                .Select(x => $"{config.Server.Name.ToLower()}.{x.Name.ToLower()}").ToList();
           
            scopes.Add("roles");

            IdSAdminClient client = new IdSAdminClient(config.IdSAdmin);
            ClientRegistry clientRegistry = new ClientRegistry()
            {
                AllowedGrantType = "implicit",
                AllowOfflineAccess = false,
                BaseURL = config.Server.BaseUrl,
                AllowAccessTokensViaBrowser = true,
                AllowedScopes = scopes,
                ClientUri = $"{config.Server.BaseUrl}/swagger",
                ClientId = config.Server.Name + "-swagger",
                ClientName = config.Server.Name + " swagger",
                Description = $"数据服务Swagger[{config.Server.BaseUrl}/swagger]",
                RedirectUri = $"{config.Server.BaseUrl}/swagger/oauth2-redirect.html"
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
