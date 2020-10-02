using System;

namespace HallOfBeorn.Models.LotR.Scenarios.DoomMastered
{
    public class TheBetrayalOfMimScenario
        : Scenario
    {
        public TheBetrayalOfMimScenario()
            : base(false)
        {
            Title = "The Betrayal of Mîm";
            ProductName = "The Betrayal of Mîm";
            GroupName = "Doom Mastered";
            Number = 3;

            AddEncounterSet(EncounterSet.TheBetrayalOfMim);

            AddQuestCardId("The-Land-of-Bow-and-Helm-TBoM");
            AddQuestCardId("The-Wrath-of-Angband-TBoM");
        }
    }
}
