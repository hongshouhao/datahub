using Elastic.Apm.AspNetCore;
using Elastic.Apm.DiagnosticSource;
using Geone.AuthorisationFilter.Authorisation;
using Geone.DataHub.AspNetCore.Config;
using Geone.DataHub.AspNetCore.Swagger;
using Geone.DataHub.Core.APM;
using Geone.DataHub.Core.Exceptions;
using Geone.IdentityServer4.Client;
using Hellang.Middleware.ProblemDetails;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Core.Enrichers;
using Serilog.Enrichers.AspNetCore.HttpContext;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Geone.DataHub
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private IConfiguration _configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDataHub();
            services.AddHttpClient();
            services.AddHttpContextAccessor();

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
                options.Map<DataHubException>(ex => new StatusCodeProblemDetails(ex.Status) { Detail = ex.Message });
                options.Map<IdSException>(ex => new StatusCodeProblemDetails(ex.Status) { Detail = ex.Message });
            });

            services.AddControllers(options => options.Filters.Add<DynamicAuthorize>())
                        .Add400ProblemDetails()
                        .AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseElasticApm(_configuration, new HttpDiagnosticsSubscriber(), new DbClientDiagnosticsSubscriber());
            app.UseSerilogRequestLogging();

            app.SetupDataHub();
            app.RegisteSwagger2IdentityServer();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Data Hub Web API V1");
                options.OAuthClientId(RootConfig.Value.Server.Name + "-swagger");
            });

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSerilogLogContext(options =>
            {
                options.EnrichersForContextFactory = context =>
                {
                    List<PropertyEnricher> list = new List<PropertyEnricher>()
                    {
                        new PropertyEnricher("UserId", context.User.Identity.Name),
                        new PropertyEnricher("UserName", context.User.FindFirst("cnname")?.Value),
                        new PropertyEnricher("Scopes", string.Join(",", context.User.FindAll("scope").Select(x=>x.Value))),
                        new PropertyEnricher("Roles", string.Join(",", context.User.FindAll("role").Select(x=>x.Value))),
                    };

                    if (Log.IsEnabled(LogEventLevel.Debug))
                    {
                        list.Add(new PropertyEnricher("Route", string.Join(",", context.Request.RouteValues.Select(x => $"{x.Key}:{x.Value}"))));
                        list.Add(new PropertyEnricher("Body", context.Request.BodyAsString()));
                    }

                    return list;
                };
            });

            app.UseProblemDetails();
            app.UseCors();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
