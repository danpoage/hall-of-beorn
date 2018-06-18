using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheWildsOfRhovanion
{
    public class JourneyUpTheAnduin : Scenario
    {
        public JourneyUpTheAnduin()
        {
            Title = "Journey Up the Anduin";
            ProductName = "The Wilds of Rhovanion";
            GroupName = "The Wilds of Rhovanion";
            Number = 1;

            AddEncounterSet(EncounterSet.GreyMountainGoblins);
            AddEncounterSet(EncounterSet.HillsOfWilderland);
            AddEncounterSet(EncounterSet.LostInWilderland);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduin);
            AddEncounterSet(EncounterSet.JourneyUpTheAnduin);
            AddEncounterSet(EncounterSet.Wilderlands);

            AddQuestCardId("Traveling-North-TWoR");
            AddQuestCardId("Woodmen-Under-Attack-TWoR");
            AddQuestCardId("The-Passage-of-the-Ford-TWoR");

            ExcludeFromEasyMode("Frenzied-Creature-TWoR", 1);
            ExcludeFromEasyMode("Goblin-Troop-TWoR", 1);
            ExcludeFromEasyMode("Stray-Goblin-TWoR", 1);
            ExcludeFromEasyMode("Pack-of-Wargs-TWoR", 1);
            ExcludeFromEasyMode("Hills-of-Wilderland-TWoR", 1);
            ExcludeFromEasyMode("Lonely-Lands-TWoR", 1);
            ExcludeFromEasyMode("Ruined-Supplies-TWoR", 1);
            ExcludeFromEasyMode("Lost-in-the-Wild-TWoR", 1);
            ExcludeFromEasyMode("Weighed-Down-TWoR", 1);

            //Journey Along the Anduin (Core)
            ExcludeFromEasyMode("Massing-at-Night-Core", 1);
            ExcludeFromEasyMode("Gladden-Fields-Core", 2);

            //Wilderlands (Core)
            ExcludeFromEasyMode("Hill-Troll-Core", 1);
            ExcludeFromEasyMode("Marsh-Adder-Core", 1);
            ExcludeFromAllModes("Despair-Core");
            ExcludeFromAllModes("The-Brown-Lands-Core");
            ExcludeFromAllModes("The-East-Bight-Core");
        }
    }
}