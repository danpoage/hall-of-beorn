using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.TalesFromTheCards
{
    public class PalantirSupport : Deck
    {
        public PalantirSupport()
            : base("Palantir Support", "http://talesfromthecards.wordpress.com/2013/08/29/deck-spotlight-palantir-support/")
        {
            DeckList =
@"Eleanor
Eowyn
Glorfindel (FoS)

Imladris Stargazer x3
Zigil Miner x3
Minis Tirith Lampwright x3
Gandalf (Core) x3
Northern Tracker x3
Pelargir Shipwright x3
The Riddermark's Finest x3
Arwen Undomiel
Damrod
Elfhelm

Light of Valinor
Palantir
Map of Earnil
Unexpected Courage

A Light in the Dark
Elrond's Counsel
The Galadhrim's Greeting
A Test of Will
Stand and Fight
Dwarven Tomb
Will of the West";
        }
    }
}