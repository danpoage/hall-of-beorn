using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class OrophinCharacter : Character
    {
        public OrophinCharacter()
            : base("Orophin", "Orophin", "Silvan Elf")
        {
            Bio =
@"<p>Orophin was a Silvan Elf of Lothlórien.</p>
<h4>History</h4>
<p>Orophin was the brother of Haldir and Rúmil. He was one of the Galadhrim who seldom left Lothlórien and spoke but a little of Westron.</p>
<p>He was one of three wardens of the northern border of Lothlórien met by the Fellowship as they entered the Golden Wood on 15 January T.A. 3019.</p>
<p>Some days later, when a band of a hundred Orcs were seen passing the Nimrodel, the three brothers went ahead and spoke with feigned voices, leading them on into the wood. Orophin ran back to warn the Galadhrim and prepare an ambush and fortify the wood.</p>
<h4>Etymology</h4>
<p>Robert Foster identified the name as either Sindarin or Silvan. At another point it is described to be 'suitable to Sindarin sounds and patterns' although it is 'not clearly etymologizable as Sindarin'.</p>
<p>One possibility is that Orophin means 'Mountain Peak', from orod and pind.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Orophin";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Marchwarden of Lórien");

            addFamily("Haldir of Lórien (Brother)", "Haldir-of-Lorien");
            addFamily("Rúmil (Brother)", "Rumil");

            addItem("Bow of the Galadhrim", "Bow-of-the-Galadhrim-NiE");
            addItem("Cloak of Lórien", "Cloak-of-Lorien-CS");

            addGroup("The Galadhrim");

            Card("Orophin-CS");
        }
    }
}