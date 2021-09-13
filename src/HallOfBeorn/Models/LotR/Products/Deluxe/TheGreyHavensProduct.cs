using System;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class TheGreyHavensProduct : Product
    {
        public TheGreyHavensProduct()
            : base("The Grey Havens", "MEC47", ImageType.Jpg, new DateTime(2016, 2, 1))
        {
            AddCardSet(CardSet.TheGreyHavens);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC47.pdf";

            AddScenario(Scenario.VoyageAcrossBelegaer);
            AddScenario(Scenario.TheFateOfNumenor);
            AddScenario(Scenario.RaidOnTheGreyHavens);
        }
    }
}