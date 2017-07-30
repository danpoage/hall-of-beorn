using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class FiliCharacter : Character
    {
        public FiliCharacter()
            : base("Fíli", "Fíli, son of Dís", "Dwarf")
        {
            Bio =
@"<p>Fíli (T.A. 2859 – 2941,[1] 82 years old) was one of the thirteen Dwarves who took part in the quest for Erebor, which was Bilbo Baggins's great adventure. He was one of the three Dwarves of Thorin's company who did not survive the Battle of Five Armies (the other two being his uncle Thorin and his brother Kíli.)</p>
<p>Fíli and Kíli were the sons of Dís, the sister of Thorin. Before the quest to Erebor, they probably lived in the Blue Mountains where their uncle resided after the disappearance of Thráin II.[1] As Thorin's sister-sons, they accompanied their uncle when he set out to challenge the dragon Smaug. Before the Dwarves met Bilbo, Gandalf met with them and persuaded them to bring the hobbit on the quest. At this meeting Fíli thought that Bilbo sounded like a strange creature and laughed at his name.</p>
<h4>The Quest of Erebor</h4>
<p>When Bilbo first met Fíli and Kíli (in the third group of Dwarves to arrive at Bag End) they were wearing blue hoods. After supper, Fíli and Kíli played small fiddles that they had brought in bags.</p>
<p>The brothers were the youngest of the company by some 50 years,[4] with Kíli being five years younger than his brother. Although not twins, the two brothers were inseparable throughout the adventure.</p>
<p>Early on the night when the company encountered the Trolls one of the ponies became frightened and bolted into the river; Fíli and Kíli nearly drowned getting the beast out of the water. After the trolls had turned to stone and the company explored their hideout, it was Fíli who encouraged the others to get out of the 'horrible smell' in the troll's lair.</p>
<p>Up in the Misty Mountains during the thunder-battle the two brothers, being the youngest Dwarves with the keenest eyes, were sent ahead to look for shelter. They found a small dry cave which was perfect for the company (until the Gobins arrived). After Gandalf had rescued the company and was counting the members he found Fíli and Kíli, as usual, paired together.</p>
<p>When the company rushed up into trees to escape the wargs, Fíli and Kíli scrambled to the top of a tall larch. The next day, when the company arrived at Beorn's Hall, Fíli and Kíli were again together as the fourth pair of Dwarves to appear during Gandalf's story.</p>
<p>When Bilbo spied the boat on the far side of the Enchanted River, Thorin chose Fíli as the youngest with the best sight (instead of Dori, the strongest) to throw a rope with a hook attached to snag the small vessel. Fíli did manage to snag the boat on the second try but could not pull it across. Kíli came to his aid first, followed by Óin and Glóin, before the boat came loose (after its painter snapped). When the company made the crossing they used another rope that Fíli threw ahead into the trees since the boat had no oars.</p>
<p>After the Dwarves had been captured by spiders Bilbo climbed out on the branch where the spiders had trussed up the Dwarves. The first bundle that Bilbo reached was Fíli, whom the hobbit recognized by the tips of his blue hood and long nose poking out of the threads.[note 2] Once freed, Fíli helped Bilbo free the other Dwarves despite being sickened by spider-poison.</p>
<p>After the escape from the halls of the Elvenking, Fíli and Kíli came out smiling since they were young and had but few bruises. The two brothers helped Thorin and Bilbo locate and free the other Dwarves. Next, they accompanied Thorin and Bilbo to the bridge into Esgaroth while the others recovered and Fíli was the most impatient to see the Master of Lake-town at his feast.</p>
<p>When the company reached the Lonely Mountain, Thorin sent out a scouting party to view the Front Gate (or where it once stood). Fíli and Kíli went along with Balin and Bilbo on this expedition. On another scouting trip Bilbo was with Fíli and Kíli when the three discovered the rough steps that led up the mountain to the little bay that contained the secret door.</p>
<p>Of the thirteen Dwarves, Fíli and Kíli looked uncomfortable when Bilbo asked for volunteers to accompany him on the first trip into the mountain (only Balin went with the hobbit for part of the way). Once the dragon woke up though Fíli and Kíli, along with Bilbo and Balin, were the first to go in the tunnel (sent in by Thorin).</p>
<p>While searching the treasure when the full company descended into Erebor, Fíli and Kíli were in such exuberant spirits that they took down magic golden harps and played music on them.</p>
<p>Fíli was slain with his brother in the Battle of Five Armies, while defending their mortally wounded uncle. After Thorin's death, the brothers would have been the only remaining descendants of Thrór's line and Fíli would have inherited the title of King under the Mountain. Their deaths ended the dynasty, and the title passed to Dáin II. It was their heroic last stand that made their mother the only Dwarf-woman to be mentioned in the genealogies.</p>
<h4>Etymology</h4>
<p>Fíli is a dwarf from the Dvergatal. It can mean 'File' or 'Filer'; it is of Frisian or Low German origin rather than Old Norse.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Fili";
            ImageArtist = Artist.Angelo_Montanini;

            addFamily("Dís (Mother)");
            addFamily("Thorin Oakenshield (Uncle)", "Thorin-Oakenshield");
            addFamily("Kili (Brother)", "Kili");

            addGroup("Thorin's Company", "Thorin's-Company");

            Card("Fili-THOHaUH");
        }
    }
}