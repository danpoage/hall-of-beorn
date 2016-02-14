using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheFateOfNumenor : DreamChaserScenario
    {
        public TheFateOfNumenor()
        {
            Title = "The Fate of Númenor";
            ProductName = "The Grey Havens";
            GroupName = "The Grey Havens";
            Number = 2;

            AddEncounterSet(EncounterSet.DrownedDead);
            AddEncounterSet(EncounterSet.RuinsOfNumenor);
            AddEncounterSet(EncounterSet.TheFateOfNumenor);

            AddQuestCardId("Explore-the-Island-TGH");
            AddQuestCardId("A-Fateful-Discovery-TGH");
        }
    }
}