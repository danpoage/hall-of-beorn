using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.Sets;

namespace HallOfBeorn.Models.Products
{
    public class ShadowAndFlameNightmareProduct : Product
    {
        public ShadowAndFlameNightmareProduct()
            : base("Shadow and Flame Nightmare Deck", "MEN16", ImageType.Jpg)
        {
            AddCardSet(CardSet.ShadowAndFlameNightmare);
        }
    }
}