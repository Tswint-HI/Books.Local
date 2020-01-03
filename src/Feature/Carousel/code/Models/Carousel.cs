using System.Collections.Generic;

using Glass.Mapper.Sc.Configuration.Attributes;

namespace Books.Feature.Carousel.Models
{
    public class Carousel
    {
        [SitecoreChildren]
        public virtual IEnumerable<Foundation.Orm.Models.sitecore.templates.Feature.Carousel.Carousel_Content.Carousel> Items { get; set; }

        public virtual string Title { get; set; }
    }
}