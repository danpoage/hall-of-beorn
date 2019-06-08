using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheFateOfWilderlandProduct : Product
    {
        public TheFateOfWilderlandProduct()
            : base("The Fate of Wilderland", "MEC71", ImageType.Jpg, new DateTime(2019, 6, 6))
        {
            AddCardSet(CardSet.TheFateOfWilderland);
            AddScenario(new Scenarios.EredMithrin.TheFateOfWilderlandScenario());
        }
    }
}