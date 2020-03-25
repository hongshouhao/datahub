using Geone.DataService.AspNetCore.Config;
using Geone.DataService.Core;
using Geone.DataService.Core.Repository;
using Geone.DataService.Core.Service;
using Geone.DataService.Core.Service.Aggregate;
using Geone.DataService.Core.Service.DBaaS;
using Geone.DataService.Core.Service.REST;
using Geone.DataService.Core.Service.SOAP;
using Geone.IdentityServer4.Client;
using Geone.IdentityServer4.Client.Models;
using Microsoft.AspNetCore.Builder;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System.Linq;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class _
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, string configFile)
        {
            services.AddSingleton(ConfigRoot.Read(configFile));
            services.AddSingleton<IDbConnectionFactory>(c => new OrmLiteConnectionFactory("meta.db", SqliteDialect.Provider));
            services.AddSingleton<MetaRepository>();
            services.AddSingleton<DBaaSExcutor>();
            services.AddSingleton<SoapExcutor>();
            services.AddSingleton<RestExcutor>();
            services.AddSingleton<SingleServiceExcutor>();
            services.AddSingleton<AggregateExcutor>();
            services.AddSingleton<ServiceExcutor>();

            return services;
        }

        public static IApplicationBuilder UseDataServices(this IApplicationBuilder app)
        {
            IDbConnectionFactory dbFactory = app.ApplicationServices.GetService(typeof(IDbConnectionFactory)) as IDbConnectionFactory;
            DsSetup setup = new DsSetup(dbFactory);
            setup.Initialize();
            return app;
        }

        public static IApplicationBuilder AddSwaggerClientToIds(this IApplicationBuilder app)
        {
            ConfigRoot config = (ConfigRoot)app.ApplicationServices.GetService(typeof(ConfigRoot));
            if (string.IsNullOrWhiteSpace(config.IdentityServer?.BaseURL))
            {
                return app;
            }

            MetaRepository repository = (MetaRepository)app.ApplicationServices.GetService(typeof(MetaRepository));
            var services = repository.Query(x => x.MetaType == MetaType.Service)
                .Select(x => $"{config.Server.Name.ToLower()}.{x.Name.ToLower()}").ToList();

            IdS4Client client = new IdS4Client(config.IdentityServer);
            ClientRegistry clientRegistry = new ClientRegistry()
            {
                AllowedGrantType = "implicit",
                AllowOfflineAccess = false,
                BaseURL = config.Server.BaseUrl,
                AllowAccessTokensViaBrowser = true,
                AllowedScopes = services,
                ClientUri = $"{config.Server.BaseUrl}/swagger",
                ClientId = config.Server.Name + "Swagger",
                ClientName = config.Server.Name + "Swagger",
                Description = $"数据服务Swagger[{config.Server.BaseUrl}/swagger]",
                RedirectUri = $"{config.Server.BaseUrl}swagger/oauth2-redirect.html"
            };
            try
            {
                client.SaveClient(clientRegistry);
            }
            catch (IdS4Exception)
            {
            }
            

            return app;
        }
    }
}
