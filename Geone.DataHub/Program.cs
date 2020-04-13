using Geone.DataHub.AspNetCore.Config;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.AspNetCore;
using Serilog.Events;
using System;
using System.IO;
using Microsoft.Extensions.Logging;

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
                    webBuilder.CaptureStartupErrors(true)
                              .UseSetting("detailedErrors", "true")
                              .UseUrls(RootConfig.Read().Server.ToString())
                              .UseStartup<Startup>()
                              .ConfigureLogging(builder =>
                              {
                                  builder.ClearProviders();
                                  builder.AddSerilog(dispose: true);
                              })
                              .UseSerilog((context, configuration) =>
                              {
                                  configuration.ReadFrom.Configuration(context.Configuration, "Serilog");
                              });
                });
    }
}
