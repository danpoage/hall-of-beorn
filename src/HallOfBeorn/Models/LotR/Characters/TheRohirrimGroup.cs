using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class TheRohirrimGroup : CharacterGroup
    {
        public TheRohirrimGroup()
            : base("The Rohirrim", "The People of Rohan")
        {
            Bio =
@"<p>Rohan (from Sindarin Rochand) is a kingdom in J. R. R. Tolkien's fantasy setting of Middle-earth. It is mainly a grassland, and lies north-west of its ally Gondor, and further north-west of Mordor, the realm of Sauron, their enemy (see maps of Middle-earth). It is inhabited by the Rohirrim, a people of herdsmen and farmers who are well known for their horses and cavalry. Rohan is also referred to as Riddermark or the 'Mark'. The realm is of significant importance in the author's book, The Lord of the Rings. Much of the background of Rohan is grounded in Anglo-Saxon tradition.</p>
<p>Conceptualised as the 'Horse Lords of Rohan' allied with Gondor in early drafts of 1939, the Rohirrim took their final form in 1942 when about one third of The Lord of the Rings was completed.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Rohan_(Middle-earth)";
            ImageArtist = Artist.Julia_Alekseeva;

            Alias("The Horse Lords of Rohan");

            addLeader("Théoden", "Theoden");

            addMember("Théodred", "Theodred");
            addMember("Éomund", "Eomund");
            addMember("Éomer", "Eomer");
            addMember("Éowyn", "Eowyn");
            addMember("Erkenbrand", "Erkenbrand");
            addMember("Dúnhere", "Dunhere");
            addMember("Háma", "Hama");
            addMember("Elfhelm", "Elfhelm");
            addMember("Gamling", "Gamling");
            addMember("Grimbold", "Grimbold");
            addMember("Fastred", "Fastred");
            addMember("Gríma", "Grima");
            addMember("Gléowine", "Gleowine");

            Card("Mustering-the-Rohirrim-THfG");
            Card("Ride-to-Ruin-THoEM");
            Card("Forth-Eorlingas-TMV");
            Card("Charge-of-the-Rohirrim-CS");
            Card("Ride-Them-Down-TAC");
        }
    }
}