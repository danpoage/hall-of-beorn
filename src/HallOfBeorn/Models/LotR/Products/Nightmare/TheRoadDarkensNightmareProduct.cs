using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheRoadDarkensNightmareProduct : Product
    {
        public TheRoadDarkensNightmareProduct()
            : base("The Road Darkens Nightmare", "MEN20", ImageType.Jpg, new DateTime(2016, 3, 1))
        {
            AddCardSet(CardSet.TheRingGoesSouthNightmare);
            AddCardSet(CardSet.JourneyInTheDarkNightmare);
            AddCardSet(CardSet.BreakingOfTheFellowshipNightmare);
        }
    }
}