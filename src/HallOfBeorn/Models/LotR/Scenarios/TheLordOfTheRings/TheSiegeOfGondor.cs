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
            Number = 14;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/lotr-the-flame-of-the-west-saga-expansion-quest-the-siege-of-gondor.html";

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