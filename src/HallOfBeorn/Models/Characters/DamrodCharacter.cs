using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class DamrodCharacter : Character
    {
        public DamrodCharacter()
            : base("Damrod", "Damrod", "Man")
        {
            Bio =
@"<p>Damrod was a Ranger of Ithilien.</p>
<h4>History</h4>
<p>Damrod was the companion of Mablung and a trusted guard of Faramir. Together he and Mablung watched Frodo and Sam during the ambush of the Men of Harad in Ithilien. While they waited before the battle Damrod told the hobbits of the Enemy's dealings with the Southrons. Damrod had little hope; he believed 'the days of Gondor are numbered, and the walls of Minas Tirith are doomed'.</p>
<p>After the ambush Damrod and Mablung continued to serve as watch-guards over the hobbits as the Rangers journeyed to Henneth Annûn.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Damrod";
            ImageArtist = Artist.Joshua_Cairos;

            addFriend("Faramir", "Faramir");
            addFriend("Mablung", "Mablung");
            addFriend("Anborn", "Anborn");

            addGroup("Rangers of Ithilien", "Rangers-of-Ithilien");
        }
    }
}