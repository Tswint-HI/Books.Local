using System.Collections.Generic;

namespace Books.Feature.Navigation.Controllers
{
    public class HeaderViewModel
    {
        public IEnumerable<Foundation.Orm.Models.sitecore.templates.Feature.Navigation.INavigationItem> Navigation { get; set; }
    }
}
