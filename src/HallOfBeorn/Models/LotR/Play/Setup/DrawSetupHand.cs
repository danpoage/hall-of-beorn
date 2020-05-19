using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class DrawSetupHand
        : GameSegment
    {
        public override IEnumerable<Effect> Execute(Game game)
        {
            var effects = LookupEffectsByTrigger(Trigger.Setup_Determine_Starting_Hand_Size);

            foreach (var player in game.Players)
            {
                player.IsActivePlayer = true;
                player.SetupStep = SetupStep.Setup_Draw_Setup_Hand;

                var hand = player.Deck.Draw(player.SetupHandSize);
                player.Hand.AddRange(hand);
                game.Log(string.Format("Player {0} Draws {1} Cards in their Setup Hand", player.Name, player.SetupHandSize));
            }

            return effects;
        }
    }
}
