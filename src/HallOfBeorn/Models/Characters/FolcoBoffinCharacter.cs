using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class FolcoBoffinCharacter : Character
    {
        public FolcoBoffinCharacter()
            : base("Folco Boffin", "Folco Boffin", "Hobbit")
        {
            Bio = 
@"<p>Folco Boffin (born S.R. 1378) was a Hobbit of the Shire.</p>
<h3>History</h3>
<p>Folco was the son of Vigo Boffin and probably one of the guests at Bilbo's Farewell Party.</p>
<p>He was a friend of Frodo Baggins, and assisted in his move to Buckland.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Folco_Boffin";
            ImageArtist = Artist.Quinton_Hoover;

            addFamily("Vigo Boffin (Father)");

            addFriend("Frodo Baggins", "Frodo-Baggins");
            addFriend("Pippin", "Pippin");
            addFriend("Merry", "Merry");

            addGroup("The Shire", "The-Shire");
            addGroup("The Conspiracy");
        }
    }
}
