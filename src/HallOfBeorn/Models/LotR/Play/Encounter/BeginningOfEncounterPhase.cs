using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Encounter
{
    public class BeginningOfEncounterPhase
        : GameSegment
    {
        public BeginningOfEncounterPhase()
            : base(Phase.Encounter, FrameworkStep.Encounter_Begin)
        {
            AddPart(Play.FrameworkStep.Encounter_Begin, (gm) => StartOfPhase(gm));
        }

        private static ExecutionResult StartOfPhase(Game game)
        {
            var startOfPhaseEffect = Effect.Create(FrameworkStep.Encounter_Begin, EffectTiming.When, Trigger.When_Phase_Begins, "Beginning of encounter phase")
                .Accept((gm) =>
                {
                    return "Beginning of encounter phase";
                });

            return ExecutionResult.Create(startOfPhaseEffect);
        }
    }
}