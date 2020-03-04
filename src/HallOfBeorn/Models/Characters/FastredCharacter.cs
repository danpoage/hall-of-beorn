using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class FastredCharacter : Character
    {
        public FastredCharacter()
            : base("Fastred", "Fastred", "Man")
        {
            Bio =
@"<p>Fastred was a man of Rohan during the War of the Ring.</p>
<p>Fastred rode with his king Théoden to the Battle of the Pelennor Fields, where he was killed. His name was remembered in the Song of the Mounds of Mundburg.</p>
<p>Fastred in Old English means 'fast-rede, firm-counsel'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Fastred_(rider_of_Rohan)";
            ImageArtist = Artist.David_Horne;

            addFriend("Théoden", "Theoden");
            addFriend("Herefara");
            addFriend("Herubrand");
            addFriend("Horn");

            addGroup("The Rohirrim", "The-Rohirrim");
        }
    }
}
