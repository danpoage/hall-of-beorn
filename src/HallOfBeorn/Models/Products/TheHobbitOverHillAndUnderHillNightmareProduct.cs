using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheHobbitOverHillAndUnderHillNightmareProduct : Product
    {
        public TheHobbitOverHillAndUnderHillNightmareProduct()
            : base("The Hobbit: Over Hill and Under Hill Nightmare Decks", "MEN17", ImageType.Jpg)
        {
            IsPremier = true;
            CardSets.Add(CardSet.WeMustAwayEreBreakOfDayNightmare);
            CardSets.Add(CardSet.OverTheMistyMountainsGrimNightmare);
            CardSets.Add(CardSet.DungeonsDeepAndCavernsDimNightmare);
        }
    }
}