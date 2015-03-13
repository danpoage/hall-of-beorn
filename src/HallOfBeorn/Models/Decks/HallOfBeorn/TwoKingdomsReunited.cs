using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class TwoKingdomsReunited : Deck
    {
        public TwoKingdomsReunited()
            : base("Two Kingdoms Reunited", "http://hallofbeorn.wordpress.com/2013/03/31/deck-two-kingdoms-reunited/")
        {
            DeckList =
@"Aragorn (Core)
Boromir (HoN)
Eleanor

Errand-Rider x3
Envoy of Pelargir x3
Guard of the Citadel x3
Dúnedain Watcher x3
Son of Arnor x2
Faramir (Core) x2
Damrod x2
Northern Tracker x2
Citadel Custodian x2
Gandalf (Core) x3

Blood of Númenor x2
Steward of Gondor x3
Celebrian's Stone x2
Sword that was Broken x3

A Very Good Tale x3
Wealth of Gondor x3
Sneak Attack x3
Valiant Sacrifice x3
The Galadhrim's Greeting x3";
        }
    }
}