using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class BloodInTheIsenProduct
        : Product
    {
        public BloodInTheIsenProduct()
            : base("Blood in the Isen", "ALEP07", ImageType.Png, new DateTime(2022, 9, 9))
        {
            AddCardSet(CardSet.BloodInTheIsen);
            AddScenario(Scenario.BloodInTheIsen);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP07.pdf";
        }
    }
}