using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B3;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace B3
{
    public class Program
    {
        //Creating a host that runs the App
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        //Here we are creating the host Default Builder and Enviroment is set to "Development"
        //Web server Kastrel is created and integration with IIS
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //Calling StartUp class where we configure our application
                    webBuilder.UseStartup<Startup>();
                });
    }
}

