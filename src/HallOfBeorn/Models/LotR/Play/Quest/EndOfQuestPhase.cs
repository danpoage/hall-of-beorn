using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Quest
{
    public class EndOfQuestPhase
        : GameSegment
    {
        public EndOfQuestPhase()
            : base(SetupStep.None, Phase.Quest, FrameworkStep.Quest_End)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var endOfPhaseEffect = Effect.Create(SetupStep.Setup_End, EffectTiming.After, Trigger.After_End_of_Setup, "End of quest phase")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    gm.Phase = Play.Phase.Travel;
                    gm.FrameworkStep = Play.FrameworkStep.None;
                    return "End of quest phase";
                });

            return new List<Effect> { endOfPhaseEffect };
        }
    }
}