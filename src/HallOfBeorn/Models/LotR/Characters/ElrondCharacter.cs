using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class ElrondCharacter : Character
    {
        public ElrondCharacter()
            : base("Elrond", "Elrond Half-elven", "Half-elven")
        {
            Bio =
@"<p>Elrond was Lord of Rivendell, one of the mighty rulers of old that remained in Middle-earth in its Third Age. His name was explained by Tolkien in a letter from 1958 to Rhona Beare as 'Elf of the Cave', as he was found as an infant abandoned in a cave. Later notes, reflected in The Silmarillion and The War of the Jewels, interpret the name instead as 'Star-dome' or 'Vault of Stars' (a vault in the sense of the celestial dome).</p>
<p>Elrond was the son of Eärendil and Elwing, and a great-grandson of Lúthien, born in Beleriand in the First Age, making him well over 6,000 years old by the time of the events described in The Lord of the Rings. Elrond's twin brother was Elros Tar-Minyatur, the first High King of Númenor.</p>
<p>Although Elrond was considered half-elven, that was not meant to be an exact percentage value. Through Lúthien, daughter of Melian the Maia, he and his brother Elros were also descended from the Maiar, angelic beings who had come to Middle-earth thousands of years before. Both his mother and his father had mixed human-elf ancestry, and as a result Elrond himself was 6/16 human, 9/16 elf and 1/16 Maia. Elrond, along with his parents, his brother, and his children, were granted a choice between Elven or human fates by the Valar. Elrond chose to live as an immortal Elf, while his twin Elros chose the mortality of Men.</p>";

            BioSourceUrl = "https://en.wikipedia.org/wiki/Elrond";
            ImageArtist = Artist.Magali_Villeneuve;

            TheHobbit();
            TheFellowshipOfTheRing();
            TheReturnOfTheKing();

            Alias("Half-elven");
            
            addFamily("Eärendil (Father)"); //, "Earendil");
            addFamily("Elwing (Mother)"); //, "Elwing");
            addFamily("Galadriel (Mother-in-Law)", "Galadriel");
            addFamily("Celeborn (Father-in-Law)", "Celeborn");
            addFamily("Elros (Brother)");
            addFamily("Celebrían (Wife)"); //, "Celebrian");
            addFamily("Elladan (Son)", "Elladan");
            addFamily("Elrohir (Son)", "Elrohir");
            addFamily("Arwen Undómiel (Daughter)", "Arwen-Undomiel");
            addFamily("Aragorn (Son-in-Law)", "Aragorn");

            addItem("Vilya", "Vilya-SaF");
            addItem("Message from Elrond", "Message-from-Elrond-TTT");

            addGroup("The White Council", "The-White-Council");
            addGroup("The Council of Elrond", "The-Council-of-Elrond");
            addGroup("The House of Elrond");

            Card("Elrond-SaF");
            Card("Elrond-RD");
        }
    }
}