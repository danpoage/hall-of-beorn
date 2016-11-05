namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class JourneyToTheCrossRoads : Scenario
    {
        public JourneyToTheCrossRoads()
        {
            Title = "Journey to the Cross-roads";
            ProductName = "The Land of Shadow";
            GroupName = "The Lord of the Rings";
            Number = 11;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/lotr-the-land-of-shadow-saga-expansion-quest-journey-to-the-cross-roads.html";

            AddEncounterSet(EncounterSet.MenOfHarad);
            AddEncounterSet(EncounterSet.JourneyToTheCrossRoads);

            AddQuestCardId("Ambush-the-Men-of-Harad-TLoS");

            ExcludeFromEasyMode("Captain-of-Harad-TLoS", 1);
            ExcludeFromEasyMode("Fierce-Southrons-TLoS", 1);
            ExcludeFromEasyMode("Marching-Up-the-Road-TLoS", 1);
            ExcludeFromEasyMode("Southward-Road-TLoS", 1);

        }
    }
}
