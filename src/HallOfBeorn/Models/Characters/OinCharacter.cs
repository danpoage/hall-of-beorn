using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class OinCharacter : Character
    {
        public OinCharacter()
            : base("Óin", "Óin, son of Gróin", "Dwarf")
        {
            Bio =
@"<p>Óin (T.A. 2774 - 2994, 220 years old) was one of the Dwarves of Thorin's company who set out to reclaim Erebor from Smaug. Later, he followed Balin in an ill-fated attempt to retake Moria.</p>
<h4>History</h4>
<p>Óin was the son of Gróin and older brother of Glóin, both of the House of Durin.</p>
<h4>The Quest of Erebor</h4>
<p>Óin was one of the five Dwarves in the fourth group to arrive at Bag End. He wore a brown hood.</p>
<p>Óin and Glóin were noted for their ability to start fires, although both failed on the night that the company met the trolls. In their frustration they began to quarrel and eventually to fight, which was the incident that prompted the company to head for the fire seen far off on a hill.</p>
<p>In the glade where the wolves came to gather, Óin was one of five Dwarves who climbed up to fairly comfortable seats in a huge pine tree.</p>
<p>When Gandalf was telling the story of the company's adventures to Beorn, Óin and Glóin were the fifth pair of Dwarves to show up.</p>
<p>Óin fought in and survived the Battle of Five Armies. He was given his share of the treasure by Dáin Ironfoot, and made his home in Erebor.</p>
<h4>Expedition to Moria</h4>
<p>In T.A. 2989 Óin had followed Balin with a colony of Dwarves in an attempt to reclaim their ancient mansions of Khazad-dûm, which were occupied by Orcs.[8] At first the colony did well, but on November 10, 2994 Balin was killed, and the Orcs returned. They took the East-gate/First Hall then the Second Hall after a fierce battle which Óin likely fought in. Óin went with a party to find escape via the West-gate but they found the water up to the doors and he was killed by the Watcher in the Water. Of his party only four returned five days after they had left, and soon thereafter all the remaining colonists were killed in a final stand in the Chamber of Mazarbul.</p>
<p>When Frodo Baggins came to Rivendell he met Glóin, who delighted in telling the hobbit about the doings of the renewed dwarf-kingdom in the Lonely Mountain. But when Frodo asked about Óin, Balin, and Ori, Glóin's face darkened and he said that he did not know. Their fate was largely why the Dwarves had come to Rivendell at that time, to seek news from Elrond.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Oin";
            ImageArtist = Artist.Alex_Tooth;

            addFamily("Gróin (Father)");
            addFamily("Glóin (Brother)", "Gloin");
            addFamily("Gimli (Nephew)", "Gimli");

            addFriend("Thorin Oakenshield", "Thorin-Oakenshield");
            addFriend("Balin", "Balin");
            addFriend("Bilbo Baggins", "Bilbo-Baggins");

            addGroup("Thorin's Company", "Thorin's-Company");
            addGroup("Balin's Colony");
        }
    }
}
