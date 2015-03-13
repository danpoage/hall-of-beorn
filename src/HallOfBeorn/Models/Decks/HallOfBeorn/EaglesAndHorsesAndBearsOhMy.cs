using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class EaglesAndHorsesAndBearsOhMy : Deck
    {
        public EaglesAndHorsesAndBearsOhMy()
            : base("Eagles, and Horses, and Bears, Oh My!", "http://hallofbeorn.wordpress.com/2013/01/30/decks-dwarves-at-the-circus/")
        {
            DeckList =
@"Prince Imrahil
Beorn (THOHaUH)
Glorfindel (FoS)

Errand-Rider x3
Vassal of the Windlord x3
Winged Guardian x3
Watcher of the Bruinen x3
The Riddermark's Finest x3
Bofur (TRG) x1
Eagles of the Misty Mountains x2
Descendant of Thorondor x1
Landroval x1
Radagast x2
Gandalf (Core) x3

Horn of Gondor x2
Light of Valinor x3
Steward of Gondor x3
Song of Battle x3

Elrond's Counsel x3
Valiant Sacrifice x2
Sneak Attack x3
Feint x3
A Test of Will x3";
        }
    }
}