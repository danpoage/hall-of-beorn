using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheThreeTrialsProduct : Product
    {
        public TheThreeTrialsProduct()
            : base("The Three Trials", "MEC27", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/the-three-trials-rulesheet.pdf";

            AddCardSet(CardSet.TheThreeTrials);

            AddScenario(new HallOfBeorn.Models.Scenarios.TheThreeTrials());
        }
    }
}