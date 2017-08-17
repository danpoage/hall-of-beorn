using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class RangersOfIthilienGroup : CharacterGroup
    {
        public RangersOfIthilienGroup()
            : base("Rangers of Ithilien", "Rangers of Ithilien")
        {
            Bio =
@"<p>The <b>Rangers of Ithilien</b> were a specialized force of soldiers of Gondor, selected from the descendants of the people who had dwelt in Ithilien before it fell from Gondor's control. Dressed in camouflaging green and brown, they crossed the Anduin in secret to harass the forces of the Enemy in Gondor's old domain and used several secret retreats in the region.</p>
<h4>History</h4>
<p>It is likely that the Rangers of Ithilien were established at the same time that Henneth Annûn was built, in T.A. 2901 when most of the remaining inhabitants of the region departed due to Uruk attacks from Mordor.[2] The Rangers' main task was to harry Sauron's forces whenever they entered Ithilien.</p>
<p>At the time of the War of the Ring the leader of these Rangers was Faramir, son of the Ruling Steward Denethor.[3] Other Rangers at that time were Damrod, Mablung,[1] and Anborn.</p>
<p>On 7 March 3019, Frodo and Sam witnessed a harassing attack by the Rangers of Ithilien upon a regiment of Southrons marching north. The two hobbits were captured by Faramir and other Rangers and brought to Henneth Annûn.[4] Faramir learned of the One Ring carried by Frodo[3] and captured Gollum, but on 8 March he let the three go to seek entry into Mordor.</p>
<p>Faramir and the Rangers of Ithilien left Henneth Annûn on 9 March.[4] The Rangers fought in the Battle of the Pelennor Fields. When the Army of the West marched through Ithilien on its way to the Morannon, a powerful force of Orcs and Easterlings tried to ambush its leading companies, but the Rangers of Ithilien, led by Mablung (since Faramir was recovering in the Houses of Healing) trapped the ambushers and destroyed them.</p>
<p>After the defeat of Sauron it may be that the Rangers of Ithilien became the White Company, the guard of Faramir, who became the Prince of Ithilien at the command of King Elessar.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Rangers_of_Ithilien";
            ImageArtist = Artist.David_A_Nash;

            addLeader("Faramir", "Faramir");

            addMember("Mablung", "Mablung");
            addMember("Damrod", "Damrod");
            addMember("Anborn", "Anborn");

            Card("Ranger-of-Ithilien-TMaO");
            Card("Ithilien-Tracker-HoN");
            Card("Ithilien-Guardian-HoN");
            Card("Ithilien-Archer-EaAD");
            Card("Ithilien-Lookout-TDT");
            Card("Guardian-of-Ithilien-TCoC");
            Card("Ranger-Bow-AoO");
            Card("Ranger-Spear-TCoC");
            Card("Forest-Snare-Core");
            Card("Ranger-Spikes-HoN");
            Card("Ithilien-Pit-EaAD");
            Card("Poisoned-Stakes-TBoG");
            Card("Entangling-Nets-TotD");
            Card("Followed-CoP");
            Card("Ambush-TLoS");
            Card("Advance-Warning-TDF");
            Card("Forest-Patrol-AoO");
            Card("Arrows-from-the-Trees-TotD");
            Card("Coney-in-a-Trap-TMk");
            Card("In-the-Shadows-TLoS");
        }
    }
}