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
            IsSubGroup = true;
            Number = 13;

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/e8/5c/e85c8012-6840-432b-bd81-ac7792aa6281/mec54_rulesheet.pdf";
            QuestCompanionSlug = "lotr-the-flame-of-the-west-saga-expansion-quest-the-passing-of-the-grey-company";
            DifficultyRating = 6.5f;
            Votes = 15;

            AddTheRoadLink(17, "https://theroadlotr.wordpress.com/the-passing-of-the-grey-company/");

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