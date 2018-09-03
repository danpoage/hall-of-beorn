using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.ViewModels
{
    public class DigitalCardViewModel
    {
        public DigitalCardViewModel(DigitalCard card)
        {
            Card = card;
        }

        public DigitalCard Card { get; private set; }

        public string Title { get { return Card.Title; } }
        public string Slug { get { return Card.Slug; } }
        public bool IsUnique { get { return Card.IsUnique; } }
        public DigitalCardType CardType { get { return Card.CardType; } }
        public string Sphere { get { return Card.Sphere.HasValue && Card.Sphere.Value != DigitalSphere.None ? Card.Sphere.ToString() : string.Empty; } }
        public byte? ThreatCost { get { return Card.ThreatCost; } }
        public byte? ResourceCost { get { return Card.ResourceCost; } }
        public byte? Attack { get { return Card.Attack; } }
        public byte? Willpower { get { return Card.Willpower; } }
        public byte? HitPoints { get { return Card.HitPoints; } }
        public string Text { get { return Card.Text; } }
        public string Trait { get { return Card.Trait.ToString(); } }

        public string ThumbImagePath
        {
            get
            {
                return string.Format("https://s3.amazonaws.com/hallofbeorn-resources/Images/Digital/{0}/{1}.jpg",
                    Card.CardSet.Slug, Card.NormalizedTitle.ToUrlSafeString());
            }
        }
    }
}