using System.Web.Mvc;

namespace Books.Feature.Banner.Controllers
{
    public class BannerController : Controller
    {
        // GET: Banner

        public ActionResult FeaturedGenre()
        {

            return View();
        }
    }
}