using System.Web.Mvc;
using System.Web.Routing;

using Sitecore.Pipelines;

namespace Books.Feature.Search.App_Start
{
    public class RegisterCustomRoute
    {
        public static void Register()
        {
            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.MapRoute("CustomRoute", "bookapi/{controller}/{action}",
                new { Controller = "Search", Action = "Index", Id = UrlParameter.Optional });
        }

        public virtual void Process(PipelineArgs args) => Register();
    }
}