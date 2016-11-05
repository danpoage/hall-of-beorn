using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheHobbitOverHillAndUnderHillNightmareProduct : Product
    {
        public TheHobbitOverHillAndUnderHillNightmareProduct()
            : base("The Hobbit: Over Hill and Under Hill Nightmare Decks", "MEN17", ImageType.Jpg, new DateTime(2014, 7, 22))
        {
            IsPremier = true;
            AddCardSet(CardSet.WeMustAwayEreBreakOfDayNightmare);
            AddCardSet(CardSet.OverTheMistyMountainsGrimNightmare);
            AddCardSet(CardSet.DungeonsDeepAndCavernsDimNightmare);
        }
    }
}