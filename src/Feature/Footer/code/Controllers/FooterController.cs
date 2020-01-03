using System;
using System.Web.Mvc;

using Books.Feature.Footer.Models;

using Glass.Mapper.Sc.Web.Mvc;

using Sitecore.Mvc.Presentation;

using IBaseFooter = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.IBase_Footer;

namespace Books.Feature.Footer.Controllers
{
    public class FooterController : Controller
    {
        private readonly IMvcContext _context;

        public FooterController(IMvcContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));

        // TODO: Add support for another footer variant
        public ActionResult FooterVariant2() => View();

        public ActionResult StandardFooter()
        {
            if (RenderingContext.Current.Rendering.Item != null)
            {
                var datasource = _context.HasDataSource
                    ? _context.SitecoreService.Cast<IBaseFooter>(_context.DataSourceItem)
                    : _context.GetDataSourceItem<IBaseFooter>();
                return datasource == null ? null : View(_ = new StandardFooterViewModel(datasource));
            }

            return null;
        }
    }
}