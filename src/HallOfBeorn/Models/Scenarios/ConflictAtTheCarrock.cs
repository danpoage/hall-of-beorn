namespace HallOfBeorn.Models.Scenarios
{
    public class ConflictAtTheCarrock : Scenario
    {
        public ConflictAtTheCarrock()
        {
            Title = "Conflict at the Carrock";
            ProductName = "Conflict at the Carrock";
            GroupName = "Shadows of Mirkwood";
            Number = 0;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/shadows-of-mirkwood-quest-conflict-at-the-carrock.html";

            AddEncounterSet(EncounterSet.ConflictAtTheCarrock);
            AddEncounterSet(EncounterSet.ConflictAtTheCarrockNightmare);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduin);
            AddEncounterSet(EncounterSet.Wilderlands);

            AddQuestCardId("Grimbeorn's-Quest-CatC");
            AddQuestCardId("Against-the-Trolls-CatC");
            AddQuestCardId("Grimbeorn's-Folly-CatCN");

            ExcludeFromEasyMode("A-Frightened-Beast-CatC", 2);
            ExcludeFromEasyMode("Muck-Adder-CatC", 2);
            ExcludeFromEasyMode("River-Langflood-CatC", 2);
            ExcludeFromEasyMode("Roasted-Slowly-CatC", 2);
            ExcludeFromEasyMode("Sacked-CatC", 1);
            ExcludeFromEasyMode("Gladden-Fields-Core", 2);
            ExcludeFromEasyMode("Massing-at-Night-Core", 1);
            ExcludeFromEasyMode("Despair-Core", 2);
            ExcludeFromEasyMode("Hill-Troll-Core", 1);
            ExcludeFromEasyMode("Marsh-Adder-Core", 1);

            ExcludeFromNightmareMode("Bee-Pastures-CatC", 3);
            ExcludeFromNightmareMode("Grimbeorn-the-Old-CatC", 1);
            ExcludeFromNightmareMode("Louis-CatC", 1);
            ExcludeFromNightmareMode("Morris-CatC", 1);
            ExcludeFromNightmareMode("Oak-wood-Grove-CatC", 3);
            ExcludeFromNightmareMode("Roasted-Slowly-CatC", 1);
            ExcludeFromNightmareMode("Rupert-CatC", 1);
            ExcludeFromNightmareMode("Stuart-CatC", 1);
            ExcludeFromNightmareMode("Banks-of-the-Anduin-Core", 2);
            ExcludeFromNightmareMode("Misty-Mountain-Goblins-Core", 3);
            ExcludeFromNightmareMode("Despair-Core", 2);
            ExcludeFromNightmareMode("Goblin-Sniper-Core", 2);
            ExcludeFromNightmareMode("The-Brown-Lands-Core", 2);
            ExcludeFromNightmareMode("The-East-Bight-Core", 2);
            ExcludeFromNightmareMode("Wargs-Core", 2);
            ExcludeFromNightmareMode("Wolf-Rider-Core", 1);
        }
    }
}
