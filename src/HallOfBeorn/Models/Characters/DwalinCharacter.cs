using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class DwalinCharacter : Character
    {
        public DwalinCharacter()
            : base("Dwalin", "Dwalin", "Dwarf")
        {
            Bio =
@"<p>Dwalin (T.A. 2772 – Fo.A. 91[2]) was a Dwarf of the House of Durin. He was, along with his brother Balin, a member of Thorin's company which took part in the quest for Erebor. Dwalin survived the adventure and lived well into the Fourth Age.</p>
<h3>History</h3>
<p>Two years before he was born the dragon Smaug had come to Erebor[3] and destroyed King Thrór's kingdom. Thrór and a small group of kinsmen and followers headed south while other Dwarves of Erebor escaped to the Iron Hills so Dwalin was born in exile, perhaps in Dunland.</p>
<p>After the Battle of Azanulbizar, Thráin II and Thorin settled in the northern Ered Luin and at some point Dwalin joined them.</p>
<h4>King Thráin's Expedition</h4>
<p>Dwalin, his brother Balin, and a few others accompanied Thráin II in T.A. 2841 when he left the Ered Luin to visit Erebor. The small party was dogged by the emissaries of Sauron. In 2845 Thráin was captured one night when he and his companions sheltered under the eaves of Mirkwood from a black rain. After a fruitless search for their leader the Dwarves gave up and returned to Thorin.</p>
<h4>The Quest for Erebor</h4>
<p>Dwalin was the first Dwarf to arrive, alone, at Bag End when the unexpected party began at Bilbo's hobbit hole. He was wearing a dark-green hood and walked in as if expected, which greatly surprised Bilbo. Soon Balin arrived and he and Dwalin sat talking while Bilbo kept answering the door for the arrival of more and more Dwarves. Later, when Bilbo griped aloud in his kitchen about the lack of help in setting out refreshments, Dwalin and Balin were the first (followed by Fíli and Kíli) to lend a hand. Later still, when the Dwarves filled Bag End with music, Dwalin played on a viol as big as himself.</p>
<p>At the Green Dragon Inn, when Bilbo told the company that he had forgotten to bring his hat or his pocket-handkerchief, Dwalin gave him his spare dark-green hood and cloak to keep in place of a hat, but told him that he would 'have to manage without pocket-handkerchiefs, and a good many other things' before the end of the journey.</p>
<p>When the company rushed up into trees to escape the wargs, Dwalin and Balin managed to swarm up a tall slender fir that had few branches for sitting.[5] The next day, when the company arrived at Beorn's hall, Dwalin and Balin were the third pair of Dwarves to appear during Gandalf's story.</p>
<p>At the Enchanted River in Mirkwood, Dwalin was in the last boatload to cross. He exited the boat just before the deer charged down the path and caused Bombur to fall in the water. Later, after the Dwarves had been captured by the spiders and rescued by Bilbo, it was Dwalin who first realized that Thorin was missing.</p>
<p>At the opening of the barrels after the escape from the halls of the Elvenking, Dwalin and Balin were two of the most unhappy Dwarves and did nothing to help pull out other Dwarves.</p>
<p>When the last week of autumn arrived it was Dwalin who complained the most about Bilbo's inactivity. He felt that Bilbo, with his 'invisible ring', ought to go through the Front Gate of Erebor and spy things out.</p>
<p>Dwalin fought in and survived the Battle of Five Armies. Afterwards he received his fourteenth share and chose to live in Erebor under Dáin Ironfoot.</p>
<h4>Later Life</h4>
<p>Dwalin was one of seven of the ten Dwarves of Thorin's company who were still living in Erebor when Frodo came to Rivendell, as reported by Glóin. Dwalin lived until Fo.A. 91, later than any other known date of death for others of the company.</p>
<h4>Etymology</h4>
<p>In Norse mythology, Dvalinn is a chief Dwarf. The origin of the name is uncertain; suggested etymologies are 'one lying in a trance', 'numb' and 'dawdler'. Both words, dvalen ('to sleep') dvelja ('to delay') derive from the same root.</p>
<h4>Other Versions of the Legendarium</h4>
<p>In the early version of The Hobbit it was Dwalin rather than Balin who spotted the Trolls' fire in the woods (and it was stated that Dwalin was always the Dwarves' look-out).[17] This contradicted the fact that Balin was the Dwarf who was looking for Bilbo at the inn at the start of the adventure[18] and Tolkien eventually made Balin the permanent look-out. However, Dwalin remained the first Dwarf to arrive at Bag End[1] (what would be expected of the Company's look-out). Dwalin was also the first to notice that Thorin was missing after the battle with the spiders,[7] a testament to his observational abilities.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Dwalin";
            ImageArtist = Artist.Tony_Foti;

            addFamily("Fundin (Father)");
            addFamily("Balin (Brother)", "Balin");

            addFriend("Thorin Oakenshield", "Thorin-Oakenshield");

            addGroup("Thorin's Company", "Thorin's-Company");
        }
    }
}