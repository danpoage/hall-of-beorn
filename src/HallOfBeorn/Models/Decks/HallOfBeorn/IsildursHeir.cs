using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class IsildursHeir : Deck
    {
        public IsildursHeir()
            : base("Isildur's Heir", "http://hallofbeorn.wordpress.com/2013/05/28/deck-isildurs-heir/")
        {
            DeckList =
@"Aragorn (Core)
Boromir (TDM)
Denethor

Errand-Rider x2
Envoy of Pelargir x3
Gondorian Spearman x3
Warden of Healing x2
Ithilien Tracker x2
Guard of the Citadel x2
Citadel Custodian x2
Faramir x2
Gandalf (Core) x3

Steward of Gondor x3
Celebrian's Stone x3
Sword that was Broken x2
Ring of Barahir x2
Horn of Gondor x2
Spear of the Citadel x2
Gondorian Shield x2
A Burning Brand x2
Unexpected Courage x2

Daeron's Runes x3
Sneak Attack x3
Valiant Sacrifice x3";
        }
    }
}