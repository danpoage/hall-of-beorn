using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class Product
        : INamed
    {
        public Product(string name, string code, DateTime releaseDate, List<CardSet> cardSets)
        {
            Name = new Content(name);
            Code = code;
            ReleaseDate = releaseDate;
            this.cardSets = cardSets;
        }

        private readonly List<CardSet> cardSets;

        public string Code { get; }
        public Content Name { get; }
        public DateTime ReleaseDate { get; }
        public IReadOnlyList<CardSet> CardSets => cardSets;
    }
}
