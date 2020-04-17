/*
 * Author: William Raymann.
 * Class: Program.
 * Purpose: To start the Cowboy Cafe website.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Website
{
    /// <summary>
    /// The program for the Cowboy Cafe website.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main function for the Cowboy Cafe website.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Configures the Cowboy Cafe web server based on specifications provided by the Startup class.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
