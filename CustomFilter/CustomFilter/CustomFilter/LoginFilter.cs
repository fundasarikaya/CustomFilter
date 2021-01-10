using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomFilter.CustomFilter
{
    public class LoginFilter : FilterAttribute, IActionFilter
    {
        //action method tetiklendiginde onactionexecuted methodu devreye girer
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var SessionControl = context.HttpContext.Session["Kullanici"];
            if (SessionControl == null)
            {
                context.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary { { "Controller", "Account" }, { "Action", "Login" } });
            }
        }
        //action method calıştırıldıktan sonra devreye girer
        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}