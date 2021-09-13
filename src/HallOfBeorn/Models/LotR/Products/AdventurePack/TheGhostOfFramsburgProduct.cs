using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheGhostOfFramsburgProduct : Product
    {
        public TheGhostOfFramsburgProduct()
            : base("The Ghost of Framsburg", "MEC69", ImageType.Png, new DateTime(2018, 12, 6))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC69.pdf";
            
            AddCardSet(CardSet.TheGhostOfFramsburg);

            AddScenario(Scenario.TheGhostOfFramsburg);
        }
    }
}