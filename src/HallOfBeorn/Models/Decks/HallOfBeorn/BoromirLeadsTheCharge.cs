using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class BoromirLeadsTheCharge : Deck
    {
        public BoromirLeadsTheCharge()
            : base("Boromir Leads the Charge!", "http://hallofbeorn.wordpress.com/2013/12/05/deck-boromir-leads-the-charge/")
        {
            DeckList =
@"Boromir (HoN)
Balin
Sam Gamgee

Errand-rider x3
Squire of the Citadel x3
Envoy of Pelargir x3
Pelargir Ship Captain x3
Guard of the Citadel x2
White Tower Watchman x2
Faramir x3
Citadel Custodian x2
Gandalf x3

Steward of Gondor x3
Visionary Leadership x3
King Under the Mountain x3
Dúnedain Warning x2

A Very Good Tale x3
Wealth of Gondor x3
Gaining Strength x2
We Are Not Idle x2
Sneak Attack x3
Strength of Arms x2";
        }
    }
}