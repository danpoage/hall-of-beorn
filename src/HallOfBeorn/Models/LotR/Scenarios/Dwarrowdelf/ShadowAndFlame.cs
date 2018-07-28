namespace HallOfBeorn.Models.LotR.Scenarios.Dwarrowdelf
{
    public class ShadowAndFlame : Scenario
    {
        public ShadowAndFlame()
        {
            Title = "Shadow and Flame";
            ProductName = "Shadow and Flame";
            GroupName = "Dwarrowdelf";
            Number = 6;

            QuestCompanionSlug = "dwarrowdelf-quest-shadow-and-flame";
            DifficultyRating = 7.9f;
            Votes = 59;

            AddTheLineUnbrokenLink("18", "Or-4_WHvtmo");

            AddEncounterSet(EncounterSet.DeepsOfMoria);
            AddEncounterSet(EncounterSet.GoblinsOfTheDeep);
            AddEncounterSet(EncounterSet.ShadowAndFlame);
            AddEncounterSet(EncounterSet.ShadowAndFlameNightmare);

            AddQuestCardId("Nearing-the-Gate-SaF");
            AddQuestCardId("The-Rear-Guard-SaF");
            AddQuestCardId("Last-Lord-of-Moria-SaF");

            ExcludeFromEasyMode("Great-Cave-troll-KD", 2);
            ExcludeFromEasyMode("Massing-in-the-Deep-KD", 2);
            ExcludeFromEasyMode("Orc-Drummer-KD", 1);
            ExcludeFromEasyMode("Watchful-Eyes-KD", 3);
            ExcludeFromEasyMode("Counter-Spell-SaF", 2);
            ExcludeFromEasyMode("Fires-in-the-Deep-SaF", 2);
            ExcludeFromEasyMode("Leaping-Flame-SaF", 2);

            ExcludeFromNightmareMode("Stray-Goblin-KD", 3);
            ExcludeFromNightmareMode("The-Mountains'-Roots-KD", 3);
            ExcludeFromNightmareMode("Goblin-Scout-KD", 3);
            ExcludeFromNightmareMode("Goblin-Tunnels-KD", 2);
            ExcludeFromNightmareMode("Fiery-Sword-SaF", 1);
            ExcludeFromNightmareMode("Many-Thonged-Whip-SaF", 1);
            ExcludeFromNightmareMode("Ranging-Goblin-SaF", 3);
        }
    }
}
