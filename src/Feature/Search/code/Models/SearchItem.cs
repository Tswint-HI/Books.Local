using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Runtime.Serialization;


namespace Books.Feature.Search.Models
{
    public class SearchItem : SearchResultItem
    {
        [DataMember]
        [IndexField("_latestversion")]
        public bool IsLatestVersion { get; set; }
        [IndexField("title_t_en")]
        public string Title { get; set; }
        public bool IsStandardValue { get; internal set; }
    }
}
