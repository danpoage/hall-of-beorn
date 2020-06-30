using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Effects
{
    public class ChooseResultTargets
        : GamePart
    {
        public ChooseResultTargets(GameSegment segment, FrameworkStep step)
            : base(segment, step, null)
        {
        }

        public override ExecutionResult Execute(Game game)
        {
            var effects = new List<Effect>();

            return new ExecutionResult(effects);
        }
    }
}