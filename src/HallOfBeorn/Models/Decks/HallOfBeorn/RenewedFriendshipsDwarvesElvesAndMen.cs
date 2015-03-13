using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class RenewedFriendshipsDwarvesElvesAndMen : Deck
    {
        public RenewedFriendshipsDwarvesElvesAndMen()
            : base("Renewed Friendships: Dwarves, Elves and Men", "http://hallofbeorn.wordpress.com/2013/01/14/decks-renewed-friendships/")
        {
            DeckList =
@"Bifur (KD)
Glorfindel (FoS)
Theodred (Core)

Imladris Stargazer x2
Warden of Healing x3
Erebor Hammersmith x2
Master of the Forge x3
Gleowine x3
Mirkwood Runner x2
Haldir of Lorien x2
Gandalf (Core) x3

Vilya x3
Good Meal x1
Fast Hitch x1
Cram x3
Unexpected Courage x1
A Burning Brand x1
Protector of Lorien x2
Thror's Map x1
Steward of Gondor x2

Elrond's Counsel x3
Daeron's Runes x3
Renewed Friendship x3
A Test of Will x3
Dwarven Tomb x1
We Are Not Idle x2";
        }
    }
}