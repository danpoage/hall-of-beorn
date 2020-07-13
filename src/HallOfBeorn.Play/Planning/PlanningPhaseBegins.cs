using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play.Planning
{
    public class PlanningPhaseBegins
        : GameSegment
    {
        public PlanningPhaseBegins()
            : base(Phase.Planning, FrameworkStep.Planning_Begin)
        {
            AddPart(Play.FrameworkStep.Planning_Begin, (gm) => StartOfPhase(gm));
        }

        private static ExecutionResult StartOfPhase(Game game)
        {
            var startOfPhaseEffect = Effect.Create(FrameworkStep.Planning_Begin, EffectTiming.When, Trigger.When_Phase_Begins, "Beginning of planning phase")
                .Accept((gm) =>
                {
                    return "Beginning of planning phase";
                });

            return ExecutionResult.Create(startOfPhaseEffect);
        }
    }
}
