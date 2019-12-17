using System;
using System.Collections.Generic;
using System.Linq;

using Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base;

using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Web.Mvc;

using IBookCard = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.IBase_Book;

namespace Books.Feature.BookCard.Models
{
    public class BookCardViewModel
    {
        public string Author { get; set; }
        public string BookReview { get; set; }
        public ICollection<IBookCard> Cards { get; set; }
        public Guid Genre { get; set; }
        public Guid Id { get; set; }
        public Image Img { get; set; }
        public string Intro { get; set; }
        public Link Link { get; set; }
        public DateTime PublishDate { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; }
        private readonly IBookCard _bcDatasource;
        private readonly IBook_Folder _bfDatasource;
        public IMvcContext _context;

        public BookCardViewModel(IBook_Folder datasource) => _bfDatasource = datasource;

        public BookCardViewModel(IBookCard datasource)
        {
            _bcDatasource = datasource;
            Id = _bcDatasource.Id;
            Img = _bcDatasource.Img;
            Title = _bcDatasource.Title;
            Author = _bcDatasource.Author;
            Genre = _bcDatasource.Genre;
            PublishDate = _bcDatasource.PublishDate;
            Intro = _bcDatasource.Intro;
            BookReview = _bcDatasource.BookReview;
            Rating = _bcDatasource.Rating;
            Link = _bcDatasource.Link;
        }

        public BookCardViewModel()
        {
        }

        internal static List<BookCardViewModel> AllBooks(IBook_Folder ds, IMvcContext context)
        {
            _ = context.ContextItem.DisplayName.ToLowerInvariant();
            var genre = context.GetPageContextItem<Foundation.Orm.Models.sitecore.templates.Project.Page_Types.Genres>().Id;
            return (ds.Books.Where(card => card.Genre == genre).Select(card => new BookCardViewModel(card))).ToList();
        }

        internal static List<BookCardViewModel> GetBooksWithHighestRating(IBook_Folder datasource) => (datasource.Books.Where(card => card.Rating >= 4).Select(card => card).Select(card => new BookCardViewModel(card))).ToList();
    }
}