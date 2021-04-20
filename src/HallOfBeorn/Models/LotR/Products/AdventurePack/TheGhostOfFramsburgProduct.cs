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
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC69.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/f7/3c/f73c7c71-40db-4832-b34f-9bf4806e989f/mec69_web_the_ghost_of_framsburg_rules.pdf";

            AddCardSet(CardSet.TheGhostOfFramsburg);

            AddScenario(new Scenarios.EredMithrin.TheGhostOfFramsburgScenario());
        }
    }
}