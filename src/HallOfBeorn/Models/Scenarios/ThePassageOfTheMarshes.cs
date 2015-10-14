namespace HallOfBeorn.Models.Scenarios
{
    public class ThePassageOfTheMarshes : Scenario
    {
        public ThePassageOfTheMarshes()
        {
            Title = "The Passage of the Marshes";
            ProductName = "The Land of Shadow";
            GroupName = "The Lord of the Rings";
            Number = 10;

            AddEncounterSet(EncounterSet.Gollum);
            AddEncounterSet(EncounterSet.Nazgul);
            AddEncounterSet(EncounterSet.ThePassageOfTheMarshes);

            AddQuestCardId("The-Taming-of-Smeagol-TLoS");
            AddQuestCardId("Across-the-Marshes-TLoS");
            AddQuestCardId("Don't-Look-at-the-Lights-TLoS");

            ExcludeFromEasyMode("We-Hates-Them-TLoS", 1);
            ExcludeFromEasyMode("Call-of-the-Ring-TLoS", 1);
            ExcludeFromEasyMode("Morgul-Wraith-TLoS", 1);
            ExcludeFromEasyMode("A-Fell-Light-TLoS", 1);
            ExcludeFromEasyMode("Bitter-Reek-TLoS", 1);
            ExcludeFromEasyMode("Candle-bearer-TLoS", 2);
            ExcludeFromEasyMode("Creeping-Marshes-TLoS", 1);
            ExcludeFromEasyMode("Evil-smelling-Fens-TLoS", 1);
            ExcludeFromEasyMode("Soft-Mires-TLoS", 1);

        }
    }
}
