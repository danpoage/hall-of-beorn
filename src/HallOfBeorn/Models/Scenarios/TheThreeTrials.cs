using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheThreeTrials : TheVoiceOfIsengardScenario
    {
        public TheThreeTrials()
        {
            AdventurePack("The Three Trials", "The Ring-maker", 2);

            AddQuestCardId("The-Trials-Begin-TTT");
            AddQuestCardId("The-Trial-of-Strength-TTT");
            AddQuestCardId("The-Trial-of-Perseverance-TTT");
            AddQuestCardId("The-Trail-of-Intuition-TTT");
            AddQuestCardId("The-Antlered-Crown-TTT");

            AddEncounterSet(EncounterSet.TheThreeTrials);
            AddEncounterSet(EncounterSet.AncientForest);
        }
    }
}