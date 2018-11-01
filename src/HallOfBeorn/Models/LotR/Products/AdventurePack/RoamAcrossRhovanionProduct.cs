using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class RoamAcrossRhovanionProduct : Product
    {
        public RoamAcrossRhovanionProduct()
            : base("Roam Across Rhovanion", "MEC67", ImageType.Jpg, new DateTime(2018, 8, 30))
        {
            AddCardSet(CardSet.RoamAcrossRhovanion);
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.EredMithrin.RoamAcrossRhovanionScenario());
        }
    }
}