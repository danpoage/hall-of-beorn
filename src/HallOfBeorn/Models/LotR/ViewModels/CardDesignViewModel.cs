using System;
using System.Collections.Generic;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class CardDesignViewModel
    {
        public CardDesignViewModel(
            CardDesign design, Language lang)
        {
            this.design = design;

            Image = new CardImageViewModel(design.First, lang);

            foreach (var version in design.Versions)
            {
                this.versions.Add(new CardViewModel(version, null, null, null, null, null, lang));
            }
        }

        private readonly CardDesign design;
        private readonly List<CardViewModel> versions = new List<CardViewModel>();

        public string Title { get { return design.Title; } }
        public string Slug { get { return design.Slug; } }
        public string Sphere { get { return design.Sphere.ToString(); } }
        public string CardType { get { return design.CardType.ToCardTypeDescription(); } }
        public string CardSubtype { get { return design.CardSubtype != Models.CardSubtype.None ? design.CardSubtype.ToString() : null; } }

        public CardImageViewModel Image { get; private set; }
    }
}