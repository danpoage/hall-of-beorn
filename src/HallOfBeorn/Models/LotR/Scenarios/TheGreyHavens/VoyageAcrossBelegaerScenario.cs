using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheGreyHavens
{
    public class VoyageAcrossBelegaerScenario : Scenarios.DreamChaser.DreamChaserScenarioScenario
    {
        public VoyageAcrossBelegaerScenario()
        {
            Title = "Voyage Across Belegaer";
            ProductName = "The Grey Havens";
            GroupName = "The Grey Havens";
            Number = 1;

            QuestCompanionSlug = "the-grey-havens-quest-voyage-across-belegaer";
            DifficultyRating = 4.8f;
            Votes = 19;

            AddWanderingTookVideoLink("Twitch Recast: " + Title, "wrbPRLUbl6s");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2017/05/30/path-less-traveled-voyage-across-belegaer/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2019/01/12/voyage-across-belegaer/");

            AddEncounterSet(EncounterSet.VastOceans);
            AddEncounterSet(EncounterSet.StormyWeather);
            AddEncounterSet(EncounterSet.UmbarFleet);
            AddEncounterSet(EncounterSet.CorsairPirates);
            AddEncounterSet(EncounterSet.TheDreamChasersFleet);
            AddEncounterSet(EncounterSet.VoyageAcrossBelegaer);
            AddEncounterSet(EncounterSet.VoyageAcrossBelegaerNightmare);

            AddQuestCardId("Departure-from-the-Havens-TGH");
            AddQuestCardId("Into-the-Storm-TGH");
            AddQuestCardId("Cursed-Mists-TGH");
            AddQuestCardId("Calphon's-Divination-TGH");
            AddQuestCardId("The-Star's-Guidance-TGH");
            AddQuestCardId("Corsair-Confrontation-VaBN");
            AddQuestCardId("Lost-at-Sea-VaBN");
            AddQuestCardId("Corsair-Pursuit-TGH");

            ExcludeVastOceansFromEasyMode();
            ExcludeStormyWeatherFromEasyMode();
            ExcludeUmbarFleetFromEasyMode();
            ExcludeCorsairPiratesFromEasyMode();

            ExcludeFromNightmareMode("Southron-Sailor-TGH", 2);
            ExcludeFromNightmareMode("Starlit-Sea-TGH", 1);
            ExcludeFromNightmareMode("Fog-Bank-TGH", 1);
            ExcludeFromNightmareMode("Calm-Waters-TGH", 2);
            ExcludeFromNightmareMode("Thrown-Off-Course-TGH", 2);
            ExcludeFromNightmareMode("Scouting-Ship-TGH", 1);
        }
    }
}