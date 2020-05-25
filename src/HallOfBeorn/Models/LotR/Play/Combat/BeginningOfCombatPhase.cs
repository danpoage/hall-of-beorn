using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Combat
{
    public class BeginningOfCombatPhase
        : GameSegment
    {
        public BeginningOfCombatPhase()
            : base(Phase.Combat, FrameworkStep.Combat_Begin)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var startOfPhaseEffect = Effect.Create(FrameworkStep.Combat_Begin, EffectTiming.When, Trigger.When_Phase_Begins, "Beginning of combat phase")
                .Accept((gm) =>
                {
                    return "Beginning of combat phase";
                });

            return new List<Effect> { startOfPhaseEffect };
        }
    }
}
