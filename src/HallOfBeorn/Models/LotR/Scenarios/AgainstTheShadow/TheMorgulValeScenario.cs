namespace HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow
{
    public class TheMorgulValeScenario : Scenario
    {
        public TheMorgulValeScenario()
            : base(true)
        {
            Title = "The Morgul Vale";
            ProductName = "The Morgul Vale";
            GroupName = "Against the Shadow";
            Number = 6;

            QuestCompanionSlug = "against-the-shadow-quest-the-morgul-vale";
            DifficultyRating = 8.0f;
            Votes = 44;

            AddTheLineUnbrokenLink("33", "0zXQhQq6iEY");
            AddMrUnderhillLink(Title + " Nightmare Mode - Two Players", "Ep1MD4NNJgU");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/12/26/nightmare-the-morgul-vale/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2018/05/07/the-morgul-vale/");

            AddEncounterSet(EncounterSet.CreaturesOfTheForest);
            AddEncounterSet(EncounterSet.MordorElite);
            AddEncounterSet(EncounterSet.TheMorgulVale);
            AddEncounterSet(EncounterSet.TheMorgulValeNightmare);

            AddQuestCardId("The-Rearguard-TMV");
            AddQuestCardId("The-Betrayal-TMV");
            AddQuestCardId("The-Morgul-Rider-TMV");

            ExcludeFromEasyMode("Morgul-Spider-HoN", 2);
            ExcludeFromEasyMode("Watcher-in-the-Wood-HoN", 2);
            ExcludeFromEasyMode("Orc-Vanguard-HoN", 2);
            ExcludeFromEasyMode("Orc-War-Camp-HoN", 2);
            ExcludeFromEasyMode("The-Master's-Malice-HoN", 2);
            ExcludeFromEasyMode("Impenetrable-Fog-TMV", 2);
            ExcludeFromEasyMode("The-Dead-City-Looms-TMV", 1);

            ExcludeFromNightmareMode("Forest-Bat-HoN", 3);
            ExcludeFromNightmareMode("Watcher-in-the-Wood-HoN", 1);
            ExcludeFromNightmareMode("Orc-Arbalesters-HoN", 3);
            ExcludeFromNightmareMode("The-Power-of-Mordor-HoN", 1);
            ExcludeFromNightmareMode("Morgul-Road-TMV", 3);
            ExcludeFromNightmareMode("Morgul-Sorcerer-TMV", 2);
            ExcludeFromNightmareMode("Morgul-Tracker-TMV", 2);
        }
    }
}
