namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class TheRuinsOfBelegost : Scenario
    {
        public TheRuinsOfBelegost()
        {
            Title = "The Ruins of Belegost";
            ProductName = "The Ruins of Belegost";
            GroupName = "GenCon";
            Number = 6;

            QuestCompanionSlug = "print-on-demand-quest-the-ruins-of-belegost";

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
