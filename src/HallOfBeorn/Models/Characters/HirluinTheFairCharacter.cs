using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class HirluinTheFairCharacter : Character
    {
        public HirluinTheFairCharacter()
            : base("Hirluin the Fair", "Hirluin the Fair", "Man")
        {
            Bio =
@"<p>Hirluin the Fair or Hirluin of the Green Hills was the leader of the people of the Green Hills during the War of the Ring.</p>
<p>He was one of the many leaders of Men who brought companies to Minas Tirith; in his contingent were three hundred gallant green-clad men. A week later, he fought in the Battle of the Pelennor Fields, rushing to the aid of Éomer and the Rohirrim, in the van with Imrahil of Dol Amroth, Húrin of the Keys and Forlong of Lossarnach. He was slain on the fields before the City.</p>
<p>The name Hirluin is composed of the two elements hîr 'lord' and luin 'pale, fair' (and by extension 'blue').</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Hirluin_the_Fair";
            ImageArtist = Artist.Tony_Foti;

            Alias("Hirluin of the Green Hills");
            Alias("Lord of Morthond", "Lord-of-Morthond-EaAD");

            addFriend("Forlong", "Forlong");

            addGroup("Gondor", "Gondor");

            addItem("Sword of Morthond", "Sword-of-Morthond-AoO");
        }
    }
}
