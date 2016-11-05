namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class IntrudersInChetwood : Scenario
    {
        public IntrudersInChetwood()
        {
            Title = "Intruders in Chetwood";
            ProductName = "The Lost Realm";
            GroupName = "The Lost Realm";
            Number = 1;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-lost-realm-quest-intruders-in-chetwood.html";

            AddEncounterSet(EncounterSet.AngmarOrcs);
            AddEncounterSet(EncounterSet.EriadorWilds);
            AddEncounterSet(EncounterSet.Iarion);
            AddEncounterSet(EncounterSet.IntrudersInChetwood);

            AddQuestCardId("Stop-the-War-Party-TLR");

            ExcludeFromEasyMode("Angmar-Captain-TLR", 1);
            ExcludeFromEasyMode("Angmar-Marauder-TLR", 1);
            ExcludeFromEasyMode("Pressing-Needs-TLR", 1);
            ExcludeFromEasyMode("Shrouded-Hills-TLR", 1);
            ExcludeFromEasyMode("Weight-of-Responsibility-TLR", 1);
            ExcludeFromEasyMode("Chetwood-Forest-TLR", 1);
            ExcludeFromEasyMode("Cornered-Orc-TLR", 1);
            ExcludeFromEasyMode("Orc-War-Party-TLR", 2);
            ExcludeFromEasyMode("Outlying-Homestead-TLR", 1);
            ExcludeFromEasyMode("Sudden-Assault-TLR", 2);
            ExcludeFromEasyMode("Surprising-Speed-TLR", 1);

        }
    }
}
