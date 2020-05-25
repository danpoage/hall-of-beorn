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
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var startOfPhaseEffect = Effect.Create(FrameworkStep.Travel_Begin, EffectTiming.When, Trigger.When_Phase_Begins, "Beginning of travel phase")
                .Accept((gm) =>
                {
                    return "Beginning of travel phase";
                });

            return new List<Effect> { startOfPhaseEffect };
        }
    }
}
