using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace RowingLookbook_backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


            //var builder = new WebHostBuilder()
            //       .UseContentRoot(Directory.GetCurrentDirectory())
            //       .UseKestrel()
            //       .ConfigureKestrel(options =>
            //       {
            //           foreach (var p in new[] { 2004 })
            //           {
            //               options.ListenAnyIP(p, listenOptions =>
            //           {
            //               listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
            //           });
            //           }
            //       })
            //       .UseStartup<Startup>();
            //return builder;


        }
    }
}
