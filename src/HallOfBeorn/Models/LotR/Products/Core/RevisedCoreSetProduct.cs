using System;

namespace HallOfBeorn.Models.LotR.Products.Core
{
    public class RevisedCoreSetProduct
        : Product
    {
        public RevisedCoreSetProduct()
            : base("Revised Core Set", "MEC101", ImageType.Png, new DateTime(2022, 1, 14))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC101.pdf";
            EasyModeUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC101-EASY.pdf";
            LearnToPlayUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC101-LTP.pdf";
            PrintAndPlayFile = "core_set_campaign_cards.pdf";
            HasCampaignMode = true;

            AddCardSet(CardSet.RevisedCore);
            AddScenario(Scenario.PassageThroughMirkwoodRevised);
            AddScenario(Scenario.JourneyAlongTheAnduinRevised);
            AddScenario(Scenario.EscapeFromDolGuldurRevised);
        }
    }
}