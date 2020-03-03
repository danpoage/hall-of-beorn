using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class DainIronfootCharacter : Character
    {
        public DainIronfootCharacter()
            : base("Dáin Ironfoot", "Dáin II Ironfoot", "Dwarf")
        {
            Bio = 
@"<p>Dáin II or Dáin Ironfoot (Third Age 2767 – 3019, aged 252 years) was the Lord of the Iron Hills and King under the Mountain. In his life, he fought in the Battle of Azanulbizar, the Battle of Five Armies and the Battle of Dale. He was renowned as a warrior across Middle-earth.</p>
<h3>History</h3>
<h4>Early Life</h4>
<p>Dáin was born in T.A. 2767 in the Iron Hills, the son of Náin, during the reign of his grandfather Grór.</p>
<h4>War of the Dwarves and Orcs</h4>
<p>After the murder of Thrór by Azog in T.A. 2790, his son Thráin II swore revenge. He summoned all available Dwarves, and sacked every Orc stronghold in the Misty Mountains, battling his way to Moria. There, the Battle of Azanulbizar raged before the gate of the ancient Dwarf stronghold.</p>
<p>Náin and his son Dáin arrived late in the battle, but proved pivotal. Fresh and well equipped, they drove through the Orc forces, until at last Náin confronted Azog. But Náin was weary and filled with anger, and Azog strong and agile. He darted from the dwarf's blows, and when the warrior stumbled, Azog hewed and broke his neck. However, all across the valley, his troops were in retreat. He tried to escape back inside, but he was followed by Dáin who with his red axe, hewed off his head before the doors of the East-Gate. He was a very young Dwarf at thirty-two at the time, and it was heralded as a magnificent feat.</p>
<p>After the battle King Thráin II wanted to enter Moria as his own. But Dáin dissuaded him, because he alone looked past the gate into Moria, and had the wisdom to know that it was impossible for Durin's folk to return at that time because of Durin's Bane.</p>
<h4>Lord of the Iron Hills</h4>
<p>Dáin returned to the Halls of Grór with his people, and with his father dead, became Lord of the Iron Hills at his grandfather's death in T.A. 2805. He had one son, Thorin, born in T.A. 2866.</p>
<p>During his reign his people became the strongest in Wilderland, being the only realm capable to resist Sauron if he dared come North and retake the realm of Angmar and the northern passes of the Misty Mountains.</p>
<h4>The Battle of Five Armies</h4>
<p>Nearly a hundred years later, King Thorin, the son of Thráin II, set out on a journey to reclaim Erebor, the Lonely Mountain, which had been usurped by the Dragon Smaug.</p>
<p>The dragon was slain, though by Bard of Lake-town and not by Thorin's company. Thorin claimed the entire hoard and proclaimed himself King under the Mountain, but both Bard and the Elven king Thranduil both longed for compensation of their suffering caused by the Dragon. Because his company of thirteen could not hold the mountain, Thorin sent for Dáin.</p>
<p>Dáin responded to Thorin's call and set out with more than five hundred dwarves, well armed and experienced. They were originally intent on driving off the Elves and Men, but Gandalf arrived to inform them of the approaching Orcs and Wargs. They all united against the common enemy, and so was fought the Battle of Five Armies in the valley of Dale.</p>
<p>Thorin was killed in the battle, as were his sister-sons Kíli and Fíli. As his 'rightful heir,' Dáin succeeded Thorin as King under the Mountain, and King of all of Durin's folk.</p>
<h4>King Under the Mountain</h4>
<p>During his reign as king, he became exceedingly rich and his people were very prosperous. The town of Dale was rebuilt and its border stretched far to the South and East and the friendship between the Elves of Mirkwood, Men of Dale, and Dwarves of Erebor was close, especially between the Men and Dwarves. For the Dwarves of Erebor now exceeded all their ancestors in the art of masonry and mining, and created many beautiful things in Dale.</p>
<p>But not all were content. Balin set out with several others to reclaim Moria in T.A. 2989. Dáin did not give the expedition his blessing, and could not dissuade them.[8] It was only later learned the colony was destroyed after five years.</p>
<h4>War of the Ring</h4>
<p>In T.A. 3018, a messenger came from Mordor, enquiring about a creature named 'Baggins' from 'Shire'. In return for information Dáin would be given the last three Dwarf-rings. Dáin told him to give him time to think and for many weeks he pondered until he sent Glóin and his son Gimli to Elrond for council, and to warn Bilbo of the enemy looking for him.</p>
<p>After many months war came to Erebor in the Battle of Dale. King Brand of Dale was at war with Easterlings along the River Carnen, but they defeated him and he retreated back to Dale where he was given aid by Dáin and an army of Dwarves. After three days of fighting the Dwarves and Men were driven back, and Brand was slain. But defending his body stood Dáin, who at over 250 years old was not feeble, and still could wield his axe with great skill. But his skill was not enough and he was slain as well before the gates of Erebor.</p>
<p>Several days later the Easterlings learned that the Battle of the Pelennor Fields was lost and they were afraid. When the new King Thorin III Stonehelm, son of Dáin, and Brand's son Bard II saw this they came out of the mountain and routed their enemies.</p>
<h4>Etymology and Names</h4>
<p>Dáinn is a dwarf from the Dvergatal. His name most likely means 'Deadlike'.</p>
<p>The epithet Ironfoot remains unexplained in the published writings of J.R.R. Tolkien. However, John D. Rateliff has pointed out that an explanation for the epithet is likely found in the original manuscript of The Hobbit, where it is stated that the shoes of the Dwarves of the Iron Hills were of iron.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/D%C3%A1in_Ironfoot";
            ImageArtist = Artist.Olga_G;

            Alias("King Under the Mountain", "King-Under-the-Mountain-THOtD");
            Alias("Lord of the Iron Hills");
            Alias("King of Durin's Folk");

            addFamily("Náin (Father)");
            addFamily("Thorin Stonehelm (Son)", "Thorin-Stonehelm");
            addFamily("Thorin Oakenshield (Cousin)", "Thorin-Oakenshield");

            addFriend("Brand son of Bain", "Brand-son-of-Bain");
            addFriend("Balin", "Balin");
            addFriend("Glóin", "Gloin");
        }
    }
}