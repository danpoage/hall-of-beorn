using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class EomundCharacter : Character
    {
        public EomundCharacter()
            : base("Éomund", "Éomund", "Man")
        {
            Bio =
@"<p>Éomund was the Lord of Aldburg and a Marshal of the Mark.</p>
<h4>History</h4>
<p>Éomund was a descendant of Eofor, and dwelt in Aldburg. He married Théodwyn, the sister of the later King Théoden. Their children were Éomer and Éowyn, who were each to play a great part in the War of the Ring.</p>
<p>A man from Eastfold, he was a dedicated marshal in charge of the east marches, mainly defending the regin against Orcish raids.</p>
<p>Éomund himself was slain in battle with Orcs in the Emyn Muil in T.A. 3002. Théodwyn grew ill and died shortly after, and their children were raised by Théoden.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Eomund";
            ImageArtist = Artist.Katherine_Dinger;

            Alias("First Marshal of the Riddermark");
            Alias("Lord of Aldburg");

            addFamily("Théodwyn (Wife)");
            addFamily("Éomer (Son)", "Eomer");
            addFamily("Éowyn (Daughter)", "Eowyn");
            addFamily("Théoden (Brother-in-Law)", "Theoden");
            addFamily("Théodred (Nephew)", "Theodred");

            addGroup("The Rohirrim", "The-Rohirrim");
        }
    }
}
