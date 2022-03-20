using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class CardVersionViewModel
    {
        public CardVersionViewModel(LotRCard card, Language lang)
        {
            CardSet = card.CardSet.Name;
            Year = getYear(card.CardSet);
            Link = string.Format("/LotR/Details/{0}?Lang={1}", card.Slug, lang);
            Image = new CardImageViewModel(card, lang);
        }

        private string getYear(CardSet cardSet)
        {
            return cardSet.Product != null
                ? cardSet.Product.FirstReleased.Year.ToString()
                : "Unknown";
        }

        
        public string CardSet { get; private set; }
        public string Year { get; private set; }
        public string Description { get { return string.Format("{0} ({1})", CardSet, Year); } }
        public string Link { get; private set; }
        public CardImageViewModel Image { get; private set; }
    }
}