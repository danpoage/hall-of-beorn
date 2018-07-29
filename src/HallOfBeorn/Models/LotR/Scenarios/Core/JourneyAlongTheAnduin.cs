namespace HallOfBeorn.Models.LotR.Scenarios.Core
{
    public class JourneyAlongTheAnduin : Scenario
    {
        public JourneyAlongTheAnduin()
        {
            Title = "Journey Along the Anduin";
            AlternateTitle = "Journey Down the Anduin";
            ProductName = "Core Set";
            GroupName = "Core Set";
            Number = 2;

            QuestCompanionSlug = "core-set-quest-journey-down-the-anduin";

            DifficultyRating = 5.3f;
            Votes = 160;

            AddProgressionSeriesLink("2", "Lx5RL9_0yBA");
            AddTheLineUnbrokenLink("2.1", "Fpv3YJAoHNk");
            AddTheLineUnbrokenLink("N2", "k84HvCq6uRo");
            AddMrUnderhillLink(Title + " Nightmare Mode, Attempt One", "IaO8wJmLt_I");
            AddMrUnderhillLink(Title + " Nightmare Mode, Attempt Two", "LwsqbhhOA1c");
            AddLotRDeckTechLink("Rossiel, Keen as Lances vs The Anduin", "PlQrthtPULc");
            AddLotRDeckTechLink("Argalad Along the Anduin", "bICTQO1uVUo");
            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2013/02/04/beorns-path-part-4-journey-along-the-anduin/");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2016/11/06/journey-along-the-anduin/");

            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduin);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduinNightmare);
            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.Wilderlands);

            AddQuestCardId("To-the-River-Core");
            AddQuestCardId("Anduin-Passage-Core");
            AddQuestCardId("Ambush-on-the-Shore-Core");

            ExcludeFromEasyMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-Core", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-Core", 2);
            ExcludeFromEasyMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromEasyMode("Gladden-Fields-Core", 2);
            ExcludeFromEasyMode("Massing-at-Night-Core", 1);
            ExcludeFromEasyMode("Eastern-Crows-Core", 2);
            ExcludeFromEasyMode("Evil-Storm-Core", 1);
            ExcludeFromEasyMode("Despair-Core", 2);
            ExcludeFromEasyMode("Hill-Troll-Core", 1);
            ExcludeFromEasyMode("Marsh-Adder-Core", 1);

            ExcludeFromNightmareMode("Evil-Storm-Core", 3);
            ExcludeFromNightmareMode("Treacherous-Fog-Core", 2);
            ExcludeFromNightmareMode("Banks-of-the-Anduin-Core", 2);
            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Enemy-Core", 3);
            ExcludeFromNightmareMode("Enchanted-Stream-Core", 2);
            ExcludeFromNightmareMode("Despair-Core", 2);
            ExcludeFromNightmareMode("Misty-Mountain-Goblins-Core", 3);
            ExcludeFromNightmareMode("Necromancer's-Pass-Core", 2);
        }
    }
}
