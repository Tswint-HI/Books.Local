using Books.Foundation.Assets.Models;
using Books.Foundation.Assets.Repo;
using System;
using System.Linq;
using System.Text;
using System.Web;

namespace Books.Foundation.Assets.Service
{
    public class RenderAssetsService
    {
        private static RenderAssetsService _current;
        public static RenderAssetsService Current => _current ?? (_current = new RenderAssetsService());

        public HtmlString RenderScript(ScriptLocation location)
        {
            var assets = AssetRepository.Current.Items.Where(asset => (asset.Type == AssetType.JavaScript || asset.Type == AssetType.Raw) && asset.Location == location && this.IsForContextSite(asset));

            StringBuilder sb = new StringBuilder();
            foreach (var item in assets)
            {
                if (item.Type == AssetType.Raw)
                {
                    sb.Append(item.Content).AppendLine();
                }
                else
                {
                    switch (item.ContentType)
                    {
                        case AssetContentType.File:
                            sb.AppendFormat("<script src=\"{0}\"></script>", item.Content).AppendLine();
                            break;
                        case AssetContentType.Inline:
                            if (item.Type == AssetType.Raw)
                            {
                                sb.AppendLine(HttpUtility.HtmlDecode(item.Content));
                            }
                            else
                            {
                                sb.AppendLine("<script>\njQuery(document).ready(function() {");
                                sb.AppendLine(item.Content);
                                sb.AppendLine("});\n</script>");
                            }
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
            return new HtmlString(sb.ToString());
        }

        public HtmlString RenderStyles()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in AssetRepository.Current.Items.Where(asset => asset.Type == AssetType.Css && this.IsForContextSite(asset)))
            {
                switch (item.ContentType)
                {
                    case AssetContentType.File:
                        sb.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" />", item.Content).AppendLine();
                        break;
                    case AssetContentType.Inline:
                        sb.AppendLine("<style type=\"text/css\">");
                        sb.AppendLine(item.Content);
                        sb.AppendLine("</style>");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return new HtmlString(sb.ToString());
        }

        private bool IsForContextSite(Asset asset)
        {
            if (asset.Site == null)
            {
                return true;
            }

            foreach (string part in asset.Site.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string siteWildcard = part.Trim().ToLowerInvariant();
                if (siteWildcard == "*" || Sitecore.Context.Site.Name.Equals(siteWildcard, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}