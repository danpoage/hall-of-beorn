using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class GimliCharacter : Character
    {
        public GimliCharacter()
            : base("Gimli", "Gimli", "Dwarf")
        {
            Bio =
@"<p>Gimli is a fictional character from J. R. R. Tolkien's Middle-earth legendarium, featured in The Lord of the Rings. A dwarf warrior, he is the son of Glóin (a character from Tolkien's earlier novel, The Hobbit).</p>
<p>Gimli is chosen to represent the race of Dwarves in the Fellowship of the Ring. As such, he is one of the primary characters of the novel. In the course of the adventure, Gimli aids the Ring-bearer, participates in the War of the Ring, and becomes close friends with Legolas, overcoming an ancient enmity of Dwarves and Elves.</p>
<p>Gimli was a member of Durin's Folk who volunteered to accompany Frodo Baggins as a member of the Fellowship of the Ring on the quest to destroy the One Ring. He was an honourable, wise, and stalwart warrior.</p>
<p>Gimli became deeply enamoured upon meeting the elf-lady Galadriel, and he forged a friendship with the elf Legolas despite his original hostility (due to the fact that Thranduil, Legolas's father, had once incarcerated Glóin, Gimli's father, one of the company of Thorin Oakenshield in The Hobbit). These relationships helped rehabilitate the long-troubled relationship between Elves and Dwarves of Middle-earth.</p>";

            BioSourceUrl = "https://en.wikipedia.org/wiki/Gimli_(Middle-earth)";
            ImageArtist = Artist.Magali_Villeneuve;

            addFamily("Glóin (Father)", "Gloin");

            addFriend("Legolas", "Legolas");

            addGroup("The Council of Elrond", "The-Council-of-Elrond");
            addGroup("The Fellowship", "The-Fellowship");
            addGroup("The Three Hunters");

            Card("Gimli-Core");
            Card("Gimli-ToS");
            Card("Gimli-TRoB");
            Card("Gimli-TSoH");
        }
    }
}