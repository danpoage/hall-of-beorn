namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class HelmsDeep : Scenario
    {
        public HelmsDeep()
        {
            Title = "Helm's Deep";
            ProductName = "The Treason of Saruman";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 8;

            QuestCompanionSlug = "lotr-the-treason-of-saruman-saga-expansion-quest-helms-deep";
            DifficultyRating = 8.2f;
            Votes = 30;

            AddEncounterSet(EncounterSet.HelmsDeep);
            AddEncounterSet(EncounterSet.OrcsOfTheWhiteHand);

            AddQuestCardId("The-King-of-the-Golden-Hall-ToS");
            AddQuestCardId("Assault-on-Helm's-Deep-ToS");
            AddQuestCardId("The-Hosts-of-Isengard-ToS");
            AddQuestCardId("The-Wall-is-Breached-ToS");
            AddQuestCardId("The-King-Rides-Out-ToS");

            ExcludeFromEasyMode("Deeping-Culvert-ToS", 1);
            ExcludeFromEasyMode("Devilry-of-Saruman-ToS", 1);
            ExcludeFromEasyMode("Helm's-Gate-ToS", 1);
            ExcludeFromEasyMode("Night-Without-End-ToS", 1);
            ExcludeFromEasyMode("Scaling-Ladders-ToS", 2);
            ExcludeFromEasyMode("Warrior-of-Dunland-ToS", 2);
            ExcludeFromEasyMode("Fighting-Uruk-hai-ToS", 1);
            ExcludeFromEasyMode("Isengard-Uruk-ToS", 1);

        }
    }
}
