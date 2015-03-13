using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class BeornsPathTHFGTacticsSpirit : Deck
    {
        public BeornsPathTHFGTacticsSpirit()
            : base("Beorn's Path: The Hunt For Gollum - Tactics/Spirit", "http://hallofbeorn.wordpress.com/2013/02/26/beorns-path-part-7-deck-tuning-the-hunt-for-gollum/")
        {
            DeckList =
@"Gimli (Core)
Thalin (Core)
Eowyn (Core)

Gondorian Spearman x3
Winged Guardian x3
Horseback Archer x2
Lorien Guide x1
Northern Tracker x2
Gandalf (Core) x1
Beorn (Core) x1
Westfold Horse-Breaker x3

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