namespace HallOfBeorn.Models.Scenarios
{
    public class TheDunlandTrap : Scenario
    {
        public TheDunlandTrap()
        {
            Title = "The Dunland Trap";
            ProductName = "The Dunland Trap";
            GroupName = "The Ring-maker";
            Number = 0;

            AddEncounterSet(EncounterSet.DunlandWarriors);
            AddEncounterSet(EncounterSet.TheDunlandTrap);
            AddEncounterSet(EncounterSet.WearyTravelers);
            AddEncounterSet(EncounterSet.TheDunlandTrapNightmare);

            AddQuestCardId("The-Road-to-Tharbad-TDT");
            AddQuestCardId("A-Well-Laid-Trap-TDT");
            AddQuestCardId("No-Way-Out-TDT");

            ExcludeFromEasyMode("Dunland-Chieftain-VoI", 2);
            ExcludeFromEasyMode("Wild-Men-of-Dunland-VoI", 1);
            ExcludeFromEasyMode("Boar-Clan-Stalker-TDT", 1);
            ExcludeFromEasyMode("Hills-of-Dunland-TDT", 2);
            ExcludeFromEasyMode("Hithaeglir-Foothills-TDT", 1);
            ExcludeFromEasyMode("In-Need-of-Rest-VoI", 1);
            ExcludeFromEasyMode("Low-on-Provisions-VoI", 1);

            ExcludeFromNightmareMode("Boar-Clan-Warrior-TDT", 4);
            ExcludeFromNightmareMode("Hithaeglir-Stream-TDT", 4);
            ExcludeFromNightmareMode("Plains-of-Enedwaith-TDT", 3);
            ExcludeFromNightmareMode("Dunlending-Ambush-TDT", 1);
            ExcludeFromNightmareMode("Frenzied-Attack-TDT", 1);
            ExcludeFromNightmareMode("Low-on-Provisions-VoI", 1);
        }
    }
}
