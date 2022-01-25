using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.DreamChaser
{
    public abstract class DreamChaserScenarioScenario : Scenario
    {
        protected DreamChaserScenarioScenario()
            : base(true)
        {
        }

        protected void ExcludeVastOceansFromEasyMode()
        {
            ExcludeFromEasyMode("Rolling-Seas-TGH", 2);
        }

        protected void ExcludeStormyWeatherFromEasyMode()
        {
            ExcludeFromEasyMode("Waterspout-TGH", 1);
            ExcludeFromEasyMode("Sudden-Storms-TGH", 1);
            ExcludeFromEasyMode("Winds-of-Wrath-TGH", 1);
        }

        protected void ExcludeUmbarFleetFromEasyMode()
        {
            ExcludeFromEasyMode("Corsair-Warship-TGH", 2);
            ExcludeFromEasyMode("Boarding-Party-TGH", 1);
        }

        protected void ExcludeCorsairPiratesFromEasyMode()
        {
            ExcludeFromEasyMode("Umbar-Captain-TGH", 2);
        }

        protected void ExcludeCorsairRaidersFromEasyMode()
        {
            ExcludeFromEasyMode("Raid-Leader-TGH", 2);
            ExcludeFromEasyMode("Battle-Hardened-TGH", 2);
        }

        protected void ExcludeDrownedDeadFromEasyMode()
        {
            ExcludeFromEasyMode("Soulless-Cadaver-TGH", 1);
            ExcludeFromEasyMode("Throngs-of-Unfaithful-TGH", 1);
            ExcludeFromEasyMode("Curse-of-the-Downfallen-TGH", 2);
        }
    }
}