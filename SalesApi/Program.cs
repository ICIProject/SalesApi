using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SalesApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //var host = new WebHostBuilder()
            //    .UseKestrel()
            //   .UseContentRoot(Directory.GetCurrentDirectory())
            //   .UseIISIntegration()
            //   .CaptureStartupErrors(true) // the default
            //                               //.UseSetting("detailedErrors", "true")
            //   .UseStartup<Startup>()              
            //   .Build();
            //host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.UseKestrel()
                .UseStartup<Startup>();
    }
}
