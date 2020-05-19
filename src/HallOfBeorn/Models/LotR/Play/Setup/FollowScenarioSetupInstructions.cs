using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class FollowScenarioSetupInstructions
        : GameSegment
    {
        public override IEnumerable<Effect> Execute(Game game)
        {
            var effects = new List<Effect>();

            //TODO: Get effects from A-side of quest card 1

            return effects;
        }
    }
}