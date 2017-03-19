using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()//Kestrel服务器
                .UseContentRoot(Directory.GetCurrentDirectory())//系统根目录
                .UseIISIntegration()//IIS集成
                .UseStartup<Startup>()//使用过owin的应该就不会陌生
                .UseApplicationInsights()//这好像是一个新的 微软服务?
                .Build();

            host.Run();
        }
    }
}
