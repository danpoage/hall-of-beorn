namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class ThePassageOfTheMarshesScenario : Scenario
    {
        public ThePassageOfTheMarshesScenario()
            : base(true)
        {
            Title = "The Passage of the Marshes";
            ProductName = "The Land of Shadow";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 10;

            QuestCompanionSlug = "lotr-the-land-of-shadow-saga-expansion-quest-the-passage-of-the-marshes";
            DifficultyRating = 6.2f;
            Votes = 17;

            AddTheLineUnbrokenLink("C10", "RgnR-N3wRfo");
            AddMrUnderhillLink(Title + " - Boromir Deck", "REmISg50GvI");
            AddTheRoadLink(14, "https://theroadlotr.wordpress.com/the-passage-of-the-marshes/");

            AddEncounterSet(EncounterSet.Gollum);
            AddEncounterSet(EncounterSet.MorgulNazgul);
            AddEncounterSet(EncounterSet.ThePassageOfTheMarshes);
            AddEncounterSet(EncounterSet.ThePassageOfTheMarshesNightmare);

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

            ExcludeFromNightmareMode("Groping-Dead-TLoS", 3);
            ExcludeFromNightmareMode("Dead-Things-TLoS", 3);
            ExcludeFromNightmareMode("Soft-Mires-TLoS", 3);
            ExcludeFromNightmareMode("Haunted-Mere-TLoS", 3);
            ExcludeFromNightmareMode("Bitter-Reek-TLoS", 3);
        }
    }
}
