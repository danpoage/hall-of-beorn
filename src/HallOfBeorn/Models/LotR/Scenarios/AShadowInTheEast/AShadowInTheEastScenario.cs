using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast
{
    public abstract class AShadowInTheEastScenario : Scenario
    {
        protected void ExcludeTheRiverRunningFromEasyMode()
        {
            ExcludeFromEasyMode("Easterling-Outrider-ASitE", 2);
            ExcludeFromEasyMode("Exposed-Riverbank-ASitE", 1);
        }

        protected void ExcludeRidersOfRhunFromEasyMode()
        {
            ExcludeFromEasyMode("Rider-of-Rhun-ASitE", 1);
        }

        protected void ExcludeEasterlingRaidersFromEasyMode()
        {
            ExcludeFromEasyMode("Warrior-of-Rhun-ASitE", 1);
            ExcludeFromEasyMode("Sword-of-Rhun-ASitE", 1);
            ExcludeFromEasyMode("Recurve-Bow-ASitE", 1);
        }

        protected void ExcludeRollingPlainsFromEasyMode()
        {
            ExcludeFromEasyMode("Rolling-Plains-ASitE", 1);
            ExcludeFromEasyMode("Rocky-Outcrop-ASitE", 1);
            ExcludeFromEasyMode("Weary-Lands-ASitE", 1);
        }

        protected void ExcludeDangerInDorwinionFromEasyMode()
        {
            ExcludeFromEasyMode("Disappearances-ASitE", 1);
            ExcludeFromEasyMode("Secret-Cultist-ASitE", 1);
        }

        protected void ExcludeServantsOfSauronFromEasyMode()
        {
            ExcludeFromEasyMode("Servant-of-Sauron-ASitE", 1);
            ExcludeFromEasyMode("Overwhelmed-ASitE", 1);
        }

        protected void ExcludeCityOfRhunFromEasyMode()
        {
            ExcludeFromEasyMode("Treacherous-Easterling-ASitE", 1);
        }

        protected void ExcludeUnderGuardFromEasyMode()
        {
            ExcludeFromEasyMode("Side-Street-ASitE", 1);
            ExcludeFromEasyMode("Catacombs-ASitE", 1);
            ExcludeFromEasyMode("Under-Guard-ASitE", 1);
        }

        protected void ExcludeTheTempleOfDoomFromEasyMode()
        {
            ExcludeFromEasyMode("Temple-of-Sauron-ASitE", 1);
            ExcludeFromEasyMode("Hall-of-Horrors-ASitE", 1);
            ExcludeFromEasyMode("Place-of-Evil-ASitE", 2);
        }

        protected void ExcludeUlchorsGuardFromEasyMode()
        {
            ExcludeFromEasyMode("Ulchor's-Guard-ASitE", 1);
            ExcludeFromEasyMode("Ulchor's-Rage-ASitE", 2);
        }

        protected void ExcludeTwistedTunnelsFromEasyMode()
        {
            ExcludeFromEasyMode("Crumbling-Passage-ASitE", 1);
            ExcludeFromEasyMode("Fearful-Shadows-ASitE", 1);
        }
    }
}
