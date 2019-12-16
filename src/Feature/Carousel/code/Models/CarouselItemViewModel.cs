using System;

using Glass.Mapper.Sc.Fields;

namespace Books.Feature.Carousel.Models
{
    public class CarouselItemViewModel
    {
        public virtual string Caption { get; set; }
        public virtual string Class { get; set; }
        public Guid Id { get; set; }
        public virtual Image Image { get; set; }
        public virtual string ImageAlt { get; set; }
        public int Index { get; set; }
        public virtual bool ShowCaption { get; set; }
    }
}