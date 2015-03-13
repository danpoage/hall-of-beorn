using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class CaldarasSacrifice : Deck
    {
        public CaldarasSacrifice()
            : base("Caldara's Sacrifice", "http://hallofbeorn.wordpress.com/2013/10/31/deck-caldaras-sacrifice/")
        {
            DeckList =
@"Caldara
Frodo Baggins (CatC)
Glorfindel (FoS)

Arwen Undomiel x3
Escort from Edoras x3
Imladris Stargazer x3
The Riddermark’s Finest x2
Zigil Miner x3
Emery x2
Damrod x2
Elfhelm x2
Northern Tracker x3
Gandalf (H:OHaUH) x3

Light of Valinor x3
Resourceful x3
Ancient Mathom x3
Unexpected Courage x2

Elrond’s Counsel x3
A Test of Will x3
Dwarven Tomb x2
Hasty Stroke x2
The Galadhrim’s Greeting x3";
        }
    }
}