namespace HallOfBeorn.Models.LotR.Scenarios.ShadowsOfMirkwood
{
    public class TheDeadMarshes : Scenario
    {
        public TheDeadMarshes()
        {
            Title = "The Dead Marshes";
            ProductName = "The Dead Marshes";
            GroupName = "Shadows of Mirkwood";
            Number = 5;

            QuestCompanionSlug = "shadows-of-mirkwood-quest-the-dead-marshes";

            DifficultyRating = 3.8f;
            Votes = 84;

            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2013/09/12/beorns-path-part-12-the-dead-marshes/");

            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.TheDeadMarshes);
            AddEncounterSet(EncounterSet.TheDeadMarshesNightmare);
            AddEncounterSet(EncounterSet.Wilderlands);

            AddQuestCardId("Into-the-Marshes-TDM");
            AddQuestCardId("The-Capture-TDM");

            ExcludeFromEasyMode("Eastern-Crows-Core", 2);
            ExcludeFromEasyMode("Evil-Storm-Core", 1);
            ExcludeFromEasyMode("A-Wisp-of-Pale-Sheen-TDM", 2);
            ExcludeFromEasyMode("Giant-Marsh-Worm-TDM", 2);
            ExcludeFromEasyMode("Impassable-Bog-TDM", 2);
            ExcludeFromEasyMode("The-Heart-of-the-Marshes-TDM", 2);
            ExcludeFromEasyMode("The-Lights-of-the-Dead-TDM", 2);
            ExcludeFromEasyMode("Despair-Core", 2);
            ExcludeFromEasyMode("Hill-Troll-Core", 1);
            ExcludeFromEasyMode("Marsh-Adder-Core", 1);

            ExcludeFromNightmareMode("Eastern-Crows-Core", 3);
            ExcludeFromNightmareMode("Pursued-by-Shadow-Core", 2);
            ExcludeFromNightmareMode("Treacherous-Fog-Core", 2);
            ExcludeFromNightmareMode("A-Wisp-of-Pale-Sheen-TDM", 1);
            ExcludeFromNightmareMode("Fens-and-Mires-TDM", 4);
            ExcludeFromNightmareMode("Through-the-Mist-TDM", 1);
            ExcludeFromNightmareMode("Despair-Core", 2);
            ExcludeFromNightmareMode("Goblin-Sniper-Core", 2);
            ExcludeFromNightmareMode("Hill-Troll-Core", 2);
            ExcludeFromNightmareMode("The-Brown-Lands-Core", 2);
            ExcludeFromNightmareMode("The-East-Bight-Core", 2);
            ExcludeFromNightmareMode("Wargs-Core", 2);
            ExcludeFromNightmareMode("Wolf-Rider-Core", 1);
        }
    }
}
