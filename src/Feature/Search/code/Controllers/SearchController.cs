using System;
using System.Linq;
using System.Web.Mvc;

using Books.Feature.Search.Models;

using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;

namespace Books.Feature.Search.Controllers
{
    public class SearchController : Controller
    {
        private readonly IMvcContext _context;
        private readonly IRequestContext _sitecoreRequestContext;

        public SearchController(IMvcContext context, IRequestContext requestContext)
        {
            _sitecoreRequestContext = requestContext ?? throw new ArgumentNullException(nameof(requestContext));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public ActionResult Index(Data data)
        {
            try
            {
                var model = new ResponseItem();
                if (!string.IsNullOrEmpty(data.SearchTerm))
                {
                    var bookitems = Solr.SolrHelper.GetBookResults(data.SearchTerm, _context, _sitecoreRequestContext);
                    var pageItems = Solr.SolrHelper.GetPageResults(data.SearchTerm, _context, _sitecoreRequestContext);
                    if (bookitems.Any())
                    {
                        model.Books = bookitems;
                    }
                    if (pageItems.Any())
                    {
                        model.Pages = pageItems;
                    }
                    return View(model);
                }
                else
                {
                    model.Message = _context.GetContextItem<Foundation.Orm.Models.sitecore.templates.User_Defined.Base.IBasePage>().Message;
                    return View(model);
                }
            }
            catch (System.NotSupportedException ex)
            {
                Sitecore.Diagnostics.Log.Error("There was an issue with Solr or your Response item + ", ex);
            }

            return null;
        }
    }
}