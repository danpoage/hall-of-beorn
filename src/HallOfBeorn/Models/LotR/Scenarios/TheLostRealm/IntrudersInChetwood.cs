namespace HallOfBeorn.Models.LotR.Scenarios.TheLostRealm
{
    public class IntrudersInChetwood : Scenario
    {
        public IntrudersInChetwood()
        {
            Title = "Intruders in Chetwood";
            ProductName = "The Lost Realm";
            GroupName = "The Lost Realm";
            Number = 1;

            QuestCompanionSlug = "the-lost-realm-quest-intruders-in-chetwood";
            DifficultyRating = 5.7f;
            Votes = 39;

            AddEncounterSet(EncounterSet.AngmarOrcs);
            AddEncounterSet(EncounterSet.EriadorWilds);
            AddEncounterSet(EncounterSet.Iarion);
            AddEncounterSet(EncounterSet.IntrudersInChetwood);
            AddEncounterSet(EncounterSet.IntrudersInChetwoodNightmare);

            AddQuestCardId("Stop-the-War-Party-TLR");

            ExcludeFromEasyMode("Angmar-Captain-TLR", 1);
            ExcludeFromEasyMode("Angmar-Marauder-TLR", 1);
            ExcludeFromEasyMode("Pressing-Needs-TLR", 1);
            ExcludeFromEasyMode("Shrouded-Hills-TLR", 1);
            ExcludeFromEasyMode("Weight-of-Responsibility-TLR", 1);
            ExcludeFromEasyMode("Chetwood-Forest-TLR", 1);
            ExcludeFromEasyMode("Cornered-Orc-TLR", 1);
            ExcludeFromEasyMode("Orc-War-Party-TLR", 2);
            ExcludeFromEasyMode("Outlying-Homestead-TLR", 1);
            ExcludeFromEasyMode("Sudden-Assault-TLR", 2);
            ExcludeFromEasyMode("Surprising-Speed-TLR", 1);

            ExcludeFromNightmareMode("Angmar-Orc-TLR", 1);
            ExcludeFromNightmareMode("Angmar-Marauder-TLR", 3);
            ExcludeFromNightmareMode("Chetwood-Forest-TLR", 2);
            ExcludeFromNightmareMode("Outlying-Homestead-TLR", 1);
            ExcludeFromNightmareMode("Borders-of-Bree-land-TLR", 2);
            ExcludeFromNightmareMode("Rugged-Country-TLR", 1);
            ExcludeFromNightmareMode("Shrouded-Hills-TLR", 1);
            ExcludeFromNightmareMode("Surprising-Speed-TLR", 3);
            ExcludeFromNightmareMode("Sudden-Assault-TLR", 2);
        }
    }
}
