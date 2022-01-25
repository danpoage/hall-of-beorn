namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class HelmsDeepScenario : Scenario
    {
        public HelmsDeepScenario()
            : base(true)
        {
            Title = "Helm's Deep";
            ProductName = "The Treason of Saruman";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 8;

            QuestCompanionSlug = "lotr-the-treason-of-saruman-saga-expansion-quest-helms-deep";
            DifficultyRating = 8.2f;
            Votes = 30;

            AddTheLineUnbrokenLink("C8", "4iWunMbDBVc");
            AddTheRoadLink(12, "https://theroadlotr.wordpress.com/helms-deep/");

            AddEncounterSet(EncounterSet.HelmsDeep);
            AddEncounterSet(EncounterSet.OrcsOfTheWhiteHand);
            AddEncounterSet(EncounterSet.HelmsDeepNightmare);

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

            ExcludeFromNightmareMode("Isengard-Uruk-ToS", 1);
            ExcludeFromNightmareMode("Uruk-hai-Fighter-ToS", 3);
            ExcludeFromNightmareMode("Wild-Hillman-ToS", 3);
            ExcludeFromNightmareMode("The-Hornburg-ToS", 3);
            ExcludeFromNightmareMode("Deeping-Wall-ToS", 1);
            ExcludeFromNightmareMode("Postern-Door-ToS", 2);
            ExcludeFromNightmareMode("Reckless-Hate-ToS", 2);
        }
    }
}
