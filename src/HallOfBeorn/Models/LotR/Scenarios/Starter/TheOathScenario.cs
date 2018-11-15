using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.Starter
{
    public class TheOathScenario : StarterScenario
    {
        public TheOathScenario()
        {
            Title = "The Oath";
            ProductName = "Two-Player Limited Edition Starter";
            GroupName = "Two-Player Limited Edition Starter";
            Number = 1;

            DifficultyRating = 3f;
            Votes = 1;

            AddEncounterSet(EncounterSet.TheOath);
            AddEncounterSet(EncounterSet.TheGoblins);

            AddQuestCardId("After-the-Raid-TPLES");
            AddQuestCardId("Mirkwood-Forest-TPLES");
            AddQuestCardId("The-Rearguard-TPLES");

            ExcludeTheGoblinsFromEasyMode();

            ExcludeFromEasyMode("Spiders-of-Mirkwood-TPLES", 2);
            ExcludeFromEasyMode("Tangled-Grove-TPLES", 2);
            ExcludeFromEasyMode("Caught-in-a-Web-TPLES", 1);
        }
    }
}