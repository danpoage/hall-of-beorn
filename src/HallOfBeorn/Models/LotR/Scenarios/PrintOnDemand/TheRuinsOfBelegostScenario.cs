namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class TheRuinsOfBelegostScenario : Scenario
    {
        public TheRuinsOfBelegostScenario()
        {
            Title = "The Ruins of Belegost";
            ProductName = "2015";
            GroupName = ScenarioGroup.GenConDecks;
            IsSubGroup = true;
            Number = 6;

            QuestCompanionSlug = "print-on-demand-quest-the-ruins-of-belegost";
            DifficultyRating = 8.1f;
            Votes = 14;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2021/01/04/the-ruins-of-belegost/");

            AddTheLineUnbrokenLink("G6", "hg-QXsiOiyE");
            AddTheLineUnbrokenLink("G6.2", "6on97G5zkRY");
            AddMrUnderhillLink(Title + " - Two Players", "vhNz23-wrqc");
            AddMrUnderhillLink("Return to " + Title + " - Two Players", "LzX_wTItaGg");

            AddEncounterSet(EncounterSet.TheRuinsOfBelegost);

            AddQuestCardId("Ruins-of-the-First-Age-TRoB");
            AddQuestCardId("Ancient-Evils-Disturbed-TRoB");
            AddQuestCardId("Deeper-into-the-Past-C-TRoB");
            AddQuestCardId("The-Servants-of-Morgoth-TRoB");
            AddQuestCardId("The-Roots-of-Ered-Luin-C-TRoB");
            AddQuestCardId("The-Mines-of-Belegost-E-TRoB");
            AddQuestCardId("The-Beast-of-Belegost-TRoB");

            ExcludeFromEasyMode("Flooded-Hall-TRoB", 2);
            ExcludeFromEasyMode("Old-Stone-Troll-TRoB", 2);
            ExcludeFromEasyMode("Spawn-of-Thangorodrim-TRoB", 2);

        }
    }
}
