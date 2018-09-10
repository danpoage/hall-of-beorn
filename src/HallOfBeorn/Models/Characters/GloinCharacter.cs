using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class GloinCharacter : Character
    {
        public GloinCharacter()
            : base("Glóin", "Glóin, son of Gróin", "Dwarf")
        {
            Bio =
@"<p>Glóin (T.A. 2783 – Fo.A. 15, aged 253 years), was a dwarf of Durin's Folk, the son of Gróin, the brother of Óin, and the father of Gimli of the Fellowship of the Ring.[2] He is most famous as one of Thorin's companions on the quest to Erebor.</p>
<h4>Youth</h4>
<p>Glóin was likely born in Dunland, where the Dwarves of Durin's Line dwelt in exile[2] after their expulsion from Erebor by Smaug in T.A. 2770.[3] Glóin was present at the Battle of Azanulbizar,[2] which was odd because Dwarves were considered to be mere striplings in their thirties, yet at the time (2799[3]) Glóin was but 16. After the war Glóin returned to Dunland with the followers of Thorin, who then removed to the Ered Luin.</p>
<h4>Life in Thorin's Halls</h4>
<p>During Glóin's life in Ered Luin he saw the departure of King Thráin, who tried to go back to Erebor, but was captured and tortured for the Ring of Thrór, and subsequently died several years later. Under King Thorin, Glóin and the other Dwarves living in Thorin's Halls in the mountains became prosperous in a fashion and trafficked goods with other peoples, and gained what wealth they could. But ever they spoke of the Lonely Mountain.</p>
<h4>The Quest of Erebor</h4>
<p>In 2941 Thorin happened to meet Gandalf the Wizard. From this meeting came Thorin's determination to return to the Lonely Mountain with a company of Dwarves, including Glóin, to seek revenge upon Smaug. Gandalf came to a conclave of the Dwarves after visiting the Shire (but before seeing Bilbo Baggins) to persuade them to take the hobbit with them. The Dwarves were skeptical, with Glóin calling them 'simpletons' and claiming that one of them 'would never dare to come within smelling distance of the nakedest dragonet new from the shell!'</p>
<p>Glóin was the fifth Dwarf in the fourth group to arrive at Bag End for the Unexpected Party, and he came wearing a white hood. Glóin did not assist in setting the table nor did he bring a musical instrument out when Thorin called for music. After Bilbo had his fit of fright he overheard Glóin sneer that the hobbit looked 'more like a grocer than a burglar' when he saw him 'bobbing and puffing on the mat'. This affronted Bilbo enough to make him agree to undertake the quest. Then, when Gandalf proclaimed that Bilbo was his choice he scowled at Glóin so fiercely that the dwarf huddled back in his chair.</p>
<p>On their quest Glóin was quite useful, especially at making fires, although on the night the company met the trolls he and his brother failed to start one and began to fight. On the night when the company came to the glade of the Wargs, Glóin secured a seat in a huge pine tree.[7] At Beorn's home Glóin and Óin were the fifth pair of Dwarves to appear as Gandalf spun their tale.[8] And when released from his barrel near Esgaroth, Glóin was one of the Dwarves who was waterlogged and seemed but half alive, and needed to be carried ashore.</p>
<p>Glóin fought in and survived the Battle of Five Armies. He was given his share of the treasure by Dáin Ironfoot, who became King after Thorin's death. Glóin settled in the Lonely Mountain.</p>
<h4>The War of the Ring</h4>
<p>n October T.A. 3018[11] Glóin and his son Gimli were sent by Dáin Ironfoot to Rivendell to seek advice concerning the fate of Balin's Colony in Moria. When Frodo Baggins recovered from his wounds and attended the feast, it was Glóin who sat next to him and gave him the news from Erebor and surrounding lands since the time of Bilbo.[1] Later, at the Council of Elrond, Glóin spoke of the shadow that had fallen upon his people and of the sinister messenger from Mordor who had come to inquire about Hobbits and where they dwelt.[12] Glóin's greatest contribution to the War of the Ring was his son Gimli, who joined the Fellowship of the Ring.</p>
<p>It is possible that Glóin fought in the Battle of Dale during the War of the Ring, for he lived until Fo.A. 15.</p>
<h4>Etymology</h4>
<p>Glóinn is a dwarf in the Dvergatal. The name means 'Glowing one'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Gloin";
            ImageArtist = Artist.Jeff_Lee_Johnson;

            addFamily("Gróin (Father)");
            addFamily("Óin (Brother)", "Oin");
            addFamily("Gimli (Son)", "Gimli");

            addFriend("Thorin Oakenshield", "Thorin-Oakenshield");
            addFriend("Bilbo Baggins", "Bilbo-Baggins");

            addItem("Dwarven Shield", "Dwarven-Shield-TSoH");

            addGroup("Thorin's Company", "Thorin's-Company");
            addGroup("The Council of Elrond", "The-Council-of-Elrond");

            LotRCard("Gloin-Core");
            LotRCard("Gloin-THOtD");
        }
    }
}