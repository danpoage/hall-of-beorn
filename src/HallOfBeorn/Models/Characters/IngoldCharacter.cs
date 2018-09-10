using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class IngoldCharacter : Character
    {
        public IngoldCharacter()
            : base("Ingold", "Ingold", "Man")
        {
            Bio =
@"<p>Ingold was a soldier of Gondor during the War of the Ring.</p>
<h4>History</h4>
<p>On the road that passed northward from Minas Tirith into Rohan, at the point where it passed through the encircling wall of the Rammas Echor, a guard of Gondorians was posted . Their leader was Ingold, by whose permission Gandalf and Pippin entered the town-lands of Minas Tirith on their journey southwards from Rohan.</p>
<p>Days after Gandalf had passed, an army out of the east crossed the River Anduin and descended on Ingold's position. He retreated with his men back to the city, reporting that the northern road had fallen into the hands of the enemy. This was woeful news in Minas Tirith, because it was thought to mean that the Rohirrim could not come to their aid.</p>
<h4>Etymology</h4>
<p>Ingoldo, or i Ñoldo, was Finrod's mothername. It became a frequent given name in Númenor, and in the Third Age it was shortened to Ingold under influence of Westron.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Ingold";
            ImageArtist = Artist.Owen_William_Weber;

            addGroup("Gondor", "Gondor");

            LotRCard("Ingold-TWoE");
        }
    }
}