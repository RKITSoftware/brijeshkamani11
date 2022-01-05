using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HttpVerbsDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{movieId}",
                defaults: new { controller = "movies", movieId = RouteParameter.Optional }
            );
        }
    }
}
