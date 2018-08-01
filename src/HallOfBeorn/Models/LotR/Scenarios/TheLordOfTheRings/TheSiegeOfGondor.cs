using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class TheSiegeOfGondor : Scenario
    {
        public TheSiegeOfGondor()
        {
            Title = "The Siege of Gondor";
            ProductName = "The Flame of the West";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 14;

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/e8/5c/e85c8012-6840-432b-bd81-ac7792aa6281/mec54_rulesheet.pdf";
            QuestCompanionSlug = "lotr-the-flame-of-the-west-saga-expansion-quest-the-siege-of-gondor";
            DifficultyRating = 6.7f;
            Votes = 12;

            AddCardboardOfTheRingsLink("https://www.youtube.com/watch?v=Wm-AMpC0Rb0", "Chad's Campaign: The Siege of Gondor", "https://i.ytimg.com/vi/Wm-AMpC0Rb0/hqdefault.jpg");
            AddTheRoadLink(18, "https://theroadlotr.wordpress.com/the-siege-of-gondor/");

            AddEncounterSet(EncounterSet.TheSiegeOfGondor);

            AddQuestCardId("Attack-on-Pelargir-TFotW");

            ExcludeFromEasyMode("Pelargir-Quays-TFotW", 2);
            ExcludeFromEasyMode("Corsair-Captain-TFotW", 1);
            ExcludeFromEasyMode("Umbar-Pirate-Crew-TFotW", 1);
            ExcludeFromEasyMode("Raiding-the-Coasts-TFotW", 1);
            ExcludeFromEasyMode("Driven-to-the-Brink-TFotW", 1);
        }
    }
}