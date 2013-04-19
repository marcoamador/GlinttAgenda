using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Patient_Search",
                url: "Patient/Search",
                defaults: new { controller = "Patient", action = "Search" }
            );

            routes.MapRoute(
                name: "Patient",
                url: "Patient/{id}",
                defaults: new { controller = "Patient", action = "Index", id = "" }
            );

            routes.MapRoute(
                name: "Visit_Search",
                url: "Visit/Search",
                defaults: new { controller = "Visit", action = "Search" }
            );

            routes.MapRoute(
                name: "Visit",
                url: "Visit/{id}",
                defaults: new { controller = "Visit", action = "Index", id = "" }
            );

            routes.MapRoute(
                name: "Practitioner_Search",
                url: "Practitioner/Search",
                defaults: new { controller = "Practitioner", action = "Search" }
            );

            routes.MapRoute(
                name: "Practitioner",
                url: "Practitioner/{id}",
                defaults: new { controller = "Practitioner", action = "Index", id = "" }
            );

           routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


          

            /*routes.MapRoute(
              name: "Default1",
              url: "{resource}/{res_action}/{id}",
              defaults: new { controller = "Home", action = "Hello", id = "0", resource="",res_action=""}
          );*/
        }
    }
}