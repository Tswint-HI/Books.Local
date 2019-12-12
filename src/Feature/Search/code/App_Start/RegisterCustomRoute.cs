using Sitecore.Pipelines;
using System.Web.Mvc;
using System.Web.Routing;

namespace Books.Feature.Search.App_Start
{
    public class RegisterCustomRoute
    {
        public virtual void Process(PipelineArgs args)
        {
            Register();
        }

        public static void Register()
        {
            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.MapRoute("CustomRoute", "bookapi/{controller}/{action}",
                new { Controller = "Search", Action = "Index", Id = UrlParameter.Optional });
        }
    }
}