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

            QuestCompanionSlug = "starter-set-quest-the-caves-of-nibin-dum";
            DifficultyRating = 4.7f;
            Votes = 4;

            AddEncounterSet(EncounterSet.TheCavesOfNibinDum);
            AddEncounterSet(EncounterSet.TheGoblins);

            AddQuestCardId("The-Dark-of-Nibin-Dum-TPLES");
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