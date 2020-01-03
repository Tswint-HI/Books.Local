using System;
using System.Collections.Generic;
using System.Linq;

using Books.Foundation.Orm.Models.sitecore.templates.Feature.Banner;

using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Web.Mvc;

namespace Books.Feature.Banner.ViewModels
{
    public class BannerViewModel
    {
        public string Content { get; set; }
        public Link CTA { get; set; }
        public string Headline { get; set; }
        public Guid Id { get; set; }
        public Image Img { get; set; }
        public string Sub { get; set; }
        public string Title { get; set; }
        private readonly IBanner _bannerDatasource;
        private readonly IBanner_Folder _bfDatasource;

        public BannerViewModel(IBanner ds)
        {
            _bannerDatasource = ds;
            Id = ds.Id;
            Headline = ds.HeadLine;
            Title = ds.Title;
            Sub = ds.Sub;
            Img = ds.Img;
            Content = ds.Content;
            CTA = ds.CTA;
        }

        public BannerViewModel(IBanner_Folder _Folder) => _bfDatasource = _Folder;

        internal static List<BannerViewModel> GetAllBanners(IBanner_Folder ds, IMvcContext _context)
        {
            var bcVM = new List<BannerViewModel>();
            var bf = _context.SitecoreService.GetItem<IBanner_Folder>(ds.Id);
            bcVM.AddRange(from IBanner banner in bf.Banners
                          let tempVm = new BannerViewModel(banner)
                          select tempVm);
            return bcVM;
        }
    }
}