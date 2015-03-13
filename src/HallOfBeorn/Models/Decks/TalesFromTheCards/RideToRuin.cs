using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.TalesFromTheCards
{
    public class RideToRuin :
        Deck
    {
        public RideToRuin()
            : base("Ride to Ruin", "http://talesfromthecards.wordpress.com/2013/12/10/deck-spotlight-ride-to-ruin/")
        {
            DeckList =
@"Theodred (Core) x1
Dunhere (Core) x1
Hama (TLD) x1

Eomund (CatC) x2
Errand-rider (HON) x3
Escort from Edoras (AJtR) x3
Gandalf (Core) x3
Bofur (OHaUH) x3
West Road Traveller (RtM) x3
Westfold Horse-Breaker (THfG) x3

Dunedain Mark (THfG) x3
Spear of the Mark (TMV) x3
Ancient Mathom (AJtR) x3
Steward of Gondor (Core) x3

A Light in the Dark (Core) x3
Forth Eorlingas! (TMV) x3
Fresh Tracks (TLD) x3
Quick Strike (Core) x3
The Galadhrim’s Greeting (Core) x3
Ride to Ruin (THoEM) x3";
        }
    }
}