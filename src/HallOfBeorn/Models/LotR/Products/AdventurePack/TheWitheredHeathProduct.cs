using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheWitheredHeathProduct : Product
    {
        public TheWitheredHeathProduct()
            : base("The Withered Heath", "MEC66", ImageType.Jpg, new DateTime(2018, 7, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC66.pdf";
            
            AddCardSet(CardSet.TheWitheredHeath);

            AddScenario(Scenario.TheWitheredHeath);
        }
    }
}