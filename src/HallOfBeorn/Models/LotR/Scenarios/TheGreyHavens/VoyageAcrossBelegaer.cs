using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheGreyHavens
{
    public class VoyageAcrossBelegaer : Scenarios.DreamChaser.DreamChaserScenario
    {
        public VoyageAcrossBelegaer()
        {
            Title = "Voyage Across Belegaer";
            ProductName = "The Grey Havens";
            GroupName = "The Grey Havens";
            Number = 1;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-grey-havens-quest-voyage-across-belegaer.html";

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