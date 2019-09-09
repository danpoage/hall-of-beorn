using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened
{
    public class TheBattleOfCarnDumScenario : AngmarAwakenedScenario
    {
        public TheBattleOfCarnDumScenario()
        {
            Title = "The Battle of Carn Dûm";
            ProductName = "The Battle of Carn Dûm";
            GroupName = "Angmar Awakened";
            Number = 5;

            QuestCompanionSlug = "angmar-awakened-quest-the-battle-of-carn-dum";
            DifficultyRating = 9.6f;
            Votes = 40;

            AddTheLineUnbrokenLink("50", "1VHJ6jEwCG0");
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2019/01/24/the-battle-of-carn-dum/");

            AddEncounterSet(EncounterSet.TheBattleOfCarnDum);
            AddEncounterSet(EncounterSet.TheBattleOfCarnDumNightmare);
            AddEncounterSet(EncounterSet.AngmarOrcs);
            AddEncounterSet(EncounterSet.DarkSorcery);

            AddQuestCardId("The-Clutches-of-Carn-Dum-TBoCD");
            AddQuestCardId("Midwinter's-Crux-TBoCD");

            ExcludeAngmarOrcsFromEasyMode();
            ExcludeDarkSorceryFromEasyMode();

            ExcludeFromEasyMode("Carn-Dum-Garrison-TBoCD", 1);
            ExcludeFromEasyMode("Orc-Grunts-TBoCD", 2);
            ExcludeFromEasyMode("Werewolf-of-Angmar-TBoCD", 2);
            ExcludeFromEasyMode("Fortress-Walls-TBoCD", 2);
            ExcludeFromEasyMode("The-Sky-Darkens-TBoCD", 2);
            ExcludeFromEasyMode("Daechanar's-Will-TBoCD", 1);

            ExcludeFromNightmareMode("Vile-Afflication-TBoCD", 1);
            ExcludeFromNightmareMode("Furious-Charge-TBoCD", 1);
            ExcludeFromNightmareMode("Orc-Ambush-TLR", 1);
            ExcludeFromNightmareMode("Angmar-Orc-TLR", 1);
            ExcludeFromNightmareMode("Angmar-Marauder-TLR", 3);
            ExcludeFromNightmareMode("Terror-of-the-North-TBoCD", 3);
            ExcludeFromNightmareMode("Accursed-Battlefield-TBoCD", 2);
            ExcludeFromNightmareMode("Blight-of-Carn-Dum-TBoCD", 1);
        }
    }
}