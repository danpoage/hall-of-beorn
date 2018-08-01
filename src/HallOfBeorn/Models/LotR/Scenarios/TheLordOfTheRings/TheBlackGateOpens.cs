using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class TheBlackGateOpens : Scenario
    {
        public TheBlackGateOpens()
        {
            Title = "The Black Gate Opens";
            ProductName = "The Mountain of Fire";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 17;

            QuestCompanionSlug = "the-lord-of-the-rings-the-mountain-of-fire-saga-expansion-quest-the-black-gate-opens";
            DifficultyRating = 8.8f;
            Votes = 4;

            AddTheRoadLink(21, "https://theroadlotr.wordpress.com/the-black-gate-opens/");

            AddEncounterSet(EncounterSet.TheBlackGateOpens);
            AddEncounterSet(EncounterSet.OrcsOfMordor);
            AddEncounterSet(EncounterSet.MountainOfFireEpicMultiplayer);

            AddQuestCardId("Embassy-from-the-Dark-Tower-TMoF");
            AddQuestCardId("The-Battle-of-the-Morannon-TMoF");

            //The Black Gate Opens
            ExcludeFromEasyMode("Towers-of-the-Teeth-TMoF", 1);
            ExcludeFromEasyMode("Nazgul-of-Mordor-TMoF", 1);
            ExcludeFromEasyMode("Gorgoroth-Hill-troll-TMoF", 1);
            ExcludeFromEasyMode("Hell-hawk-TMoF", 1);
            ExcludeFromEasyMode("Jaws-of-Steel-TMoF", 1);
            ExcludeFromEasyMode("Onslaught-of-Mordor-TMoF", 1);

            //Orcs of Mordor
            ExcludeFromEasyMode("Orc-of-Mordor-TMoF", 1);
        }
    }
}