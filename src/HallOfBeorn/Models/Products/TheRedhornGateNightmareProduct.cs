using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheRedhornGateNightmareProduct : Product
    {
        public TheRedhornGateNightmareProduct()
            : base("The Redhord Gate Nightmare Deck", "MEN11", ImageType.Jpg)
        {
            CardSets.Add(CardSet.TheRedhornGateNightmare);
        }
    }
}