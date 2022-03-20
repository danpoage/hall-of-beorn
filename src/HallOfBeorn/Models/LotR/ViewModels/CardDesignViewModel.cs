using System;
using System.Collections.Generic;
using System.Linq;
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
            this.lang = lang;

            Image = new CardImageViewModel(design.First, lang);

            foreach (var version in design.Versions)
            {
                this.versions.Add(new CardVersionViewModel(version, lang));
            }
        }

        private readonly CardDesign design;
        private readonly Language lang;
        private readonly List<CardVersionViewModel> versions = new List<CardVersionViewModel>();
        
        public string Title { get { return design.Title; } }
        public string Slug { get { return design.Slug; } }
        public string DetailsLink { get { return string.Format("/Designs/{0}", design.Slug); } }
        public string Sphere { get { return design.Sphere.ToString(); } }
        public string CardType { get { return design.CardType.ToCardTypeDescription(); } }
        public string CardSubtype { get { return design.CardSubtype != Models.CardSubtype.None ? design.CardSubtype.ToString() : null; } }
        
        public IEnumerable<CardVersionViewModel> Versions
        {
            get { return versions.OrderBy(ver => ver.Year); }
        }

        public CardImageViewModel Image { get; private set; }
    }
}