using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class BalinHoldsTheLine : Deck
    {
        public BalinHoldsTheLine()
            : base("Balin Holds the Line", "http://hallofbeorn.wordpress.com/2013/02/12/deck-balin-holds-the-line/")
        {
            DeckList =
@"Balin
Eowyn
Nori

Fili x3
Kili x3
Miner of the Iron Hills x2
Zigil Miner x2
Bofur (TRG) x2
Longbeard Elder x3
Longbeard Orc Slayer x2
Erebor Battle Master x3
Brok Ironfist x2
Gandalf (THOHaUH) x2

Cram x3
Hardy Leadership x2
King Under The Mountain x3
Steward of Gondor x3

Sneak Attack x2
A Very Good Tale x3
To Me! O My Kinsfolk! x2
We Are Not Idle x3
Stand and Fight x3
Lure of Moria x2";
        }
    }
}