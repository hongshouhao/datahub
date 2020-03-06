using Geone.DataService.AspNetCore.Config;
using Geone.DataService.Core;
using Geone.DataService.Core.Repository;
using Geone.DataService.Core.Service;
using Geone.DataService.Core.Service.Aggregate;
using Geone.DataService.Core.Service.DBaaS;
using Geone.DataService.Core.Service.REST;
using Geone.DataService.Core.Service.SOAP;
using Microsoft.AspNetCore.Builder;
using ServiceStack.Data;
using ServiceStack.OrmLite;

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
    }
}
