using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class Gluttony : Deck
    {
        public Gluttony()
            : base("Gluttony", "http://hallofbeorn.wordpress.com/2013/01/23/deck-gluttony/")
        {
            DeckList =
@"Gloin (Core)
Bombur (THOtD)
Frodo Baggins (CatC)

Erebor Record Keeper x3
Erebor Hammersmith x3
Master of the Forge x3
Wandering Took x2
Longbeard Elder x2
Fili (THOHaUH) x2
Kili (THOHaUH) x2
Gandalf (HUHaOH) x2
Brok Ironfist x1

Miruvor x3
Cram x3
Good Meal x2
Fast Hitch x1
A Burning Brand x2
Self Preservation x2
Narvi's Belt x2

We Are Not Idle x3
A Very Good Tale x3
Second Breakfast x2
Peace and Thought x2
O, Elbereth! Gilthonial! x2
The Galadhrim's Greeting x3";
        }
    }
}