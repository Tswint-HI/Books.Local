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
        public IEnumerable<IBookCard> Cards { get; set; }
        public Image Image { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Introduction { get; set; }
        public Link Link { get; set; }
        public int Rating { get; set; }
        public string Authour { get; set; }

        public BookCardViewModel(ICard_Folder datasource) => this._cfDatasource = datasource;

        public BookCardViewModel(IBookCard datasource)
        {
            this._bcDatasource = datasource;
            Id = _bcDatasource.Id;
            Authour = _bcDatasource.Author;
            Image = _bcDatasource.Image;
            Title = _bcDatasource.Title;
            Genre = _bcDatasource.Genre;
            Introduction = _bcDatasource.Intro;
            Rating = _bcDatasource.Rating;
            Link = _bcDatasource.Link;
        }

        public static IEnumerable<IBookCard> GetBooksWithHighestRating(ICard_Folder datasource)
        {
            List<IBookCard> list = new List<IBookCard>();
            foreach (var card in datasource.BookCards)
            {
                if (card.Rating >= 4)
                {
                    list.Add(card);
                }
            }
            return list;
        }

    }
}