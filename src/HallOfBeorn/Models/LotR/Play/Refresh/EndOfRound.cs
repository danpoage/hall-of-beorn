using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Refresh
{
    public class EndOfRound
        : GameSegment
    {
        public EndOfRound()
            : base(Phase.Refresh, FrameworkStep.Round_End)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var endOfRoundEffect = Effect.Create(FrameworkStep.Round_End, EffectTiming.After, Trigger.After_End_of_Round, "End of round")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    gm.Phase = Play.Phase.Resource;
                    gm.FrameworkStep = Play.FrameworkStep.None;
                    return string.Format("End of round {0}", gm.RoundNumber);
                });

            return new List<Effect> { endOfRoundEffect };
        }
    }
}