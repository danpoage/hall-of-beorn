using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.TalesFromTheCards
{
    public class BlazeOfGlory : Deck
    {
        public BlazeOfGlory()
            : base("Blaze of Glory", "http://talesfromthecards.wordpress.com/2013/03/25/deck-spotlight-blaze-of-glory/")
        {
            DeckList =
@"Frodo Baggins (CatC) x1
Boromir (TDM) x1
Beorn (THOHaUH) x1

Beorning Beekeeper (CatC) x3
Descendant of Thorondor (THoEM) x3
Escort from Edoras (AJtR) x3
Gondorian Spearman (Core) x3
Defender of Rammas (HON) x3
Gandalf (Core) x3
West Road Traveller (RtM) x3

Good Meal (TRG) x3
Horn of Gondor (Core) x2
Ring Mail (TLD) x3
Unexpected Courage (Core) x2
Spear of the Citadel (HON) x3

Fortune or Fate (Core) x3
A Test of Will (Core) x3
Dwarven Tomb (Core) x2
Feint (Core) x3
Stand Together (Core) x3
Hasty Stroke (Core) x3";
        }
    }
}