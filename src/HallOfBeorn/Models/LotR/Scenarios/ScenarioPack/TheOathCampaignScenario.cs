using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.ScenarioPack
{
    public class TheOathCampaignScenario
        : Scenario
    {
        public TheOathCampaignScenario()
        {
            Title = "The Oath (Campaign)";
            ProductName = "The Dark of Mirkwood";
            GroupName = "Mirkwood Paths";
            IsSubGroup = true;
            Number = 1;

            //QuestCompanionSlug = "starter-set-quest-the-oath";
            DifficultyRating = 2.3f;
            Votes = 4;

            AddEncounterSet(EncounterSet.TheOathCampaign);
            AddEncounterSet(EncounterSet.TheGoblinsCampaign);

            AddQuestCardId("After-the-Raid-TDoM");
            AddQuestCardId("Mirkwood-Forest-TDoM");
            AddQuestCardId("The-Rearguard-TDoM");

            ExcludeFromEasyMode("Goblin-Runners-TDoM", 2);
            ExcludeFromEasyMode("Goblins-are-Upon-You-TDoM", 1);

            ExcludeFromEasyMode("Spiders-of-Mirkwood-TDoM", 2);
            ExcludeFromEasyMode("Tangled-Grove-TDoM", 2);
            ExcludeFromEasyMode("Caught-in-a-Web-TDoM", 1);
        }

    }
}