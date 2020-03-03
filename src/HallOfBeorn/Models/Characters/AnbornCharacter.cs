using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class AnbornCharacter : Character
    {
        public AnbornCharacter()
            : base("Anborn", "Anborn", "Man")
        {
            Bio =
@"<p><b>Anborn</b> was a Ranger of Ithilien.</p>
<h4>History</h4>
<p>He was one of the Rangers in the company under Faramir who were on a mission to ambush the Men of Harad in Ithilien. He had been left behind as a scout near the road. Just before he returned to Henneth Annûn he saw Gollum lurking among the trees, yet he mistook him for a wild beast. He did not shoot him because Faramir had commanded his men not to slay wild beasts for no purpose.</p>
<p>Later, Anborn answered Faramir's question as to what was in the forbidden pool below Henneth Annûn, saying that the creature was not a bird since it had four limbs and dove manwise. He offered to shoot it with his bow, at Faramir's command. Faramir stayed his hand and when Gollum was captured had Anborn guard the creature.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Anborn";
            ImageArtist = Artist.Owen_William_Weber;

            addFriend("Faramir", "Faramir");
            addFriend("Mablung", "Mablung");
            addFriend("Damrod", "Damrod");
            
            addGroup("Gondor", "Gondor");
            addGroup("Rangers of Ithilien", "Rangers-of-Ithilien");
        }
    }
}