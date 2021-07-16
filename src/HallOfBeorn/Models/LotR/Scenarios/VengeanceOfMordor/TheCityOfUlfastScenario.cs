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

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC79.pdf";
            RulesImageCount = 2;

            QuestCompanionSlug = "vengeance-of-mordor-cycle-quest-the-city-of-ulfast";
            DifficultyRating = 6.8f;
            Votes = 6;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2021/07/15/the-city-of-ulfast/");

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