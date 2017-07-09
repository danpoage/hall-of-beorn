using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class MerryCharacter : Character
    {
        public MerryCharacter()
            : base("Merry", "Meriadoc Brandybuck", "Hobbit")
        {
            Bio =
@"<p>Meriadoc Brandybuck, usually referred to as Merry, is a fictional character from J. R. R. Tolkien's Middle-earth legendarium, featured throughout his most famous work, The Lord of the Rings.</p>
<p>A lover of boats and maps, Merry is described as one of the closest friends of Frodo Baggins, the main protagonist. Merry is a member of the Fellowship of the Ring. He shares a close association with Peregrin Took (Pippin), another Hobbit who accompanies Frodo as a member of the Fellowship. Merry and Pippin become separated from the rest of the group at the breaking of the Fellowship and spend much of The Two Towers with their own story line. By the time of The Return of the King, he has enlisted in the army of Rohan as an esquire to King Theoden, in whose service he fights several battles during the War of the Ring. Upon the conclusion of the war, he returns to The Shire with his friend Pippin, where in time he inherited the title of Master of Brandybuck. He died and was interred in Gondor as a hero of the War of the Ring.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Meriadoc_Brandybuck";
            ImageArtist = Artist.Romana_Kendelic;

            Alias("Kalimac Brandagamba");
            Alias("Meriadoc the Magnificent");
            Alias("Master of Buckland");
            Alias("Holdwine of the Mark");

            addFamily("Frodo Baggins (Cousin)", "Frodo-Baggins");

            addFriend("Treebeard", "Treebeard");
            addFriend("Quickbeam", "Quickbeam");
            addFriend("Pippin", "Pippin");
            addFriend("Éowyn", "Eowyn");

            addGroup("The Fellowship", "The-Fellowship");

            addItem("Dagger of Westernesse", "Dagger-of-Westernesse-TBR");
            addItem("Hobbit Pony", "Hobbit-Pony-TWoE");

            Card("Merry-TBR");
            Card("Merry-TWoE");
        }
    }
}