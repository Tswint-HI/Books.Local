﻿using Sitecore.Diagnostics;
using Sitecore.Pipelines.HttpRequest;
using System.Web;

namespace Books.Foundation.CustomErrors.Pipelines
{
    public class Custom404Resolver : HttpRequestProcessor
    {

        public override void Process(HttpRequestArgs args)
        {
            Assert.ArgumentNotNull(args, "args");

            var url = HttpContext.Current.Request.Url;
            var siteContext = Sitecore.Sites.SiteContextFactory.GetSiteContext(url.Host, url.PathAndQuery);
            string path404 = siteContext.StartPath + "/404";


            // Do nothing if the item is actually found
            if ((Sitecore.Context.Item != null && !Sitecore.Context.Item.Paths.Path.Equals(path404)) || Sitecore.Context.Database == null)
                return;

            // all the icons and media library items 
            // for the sitecore client need to be ignored
            if (args.Url.FilePath.StartsWith("/-/"))
                return;

            // Get the 404 not found item in Sitecore.
            // You can add more complex code to get the 404 item 
            // from multisite solutions. In a production 
            // environment you would probably get the item from
            // your website configuration.

            var notFoundPage = Sitecore.Context.Database.GetItem(path404);
            if (notFoundPage == null)
                return;

            // Switch to the 404 item
            Sitecore.Context.Item = notFoundPage;
        }
    }
}