using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.EredMithrin
{
    public class TheGhostOfFramsburgScenario : EredMithrinScenario
    {
        private const string name = "The Ghost of Framsburg";

        public TheGhostOfFramsburgScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Ered Mithrin";
            Number = 7;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC69.pdf";
            RulesImageCount = 2;

            QuestCompanionSlug = "ered-mithrin-quest-the-ghost-of-framsburg";
            DifficultyRating = 5.6f;
            Votes = 5;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2020/07/15/the-ghost-of-framsburg/");

            AddEncounterSet(EncounterSet.TheGhostOfFramsburg);
            AddEncounterSet(EncounterSet.WildCreatures);
            AddEncounterSet(EncounterSet.AfraidOfTheDark);

            AddQuestCardId("The-Haunted-Keep-TGoF");
            AddQuestCardId("Searching-the-Ruins-TGoF");
            AddQuestCardId("The-Cursed-Shade-TGoF");

            ExcludeWildCreaturesFromEasyMode();
            ExcludeAfraidOfTheDarkFromEasyMode();

            ExcludeFromEasyMode("Crypt-Stalker-TGoF", 1);
            ExcludeFromEasyMode("Evil-Spectre-TGoF", 1);
            ExcludeFromEasyMode("Haunted-Hall-TGoF", 1);
            ExcludeFromEasyMode("Moonlit-Passage-TGoF", 1);
            ExcludeFromEasyMode("Cursed-Tower-TGoF", 1);
            ExcludeFromEasyMode("Abandoned-Ruins-TGoF", 1);
            ExcludeFromEasyMode("Terrible-Shadows-TGoF", 2);
        }
    }
}