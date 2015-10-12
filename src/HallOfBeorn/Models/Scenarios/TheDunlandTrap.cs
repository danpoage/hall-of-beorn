using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheDunlandTrap : TheVoiceOfIsengardScenario
    {
        public TheDunlandTrap()
        {
            AdventurePack("The Dunland Trap", "The Ring-maker", 1);

            AddQuestCardId("The-Road-to-Tharbad-TDT");
            AddQuestCardId("A-Well-Laid-Trap-TDT");
            AddQuestCardId("No-Way-Out-TDT");

            AddEncounterSet(EncounterSet.TheDunlandTrap);
            AddEncounterSet(EncounterSet.DunlandWarriors);
            AddEncounterSet(EncounterSet.WearyTravelers);
        }
    }
}