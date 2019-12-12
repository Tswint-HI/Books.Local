using Books.Foundation.Orm.Models.sitecore.templates.Feature.Navigation;
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
        public IEnumerable<Sitecore.Data.Items.Item> _childItems;
        public IMvcContext _context;
        public INavigation_Links_Folder _folder;
        public IEnumerable<Sitecore.Data.Items.Item> _parentItems;

        public HeaderViewModel(INavigation_Links_Folder dataSource, IMvcContext context)
        {
            _context = context;
            _folder = dataSource;
            //_folder.Logo = dataSource.Logo;
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
                    temp.Remove(item);

                _parentItems = temp;
            }
            List<Item> temp2 = new List<Item>();
            foreach (var items in _childItems)
            {
                string itemName = items.DisplayName.ToString().Replace("-", string.Empty).ToLowerInvariant();
                temp2.Add(items);
                if (itemName == contextName)
                    temp2.Remove(items);
            }
            _childItems = temp2;
        }
    }
}