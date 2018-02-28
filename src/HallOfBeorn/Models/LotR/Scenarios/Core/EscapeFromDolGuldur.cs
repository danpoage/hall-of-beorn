namespace HallOfBeorn.Models.LotR.Scenarios.Core
{
    public class EscapeFromDolGuldur : Scenario
    {
        public EscapeFromDolGuldur()
        {
            Title = "Escape from Dol Guldur";
            ProductName = "Core Set";
            GroupName = "Core Set";
            Number = 3;

            QuestCompanionSlug = "core-set-quest-escape-from-dol-guldur";

            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.EscapeFromDolGuldur);
            AddEncounterSet(EncounterSet.EscapeFromDolGuldurNightmare);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);

            AddQuestCardId("The-Necromancer's-Tower-Core");
            AddQuestCardId("Through-the-Caverns-Core");
            AddQuestCardId("Out-of-the-Dungeons-Core");

            ExcludeFromEasyMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-Core", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-Core", 2);
            ExcludeFromEasyMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromEasyMode("Dungeon-Jailor-Core", 2);
            ExcludeFromEasyMode("Caught-in-a-Web-Core", 2);
            ExcludeFromEasyMode("Eyes-of-the-Forest-Core", 1);
            ExcludeFromEasyMode("Hummerhorns-Core", 1);

            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Enemy-Core", 2);
            ExcludeFromNightmareMode("Enchanted-Stream-Core", 2);
            ExcludeFromNightmareMode("Necromancer's-Pass-Core", 1);
            ExcludeFromNightmareMode("The-Necromancer's-Reach-Core", 1);
            ExcludeFromNightmareMode("Iron-Shackles-Core", 1);
            ExcludeFromNightmareMode("Tower-Gate-Core", 2);
            ExcludeFromNightmareMode("Under-the-Shadow-Core", 2);
            ExcludeFromNightmareMode("Caught-in-a-Web-Core", 2);
            ExcludeFromNightmareMode("Great-Forest-Web-Core", 1);
            ExcludeFromNightmareMode("Mountains-of-Mirkwood-Core", 3);
        }
    }
}
