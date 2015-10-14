namespace HallOfBeorn.Models.Scenarios
{
    public class DungeonsDeepAndCavernsDim : Scenario
    {
        public DungeonsDeepAndCavernsDim()
        {
            Title = "Dungeons Deep and Caverns Dim";
            ProductName = "The Hobbit: Over Hill and Under Hill";
            GroupName = "The Hobbit";
            Number = 3;

            AddEncounterSet(EncounterSet.DungeonsDeepAndCavernsDim);
            AddEncounterSet(EncounterSet.DungeonsDeepAndCavernsDimNightmare);
            AddEncounterSet(EncounterSet.MistyMountainGoblins);

            AddQuestCardId("Out-of-the-Frying-Pan-THOHaUH");
            AddQuestCardId("Riddles-in-the-Dark-THOHaUH");
            AddQuestCardId("Into-the-Fire-THOHaUH");

            ExcludeFromEasyMode("Come-Down-Little-Bird-THOHaUH", 1);
            ExcludeFromEasyMode("Great-Gray-Wolf-THOHaUH", 1);
            ExcludeFromEasyMode("Hiding-in-the-Trees-THOHaUH", 1);
            ExcludeFromEasyMode("Goblin-Runners-THOHaUH", 2);
            ExcludeFromEasyMode("Grip-Grab-Pinch-Nab-THOHaUH", 3);
            ExcludeFromEasyMode("The-Goblins'-Caves-THOHaUH", 1);

            ExcludeFromNightmareMode("Not-Fair-Not-Fair-THOHaUH", 1);
            ExcludeFromNightmareMode("Goblin-Axeman-THOHaUH", 3);
            ExcludeFromNightmareMode("Goblin-Miners-THOHaUH", 3);
            ExcludeFromNightmareMode("Grip-Grab-Pinch-Nab-THOHaUH", 3);
            ExcludeFromNightmareMode("The-Goblins'-Caves-THOHaUH", 3);
        }
    }
}
