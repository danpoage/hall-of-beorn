using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Planning
{
    public class BeginningOfPlanningPhase
        : GameSegment
    {
        public BeginningOfPlanningPhase()
            : base(Phase.Planning, FrameworkStep.Planning_Begin)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var startOfPhaseEffect = Effect.Create(FrameworkStep.Planning_Begin, EffectTiming.When, Trigger.When_Phase_Begins, "Beginning of planning phase")
                .Accept((gm) =>
                {
                    return "Beginning of planning phase";
                });

            return new List<Effect> { startOfPhaseEffect };
        }
    }
}
