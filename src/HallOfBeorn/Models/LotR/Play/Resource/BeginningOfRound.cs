using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Resource
{
    public class BeginningOfRound
        : GameSegment
    {
        public BeginningOfRound()
            : base(Phase.Resource, FrameworkStep.Resource_Begin)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var startOfRoundEffect = Effect.Create(FrameworkStep.Round_Begin, EffectTiming.When, Trigger.When_Round_Begins, "Beginning of round")
                .Accept((gm) =>
                {
                    gm.RoundNumber += 1;
                    return string.Format("Beginning of round {0}", gm.RoundNumber);
                });

            return new List<Effect> { startOfRoundEffect };
        }
    }
}
