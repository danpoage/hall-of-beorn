using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.EredMithrin
{
    public class TheWitheredHeathScenario : EredMithrinScenario
    {
        private const string name = "The Withered Heath";

        public TheWitheredHeathScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Ered Mithrin";
            Number = 4;

            QuestCompanionSlug = "ered-mithrin-quest-the-withered-heath";
            DifficultyRating = 6.6f;
            Votes = 12;

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC66.pdf";
            RulesImageCount = 2;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2020/04/11/the-withered-heath/");

            AddEncounterSet(EncounterSet.TheWitheredHeath);
            AddEncounterSet(EncounterSet.LostCaves);
            AddEncounterSet(EncounterSet.WildCreatures);
            AddEncounterSet(EncounterSet.LostInWilderland);

            AddQuestCardId("Searching-for-Dragon-Sign-TWH");
            AddQuestCardId("The-Cold-Drake-Attacks-TWH");
            AddQuestCardId("Hunting-the-Beast-TWH");
            AddQuestCardId("A-Cornered-Dragon-TWH");

            ExcludeFromEasyMode("Snow-troll-TWH", 1);
            ExcludeFromEasyMode("Dragon-Hatchling-TWH", 1);
            ExcludeFromEasyMode("Cave-Entrance-TWH", 1);
            ExcludeFromEasyMode("High-Falls-TWH", 1);
            ExcludeFromEasyMode("Heavy-Snow-TWH", 1);
            ExcludeFromEasyMode("Deadly-Cold-TWH", 1);

            ExcludeWildCreaturesFromEasyMode();
            ExcludeLostInWilderlandFromEasyMode();
        }
    }
}