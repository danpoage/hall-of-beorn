using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play.Combat
{
    public class BeginningOfCombatPhase
        : GameSegment
    {
        public BeginningOfCombatPhase()
            : base(Phase.Combat, FrameworkStep.Combat_Begin)
        {
            AddPart(Play.FrameworkStep.Combat_Begin, (gm) => StartOfPhase(gm));
        }

        private static ExecutionResult StartOfPhase(Game game)
        {
            var startOfPhaseEffect = Effect.Create(FrameworkStep.Combat_Begin, EffectTiming.When, Trigger.When_Phase_Begins, "Beginning of combat phase")
                .Accept((gm) =>
                {
                    return "Beginning of combat phase";
                });

            return ExecutionResult.Create(startOfPhaseEffect);
        }
    }
}
