using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Marvel.ViewModels
{
    public class MarvelCardViewModel
    {
        public MarvelCardViewModel(MarvelCard card)
        {
            this.card = card;
        }

        private const string cardImagePath = 
            "https://s3.amazonaws.com/hallofbeorn-resources/Images/Marvel/Cards";

        private readonly MarvelCard card;

        public string Title { get { return card.Title; } }

        public string CardImagePath
        {
            get
            {
                return string.Format(
                    "{0}/{1}-{2}", 
                    cardImagePath, 
                    card.Title.ToUrlSafeString(), 
                    card.Product.Abbreviation.ToUrlSafeString());
            }
        }

        public string HeroImagePath
        {
            get
            { 
                return string.Format(
                    "{0}/{1}-{2}", 
                    cardImagePath, 
                    card.HeroName.ToUrlSafeString(), 
                    card.Product.Abbreviation.ToUrlSafeString()); 
            }
        }

        public string AlterEgoImagePath
        {
            get
            {
                return string.Format(
                    "{0}/{1}-{2}", 
                    cardImagePath, 
                    card.AlterEgoName.ToUrlSafeString(), 
                    card.Product.Abbreviation.ToUrlSafeString());
            }
        }
    }
}