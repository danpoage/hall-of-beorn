using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters.Things
{
    public class Orcrist : CharacterThing
    {
        public Orcrist()
            : base("Orcrist", "Orcrist", "Weapon")
        {
            Bio =
@"<p><b>Orcrist</b> was an Elven sword, the mate of Glamdring. It had a decorated scabbard and a jewelled hilt. Like Glamdring and Sting, the blade could detect the presence of Orcs and warn its bearer by glowing blue.</p>
<p>Goblins called the blade Biter. It had been crafted by the Elves, who not only made it a valuable weapon, but also a feared one to their enemies, particularly among Orcs and other evil creatures.</p>
<h3>History</h3>
<p>As the &ldquo;mate&rdquo; to King Turgon's sword Glamdring, Orcrist was likely borne by him, or a high ranking lord of the Gondolindrim in the King's entourage.</p>
<p>Orcrist &ldquo;had killed hundreds of goblins in its time, when the fair elves of Gondolin hunted them in the hills or did battle before their walls&rdquo;. During the Fall of Gondolin, Rog, Duilin, Egalmoth, Tuor and Ecthelion's houses defended at the gates before the walls. Ecthelion led a charge that resulted in the deaths of thousands of orcs, which made his name a terror to their race, before fighting Gothmog.</p>
<p>By the Third Age Orcrist and its mate were found and kept in a trolls' cave in Eriador. Thorin and Company, found and searched the cave early in the Quest of Erebor, and Thorin Oakenshield obtained the weapon. Elrond identified the sword and Thorin promised to honor the sword and hoped to cleave Goblins once again which he did when captured in Goblin-town.</p>
<p>Thorin was disarmed when captured by the Elves of Mirkwood and Orcrist was kept there. However after his death, Thranduil returned Orcrist and placed it upon Thorin's tomb under Erebor, and it &ldquo;gleamed ever in the dark if foes approached&rdquo;.</p>
<h3>Etymology</h3>
<p>Orcrist is Sindarin for &ldquo;goblin-cleaver&rdquo;.</p>
<p>In the Etymologies, the name Orchrist is said to be a &ldquo;sword-name&rdquo;, related to Noldorin risto (&ldquo;rend, rip&rdquo;), derived from the root RIS (&ldquo;slash, rip&rdquo;).</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Orcrist";
            ImageArtist = Artist.Magali_Villeneuve;

            addFriend("Thorin Oakenshield", "Thorin-Oakenshield");

            Alias("Goblin-cleaver", "Goblin-cleaver-THOHaUH");
            Alias("Biter");

            LotRCard("Orcrist-FitN");
            LotRCard("Orcrist-THOHaUH");
        }
    }
}