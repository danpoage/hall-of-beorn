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

            QuestCompanionSlug = "ered-mithrin-quest-roam-across-rhovanion";
            DifficultyRating = 6.5f;
            Votes = 1;

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