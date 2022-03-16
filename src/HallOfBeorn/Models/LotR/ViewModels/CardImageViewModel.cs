using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class CardImageViewModel
    {
        public CardImageViewModel(LotRCard card, Language lang)
        {
            this.card = card;
            this.lang = lang;
        }

        private readonly LotRCard card;
        private readonly Language lang;

        //TODO: Move CardViewModel logic (use card.CardSet and Lang) to determine image path
        public string DetailFrontPath { get; private set; }
        public string DetailBackPath { get; private set; }
        public string ThumbnailFrontPath { get; private set; }
        public string ThumbnailBackPath { get; private set; }

        public int DetailPixelHeight { get; private set; }
        public int DetailPixelWidth { get; private set; }
        public int ThumbnailPixelHeight { get; private set; }
        public int ThumbnailPixelWidth { get; private set; }
    }
}