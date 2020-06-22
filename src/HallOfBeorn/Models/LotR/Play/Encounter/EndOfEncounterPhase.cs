using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Encounter
{
    public class EndOfEncounterPhase
        : GameSegment
    {
        public EndOfEncounterPhase()
            : base(Phase.Encounter, FrameworkStep.Encounter_End)
        {
            AddPart(Play.FrameworkStep.Encounter_End, (gm) => EndOfPhase(gm));
        }

        private static ExecutionResult EndOfPhase(Game game)
        {
            var endOfPhaseEffect = Effect.Create(FrameworkStep.Encounter_End, EffectTiming.After, Trigger.After_End_of_Phase, "End of encounter phase")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    gm.Phase = Play.Phase.Combat;
                    gm.FrameworkStep = Play.FrameworkStep.None;
                    return "End of encounter phase";
                });

            return ExecutionResult.Create(endOfPhaseEffect);
        }
    }
}