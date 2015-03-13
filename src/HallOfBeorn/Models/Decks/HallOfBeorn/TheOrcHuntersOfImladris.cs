using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Decks.HallOfBeorn
{
    public class TheOrcHuntersOfImladris : Deck
    {
        public TheOrcHuntersOfImladris()
            : base("Orc Hunters of Imladris", "http://hallofbeorn.wordpress.com/2013/01/07/key-concepts-roles/")
        {
            DeckList =
@"Elladan
Elrohir
Glorfindel (FoS)

Errand-Rider x3
Trollshaw Scout x3
Watcher of the Bruinen x2
Silverlode Archer x2
Dunedain Watcher x2
Arwen Undomiel x3
Imladris Stargazer x3
Erestor x2
Gandalf (Core) x3

Steward of Gondor x2
Horn of Gondor x1
Dunedain Warning x3
Celebrian's Stone x1
Rivendell Blade x2
Unexpected Courage x1
Light of Valinor x3
Song of Battle x1
Song of Travel x1

Elrond's Counsel x3
A Test of Will x3
Hasty Stroke x2
Feint x2
Sneak Attack x2";
        }
    }
}