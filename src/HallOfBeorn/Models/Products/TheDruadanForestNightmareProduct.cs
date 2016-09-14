using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheDruadanForestNightmareProduct : Product
    {
        public TheDruadanForestNightmareProduct()
            : base("The Drúadan Forest Nightmare Deck", "MEN23", ImageType.Jpg, new DateTime(2015, 2, 12))
        {
            AddCardSet(CardSet.TheDruadanForestNightmare);
        }
    }
}