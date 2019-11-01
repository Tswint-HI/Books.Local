using Glass.Mapper.Sc.Fields;

namespace Books.Feature.Carousel.Models
{
    public class CarouselItem
    {
        public virtual Image MyProperty { get; set; }
        public virtual string Caption { get; set; }
    }
}