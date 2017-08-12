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
@"<p>Haldir was an Elf of Lothlórien, probably a Silvan Elf: a marchwarden who guarded the forest's northern borders. When the Fellowship of the Ring arrived in Lórien, he became their guide to Caras Galadhon. He and his companions are described as wearing grey hooded cloaks and living on platforms in the trees.</p>
<p>Haldir was seen with his brothers, Rúmil and Orophin, when the fellowship entered Lórien. They are little discussed by Tolkien in the book and much less, if at all in the movie.</p>
<p>Haldir was one of the few Elves of Lórien who could speak Westron (unlike either of his brothers).</p>
<p>As Haldir led the Fellowship inside Lothlórien, law required him to blindfold Gimli the Dwarf until the company was brought before Galadriel and Celeborn. Haldir and other Silvan Elves still bore grudges against Dwarves as a result of long-past events in the First Age involving King Thingol, and treated Gimli as a potential foe. Aragorn, in his wisdom, suggested that all of the Fellowship, including Legolas the Elf, be blindfolded as well. Haldir successfully led the Fellowship so that they did not even stub their toes. After the company leaves Lothlórien, Tolkien never mentions him again.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/List_of_Middle-earth_Elves#Haldir";
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