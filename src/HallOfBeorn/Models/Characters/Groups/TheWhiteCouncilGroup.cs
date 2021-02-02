using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters.Groups
{
    public class TheWhiteCouncilGroup : CharacterGroup
    {
        public TheWhiteCouncilGroup()
            : base("The White Council", "The Second White Council")
        {
            Bio =
@"<p><b>The White Council</b>, also referred to as the <b>Council of the Wise</b>, was a group of the wise in Middle-earth which met irregularly. Its purpose was 'to unite and direct the forces of the West, in resistance to the shadow.'</p>
<h3>Members</h3>
<p>
The following individuals were clearly stated to have been members of the White Council. It should be noted, however, that 'other lords of the Eldar' did join them.</p>
<ul>
<li>Saruman, the appointed leader of the Council</li>
<li>Gandalf</li>
<li>Galadriel</li>
<li>Elrond</li>
<li>Círdan</li>
</ul>
<h3>History</h3>
<h4>The Second Age</h4>
<p>A 'White Council' first met in c. S.A. 1701.[note 1] At this meeting it was decided that Imladris should become the stronghold of the Elves in Eriador, rather than Eregion. No members are mentioned explicitly, but it is implied that at least Gil-galad and Elrond were members because Gil-galad gave Vilya to Elrond 'At that time also'.[5] It seems likely that the 'White Council' of the Third Age echoed this 'White Council' of the Second Age.</p>
<h4>The Third Age</h4>
<p>In T.A. 2063[3] Gandalf entered Dol Guldur and drove Sauron away, beginning the Watchful Peace; although this was before the formation of the Council, the feat was attributed to them.</p>
<p>In T.A. 2463,[3] following the return of Sauron and the end of the Watchful Peace in 2460,[3] Galadriel summoned the first meeting of the White Council.</p>
<p>There are only four known meetings of the White Council:</p>
<ol>
<li>T.A. 2463</li>
<li>T.A. 2851</li>
<li>T.A. 2941</li>
<li>T.A. 2953</li>
</ol>
<p>At the first meeting in T.A. 2463,[3] it was mooted that Gandalf be the head of the Council, but to Galadriel's dismay he refused the office. Saruman was chosen as their chief instead and he begrudged Gandalf for being the desired candidate.</p>
<p>At the second meeting in T.A. 2851,[3] the Council met at Rivendell.[8] Gandalf urged an attack on Dol Guldur following his discovery in the previous year that its master was indeed Sauron. Saruman overruled him because in secret he had begun to desire the One Ring for himself.[3] Unusually for a White Council meeting, Gandalf sat apart from the others, in silence and smoking, whilst Saruman spoke against the attack on Dol Guldur. This irritated Saruman and he spoke to Gandalf afterwards, asking him why he did not join in the discussion, and mocked his smoking. Gandalf replied, saying that pipe-weed, a practice of the Halflings, gave him 'patience'. Saruman mocked him again and in response Gandalf sent out many rings of smoke into the air and grasped them in his hand before they vanished. Saruman read this gesture as suggesting that Gandalf suspected him of wanting to possess the One Ring, or that there was a connection between the rings of power and the Halflings.</p>
<p>At the third meeting in T.A. 2941,[3] they agreed to attack Dol Guldur. Saruman finally submitted for he knew that Sauron was searching for the One Ring in the Anduin.[3] The White Council launched an attack on Dol Guldur, but Sauron, having already made plans, fled to Mordor.</p>
<p>At the fourth and final meeting in T.A. 2953, following Sauron's open declaration in 2951,[3] there was a discussion on the Rings of Power. Saruman claimed to have knowledge that the One Ring had been lost down the Anduin and into the sea[3] this quieting Gandalf's worries about Bilbo's Ring.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/White_Council";
            ImageArtist = Artist.Angus_McBride;

            addLeader("Saruman the White", "Saruman");

            addMember("Gandalf the Grey", "Gandalf");
            addMember("Galadriel", "Galadriel");
            addMember("Elrond", "Elrond");
            addMember("Radagast the Brown", "Radagast");
            addMember("Círdan the Shipwright", "Cirdan-the-Shipwright");

            LotRCard("Council-of-the-Wise-UtAM");
            LotRCard("The-White-Council-TDT");
        }
    }
}