using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class OriCharacter : Character
    {
        public OriCharacter()
            : base("Ori", "Ori", "Dwarf")
        {
            Bio =
@"<p>Ori was one of the thirteen Dwarves of Thorin's company who journeyed to Erebor to challenge the dragon Smaug. After the death of Smaug, Ori lived at the Lonely Mountain until he went to Moria as part of Balin's ill-fated attempt to re-take the ancient mansions of the Dwarves.</p>
<h4>History</h4>
<p>Ori's parentage is unknown, although he was a remote kinsman of Thorin and a member of the House of Durin. His birth year is also unknown. However, in Bilbo Baggins' account of the quest to Erebor, it was said that the brothers Fíli and Kíli were the youngest of the thirteen 'by some fifty years' and that after Thorin had been captured, Balin was 'the eldest left'. Since Fíli was born in T.A. 2859 and Balin was born in 2763,[3] this would put Ori's birth between 2809 and 2763, and he would have been between 132 and 178 years old during the quest to Erebor. Ori was a member of the House of Durin and probably lived in the Blue Mountains with Thorin after he began living there following the loss of Thráin II.</p>
<h4>The Quest of Erebor</h4>
<p>In T.A. 2941, Ori was one of the five Dwarves in the fourth group to arrive at Bag End. He wore a grey hood. During the evening when Thorin called for music, Ori (along with Dori and Nori) played the flute.</p>
<p>When Gandalf was telling the story of the company's adventures to Beorn, Ori and Nori were the second pair of Dwarves to arrive.</p>
<p>Ori fought in and survived the Battle of Five Armies. He was given his share of the treasure by Dáin Ironfoot, and made his home in Erebor.</p>
<h4>Expedition to Moria</h4>
<p>In T.A. 2989 Ori (and Óin) had followed Balin with a colony of Dwarves in an attempt to reclaim their ancient mansions of Khazad-dûm, which were already occupied by the Goblins. At first the colony did well, but less than five years later Balin was killed, the Orcs returned and took the East-gate, and Óin's group that he took west to the West-gate was destroyed except for a few.</p>
<p>Ori retreated to the Chamber of Mazarbul where Balin's Tomb was laid. He wrote the last pages in the Book of Mazarbul before he and the last few remaining Dwarves perished during a final stand.</p>
<p>When Frodo Baggins came to Rivendell he met Glóin, who delighted in telling the hobbit about the doings of the renewed dwarf-kingdom in the Lonely Mountain. But when Frodo asked about Ori, Balin, and Óin (also members of Thorin and Company), Glóin's face darkened and he said that he did not know. In fact, their fate was largely why the Dwarves had come to Rivendell at that time, to seek advice.</p>
<h4>Legacy</h4>
<p>During the War of the Ring, the Fellowship of the Ring journeyed through Moria and discovered the book that contained the records of the expedition. The last lines were written by Ori, as recognized by Gimli due to Ori's recognizable large, bold handwriting using Tengwar (Gimli also said that Ori could write well and speedily).</p>
<h4>Etymology</h4>
<p>Óri is a dwarf from the Dvergatal. The name means 'Violent'.</p>
<h4>Other Versions of Tolkien's Legendarium</h4>
<p>Ori is said to be the cousin of Dori and Nori in Tolkien's 1966 notes, despite the popular belief that he is their brother. It is also confirmed that he wears a grey hood.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Ori";
            ImageArtist = Artist.Blake_Henriksen;

            addFriend("Thorin Oakenshield", "Thorin-Oakenshield");
            addFriend("Dori", "Dori");
            addFriend("Nori", "Nori");

            addGroup("Thorin's Company", "Thorin's-Company");

            Card("Ori-THOHaUH");
        }
    }
}