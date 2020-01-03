using System;
using System.Web.Mvc;

using Books.Foundation.Orm.Repo;

using Errors = Books.Foundation.Orm.Models.sitecore.templates.Project.Page_Types.Error;

namespace Books.Feature.Error.Controllers
{
    public class ErrorController : Controller
    {
        public SitecoreRepository Repository { get; set; }

        public ErrorController(SitecoreRepository repository) => Repository = repository;

        // GET: Error
        public ActionResult Index()
        {
            try
            {
                var model = Repository.FindById<Errors>(Sitecore.Context.Item.ID.Guid);
            }
            catch (Exception ex)
            {
                Sitecore.Diagnostics.Log.Error("UH OH", ex);
            }
            return View((object)null);
        }
    }
}