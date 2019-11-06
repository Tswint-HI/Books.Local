using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Web.Mvc;
using System.Collections.Generic;

namespace Books.Feature.Navigation.Controllers
{
    public class HeaderViewModel
    {
        public IEnumerable<Books.Foundation.Orm.Models.sitecore.templates.Feature.Navigation.INavigationItem> Navigation { get; set; }
        public IEnumerable<Books.Foundation.Orm.Models.sitecore.templates.Feature.Navigation.NavigationItem> NavigationLinks { get; set; }
        public virtual Link NavLink { get; internal set; }
        public IMvcContext Context { get; internal set; }
        public virtual Image Image { get; set; }

        public HeaderViewModel(IMvcContext _context)
        {
            Image = _context.GetContextItem<Foundation.Orm.Models.sitecore.templates.User_Defined.Base.I_Base_Navigation>().Logo;

            NavLink = _context.GetContextItem<Foundation.Orm.Models.sitecore.templates.Project.Page_Types.IHome>().Navs as Link;
        }
    }
}
