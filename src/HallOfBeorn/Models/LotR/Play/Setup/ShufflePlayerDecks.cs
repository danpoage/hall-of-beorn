using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class ShufflePlayerDecks
        : GameSegment
    {
        public override IEnumerable<Effect> Execute(Game game)
        {
            foreach (var player in game.Players)
            {
                player.IsActivePlayer = true;
                player.Deck.Shuffle();
                game.Log(string.Format("Shuffle Player Deck for {0}", player.Name));
            }

            return Enumerable.Empty<Effect>();
        }
    }
}