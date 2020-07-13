using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play.Planning
{
    public class PlanningPhaseEnds
        : GameSegment
    {
        public PlanningPhaseEnds()
            : base(Phase.Planning, FrameworkStep.Planning_End)
        {
            AddPart(Play.FrameworkStep.Planning_End, (gm) => EndOfPhase(gm));
        }

        private static ExecutionResult EndOfPhase(Game game)
        {
            var endOfPhaseEffect = Effect.Create(SetupStep.Setup_End, EffectTiming.After, Trigger.After_End_of_Setup, "End of planning phase")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    gm.Phase = Play.Phase.Quest;
                    gm.FrameworkStep = Play.FrameworkStep.None;
                    return "End of planning phase";
                });

            return ExecutionResult.Create(endOfPhaseEffect);
        }
    }
}
