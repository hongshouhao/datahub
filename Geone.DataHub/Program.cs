using Elastic.Apm.SerilogEnricher;
using Geone.DataHub.AspNetCore.Config;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System.Diagnostics;

namespace Geone.DataHub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    AppSettings.Read();
                    IWebHostBuilder webHostBuilder = webBuilder.CaptureStartupErrors(true)
                              .UseIISIntegration()
                              .UseKestrel()
                              .UseSetting("detailedErrors", "true")
                              .UseStartup<Startup>()
                              .ConfigureLogging(builder =>
                              {
                                  builder.ClearProviders();
                                  builder.AddSerilog(dispose: true);
                              })
                              .UseSerilog((context, configuration) =>
                              {
                                  configuration.ReadFrom.Configuration(context.Configuration, "Serilog")
                                    .Enrich.WithElasticApmCorrelationInfo();
                              });

                    Process cur = Process.GetCurrentProcess();
                    if (cur.ProcessName != "w3wp")
                    {
                        webHostBuilder.UseUrls(AppSettings.Value.Server.ToString());
                    }
                });
    }
}
