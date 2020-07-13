using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play.Setup
{
    public class EndOfSetup
        : GameSegment
    {
        public EndOfSetup()
            : base(SetupStep.Setup_End)
        {
            AddPart(SetupStep.Setup_End, (gm) => EndOfSetupPart(gm));
        }

        private static ExecutionResult EndOfSetupPart(Game game)
        {
            var startFirstRoundEffect = Effect.Create(SetupStep.Setup_End, EffectTiming.After, Trigger.After_End_of_Setup, "End of Setup")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    gm.SetupStep = Play.SetupStep.None;
                    gm.Phase = Play.Phase.Resource;
                    return string.Format("End of Setup");
                });

            return ExecutionResult.Create(startFirstRoundEffect);
        }
    }
}
