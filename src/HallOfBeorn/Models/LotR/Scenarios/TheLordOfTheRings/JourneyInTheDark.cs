namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class JourneyInTheDark : Scenario
    {
        public JourneyInTheDark()
        {
            Title = "Journey in the Dark";
            ProductName = "The Road Darkens";
            GroupName = "The Lord of the Rings";
            Number = 5;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/lotr-the-road-darkens-quest-journey-in-the-dark.html";

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
