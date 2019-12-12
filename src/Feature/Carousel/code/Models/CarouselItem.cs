using Glass.Mapper.Sc.Fields;
using System;

namespace Books.Feature.Carousel.Models
{
    public class CarouselItem
    {
        public Guid Id { get; set; }
        public virtual Image Image { get; set; }
        public virtual string Caption { get; set; }
    }
}