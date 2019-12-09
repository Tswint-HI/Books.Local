using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;
using Sitecore.Pipelines;

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
            RouteTable.Routes.MapRoute("CustomRoute", "api/testing/{controller}/{action}");
        }
    }
}