namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class TheRingGoesSouth : Scenario
    {
        public TheRingGoesSouth()
        {
            Title = "The Ring Goes South";
            ProductName = "The Road Darkens";
            GroupName = "The Lord of the Rings";
            Number = 4;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/lotr-the-road-darkens-quest-the-ring-goes-south.html";

            AddEncounterSet(EncounterSet.TheRingGoesSouth);

            AddQuestCardId("The-Council-of-Elrond-RD");
            AddQuestCardId("The-Nine-Walkers-RD");
            AddQuestCardId("The-Hunt-is-Up-RD");
            AddQuestCardId("The-Gates-of-Moria-RD");

            ExcludeFromEasyMode("Bitter-Cold-RD", 1);
            ExcludeFromEasyMode("Eregion-RD", 1);
            ExcludeFromEasyMode("Hound-of-Sauron-RD", 2);
            ExcludeFromEasyMode("Redhorn-Foothills-RD", 1);
            ExcludeFromEasyMode("Regiments-of-Crows-RD", 1);
            ExcludeFromEasyMode("Storm-of-Howls-RD", 1);

        }
    }
}
