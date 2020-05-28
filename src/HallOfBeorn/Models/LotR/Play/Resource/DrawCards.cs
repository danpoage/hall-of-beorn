using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Resource
{
    public class DrawCards
        : GameSegment
    {
        public DrawCards()
            : base(Phase.Resource, FrameworkStep.Resource_Draw_Cards)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var effects = new List<Effect>();

            foreach (var player in game.Players)
            {
                effects.Add(Effect.Create(FrameworkStep.Resource_Draw_Cards, EffectTiming.When, Trigger.When_Player_Draws_Cards, "When a player draws cards")
                    .Accept((gm) =>
                        {
                            var drawCount = 1;
                            var draw = player.Deck.Draw(drawCount);
                            var drawName = string.Join(", ", draw.Select(d => d.Card.NormalizedTitle));
                            player.Hand.AddRange(draw);
                            return (drawCount > 1)
                                ? string.Format("{0} draws {1} cards: {2}", player.Name, drawCount, drawName)
                                : string.Format("{0} draws 1 card: {1}", player.Name, drawName);
                        }));
            }

            return effects;
        }
    }
}