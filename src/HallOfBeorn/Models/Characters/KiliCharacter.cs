using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class KiliCharacter : Character
    {
        public KiliCharacter()
            : base("Kíli", "Kíli, son of Dís", "Dwarf")
        {
            Bio =
@"<p>Kíli (T.A. 2864 – 2941[1] 77 years old) was the son of Dís, the sister of King Thorin, and brother of Fíli.</p>
<p>Kíli was one of the thirteen Dwarves who took part in the quest for Erebor, which was Bilbo Baggins's great adventure. The brothers were the youngest of Thorin and Company by some 50 years,[2] with Kíli being five years younger than his brother.[1] The two brothers were inseparable throughout the adventure.</p>
<p>The brothers, along with Thorin himself, did not survive the Battle of Five Armies.</p>
<h4>History</h4>
<p>Before the quest to Erebor, Fíli and Kíli probably lived in the Blue Mountains where their uncle resided after the disappearance of Thráin II.[1] As Thorin's sister-sons, they accompanied their uncle when he set out to challenge the dragon Smaug.</p>
<p>When Bilbo first met Kíli and Fíli (in the third group of Dwarves to arrive at Bag End) they wore blue hoods. After supper, when the Dwarves made music, Kíli and Fíli played small fiddles that they had brought in bags.</p>
<p>Early on the night when the company encountered the trolls one of the ponies became frightened and bolted into the river; Kíli and Fíli nearly drowned getting the beast out of the water.</p>
<p>Up in the Misty Mountains during the thunder-battle the two brothers, being the youngest Dwarves with the keenest eyes, were sent ahead to look for shelter. They found a small dry cave which was perfect for the company (until the Gobins arrived). After Gandalf had rescued the company and was counting the members he found Kíli and Fíli, as usual, paired together.</p>
<p>When the company rushed up into trees to escape the wargs Kíli and Fíli scrambled to the top of a tall larch.[5] The next day, when the company arrived at Beorn's hall, Kíli and Fíli were again together as the fourth pair of Dwarves to appear during Gandalf's story.</p>
<p>When Bilbo spied the boat on the far side of the Enchanted River, Fíli managed to snag it with a hook on a rope but could not pull it across. Kíli came to his aid first, followed by Óin and Glóin, before the boat came loose (after its painter snapped).</p>
<p>At the opening of the barrels after the escape from the halls of the Elvenking, Kíli and Fíli came out smiling since they were young and had but few bruises. The two brothers helped Thorin and Bilbo locate and free the other Dwarves. Next, they accompanied Thorin and Bilbo to the bridge into Esgaroth while the others recovered.</p>
<p>When the company reached the Lonely Mountain, Thorin sent out a scouting party to view the Front Gate (or where it had once stood). Kíli and Fíli went along with Balin and Bilbo on this expedition. On another scouting trip Bilbo was with Kíli and Fíli when the three discovered the rough steps that led up the mountain to the little bay that contained the secret door.</p>
<p>Of the thirteen Dwarves, Kíli and Fíli looked uncomfortable when Bilbo asked for volunteers to accompany him on the first trip into the mountain (only Balin went with the hobbit for part of the way). Once the dragon woke up though Kíli and Fíli, along with Bilbo and Balin, were the first to go in the tunnel (sent in by Thorin).</p>
<p>While searching the treasure when the full company descended into Erebor, Kíli and Fíli were in such exuberant spirits that they took down magic golden harps and played music on them.</p>
<p>Kíli was slain with his brother in the Battle of Five Armies, while defending their mortally wounded uncle. After Thorin's death, the brothers would have been the only remaining descendants of Thrór's line. Their deaths ended the dynasty, and the title of King under the Mountain passed to Dáin II. It was their heroic last stand that made their mother the only Dwarf-woman to be mentioned in the genealogies</p>
<h4>Etymology</h4>
<p>Kíli is a dwarf from the Dvergatal. It can mean 'Wedge' or 'One who uses a wedge'; it is of Frisian or Low German origin rather than Old Norse.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Kili";
            ImageArtist = Artist.Daniel_Govar;

            addFamily("Dís (Mother)");
            addFamily("Thorin Oakenshield (Uncle)", "Thorin-Oakenshield");
            addFamily("Fili (Brother)", "Fili");

            addGroup("Thorin's Company", "Thorin's-Company");
        }
    }
}
