namespace HallOfBeorn.Models.LotR.Scenarios.CoreSet
{
    public class PassageThroughMirkwood : Scenario
    {
        public PassageThroughMirkwood()
        {
            Title = "Passage Through Mirkwood";
            ProductName = "Core Set";
            GroupName = "Core Set";
            Number = 1;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/core-set-quest-passage-through-mirkwood.html";

            addEncounterSets(
                EncounterSet.DolGuldurOrcs,
                EncounterSet.SpidersOfMirkwood,
                EncounterSet.PassageThroughMirkwood,
                EncounterSet.PassageThroughMirkwoodNightmare
            );
        }
    }
}
