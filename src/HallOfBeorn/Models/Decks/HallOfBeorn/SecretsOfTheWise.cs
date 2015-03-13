using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class SecretsOfTheWise : Deck
    {
        public SecretsOfTheWise()
            : base("Secrets of the Wise", "http://hallofbeorn.wordpress.com/2013/08/04/decks-gencon-2013/")
        {
            DeckList =
@"Denethor
Mirlonde
Glorfindel (FoS)

Silvan Refugee x2
Arwen Undomiel x2
Imladris Stargazer x3
Warden of Healing x3
Gleowine x1
Master of the Forge x2
Silvan Tracker x1
Northern Tracker x1
Haldir of Lorien x1
Gildor Inglorion x1
Gandalf (Core) x2
Gandalf (THOHaUH) x1

Expert Treasure-Hunter x3
Resourceful x3
Light of Valinor x3
Protector of Lorien x1
A Burning Brand x2
Asfaloth x2
Ranger Spikes x3
Unexpected Courage x1

Daeron's Runes x3
Elrond's Counsel x3
A Test of Will x3
Mithrandir's Advice x2
The Galadhrim's Greeting x1";
        }
    }
}