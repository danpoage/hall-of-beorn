using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class ElfhelmCharacter : Character
    {
        public ElfhelmCharacter()
            : base("Elfhelm", "Elfhelm", "Man")
        {
            Bio =
@"<p>In J. R. R. Tolkien's Middle-earth legendarium, Elfhelm was a lord of Rohan (Middle-earth) and Marshal of the East-mark.</p>
<p>He appears in The Two Towers and The Return of the King, the second and third volumes of the fantasy novel The Lord of the Rings as originally published. He also appears in the posthumously published Unfinished Tales.</p>
<p>During the War of the Ring, he fought in the Battles of the Fords of Isen with Théodred and Grimbold. In the second battle, he and his men were forced to retreat eastward - where he met Gandalf the White, who told him to go to the Edoras, to defend the city. In the Ride of the Rohirrim to Minas Tirith, he tacitly allowed the hobbit Merry to ride with Dernhelm.[1] Later, Elfhelm commanded one of the three éoreds in the Battle of the Pelennor Fields.</p>
<p>While King Éomer was leading a large part of the Rohirrim to the Black Gate, Elfhelm was the commander of the remaining three thousand Rohirrim in Minas Tirith. He defeated the orc army that was invading Gondor from Anórien.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Elfhelm";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Mashal of the East-mark");

            addFriend("Théodred", "Theodred");
            addFriend("Grimbold", "Grimbold");
            addFriend("Éomer", "Eomer");

            addGroup("The Rohirrim", "The Rohirrim");

            Card("Elfhelm-TotD");
            Card("Elfhelm-TDM");
            Card("Elfhelm-TMoF");
        }
    }
}