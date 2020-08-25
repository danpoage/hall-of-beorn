using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class CardSet
        : INamed
    {
        public Content Name { get; set; }
        public string Abbreviation { get; set; }
        public ushort Number { get; set; }
        public SetType SetType { get; set; }
        public readonly List<Card> Cards = new List<Card>();
        INamed Product { get; set; }
    }
}
