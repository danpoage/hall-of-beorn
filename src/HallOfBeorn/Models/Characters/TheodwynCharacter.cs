using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class TheodwynCharacter
        : Character
    {
        public TheodwynCharacter()
            : base("Théodwyn", "Théodwyn", "Man")
        {
            Bio =
@"<p><b>Théodwyn</b> (T.A. 2963-3002) was the mother of Éomer and Éowyn.</p>
<h4>History</h4>
<p>Théodwyn was a noble woman of Rohan, the sister of Théoden, and the daughter of Thengel and Morwen Steelsheen. She was married to Éomund of Eastfold in T.A. 2989. Her son Éomer was born in 2991, and her daughter Éowyn in 2995.</p>
<p>Éomund was slain in 3002. Not long after that Théodwyn died of illness. Théoden raised her two children after her death.</p>
<h4>Etymology</h4>
<p>Théodwyn is Old English for 'joy of the people'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Theodwyn";
            ImageArtist = Artist.Mila_Pesic;

            addFamily("Thengel (Father)", "Thengel");
            addFamily("Théoden (Husband)", "Theoden");
            addFamily("Théodred (Son)", "Theodred");

            LotRCard("Theodwyn-CoE");
        }
    }
}