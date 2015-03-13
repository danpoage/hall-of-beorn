using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class BoromirAndTheSevenDwarves : Deck
    {
        public BoromirAndTheSevenDwarves()
            : base("Boromir and the Seven Dwarves", "http://hallofbeorn.wordpress.com/2013/01/22/deck-boromir-and-the-seven-dwarves/")
        {
            DeckList =
@"Boromir (TDM)
Nori
Bifur (KD)

Erebor Record Keeper x3
Erebor Hammersmith x3
Imladris Stargazer x3
Zigil Miner x3
Longbeard Map-Maker x3
Dori (THOHaUH) x1
Bombur (RtR) x1
Fili (THOHaUH) x1
Kili (THOHaUH) x1
Bofur (TRG) x2
Erebor Battle Master x3

Horn of Gondor x2
Legacy of Durin x3
Ranger Spikes x3
Healing Herbs x3
Protector of Lorien x2

Daeron's Runes x3
A Test of Will x2
Feint x3
Stand and Fight x3
The Galadhrim's Greeting x2";
        }
    }
}