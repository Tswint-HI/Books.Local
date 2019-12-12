using Books.Feature.Navigation.ViewModels;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using System;
using System.Web.Mvc;

namespace Books.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        private readonly IMvcContext _context;

        public NavigationController(IMvcContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public ActionResult getNav()
        {
            if (RenderingContext.Current.Rendering.Item != null)
            {
                var dataSource = _context.GetDataSourceItem<Foundation.Orm.Models.sitecore.templates.Feature.Navigation.INavigation_Links_Folder>();
                if (dataSource == null)
                    return null;

                HeaderViewModel viewModel = new HeaderViewModel(dataSource, _context);
                return View(viewModel);
            }
            return null;
        }
    }
}