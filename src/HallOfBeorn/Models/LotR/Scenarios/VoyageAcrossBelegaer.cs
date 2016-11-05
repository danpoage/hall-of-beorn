using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class VoyageAcrossBelegaer : DreamChaserScenario
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

            AddQuestCardId("Departure-from-the-Havens-TGH");
            AddQuestCardId("Into-the-Storm-TGH");
            AddQuestCardId("Cursed-Mists-TGH");
            AddQuestCardId("Calphon's-Divination-TGH");
            AddQuestCardId("The-Star's-Guidance-TGH");
            AddQuestCardId("Corsair-Pursuit-TGH");

            ExcludeVastOceansFromEasyMode();
            ExcludeStormyWeatherFromEasyMode();
            ExcludeUmbarFleetFromEasyMode();
            ExcludeCorsairPiratesFromEasyMode();
        }
    }
}