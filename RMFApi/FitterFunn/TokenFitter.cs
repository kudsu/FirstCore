using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMFApi.FitterFunn
{
    [Serializable, AttributeUsage(AttributeTargets.Method)]
    public class TokenFitter : Attribute, IActionFilter
    {
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            var bb = context.ActionArguments.ContainsKey("id");
            if (true&& context.ActionArguments["id"].ToString()=="3")
            {
            }
            else
            {
                context.HttpContext.Response.Redirect("test/login");
            }
        }
    }
}
