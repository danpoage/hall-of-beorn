using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play.Resource
{
    public class GainResources
        : GameSegment
    {
        public GainResources()
            : base(Phase.Resource, FrameworkStep.Resource_Gain_Resources)
        {
            AddPart(Play.FrameworkStep.Resource_Gain_Resources, (gm) => GainResourcesPart(gm));
        }

        private static ExecutionResult GainResourcesPart(Game game)
        {
            var effects = new List<Effect>();

            foreach (var player in game.Players)
            {
                foreach (var hero in player.Heroes)
                {
                    effects.Add(Effect.Create(FrameworkStep.Resource_Gain_Resources, EffectTiming.When, Trigger.When_Hero_Gains_Resources, "When hero gains resources")
                        .Accept((gm) => {
                            hero.ResourceTokens += 6;
                            return string.Format("{0} gains 1 resource", hero.Card.NormalizedTitle);
                        }));
                }
            }

            return ExecutionResult.Create(effects);
        }
    }
}