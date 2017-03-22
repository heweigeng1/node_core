using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Extensions
{
    public static class ConsoleText
    {
        public static void Write(this IApplicationBuilder app ,string msg)
        {
            dynamic dic;
            app.Run((context) => {
                dic = context.Response.StatusCode;
                Console.WriteLine($"msg:{ context.Response.StatusCode}");
                return null;
            });
            int i = 100;
        }
    }
}
