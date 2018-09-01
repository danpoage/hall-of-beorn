using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class MablungCharacter : Character
    {
        public MablungCharacter()
            : base("Mablung", "Mablung", "Man")
        {
            Bio =
@"<p>Mablung was Ranger of Ithilien during the War of the Ring.</p>
<p>Mablung's family had lived in Ithilien before it was overrun by the forces of Sauron. As such, he was given a place among the Rangers of Ithilien, Denethor's most trusted forayers.</p>
<p>Together with Damrod, Anborn and several others, Mablung served under the Steward's second son, Faramir. They were sent to intercept a troop of Southrons in March T.A. 3019, and there, they came across Frodo Baggins and Samwise Gamgee. While standing guard over Faramir's guest with Damrod, he briefly conversed with them. Faramir, in the meantime, went on to ambush the Haradrim.</p>
<p>Mablung and Damrod remained the guards of the Ring-bearer during their short stay at Henneth Annûn.</p>
<p>With his Lord injured, Mablung was given command of the Rangers after the Battle of the Pelennor Fields. When the Army of the West marched on the Morannon, Mablung and his troops scouted the road and discovered an ambush by Orcs and Easterlings that lay hid in Ithilien. The ambush was quickly turned.</p>
<p>Mablung was named after Mablung of the Heavy Hand, a great Hunter of Doriath. The name is from Doriathrin mab 'hand', lung 'heavy'. His epithet was a translation of his name.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Mablung_(ranger_of_Ithilien)";
            ImageArtist = Artist.Sebastian_Giacobino;

            addFriend("Faramir", "Faramir");
            addFriend("Damrod", "Damrod");
            addFriend("Anborn", "Anborn");

            addGroup("Gondor", "Gondor");
            addGroup("Rangers of Ithilien", "Rangers-of-Ithilien");

            Card("Mablung-NiE");
            Card("Mablung-TLoS");
            Card("Mablung-TPLES");
        }
    }
}