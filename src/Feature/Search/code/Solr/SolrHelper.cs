using System.Collections.Generic;
using System.Linq;

using Books.Feature.Search.Models;
using Books.Foundation.Orm.Repo;

using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;

using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.Security;

using Book = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.Base_Book;
using Pages = Books.Foundation.Orm.Models.sitecore.templates.Feature.Navigation.NavigationItem;

namespace Books.Feature.Search.Solr
{
    public class SolrHelper
    {
        public static List<Book> GetBookResults(string searchTerm, IMvcContext context, IRequestContext requestContext)
        {
            SitecoreRepository repo = new SitecoreRepository(requestContext);
            string siteSearchIndexName = context.SitecoreService.Database.Name;
            using (var searchContext = ContentSearchManager.GetIndex("sitecore_" + siteSearchIndexName + "_index").CreateSearchContext(SearchSecurityOptions.DisableSecurityCheck))
            {
                var query = searchContext.GetQueryable<SearchItem>()
                    .Where(i => i.Title.Contains(searchTerm)
                    && i.IsLatestVersion
                    && i.TemplateId == Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.IBase_BookConstants.TemplateId
                    && i.Name != "__Standard Values");

                var results = query.GetResults();

                List<Sitecore.Data.Items.Item> descriptiveVariableName = results.Select(e => e.Document.GetItem()).ToList();
                List<Book> bookList = new List<Book>();
                Book book = new Book();
                foreach (var item in descriptiveVariableName)
                {
                    // Try to get it as a book
                    book = repo.FindById<Book>(item.ID.ToGuid());
                    if (book.Author != null)
                    {
                        bookList.Add(book);
                    }
                }
                return bookList;
            };
        }

        public static List<Pages> GetPageResults(string searchTerm, IMvcContext context, IRequestContext requestContext)
        {
            SitecoreRepository repo = new SitecoreRepository(requestContext);
            string siteSearchIndexName = context.SitecoreService.Database.Name;
            using (var searchContext = ContentSearchManager.GetIndex("sitecore_" + siteSearchIndexName + "_index").CreateSearchContext(SearchSecurityOptions.DisableSecurityCheck))
            {
                var query = searchContext.GetQueryable<SearchItem>()
                    .Where(i => i.Title.Contains(searchTerm)
                    && i.IsLatestVersion
                    && i.TemplateId == Books.Foundation.Orm.Models.sitecore.templates.Feature.Navigation.INavigationItemConstants.TemplateId
                    && i.Name != "__Standard Values");

                var results = query.GetResults();

                List<Sitecore.Data.Items.Item> descriptiveVariableName = results.Select(e => e.Document.GetItem()).ToList();
                Pages page = new Pages();
                List<Pages> pageList = new List<Pages>();
                foreach (var item in descriptiveVariableName)
                {
                    page = repo.FindById<Pages>(item.ID.ToGuid());
                    if (page.Link != null)
                    {
                        pageList.Add(page);
                    }
                }
                return pageList;
            };
        }
    }
}