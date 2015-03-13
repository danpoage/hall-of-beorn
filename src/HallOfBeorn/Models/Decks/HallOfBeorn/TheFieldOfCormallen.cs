using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class TheFieldOfCormallen : Deck
    {
        public TheFieldOfCormallen()
            : base("The Field of Cormallen", "http://hallofbeorn.wordpress.com/2013/05/31/deck-the-field-of-cormallen/")
        {
            DeckList =
@"Beregond
Gimli
Legolas

Knights of the Swan x3
Vassal of the Windlord x3
Gondorian Spearman x3
Envoy of Pelargir x1
Winged Guardian x3
Bofur (OHaUH) x3
Horseback Archer x1
Eagles of the Misty Mountains x2
Landroval x1
Gandalf (Core) x3

Spear of the Citadel x3
Blade of Gondolin x2
Rivendell Blade x1
Gondorian Shield x2
Citadel Plate x2
Horn of Gondor x2
Support of the Eagles x2

Foe-Hammer x2
The Eagles are Coming! x3
Hail of Stones x2
Hands Upon the Bow x3
Trained for War x3";
        }
    }
}