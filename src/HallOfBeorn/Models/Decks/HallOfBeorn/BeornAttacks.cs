using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class BeornAttacks : Deck
    {
        public BeornAttacks()
            : base("Beorn Attacks!", "http://hallofbeorn.wordpress.com/2013/06/11/deck-beorn-attacks/")
        {
            DeckList =
@"Beorn (THOHaUH)
Balin
Oin

Veteran Axehand x2
Erebor Battle Master x3
Bofur (TRG) x1
Imladris Stargazer x2
Zigil Miner x3
Kili x2
Dwalin (THOtD) x2
Errand-Rider x3
Fili x2
Gloin (THotD) x2
Gandalf (Core) x3

Cram x3
King Under the Mountain x3
Narvi's Belt x3

Feint x2
A Very Good Tale x3
Gaining Strength x3
We Are Not Idle x2
Sneak Attack x2
Lure of Moria x2
A Test of Will x2";
        }
    }
}