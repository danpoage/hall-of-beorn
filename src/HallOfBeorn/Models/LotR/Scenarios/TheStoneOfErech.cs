namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class TheStoneOfErech : Scenario
    {
        public TheStoneOfErech()
        {
            Title = "The Stone of Erech";
            ProductName = "The Stone of Erech GenCon 2013";
            GroupName = "GenCon";
            Number = 3;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/print-on-demand-quest-the-stone-of-erech.html";

            AddEncounterSet(EncounterSet.TheStoneOfErech);

            AddQuestCardId("The-Disappearance-TSoE");
            AddQuestCardId("Terror-of-the-Dead-TSoE");
            AddQuestCardId("The-Shadow-Host-TSoE");


        }
    }
}
