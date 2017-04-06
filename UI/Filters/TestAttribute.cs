using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Filters
{
    public class TestAttribute : ActionFilterAttribute
    {
        private readonly string _name;
        private readonly string _value;
        public TestAttribute(string name, string value)
        {
            _name = $"hello{name}";
            _value = $"{value}";
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add(_name, new string[] { _value });
            base.OnActionExecuted(context);
        }
    }
}
