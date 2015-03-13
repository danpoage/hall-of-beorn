using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class CalledToTheSea : Deck
    {
        public CalledToTheSea()
            : base("Called to the Sea", "http://hallofbeorn.wordpress.com/2013/08/04/decks-gencon-2013/")
        {
            DeckList =
@"Elladan
Elrohir
Legolas

Errand-Rider x3
Vassal of the Windlord x2
Envoy of Pelargir x3
Gondorian Spearman x2
Bofur (THOHaUH) x3
Erestor x2
Faramir x2
Gandalf (Core) x3

Cram x2
Steward of Gondor x3
Rivendell Blade x3
Rivendell Bow x1
Blade of Gondolin x3
Gondorian Shield x3
Book of Eldacar x2

Sneak Attack x3
Foe-Hammer x3
Goblin-Cleaver x2
Feint x2
Hands Upon the Bow x3";
        }
    }
}