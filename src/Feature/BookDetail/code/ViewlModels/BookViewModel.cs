using Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base;
using Glass.Mapper.Sc.Fields;
using System;

namespace Books.Feature.BookDetail.ViewlModels
{
    public class BookViewModel
    {
        private readonly IBase_Book _datasource;
        public Guid Id { get; set; }
        public Image Img { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Guid Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string BookReview { get; set; }

        public BookViewModel(IBase_Book datasource)
        {
            this._datasource = datasource;
            Id = _datasource.Id;
            Img = _datasource.Img;
            Title = _datasource.Title;
            Author = _datasource.Author;
            Genre = _datasource.Genre;
            PublishDate = _datasource.PublishDate;
            BookReview = _datasource.BookReview;
        }

        internal static BookViewModel VariantOne(BookViewModel vm)
        {
            return vm;
        }
    }
}