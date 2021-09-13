using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheCityOfCorsairsProduct : Product
    {
        public TheCityOfCorsairsProduct()
            : base("The City of Corsairs", "MEC53", ImageType.Jpg, new DateTime(2016, 10, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC53.pdf";
            
            AddCardSet(CardSet.TheCityOfCorsairs);

            AddScenario(Scenario.TheCityOfCorsairs);
        }
    }
}