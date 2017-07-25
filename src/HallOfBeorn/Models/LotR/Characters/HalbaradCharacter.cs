using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class HalbaradCharacter : Character
    {
        public HalbaradCharacter()
            : base("Halbarad", "Halbarad", "Man")
        {
            Bio =
@"<p>Halbarad was a Ranger of Eriador.</p>
<p>Halbarad spent his early life watching the borders of the Shire.</p>
<p>During the War of the Ring, Halbarad was sent to the aid of his Chieftain Aragorn. From Eriador, he led a thirty-man strong group of Rangers, calling themselves the Grey Company. With them rode Elladan and Elrohir, the sons of Elrond. In the night between the 5th and the 6th of March, the Company met Aragorn at Dol Baran. Halbarad gave his kinsman a standard, which was a gift from Arwen, and a message, summoning him to take the Paths of the Dead.</p>
<p>The Grey Company, now with Gimli and Legolas part of Aragorn's comitatus, passed through the Paths of the Dead, to the Stone of Erech, over Tarlang's Neck, and on to Pelargir. He captained a Corsair ship and they sailed toward Harlond.</p>
<p>On March 15 they arrived on the Pelennor Fields and fought in the battle. Halbarad unfurled the standard, and it showed the White Tree of Gondor and the signs of Elendil. He was killed in this battle, and would never return to the North.</p>
<p>Though it is nowhere translated, Halbarad most likely means 'Tall Tower', from Sindarin hall, 'tall', and barad, 'tower'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Halbarad";
            ImageArtist = Artist.Smirtouille;

            addFriend("Aragorn", "Aragorn");

            addGroup("The Grey Company");

            Card("Halbarad-TLR");
            Card("Halbarad-TFotW");
        }
    }
}