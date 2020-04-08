using Geone.AuthorisationFilter.Authorisation;
using Geone.DataService.AspNetCore.Config;
using Geone.DataService.AspNetCore.Swagger;
using Geone.DataService.Core.Exceptions;
using Geone.IdentityServer4.Client;
using Hellang.Middleware.ProblemDetails;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace Geone.DataService
{
    public class Startup
    {
        public Startup()
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDataServices();

            if (!string.IsNullOrWhiteSpace(RootConfig.Value.IdSServer?.BaseUrl))
            {
                services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                        .AddIdentityServerAuthentication(options =>
                        {
                            options.RequireHttpsMetadata = false;
                            options.ApiName = RootConfig.Value.Server.Name;
                            options.Authority = RootConfig.Value.IdSServer.BaseUrl;
                            options.ApiSecret = RootConfig.Value.IdSServer.ApiSecret;
                        });
            }

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Data Hub Web API", Version = "v1" });
                options.DocumentFilter<ServiceDocumentFilter>();
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        Password = new OpenApiOAuthFlow
                        {
                            TokenUrl = new Uri(RootConfig.Value.IdSServer.BaseUrl + "/connect/token"),
                        },
                        Implicit = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri(RootConfig.Value.IdSServer.BaseUrl + "/connect/authorize"),
                        }
                    },
                });
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

            services.AddProblemDetails(options =>
            {
                options.Map<DataServiceException>(ex => new StatusCodeProblemDetails(ex.Status) { Detail = ex.Message });
                options.Map<IdSException>(ex => new StatusCodeProblemDetails(ex.Status));
            });

            services.AddControllers(options => options.Filters.Add<DynamicAuthorize>())
                    .Add400ProblemDetails()
                    .AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDataServices();
            app.RegisteSwaggerClientToIdentityServer();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Data Hub Web API V1");
                options.OAuthClientId(RootConfig.Value.Server.Name + "-swagger");
            });

            app.UseProblemDetails();
            app.UseCors();
            app.UseMiddleware<ErrorHandlingMiddleware>();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
