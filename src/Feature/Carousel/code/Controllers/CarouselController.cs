using Books.Feature.Carousel.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Linq;
using System.Web.Mvc;

namespace Books.Feature.Carousel.Controllers
{
    public class CarouselController : Controller
    {

        private readonly IMvcContext _mvcContext;
        public CarouselController(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext;
        }
        // GET: Carousel
        public ActionResult GetCarousel()
        {
            var dataSource = _mvcContext.GetDataSourceItem<Books.Feature.Carousel.Models.Carousel>();
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
                    ShowCaption = !string.IsNullOrEmpty(item.Caption),
                    Caption = item.Caption,
                    Class = i == 0 ? "active" : string.Empty
                });
            }

            return View(viewModel);
        }
    }
}