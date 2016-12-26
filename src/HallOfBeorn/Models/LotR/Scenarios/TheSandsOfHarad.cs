using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios
{
    public abstract class TheSandsOfHarad : Scenario
    {
        protected void excludeEscapeFromUmbar() {
            ExcludeFromEasyMode("Umbar-Sentry-TSoH", 1);
            ExcludeFromEasyMode("Umbar-Street-TSoH", 1);
            ExcludeFromEasyMode("Enemy-Pursui-TSoH", 1);
        }

        protected void excludeFromDesertCrossing() {
            ExcludeFromEasyMode("Carrion-Bird-TSoH", 1);
            ExcludeFromEasyMode("Scorched-Hamada-TSoH", 1);
            ExcludeFromEasyMode("Unbeatable-Heat-TSoH", 1);
            ExcludeFromEasyMode("Scorching-Sun-TSoH", 1);
        }

        protected void excludeFromTheLongArmOfMordor() {
            ExcludeFromEasyMode("Savage-Attack-TSoH", 1);
        }

        protected void excludeFromHaradSoldiers() {
            ExcludeFromEasyMode("Southron-Soldier-TSoH", 1);
            ExcludeFromEasyMode("Southron-Archer-TSoH", 1);
            ExcludeFromEasyMode("Nowhere-to-Hide-TSoH", 1);
        }

        protected void excludeFromHaradTerritory() {
            ExcludeFromEasyMode("Injured-Companion-TSoH", 1);
            ExcludeFromEasyMode("Enfeebled-TSoH", 1);
        }

        protected void excludeFromDesertSands() {
            ExcludeFromEasyMode("Towering-Dunes-TSoH", 1);
            ExcludeFromEasyMode("Sandstorm-TSoH", 1);
        }

        protected void excludeFromDesertCreatures() {
            ExcludeFromEasyMode("Sand-Viper-TSoH", 1);
        }

        protected void excludeFromJungleForest() {
            ExcludeFromEasyMode("Jungle-Trail-TSoH", 1);
            ExcludeFromEasyMode("Forest-Clearing-TSoH", 1);
            ExcludeFromEasyMode("Overgrown-TSoH", 1);
        }

        protected void excludeFromMordorOrcs() {
            ExcludeFromEasyMode("Uruk-Warg-rider-TSoH", 1);
            ExcludeFromEasyMode("Mordor-Watrg-TSoH", 1);
            ExcludeFromEasyMode("Fear-of-Mordor-TSoH", 1);
        }
    }
}