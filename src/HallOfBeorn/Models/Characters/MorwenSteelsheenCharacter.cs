using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class MorwenSteelsheenCharacter
        : Character
    {
        public MorwenSteelsheenCharacter()
            : base("Morwen Steelsheen", "Morwen Steelsheen", "Man")
        {
            Bio =
@"<p><b>Morwen Steelsheen</b>, also known as <b>Morwen of Lossarnach</b>, was the queen to King Thengel of Rohan, and mother of his heir Théoden. The epithet 'Steelsheen' was given to her by the Rohirrim due to the grace and pride that she brought from Gondor.</p>
<p>Being one of the Dúnedain of the South due to her high-Númenórean heritage, her descendants were said to be considerably taller than most of the Rohirrim, especially Éomer, and some also inherited her dark hair. Éowyn was slender and tall, and she too inherited the graceful and proud bearing of Gondor from Morwen.</p>
<h4>History</h4>
<p>Although Morwen dwelt in Lossarnach, she did not belong to the people of that land. In fact, her father had removed there for its flowering vales, from Belfalas; he was a descendant of a former Prince of Dol Amroth and thus a kinsman of Prince Imrahil.</p>
<p>In T.A. 2943, she was married to Thengel of Rohan in Gondor, though she was seventeen years younger than him. She bore three children in Gondor, of whom Théoden, the second, was her only son. When his father Fengel died, Thengel inherited the Kingship of Rohan, and travelled with Morwen back to his own land. Morwen bore him two more daughters in Rohan; and the last, Théodwyn, was the fairest; she would become the mother of Éomer and Éowyn.</p>
<h4>Etymology</h4>
<p>Morwen is the name of a famous member of the House of Bëor in the first age. It translates from Sindarin as 'black(haired) woman'.</p>
<p>'Steelsheen' is presumably intended as a modernization of Old English stýle 'steel' + scíene 'beautiful.'</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Morwen_Steelsheen";
            ImageArtist = Artist.Kimberly80;

            addFamily("Thengel (Husband)", "Thengel");
            addFamily("Théoden (Son)", "Theoden");
            addFamily("Théodwyn (Daughter)", "Theodwyn");

            Alias("Morwen of Lossarnach");

            LotRCard("Morwen-Steelsheen-CoE");
        }
    }
}