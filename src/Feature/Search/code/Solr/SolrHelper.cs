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
        // Query book types for either author or book name
        public static List<Book> GetBookResults(string searchTerm, IMvcContext context, IRequestContext requestContext)
        {
            var siteSearchIndexName = context.SitecoreService.Database.Name;
            using (var searchContext = ContentSearchManager.GetIndex("sitecore_" + siteSearchIndexName + "_index")
                                                           .CreateSearchContext(SearchSecurityOptions.DisableSecurityCheck))
            {
                var query = searchContext.GetQueryable<SearchItem>()
                    .Where(i => i.Title.Contains(searchTerm)
                    && i.IsLatestVersion
                    && i.TemplateId == Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.IBase_BookConstants.TemplateId
                    && i.Name != "__Standard Values"
                    || i.Author.Contains(searchTerm)).GetResults().Select(e => e.Document.GetItem()).ToList();
                var bookList = new List<Book>();
                var book = new Book();
                foreach (var item in query)
                {
                    // Try to get it as a book
                    book = new SitecoreRepository(requestContext).FindById<Book>(item.ID.ToGuid());
                    if (book.Author != null)
                    {
                        bookList.Add(book);
                    }
                }
                return bookList;
            };
        }

        // Query links and pages
        public static List<Pages> GetPageResults(string searchTerm, IMvcContext context, IRequestContext requestContext)
        {
            var siteSearchIndexName = context.SitecoreService.Database.Name;
            using (var searchContext = ContentSearchManager.GetIndex("sitecore_" + siteSearchIndexName + "_index").CreateSearchContext(SearchSecurityOptions.DisableSecurityCheck))
            {
                var query = searchContext.GetQueryable<SearchItem>()
                    .Where(i => i.Title.Contains(searchTerm)
                    && i.IsLatestVersion
                    && i.TemplateId == Books.Foundation.Orm.Models.sitecore.templates.Feature.Navigation.INavigationItemConstants.TemplateId
                    && i.Name != "__Standard Values").GetResults().Select(e => e.Document.GetItem()).ToList();
                var page = new Pages();
                var pageList = new List<Pages>();
                foreach (var item in query)
                {
                    page = new SitecoreRepository(requestContext).FindById<Pages>(item.ID.ToGuid());
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