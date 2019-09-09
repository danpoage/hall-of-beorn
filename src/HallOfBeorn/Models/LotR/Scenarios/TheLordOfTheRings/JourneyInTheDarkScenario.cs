namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class JourneyInTheDarkScenario : Scenario
    {
        public JourneyInTheDarkScenario()
        {
            Title = "Journey in the Dark";
            ProductName = "The Road Darkens";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 5;

            QuestCompanionSlug = "lotr-the-road-darkens-quest-journey-in-the-dark";
            DifficultyRating = 7.9f;
            Votes = 32;

            AddTheLineUnbrokenLink("C5", "SrQe0OW8lgA");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2018/06/12/path-less-traveled-journey-in-the-dark/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2017/08/29/nightmare-review-journey-in-the-darknightmare-campaign-part-5/", "Nightmare " + Title);
            AddTheRoadLink(8, "https://theroadlotr.wordpress.com/journey-in-the-dark/");

            AddEncounterSet(EncounterSet.JourneyInTheDark);
            AddEncounterSet(EncounterSet.JourneyInTheDarkNightmare);

            AddQuestCardId("The-Long-Dark-of-Moria-RD");
            AddQuestCardId("Drums-in-the-Deep-RD");
            AddQuestCardId("The-Bridge-of-Khazad-dum-RD");

            ExcludeFromEasyMode("Darkened-Stairway-RD", 1);
            ExcludeFromEasyMode("Fool-of-a-Took-RD", 1);
            ExcludeFromEasyMode("Great-Cave-troll-RD", 1);
            ExcludeFromEasyMode("Many-pillared-Hall-RD", 1);
            ExcludeFromEasyMode("Moria-Archer-RD", 1);
            ExcludeFromEasyMode("They-Are-Coming-RD", 1);
            ExcludeFromEasyMode("Uruk-from-Mordor-RD", 1);
            ExcludeFromEasyMode("We-Cannot-Get-Out-RD", 1);

            ExcludeFromNightmareMode("Moria-Archer-RD", 3);
            ExcludeFromNightmareMode("Mines-of-Moria-RD", 4);
            ExcludeFromNightmareMode("We-Cannot-Get-Out-RD", 1);
            ExcludeFromNightmareMode("Deep-Fissure-RD", 3);
        }
    }
}
