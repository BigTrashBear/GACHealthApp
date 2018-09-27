using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GaCHealthApp2
{
    public class Program
    {
        // git test
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        // aaaaaaaaaaaaaaaaaaaaaa

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
