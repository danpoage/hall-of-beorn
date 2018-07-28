namespace HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow
{
    public class AssaultOnOsgiliath : Scenario
    {
        public AssaultOnOsgiliath()
        {
            Title = "Assault on Osgiliath";
            ProductName = "Assault on Osgiliath";
            GroupName = "Against the Shadow";
            Number = 4;

            QuestCompanionSlug = "against-the-shadow-quest-assault-on-osgiliath";
            DifficultyRating = 5.2f;
            Votes = 44;

            AddTheLineUnbrokenLink("31", "t3l__Hzubmc");

            AddEncounterSet(EncounterSet.AssaultOnOsgiliath);
            AddEncounterSet(EncounterSet.AssaultOnOsgiliathNightmare);
            AddEncounterSet(EncounterSet.MordorElite);
            AddEncounterSet(EncounterSet.Southrons);

            AddQuestCardId("Retake-the-City-AoO");

            ExcludeFromEasyMode("Counter-attack-AoO", 1);
            ExcludeFromEasyMode("East-Quarter-AoO", 1);
            ExcludeFromEasyMode("Southron-Commander-AoO", 2);
            ExcludeFromEasyMode("Uruk-Lieutenant-AoO", 2);
            ExcludeFromEasyMode("West-Quarter-AoO", 1);
            ExcludeFromEasyMode("Orc-Vanguard-HoN", 2);
            ExcludeFromEasyMode("Orc-War-Camp-HoN", 2);
            ExcludeFromEasyMode("The-Master's-Malice-HoN", 2);
            ExcludeFromEasyMode("Mumak-HoN", 1);
            ExcludeFromEasyMode("Southron-Support-HoN", 2);

            ExcludeFromNightmareMode("East-Quarter-AoO", 2);
            ExcludeFromNightmareMode("Ruined-Square-AoO", 1);
            ExcludeFromNightmareMode("Ruined-Tower-AoO", 1);
            ExcludeFromNightmareMode("Southron-Phalanx-AoO", 3);
            ExcludeFromNightmareMode("Street-Fighting-AoO", 2);
            ExcludeFromNightmareMode("Uruk-Lieutenant-AoO", 1);
            ExcludeFromNightmareMode("Uruk-Soldier-AoO", 4);
            ExcludeFromNightmareMode("West-Quarter-AoO", 2);
            ExcludeFromNightmareMode("The-Master's-Malice-HoN", 2);
            ExcludeFromNightmareMode("The-Power-of-Mordor-HoN", 1);
            ExcludeFromNightmareMode("Southron-Mercenaries-HoN", 3);
        }
    }
}
