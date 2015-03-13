using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class ThePowerOfThePalantir : Deck
    {
        public ThePowerOfThePalantir()
            : base("The Power of the Palantir", "http://hallofbeorn.wordpress.com/2013/02/05/deck-the-power-of-the-palantir/")
        {
            DeckList =
@"Denethor (Core)
Frodo Baggins (CatC)
Glorfindel (FoS)

Henamarth Riversong x2
Imladris Stargazer x3
Zigil Miner x3
Master of the Forge x3
Gleowine x3
Northern Tracker x3
Gildor Inglorion x2

Resourceful x3
Light of Valinor x3
Ancient Mathom x2
Palantir x2
Asfaloth x2
Fast Hitch x1
Unexpected Courage x3

Peace, and Thought x2
Elrond's Counsel x3
Shadow of the Past x2
A Watchful Peace x3
Small Target x2
The Galadhrim's Greeting x3";
        }
    }
}