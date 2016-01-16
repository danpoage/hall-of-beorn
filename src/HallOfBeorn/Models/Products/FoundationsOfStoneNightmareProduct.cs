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
            : base("Foundations of Stone Nightmare Deck", "MEN15", ImageType.Jpg, new DateTime(2014, 9, 18))
        {
            AddCardSet(CardSet.FoundationsOfStoneNightmare);
        }
    }
}