using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Filters
{
    public class TestActionFilters : IActionFilter
    {
        /// <summary>
        /// 在管道后执行
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var path = context.HttpContext.Request.Path.Value;
            Console.WriteLine(path);
        }
        /// <summary>
        /// 在执行管道前执行
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var path = context.HttpContext.Request.QueryString.Value;
            Console.WriteLine(path);
        }
    }
}
