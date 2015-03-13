using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class FlightToTheFord : Deck
    {
        public FlightToTheFord()
            : base("Flight to the Ford", "http://hallofbeorn.wordpress.com/2013/05/19/deck-flight-to-the-ford/")
        {
            DeckList =
@"Aragorn (TWitW)
Glorfindel (FoS)
Frodo (CatC)

Arwen Undomiel x2
Imladris Stargazer x3
Master of the Forge x3
Rivendell Minstrel x2
Northern Tracker x3
Gandalf (Core) x3

Song of Kings x3
Celebrian's Stone x1
Steward of Gondor x2
Sword that was Broken x2
Ancient Mathom x2
Miruvor x3
Light of Valinor x3
Ring of Barahir x2
Unexpected Courage x1
Fast Hitch x1
A Burning Brand x2
Asfaloth x2
Self Preservation x2

Elrond's Counsel x3
A Test of Will x2
Word of Command x2
Lore of Imladris x1";
        }
    }
}