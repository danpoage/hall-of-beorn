using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class TheSpiritOfGondor : Deck
    {
        public TheSpiritOfGondor()
            : base("The Spirit of Gondor", "http://hallofbeorn.wordpress.com/2013/12/16/deck-the-spirit-of-gondor/")
        {
            DeckList =
@"Caldara
Eleanor
Glorfindel (FoS)

Minas Tirith Lampwright x2
Envoy of Pelargir x3
Escort From Edoras x2
Emery x2
Pelargir Shipwright x3
White Tower Watchman x3
Damrod x2
Gandalf (Core) x3

Blood of Númenor x2
Ancient Mathom x3
Light of Valinor x3
Unexpected Courage x2
Map of Earnil x2
Resourceful x3

Elrond's Counsel x3
A Test of Will x3
Dwarven Tomb x2
Hasty Stroke x3
The Galadhrim's Greeting x2
Light the Beacons x2";
        }
    }
}