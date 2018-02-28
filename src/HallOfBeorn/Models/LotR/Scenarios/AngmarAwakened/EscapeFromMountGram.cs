namespace HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened
{
    public class EscapeFromMountGram : Scenario
    {
        public EscapeFromMountGram()
        {
            Title = "Escape from Mount Gram";
            ProductName = "Escape from Mount Gram";
            GroupName = "Angmar Awakened";
            Number = 2;

            QuestCompanionSlug = "angmar-awakened-quest-escape-from-mount-gram";

            AddEncounterSet(EncounterSet.AngmarOrcs);
            AddEncounterSet(EncounterSet.EscapeFromMountGram);
            AddEncounterSet(EncounterSet.EscapeFromMountGramNightmare);

            AddQuestCardId("Unexpected-Rescue-EfMG");
            AddQuestCardId("Gornakh's-Dungeons-EfMG");
            AddQuestCardId("Flight-from-Mount-Gram-EfMG");

            ExcludeFromEasyMode("Angmar-Captain-TLR", 1);
            ExcludeFromEasyMode("Angmar-Marauder-TLR", 1);
            ExcludeFromEasyMode("Captives-of-Gornakh-EfMG", 1);
            ExcludeFromEasyMode("Goblin-Tormentor-EfMG", 2);
            ExcludeFromEasyMode("Sound-the-Alarm-EfMG", 1);

            ExcludeFromNightmareMode("Prison-Cell-EfMG", 4);
            ExcludeFromNightmareMode("Dungeon-Guard-EfMG", 3);
            ExcludeFromNightmareMode("Jailor-Gornakh-EfMG", 1);
            ExcludeFromNightmareMode("Interrogation-EfMG", 2);
            ExcludeFromNightmareMode("Goblin-Tormentor-EfMG", 1);
            ExcludeFromNightmareMode("Cruel-Torturer-EfMG", 1);
        }
    }
}
