using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.DoomMastered
{
    public class TrialUponTheMarchesScenario
        : Scenario
    {
        public TrialUponTheMarchesScenario()
            : base(false)
        {
            Title = "Trial Upon the Marches";
            ProductName = "Trial Upon the Marches";
            GroupName = "Doom Mastered";
            Number = 1;

            HasFirstAgeApprovedList = true;

            AddEncounterSet(EncounterSet.TrialUponTheMarches);

            AddQuestCardId("Preparing-for-Battle-TUtM");
            AddQuestCardId("Repel-the-Incursion-TUtM");
            AddQuestCardId("Rescue-the-Settlement-TUtM");
            AddQuestCardId("Destroy-the-War-Engine-TUtM");
            AddQuestCardId("A-Final-Proving-TUtM");
        }
    }
}