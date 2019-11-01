namespace Books.Feature.Carousel.Models
{
    public class CarouselItemViewModel
    {
        public int Index { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual string ImageAlt { get; set; }
        public virtual bool ShowCaption { get; set; }
        public virtual string Caption { get; set; }
        public virtual string Class { get; set; }
    }
}