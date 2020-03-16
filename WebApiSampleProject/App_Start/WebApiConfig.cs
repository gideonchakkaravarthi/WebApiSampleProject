﻿using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiSampleProject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
        
            //EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");          
              config.EnableCors();

            // config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
