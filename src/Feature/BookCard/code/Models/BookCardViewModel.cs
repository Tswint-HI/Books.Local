using Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base;
using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using IBookCard = Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.IBase_Book;

namespace Books.Feature.BookCard.Models
{
    public class BookCardViewModel
    {
        private readonly IBook_Folder _bfDatasource;
        private readonly IBookCard _bcDatasource;
        public IMvcContext _context;
        public Guid Id { get; set; }
        public ICollection<IBookCard> Cards { get; set; }
        public Image Img { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Guid Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string BookReview { get; set; }
        public string Intro { get; set; }
        public int Rating { get; set; }
        public Link Link { get; set; }

        public BookCardViewModel(IBook_Folder datasource)
        {
            this._bfDatasource = datasource;
        }

        public BookCardViewModel(IBookCard datasource)
        {
            this._bcDatasource = datasource;
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

        internal static List<BookCardViewModel> GetBooksWithHighestRating(IBook_Folder datasource)
        {
            List<BookCardViewModel> bcVM = new List<BookCardViewModel>();
            foreach (var card in datasource.Books)
            {
                if (card.Rating >= 4)
                {
                    BookCardViewModel tempVm = new BookCardViewModel(card);
                    bcVM.Add(tempVm);
                }
            }
            return bcVM;
        }

        internal static List<BookCardViewModel> AllBooks(IBook_Folder ds, IMvcContext context)
        {
            string contextName = context.ContextItem.DisplayName.ToLowerInvariant();
            var genre = context.GetPageContextItem<Books.Foundation.Orm.Models.sitecore.templates.Project.Page_Types.Genres>().Id;
            List<BookCardViewModel> bcVM = new List<BookCardViewModel>();
            foreach (var card in ds.Books)
            {
                if (card.Genre == genre)
                {
                    BookCardViewModel tempVm = new BookCardViewModel(card);
                    bcVM.Add(tempVm);
                }
            }
            return bcVM;
        }
    }
}