using Books.Foundation.Orm.Models.sitecore.templates.Feature.Navigation;
using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Item = Sitecore.Data.Items.Item;

namespace Books.Feature.Navigation.ViewModels
{
    public class HeaderViewModel
    {
        public Guid Id { get; set; }
        public IMvcContext _context;
        public IEnumerable<Sitecore.Data.Items.Item> _parentItems;
        public IEnumerable<Sitecore.Data.Items.Item> _childItems;
        public Image Logo;

        public HeaderViewModel(INavigation_Links_Folder dataSource, IMvcContext context)
        {
            _context = context;
            Logo = dataSource.Logo;
            GatherParents();
            GrabTheKids();
            RemoveItem(context);
        }
        private IEnumerable<Item> GatherParents() => _parentItems = _context.DataSourceItem.GetChildren().ToList();
        // Goes through Parents property checks for children and assigns them to to child property
        private IEnumerable<Item> GrabTheKids()
        {
            foreach (var item in _parentItems)
            {
                if (item.HasChildren)
                {
                    _childItems = new List<Sitecore.Data.Items.Item>();
                    List<Item> temp = new List<Sitecore.Data.Items.Item>();
                    List<Item> Kids = item.GetChildren().ToList();

                    foreach (var children in Kids)
                    {
                        temp.Add(children);
                    }
                    _childItems = temp;
                }
            }
            return _childItems;
        }
        // Checks what link item is == to contextname
        private void RemoveItem(IMvcContext context)
        {
            string contextName = context.ContextItem.DisplayName.ToLowerInvariant();
            List<Item> temp = new List<Item>();
            foreach (var item in _parentItems)
            {
                temp.Add(item);
                if (item.DisplayName.ToLowerInvariant() == contextName)
                {
                    temp.Remove(item);
                }
                _parentItems = temp;
            }
            List<Item> temp2 = new List<Item>();
            foreach (var items in _childItems)
            {
                temp2.Add(items);
                if (items.DisplayName.ToLowerInvariant() == contextName)
                {
                    temp2.Remove(items);
                }
                _childItems = temp2;
            }
        }
    }
}
