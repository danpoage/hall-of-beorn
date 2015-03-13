using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class LoreMastery : Deck
    {
        public LoreMastery()
            : base("Lore Mastery", "http://hallofbeorn.wordpress.com/2013/01/31/deck-lore-mastery/")
        {
            DeckList =
@"Glorfindel (FoS)
Denethor (Core)
Bifur (KD)

Henamarth Riversong x2
Erebor Hammersmith x2
Miner of the Iron Hills x2
Gleowine x3
Master of the Forge x3
Warden of Healing x3
Ithilien Tracker x2
Master of Lore x3
Haldir of Lorien x2
Gildor Inglorion x2

Spare Hood and Cloak x3
Light of Valinor x3
Thror's Map x2
Asfaloth x2
A Burning Brand x2
Ranger Spikes x3
Forest Snare x2

Expecting Mischief x2
Needful to Know x2
Out of the Wild x3
Lorien's Wealth x2";
        }
    }
}