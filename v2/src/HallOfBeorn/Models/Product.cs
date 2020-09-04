using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class Product
        : INamed
    {
        public Product(Cycle cycle, string name, string code, DateTime releaseDate, List<CardSet> cardSets)
        {
            Cycle = cycle;
            Name = new Content(name);
            Code = code;
            ReleaseDate = releaseDate;
            this.cardSets = cardSets;
        }
        
        private readonly List<CardSet> cardSets;

        public Cycle Cycle { get; }
        
        public Content Name { get; }
        public string Code { get; }
        public DateTime ReleaseDate { get; }
        public IReadOnlyList<CardSet> CardSets => cardSets;
    }
}
