using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Arc_CoreUi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.RouteExistingFiles = true;

            routes.MapRoute(
                name: "Tickets",
                url: "incident.html",
                defaults: new { controller = "Ticket", action = "Index", cat = "all" }
            );
            routes.MapRoute(
                name: "TicketsByCat",
                url: "incident-{cat}.html",
                defaults: new { controller = "Ticket", action = "Index", cat = "all", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
