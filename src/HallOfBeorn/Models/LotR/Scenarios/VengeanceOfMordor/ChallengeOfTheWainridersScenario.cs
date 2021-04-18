using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast;

namespace HallOfBeorn.Models.LotR.Scenarios.VengeanceOfMordor
{
    public class ChallengeOfTheWainridersScenario
        : AShadowInTheEastScenario
    {
        private const string name = "Challenge of the Wainriders";

        public ChallengeOfTheWainridersScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Vengeance of Mordor";
            Number = 3;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC80.pdf";
            RulesImageCount = 2;

            QuestCompanionSlug = "vengeance-of-mordor-cycle-quest-challenge-of-the-wainriders";
            DifficultyRating = 6.9f;
            Votes = 8;

            AddEncounterSet(EncounterSet.ChallengeOfTheWainriders);
            AddEncounterSet(EncounterSet.RollingPlains);
            AddEncounterSet(EncounterSet.RidersOfRhun);

            AddQuestCardId("Wainrider-Camp-CotW");
            AddQuestCardId("First-Sprint-CotW");
            AddQuestCardId("The-Turnaround-CotW");
            AddQuestCardId("The-Farthest-Edge-CotW");
            AddQuestCardId("Last-Climb-CotW");
            AddQuestCardId("Home-Stretch-CotW");

            ExcludeRollingPlainsFromEasyMode();
            ExcludeRidersOfRhunFromEasyMode();

            ExcludeFromEasyMode("Aggressive-Racer-CotW", 1);
            ExcludeFromEasyMode("Chariot-Driver-CotW", 1);
            ExcludeFromEasyMode("Crowded-Track-CotW", 1);
            ExcludeFromEasyMode("Ravine-Ledge-CotW", 1);
            ExcludeFromEasyMode("Wainrider-Chariot-CotW", 1);
            ExcludeFromEasyMode("The-Champion's-Cunning-CotW", 1);
        }
    }
}