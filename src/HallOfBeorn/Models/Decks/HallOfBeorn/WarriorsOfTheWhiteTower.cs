using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class WarriorsOfTheWhiteTower : Deck
    {
        public WarriorsOfTheWhiteTower()
            : base("Warriors of the White Tower", "http://hallofbeorn.wordpress.com/2013/12/17/deck-warriors-of-the-white-tower/")
        {
            DeckList =
@"Beregond
Háma
Merry (TBR)

Vassal of the Windlord x3
Envoy of Pelargir x3
Gondorian Spearman x3
Defender of Rammas x2
Bofur (THOHaUH) x2
Guthlaf x2
Knight of Minas Tirith x3
White Tower Watchman x2
Gandalf (Core) x3

Horn of Gondor x2
Gondorian Shield x3
Dagger of Westernesse x3
Spear of the Mark x2
Spear of the Citadel x3

Foe-hammer x3
Gondorian Discipline x2
Behind Strong Walls x2
Feint x2
Halfling Determination x3
Trained For War x2";
        }
    }
}