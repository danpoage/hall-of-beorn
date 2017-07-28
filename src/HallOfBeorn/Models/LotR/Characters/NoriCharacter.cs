using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class NoriCharacter : Character
    {
        public NoriCharacter()
            : base("Nori", "Nori", "Dwarf")
        {
            Bio =
@"<p>Nori was one of Durin's Folk and likely dwelt in the northern Blue Mountains with Thorin after the latter had settled there. He was one of the thirteen Dwarves of Thorin's company who journeyed to Erebor to challenge the dragon Smaug. After the death of Smaug, Nori lived with his share of the treasure at the Lonely Mountain.</p>
<h4>Family and Birth</h4>
<p>Nori's parentage is unknown although he was a remote kinsman of Thorin and a member of the House of Durin. His birth year is also unknown. However, from Bilbo Baggins' account of the quest to Erebor it is known that the brothers Fíli and Kíli were the youngest of the thirteen 'by some fifty years' and that after Thorin had been captured, Balin was 'the eldest left'. Since Fíli was born in T.A. 2859 and Balin was born in 2763,[1] this would put Nori's birth between 2809 and 2763, and he would have been between 132 and 178 years old during the quest to Erebor. Nori (and Dori) shared Bilbo's opinion that meals should be plentiful and frequent.</p>
<h4>The Quest of Erebor</h4>
<p>Nori was one of the five Dwarves in the fourth group to arrive at Bag End. He wore a purple hood. During the evening when Thorin called for music, Nori (along with Dori and Ori) played the flute.</p>
<p>When Gandalf was telling the story of the company's adventures to Beorn, Nori and Ori were the second two Dwarves to show up.</p>
<p>Nori fought in and survived the Battle of Five Armies. He was given his share of the treasure by Dáin Ironfoot, and made his home in Erebor.</p>
<h4>Later Life</h4>
<p>Nori lived a wealthy life after the quest as one of the reclaimers of the mountain. He was still alive during the War of the Ring, and may have fought in the Battle of Dale. His date of death is unknown.</p>
<h4>Etymology</h4>
<p>Nóri is a dwarf from the Dvergatal. It most likely means 'Little shaver, small bit of something'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Nori";
            ImageArtist = Artist.None;

            addFriend("Dori", "Dori");

            addGroup("Thorin's Company", "Thorin's Company");

            Card("Nori-THOHaUH");
        }
    }
}