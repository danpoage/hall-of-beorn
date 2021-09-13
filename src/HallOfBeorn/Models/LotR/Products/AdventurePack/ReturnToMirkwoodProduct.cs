using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class ReturnToMirkwoodProduct : Product
    {
        public ReturnToMirkwoodProduct()
            : base("Return to Mirkwood", "MEC07", ImageType.Png, new DateTime(2011, 11, 23))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC07.pdf";
            
            AddCardSet(CardSet.ReturnToMirkwood);

            AddScenario(Scenario.ReturnToMirkwood);
        }
    }
}