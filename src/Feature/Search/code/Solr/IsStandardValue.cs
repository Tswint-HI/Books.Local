using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace Books.Feature.Search.Solr
{
    public class IsStandardValue : IComputedIndexField
    {
        public string FieldName { get; set; }
        public string ReturnType { get; set; }
        public object ComputeFieldValue(IIndexable indexable)
        {
            Item item = indexable as SitecoreIndexableItem;
            return StandardValuesManager.IsStandardValuesHolder(item);
        }

    }
}