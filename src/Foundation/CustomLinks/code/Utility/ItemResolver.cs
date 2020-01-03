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

            string path = args.Url.ItemPath.ToLower();
            if (Context.Item == null && Context.Database != null && !string.IsNullOrEmpty(path))
            {
                path = path.Replace("/sitecore/content/home", "/sitecore/content/home/data/book folder");
                path = path.Replace("-", " ");
                Sitecore.Context.Item = Sitecore.Context.Database.GetItem(path);
            }


            //if (args.Url.ItemPath.Contains("/data/book-folder/"))
            //{
            //    string path = MainUtil.DecodeName(args.Url.ItemPath);
            //    Context.Item = args.GetItem(path);
            //    Context.Item.Name = args.Url.ToString().Replace("/data/book-folder/", "/");
            //}

        }
    }
}