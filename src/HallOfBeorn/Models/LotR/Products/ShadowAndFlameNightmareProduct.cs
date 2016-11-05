using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR.Sets;

namespace HallOfBeorn.Models.LotR.Products
{
    public class ShadowAndFlameNightmareProduct : Product
    {
        public ShadowAndFlameNightmareProduct()
            : base("Shadow and Flame Nightmare Deck", "MEN16", ImageType.Jpg, new DateTime(2014, 9, 18))
        {
            AddCardSet(CardSet.ShadowAndFlameNightmare);
        }
    }
}