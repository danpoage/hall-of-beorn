using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class PassageThroughMirkwoodNightmareProduct : Product
    {
        public PassageThroughMirkwoodNightmareProduct()
            : base("Passage Through Mirkwood Nightmare Deck", "MEN01", ImageType.Jpg, new DateTime(2013, 8, 1))
        {
            this.IsPremier = true;

            AddCardSet(CardSet.PassageThroughMirkwoodNightmare);
        }
    }
}