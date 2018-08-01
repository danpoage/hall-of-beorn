namespace HallOfBeorn.Models.LotR.Scenarios.TheLostRealm
{
    public class DeadmensDike : HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened.AngmarAwakenedScenario
    {
        public DeadmensDike()
        {
            Title = "Deadmen's Dike";
            ProductName = "The Lost Realm";
            GroupName = "The Lost Realm";
            Number = 3;

            QuestCompanionSlug = "the-lost-realm-quest-deadmens-dike";
            DifficultyRating = 7.7f;
            Votes = 30;

            AddTheGreyCompanyLink(Title, "Dhr_KfxWrQk");
            AddTheLineUnbrokenLink("45", "rEIshIfPXPY");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2017/09/05/path-less-traveled-deadmens-dike/");

            AddEncounterSet(EncounterSet.CursedDead);
            AddEncounterSet(EncounterSet.DarkSorcery);
            AddEncounterSet(EncounterSet.DeadmensDike);
            AddEncounterSet(EncounterSet.DeadmensDikeNightmare);
            AddEncounterSet(EncounterSet.Iarion);

            AddQuestCardId("The-Shades-of-Angmar-TLR");
            AddQuestCardId("A-Fell-Wraith-TLR");

            ExcludeDarkSorceryFromEasyMode();
            ExcludeCursedDeadFromEasyMode();
            
            ExcludeFromEasyMode("Broken-Battlements-TLR", 1);
            ExcludeFromEasyMode("Deadmen's-Gate-TLR", 1);
            ExcludeFromEasyMode("Haunted-Keep-TLR", 1);
            ExcludeFromEasyMode("Thaurdir's-Damned-TLR", 2);
            ExcludeFromEasyMode("Unnatural-Fog-TLR", 1);

            ExcludeFromNightmareMode("Fornost-Square-TLR", 2);
            ExcludeFromNightmareMode("Broken-Battlements-TLR", 3);
            ExcludeFromNightmareMode("Norbury-Tombs-TLR", 2);
            ExcludeFromNightmareMode("Restless-Evil-TLR", 2);
        }
    }
}
