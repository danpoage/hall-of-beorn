using System;

namespace HallOfBeorn.Models.Characters
{
    public class HarryGoatleafCharacter
        : Character
    {
        public HarryGoatleafCharacter()
            : base("Harry Goatleaf", "Harry Goatleaf", "Man")
        {
            Bio =
@"<p><b>Harry Goatleaf</b> was a Man of Bree and a member of the Goatleaf Family. He worked as the keeper of the western gate in the great hedge that surrounded the township of Bree.</p>
<p>As such, he was the first of the Men encountered by Frodo and his companions on their travels during the War of the Ring - he greeted them gruffly on their arrival at the town. He was later present in the Prancing Pony doing suspicious actions, as it was later discovered he was under the power of the Nazgûl.</p>
<p>Some months after the hobbits' departure, Harry, together with Bill Ferny, joined with a band of brigands from the south, causing trouble that left five of the Bree-landers dead. After that, he left Bree with other ruffians, presumably to join Sharkey's Men in the Shire.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Harry_Goatleaf";
            ImageArtist = Artist.Dmitry_Prosvirnin;

            addGroup("Bree");

            LotRCard("Harry-Goatleaf-TGoR");
        }
    }
}