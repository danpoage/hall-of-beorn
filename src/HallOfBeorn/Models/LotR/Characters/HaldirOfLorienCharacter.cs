using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class HaldirOfLorienCharacter : Character
    {
        public HaldirOfLorienCharacter()
            : base("Haldir of Lórien", "Haldir of Lórien", "Silvan Elf")
        {
            Bio =
@"<blockquote>
&ldquo;But there are some of us still who go abroad for the gathering of news and the watching of our enemies, and they speak the languages of other lands. I am one. Haldir is my name.&rdquo;
<br>― Haldir
</blockquote>
<p><b>Haldir</b> was an Elf of Lothlórien, probably a Silvan Elf, and a marchwarden who guarded the forest's northern borders.</p>
<h4>History</h4>
<p>Haldir was one of the Galadhrim; unlike his brothers, Rúmil and Orophin, Haldir had traveled outside Lórien and knew Westron. He and his companions are described as wearing grey hooded cloaks and living on flets in the trees.</p>
<p>Haldir was accompanied by his brothers between 15 and 16 February, T.A. 3019[2] when they encountered the Fellowship of the Ring who arrived in Lórien. His brothers interacted little with the Fellowship because they spoke little of the Common Speech. He treated Gimli rather poorly due to bad relations between Elves and Dwarves. He made him go blindfolded through the wood until Galadriel said he did not have to.</p>
<p>He had heard of Aragorn, but there is no indication that they had met before.[1] Haldir became their guide to the city of Caras Galadhon.</p>
<p>After Celeborn and Galadriel had nourished their guests, and they were set to depart, Haldir led them to their Elven boats.</p>
<h4>Etymology</h4>
<p>Tolkien explained the name Haldir as Sindarin for 'Hidden Hero', though this Haldir refers to the (later omitted) son of Orodreth.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Haldir";
            ImageArtist = Artist.Sebastian_Giacobino;

            Alias("Marchwarden of Lórien");

            addFamily("Rúmil (Brother)", "Rumil");
            addFamily("Orophin (Brother)", "Orophin");

            addItem("Bow of the Galadhrim", "Bow-of-the-Galadhrim-NiE");
            addItem("Cloak of Lórien", "Cloak-of-Lorien-CS");

            addGroup("Lórien", "Lorien");

            Card("Haldir-of-Lorien-AJtR");
            Card("Haldir-of-Lorien-TiT");
        }
    }
}