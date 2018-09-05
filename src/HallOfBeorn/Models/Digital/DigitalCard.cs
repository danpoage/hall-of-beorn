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
        public string SlugSuffix { get; set; }

        public string AlternateSlug { get; set; }
        public string Title { get; set; }
        public string NormalizedTitle { get { return Title.NormalizeCaseSensitiveString(); } }
        public DigitalCardType CardType { get; set; }
        public DigitalSphere Sphere { get; set; }
        public AttachmentSlot? Slot { get; set; }
        public bool IsUnique { get; set; }

        public byte? Level { get; set; }
        public DigitalRarity? Rarity { get; set; }

        //Stats
        public byte? ThreatCost { get; set; }
        public byte? ResourceCost { get; set; }
        public byte? Attack { get; set; }
        public byte? Willpower { get; set; }
        public byte? HitPoints { get; set; }

        public DigitalTrait? Trait { get; set; }

        public string Text { get; set; }
        public string Html { get; set; }

        public Artist Artist { get; set; }

        public DigitalCardSet CardSet { get; set; }
        public uint Number { get; set; }

        public string CardSetName
        { 
            get { return CardSet != null ? CardSet.Name.NormalizeCaseSensitiveString()  : string.Empty; }
        }

        public bool IsCampaign { get { return false; } }
        public bool IsQuest { get { return false; } }
        public uint StageNumber { get { return 0; } }
        public char StageLetter { get { return '\0'; } }
    }
}