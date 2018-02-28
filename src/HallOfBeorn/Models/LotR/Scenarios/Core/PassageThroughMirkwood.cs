namespace HallOfBeorn.Models.LotR.Scenarios.Core
{
    public class PassageThroughMirkwood : Scenario
    {
        public PassageThroughMirkwood()
        {
            Title = "Passage Through Mirkwood";
            ProductName = "Core Set";
            GroupName = "Core Set";
            Number = 1;

            QuestCompanionSlug = "core-set-quest-passage-through-mirkwood";

            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.PassageThroughMirkwood);
            AddEncounterSet(EncounterSet.PassageThroughMirkwoodNightmare);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);

            AddQuestCardId("Flies-and-Spiders-Core");
            AddQuestCardId("A-Fork-in-the-Road-Core");
            AddQuestCardId("A-Chosen-Path-Don't-Leave-the-Path-Core");
            AddQuestCardId("A-Chosen-Path-Beorn's-Path-Core");

            ExcludeFromEasyMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-Core", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-Core", 2);
            ExcludeFromEasyMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromEasyMode("Caught-in-a-Web-Core", 2);
            ExcludeFromEasyMode("Eyes-of-the-Forest-Core", 1);
            ExcludeFromEasyMode("Hummerhorns-Core", 1);

            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Enemy-Core", 3);
            ExcludeFromNightmareMode("Black-Forest-Bats-Core", 1);
            ExcludeFromNightmareMode("Forest-Gate-Core", 2);
            ExcludeFromNightmareMode("Forest-Spider-Core", 3);
            ExcludeFromNightmareMode("Old-Forest-Road-Core", 1);
            ExcludeFromNightmareMode("Caught-in-a-Web-Core", 2);
            ExcludeFromNightmareMode("Mountains-of-Mirkwood-Core", 3);
            ExcludeFromNightmareMode("Ungoliant's-Spawn-Core", 1);
        }
    }
}
