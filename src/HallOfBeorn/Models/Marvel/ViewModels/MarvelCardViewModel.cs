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

        public MarvelCardType CardType { get { return card.CardType; } }

        public string Title { get { return card.Title; } }

        public bool IsUnique { get { return card.IsUnique; } }

        public byte? Thwart { get { return card.Thwart; } }
        public byte? Attack { get { return card.Attack; } }
        public byte? Defense { get { return card.Defense; } }
        public byte? Recover { get { return card.Recover; } }
        public byte? HeroHitPoints { get { return card.HeroHitPoints; } }
        public byte? AlterEgoHitPoints { get { return card.AlterEgoHitPoints; } }
        public byte? HeroHandSize { get { return card.HeroHandSize; } }
        public byte? AlterEgoHandSize { get { return card.AlterEgoHandSize; } }

        public string SearchUrl
        {
            get { return string.Format("/Marvel/Details/{0}", card.Slug); }
        }

        public string CardFrontImagePath
        {
            get
            {
                return CardType == MarvelCardType.Hero 
                    ? HeroImagePath 
                    : string.Format(
                        "{0}/{1}-{2}", 
                        cardImagePath, 
                        card.Title.ToUrlSafeString(), 
                        card.Product.Abbreviation.ToUrlSafeString());
            }
        }

        public string CardBackImagePath
        {
            get
            {
                return CardType == MarvelCardType.Hero
                    ? AlterEgoImagePath
                    : null;
            }
        }

        public string HeroImagePath
        {
            get
            { 
                return string.Format(
                    "{0}/{1}/{2}.jpg", 
                    cardImagePath, 
                    card.Product.Abbreviation.ToUrlSafeString(),
                    card.HeroName.ToUrlSafeString()); 
            }
        }

        public string AlterEgoImagePath
        {
            get
            {
                return string.Format(
                    "{0}/{1}/{2}.jpg", 
                    cardImagePath, 
                    card.Product.Abbreviation.ToUrlSafeString(),
                    card.AlterEgoName.ToUrlSafeString());
            }
        }

        public int ImageHeight
        {
            get { return 300; }
        }

        public int ImageWidth
        {
            get { return 212; }
        }
    }
}