using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class TheGreyCompanyDefendsGondor : Deck
    {
        public TheGreyCompanyDefendsGondor()
            : base("The Grey Company Defends Gondor", "http://hallofbeorn.wordpress.com/2013/06/20/deck-the-grey-company-defends-gondor/")
        {
            DeckList =
@"Elrohir
Elladan
Glorfindel (FoS)

Errand-Rider x3
Snowbourn Scout x3
Knights of the Swan x3
Vassal of the Windlord x2
Silvan Refugee x3
Arwen Undomiel (TWitW) x2
Erestor x2
Faramir (Core) x3
Gandalf (Core) x3

Light of Valinor x3
Steward of Gondor x3
Horn of Gondor x2
Gondorian Shield x3
Rivendell Blade x3

Elrond's Counsel x3
A Test of Will x3
Sneak Attack x3
Valiant Sacrifice x3";
        }
    }
}