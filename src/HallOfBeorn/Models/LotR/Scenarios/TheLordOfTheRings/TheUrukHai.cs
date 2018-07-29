namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class TheUrukHai : Scenario
    {
        public TheUrukHai()
        {
            Title = "The Uruk-hai";
            ProductName = "The Treason of Saruman";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 7;

            QuestCompanionSlug = "lotr-the-treason-of-saruman-saga-expansion-quest-the-uruk-hai";
            DifficultyRating = 6.0f;
            Votes = 23;

            AddTheLineUnbrokenLink("C7", "wlUBoRQxUgo");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2018/07/10/nightmare-review-the-uruk-hai-nightmare-campaign-part-7/", "Nightmare " + Title);

            AddEncounterSet(EncounterSet.OrcsOfTheWhiteHand);
            AddEncounterSet(EncounterSet.SnagaOrcs);
            AddEncounterSet(EncounterSet.TheUrukHai);

            AddQuestCardId("Follow-the-Orcs-ToS");
            AddQuestCardId("Rescue-the-Captives-ToS");

            ExcludeFromEasyMode("Fighting-Uruk-hai-ToS", 1);
            ExcludeFromEasyMode("Isengard-Uruk-ToS", 1);
            ExcludeFromEasyMode("Saruman's-Orders-ToS", 1);
            ExcludeFromEasyMode("Snaga-ToS", 1);
            ExcludeFromEasyMode("Plains-of-Rohan-ToS", 1);
            ExcludeFromEasyMode("Strange-Weariness-ToS", 1);
            ExcludeFromEasyMode("Ugluk's-Uruk-hai-ToS", 2);

        }
    }
}
