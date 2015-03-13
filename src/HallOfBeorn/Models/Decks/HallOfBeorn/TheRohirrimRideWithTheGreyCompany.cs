using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class TheRohirrimRideWithTheGreyCompany : Deck
    {
        public TheRohirrimRideWithTheGreyCompany()
            : base("The Rohirrim Ride with the Grey Company", "http://hallofbeorn.wordpress.com/2013/02/08/deck-the-rohirrim-ride-with-the-grey-company/")
        {
            DeckList =
@"Hama
Theodred
Aragorn (TWitW)

Snowbourn Scout x3
Errand-Rider x2
Gleowine x3
Ithilien Tracker x2
Dunedain Watcher x3
Horseback Archer x3
Faramir x3
Gandalf (Core) x3

Rivendell Bow x2
Blade of Gondolin x3
Steward of Gondor x3
Celebrian's Stone x2
Ranger Spikes x3
Self Preservation x2
Sword that was Broken x3

Feint x3
Foe-Hammer x3
Hands Upon The Bow x2
Hail of Stones x2";
        }
    }
}