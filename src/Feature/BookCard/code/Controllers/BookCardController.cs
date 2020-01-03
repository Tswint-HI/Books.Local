using Books.Feature.BookCard.Models;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using System;
using System.Web.Mvc;
using Card = Books.Foundation.Orm.Models.sitecore.templates.Feature.BookCard.IBookCard;

namespace Books.Feature.BookCard.Controllers
{
    public class BookCardController : Controller
    {
        private readonly IMvcContext _context;

        public BookCardController(IMvcContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public ActionResult BookCard()
        {
            if (RenderingContext.Current.Rendering.Item != null)
            {
                BookCardViewModel vm = null;
                var datasource = _context.GetDataSourceItem<Card>();
                return datasource == null ? null : View(vm = new BookCardViewModel(datasource));
            }
            return View();
        }
    }
}