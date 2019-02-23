using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheGhostOfFramsburgProduct : Product
    {
        public TheGhostOfFramsburgProduct()
            : base("The Ghost of Framsburg", "MEC69", ImageType.Png, new DateTime(2018, 12, 6))
        {
            AddCardSet(CardSet.TheGhostOfFramsburg);
            AddScenario(new Scenarios.EredMithrin.TheGhostOfFramsburgScenario());
        }
    }
}