using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheHobbitOverHillAndUnderHillProduct : Product
    {
        public TheHobbitOverHillAndUnderHillProduct()
            : base("The Hobbit: Over Hill and Under Hill", "MEC16", ImageType.Png, new DateTime(2012, 8, 17))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/hobbit_over_hill_and_under_hill_rulesheet.pdf";

            AddCardSet(CardSet.TheHobbitOverHillAndUnderHill);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.WeMustAwayEreBreakOfDay());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.OverTheMistyMountainsGrim());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.DungeonsDeepAndCavernsDim());
        }
    }
}