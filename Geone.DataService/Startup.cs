using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Geone.DataService.Core;
using Geone.DataService.Core.DBaaS;
using Geone.DataService.Core.Repository;
using Geone.DataService.Core.SOAP;
using Geone.DataService.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Swagger;

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

            services.AddControllers();
            services.AddMvc();
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

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
