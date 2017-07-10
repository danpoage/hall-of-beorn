using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class TheodredCharacter : Character
    {
        public TheodredCharacter()
            : base("Théodred", "Théodred, son of Théoden", "Man")
        {
            Bio =
@"<p>Théodred is a fictional character in The Lord of the Rings by J.R.R. Tolkien. He is the only son and heir of King Théoden of Rohan.</p>
<p>His mother, Elfhild, died in childbirth. Théodred grew up together with his cousin Éomer. Afterwards Théodred was slain in the First Battle of the Fords of Isen.</p>
<p>Little else is known about Théodred, except that he loved Éomer like a brother, and the only person he loved more than Éomer was his father, Théoden.</p>
<p>Théodred held the title of Second Marshal of the Mark, and was slain in the First Battle of the Fords of Isen defending the islet in the middle of the ford. With no siblings, this made his cousin, Éomer, heir to the throne of Rohan.</p>
<p>Théodred's name is probably taken from the Anglo-Saxon words 'þeod' ('folk', 'people', 'nation') and 'ræd' ('counsel).</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Th%C3%A9odred";
            ImageArtist = Artist.Jarreau_Wimberly;

            Alias("Second Marshal of the Riddermark");

            addFamily("Théoden (Father)", "Theoden");
            addFamily("Elfhild (Mother)");
            addFamily("Éomund (Uncle)", "Eomund");
            addFamily("Théodwyn (Aunt)");
            addFamily("Éomer (Cousin)", "Eomer");
            addFamily("Éowyn (Cousin)", "Eowyn");

            addGroup("The Rohirrim", "The-Rohirrim");

            Card("Theodred-Core");
        }
    }
}