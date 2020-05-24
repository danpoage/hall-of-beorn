using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class EndOfSetup
        : GameSegment
    {
        public EndOfSetup()
            : base(SetupStep.Setup_End, Phase.None, FrameworkStep.None)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var startFirstRoundEffect = Effect.Create(SetupStep.Setup_End, EffectTiming.After, Trigger.After_End_of_Setup, "End of Setup")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    gm.SetupStep = Play.SetupStep.None;
                    gm.Phase = Play.Phase.Resource;
                    return string.Format("End of Setup");
                });

            return new List<Effect> { startFirstRoundEffect };
        }
    }
}
