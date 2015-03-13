using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.TalesFromTheCards
{
    public class SpearmanSuperhero
        : Deck
    {
        public SpearmanSuperhero()
            : base("Spearman Superhero", "http://talesfromthecards.wordpress.com/2013/11/13/deck-spotlight-spearman-superhero/")
        {
            DeckList =
@"Elrond (SaF) x1
Thalin (Core) x1
Hirluin the Fair (TSF) x1

Anfalas Herdsman (TSF) x3
Gondorian Spearman (Core) x3
Ethir Swordsman (TSF) x3
Hunter of Lamedon (HON) x3
Knights of the Swan (TSF) x3
Warden of Healing (TLD) x3
Warrior of Lossarnach (TSF) x3

Steward of Gondor (Core) x3
King Under the Mountain (OtD) x3
Spear of the Citadel (HON) x3
Sword of Morthond (AoO) x3
Cram (OHaUH) x3

Behind Strong Walls (HON) x3
Men of the West (AoO) x3
Ever Vigilant (Core) x2
Goblin-cleaver (OHaUH) x3
Peace, and Thought (SaF) x3";
        }
    }
}