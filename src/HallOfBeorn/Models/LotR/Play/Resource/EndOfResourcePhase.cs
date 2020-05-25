using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Resource
{
    public class EndOfResourcePhase
        : GameSegment
    {
        public EndOfResourcePhase()
            : base(Phase.Resource, FrameworkStep.Resource_End)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var endOfPhaseEffect = Effect.Create(SetupStep.None, EffectTiming.After, Trigger.After_End_of_Phase, "End of resource phase")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    gm.Phase = Play.Phase.Planning;
                    gm.FrameworkStep = Play.FrameworkStep.None;
                    return "End of resource phase";
                });

            return new List<Effect> { endOfPhaseEffect };
        }
    }
}
