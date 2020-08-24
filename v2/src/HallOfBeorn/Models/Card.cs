using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class Card
    {
        public Card()
        {
        }

        public string Title { get; set; }
        public CardSet CardSet { get; set; }
        public ushort Number { get; set; }
        public byte Quantity { get; set; }
        public CardType CardType { get; set; }
        
        public readonly List<Stat> Stats = new List<Stat>();
        public readonly List<Trait> Traits = new List<Trait>();
        public readonly List<Keyword> Keywords = new List<Keyword>();
        public readonly Dictionary<Language, string> Text = new Dictionary<Language, string>();
        public readonly Dictionary<Language, string> Shadow = new Dictionary<Language, string>();
        public readonly Dictionary<Language, string> Flavor = new Dictionary<Language, string>();
        public readonly Dictionary<Language, string> OppositeText = new Dictionary<Language, string>();
        public readonly Dictionary<Language, string> OppositeFlavor = new Dictionary<Language, string>();

        public EncounterSet EncounterSet { get; set; }
        public byte EasyModeQuantity { get; set; }
        public readonly List<EncounterSet> IncludedEncounterSets = new List<EncounterSet>();
    }
}
