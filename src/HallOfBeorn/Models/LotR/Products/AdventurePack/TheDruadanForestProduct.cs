using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheDruadanForestProduct : Product
    {
        public TheDruadanForestProduct()
            : base("The Drúadan Forest", "MEC19", ImageType.Png, new DateTime(2013, 5, 31))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC19.pdf";
            
            AddCardSet(CardSet.TheDruadanForest);

            AddScenario(Scenario.TheDruadanForest);
        }
    }
}