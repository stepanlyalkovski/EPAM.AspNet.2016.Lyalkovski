using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
namespace WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "StaticRoute",
                url: "Static/Home/{message}",
                defaults: new { controller = "Static", action = "Index", message = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "JsonService",
                url: "Service/{action}/{id}",
                defaults: new { controller = "Service", action = "Index", id = UrlParameter.Optional },
                namespaces:new [] { "JsonService.Controllers" }
            );
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            

        }
    }
}
