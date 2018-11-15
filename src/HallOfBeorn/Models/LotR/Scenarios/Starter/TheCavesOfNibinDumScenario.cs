using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.Starter
{
    public class TheCavesOfNibinDumScenario : StarterScenario
    {
        public TheCavesOfNibinDumScenario()
        {
            Title = "The Caves of Nibin-Dûm";
            ProductName = "Two-Player Limited Edition Starter";
            GroupName = "Two-Player Limited Edition Starter";
            Number = 2;

            DifficultyRating = 3.5f;
            Votes = 1;

            AddEncounterSet(EncounterSet.TheOath);
            AddEncounterSet(EncounterSet.TheGoblins);

            AddQuestCardId("The Dark of Nibin-Dûm-TPLES");
            AddQuestCardId("Surprise-Attack-TPLES");
            AddQuestCardId("The-Chasm-TPLES");
            AddQuestCardId("Oathkeepers-TPLES");

            ExcludeTheGoblinsFromEasyMode();

            ExcludeFromEasyMode("Great-Cave-troll-TPLES", 2);
            ExcludeFromEasyMode("Branching-Paths-TPLES", 2);
            ExcludeFromEasyMode("Watchful-Eyes-TPLES", 1);
        }
    }
}