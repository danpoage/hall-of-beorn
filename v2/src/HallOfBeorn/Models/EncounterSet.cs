﻿using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class EncounterSet
        : INamed
    {
        public EncounterSet(CardSet cardSet, string name, List<Card> cards)
        {
            //Product = cardSet.Product;
            CardSet = cardSet;
            Name = new Content(name);
            this.cards = cards;
        }

        public EncounterSet(CardSet cardSet, string name, string alternateName, List<Card> cards)
        {
            CardSet = cardSet;
            Name = new Content(name);
            AlternateName = new Content(alternateName);
            this.cards = cards;

        }

        private readonly List<Card> cards;
        
        //public INamed Product { get; }
        public INamed CardSet { get; }
        public Content Name { get; }
        public Content AlternateName { get; }
        public IReadOnlyList<Card> Cards => cards;
    }
}
