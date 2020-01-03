using Sitecore.Links;

namespace Books.Foundation.CustomLinks.Utility
{
    public class CustomLinkManager : LinkProvider
    {
        private const string _apiPathtoRemove = "/api/sitecore/";
        private const string _pathToRemove = "/data/book-folder/";

        public override string GetItemUrl(Sitecore.Data.Items.Item item, UrlOptions options)
        {
            // Ensure path is relative regarding Bookdeail page....everything else leave alone
            var url = base.GetItemUrl(item, options).ToLower();
            return url.Contains(_pathToRemove)
                ? "/" + url.Replace(_pathToRemove, string.Empty)
                : url.Contains(_apiPathtoRemove) ? "/" + url.Replace(_apiPathtoRemove, string.Empty) : url;
        }
    }
}