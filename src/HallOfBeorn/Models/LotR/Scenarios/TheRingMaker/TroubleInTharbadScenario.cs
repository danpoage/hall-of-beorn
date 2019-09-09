namespace HallOfBeorn.Models.LotR.Scenarios.TheRingMaker
{
    public class TroubleInTharbadScenario : Scenario
    {
        public TroubleInTharbadScenario()
        {
            Title = "Trouble in Tharbad";
            ProductName = "Trouble in Tharbad";
            GroupName = "The Ring-maker";
            Number = 3;

            QuestCompanionSlug = "the-ring-maker-quest-trouble-in-tharbad";
            DifficultyRating = 3.9f;
            Votes = 31;

            AddTheLineUnbrokenLink("39", "xlGiadgaQJ4");
            AddLotRDeckTechLink("Hobbits vs Trouble in Tharbad", "3QBCQwBg1uM");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2018/05/08/nightmare-trouble-in-tharbad/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/10/03/warriors-of-the-west-trouble-in-tharbad/", Title);
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/10/20/nightmare-review-trouble-in-tharbad/", "Nightmare " + Title);
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2018/06/05/trouble-in-tharbad/");

            AddEncounterSet(EncounterSet.MistyMountainOrcs);
            AddEncounterSet(EncounterSet.TroubleInTharbad);
            AddEncounterSet(EncounterSet.TroubleInTharbadNightmare);

            AddQuestCardId("Double-Dealings-TiT");
            AddQuestCardId("Escape-from-Tharbad-TiT");

            ExcludeFromEasyMode("Orc-Hound-VoI", 1);
            ExcludeFromEasyMode("Orc-Hunter-VoI", 2);
            ExcludeFromEasyMode("Bellach's-Marauder-TiT", 1);
            ExcludeFromEasyMode("Conspicuous-Lot-TiT", 1);
            ExcludeFromEasyMode("Get-That-Dwarf-TiT", 1);
            ExcludeFromEasyMode("Ruins-of-the-Second-Age-TiT", 1);
            ExcludeFromEasyMode("Seedy-Inn-TiT", 1);

            ExcludeFromNightmareMode("Orc-Hunter-VoI", 1);
            ExcludeFromNightmareMode("Orc-Skirmisher-VoI", 2);
            ExcludeFromNightmareMode("Tharbad-Hideout-TiT", 2);
            ExcludeFromNightmareMode("Hidden-Alleyway-TiT", 2);
            ExcludeFromNightmareMode("Decrepit-Rooftops-TiT", 1);
            ExcludeFromNightmareMode("Orc-Hunting-Party-VoI", 2);
        }
    }
}
