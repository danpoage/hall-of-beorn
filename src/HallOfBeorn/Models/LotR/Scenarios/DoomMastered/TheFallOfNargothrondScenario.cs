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

            HasFirstAgeApprovedList = true;

            AddEncounterSet(EncounterSet.TheFallOfNargothrond);
            AddEncounterSet(EncounterSet.TrialUponTheMarches);

            AddQuestCardId("Only-In-Secrecy-Lies-Hope-TFoN");
            AddQuestCardId("Arms-Are-The-Only-Wall-TFoN");
            AddQuestCardId("The-Doors-of-Felagund-TFoN");
            AddQuestCardId("The-Sack-of-Nargothrond-TFoN");

            ExcludeFromAllModes("Deeds-of-Daring-TUtM");
            ExcludeFromAllModes("Mighty-in-Arms-TUtM");
            ExcludeFromAllModes("Azrat-TUtM");
            ExcludeFromAllModes("Hidden-Grove-TUtM");
            ExcludeFromAllModes("March-Outpost-TUtM");
            ExcludeFromAllModes("Burning-Abode-TUtM");
            ExcludeFromAllModes("March-Road-TUtM");
            ExcludeFromAllModes("Raider-Camp-TUtM");
            ExcludeFromAllModes("Crooked-Blades-TUtM");
            ExcludeFromAllModes("Renewed-Grief-TUtM");
            ExcludeFromAllModes("An-Ill-Fate-TUtM");
            ExcludeFromAllModes("Mirth-of-Morgoth-TUtM");
            ExcludeFromAllModes("Orcish-Mischief-TUtM");
            ExcludeFromAllModes("Orc-Infiltration-TUtM");
            ExcludeFromAllModes("Not-So-High-Is-Your-Destiny-TUtM");
            ExcludeFromAllModes("For-Good-Or-For-Ill-TUtM");
            ExcludeFromAllModes("Trial-Upon-the-Marches-TUtM");
            ExcludeFromAllModes("Trial-Upon-the-Marches-Campaign-TUtM");
            ExcludeFromAllModes("Curse-of-Morgoth-TUtM");
        }
    }
}
