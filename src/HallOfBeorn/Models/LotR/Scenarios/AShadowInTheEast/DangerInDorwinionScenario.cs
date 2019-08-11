using System;

namespace HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast
{
    public class DangerInDorwinionScenario : AShadowInTheEastScenario
    {
        private const string name = "Danger in Dorwinion";

        public DangerInDorwinionScenario()
        {
            Title = name;
            ProductName = "A Shadow in the East";
            GroupName = "A Shadow in the East";
            Number = 2;

            //RulesImageCount = 2;

            //QuestCompanionSlug = "a-shadow-in-the-east-danger-in-dorwinion";
            DifficultyRating = 7.4f;
            Votes = 1;

            AddEncounterSet(EncounterSet.DangerInDorwinion);
            AddEncounterSet(EncounterSet.ServantsOfSauron);
            AddEncounterSet(EncounterSet.CityOfRhun);
            AddEncounterSet(EncounterSet.UnderGuard);

            AddQuestCardId("A-City-in-Turmoil-ASitE");
            AddQuestCardId("The-Shadow-of-Mordor-ASitE");
            AddQuestCardId("Leader-of-the-Cult-ASitE");

            ExcludeDangerInDorwinionFromEasyMode();
            ExcludeServantsOfSauronFromEasyMode();
            ExcludeCityOfRhunFromEasyMode();
            ExcludeUnderGuardFromEasyMode();
        }
    }
}
