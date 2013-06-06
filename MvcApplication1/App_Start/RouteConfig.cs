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
                name: "Patient_Update",
                url: "Patient/Update/{id}",
                defaults: new { controller = "Patient", action = "Update", id="" }
            );

            routes.MapRoute(
                name: "Patient_removePassword",
                url: "Patient/removePassword/{id}",
                defaults: new { controller = "Patient", action = "removePassword", id = "" }
            );

            routes.MapRoute(
                name: "Patient_setPassword",
                url: "Patient/setPassword/{id}",
                defaults: new { controller = "Patient", action = "setPassword", id = "" }
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
                name: "Visit_Create",
                url: "Visit",
                defaults: new { controller = "Visit", action = "Create" }
            );
            
            routes.MapRoute(
                name: "Visit_getSettings",
                url: "Visit/getsettings",
                defaults: new { controller = "Visit", action = "getSettings" }
            );

            routes.MapRoute(
                name: "Visit_getServices",
                url: "Visit/getServices",
                defaults: new { controller = "Visit", action = "getServices" }
            );

            routes.MapRoute(
                name: "Visit",
                url: "Visit/{id}",
                defaults: new { controller = "Visit", action = "Index", id = "" }
            );

            routes.MapRoute(
                name: "Visit_Update",
                url: "Visit/Update/{id}",
                defaults: new { controller = "Visit", action = "Update", id = "" }
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
                name: "Practitioner_Update",
                url: "Practitioner/Update/{id}",
                defaults: new { controller = "Practitioner", action = "Update", id = "" }
            );
            
            routes.MapRoute(
                name: "Practitioner_setPassword",
                url: "Practitioner/setPassword/{id}",
                defaults: new { controller = "Practitioner", action = "setPassword", id = "" }
            );

            routes.MapRoute(
                name: "Practitioner_removePassword",
                url: "Practitioner/removePassword/{id}",
                defaults: new { controller = "Practitioner", action = "removePassword", id = "" }
            );

            routes.MapRoute(
               name: "Register_LoginClient",
               url: "Login/register/{response_uri}",
               defaults: new { controller = "Login", action = "registerClient" }
           );

            routes.MapRoute(
               name: "Authorize_Login",
               url: "Login/authorize/",
               defaults: new { controller = "Login", action = "AuthorizeLogin" }
           );

           
            routes.MapRoute(
                name: "Validate_Token",
                url: "Login/validatetoken/",
                defaults: new { controller = "Login", action = "isTokenValid" }
            );

            routes.MapRoute(
                name: "Get_Notifications_byUserId",
                url: "Notifications/byUserId/{id}",
                defaults: new { controller = "Notifications", action = "byUserId", id="" }
            );

            routes.MapRoute(
                name: "Mark_Notification_Read",
                url: "Notifications/markread/",
                defaults: new { controller = "Notifications", action = "markRead" }
            );

            routes.MapRoute(
                name: "Add_Notification",
                url: "Notifications/add/",
                defaults: new { controller = "Notifications", action = "add" }
            );

            routes.MapRoute(
               name: "Contact",
               url: "Contact/{id}",
               defaults: new { controller = "Contact", action = "Index", id = "" }
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