using Books.Feature.BookDetail.ViewlModels;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using System;
using System.Web.Mvc;
using Book = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.IBase_Book;

namespace Books.Feature.BookDetail.Controllers
{
    public class BookDetailController : Controller
    {
        private readonly IMvcContext _context;

        public BookDetailController(IMvcContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // GET: BookDetail
        public ActionResult GetDetail()
        {
            if (RenderingContext.Current.Rendering.Item != null)
            {
                BookViewModel vm = null;
                Book datasource = _context.GetContextItem<Book>();
                return datasource == null ? null : View(vm = new BookViewModel(datasource));
            }
            return View();
        }
    }
}