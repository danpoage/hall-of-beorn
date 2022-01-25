namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class TheRoadToIsengardScenario : Scenario
    {
        public TheRoadToIsengardScenario()
            : base(true)
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
            AddEncounterSet(EncounterSet.TheRoadToIsengardNightmare);

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

            ExcludeFromNightmareMode("Snaga-ToS", 3);
            ExcludeFromNightmareMode("Ring-wall-of-Isengard-ToS", 1);
            ExcludeFromNightmareMode("Open-Pit-ToS", 2);
            ExcludeFromNightmareMode("Machines-of-Isengard-ToS", 1);
            ExcludeFromNightmareMode("Blast-of-Sorcery-ToS", 3);
        }
    }
}
