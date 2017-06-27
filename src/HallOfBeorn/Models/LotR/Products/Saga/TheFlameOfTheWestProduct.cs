using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheFlameOfTheWestProduct : Product
    {
        public TheFlameOfTheWestProduct()
            : base("The Flame of the West", "MEC54", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheFlameOfTheWest);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings.ThePassingOfTheGreyCompany());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings.TheSiegeOfGondor());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings.TheBattleOfThePelennorFields());

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/e8/5c/e85c8012-6840-432b-bd81-ac7792aa6281/mec54_rulesheet.pdf";
        }
    }
}