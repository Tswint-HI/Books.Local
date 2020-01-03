using Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base;

namespace Books.Feature.Footer.Models
{
    public class StandardFooterViewModel
    {
        private readonly IBase_Footer _datasource;

        public string Head { get; set; }
        public string Subhead { get; set; }
        public string Content { get; set; }
        public string Copy { get; set; }

        public StandardFooterViewModel(IBase_Footer datasource)
        {
            this._datasource = datasource;

            Head = this._datasource.Header;
            Subhead = this._datasource.Subhead;
            Content = this._datasource.Content;
            Copy = this._datasource.Copyright;
        }

    }
}