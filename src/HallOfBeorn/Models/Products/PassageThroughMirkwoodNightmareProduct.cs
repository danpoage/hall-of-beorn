using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class PassageThroughMirkwoodNightmareProduct : Product
    {
        public PassageThroughMirkwoodNightmareProduct()
            : base("Passage Through Mirkwood Nightmare Deck", "MEN01", ImageType.Jpg)
        {
            this.IsPremier = true;

            AddCardSet(CardSet.PassageThroughMirkwoodNightmare);
        }
    }
}