using Books.Feature.Footer.Models;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using System;
using System.Web.Mvc;
using IBaseFooter = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.IBase_Footer;
namespace Books.Feature.Footer.Controllers
{

    public class FooterController : Controller
    {
        private readonly IMvcContext _context;
        public FooterController(IMvcContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public ActionResult StandardFooter()
        {
            if (RenderingContext.Current.Rendering.Item != null)
            {
                StandardFooterViewModel vm = null;
                var datasource = _context.HasDataSource
                    ? _context.SitecoreService.Cast<IBaseFooter>(_context.DataSourceItem)
                    : _context.GetDataSourceItem<IBaseFooter>();
                return datasource == null ? null : View(vm = new StandardFooterViewModel(datasource));
            }

            return null;
        }


        public ActionResult FooterVariant2()
        {
            return View();
        }
    }
}