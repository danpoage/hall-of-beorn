using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class BattleOfPelennorAndTheWorldsEnding : Deck
    {
        public BattleOfPelennorAndTheWorldsEnding()
            : base("Battle of the Pelennor Fields: And The World's Ending", "http://hallofbeorn.wordpress.com/2013/01/09/decks-battle-of-the-pelennor-fields/")
        {
            DeckList =
@"Denethor (Core)
Beregond (HoN)
Gimli (Core)

Envoy of Pelargir x3
Defender of Rammas x3
Gondorian Spearman x3
Horseback Archer x3
Warden of Healing x3
Ithilien Tracker x3
Gleowine (Core) x3
Gandalf (Core) x3

Horn of Gondor x2
Citadel Plate x2
Spear of the Citadel x3
Blade of Gondolin x1
A Burning Brand x1
Dark Knowledge x1
Song of Battle x1

Feint x3
Behind Strong Walls x3
Foe-Hammer x3
Quick Strike x2
Swift Strike x2
Thicket of Spears x1
Peace, and Thought x1";
        }
    }
}