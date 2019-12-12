using Books.Feature.Banner.ViewModels;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using System;
using System.Web.Mvc;
using BannerFolder = Books.Foundation.Orm.Models.sitecore.templates.Feature.Banner.IBanner_Folder;
using FeatureItem = Books.Foundation.Orm.Models.sitecore.templates.Feature.Banner.IBanner;

namespace Books.Feature.Banner.Controllers
{
    public class BannerController : Controller
    {
        private readonly IMvcContext _context;

        public BannerController(IMvcContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Featured Genre for the home page
        public ActionResult FeaturedGenre()
        {
            if (RenderingContext.Current.Rendering.Item != null)
            {
                BannerViewModel vm = null;
                var datasource = _context.GetDataSourceItem<FeatureItem>();
                return datasource == null ? null : View(vm = new BannerViewModel(datasource));
            }
            return View();
        }

        public ActionResult GetAllGenres()
        {
            if (RenderingContext.Current.Rendering.Item != null)
            {
                var ds = _context.GetDataSourceItem<BannerFolder>();
                object bannerList = BannerViewModel.GetAllBanners(ds, _context);
                return ds == null ? null : View(bannerList);
            }
            return View();
        }
    }
}