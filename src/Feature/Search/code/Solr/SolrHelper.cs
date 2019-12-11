using Books.Feature.Search.Models;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.Security;
using System.Collections.Generic;
using System.Linq;

namespace Books.Feature.Search.Solr
{
    public class SolrHelper
    {

        public static List<Sitecore.Data.Items.Item> GetResults(string searchTerm, IMvcContext context)
        {
            string siteSearchIndexName = context.SitecoreService.Database.Name;
            using (var searchContext = ContentSearchManager.GetIndex("sitecore_" + siteSearchIndexName + "_index").CreateSearchContext(SearchSecurityOptions.DisableSecurityCheck))
            {
                var query = searchContext.GetQueryable<SearchItem>()
                    .Where(i => i.Title.Contains(searchTerm)
                    && i.IsLatestVersion
                    && i.TemplateId == Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.IBase_BookConstants.TemplateId
                    && i.Name != "__Standard Values");
                //query = query.Page(1, 20);
                var results = query.GetResults();

                return results.Select(e => e.Document.GetItem()).ToList();
            };
        }
    }
}