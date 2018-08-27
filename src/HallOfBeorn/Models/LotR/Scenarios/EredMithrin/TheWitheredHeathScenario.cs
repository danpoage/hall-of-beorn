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

            //QuestCompanionSlug = "the-dream-chaser-quest-a-storm-on-cobas-haven";
            DifficultyRating = 6.5f;
            Votes = 1;

            RulesImageCount = 2;

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
            ExcludeLostInTheWildernessFromEasyMode();
        }
    }
}