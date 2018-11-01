using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.EredMithrin
{
    public abstract class EredMithrinScenario : Scenario
    {
        protected void ExcludeWildCreaturesFromEasyMode()
        {
            ExcludeFromEasyMode("Werewolf-TWoR", 1);
            ExcludeFromEasyMode("Black-Bats-TWoR", 1);
        }

        protected void ExcludeLostInWilderlandFromEasyMode()
        {
            ExcludeFromEasyMode("Ruined-Supplies-TWoR", 1);
            ExcludeFromEasyMode("Lost-in-the-Wild-TWoR", 1);
            ExcludeFromEasyMode("Weighed-Down-TWoR", 1);
        }

        protected void ExcludeFellBeastsFromEasyMode()
        {
            ExcludeFromEasyMode("Stone-troll-TWoR", 1);
            ExcludeFromEasyMode("Hobgoblin-TWoR", 1);
        }

        protected void ExcludeHillsOfWilderlandFromEasyMode()
        {
            ExcludeFromEasyMode("Pack-of-Wargs-TWoR", 1);
            ExcludeFromEasyMode("Hills-of-Wilderland-TWoR", 1);
            ExcludeFromEasyMode("Lonely-Lands-TWoR", 1);
        }
    }
}