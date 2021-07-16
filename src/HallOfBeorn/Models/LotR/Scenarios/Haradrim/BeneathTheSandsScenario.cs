using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.Haradrim
{
    public class BeneathTheSandsScenario : Scenarios.TheSandsOfHarad.TheSandsOfHaradScenario
    {
        public BeneathTheSandsScenario()
        {
            Title = "Beneath the Sands";
            ProductName = "Beneath the Sands";
            GroupName = "Haradrim";
            Number = 3;

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/a5/a8/a5a88cea-5920-4c3c-b9c0-aa8d7bd3c455/mec58_web_beneath_the_sands-rules.pdf";
            QuestCompanionSlug = "haradrim-cycle-quest-beneath-the-sands";
            DifficultyRating = 6.0f;
            Votes = 3;

            AddMrUnderhillLink(Title + " - Vigilant Dúnadan", "FWCsh8cnAY4");
            AddWanderingTookVideoLink("Twitch Recast: " + Title, "wKhhTLSemJE");
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2020/07/28/beneath-the-sands/");

            AddEncounterSet(EncounterSet.BeneathTheSands);
            AddEncounterSet(EncounterSet.DesertCreatures);
            AddEncounterSet(EncounterSet.HaradTerritory);

            AddQuestCardId("Searching-the-Caves-BtS");
            AddQuestCardId("Getting-Closer-BtS");
            AddQuestCardId("The-Spiders'-Hive-BtS");

            excludeDesertCreatures();
            excludeHaradTerritory();

            /*
            ExcludeFromEasyMode("-BtS", 1);
            ExcludeFromEasyMode("-BtS", 1);
            ExcludeFromEasyMode("-BtS", 1);
            ExcludeFromEasyMode("-BtS", 1);
            */
        }
    }
}