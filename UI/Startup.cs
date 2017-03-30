using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using UI.Extensions;
using UI.DI;

namespace UI
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()//添加一个配置
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();//添加MVC服务
            services.AddTransient<IDateTime, SystemDateTime>();//配置关系
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();
            var logger = loggerFactory.CreateLogger("Catchall Endpoint");
            logger.LogInformation("No endpoint found for request {path}", "test");
            
            if (env.IsDevelopment())//开发状态
            {
                app.UseDeveloperExceptionPage();//捕获异常,并生成html页面
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");//捕获管道中的异常,并重定到指定的错误页
            }
            //app.Write("测试");
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "deflut",
                    template: "{controller=Home}/{action=Index}/{id?}"
                        );
            });
        }

        public void Test(IApplicationBuilder app)
        {
        }
    }
}
