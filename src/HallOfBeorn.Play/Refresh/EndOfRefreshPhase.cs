using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play.Refresh
{
    public class EndOfRefreshPhase
        : GameSegment
    {
        public EndOfRefreshPhase()
            : base(Phase.Refresh, FrameworkStep.Refresh_End)
        {
            AddPart(Play.FrameworkStep.Refresh_End, (gm) => EndOfPhase(gm));
        }

        private static ExecutionResult EndOfPhase(Game game)
        {
            var endOfPhaseEffect = Effect.Create(FrameworkStep.Refresh_End, EffectTiming.After, Trigger.After_End_of_Phase, "End of refresh phase")
                .Accept((gm) =>
                {
                    return "End of refresh phase";
                });


            return ExecutionResult.Create(endOfPhaseEffect);
        }
    }
}