using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class DunhereCharacter : Character
    {
        public DunhereCharacter()
            : base("Dúnhere", "Dúnhere", "Man")
        {
            Bio =
@"<p>In J. R. R. Tolkien's Middle-earth legendarium, Dúnhere was the lord of Harrowdale in Rohan (Middle-earth) and Chieftain of the folk of Dunharrow. He is a nephew of Erkenbrand.</p>
<p>He appears in The Return of the King, the third volume of the fantasy novel The Lord of the Rings as originally published. He also appears in the posthumously published Unfinished Tales, as the captain of the riders that allowed their companions to escape of the siege of the uruk-hai during the Battles of the Fords of Isen. There he fought alongside Théodred and Grimbold.</p>
<p>He was not in the siege of Helm's Deep because he had been ordered to gather the Muster of Rohan in Dunharrow by Gandalf, whom he trusted as he was riding Shadowfax, one of the mearas. He received King Théoden when he came to the dale after the battle. He was also at his pavilion when the messenger from Gondor came asking for their aid.</p>
<p>In the Battle of the Pelennor Fields he fought in the éored of Grimbold. He died there, as well as his marshal and other well known warriors, whose names appear in the Song of the Mounds of Mundburg.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/D%C3%BAnhere";
            ImageArtist = Artist.Jeff_Himmelman;

            TheReturnOfTheKing();
            UnfinishedTales();

            Alias("Lord of Harrowdale");
            Alias("Chieftain of the folk of Harrowdale");

            addFamily("Erkenbrand (Uncle)", "Erkenbrand");

            addFriend("Théodred", "Theodred");
            addFriend("Grimbold", "Grimbold");

            addGroup("The Rohirrim", "The-Rohirrim");

            Card("Dunhere-Core");
        }
    }
}