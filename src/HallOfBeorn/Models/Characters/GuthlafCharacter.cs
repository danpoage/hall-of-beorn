using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class GuthlafCharacter : Character
    {
        public GuthlafCharacter()
            : base("Guthláf", "Guthláf", "Man")
        {
            Bio =
@"<p>Guthláf was the banner-bearer of King Théoden of Rohan.</p>
<h4>History</h4>
<p>He rode to the relief of Minas Tirith with his Lord in the War of the Ring, and there fought in the Battle of the Pelennor Fields, where he was slain. He fell with the banner in his hand, and it had to be taken from him after death to be given to Éomer. He also earned himself a mention in the Song of the Mounds of Mundburg.</p>
<h4>Etymology</h4>
<p>In Old English Guþláf means 'survivor of the battle' (consisting of gūþ + lāf).</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Guthlaf";
            ImageArtist = Artist.Piotr_Arendzikowski;

            Alias("Banner-bearer");

            addFriend("Théoden", "Theoden");

            addGroup("The Rohirrim", "The-Rohirrim");
        }
    }
}
