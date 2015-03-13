using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class VilyaTheRingOfAir : Deck
    {
        public VilyaTheRingOfAir()
            : base("Vilya, The Ring of Air", "http://hallofbeorn.wordpress.com/2013/01/19/deck-vilya-the-ring-of-air/")
        {
            DeckList =
@"Elrond
Beravor
Glorfindel (FoS)

Master of the Forge x3
Imladris Stargazer x3
Gleowine x3
Henemarth Riversong x1
Arwen Undomiel x1
Trollshaw Scout x1
Watcher of the Bruinen x1
Mirkwood Runner x1
Silvan Tracker x1
Daughter of the Nimrodel x1
Rivendell Minstrel x1
Silverlode Archer x1
Lorien Guide x1
Haldir of Lorien x1
Erestor x1
Gildor Inglorion x2
Gandalf (Core) x3

Vilya x3
Light of Valinor x3
Unexpected Courage x2
Asfaloth x1
A Burning Brand x1
Self Preservation x1
Protector Lorien x1
Resourceful x2

Daeron's Runes x3
Elrond's Counsel x2
The Galadhrim's Greeting x1
A Test of Will x2
Word of Command x2";
        }
    }
}