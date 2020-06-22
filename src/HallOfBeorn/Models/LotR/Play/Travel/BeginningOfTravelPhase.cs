using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Travel
{
    public class BeginningOfTravelPhase
        : GameSegment
    {
        public BeginningOfTravelPhase()
            : base(Phase.Travel, FrameworkStep.Travel_Begin)
        {
            AddPart(Play.FrameworkStep.Travel_Begin, (gm) => StartOfPhase(gm));
        }

        private static ExecutionResult StartOfPhase(Game game)
        {
            var startOfPhaseEffect = Effect.Create(FrameworkStep.Travel_Begin, EffectTiming.When, Trigger.When_Phase_Begins, "Beginning of travel phase")
                .Accept((gm) =>
                {
                    return "Beginning of travel phase";
                });

            return ExecutionResult.Create(startOfPhaseEffect);
        }
    }
}
