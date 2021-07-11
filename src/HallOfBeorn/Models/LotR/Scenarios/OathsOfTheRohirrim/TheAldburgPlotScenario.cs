using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.OathsOfTheRohirrim
{
    public class TheAldburgPlotScenario
        : Scenario
    {
        public TheAldburgPlotScenario()
        {
            Title = "The Aldburg Plot";
            ProductName = "The Aldburg Plot";
            GroupName = "Oaths of the Rohirrim";
            Number = 1;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP02.pdf";

            AddEncounterSet(EncounterSet.RohanEncampment);
            AddEncounterSet(EncounterSet.FaithlessRohirrim);
            AddEncounterSet(EncounterSet.TheAldburgPlot);

            AddQuestCardId("Evil-Under-the-Moon-TAP");
            AddQuestCardId("Gathering-Clues-TAP");
            AddQuestCardId("The-Uncertain-Dawn-TAP");

            ExcludeFromEasyMode("Town-Guard-TAP", 1);
            ExcludeFromEasyMode("Dunlending-Agents-TAP", 1);
            ExcludeFromEasyMode("False-Lead-TAP", 1);

            //Rohan Encampment
            ExcludeFromEasyMode("Old-Farmhouse-CoE", 2);
            ExcludeFromEasyMode("Abandoned-Mill-CoE", 1);

            //Faithless Rohirrim
            ExcludeFromEasyMode("Recreant-Rider-CoE", 1);
            ExcludeFromEasyMode("Deadly-Defector-CoE", 2);
        }
    }
}