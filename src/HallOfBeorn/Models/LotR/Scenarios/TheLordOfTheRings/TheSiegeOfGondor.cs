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

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/03/0a/030a4e90-544d-4d24-a160-c5e05f34c778/mec56_rule_set.pdf";
            QuestCompanionSlug = "lotr-the-flame-of-the-west-saga-expansion-quest-the-siege-of-gondor";

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