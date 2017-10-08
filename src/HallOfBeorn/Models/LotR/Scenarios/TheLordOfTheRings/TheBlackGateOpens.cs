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
            Number = 17;

            //QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/.html";

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