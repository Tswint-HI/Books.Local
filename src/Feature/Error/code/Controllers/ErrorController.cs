using Books.Foundation.Orm.Repo;
using System;
using System.Web.Mvc;
using Errors = Books.Foundation.Orm.Models.sitecore.templates.Project.Page_Types.Error;

namespace Books.Feature.Error.Controllers
{
    public class ErrorController : Controller
    {
        public SitecoreRepository Repository { get; set; }

        public ErrorController(SitecoreRepository repository)
        {
            this.Repository = repository;
        }

        // GET: Error
        public ActionResult Index()
        {
            Errors model = null;
            var contextId = Sitecore.Context.Item.ID.Guid;
            try
            {
                model = Repository.FindById<Errors>(contextId);
            }
            catch (Exception ex)
            {
                Sitecore.Diagnostics.Log.Error("UH OH", ex);
            }
            return View(model);
        }
    }
}