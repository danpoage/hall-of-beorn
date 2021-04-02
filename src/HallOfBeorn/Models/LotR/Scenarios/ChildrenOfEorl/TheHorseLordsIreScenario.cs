using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.ChildrenOfEorl
{
    public class TheHorseLordsIreScenario
        : Scenario
    {
        public TheHorseLordsIreScenario()
        {
            Title = "The Horse Lord's Ire";
            ProductName = "Children of Eorl";
            GroupName = "Children of Eorl";
            Number = 3;

            QuestCompanionSlug = "the-children-of-eorl-quest-the-horse-lords-ire";
            DifficultyRating = 7.0f;
            Votes = 1;

            AddEncounterSet(EncounterSet.TheHorseLordsIre);
            AddEncounterSet(EncounterSet.OrcHost); 
            AddEncounterSet(EncounterSet.RohanLands);

            AddQuestCardId("Thieves-and-Coursers-CoE");
            AddQuestCardId("The-King's-Stallion-CoE");
            AddQuestCardId("The-Sweeping-Tide-CoE");

            //The Horse Lord's Ire
            ExcludeFromEasyMode("Bridle-biter-CoE", 1);
            ExcludeFromEasyMode("Pommel-pouncer-CoE", 1);
            ExcludeFromEasyMode("Overburdened-CoE", 1);

            //Orc-Host
            ExcludeFromEasyMode("Crimson-Banner-CoE", 1);

            //Rohan Lands
            ExcludeFromEasyMode("Wild-Country-CoE", 1);
            ExcludeFromEasyMode("Windworn-Villages-CoE", 1);
            ExcludeFromEasyMode("Humpbacked-Downs-CoE", 1);
        }
    }
}