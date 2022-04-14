using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.ScenarioPack
{
    public class TheCavesOfNibinDumCampaignScenario
        : Scenario
    {
        public TheCavesOfNibinDumCampaignScenario()
        {
            Title = "The Caves of Nibin-Dûm (Campaign)";
            ProductName = "The Dark of Mirkwood";
            GroupName = "Mirkwood Paths";
            IsSubGroup = true;
            Number = 2;

            //QuestCompanionSlug = "starter-set-quest-the-caves-of-nibin-dum";
            DifficultyRating = 4.7f;
            Votes = 4;

            AddEncounterSet(EncounterSet.TheCavesOfNibinDumCampaign);
            AddEncounterSet(EncounterSet.TheGoblinsCampaign);

            AddQuestCardId("The-Dark-of-Nibin-Dum-TDoM");
            AddQuestCardId("Surprise-Attack-TDoM");
            AddQuestCardId("The-Chasm-TDoM");
            AddQuestCardId("Oathkeepers-TDoM");

            ExcludeFromEasyMode("Goblin-Runners-TDoM", 2);
            ExcludeFromEasyMode("Goblins-are-Upon-You-TDoM", 1);

            ExcludeFromEasyMode("Great-Cave-troll-TDoM", 2);
            ExcludeFromEasyMode("Branching-Paths-TDoM", 2);
            ExcludeFromEasyMode("Watchful-Eyes-TDoM", 1);
        }

    }
}