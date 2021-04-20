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
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC67.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/b8/22/b822ee1e-d5ba-4d72-831c-3a23c007fc18/mec67_roam_across_rhovanion_rules-insert-compressed.pdf";

            AddCardSet(CardSet.RoamAcrossRhovanion);
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.EredMithrin.RoamAcrossRhovanionScenario());
        }
    }
}