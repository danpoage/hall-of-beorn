using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class WardensOfImladris : Deck
    {
        public WardensOfImladris()
            : base("Wardens of Imladris", "http://hallofbeorn.wordpress.com/2013/01/09/key-concepts-support/")
        {
            DeckList =
@"Aragorn (TWitW)
Beravor (Core)
Frodo Baggins (CatC)

Gleowine (Core) x3
Warden of Healing x3
Erebor Hammersmith x2
Henamarth Riversong x1
Imladris Stargazer x2
Master of the Forge x2
Master of Lore x3
Ithilien Tracker x1
Mirkwood Runner x1
Northern Tracker x1
Haldir of Lorien x1
Gildor Inglorion x2

Asfaloth x2
Miruvor x2
Protector of Lorien x2
A Burning Brand x2
Unexpected Courage x1
Ranger Spikes x2
Forest Snare x1
Fast Hitch x1
Song of Travel x1

Daeron's Runes x3
A Test of Will x3
The Galadhrim's Greeting x2
Radagast's Cunning x2
Secret Paths x2
Gildor's Council x2";
        }
    }
}