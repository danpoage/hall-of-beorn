using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.Sets;

namespace HallOfBeorn.Models.Products
{
    public class TheLongDarkNightmareProduct : Product
    {
        public TheLongDarkNightmareProduct()
            : base("The Long Dark Nightmare Deck", "MEN14", ImageType.Jpg, new DateTime(2014, 9, 18))
        {
            AddCardSet(CardSet.TheLongDarkNightmare);
        }
    }
}