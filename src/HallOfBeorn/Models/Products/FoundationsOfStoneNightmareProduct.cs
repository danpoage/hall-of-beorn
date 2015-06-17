using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.Sets;

namespace HallOfBeorn.Models.Products
{
    public class FoundationsOfStoneNightmareProduct : Product
    {
        public FoundationsOfStoneNightmareProduct()
            : base("Foundations of Stone Nightmare Deck", "MEN15", ImageType.Jpg)
        {
            AddCardSet(CardSet.FoundationsOfStoneNightmare);
        }
    }
}