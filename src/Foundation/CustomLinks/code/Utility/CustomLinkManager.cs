using Sitecore.Links;

namespace Books.Foundation.CustomLinks.Utility
{
    public class CustomLinkManager : LinkProvider
    {
        public override string GetItemUrl(Sitecore.Data.Items.Item item, UrlOptions options)
        {
            return base.GetItemUrl(item, options).ToLower().Replace("/data/book-folder/", string.Empty);
            //if (HttpContext.Current.Request.Url.ToString().ToLowerInvariant().Contains("/data/book-folder/"))
            //{
            //    HttpContext.Current.Request.Url.ToString().Replace("/data/book-folder/", "/");
            //}
            //var url = base.GetItemUrl(item, options);
            //if (url.Contains("/data/book-folder/"))
            //{
            //    //do some shit here
            //}
            ////Example customisation which lowercases all URLs
            //return !string.IsNullOrEmpty(url) ? url.ToLower() : url;
        }
    }
}