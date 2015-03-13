using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class KeepItSecretKeepItSafe : Deck
    {
        public KeepItSecretKeepItSafe()
            : base("Keep It Secret, Keep It Safe", "http://hallofbeorn.wordpress.com/2013/09/28/deck-keep-it-secret-keep-it-safe/")
        {
            DeckList =
@"Sam Gamgee
Pippin (TBR)
Glorfindel (FoS)

Bill the Pony x1
Arwen Undomiel x1
Gleowine x1
Faramir x1
Erestor x1
Anborn x1
Haldir of Lorien x1
Gildor Inglorion x1
Northern Tracker x2
Warden of Healing x2
Master of the Forge x1
Miner of the Iron Hills x1
Erebor Hammersmith x2
Beorn (Core) x1
Gandalf (Core) x1
Gandalf (THOHaUH) x2

Resourceful x3
Elf-Stone x3
Light of Valinor x3
Steward of Gondor x2
Asfaloth x2

A Very Good Tale x3
Elrond's Counsel x3
Timely Aid x3
Peace, and Thought x3
A Test of Will x2
Dwarven Tomb x1
The Galadhrim’s Greeting x2";
        }
    }
}