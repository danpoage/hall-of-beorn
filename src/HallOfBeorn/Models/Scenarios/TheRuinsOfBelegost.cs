namespace HallOfBeorn.Models.Scenarios
{
    public class TheRuinsOfBelegost : Scenario
    {
        public TheRuinsOfBelegost()
        {
            Title = "The Ruins of Belegost";
            ProductName = "The Ruins of Belegost";
            GroupName = "GenCon";
            Number = 6;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/print-on-demand-quest-the-ruins-of-belegost.html";

            AddEncounterSet(EncounterSet.TheRuinsOfBelegost);

            AddQuestCardId("Ruins-of-the-First-Age-TRoB");
            AddQuestCardId("Ancient-Evils-Disturbed-TRoB");
            AddQuestCardId("Deeper-into-the-Past-TRoB");
            AddQuestCardId("The-Servants-of-Morgoth-TRoB");
            AddQuestCardId("The-Roots-of-Ered-Luin-TRoB");
            AddQuestCardId("The-Mines-of-Belegost-TRoB");
            AddQuestCardId("The-Beast-of-Belegost-TRoB");

            ExcludeFromEasyMode("Flooded-Hall-TRoB", 2);
            ExcludeFromEasyMode("Old-Stone-Troll-TRoB", 2);
            ExcludeFromEasyMode("Spawn-of-Thangorodrim-TRoB", 2);

        }
    }
}
