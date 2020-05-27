using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Planning
{
    public class PlanningPhaseEnds
        : GameSegment
    {
        public PlanningPhaseEnds()
            : base(Phase.Planning, FrameworkStep.Planning_End)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var endOfPhaseEffect = Effect.Create(SetupStep.Setup_End, EffectTiming.After, Trigger.After_End_of_Setup, "End of planning phase")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    gm.Phase = Play.Phase.Quest;
                    gm.FrameworkStep = Play.FrameworkStep.None;
                    return "End of planning phase";
                });

            return new List<Effect> { endOfPhaseEffect };
        }
    }
}
