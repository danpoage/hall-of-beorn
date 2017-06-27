using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheRedhornGateNightmareProduct : Product
    {
        public TheRedhornGateNightmareProduct()
            : base("The Redhord Gate Nightmare Deck", "MEN11", ImageType.Jpg, new DateTime(2014, 8, 27))
        {
            AddCardSet(CardSet.TheRedhornGateNightmare);
        }
    }
}