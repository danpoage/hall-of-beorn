using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Travel
{
    public class EndOfTravelPhase
        : GameSegment
    {
        public EndOfTravelPhase()
            : base(Phase.Travel, FrameworkStep.Travel_End)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var endOfPhaseEffect = Effect.Create(SetupStep.None, EffectTiming.After, Trigger.After_End_of_Phase, "End of travel phase")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    gm.Phase = Play.Phase.Encounter;
                    gm.FrameworkStep = Play.FrameworkStep.None;
                    return "End of travel phase";
                });

            return new List<Effect> { endOfPhaseEffect };
        }
    }
}