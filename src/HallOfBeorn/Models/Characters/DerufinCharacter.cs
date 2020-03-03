using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class DerufinCharacter : Character
    {
        public DerufinCharacter()
            : base("Derufin", "Derufin", "Man")
        {
            Bio =
@"<p><b>Derufin</b> was one of the two tall sons of Duinhir, lord of the Blackroot Vale at the time of the War of the Ring.</p>
<h3>History</h3>
<p>With five hundred archers of their people, Derufin and his brother Duilin travelled to the aid of Minas Tirith, far to the east of their own lands that lay under the shadow of the White Mountains.[1] There, the brothers fought together in the Battle of the Pelennor Fields, and both were lost in an assault on the mighty Mûmakil.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Derufin";
            ImageArtist = Artist.Greg_Bobrowski;

            addFamily("Duinhir (Father)");
            addFamily("Duilin (Brother)");
        }
    }
}