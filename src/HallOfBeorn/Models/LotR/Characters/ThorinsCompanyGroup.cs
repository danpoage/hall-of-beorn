using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class ThorinsCompanyGroup : CharacterGroup
    {
        public ThorinsCompanyGroup()
            : base("Thorin's Company", "Thorin's Company")
        {
            Bio =
@"<p>Thorin and Company were a group of thirteen Dwarves, the Wizard Gandalf, and the Hobbit Bilbo Baggins, led by Thorin Oakenshield in TA 2941. Their main purpose was to regain the lost Dwarven kingdom of the Lonely Mountain from the Dragon Smaug.</p>
<p>The formation of the group grew out of a meeting Gandalf had with Thorin in Bree which kindled Thorin's interest in recapturing his long lost family inheritance. Remembering that he had once known an adventurous Hobbit on his travels in The Shire, Gandalf decided to add Bilbo to their company because he knew that stealth and cunning were preferable to force. Gandalf also believed that someone like Bilbo could keep the sometimes prideful and stubborn Dwarves from rash action. The superstitious Dwarves also considered thirteen to be an unlucky number, and as Gandalf had planned to leave on other business, welcomed a fourteenth to fill in to their party.</p>";
            BioSourceUrl = "http://lotr.wikia.com/wiki/Thorin_and_Company";
            ImageArtist = Artist.David_T_Wenzel;

            Alias("Thorin and Company");

            addLeader("Thorin Oakenshield", "Thorin-Oakenshield");

            addMember("Gandalf", "Gandalf");
            addMember("Bilbo Baggins", "Bilbo-Baggins");
            addMember("Balin");
            addMember("Bifur", "Bifur");
            addMember("Bofur");
            addMember("Bombur");
            addMember("Dori", "Dori");
            addMember("Dwalin", "Dwalin");
            addMember("Fili");
            addMember("Glóin", "Gloin");
            addMember("Kili");
            addMember("Nori", "Nori");
            addMember("Ori");
            addMember("Óin");
            addMember("Ori");

            Card("A-Very-Good-Tale-THOHaUH");
            Card("Desperate-Alliance-THOtD");
        }

    }
}