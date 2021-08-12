using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NerdVision;

namespace nerdvision.api.test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("NV_KEY")))
                NV.Start(Environment.GetEnvironmentVariable("NV_KEY"));

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
