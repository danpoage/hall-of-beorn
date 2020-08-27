using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class EncounterSet
        : INamed
    {
        public EncounterSet(CardSet cardSet, string name)
        {
            Product = cardSet.Product;
            CardSet = cardSet;
            Name = new Content(name);
        }

        public Content Name { get; set; }
        public INamed Product { get; }
        public INamed CardSet { get; }
        public readonly List<Card> Cards = new List<Card>();
    }
}
