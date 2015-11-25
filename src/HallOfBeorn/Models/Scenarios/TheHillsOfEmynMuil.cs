namespace HallOfBeorn.Models.Scenarios
{
    public class TheHillsOfEmynMuil : Scenario
    {
        public TheHillsOfEmynMuil()
        {
            Title = "The Hills of Emyn Muil";
            ProductName = "The Hills of Emyn Muil";
            GroupName = "Shadows of Mirkwood";
            Number = 0;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/shadows-of-mirkwood-quest-the-hills-of-emyn-muil.html";

            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.TheHillsOfEmynMuil);
            AddEncounterSet(EncounterSet.TheHillsOfEmynMuilNightmare);

            AddQuestCardId("The-Hills-of-Emyn-Muil-Quest-THoEM");

            ExcludeFromEasyMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-Core", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-Core", 2);
            ExcludeFromEasyMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromEasyMode("Eastern-Crows-Core", 2);
            ExcludeFromEasyMode("Evil-Storm-Core", 1);
            ExcludeFromEasyMode("Impassable-Chasm-THoEM", 2);
            ExcludeFromEasyMode("Orc-Horse-Thieves-THoEM", 1);
            ExcludeFromEasyMode("Rockslide-THoEM", 2);
            ExcludeFromEasyMode("The-East-Wall-of-Rohan-THoEM", 2);

            ExcludeFromNightmareMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromNightmareMode("Dol-Guldur-Beastmaster-Core", 2);
            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Enemy-Core", 2);
            ExcludeFromNightmareMode("Enchanted-Stream-Core", 2);
            ExcludeFromNightmareMode("Necromancer's-Pass-Core", 2);
            ExcludeFromNightmareMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromNightmareMode("Evil-Storm-Core", 3);
            ExcludeFromNightmareMode("Pursued-by-Shadow-Core", 2);
            ExcludeFromNightmareMode("Impassable-Chasm-THoEM", 2);
            ExcludeFromNightmareMode("Slick-Footing-THoEM", 2);
            ExcludeFromNightmareMode("The-East-Wall-of-Rohan-THoEM", 1);
            ExcludeFromNightmareMode("The-Highlands-THoEM", 4);
            ExcludeFromNightmareMode("The-North-Stair-THoEM", 1);
            ExcludeFromNightmareMode("The-Shores-of-Nen-Hithoel-THoEM", 2);
        }
    }
}
