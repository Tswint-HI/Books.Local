using Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base;
using System;

namespace Books.Feature.Footer.Models
{
    public class StandardFooterViewModel
    {
        private readonly IBase_Footer _datasource;
        public Guid Id { get; set; }
        public string Header { get; set; }
        public string Subhead { get; set; }
        public string Content { get; set; }
        public string Copyright { get; set; }
        public string Disclosure { get; set; }

        public StandardFooterViewModel(IBase_Footer datasource)
        {
            this._datasource = datasource;
            Id = _datasource.Id;
            Header = _datasource.Header;
            Subhead = _datasource.Subhead;
            Content = _datasource.Content;
            Copyright = _datasource.Copyright;
            Disclosure = datasource.Disclosure;
        }
    }
}