using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class TheIslandOfMisfitHeroes : Deck
    {
        public TheIslandOfMisfitHeroes()
            : base("The Island of Misfit Heroes", "http://hallofbeorn.wordpress.com/2013/02/18/deck-the-island-of-misfit-heroes/")
        {
            DeckList =
@"Glorfindel (Core)
Brand son of Bain
Dwalin (KD)

Master of the Forge x3
Gleowine x3
Bofur (THOHaUH) x2
Imladris Stargazer x2
Arwen Undomiel x2
Warden of Healing x2
Rivendell Minstrel x2
Gandalf (Core) x2

Song of Travel x1
Song of Wisdom x1
Rivendell Blade x2
Blade of Gondolin x2
Dwarrowdelf Axe x2
Light of Valinor x3
Protector of Lorien x2
Asfaloth x2
A Burning Brand x2
Unexpected Courage x3
Ring Mail x2

Elrond's Counsel x2
Foe-Hammer x2
A Test of Will x2
Feint x2
Hands Upon the Bow x2";
        }
    }
}