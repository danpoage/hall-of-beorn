using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class BeornsPathEFDGTacticsSpirit : Deck
    {
        public BeornsPathEFDGTacticsSpirit()
            : base("Beorn's Path: Escape From Dol Guldur - Tactics/Spirit", "http://hallofbeorn.wordpress.com/2013/02/06/beorns-path-part-5-building-a-second-core-set-deck/")
        {
            DeckList =
@"Gimli (Core)
Thalin (Core)
Eowyn (Core)

Gondorian Spearman x3
Veteran Axehand x3
Horseback Archer x2
Lorien Guide x1
Northern Tracker x2
Gandalf (Core) x1
Beorn (Core) x1

Horn of Gondor x1
Blade of Gondolin x2
Dwarven Axe x2
Citadel Plate x2
Favor of the Lady x2
Unexpected Courage x1

Feint x2
Quick Strike x2
Swift Strike x1
A Test of Will x2
Hasty Stroke x2
The Galadhrim's Greeting x2
Dwarven Tomb x1
A Light in the Dark x2
Stand and Fight x3";
        }
    }
}