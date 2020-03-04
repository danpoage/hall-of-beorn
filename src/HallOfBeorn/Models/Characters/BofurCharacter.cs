using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class BofurCharacter : Character
    {
        public BofurCharacter()
            : base("Bofur", "Bofur", "Dwarf")
        {
            Bio =
@"<p>Bofur most likely lived in the Blue Mountains with Thorin after the loss of Thráin II.[2] Bofur was one of the thirteen Dwarves of Thorin's company who journeyed to Erebor to challenge the dragon Smaug. After the death of Smaug, Bofur lived at the Lonely Mountain.</p>
<h4>History</h4>
<p>Bofur's parentage is unknown; the only familial connections mentioned are that Bombur is his brother and Bifur is his cousin.[4] He was not of Durin's line although he was descended from Dwarves of Moria.[2] His birth year is also unknown. However, from Bilbo Baggins' account of the quest to Erebor it is known that the brothers Fíli and Kíli were the youngest of the thirteen 'by some fifty years'[5] and that after Thorin had been captured, Balin was 'the eldest left'.[6] Since Fíli was born in T.A. 2859 and Balin was born in 2763,[2] this would put Bofur's birth between 2809 and 2763, and he would have been between 132 and 178 years old during the quest to Erebor.</p>
<h4>The Quest of Erebor</h4>
<p>In T.A. 2941, Bofur was one of the four Dwarves in the fifth group to arrive at Bag End, wearing a yellow hood. He asked for mince pies and cheese. During the evening when Thorin called for music, Bofur (along with Bifur) played a clarinet.</p>
<p>When Gandalf was telling the story of the company's adventures to Beorn, Bofur, Bifur, and Bombur were the last of the Dwarves to show up.</p>
<p>After the barrel ride down the River Running both Bofur and Bifur came out fairly dry and not very knocked about, but they lay down and refused to do anything.</p>
<p>Bofur fought in and survived the Battle of Five Armies. He was given his share of the treasure by Dáin Ironfoot, and made his home in Erebor.</p>
<h4>Later Life</h4>
<p>At Rivendell in T.A. 3018, Glóin told Frodo Baggins that Bofur was still alive and living in Erebor.</p>
<h4>Etymology</h4>
<p>The name Bǫvurr appears in the Dvergatal. Its meaning is unknown.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Bofur";
            ImageArtist = Artist.David_A_Nash;

            addFamily("Bombur (Brother)", "Bombur");
            addFamily("Bifur (Cousin)", "Bifur");

            addGroup("Thorin's Company", "Thorin's-Company");
        }
    }
}
