using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class DainIronfootCharacter : Character
    {
        public DainIronfootCharacter()
            : base("Dáin Ironfoot", "Dáin II Ironfoot", "Dwarf")
        {
            Bio = 
@"<p>Dáin II Ironfoot is a Dwarf and king of Erebor in J. R. R. Tolkien's high fantasy legendarium concerning Middle-earth. He appears briefly in The Hobbit and his story is elaborated in Appendix A of The Lord of the Rings.</p>
<p>Dáin, one of the greatest dwarven warriors, was the son of Náin and grandson of Grór, the youngest son of Dáin I of Durin's folk. Following his grandfather's death, Dáin became lord of the Dwarves of the Iron Hills in Wilderland. Dáin's father Náin was killed by the great Orc Azog during the Battle of Nanduhirion before the gates of Moria, the culmination of the War of the Dwarves and Orcs. Dáin avenged Náin, slaying Azog in single combat. He was a very young Dwarf at the time (only 32, roughly when Dwarves reach maturity, or 'battle-readiness'),[1] and this was heralded as a magnificent feat. Dáin alone looked past the gate into Moria, and knew that it was impossible for the Dwarves to return at that time, because Durin's Bane still resided in those halls. He dissuaded Thráin II from attempting to occupy Moria.</p>
<p>Dáin was second cousin to Thorin Oakenshield, and responded to Thorin's call for help during the quest to reclaim Erebor. Dáin set out with several hundred Dwarves, and arrived just in time for the Battle of Five Armies. Thorin was mortally wounded in this battle, and after his death and the extinction of the main branch of Durin's line, Dáin succeeded Thorin as King under the Mountain and King of Durin's folk, the first not in the direct line of Durin.</p>
<p>Dáin was killed during the War of the Ring in T.A. 3019, defending the body of his ally King Brand of Dale before the gates of Erebor. He was by then an old Dwarf – aged 252 according to Appendix A in The Lord of the Rings – but his prowess in battle was still great. After the war he was succeeded by his son, Thorin III Stonehelm.[2]</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/D%C3%A1in_II_Ironfoot";
            ImageArtist = Artist.Olga_G;

            Alias("King Under the Mountain", "King-Under-the-Mountain-THOtD");
            Alias("King of Durin's Folk");

            addFamily("Náin (Father)");
            addFamily("Thorin III Stonehelm (Son)");
            addFamily("Thorin II Oakenshield (Cousin)", "Thorin-Oakenshield");

            addFriend("Brand son of Bain", "Brand-son-of-Bain");
            addFriend("Balin", "Balin");
            addFriend("Glóin", "Gloin");

            Card("Dain-Ironfoot-RtM");
        }
    }
}