﻿using System;
using System.Collections.Generic;

using Books.Foundation.Orm.Models;

using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;

using Sitecore.Data;
using Sitecore.Data.Items;

namespace Books.Foundation.Orm.Repo
{
    public class SitecoreRepository
    {
        public IRequestContext _sitecoreRequestContext { get; set; }

        public SitecoreRepository(IRequestContext requestContext) => _sitecoreRequestContext = requestContext ?? throw new ArgumentNullException(nameof(requestContext));

        public T CastItem<T>(Item item) where T : GlassBase
        {
            var resolvedItem = _sitecoreRequestContext.SitecoreService.ResolveItem(item);
            return _sitecoreRequestContext.SitecoreService.GetItem<T>(new GetItemByIdOptions() { Id = resolvedItem.ID.Guid, Lazy = Glass.Mapper.LazyLoading.Enabled });
        }

        public T CurrentEntity<T>() where T : GlassBase => _sitecoreRequestContext.GetContextItem<T>(new GetKnownOptions() { Lazy = Glass.Mapper.LazyLoading.Enabled });

        public T FindById<T>(Guid id) where T : GlassBase => _sitecoreRequestContext.SitecoreService.GetItem<T>(new GetItemByIdOptions() { Id = id, Lazy = Glass.Mapper.LazyLoading.Enabled });

        public T FindByPath<T>(string path) where T : GlassBase
        {
            var itemPath = !path.StartsWith("/sitecore/content") ? string.Format("{0}{1}", Sitecore.Context.Site.StartPath, path) : path;
            return _sitecoreRequestContext.SitecoreService.GetItem<T>(new GetItemByPathOptions() { Path = itemPath, Lazy = Glass.Mapper.LazyLoading.Enabled });
        }

        public IEnumerable<T> FindByTemplate<T>(Guid templateId, string path) where T : GlassBase
        {
            var itemPath = !path.StartsWith("/sitecore/content") ? string.Format("{0}{1}", Sitecore.Context.Site.StartPath, path) : path;

            var item = _sitecoreRequestContext.SitecoreService.GetItem<T>(new GetItemByPathOptions() { Path = itemPath, Lazy = Glass.Mapper.LazyLoading.Enabled });
            if (item == null || string.IsNullOrEmpty(itemPath))
            {
                return null;
            }

            var queryString = string.Format("{0}/*[@@TemplateID='{{{1}}}']", itemPath, templateId.ToString().ToUpper());

            var itemQuery = new Query(queryString);
            var itemList = _sitecoreRequestContext.SitecoreService.GetItems<T>(itemQuery);

            return itemList;
        }

        public Item FindItemById(ID itemId) => Sitecore.Context.Database.GetItem(itemId);

        public Item FindItemByPath(string path) => Sitecore.Context.Database.GetItem(path);

        public T HomeItem<T>() where T : GlassBase => _sitecoreRequestContext.GetHomeItem<T>();
    }
}