using Books.Feature.Footer.Models;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using System;
using System.Web.Mvc;

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
                var home = _context.GetHomeItem<Foundation.Orm.Models.sitecore.templates.Project.Page_Types.IHome>();
                StandardFooterViewModel vm = new StandardFooterViewModel(_context);
                return View();
            }

            return null;
        }


        public ActionResult FooterVariant2()
        {

            return View();
        }
    }
}