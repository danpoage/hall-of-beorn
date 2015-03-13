using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class RangersAndTraps : Deck
    {
        public RangersAndTraps()
            : base("Rangers and Traps", "http://hallofbeorn.wordpress.com/2013/09/18/deck-rangers-and-traps/")
        {
            DeckList =
@"Beravor
Sam Gamgee
Denethor

Envoy of Pelargir x3
Warden of Healing x3
Ithilien Tracker x3
Ithilien Archer x2
Anborn x2
Faramir x2
Citadel Custodian x2
Gandalf (Core) x3

Cram x2
Steward of Gondor x3
Elf-Stone x2
Fast Hitch x2
Protector of Lorien x2
Ranger Bow x3
Ranger Spikes x3
Poisoned Stakes x2

Daeron’s Runes x3
Peace and Thought x3
Sneak Attack x3
Fresh Tracks x2";
        }
    }
}