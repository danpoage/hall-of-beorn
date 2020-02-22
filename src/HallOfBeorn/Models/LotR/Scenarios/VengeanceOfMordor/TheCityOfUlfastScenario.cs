using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast;

namespace HallOfBeorn.Models.LotR.Scenarios.VengeanceOfMordor
{
    public class TheCityOfUlfastScenario
        : AShadowInTheEastScenario
    {
        private const string name = "The City of Ulfast";

        public TheCityOfUlfastScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Vengeance of Mordor";
            Number = 2;

            RulesImageCount = 2;
            QuestCompanionSlug = "vengeance-of-mordor-cycle-quest-the-city-of-ulfast";
            DifficultyRating = 6f;
            Votes = 2;

            AddEncounterSet(EncounterSet.TheCityOfUlfast);
            AddEncounterSet(EncounterSet.ServantsOfSauron);
            AddEncounterSet(EncounterSet.UnderGuard);

            AddQuestCardId("Searching-for-Ulchor-TCoU");
            AddQuestCardId("Trying-to-Blend-In-TCoU");
            AddQuestCardId("Drawing-Attention-TCoU");
            AddQuestCardId("Ulchor's-Trap-TCoU");

            ExcludeServantsOfSauronFromEasyMode();
            ExcludeUnderGuardFromEasyMode();

            ExcludeFromEasyMode("Ulfast-Sentry-TCoU", 1);
            ExcludeFromEasyMode("The-King's-Elite-TCoU", 1);
            ExcludeFromEasyMode("Guarded-Archway-TCoU", 1);
            ExcludeFromEasyMode("Streets-of-Ulfast-TCoU", 1);
            ExcludeFromEasyMode("We've-Been-Seen-TCoU", 2);
        }
    }
}