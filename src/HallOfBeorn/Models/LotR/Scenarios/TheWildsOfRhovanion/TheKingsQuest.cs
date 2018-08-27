using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheWildsOfRhovanion
{
    public class TheKingsQuest : Scenario
    {
        public TheKingsQuest()
        {
            Title = "The King's Quest";
            ProductName = "The Wilds of Rhovanion";
            GroupName = "The Wilds of Rhovanion";
            Number = 3;

            RulesImageCount = 7;
            //QuestCompanionSlug = "";
            DifficultyRating = 7.0f;
            Votes = 1;

            AddEncounterSet(EncounterSet.FellBeasts);
            AddEncounterSet(EncounterSet.WildCreatures);
            AddEncounterSet(EncounterSet.DeepUnderground);
            AddEncounterSet(EncounterSet.AfraidOfTheDark);
            AddEncounterSet(EncounterSet.DragonMight);
            AddEncounterSet(EncounterSet.LostCaves);
            AddEncounterSet(EncounterSet.TheKingsQuest);

            AddQuestCardId("The-Iron-Hills-TWoR");
            AddQuestCardId("The-Lower-Depths-TWoR");
            AddQuestCardId("The-Fire-Worm-TWoR");
            
            //Fell Beasts
            ExcludeFromEasyMode("Stone-Troll-TWoR", 1);
            ExcludeFromEasyMode("Hobgoblin-TWoR", 1);
            
            //Wild Creatures
            ExcludeFromEasyMode("Werewolf-TWoR", 1);
            ExcludeFromEasyMode("Black-Bats-TWoR", 1);

            //Deep Underground
            ExcludeFromEasyMode("Dark-Tunnel-TWoR", 1);
            
            //Afraid of the Dark
            ExcludeFromEasyMode("Afraid-of-the-Dark-TWoR", 1);
            ExcludeFromEasyMode("Eyes-in-the-Dark-TWoR", 1);
            
            //Dragon Might
            ExcludeFromEasyMode("Dragon-Breath-TWoR", 1);
            ExcludeFromEasyMode("Dragon-Scales-TWoR", 1);

            //The King's Quest
            ExcludeFromEasyMode("Iron-Hills-Mine-TWoR", 1);
            ExcludeFromEasyMode("Deep-Chasm-TWoR", 1);
            ExcludeFromEasyMode("Denizen-of-the-Deep-TWoR", 1);
        }
    }
}