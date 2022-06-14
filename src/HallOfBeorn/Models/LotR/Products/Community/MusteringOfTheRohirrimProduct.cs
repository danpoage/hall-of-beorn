using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class MusteringOfTheRohirrimProduct
        : Product
    {
        public MusteringOfTheRohirrimProduct()
            : base("Mustering of the Rohirrim", "ALEP06", ImageType.Png, new DateTime(2022, 6, 13))
        {
            AddCardSet(CardSet.MusteringOfTheRohirrim);
            AddScenario(Scenario.MusteringOfTheRohirrim);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP06.pdf";
        }
    }
}