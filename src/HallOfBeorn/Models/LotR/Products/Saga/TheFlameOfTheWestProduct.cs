using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheFlameOfTheWestProduct : Product
    {
        public TheFlameOfTheWestProduct()
            : base("The Flame of the West", "MEC54", ImageType.Jpg, new DateTime(2016, 8, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC54.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/e8/5c/e85c8012-6840-432b-bd81-ac7792aa6281/mec54_rulesheet.pdf";

            AddCardSet(CardSet.TheFlameOfTheWest);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings.ThePassingOfTheGreyCompanyScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings.TheSiegeOfGondorScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings.TheBattleOfThePelennorFieldsScenario());
        }
    }
}