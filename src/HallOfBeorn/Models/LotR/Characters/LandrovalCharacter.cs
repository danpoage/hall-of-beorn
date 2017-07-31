using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class LandrovalCharacter : Character
    {
        public LandrovalCharacter()
            : base("Landroval", "Landroval", "Eagle")
        {
            Bio =
@"<p>Landroval was one of the Eagles.</p>
<h4>History</h4>
<p>A descendant of Thorondor, it is said that Landroval was his vassal in the First Age and with his brother Gwaihir helped him rescue Beren and Lúthien from Angband.</p>
<p>During the War of the Ring he stayed out of the war for most of the conflict, but he followed his brother to the Battle of the Morannon, where he and his vassals helped turn the tide.</p>
<p>After the Ring was destroyed, Landroval, Gwaihir and Meneldor, flew into Mordor to retrieve Frodo and Sam from the ruins of Mount Doom.</p>
<h4>Etymology</h4>
<p>Landroval is a Sindarin name meaning 'broad winged', containing the element roval ('wing').</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Landroval";
            ImageArtist = Artist.Allison_Theus;

            addFamily("Gwaihir (Brother)", "Gwaihir");

            addGroup("Eagles of the Eyrie");

            Card("Landroval-AJtR");
        }
    }
}