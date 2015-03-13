using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.TalesFromTheCards
{
    public class TrapsOfIthilien : Deck
    {
        public TrapsOfIthilien()
            : base("Traps of Ithilien", "http://talesfromthecards.wordpress.com/2013/08/27/deck-spotlight-traps-of-ithilien/")
        {
            DeckList =
@"Faramir (AoO) x1
Mirlonde (TDF) x1
Denethor (Core) x1

Rivendell Minstrel (THFG) x3
Ithilien Tracker (HON) x3
Mirkwood Runner (RtM) x2
Haldir of Lorien (AJtR) x2
Ithilien Archer (EaAD) x3
Silvan Tracker (TDM) x3
Anborn (BoG) x2

Song of Battle (TDM) x1
Ithilien Pit (EaAD) x3
A Burning Brand (CatC) x2
Gondorian Shield (TSF) x3
Great Yew Bow (OtD) x2
Poisoned Stakes (BoG) x3
Ranger Bow (AoO) x3
Ranger Spikes (HON) x3

Expecting Mischief (OHaUH) x3
Forest Patrol (AoO) x3
Hands Upon the Bow (SaF) x3
Advance Warning (TDF) x3";
        }
    }
}