using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheSandsOfHarad
{
    public abstract class TheSandsOfHaradScenario : Scenario
    {
        protected TheSandsOfHaradScenario()
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/b6/a2/b6a24632-929f-4bd5-a436-bd8c617e4bd2/mec55_rules_webready.pdf";
        }

        protected void excludeEscapeFromUmbar() {
            ExcludeFromEasyMode("Umbar-Sentry-TSoH", 1);
            ExcludeFromEasyMode("Umbar-Street-TSoH", 1);
            ExcludeFromEasyMode("Enemy-Pursui-TSoH", 1);
        }

        protected void excludeDesertCrossing() {
            ExcludeFromEasyMode("Carrion-Bird-TSoH", 1);
            ExcludeFromEasyMode("Scorched-Hamada-TSoH", 1);
            ExcludeFromEasyMode("Unbeatable-Heat-TSoH", 1);
            ExcludeFromEasyMode("Scorching-Sun-TSoH", 1);
        }

        protected void excludeTheLongArmOfMordor() {
            ExcludeFromEasyMode("Savage-Attack-TSoH", 1);
        }

        protected void excludeHaradSoldiers() {
            ExcludeFromEasyMode("Southron-Soldier-TSoH", 1);
            ExcludeFromEasyMode("Southron-Archer-TSoH", 1);
            ExcludeFromEasyMode("Nowhere-to-Hide-TSoH", 1);
        }

        protected void excludeHaradTerritory() {
            ExcludeFromEasyMode("Injured-Companion-TSoH", 1);
            ExcludeFromEasyMode("Enfeebled-TSoH", 1);
        }

        protected void excludeDesertSands() {
            ExcludeFromEasyMode("Towering-Dunes-TSoH", 1);
            ExcludeFromEasyMode("Sandstorm-TSoH", 1);
        }

        protected void excludeDesertCreatures() {
            ExcludeFromEasyMode("Sand-Viper-TSoH", 1);
        }

        protected void excludeJungleForest() {
            ExcludeFromEasyMode("Jungle-Trail-TSoH", 1);
            ExcludeFromEasyMode("Forest-Clearing-TSoH", 1);
            ExcludeFromEasyMode("Overgrown-TSoH", 1);
        }

        protected void excludeMordorOrcs() {
            ExcludeFromEasyMode("Uruk-Warg-rider-TSoH", 1);
            ExcludeFromEasyMode("Mordor-Watrg-TSoH", 1);
            ExcludeFromEasyMode("Fear-of-Mordor-TSoH", 1);
        }
    }
}