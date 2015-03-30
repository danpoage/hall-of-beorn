using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheMorgulValeNightmareProduct : Product
    {
        public TheMorgulValeNightmareProduct()
            : base("The Morgul Vale Nightmare Product", "MEN27", ImageType.Jpg)
        {
            CardSets.Add(CardSet.TheMorgulValeNightmare);
        }
    }
}