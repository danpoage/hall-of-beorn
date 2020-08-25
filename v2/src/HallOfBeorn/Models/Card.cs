using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class Card
    {
        public Card()
        {
            Front = new CardSide();
        }
        
        public string Slug { get; set; }

        //Do we need these?
        public string SlugSubtitle { get; set; }
        public string SlugSuffix { get; set; }
        public string AlternateSlug { get; set; }

        public Content Title { get; set; }
        public Content OppositeTitle { get; set; }

        public INamed CardSet { get; set; }
        public ushort Number { get; set; }
        public byte Quantity { get; set; }
        public CardType CardType { get; set; }
        public CardSubtype CardSubtype { get; set; }

        public CardSide Front { get; }
        public CardSide Back { get; set; }

        public readonly Stats Stats = new Stats();
        public readonly List<Content> Traits = new List<Content>();
        public readonly List<Content> Keywords = new List<Content>();
        
        public EncounterSet EncounterSet { get; set; }
        public readonly List<EncounterSet> IncludedEncounterSets = new List<EncounterSet>();
    }
}
