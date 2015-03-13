using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class MastersOfTheForest : Deck
    {
        public MastersOfTheForest()
            : base("Masters of the Forest", "http://hallofbeorn.wordpress.com/2013/06/02/deck-masters-of-the-forest/")
        {
            DeckList =
@"Elrond
Aragorn (TWitW)
Mirlonde

Henamarth Riversong x1
Erebor Hammersmith x2
Miner of the Iron Hills x2
Master of the Forge x3
Master of Lore x3
Daughter of the Nimrodel x2
Rivendell Minstrel x3
Silvan Tracker x3
Mirkwood Runner x2
Haldir of Lorien x2
Gildor Inglorion x3

A Burning Brand x2
Protector of Lorien x2
Celebrian's Stone x2
Vilya x2
Song of Kings x1
Song of Travel x1
Steward of Gondor x2

Daeron's Runes x3
A Test of Will x3
Mithrandir's Advice x3
Expecting Mischief x3";
        }
    }
}