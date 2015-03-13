using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class MagaliTribute : Deck
    {
        public MagaliTribute()
            : base("Magali Tribute", "http://hallofbeorn.wordpress.com/2013/06/13/deck-magali-tribute/")
        {
            DeckList =
@"Elrond
Eleanor
Glorfindel (FoS)

Envoy of Pelargir x3
Imladris Stargazer x3
Zigil Miner x3
Westfold Horse-Breaker x3
Arwen Undomiel x2
Daughter of the Nimrodel x3
Silvan Tracker x2
Haldir of Lorien x1
Damrod x1
Elfhelm x1
Gildor Inglorion x1
Gandalf (THOHaUH) x3

Expert Treasure-Hunter x3
Protector of Lorien x3
Blood of Númenor x2
The Favor of the Lady x2
Song of Wisdom x3
Resourceful x2

Word of Command x2
The Galadhrim’s Greeting x3
Gildor's Counsel x2
Lorien's Wealth x2";
        }
    }
}