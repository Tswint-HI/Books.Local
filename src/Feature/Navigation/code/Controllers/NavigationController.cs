using System;
using System.Web.Mvc;

using Books.Feature.Navigation.ViewModels;

using Glass.Mapper.Sc.Web.Mvc;

using Sitecore.Mvc.Presentation;

using LinksFolder = Books.Foundation.Orm.Models.sitecore.templates.Feature.Navigation.INavigation_Links_Folder;

namespace Books.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        private readonly IMvcContext _context;

        public NavigationController(IMvcContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));

        public ActionResult GetNav() =>
            RenderingContext.Current.Rendering.Item != null
                ? _context.GetDataSourceItem<LinksFolder>() == null
                    ? null
                    : View(new HeaderViewModel(_context.GetDataSourceItem<LinksFolder>(), _context))
                : null;
    }
}