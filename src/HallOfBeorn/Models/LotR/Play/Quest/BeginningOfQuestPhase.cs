using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Quest
{
    public class BeginningOfQuestPhase
        : GameSegment
    {
        public BeginningOfQuestPhase()
            : base(Phase.Quest, FrameworkStep.Quest_Begin)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var startOfPhaseEffect = Effect.Create(FrameworkStep.Quest_Begin, EffectTiming.When, Trigger.When_Phase_Begins, "Beginning of quest phase")
                .Accept((gm) =>
                {
                    return "Beginning of quest phase";
                });

            return new List<Effect> { startOfPhaseEffect };
        }
    }
}