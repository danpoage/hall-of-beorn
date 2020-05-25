using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class BeginningOfSetup
        : GameSegment
    {
        public BeginningOfSetup()
            : base(SetupStep.Setup_Begin)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var startOfSetupEffect = Effect.Create(SetupStep.Setup_Begin, EffectTiming.When, Trigger.When_Setup_Begins, "Beginning of setup")
                .Accept((gm) =>
                {
                    return "Beginning of setup";
                });

            return new List<Effect> { startOfSetupEffect };
        }
    }
}
