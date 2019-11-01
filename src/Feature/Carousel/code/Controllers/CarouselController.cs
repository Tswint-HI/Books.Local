using Books.Feature.Carousel.Models;
using Books.Foundation.Orm.Models.sitecore.templates.Feature.Carousel;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Books.Feature.Carousel.Controllers
{
    public class CarouselController : Controller
    {

        private readonly IMvcContext _context;
        public CarouselController(IMvcContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        // GET: Carousel
        public ActionResult GetCarousel()
        {
            var dataSource = _context.GetDataSourceItem<ICarousel>();
            if (dataSource != null)
            {
                CarouselViewModel viewModel = new CarouselViewModel
                {
                    Title = dataSource.Title
                };
                for (int i = 0; i < dataSource.Items.Count(); i++)
                {
                    var item = dataSource.Items.ElementAt(i);
                    viewModel.Items.Add(new CarouselItemViewModel
                    {
                        Index = i,
                        ImageUrl = item.Image?.Src,
                        ImageAlt = item.Image?.Alt,
                        ShowCaption = item.ShowCaption,
                        Caption = item.Caption,
                        Class = i == 0 ? "active" : string.Empty
                    });
                }

                return View(viewModel);
            }
            return new EmptyResult();
        }
    }
}