using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.ChildrenOfEorl
{
    public class TheBattleForTheBeaconScenario
        : Scenario
    {
        public TheBattleForTheBeaconScenario()
        {
            Title = "The Battle for the Beacon";
            ProductName = "Children of Eorl";
            GroupName = "Children of Eorl";
            Number = 2;

            //QuestCompanionSlug = "children-of-eorl-the-battle-for-the-beacon";
            //DifficultyRating = 5.0f;
            //Votes = 1;

            AddEncounterSet(EncounterSet.TheBattleForTheBeacon);
            AddEncounterSet(EncounterSet.DunlendingWarriors);
            AddEncounterSet(EncounterSet.FaithlessRohirrim);

            AddQuestCardId("Battle-for-the-Hill-CoE");
            AddQuestCardId("Hold-the-Hilltop-CoE");
            AddQuestCardId("The-Last-Push-CoE");

            //The Battle for the Beacon
            ExcludeFromEasyMode("Bald-Hill-CoE", 2);
            ExcludeFromEasyMode("Narrow-Stair-CoE", 1);
            ExcludeFromEasyMode("From-All-Sides-CoE", 2);
            ExcludeFromEasyMode("Another-Wave-CoE", 1);

            //Dunlending Warriors
            ExcludeFromEasyMode("Wild-Ravager-CoE", 2);
            ExcludeFromEasyMode("Hillman-Scout-CoE", 1);
            ExcludeFromEasyMode("Surprise-Attack-CoE", 1);

            //Faithless Rohirrim
            ExcludeFromEasyMode("Recreant-Rider-CoE", 1);
            ExcludeFromEasyMode("Deadly-Defector-CoE", 2);
        }
    }
}