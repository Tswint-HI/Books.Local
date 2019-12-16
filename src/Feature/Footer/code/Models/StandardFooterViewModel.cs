using System;

using Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base;

namespace Books.Feature.Footer.Models
{
    public class StandardFooterViewModel
    {
        public string Content { get; set; }
        public string Copyright { get; set; }
        public string Disclosure { get; set; }
        public string Header { get; set; }
        public Guid Id { get; set; }
        public string Subhead { get; set; }
        private readonly IBase_Footer _datasource;

        public StandardFooterViewModel(IBase_Footer datasource)
        {
            _datasource = datasource;
            Id = _datasource.Id;
            Header = _datasource.Header;
            Subhead = _datasource.Subhead;
            Content = _datasource.Content;
            Copyright = _datasource.Copyright;
            Disclosure = _datasource.Disclosure;
        }
    }
}