using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DatingApp.API
{
    public class Program
    {
        //entry point
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }
        //use Kestrel as the web server and configure it using the application's configuration
        //Web sunucusu olarak lightweight bir kod kullanılıyor. (IIS yada apache kadar kuvvetli değil)
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }
}
