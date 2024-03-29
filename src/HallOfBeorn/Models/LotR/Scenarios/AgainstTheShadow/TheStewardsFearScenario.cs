namespace HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow
{
    public class TheStewardsFearScenario : Scenario
    {
        public TheStewardsFearScenario()
            : base(true)
        {
            Title = "The Steward's Fear";
            ProductName = "The Steward's Fear";
            GroupName = "Against the Shadow";
            Number = 1;

            QuestCompanionSlug = "against-the-shadow-quest-the-stewards-fear";
            DifficultyRating = 6.2f;
            Votes = 54;

            AddTheLineUnbrokenLink("28", "UTOX8V99QKc");
            AddTheLineUnbrokenLink("N28", "iQKTWarQGBs");
            AddWanderingTookVideoLink("Twitch Recast: " + Title, "Ug1w2oHsOIY");
            AddLotRDeckTechLink("Silvan Tracker vs Steward's Fear", "dUxOSPXapTc");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/09/12/nightmare-the-stewards-fear/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/04/06/the-stewards-fear/");

            AddEncounterSet(EncounterSet.Brigands);
            AddEncounterSet(EncounterSet.StreetsOfGondor);
            AddEncounterSet(EncounterSet.TheStewardsFear);
            AddEncounterSet(EncounterSet.TheStewardsFearNightmare);
            AddEncounterSet(EncounterSet.BrigandsNightmare);

            AddQuestCardId("Conspiracy-TSF");
            AddQuestCardId("The-Grand-Design-TSF");
            AddQuestCardId("The-Confrontation-TSF");

            ExcludeFromEasyMode("Umbar-Assassin-HoN", 1);
            ExcludeFromEasyMode("Local-Trouble-HoN", 1);
            ExcludeFromEasyMode("Lost-in-the-City-HoN", 1);
            ExcludeFromEasyMode("A-Knife-in-the-Back-TSF", 2);
            ExcludeFromEasyMode("Houses-of-the-Dead-TSF", 1);

            ExcludeFromNightmareMode("Market-Square-HoN", 2);
            ExcludeFromNightmareMode("Pickpocket-HoN", 3);
            ExcludeFromNightmareMode("Storehouse-TSF", 2);
            ExcludeFromNightmareMode("Underworld-Dissident-TSF", 3);
        }
    }
}
