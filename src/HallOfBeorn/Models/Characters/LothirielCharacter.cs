using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class LothirielCharacter : Character
    {
        public LothirielCharacter()
            : base("Lothíriel", "Lothíriel", "Man")
        {
            Bio =
@"<p><b>Lothíriel</b> was the daughter of Prince Imrahil of Dol Amroth, and later the wife of King Éomer of Rohan.</p>
<h4>History</h4>
<p>Lothíriel was born in T.A. 2999. She had three older brothers: Elphir, Erchirion, and Amrothos.</p>
<p>Lothíriel married Éomer, King of Rohan, in T.A. 3021. They had at least one son named Elfwine the Fair who became the 19th King of Rohan on the death of his father in Fo.A. 63. Whether she still lived by that date, or died after, is unknown.</p>
<h4>Etymology</h4>
<p>Lothíriel may mean &ldquo;flower garlanded maiden&rdquo;. The word loth means &ldquo;flower, blossom&rdquo;. The element riel means &ldquo;garlanded maiden&rdquo;, as also seen in Galadriel.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Lothiriel";
            ImageArtist = Artist.Alvaro_Calvo_Escudero;

            Alias("Queen Consort of Rohan");

            addFamily("Éomer (Husband)", "Eomer");
            addFamily("Prince Imrahil (Father)", "Prince-Imrahil");
            addFamily("Éowyn (Sister by Marriage)", "Eowyn");
            addFamily("Elphir (Brother)");
            addFamily("Erchirion (Brother)");
            addFamily("Amrothos (Brother)");
            addFamily("Elfwine the Fair (Son)");

            addGroup("Gondor", "Gondor");
            addGroup("Rohan", "Rohan");
        }
    }
}
