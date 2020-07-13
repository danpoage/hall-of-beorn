using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play.Resource
{
    public class EndOfResourcePhase
        : GameSegment
    {
        public EndOfResourcePhase()
            : base(Phase.Resource, FrameworkStep.Resource_End)
        {
            AddPart(Play.FrameworkStep.Resource_End, (gm) => EndOfPhase(gm));
        }

        private static ExecutionResult EndOfPhase(Game game)
        {
            var endOfPhaseEffect = Effect.Create(FrameworkStep.Resource_End, EffectTiming.After, Trigger.After_End_of_Phase, "End of resource phase")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    gm.Phase = Play.Phase.Planning;
                    gm.FrameworkStep = Play.FrameworkStep.None;
                    return "End of resource phase";
                });

            return ExecutionResult.Create(endOfPhaseEffect);
        }
    }
}
