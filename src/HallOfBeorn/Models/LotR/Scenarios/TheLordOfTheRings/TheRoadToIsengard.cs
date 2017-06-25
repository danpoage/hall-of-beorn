namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class TheRoadToIsengard : Scenario
    {
        public TheRoadToIsengard()
        {
            Title = "The Road to Isengard";
            ProductName = "The Treason of Saruman";
            GroupName = "The Lord of the Rings";
            Number = 9;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/lotr-the-treason-of-saruman-saga-expansion-quest-the-road-to-isengard.html";

            AddEncounterSet(EncounterSet.SnagaOrcs);
            AddEncounterSet(EncounterSet.TheRoadToIsengard);

            AddQuestCardId("Rouse-the-Ents-ToS");
            AddQuestCardId("Breaking-Isengard-ToS");
            AddQuestCardId("The-Voice-of-Saruman-ToS");

            ExcludeFromEasyMode("Saruman's-Orders-ToS", 1);
            ExcludeFromEasyMode("Snaga-ToS", 1);
            ExcludeFromEasyMode("Gríma-ToS", 1);
            ExcludeFromEasyMode("Plain-of-Isengard-ToS", 1);
            ExcludeFromEasyMode("Poisoned-Vapour-ToS", 2);
            ExcludeFromEasyMode("Steaming-Vent-ToS", 2);
            ExcludeFromEasyMode("Underground-Armoury-ToS", 1);
            ExcludeFromEasyMode("Wolf-of-Isengard-ToS", 1);

        }
    }
}
