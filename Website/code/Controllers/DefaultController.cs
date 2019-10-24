using System.Web.Mvc;

namespace Books.Project.Web.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            double a = 32.4;
            a = 4.34;
            return View(a);
        }
    }
}