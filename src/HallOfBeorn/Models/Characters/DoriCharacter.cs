using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class DoriCharacter : Character
    {
        public DoriCharacter()
            : base("Dori", "Dori", "Dwarf")
        {
            Bio =
@"<p>Dori was a Dwarf who, being of Durin's Folk, probably dwelt in the northern Blue Mountains with Thorin after the latter had settled there after Thráin II had disappeared. He was one of the thirteen Dwarves who journeyed to Erebor to challenge the dragon Smaug, and after the successful conclusion of this quest he lived with his part of the treasure at the Lonely Mountain.</p>
<p>Dori's parentage is unknown although he was a member of the House of Durin and a remote kinsman of Thorin. His birth year is also unknown. However, in Bilbo Baggins' account of the quest to Erebor he stated that the brothers Fíli and Kíli were the youngest of the thirteen 'by some fifty years' and that when Thorin was missing, Balin was 'the eldest left' Since Fíli was born in T.A. 2859 and Balin was born in 2763,[1] this would put Dori's birth between 2809 and 2763, and he would have been between 132 and 178 years old during the quest to Erebor. Thorin stated that Dori was the strongest of the Dwarves in the company. Dori (and Nori) shared Bilbo's opinion that meals should be plentiful and frequent.</p>
<h4>The Quest of Erebor</h4>
<p>When Bilbo first met Dori (in the fourth group of Dwarves to arrive at Bag End) he was wearing a purple hood. During the evening when Thorin called for music, Dori (along with Nori and Ori) played the flute.</p>
<p>Bilbo proclaimed Dori to be 'really a decent fellow' because thrice Dori assisted Bilbo when the hobbit might otherwise have been killed: First, Dori carried Bilbo in the tunnels of the Misty Mountains during the escape from the goblins, but unfortunately dropped him;[3] the other Dwarves later blamed him for losing their burglar. Second, during the escape from the Wargs, Dori climbed down from a tree, which allowed Bilbo to scramble up Dori and into the tree. Lastly, Bilbo grabbed Dori's legs as they were carried off by an eagle, saving them from a fire lit by Goblins.</p>
<p>When Gandalf was telling the story of the company's adventures to Beorn, Dori and Thorin were the first two Dwarves to show up. Upon being pulled out of the barrel after escaping the Elvenking's halls, Dori was one of the Dwarves who was waterlogged and seemed only half alive.</p>
<p>Dori later fought in and survived the Battle of Five Armies. He was given his share of the treasure by Dáin Ironfoot, and made his home in Erebor.</p>
<h4>Erebor</h4>
<p>Dori lived a very rich life after the quest as one of the reclaimers of the mountain. He was still alive during the War of the Ring, and may have fought in the Battle of Dale. His date of death is not known.</p>
<h4>Etymology</h4>
<p>Dóri is a dwarf from the Dvergatal. His name most likely means 'Borer' or 'auger-man'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Dori";
            ImageArtist = Artist.Jake_Murray;

            addFriend("Thorin Oakenshield", "Thorin-Oakenshield");
            addFriend("Nori", "Nori");
            addFriend("Ori", "Ori");

            addGroup("Thorin's Company", "Thorin's-Company");
        }
    }
}
