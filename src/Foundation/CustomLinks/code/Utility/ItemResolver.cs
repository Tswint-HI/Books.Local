using Sitecore;
using Sitecore.Diagnostics;
using Sitecore.Pipelines.HttpRequest;

namespace Books.Foundation.CustomLinks.Utility
{
    public class ItemResolver : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            Assert.ArgumentNotNull(args, "args");

            var path = args.Url.ItemPath.ToLower();
            // If its the item im tageting *Books* update path and set the contextitem
            if (Context.Item == null && Context.Database != null && !string.IsNullOrEmpty(path))
            {
                path = path.Replace("/sitecore/content/home", "/sitecore/content/home/data/book folder");
                path = path.Replace("-", " ");
                Sitecore.Context.Item = Sitecore.Context.Database.GetItem(path);
            }
        }
    }
}