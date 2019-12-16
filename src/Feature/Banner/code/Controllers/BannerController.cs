using System;
using System.Web.Mvc;

using Books.Feature.Banner.ViewModels;

using Glass.Mapper.Sc.Web.Mvc;

using Sitecore.Mvc.Presentation;

using BannerFolder = Books.Foundation.Orm.Models.sitecore.templates.Feature.Banner.IBanner_Folder;
using FeatureItem = Books.Foundation.Orm.Models.sitecore.templates.Feature.Banner.IBanner;

namespace Books.Feature.Banner.Controllers
{
    public class BannerController : Controller
    {
        private readonly IMvcContext _context;

        public BannerController(IMvcContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));

        // Featured Genre for the home page
        public ActionResult FeaturedGenre()
        {
            return RenderingContext.Current.Rendering.Item != null
                ? _context.GetDataSourceItem<FeatureItem>() == null ? null : View(_ = new BannerViewModel(_context.GetDataSourceItem<FeatureItem>()))
                : View();
        }

        public ActionResult GetAllGenres()
        {
            return RenderingContext.Current.Rendering.Item != null
                ? _context.GetDataSourceItem<BannerFolder>() == null ? null : View(BannerViewModel.GetAllBanners(_context.GetDataSourceItem<BannerFolder>(), _context))
                : View();
        }
    }
}