using System.Collections.Generic;
using System.Linq;

namespace Books.Feature.Carousel.Models
{
    public class CarouselViewModel
    {
        public IList<CarouselItemViewModel> Items { get; set; }
        public string Title { get; set; }

        public CarouselViewModel(Foundation.Orm.Models.sitecore.templates.Feature.Carousel.Carousel_Content.ICarousel dataSource)
        {
            Items = new List<CarouselItemViewModel>();
            Title = dataSource.Title;
            for (var i = 0; i < dataSource.Items.Count(); i++)
            {
                var item = dataSource.Items.ElementAt(i);
                Items.Add(new CarouselItemViewModel
                {
                    Index = i,
                    Id = item.Id,
                    Image = item.Image,
                    ImageAlt = item.Image?.Alt,
                    ShowCaption = item.ShowCaption,
                    Caption = item.Caption,
                    Class = i == 0 ? "active" : string.Empty
                });
            }
        }
    }
}