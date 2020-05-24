using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Resource
{
    public class StartOfRound
        : GameSegment
    {
        public StartOfRound()
            : base(SetupStep.None, Phase.Resource, FrameworkStep.Round_Begin)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var roundStartEffect = Effect.Create(FrameworkStep.Refresh_End, EffectTiming.After, Trigger.After_End_of_Round, "Start of Round")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    gm.Phase = Play.Phase.Resource;
                    gm.RoundNumber += 1;
                    return string.Format("Start of round {0}", gm.RoundNumber);
                });

            return new List<Effect> { roundStartEffect };
        }
    }
}