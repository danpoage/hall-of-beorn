namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class JourneyToTheCrossRoads : Scenario
    {
        public JourneyToTheCrossRoads()
            : base(true)
        {
            Title = "Journey to the Cross-roads";
            ProductName = "The Land of Shadow";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 11;

            QuestCompanionSlug = "lotr-the-land-of-shadow-saga-expansion-quest-journey-to-the-cross-roads";
            DifficultyRating = 7.9f;
            Votes = 21;

            AddTheLineUnbrokenLink("C11", "_WXE3XE8PYE");
            AddTheLineUnbrokenLink("C11.2", "Uwh4BPZlt_w");
            AddTheRoadLink(15, "https://theroadlotr.wordpress.com/journey-to-the-cross-roads/");

            AddEncounterSet(EncounterSet.MenOfHarad);
            AddEncounterSet(EncounterSet.JourneyToTheCrossRoads);
            AddEncounterSet(EncounterSet.JourneyToTheCrossRoadsNightmare);

            AddQuestCardId("Ambush-the-Men-of-Harad-TLoS");

            ExcludeFromEasyMode("Captain-of-Harad-TLoS", 1);
            ExcludeFromEasyMode("Fierce-Southrons-TLoS", 1);
            ExcludeFromEasyMode("Marching-Up-the-Road-TLoS", 1);
            ExcludeFromEasyMode("Southward-Road-TLoS", 1);

            ExcludeFromNightmareMode("Captain-of-Harad-TLoS", 1);
            ExcludeFromNightmareMode("Henneth-Annun-TLoS", 1);
            ExcludeFromNightmareMode("Southward-Road-TLoS", 2);
            ExcludeFromNightmareMode("Hills-of-Ithilien-TLoS", 4);
            ExcludeFromNightmareMode("The-Dark-Lord's-Summons-TLoS", 3);
        }
    }
}
