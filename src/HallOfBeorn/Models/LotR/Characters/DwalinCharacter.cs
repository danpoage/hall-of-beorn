using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class DwalinCharacter : Character
    {
        public DwalinCharacter()
            : base("Dwalin", "Dwalin", "Dwarf")
        {
            Bio =
@"<p>Dwalin (T.A. 2772 - Fourth Age 91/92) was one of the twelve companions of Thorin and Bilbo on the Quest of Erebor. He and his older brother, Balin, were the sons of Fundin, and thus of the royal line of Durin. Dwalin was born during the wanderings of his people, following the sack of Erebor. His father was killed in the Battle of Azanulbizar, and three years later (2802) Dwalin and his other surving family settled in the Ered Mithrin (Blue Mountains), where he resided until the Quest of Erebor. In 2841, Dwalin was among those who set out with Thráin II,[8] but they lost Thráin and returned to the Blue Mountains.</p>
<p>A century later, Dwalin embarked on the Quest of Erebor, and he was the first Dwarf to arrive at Bag End. He wore a dark green hood and a golden belt, had a blue beard so long he had to tuck it into his belt, and like his brother Balin, he played the viol. Dwalin lent a hood and cloak to Bilbo when they set out on their journey.</p>
<p>After the Quest he lived the rest of his life in Erebor. There he was fabulously wealthy, a far cry from his early childhood. When he died in the year 91 of the Fourth Age he was aged 340, very old even for a Dwarf.</p>
<p>His name is taken from Dvalin, a dwarf from the Poetic Edda and other Norse mythology.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Middle-earth_dwarf_characters#Dwalin";
            ImageArtist = Artist.Tony_Foti;

            addFamily("Fundin (Father)");
            addFamily("Balin (Brother)", "Balin");

            addFriend("Thorin Oakenshield", "Thorin-Oakenshield");

            addGroup("Thorin's Company", "Thorin's-Company");

            Card("Dwalin-KD");
            Card("Dwalin-THOtD");
        }
    }
}