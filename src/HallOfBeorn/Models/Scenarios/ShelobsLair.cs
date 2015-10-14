namespace HallOfBeorn.Models.Scenarios
{
    public class ShelobsLair : Scenario
    {
        public ShelobsLair()
        {
            Title = "Shelob's Lair";
            ProductName = "The Land of Shadow";
            GroupName = "The Lord of the Rings";
            Number = 12;

            AddEncounterSet(EncounterSet.Gollum);
            AddEncounterSet(EncounterSet.Nazgul);
            AddEncounterSet(EncounterSet.ShelobsLair);
            AddEncounterSet(EncounterSet.TheGreatSpider);

            AddQuestCardId("The-Stairs-of-Cirith-Ungol-TLoS");
            AddQuestCardId("The-Spider's-Pass-TLoS");
            AddQuestCardId("Gollum's-Betrayal-TLoS");

            ExcludeFromEasyMode("We-Hates-Them-TLoS", 1);
            ExcludeFromEasyMode("Call-of-the-Ring-TLoS", 1);
            ExcludeFromEasyMode("Morgul-Wraith-TLoS", 1);
            ExcludeFromEasyMode("Many-Openings-TLoS", 1);
            ExcludeFromEasyMode("Morgul-Orc-TLoS", 1);
            ExcludeFromEasyMode("Orc-of-Cirith-Ungol-TLoS", 1);
            ExcludeFromEasyMode("The-Under-way-TLoS", 1);
            ExcludeFromEasyMode("Blocked-Tunnel-TLoS", 1);
            ExcludeFromEasyMode("Lurking-Malice-TLoS", 1);
            ExcludeFromEasyMode("Rage-and-Hunger-TLoS", 1);
            ExcludeFromEasyMode("Shelob's-Poison-TLoS", 1);

        }
    }
}
