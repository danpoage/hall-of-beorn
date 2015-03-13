using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class PrisonerOfTheDarkForest : Deck
    {
        public PrisonerOfTheDarkForest()
            : base("Prisoner of the Dark Forest", "http://hallofbeorn.wordpress.com/2013/07/03/deck-prisoner-of-the-dark-forest/")
        {
            DeckList =
@"Aragorn (TWitW)
Glorfindel (Core)
Mirlonde

Master of the Forge x3
Rivendell Minstrel x3
Gildor Inglorion x3
Gandalf (THOHaUH) x3

Song of Battle x2
Song of Kings x3
Song of Travel x2
Expert Treasure-Hunter x3
Protector of Lorien x2
A Burning Brand x2
Asfaloth x2
Ranger Spikes x2
Rivendell Blade x2
Celebrian's Stone x2
Steward of Gondor x3
Sword that was Broken x2
Light of Valinor x2
Ring of Barahir x1

Daeron's Runes x3
Mithrandir's Advice x3
Word of Command x2";
        }
    }
}