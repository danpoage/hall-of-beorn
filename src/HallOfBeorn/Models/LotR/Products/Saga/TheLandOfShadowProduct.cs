using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheLandOfShadowProduct : Product
    {
        public TheLandOfShadowProduct()
            : base("The Land of Shadow", "MEC46", ImageType.Jpg, new DateTime(2015, 11, 19))
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/57/42/5742e6c7-ade4-433c-8263-492eaf2d1c65/mec46-the-land-of-shadow-rulesheet.pdf";

            AddCardSet(CardSet.TheLandOfShadow);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings.ThePassageOfTheMarshesScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings.JourneyToTheCrossRoads());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings.ShelobsLairScenario());
        }
    }
}