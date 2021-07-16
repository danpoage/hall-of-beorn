using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.EredMithrin
{
    public class MountGundabadScenario : EredMithrinScenario
    {
        private const string name = "Mount Gundabad";

        public MountGundabadScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Ered Mithrin";
            Number = 8;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC70.pdf";
            RulesImageCount = 2;

            QuestCompanionSlug = "ered-mithrin-quest-mount-gundabad";
            DifficultyRating = 7.8f;
            Votes = 6;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2020/07/03/mount-gundabad/");

            AddEncounterSet(EncounterSet.MountGundabad);
            AddEncounterSet(EncounterSet.FellBeasts); 
            AddEncounterSet(EncounterSet.DeepUnderground);
            AddEncounterSet(EncounterSet.AfraidOfTheDark);
            AddEncounterSet(EncounterSet.LostCaves);
            AddEncounterSet(EncounterSet.DragonMight);

            AddQuestCardId("The-Side-Door-MG");
            AddQuestCardId("Exploring-Gundabad-The-Upper-Levels-MG");
            AddQuestCardId("Exploring-Gundabad-The-Lower-Deeps-MG");
            AddQuestCardId("Exploring-Gundabad-Frenzied-Warrens-MG");
            AddQuestCardId("Exploring-Gundabad-Dagnir's-Wrath-MG");
            AddQuestCardId("Exploring-Gundabad-Foreboding-Darkness-MG");
            AddQuestCardId("Exploring-Gundabad-Imminent-Pursuit-MG");
            AddQuestCardId("Exploring-Gundabad-The-Great-Worm-MG");

            ExcludeFromEasyMode("Dagnir's-Slave-MG", 1);
            ExcludeFromEasyMode("Deep-dweller-MG", 1);
            ExcludeFromEasyMode("Mines-of-Gundabad-MG", 1);
            ExcludeFromEasyMode("Narrow-Stair-MG", 1);
            ExcludeFromEasyMode("Wilderland's-Bane", 2);

            ExcludeFellBeastsFromEasyMode();
            ExcludeDeepUndergroundFromEasyMode();
            ExcludeAfraidOfTheDarkFromEasyMode();
            ExcludeDragonMightFromEasyMode();
        }
    }
}