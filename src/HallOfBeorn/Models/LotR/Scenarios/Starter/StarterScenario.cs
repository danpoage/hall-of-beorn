using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.Starter
{
    public abstract class StarterScenario : Scenario
    {
        protected void ExcludeTheGoblinsFromEasyMode()
        {
            ExcludeFromEasyMode("Goblin-Runners-TPLES", 2);
            ExcludeFromEasyMode("Goblins-are-Upon-You-TPLES", 1);
        }
    }
}