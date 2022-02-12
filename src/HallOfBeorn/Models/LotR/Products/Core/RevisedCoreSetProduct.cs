using System;

namespace HallOfBeorn.Models.LotR.Products.Core
{
    public class RevisedCoreSetProduct
        : Product
    {
        public RevisedCoreSetProduct()
            : base("Revised Core Set", "MEC101", ImageType.Png, new DateTime(2022, 1, 14))
        {
            PrintAndPlayFile = "core_set_campaign_cards.pdf";

            AddCardSet(CardSet.RevisedCore);
            AddScenario(Scenario.PassageThroughMirkwoodRevised);
            AddScenario(Scenario.JourneyAlongTheAnduinRevised);
            AddScenario(Scenario.EscapeFromDolGuldurRevised);
        }
    }
}