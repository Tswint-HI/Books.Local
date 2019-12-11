using Books.Feature.Search.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Web.Mvc;

namespace Books.Feature.Search.Controllers
{
    [RoutePrefix("/search/")]
    public class SearchController : Controller
    {
        private readonly IMvcContext _context;

        public SearchController(IMvcContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public ActionResult Index()
        {

            return View();
        }

        //[HttpPost]
        public ActionResult Results(Data data)
        {
            string termToSearch = data.SearchTerm;
            var items = Solr.SolrHelper.GetResults(termToSearch, _context);
            return View(items);
        }
    }
}