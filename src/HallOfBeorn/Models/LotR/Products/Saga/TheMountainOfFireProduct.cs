using System;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheMountainOfFireProduct : Product
    {
        public TheMountainOfFireProduct()
            : base("The Mountain of Fire", "MEC62", ImageType.Jpg, new DateTime(2017, 10, 1))
        {
            AddCardSet(CardSet.TheMountainOfFire);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC62.pdf";
            HasCampaignMode = true;

            AddScenario(Scenario.TheTowerOfCirithUngol);
            AddScenario(Scenario.TheBlackGateOpens);
            AddScenario(Scenario.MountDoom);
        }
    }
}