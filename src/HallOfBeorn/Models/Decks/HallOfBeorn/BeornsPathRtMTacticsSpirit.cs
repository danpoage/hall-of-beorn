using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class BeornsPathRtMTacticsSpirit : Deck
    {
        public BeornsPathRtMTacticsSpirit()
            : base("Beorn's Path: Return to Mirkwood - Tactics/Spirit", "http://hallofbeorn.wordpress.com/2013/09/22/beorns-path-part-13-return-to-mirkwood/")
        {
            DeckList =
@"Gimli (Core)
Thalin (Core)
Eowyn (Core)

Vassal of the Windlord x3
Winged Guardian x3
Gondorian Spearman x3
West Road Traveller x3
Escort from Edoras x3
Eagles of the Misty Mountains x2
Northern Tracker x2
Gandalf (Core) x3

Horn of Gondor x1
Ancient Mathom x3
Song of Travel x3
Unexpected Courage x1
Citadel Plate x2

The Eagles Are Coming! x3
Feint x2
Quick Strike x2
A Test of Will x2
Dwarven Tomb x1
Hasty Stroke x2
Swift Strike x1
The Galadhrim’s Greeting x2
Stand and Fight x3";
        }
    }
}