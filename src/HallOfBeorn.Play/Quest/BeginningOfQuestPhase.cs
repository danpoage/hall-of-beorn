using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play.Quest
{
    public class BeginningOfQuestPhase
        : GameSegment
    {
        public BeginningOfQuestPhase()
            : base(Phase.Quest, FrameworkStep.Quest_Begin)
        {
        }

        public static ExecutionResult StartOfPhase(Game game)
        {
            var startOfPhaseEffect = Effect.Create(FrameworkStep.Quest_Begin, EffectTiming.When, Trigger.When_Phase_Begins, "Beginning of quest phase")
                .Accept((gm) =>
                {
                    return "Beginning of quest phase";
                });

            return ExecutionResult.Create(startOfPhaseEffect);
        }
    }
}