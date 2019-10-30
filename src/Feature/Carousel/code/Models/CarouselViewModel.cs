using System.Collections.Generic;

namespace Books.Feature.Carousel.Models
{
    public class CarouselViewModel
    {
        public string Title { get; set; }
        public IList<CarouselItemViewModel> Items { get; set; }

        public CarouselViewModel()
        {
            Items = new List<CarouselItemViewModel>();
        }
    }
}