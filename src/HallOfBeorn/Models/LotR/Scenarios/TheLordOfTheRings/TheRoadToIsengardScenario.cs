namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class TheRoadToIsengardScenario : Scenario
    {
        public TheRoadToIsengardScenario()
        {
            Title = "The Road to Isengard";
            ProductName = "The Treason of Saruman";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 9;

            QuestCompanionSlug = "lotr-the-treason-of-saruman-saga-expansion-quest-the-road-to-isengard";
            DifficultyRating = 6.9f;
            Votes = 22;

            AddTheLineUnbrokenLink("C9", "6EbEiwbBEMI");

            AddEncounterSet(EncounterSet.SnagaOrcs);
            AddEncounterSet(EncounterSet.TheRoadToIsengard);

            AddQuestCardId("Rouse-the-Ents-ToS");
            AddQuestCardId("Breaking-Isengard-ToS");
            AddQuestCardId("The-Voice-of-Saruman-ToS");

            ExcludeFromEasyMode("Saruman's-Orders-ToS", 1);
            ExcludeFromEasyMode("Snaga-ToS", 1);
            ExcludeFromEasyMode("Gríma-ToS", 1);
            ExcludeFromEasyMode("Plain-of-Isengard-ToS", 1);
            ExcludeFromEasyMode("Poisoned-Vapour-ToS", 2);
            ExcludeFromEasyMode("Steaming-Vent-ToS", 2);
            ExcludeFromEasyMode("Underground-Armoury-ToS", 1);
            ExcludeFromEasyMode("Wolf-of-Isengard-ToS", 1);

        }
    }
}
