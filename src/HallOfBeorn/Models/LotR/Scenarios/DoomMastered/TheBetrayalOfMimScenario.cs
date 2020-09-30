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
            ProductName = "Trial Upon the Marches";
            GroupName = "Doom Mastered";
            Number = 6;

            AddEncounterSet(EncounterSet.TheBetrayalOfMim);

            AddQuestCardId("The-Land-of-Bow-and-Helm-TBoM");
            AddQuestCardId("The-Wrath-of-Angband-TBoM");
        }
    }
}
