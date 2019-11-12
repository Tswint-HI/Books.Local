using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Web.Mvc;

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

            return View();
        }
    }
}