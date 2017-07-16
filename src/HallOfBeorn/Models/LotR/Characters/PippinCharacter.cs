using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class PippinCharacter : Character
    {
        public PippinCharacter()
            : base("Pippin", "Peregrin Took", "Hobbit")
        {
            Bio = "<p>Peregrin Took, more commonly known as Pippin, is a fictional character from J. R. R. Tolkien's fantasy novel The Lord of the Rings. He is closely tied with his friend and cousin, Meriadoc Brandybuck (Merry), the two are usually together during most of the story. Pippin and Merry are introduced as a pair of young hobbits who become ensnared in fellow hobbit Frodo Baggins's quest to destroy the One Ring. In this regard, Pippin is a member of the Fellowship of the Ring. He and Merry become separated from the rest of the group at the breaking of the Fellowship and spend much of The Two Towers with their own story line. Impetuous and curious, he enlists (in The Return of the King) as a soldier in the army of Gondor and fought in several battles during the War of the Ring. In the epilogues to the main story, Pippin returns to the Shire and becomes Thain or hereditary leader of the land before dying and being buried as a hero in Gondor.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Peregrin_Took";
            ImageArtist = Artist.Tony_Foti;

            Alias("Pippin");
            Alias("Pip");
            Alias("Ernil i Pheriannath");
            Alias("Thain Peregrin I");
            Alias("Razanur Tûk");

            addFamily("Frodo Baggins (Cousin)", "Frod-Baggins");

            addFriend("Treebeard", "Treebeard");
            addFriend("Quickbeam", "Quickbeam");
            addFriend("Beregond", "Beregond");
            addFriend("Bergil");

            addGroup("The Fellowship", "The-Fellowship");

            addItem("Dagger of Westernesse", "Dagger-of-Westernesse-TBR");
            addItem("Hobbit Pony", "Hobbit-Pony-TWoE");

            Card("Pippin-TBR");
            Card("Pippin-EaAD");
        }
    }
}