using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class FollowScenarioSetupInstructions
        : GameSegment
    {
        public FollowScenarioSetupInstructions()
            : base(SetupStep.Setup_Follow_Scenario_Setup_Instructions, Phase.None, FrameworkStep.None)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var effects = new List<Effect>();

            //TODO: Get effects from A-side of quest card 1

            game.RoundNumber = 1;
            game.Phase = Phase.Resource;

            return effects;
        }
    }
}