using System;

namespace HallOfBeorn.Models.LotR.Scenarios.DoomMastered
{
    public class TheFallOfNargothrondScenario
        : Scenario
    {
        public TheFallOfNargothrondScenario()
            : base(false)
        {
            Title = "The Fall of Nargothrond";
            ProductName = "The Fall of Nargothrond";
            GroupName = "Doom Mastered";
            Number = 4;

            AddEncounterSet(EncounterSet.TheFallOfNargothrond);

            AddQuestCardId("Only-In-Secrecy-Lies-Hope-TFoN");
            AddQuestCardId("Arms-Are-The-Only-Wall-TFoN");
            AddQuestCardId("The-Doors-of-Felagund-TFoN");
            AddQuestCardId("The-Sack-of-Nargothrond-TFoN");
        }
    }
}
