using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class RoamAcrossRhovanionProduct : Product
    {
        public RoamAcrossRhovanionProduct()
            : base("Roam Across Rhovanion", "MEC67", ImageType.Jpg, new DateTime(2018, 8, 30))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC67.pdf";
            
            AddCardSet(CardSet.RoamAcrossRhovanion);

            AddScenario(Scenario.RoamAcrossRhovanion);
        }
    }
}