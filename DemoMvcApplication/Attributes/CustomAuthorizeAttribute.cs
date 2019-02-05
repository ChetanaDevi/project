using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMvcApplication.Attributes
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
       
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if(HttpContext.Current.Session["User"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                                        new System.Web.Routing.RouteValueDictionary(
                                            new { Controller="Error", Action="AccessDenied" }));
            }
            return;
        }
    }
}