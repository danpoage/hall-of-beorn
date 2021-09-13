using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheThingInTheDepthsProduct : Product
    {
        public TheThingInTheDepthsProduct()
            : base("The Thing in the Depths", "MEC49", ImageType.Jpg, new DateTime(2016, 6, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC49.pdf";
            
            AddCardSet(CardSet.TheThingInTheDepths);

            AddScenario(Scenario.TheThingInTheDepths);
        }
    }
}