using Books.Foundation.Orm.Models.sitecore.templates.Feature.BookCard;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using IBookCard = Books.Foundation.Orm.Models.sitecore.templates.Feature.BookCard.IBookCard;

namespace Books.Feature.BookCard.Models
{
    public class BookCardViewModel
    {
        private readonly ICard_Folder _cfDatasource;
        private readonly IBookCard _bcDatasource;
        public Guid Id { get; set; }
        public ICollection<IBookCard> Cards { get; set; }
        public Image Image { get; set; }
        public string BookTitle { get; set; }
        public string BookGenre { get; set; }
        public string Intro { get; set; }
        public Link Link { get; set; }
        public int Rating { get; set; }
        public string Authour { get; set; }

        public BookCardViewModel(ICard_Folder datasource)
        {
            this._cfDatasource = datasource;
        }

        public BookCardViewModel(IBookCard datasource)
        {
            this._bcDatasource = datasource;
            Id = _bcDatasource.Id;
            Authour = _bcDatasource.Authour;
            Image = _bcDatasource.Image;
            BookTitle = _bcDatasource.BookTitle;
            BookGenre = _bcDatasource.BookGenre;
            Intro = _bcDatasource.Intro;
            Rating = _bcDatasource.Rating;
            Link = _bcDatasource.Link;
        }

        public BookCardViewModel()
        {
        }

        public static List<BookCardViewModel> GetBooksWithHighestRating(ICard_Folder datasource)
        {
            List<BookCardViewModel> bcVM = new List<BookCardViewModel>();
            foreach (var card in datasource.BookCards)
            {
                if (card.Rating >= 4)
                {
                    BookCardViewModel tempVm = new BookCardViewModel(card);
                    bcVM.Add(tempVm);
                }

            }
            return bcVM;
        }

    }
}