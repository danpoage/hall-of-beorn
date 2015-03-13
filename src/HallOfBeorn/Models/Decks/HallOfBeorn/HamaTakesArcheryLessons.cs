using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class HamaTakesArcheryLessons : Deck
    {
        public HamaTakesArcheryLessons()
            : base("Háma Takes Archery Lessons", "http://hallofbeorn.wordpress.com/2013/03/28/deck-hama-takes-archery-lessons/")
        {
            DeckList =
@"Háma
Theodred
Bifur

Snowbourn Scout x3
Vassal of the Windlord x3
Winged Guardian x3
Erebor Hammersmith x2
Gleowine x3
Master of the Forge x3
Descendant of Thorondor x2
Eagles of the Misty Mountains x3
Radagast x2

Cram x3
Dunedain Cache x3
Steward of Gondor x3
Ranger Spikes x3
Support of the Eagles x3

The Eagles Are Coming! x3
Feint x3
Hail of Stones x2
Hands Upon the Bow x3";
        }
    }
}