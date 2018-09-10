using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters.Groups
{
    public class ThorinsCompanyGroup : CharacterGroup
    {
        public ThorinsCompanyGroup()
            : base("Thorin's Company", "Thorin's Company")
        {
            Bio =
@"<p><b>Thorin and Company</b> refers to the thirteen exiled Dwarves under the leadership of Thorin Oakenshield and the one Hobbit Bilbo Baggins, who famously made the Quest of Erebor, travelling through the Misty Mountains and the Wilderland to the Lonely Mountain, to recover their ancient treasure from the Kingdom of Erebor, stolen by the Dragon Smaug.</p>
<p>Thorin's company were:</p>
<ul>
<li>Balin and Dwalin, descendants of Náin II</li>
<li>Óin and Glóin, cousins of Balin and Dwalin</li>
<li>Fíli and Kíli, nephews of Thorin</li>
<li>Dori, Nori, and Ori, Dwarves of the House of Durin</li>
<li>Bifur, Bofur, and Bombur, descendants of the Dwarves of Moria</li>
<li>And Bilbo Baggins, a Hobbit of the Shire</li>
</ul>
<p>They were joined by Gandalf for part of the journey.</p>
<p>Thorin referred to himself and his Dwarven companions as 'Thorin and Company' in the opening line of the message left on Bilbo's mantelpiece after the unexpected party at Bag End.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Thorin_and_Company";
            ImageArtist = Artist.David_T_Wenzel;

            Alias("Thorin and Company");
            Alias("The Quest of Erebor");

            addLeader("Thorin Oakenshield", "Thorin-Oakenshield");

            addMember("Gandalf", "Gandalf");
            addMember("Bilbo Baggins", "Bilbo-Baggins");
            addMember("Balin", "Balin");
            addMember("Bifur", "Bifur");
            addMember("Bofur", "Bofur");
            addMember("Bombur", "Bombur");
            addMember("Dori", "Dori");
            addMember("Dwalin", "Dwalin");
            addMember("Fili", "Fili");
            addMember("Glóin", "Gloin");
            addMember("Kili", "Kili");
            addMember("Nori", "Nori");
            addMember("Óin", "Ori");
            addMember("Ori", "Ori");
            
            LotRCard("A-Very-Good-Tale-THOHaUH");
            LotRCard("To-me-O-my-kinsfolk-THOtD");
            LotRCard("Desperate-Alliance-THOtD");
        }

    }
}