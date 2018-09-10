using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters.Groups
{
    public class TheCouncilOfElrondGroup : CharacterGroup
    {
        public TheCouncilOfElrondGroup()
            : base("The Council of Elrond", "The Council of Elrond")
        {
            Bio =
@"<p>The Council of Elrond was a council called and led by Elrond, held on 25 October, T.A. 3018[1] in Rivendell. The main purpose of the council was to discuss what should be done with the One Ring, which was brought there by the Ring-bearer Frodo Baggins.</p>
<h4>Attendees</h4>
<p>The following people are known to have attended the Council:</p>
<ul>
<li>Elrond. As convener of the council and de facto ruler of Rivendell, Elrond headed the Council.</li>
<li>Gandalf, one of the Wizards, was one of the Wise.</li>
<li>Frodo Baggins, the Ring-bearer, came to Rivendell on the advice of Gandalf.</li>
<li>Bilbo Baggins, a former Ring-bearer, and the 'Ring-finder'.</li>
<li>Glorfindel, a Noldo of Rivendell who had aided Frodo earlier on his travel to Rivendell.</li>
<li>Erestor, and several unnamed advisers of Elrond's household.</li>
<li>Aragorn, a Ranger, Chieftain of the Dúnedain and Heir of Isildur, who had been Frodo's travel companion, guide and aide since Bree.</li>
<li>Boromir, son of the Steward of Gondor. His brother Faramir had a prophetic dream thrice, and he himself once. It spoke of 'the Sword that was broken, 'Imladris', 'Isildur's Bane' and a 'Halfling'. In order to find the meaning of the dream, Boromir went to 'Imladris' - Rivendell.</li>
<li>Glóin and his son Gimli were sent by Dáin II Ironfoot to warn Bilbo about a messenger from Mordor who appeared at the gate of Erebor, and asked for information of the One Ring. As king Brand of Dale was also encountered, Dáin decided to send messengers to Rivendell. They also came to seek news of what happened to Balin's Colony, which entered Moria thirty years before.</li>
<li>Legolas, was sent by his father Thranduil with ill news. Gollum, put in the custody of the Elves of Mirkwood by Aragorn, managed to escape after a surprise attack of Orcs.</li>
<li>Galdor of the Havens, a messenger of Círdan who just happened to be present at the time. His role in the Council was no larger than asking a couple of questions.</li>
</ul>
<h4>Procedure</h4>
<p>At the Council, Gandalf, Elrond and Bilbo told the history of the Ring to all. At hearing the potential of 'Isildur's Bane', Boromir opted to use the Ring to defend his native Gondor, and overthrow Sauron, its creator. Gandalf and Elrond were against it, and stated that the Ring was the essence of Sauron, and thus would corrupt and ultimately destroy whoever tried to use it. Eventually Gandalf felt it necessary to employ shock tactics by reciting the Ring Verse in Black Speech, angering Elrond in the process.</p>
<p>The fate of the Ring was considered. The Ring was indestructible as it could be unmade only where it was created, in the Crack of Doom in Mount Doom, and several solutions were proposed. It was suggested to give it to Tom Bombadil who could not be corrupted, or to send it to Valinor under the guardianship of the Valar and the High Elves. But it was deemed that the Ring could not be hidden or disposed, as it would remain dangerous for the generations to come.</p>
<p>Eventually it was decided that the only way to be free of Sauron and the Ring was to cast the Ring where it was made.</p>
<p>It then became necessary to decide who should take responsibility for such a perilous undertaking. Bilbo offered to finish the job he had started, but Gandalf told him he could not take back the Ring due to having possessing it for some time. Eventually Frodo surprised everyone including himself by telling them he would take the Ring. After some thought Elrond agreed. At this point Sam emerged from hiding and demanded to accompany Frodo, and since it was hardly possible to separate them Elrond agreed.</p>
<p>Who would further accompany the 'Company of the Ring' was the subject of some debate for the following two months, although it was clear that Gandalf, Aragorn, Boromir, Gimli and Legolas would join them. Elrond opted for two more; 'Nine walkers' would counter the 'Nine Riders'. He originally intended to send two of his household, such as Glorfindel, but Gandalf opted to include Merry and Pippin instead, as he deemed friendship and loyalty more important than strength</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Council_of_Elrond";
            ImageArtist = Artist.Angus_McBride;

            addLeader("Elrond", "Elrond");

            addMember("Gandalf", "Gandalf");
            addMember("Frodo Baggins", "Frodo-Baggins");
            addMember("Bilbo Baggins", "Bilbo-Baggins");
            addMember("Glorfindel", "Glorfindel");
            addMember("Erestor", "Erestor");
            addMember("Aragorn", "Aragorn");
            addMember("Boromir", "Boromir");
            addMember("Glóin", "Gloin");
            addMember("Gimli", "Gimli");
            addMember("Legolas", "Legolas");
            addMember("Galdor of the Havens", "Galdor-of-the-Havens");

            //Card("The-Council-of-Elrond-RD");
            LotRCard("Elrond's-Counsel-TWitW");
        }
    }
}