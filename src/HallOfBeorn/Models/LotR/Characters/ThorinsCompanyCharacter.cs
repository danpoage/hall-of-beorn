using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class ThorinsCompanyCharacter : Character
    {
        public ThorinsCompanyCharacter()
            : base("Thorin's Company", "Thorin's Company", string.Empty)
        {
            Bio =
@"<p>Thorin's company consisted of the following 13 dwarves; their quest in The Hobbit is the main impetus of the plot of that story. Their quest was joined by Bilbo Baggins (a hobbit) and occasionally by the wizard Gandalf.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Middle-earth_dwarf_characters#Thorin.27s_Company";
            ImageArtist = Artist.David_T_Wenzel;

            addMember("Thorin-Oakenshield");
            addMember("Gandalf", "Gandalf");
            addMember("Bilbo Baggins", "Bilbo-Baggins");
            addMember("Balin");
            addMember("Bifur");
            addMember("Bofur");
            addMember("Bombur");
            addMember("Dori");
            addMember("Dwalin");
            addMember("Fili");
            addMember("Glóin", "Gloin");
            addMember("Kili");
            addMember("Ori");
            addMember("Óin");
            addMember("Ori");
        }

    }
}