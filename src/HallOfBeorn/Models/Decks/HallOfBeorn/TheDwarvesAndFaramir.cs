using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class TheDwarvesAndFaramir : Deck
    {
        public TheDwarvesAndFaramir()
            : base("The Dwarves and Faramir", "http://hallofbeorn.wordpress.com/2013/01/30/decks-dwarves-at-the-circus/")
        {
            DeckList =
@"Dain Ironfoot
Gloin (Core)
Bifur (KD)

Erebor Record Keeper x3
Erebor Hammersmith x3
Miner of the Iron Hills x2
Longbeard Elder x2
Longbeard Map-Maker x3
Erebor Battle Master x3
Gleowine x2
Dori x2
Faramir (Core) x2
Gandalf (Core) x3

Healing Herbs x2
Cram x2
Legacy of Durin x2
Narvi's Belt x2
Song of Battle x1
Hardy Leadership x1
Ranger Spikes x2
Forest Snare x1
Self Preservation x2

We Are Not Idle x3
Daeron's Runes x3
Sneak Attack x2
Lure of Moria x2";
        }
    }
}