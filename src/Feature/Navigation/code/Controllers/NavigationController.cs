using System;
using System.Web.Mvc;

using Books.Feature.Navigation.ViewModels;

using Glass.Mapper.Sc.Web.Mvc;

using Sitecore.Mvc.Presentation;

namespace Books.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        private readonly IMvcContext _context;

        public NavigationController(IMvcContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));

        public ActionResult GetNav()
        {
            return RenderingContext.Current.Rendering.Item != null
                ? _context.GetDataSourceItem<Foundation.Orm.Models.sitecore.templates.Feature.Navigation.INavigation_Links_Folder>() == null
                    ? null
                    : View(new HeaderViewModel(_context.GetDataSourceItem<Foundation.Orm.Models.sitecore.templates.Feature.Navigation.INavigation_Links_Folder>(), _context))
                : null;
        }
    }
}