using Geone.DataService.AspNetCore.Swagger;
using Geone.DataService.Authorize;
using Geone.DataService.Core.Exceptions;
using Geone.IdentityServer4.Client;
using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

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
            services.AddDataServices("appsettings.json");
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Data Hub Web API", Version = "v1" });
                options.DocumentFilter<ServiceDocumentFilter>();
                options.EnableAnnotations();
            });
            services.AddSwaggerGenNewtonsoftSupport();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAny", builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });

            if (Configuration.GetValue<bool>("FilterEnable"))
            {
                services.AddMvc(options => options.Filters.Add<AuthorizationFilter>());
            }

            services.AddProblemDetails(options =>
            {
                options.Map<DataServiceException>(ex => new StatusCodeProblemDetails(ex.Status) { Detail = ex.Message });
                options.Map<IdS4Exception>(ex => new StatusCodeProblemDetails(ex.Status));
            });

            services.AddControllers()
                    .Add400ProblemDetails()
                    .AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDataServices();
            app.AddSwaggerClientToIds();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Data Hub Web API V1");
            });

            app.UseCors("AllowAny");
            app.UseMiddleware<ErrorHandlingMiddleware>();
            app.UseRouting();
            app.UseProblemDetails();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
