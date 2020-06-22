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
            : base(SetupStep.Setup_Follow_Scenario_Setup_Instructions)
        {
            AddPart(SetupStep.Setup_Follow_Scenario_Setup_Instructions, (gm) => ScenarioSetupPart(gm));
        }

        private static ExecutionResult ScenarioSetupPart(Game game)
        {
            //TODO: get setup effects
            return new ExecutionResult();
        }
    }
}
