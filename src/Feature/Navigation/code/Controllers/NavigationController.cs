﻿using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using System;
using System.Web.Mvc;

namespace Books.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        private readonly IMvcContext _context;
        public NavigationController(IMvcContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public ActionResult getNav()
        {
            if (RenderingContext.Current.Rendering.Item != null)
            {

                var home = _context.GetHomeItem<Foundation.Orm.Models.sitecore.templates.Project.Page_Types.IHome>();
                HeaderViewModel vm = new HeaderViewModel
                {
                    Navigation = home.Navs
                };
                return View(vm);

            }
            return null;
        }

    }
}
