using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.EredMithrin
{
    public abstract class EredMithrinScenario : Scenario
    {
        protected void ExcludeAfraidOfTheDarkFromEasyMode()
        {
            ExcludeFromEasyMode("Eyes-in-the-Dark-TWoR", 1);
            ExcludeFromEasyMode("Afraid-of-the-Dark-TWoR", 1);
        }

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

        protected void ExcludeGreyMountainGoblinsFromEasyMode()
        {
            ExcludeFromEasyMode("Goblin-Troop-TWoR", 1);
            ExcludeFromEasyMode("Stray-Goblin-TWoR", 1);
        }

        protected void ExcludeDarkWoodsFromEasyMode()
        {
            ExcludeFromEasyMode("Accursed-Forest-TWoR", 1);
            ExcludeFromEasyMode("Dark-Black-Woods-TWoR", 1);
        }

        protected void ExcludeGatheringGloomFromEasyMode()
        {
            ExcludeFromEasyMode("Gathering-Gloom-TWoR", 1);
            ExcludeFromEasyMode("Swarm-of-Bats-TWoR", 1);
        }

        protected void ExcludeDeepUndergroundFromEasyMode()
        {
            ExcludeFromEasyMode("Dark-Tunnel-TWoR", 1);
        }

        protected void ExcludeDragonMightFromEasyMode()
        {
            ExcludeFromEasyMode("Dragon-Breath-TWoR", 1);
            ExcludeFromEasyMode("Dragon-Scales-TWoR", 1);
        }
    }
}