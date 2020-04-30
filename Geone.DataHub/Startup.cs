using Elastic.Apm.AspNetCore;
using Elastic.Apm.DiagnosticSource;
using Geone.AuthorisationFilter;
using Geone.DataHub.AspNetCore.Config;
using Geone.DataHub.AspNetCore.Swagger;
using Geone.DataHub.Core.APM;
using Geone.DataHub.Core.Exceptions;
using Geone.IdentityServer4.Client;
using Hellang.Middleware.ProblemDetails;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Serilog;
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

        private readonly IConfiguration _configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDataHub();
            services.AddHttpClient();
            services.AddHttpContextAccessor();

            if (!string.IsNullOrWhiteSpace(Root.Value.IdentityServer?.Authority))
            {
                services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                        .AddIdentityServerAuthentication(options =>
                        {
                            options.RequireHttpsMetadata = false;
                            options.RoleClaimType = "role";
                            options.NameClaimType = "name";
                            options.ApiName = Root.Value.Server.Name;
                            options.ApiSecret = Root.Value.Server.ApiSecret;
                            options.Authority = Root.Value.IdentityServer.Authority;
                        });
            }

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Data Hub Web API", Version = "v1" });
                options.DocumentFilter<ServiceDocumentFilter>();
                options.OperationFilter<AuthorizeCheckOperationFilter>();

                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        Password = new OpenApiOAuthFlow
                        {
                            TokenUrl = new Uri(Root.Value.IdentityServer.Authority.Trim('/') + "/connect/token"),
                        },
                        Implicit = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri(Root.Value.IdentityServer.Authority.Trim('/') + "/connect/authorize"),
                        }
                    }
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

            services.AddControllers(/*options => options.Filters.Add<DynamicAuthorize>()*/)
                        .Add400ProblemDetails()
                        .AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseElasticApm(_configuration, new HttpDiagnosticsSubscriber(), new DbClientDiagnosticsSubscriber());
            app.UseSerilogRequestLogging(opts => opts.EnrichDiagnosticContext = (diagnosticContext, httpContext) =>
            {
                var request = httpContext.Request;
                diagnosticContext.Set("Host", request.Host);
                diagnosticContext.Set("Protocol", request.Protocol);
                diagnosticContext.Set("Scheme", request.Scheme);

                if (request.QueryString.HasValue)
                {
                    diagnosticContext.Set("QueryString", request.QueryString.Value);
                }

                diagnosticContext.Set("ContentType", httpContext.Response.ContentType);

                var endpoint = httpContext.GetEndpoint();
                if (endpoint != null)
                {
                    diagnosticContext.Set("EndpointName", endpoint.DisplayName);
                }

                diagnosticContext.Set("UserId", httpContext.User.Identity.Name);
                diagnosticContext.Set("UserName", httpContext.User.FindFirst("cnname")?.Value);
                diagnosticContext.Set("Scopes", string.Join(",", httpContext.User.FindAll("scope").Select(x => x.Value)));
                diagnosticContext.Set("Roles", string.Join(",", httpContext.User.FindAll("role").Select(x => x.Value)));

                if (Log.IsEnabled(LogEventLevel.Debug))
                {
                    diagnosticContext.Set("Route", string.Join(",", httpContext.Request.RouteValues.Select(x => $"{x.Key}:{x.Value}")));
                    diagnosticContext.Set("Body", httpContext.Request.BodyAsString());
                }
            });

            app.SetupDataHub();
            app.RegisteSwagger2IdentityServer();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Data Hub Web API V1");
                options.OAuthClientId(Root.Value.Server.Name + "-swagger");
            });

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseProblemDetails();
            app.UseCors("AllowAny");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
