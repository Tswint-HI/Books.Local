using System;

using Glass.Mapper.Sc.Fields;

namespace Books.Feature.Carousel.Models
{
    public class CarouselItem
    {
        public virtual string Caption { get; set; }
        public Guid Id { get; set; }
        public virtual Image Image { get; set; }
    }
}