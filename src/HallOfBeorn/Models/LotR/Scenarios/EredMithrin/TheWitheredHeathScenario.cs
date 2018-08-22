using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.EredMithrin
{
    public class TheWitheredHeathScenario : Scenario
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
        }
    }
}