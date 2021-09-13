using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheMumakilProduct : Product
    {
        public TheMumakilProduct()
            : base("The Mûmakil", "MEC56", ImageType.Jpg, new DateTime(2017, 2, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC56.pdf";
            
            AddCardSet(CardSet.TheMumakil);

            AddScenario(Scenario.TheMumakil);
        }
    }
}