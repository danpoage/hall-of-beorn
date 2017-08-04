using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class RumilCharacter : Character
    {
        public RumilCharacter()
            : base("Rúmil", "Rúmil", "Silvan Elf")
        {
            Bio =
@"<p>Rúmil was a Silvan Elf of Lothlórien.</p>
<h4>History</h4>
<p>Rúmil was the brother of Haldir and Orophin. He was one of three wardens met by the Fellowship as they entered the Golden Wood.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/R%C3%BAmil_(elf_of_L%C3%B3rien)";
            ImageArtist = Artist.Michelle_Tolo;

            Alias("Marchwarden of Lórien");

            addFamily("Haldir of Lórien (Brother)", "Haldir-of-Lorien");
            addFamily("Orophin (Brother)", "Orophin");

            addItem("Bow of the Galadhrim", "Bow-of-the-Galadhrim-NiE");
            addItem("Cloak of Lórien", "Cloak-of-Lorien-CS");

            addGroup("The Galadhrim");

            Card("Rumil-TTT");
        }
    }
}