using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class GloinCharacter : Character
    {
        public GloinCharacter()
            : base("Glóin", "Glóin", "Dwarf")
        {
            Bio =
@"<p>Glóin (T.A. 2783 − Fourth Age 15), son of Gróin, was one of the twelve companions of Thorin and Bilbo Baggins on the Quest of Erebor, as was his older brother Óin. The two brothers were direct descendants of Durin the Deathless. Many years after the Quest, Glóin and his son Gimli were sent to Rivendell as an embassy from King Dáin II to bring news of Erebor, Moria, and what they knew of Sauron's plans; they arrived in time to attend the Council of Elrond.[12] He wears a white hood. The name Gloin is found in the Völuspá.</p>
<p>He was born during the wanderings of the Dwarves following the sack of Erebor, but after the Quest he lived in the restored kingdom virtually the rest of his life.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Middle-earth_dwarf_characters#Gl.C3.B3in.2C_son_of_Gr.C3.B3in";
            ImageArtist = Artist.Jeff_Lee_Johnson;

            addFamily("Gróin (Father)");
            addFamily("Óin (Brother)", "Oin");
            addFamily("Gimli (Son)", "Gimli");

            addFriend("Thorin Oakenshield", "Thorin-Oakenshield");
            addFriend("Bilbo Baggins", "Bilbo-Baggins");

            addItem("Dwarven Shield", "Dwarven-Shield-TSoH");

            addGroup("Thorin's Company", "Thorin's-Company");

            Card("Gloin-Core");
            Card("Gloin-THOtD");
        }
    }
}