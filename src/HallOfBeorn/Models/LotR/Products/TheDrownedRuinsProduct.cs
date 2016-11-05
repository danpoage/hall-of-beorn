using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheDrownedRuinsProduct : Product
    {
        public TheDrownedRuinsProduct()
            : base("The Drowned Ruins", "MEC51", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheDrownedRuins);

            AddScenario(new Scenarios.TheDrownedRuins());
        }
    }
}