using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class BardGoesHunting : Deck
    {
        public BardGoesHunting()
            : base("Bard Goes Hunting", "http://hallofbeorn.wordpress.com/2013/03/16/deck-bard-goes-hunting/")
        {
            DeckList =
@"Bard the Bowman
Eowyn
Glorfindel (FoS)

Arwen Undomiel x3
Zigil Miner x3
Imladris Stargazer x3
Northern Tracker x3
Gandalf (Core) x3
Bofur (THOHaUH) x2
Westfold Horse-Breaker x3

Black Arrow x1
Great Yew Bow x3
Blade of Gondolin x3
Light of Valinor x3
Unexpected Courage x3
Miruvor x2

Foe-Hammer x3
Elrond's Counsel x3
The Galadhrim's Greeting x3
A Test of Will x3
Hands Upon the Bow x3";
        }
    }
}