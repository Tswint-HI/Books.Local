using System;

using Head = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.Special_Heading;

namespace Books.Feature.BookCard.Models
{
    public class HeaderViewModel
    {
        public string Heading { get; set; }
        public Guid Id { get; set; }

        public HeaderViewModel(Head ds)
        {
            Heading = ds.Heading;
            Id = ds.Id;
        }
    }
}