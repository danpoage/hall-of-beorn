using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class GhanBuriGhanCharacter : Character
    {
        public GhanBuriGhanCharacter()
            : base("Ghân-buri-Ghân", "Ghân-buri-Ghân", "Drúedain")
        {
            Bio =
@"<p>Ghân-buri-Ghân was the chief of the Drúedain who inhabited Drúadan Forest in the late Third Age.</p>
<h4>History</h4>
<p>He was the son of Ghân with whom he shared his name, and became the chief of his tribe.</p>
<p>During the War of the Ring, Ghân-buri-Ghân helped King Théoden and the Rohirrim to avoid an army of Orcs by taking them through the secret pass of Stonewain Valley. This allowed the Rohirrim to arrive in time to fight the Battle of the Pelennor Fields. In return, Théoden promised that the people of Rohan would no longer trouble the Drúedain and would drive away the Gorgûn (Orcs), that hunted them.</p>
<p>Following the War of the Ring, Aragorn, as High King of the Reunited Kingdom, issued the decree that Drúadan Forest belonged to only Ghân and his people, and that no one else was allowed to enter the forest without their permission.</p>
<h4>Etymology</h4>
<p>Ghân-buri-Ghân means 'Ghân son of Ghân' (Ghân + buri).</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Ghan-buri-Ghan";
            ImageArtist = Artist.Piya_Wannachaiwong;

            Alias("Chieftain of the Drúedain");

            addFriend("Théoden", "Theoden");
            addFriend("The Rohirrim", "The-Rohirrim");

            addGroup("Drúedain");

            Card("Ghan-buri-Ghan-TFotW");
        }
    }
}