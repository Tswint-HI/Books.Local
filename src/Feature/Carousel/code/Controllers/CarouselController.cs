using Books.Feature.Carousel.Models;
using Books.Foundation.Orm.Repo;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Web.Mvc;

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
        // GET: Carousel
        public ActionResult GetCarousel()
        {
            var dataSource = _context.GetDataSourceItem<Foundation.Orm.Models.sitecore.templates.Feature.Carousel.Carousel_Content.ICarousel>();
            if (dataSource == null)
                return null;

            CarouselViewModel viewModel = new CarouselViewModel(dataSource);

            return View(viewModel);
        }
    }
}