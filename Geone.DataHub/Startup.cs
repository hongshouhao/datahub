using Elastic.Apm.AspNetCore;
using Elastic.Apm.DiagnosticSource;
using Geone.DataHub.AspNetCore.Config;
using Geone.DataHub.AspNetCore.Swagger;
using Geone.DataHub.Core.APM;
using Geone.DataHub.Core.Exceptions;
using Geone.IdentityServer4.Client;
using Hellang.Middleware.ProblemDetails;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Events;
using System;
using System.Linq;

namespace Geone.DataHub
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDataHub(_environment.WebRootPath);
            services.AddHttpClient();
            services.AddHttpContextAccessor();

            if (!string.IsNullOrWhiteSpace(AppSettings.Value.IdentityServer?.Authority))
            {
                services.AddAuthorization(x =>
                {
                    x.DefaultPolicy = new AuthorizationPolicyBuilder("Bearer")
                        .RequireRole("administrator", "admin")
                        .Build();
                });

                services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                        .AddIdentityServerAuthentication(options =>
                        {
                            options.RequireHttpsMetadata = false;
                            options.RoleClaimType = "role";
                            options.NameClaimType = "name";
                            options.ApiName = AppSettings.Value.Server.Name;
                            options.ApiSecret = AppSettings.Value.Server.ApiSecret;
                            options.Authority = AppSettings.Value.IdentityServer.Authority;
                        });
            }
            else
            {
                services.AddAuthorization(x =>
                {
                    x.DefaultPolicy = new AuthorizationPolicyBuilder()
                        .RequireAssertion(_ => true)
                        .Build();
                });
            }

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Data Hub Web API", Version = "v1" });
                options.DocumentFilter<ServiceDocumentFilter>();
                options.OperationFilter<AuthorizeCheckOperationFilter>();
                options.MapType(typeof(IFormFile), () => new OpenApiSchema() { Type = "file", Format = "binary" });

                if (!string.IsNullOrWhiteSpace(AppSettings.Value.IdentityServer?.Authority))
                {
                    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                    {
                        Type = SecuritySchemeType.OAuth2,
                        Flows = new OpenApiOAuthFlows
                        {
                            Password = new OpenApiOAuthFlow
                            {
                                TokenUrl = new Uri(AppSettings.Value.IdentityServer.Authority.Trim('/') + "/connect/token"),
                            },
                            Implicit = new OpenApiOAuthFlow
                            {
                                AuthorizationUrl = new Uri(AppSettings.Value.IdentityServer.Authority.Trim('/') + "/connect/authorize"),
                            }
                        }
                    });
                }

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
                diagnosticContext.Set("IP", request.Host.Host);
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
                    diagnosticContext.Set("Route", string.Join(",", request.RouteValues.Select(x => $"{x.Key}:{x.Value}")));
                    diagnosticContext.Set("Body", request.BodyAsString());
                }
                else if (httpContext.Response.StatusCode == 500)
                {
                    request.BodyReader.TryRead(out System.IO.Pipelines.ReadResult result);
                    diagnosticContext.Set("Body", request.BodyAsString());
                }
            });

            app.SetupDataHub();
            app.RegisteSwagger2IdentityServer();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                string swaggerEndpoint = "/swagger/v1/swagger.json";
                if (!string.IsNullOrWhiteSpace(AppSettings.Value.Server.VirtualPath))
                {
                    swaggerEndpoint = "/" + AppSettings.Value.Server.VirtualPath + swaggerEndpoint;
                }

                options.SwaggerEndpoint(swaggerEndpoint, "Data Hub Web API V1");
                options.OAuthClientId(AppSettings.Value.Server.Name + "-swagger");
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
