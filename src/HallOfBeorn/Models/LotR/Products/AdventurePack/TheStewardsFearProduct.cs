using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheStewardsFearProduct : Product
    {
        public TheStewardsFearProduct()
            : base("The Steward's Fear", "MEC18", ImageType.Png, new DateTime(2013, 5, 9))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/MEC18-the-stewards-fear-rulesheet.pdf";

            AddCardSet(CardSet.TheStewardsFear);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow.TheStewardsFearScenario());
        }
    }
}