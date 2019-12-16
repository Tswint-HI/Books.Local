using System;
using System.Web.Mvc;

using Books.Feature.BookCard.Models;

using Glass.Mapper.Sc.Web.Mvc;

using Sitecore.Mvc.Presentation;

using Card = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.IBase_Book;
using Folder = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.Book_Folder;

namespace Books.Feature.BookCard.Controllers
{
    public class BookCardController : Controller
    {
        private readonly IMvcContext _context;

        public BookCardController(IMvcContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));

        public ActionResult BookCard()
        {
            return RenderingContext.Current.Rendering.Item != null
                ? _context.GetDataSourceItem<Card>() == null ? null : View(_ = new BookCardViewModel(_context.GetDataSourceItem<Card>()))
                : View();
        }

        public ActionResult BookCardHighRatings()
        {
            return RenderingContext.Current.Rendering.Item != null
                ? _context.GetDataSourceItem<Folder>() == null ? null : View(BookCardViewModel.GetBooksWithHighestRating(_context.GetDataSourceItem<Folder>()))
                : View();
        }

        public ActionResult BooksByGenre()
        {
            return RenderingContext.Current.Rendering.Item != null
                ? _context.GetDataSourceItem<Folder>() == null ? null : View(BookCardViewModel.AllBooks(_context.GetDataSourceItem<Folder>(), _context))
                : View();
        }
    }
}