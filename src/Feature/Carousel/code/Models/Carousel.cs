using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;

namespace Books.Feature.Carousel.Models
{
    public class Carousel
    {
        public virtual string Title { get; set; }
        [SitecoreChildren]
        public virtual IEnumerable<Books.Foundation.Orm.Models.sitecore.templates.Feature.Carousel.Carousel_Content.Carousel> Items { get; set; }
    }
}