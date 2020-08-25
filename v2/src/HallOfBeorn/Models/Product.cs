using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class Product
        : INamed
    {
        public Product(string code)
        {
            Code = code;
        }

        public string Code { get; }
        public Content Name { get; set; }
        public readonly List<CardSet> CardSets = new List<CardSet>();
    }
}
