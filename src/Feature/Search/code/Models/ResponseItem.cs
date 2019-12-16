using System;
using System.Collections.Generic;

using Book = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.Base_Book;
using Page = Books.Foundation.Orm.Models.sitecore.templates.Feature.Navigation.NavigationItem;

namespace Books.Feature.Search.Models
{
    public class ResponseItem
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public List<Book> Books { get; set; }
        public List<Page> Pages { get; set; }
    }
}