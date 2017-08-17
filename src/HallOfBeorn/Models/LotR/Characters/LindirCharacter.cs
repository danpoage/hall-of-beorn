using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class LindirCharacter : Character
    {
        public LindirCharacter()
            : base("Lindir", "Lindir", "Noldor Elf")
        {
            Bio =
@"<p><b>Lindir</b> was an Elf of Rivendell.</p>
<h4>History</h4>
<p>After Bilbo Baggins's rendition of his Song of Eärendil, Lindir claimed that he was unable to tell which parts were written by Aragorn, and which by Bilbo himself, explaining that he knew little of Mortals and their ways.</p>
<h4>Etymology</h4>
<p>The name Lindir seems to be composed of lin ('tune') + ndir ('man'), therefore meaning 'song man'.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Lindir";
            ImageArtist = Artist.Tawny_Fritzinger;

            addFriend("Elrond", "Elrond");

            addGroup("Rivendell", "Rivendell");

            Card("Lindir-TBoCD");
        }
    }
}