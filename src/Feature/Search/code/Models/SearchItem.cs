using System.Runtime.Serialization;

using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;

namespace Books.Feature.Search.Models
{
    public class SearchItem : SearchResultItem
    {
        [IndexField("author_t_en")]
        public string Author { get; set; }

        [DataMember]
        [IndexField("_latestversion")]
        public bool IsLatestVersion { get; set; }

        public bool IsStandardValue { get; internal set; }

        [IndexField("title_t_en")]
        public string Title { get; set; }
    }
}