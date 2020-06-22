using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Refresh
{
    public class BeginningOfRefreshPhase
        : GameSegment
    {
        public BeginningOfRefreshPhase()
            : base(Phase.Refresh, FrameworkStep.Refresh_Begin)
        {
            AddPart(Play.FrameworkStep.Refresh_Begin, (gm) => StartOfPhase(gm));
        }

        private static ExecutionResult StartOfPhase(Game game)
        {
            var startOfPhaseEffect = Effect.Create(FrameworkStep.Refresh_Begin, EffectTiming.When, Trigger.When_Phase_Begins, "Beginning of refresh phase")
                .Accept((gm) =>
                {
                    return "Beginning of refresh phase";
                });

            return ExecutionResult.Create(startOfPhaseEffect);
        }
    }
}
