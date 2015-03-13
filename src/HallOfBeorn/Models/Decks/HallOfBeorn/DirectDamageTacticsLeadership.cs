using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class DirectDamageTacticsLeadership : Deck
    {
        public DirectDamageTacticsLeadership()
            : base("Direct Damage: Tactics/Leadership", "http://hallofbeorn.wordpress.com/2013/01/16/decks-direct-damage/")
        {
            DeckList =
@"Thalin
Legolas
Gloin (Core)

Vassal of the Windlord x3
Gondorian Spearman x3
Veteran Axehand x3
Bofur (THOHaUH) x3
Erebor Battle Master x3
Descendant of Thorondor x2
Gandalf (Core) x3

Blade of Gondolin x2
Dwarrowdelf Axe x2
Horn of Gondor x2
Spear of the Citadel x3

Foe-Hammer x3
Goblin-Cleaver x2
Feint x3
Hail of Stones x2
Hands Upon the Bow x3
Swift Strike x2
Sneak Attack x3
Fresh Tracks x3";
        }
    }
}