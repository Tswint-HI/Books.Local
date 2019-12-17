using System;
using System.Web.Mvc;

using Books.Feature.Carousel.Models;
using Books.Foundation.Orm.Repo;

using Glass.Mapper.Sc.Web.Mvc;

using ICarousel = Books.Foundation.Orm.Models.sitecore.templates.Feature.Carousel.Carousel_Content.ICarousel;

namespace Books.Feature.Carousel.Controllers
{
    public class CarouselController : Controller
    {
        private readonly IMvcContext _context;
        public SitecoreRepository _repository;

        public CarouselController(IMvcContext context, SitecoreRepository repo)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _repository = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        // Standard Carousel
        public ActionResult GetCarousel() => _context.GetDataSourceItem<ICarousel>() == null ? null : View(new CarouselViewModel(_context.GetDataSourceItem<ICarousel>()));
    }
}