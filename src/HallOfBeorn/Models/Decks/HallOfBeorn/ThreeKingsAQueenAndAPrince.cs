using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class ThreeKingsAQueenAndAPrince : Deck
    {
        public ThreeKingsAQueenAndAPrince()
            : base("Three Kings, A Queen, and a Prince", "http://hallofbeorn.wordpress.com/2013/06/28/deck-three-kings-a-queen-and-a-prince/")
        {
            DeckList =
@"Aragorn (Core)
Dain Ironfoot
Balin

Errand-Rider x3
Arwen Undomiel x2
Longbeard Elder x3
Fili (THOHaUH) x2
Kili (THOHaUH) x1
Gloin (THOtD) x2
Dwalin (THOtD) x1
Bifur (THOtD) x2
Bofur (TRG) x1
Bombur (RtR) x1
Longbeard Orc Slayer x1
Faramir (Core) x2
Gandalf (Core) x3

King Under the Mountain x3
Steward of Gondor x3
Narvi's Belt x3
Celebrian's Stone x2
Sword that was Broken x2

A Very Good Tale x2
We Are Not Idle x3
Sneak Attack x3
Strength of Arms x3
Lure of Moria x2";
        }
    }
}