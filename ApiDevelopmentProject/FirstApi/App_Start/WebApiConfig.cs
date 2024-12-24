using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FirstApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Custom route for MyFirstApiController

            config.Routes.MapHttpRoute(
           name: "DefaultLandingPage",
           routeTemplate: "",
           defaults: new { controller = "MyFirstApi", action = "Index" }
       );


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
