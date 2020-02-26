using System;
using System.Web.Mvc;

using Books.Feature.BookCard.Models;

using Glass.Mapper.Sc.Web.Mvc;

using Sitecore.Mvc.Presentation;

using Card = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.IBase_Book;
using Folder = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.Book_Folder;
using Header = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.Special_Heading;

namespace Books.Feature.BookCard.Controllers
{
    public class BookCardController : Controller
    {
        private readonly IMvcContext _context;

        public BookCardController(IMvcContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));

        // Single Card
        public ActionResult BookCard() =>
            RenderingContext.Current.Rendering.Item != null
                ? _context.GetDataSourceItem<Card>() == null ? null : View(_ = new BookCardViewModel(_context.GetDataSourceItem<Card>()))
                : View();

        // Gets only the books that match criteria
        public ActionResult BookCardHighRatings() =>
            RenderingContext.Current.Rendering.Item != null
                ? _context.GetDataSourceItem<Folder>() == null ? null : View(BookCardViewModel.GetBooksWithHighestRating(_context.GetDataSourceItem<Folder>()))
                : View();

        // Gets books of specified genre
        public ActionResult BooksByGenre() =>
            RenderingContext.Current.Rendering.Item != null
                ? _context.GetDataSourceItem<Folder>() == null ? null : View(BookCardViewModel.AllBooks(_context.GetDataSourceItem<Folder>(), _context))
                : View();

        // Gets the Book card Heading
        public ActionResult Heading() => RenderingContext.Current.Rendering.Item != null ? View(new HeaderViewModel(_context.GetDataSourceItem<Header>())) : null;
    }
}