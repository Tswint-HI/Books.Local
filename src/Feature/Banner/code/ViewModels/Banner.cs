using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books.Feature.Banner.ViewModels
{
    public class Banner
    {
        public string Title { get; set; }
        public string Sub { get; set; }
        public Image Img { get; set; }
        public string Content { get; set; }
        public Link CTA { get; set; }



    }
}