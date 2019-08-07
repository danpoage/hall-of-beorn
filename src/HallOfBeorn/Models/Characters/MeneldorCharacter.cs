using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class MeneldorCharacter : Character
    {
        public MeneldorCharacter()
            : base("Meneldor", "Meneldor", "Eagle")
        {
            Bio =
@"<p><b>Meneldor</b> was a great Eagle of the northern mountains, one of the followers of Gwaihir the Windlord. He was among the squadron of Eagles who flew to the aid of the Captains of the West in the last desperate battle before the Gate of Mordor. With his lord Gwaihir, and Gwaihir's brother Landroval, he flew into the Black Land to the rescue of Frodo and Sam, and carried one of these two (we are not told which) out of the destruction of Mount Doom.</p>
<h3>Etymology</h3>
<p>The first element of his name menel is both a Sindarin and Quenya word meaning &ldquo;the heavens&rdquo;.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Meneldor";
            ImageArtist = Artist.Dmitry_Prosvirnin;

            addPlace("The Eyrie", "The-Eyrie");

            addGroup("The Eagles", "The-Eagles");

            addItem("Meneldor's Flight", "Meneldor's-Flight-THoEM");

            addFriend("Gwaihir", "Gwaihir");
            addFriend("Landroval", "Landroval");

            LotRCard("Meneldor-RAR");
        }
    }
}