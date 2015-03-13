using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class LocationControl : Deck
    {
        public LocationControl()
            : base("Location Control", "http://hallofbeorn.wordpress.com/2013/01/28/deck-location-control/")
        {
            DeckList =
@"Denethor (Core)
Eowyn (Core)
Glorfindel (FoS)

Henemarth Riversong x2
Erebor Hammersmith x2
Master of the Forge x2
Gleowine (Core) x2
Imladris Stargazer x3
Zigil Miner x2
The Riddermark's Finest x2
Lorien Guide x1
Northern Tracker x3
Gandalf (THOHaUH) x2

Light of Valinor x3
Miruvor x3
Ancient Mathom x3
Asfaloth x2
Thror's Map x2
Unexpected Courage x2

Daeron's Runes x3
Elrond's Counsel x3
A Test of Will x2
Dwarven Tomb x1
Will of the West x1
A Watchful Peace x2
Shadow of the Past x2";
        }
    }
}