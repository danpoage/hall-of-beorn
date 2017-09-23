using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class ThePassingOfTheGreyCompany : Scenario
    {
        public ThePassingOfTheGreyCompany()
        {
            Title = "The Passing of the Grey Company";
            ProductName = "The Flame of the West";
            GroupName = "The Lord of the Rings";
            Number = 13;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/lotr-the-flame-of-the-west-saga-expansion-quest-the-passing-of-the-grey-company.html";

            AddEncounterSet(EncounterSet.ThePassingOfTheGreyCompany);

            AddQuestCardId("The-Forbidden-Door-TFotW");
            AddQuestCardId("The-Paths-of-the-Dead-TFotW");
            AddQuestCardId("The-Dead-are-Following-TFotW");

            ExcludeFromEasyMode("Dark-Door-TFotW", 1);
            ExcludeFromEasyMode("Trysting-Place-TFotW", 1);
            ExcludeFromEasyMode("Faithless-Dead-TFotW", 1);
            ExcludeFromEasyMode("Blood-Runs-Cold-TFotW", 2);
            ExcludeFromEasyMode("No-Turning-Back-TFotW", 1);
        }
    }
}