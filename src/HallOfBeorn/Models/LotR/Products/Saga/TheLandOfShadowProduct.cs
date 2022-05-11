using System;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheLandOfShadowProduct : Product
    {
        public TheLandOfShadowProduct()
            : base("The Land of Shadow", "MEC46", ImageType.Jpg, new DateTime(2015, 11, 19))
        {
            AddCardSet(CardSet.TheLandOfShadow);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC46.pdf";
            HasCampaignMode = true;

            AddScenario(Scenario.ThePassageOfTheMarshes);
            AddScenario(Scenario.JourneyToTheCrossRoads);
            AddScenario(Scenario.ShelobsLair);
        }
    }
}