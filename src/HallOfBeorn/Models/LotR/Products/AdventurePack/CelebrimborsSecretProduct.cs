using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class CelebrimborsSecretProduct : Product
    {
        public CelebrimborsSecretProduct()
            : base("Celebrimbor's Secret", "MEC30", ImageType.Png, new DateTime(2014, 11, 13))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC30.pdf";
            
            AddCardSet(CardSet.CelebrimborsSecret);

            AddScenario(Scenario.CelebrimborsSecret);
        }
    }
}