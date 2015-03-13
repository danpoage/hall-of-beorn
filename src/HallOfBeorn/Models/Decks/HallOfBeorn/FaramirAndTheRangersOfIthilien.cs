using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class FaramirAndTheRangersOfIthilien
        : Deck
    {
        public FaramirAndTheRangersOfIthilien()
            : base("Faramir and the Rangers of Ithilien", "http://hallofbeorn.wordpress.com/2013/12/16/deck-faramir-and-the-rangers-of-ithilien/")
        {
            DeckList =
@"Faramir (AoO)
Mirlonde
Pippin (TBR)

Envoy of Pelargir x3
Warden of Healing x3
Ithilien Tracker x3
Ithilien Archer x3
Gleowine x2
Master of the Forge x2
Anborn x2
Rivendell Minstrel x3
Gandalf (Core) x2

Song of Battle x2
Elf-Stone x3
Ranger Bow x3
Asfaloth x2
Ranger Spikes x2
Protector of Lorien x2
Great Yew Bow x2
Scroll of Isildur x2

Mithrandir's Advice x3
Take No Notice x2
Radagast's Cunning x2
Secret Paths x2";
        }
    }
}