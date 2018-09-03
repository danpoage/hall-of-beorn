using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn;

namespace HallOfBeorn.Models.Digital
{
    public class DigitalCard : ICard
    {
        public string Slug { get; set; }
        public string AlternateSlug { get; set; }
        public string Title { get; set; }
        public string NormalizedTitle { get { return Title.NormalizeCaseSensitiveString(); } }
        public DigitalCardType CardType { get; set; }
        public DigitalSphere? Sphere { get; set; }
        public bool IsUnique { get; set; }

        //Stats
        public byte? ThreatCost { get; set; }
        public byte? ResourceCost { get; set; }
        public byte? Attack { get; set; }
        public byte? Willpower { get; set; }
        public byte? HitPoints { get; set; }

        public DigitalCardTrait? Trait { get; set; }

        public string Text { get; set; }

        public DigitalCardSet CardSet { get; set; }
    }
}