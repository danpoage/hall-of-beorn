using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class DeckItemViewModel
    {
        public DeckItemViewModel(CardViewModel model)
        {
            Title = model.Title;
            OctgnGuid = model.OctgnGuid;
            Url = string.Format("/Cards/Details/{0}", model.Slug);
            CardImage = model.ImagePath;
            Sphere = model.Sphere;
            SphereIcon = model.SphereIcon;
            SetName = model.Card.CardSet.Name;
            CardType = model.CardType.ToString();
            //OctgnSlug = model.Card.OctgnSlug;
            MaxPerDeck = model.Card.MaxPerDeck;
        }

        public string Title { get; set; }
        public string OctgnGuid { get; set; }
        public string Url { get; set; }
        public string CardImage { get; set; }
        public string Sphere { get; set; }
        public string SphereIcon { get; set; }
        public string SetName { get; set; }
        public string CardType { get; set; }
        public string OctgnSlug { get; set; }
        public byte MaxPerDeck { get; set; }

        public byte Count { get; set; }
    }
}