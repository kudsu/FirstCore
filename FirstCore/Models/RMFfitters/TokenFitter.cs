using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models.RMFfitters
{
    [Serializable, AttributeUsage(AttributeTargets.Method)]
    public class TokenFitter:Attribute, IActionFilter
    {
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            //写业务逻辑处理，【例子：只有uid=1或3才能获取数据，否则跳转到其他页面（404）】
            //var r = context.HttpContext.Request.Query.TryGetValue("uid", out Microsoft.Extensions.Primitives.StringValues value);
            if (true)
            {
            }
            //else
            //{
            //    context.HttpContext.Response.Redirect("test/login");
            //}
        }
    }
}
