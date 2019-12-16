using System;
using System.Collections.Generic;
using System.Linq;

using Books.Foundation.Orm.Models.sitecore.templates.Feature.Navigation;

using Glass.Mapper.Sc.Web.Mvc;

using Item = Sitecore.Data.Items.Item;

namespace Books.Feature.Navigation.ViewModels
{
    public class HeaderViewModel
    {
        public Guid Id { get; set; }
        public IEnumerable<Item> _childItems;
        public IMvcContext _context;
        public INavigation_Links_Folder _folder;
        public IEnumerable<Item> _parentItems;

        public HeaderViewModel(INavigation_Links_Folder dataSource, IMvcContext context)
        {
            _context = context;
            _folder = dataSource;
            GatherParents();
            GrabTheKids();
            RemoveItem(context);
        }

        private IEnumerable<Item> GatherParents() => _parentItems = _context.DataSourceItem.GetChildren().ToList();

        // Goes through Parents property checks for children and assigns them to to child property
        private IEnumerable<Item> GrabTheKids()
        {
            foreach (var item in _parentItems.Where(item => item.HasChildren).Select(item => item))
            {
                _childItems = new List<Item>();
                var temp = new List<Item>();
                var Kids = item.GetChildren().ToList();
                foreach (Item children in Kids)
                {
                    temp.Add(children);
                }

                _childItems = temp;
            }

            return _childItems;
        }

        // Checks what link item is == to contextname
        private void RemoveItem(IMvcContext context)
        {
            var contextName = context.ContextItem.DisplayName.ToLowerInvariant();
            var temp = new List<Item>();
            foreach (Item item in _parentItems)
            {
                temp.Add(item);
                if (item.DisplayName.ToLowerInvariant() == contextName)
                    temp.Remove(item);

                _parentItems = temp;
            }
            var temp2 = new List<Item>();
            foreach (Item items in _childItems)
            {
                var itemName = items.DisplayName.ToString().Replace("-", string.Empty).ToLowerInvariant();
                temp2.Add(items);
                if (itemName == contextName)
                    temp2.Remove(items);
            }
            _childItems = temp2;
        }
    }
}