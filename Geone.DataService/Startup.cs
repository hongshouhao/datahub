using Geone.DataService.Config;
using Geone.DataService.Core;
using Geone.DataService.Core.Repository;
using Geone.DataService.Core.Service.DBaaS;
using Geone.DataService.Core.Service.SOAP;
using Geone.DataService.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace Geone.DataService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(ConfigRoot.Read("appsettings.json"));
            services.AddSingleton<IDbConnectionFactory>(c => new OrmLiteConnectionFactory("meta.db", SqliteDialect.Provider));
            services.AddSingleton<MetaRepository>();
            services.AddSingleton<DBaaSExcutor>();
            services.AddSingleton<SoapExcutor>();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Data Service Web API", Version = "v1" });
                options.DocumentFilter<ServiceDocumentFilter>();
                options.EnableAnnotations();
            });
            services.AddSwaggerGenNewtonsoftSupport();
            services.AddControllers().AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            IDbConnectionFactory dbFactory = app.ApplicationServices.GetService(typeof(IDbConnectionFactory)) as IDbConnectionFactory;

            DsSetup setup = new DsSetup(dbFactory);
            setup.Initialize();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                //  options.RoutePrefix = "prefix";
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Data Service Web API V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<ErrorHandlingMiddleware>();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
