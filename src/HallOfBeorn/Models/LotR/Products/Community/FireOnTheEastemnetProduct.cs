using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class FireOnTheEastemnetProduct
        : Product
    {
        public FireOnTheEastemnetProduct()
            : base("Fire on the Eastemnet", "ALEP03", ImageType.Png, new DateTime(2021, 9, 9))
        {
            AddCardSet(CardSet.FireOnTheEastemnet);
            AddScenario(Scenario.FireOnTheEastemnet);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP03.pdf";
        }
    }
}