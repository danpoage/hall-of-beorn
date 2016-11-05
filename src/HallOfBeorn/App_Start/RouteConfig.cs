using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HallOfBeorn
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.html");
            routes.IgnoreRoute("{resource}.ico");
            routes.IgnoreRoute("Content/{resource}.css");
            routes.IgnoreRoute("Content/fonts/{resource}.ttf");
            routes.IgnoreRoute("Content/themes/base/{resource}.css");
            routes.IgnoreRoute("Content/themes/base/images/{resource}.png");
            routes.IgnoreRoute("Content/themes/base/minified/images/{resource}.png");
            routes.IgnoreRoute("Content/themes/base/minified/{resource}.css");
            routes.IgnoreRoute("Scripts/{resource}.js");
            routes.IgnoreRoute("Images/Arkham/{resource}.jpg");
            routes.IgnoreRoute("Images/Arkham/{resource}.png");
            routes.IgnoreRoute("Images/Arkham/{resource}.gif");
            routes.IgnoreRoute("Images/{resource}.jpg");
            routes.IgnoreRoute("Images/{resource}.png");
            routes.IgnoreRoute("Images/{resource}.gif");

            routes.RouteExistingFiles = true;

            routes.MapRoute(
                "LotRDefaultRoute",
                "LotR/{action}/{id}",
                new { controller = "LotR", action = "Search", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "LotRLegacyRoute",
                "Cards/{action}/{id}",
                new { controller = "LotR", action = "Search", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "ArkhamDefaultRoute",
                "Arkham/{action}/{id}",
                new { controller = "Arkham", action = "Search", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "CardImageRoute",
                "Images/Cards/{setName}/{imageName}",
                new { controller = "Image", action = "GetCardImage", setName = UrlParameter.Optional, imageName = UrlParameter.Optional }
            );

            routes.MapRoute(
                "ProductImageRoute",
                "Images/Products/{imageName}",
                new { controller = "Image", action = "GetProductImage", imageName = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "RootRoute",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "ExportSearch",
                "Export/Search",
                new { controller = "Export", action = "Search" }
            );

            routes.MapRoute(
                "Export",
                "Export/{name}",
                new { controller = "Export", action = "Get" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}