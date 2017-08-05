using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class CelebrianCharacter : Character
    {
        public CelebrianCharacter()
            : base("Celebrían", "Celebrían", "Noldor Elf")
        {
            Bio =
@"<p>Celebrían (S, pron. [keleˈbriː.an]; sailed West T.A. 2510) was an Elf-lady of Lothlórien, the daughter of Celeborn and Galadriel. As the wife of Elrond, she was also known as Lady of Rivendell. She was the mother of Arwen and the twins Elrohir and Elladan. Her daughter would later marry Aragorn Elessar, hero of the War of the Ring, and become the Queen of the Reunited Kingdom.</p>
<h4>History</h4>
<p>Celebrían lived in the Elven Kingdom of Eregion, and later moved to Lórien with her mother sometime after S.A. 1350. In S.A. 1701 she went to Rivendell with Galadriel searching for Celeborn, where she first met Lord Elrond.[3] Centuries later they would marry, in the year 109 of the Third Age.[2] She had inherited the Elfstone from her mother, which she later gave to Arwen.</p>
<p>In T.A. 2509, on a trip to Lórien to visit her parents, she was waylaid by Orcs in the Redhorn Pass of the Misty Mountains. She was captured and tormented, receiving a poisoned wound. Her sons rescued her and she was physically healed by Elrond, but she never fully recovered in mind or spirit, and no longer wished to stay in Middle-earth. She left for the Grey Havens and passed over the Great Sea the following year.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Celebrian";
            ImageArtist = Artist.Tawny_Fritzinger;

            addFamily("Galadriel (Mother)", "Galadriel");
            addFamily("Celeborn (Father)", "Celeborn");
            addFamily("Elrond (Husband)", "Elrond");
            addFamily("Elladan (Son)", "Elladan");
            addFamily("Elrohir (Son)", "Elrohir");
            addFamily("Arwen Undómiel (Daughter)", "Arwen-Undomiel");

            addGroup("The House of Elrond");
            addGroup("Lórien");

            Card("Celebrian's-Stone-Core");
        }
    }
}