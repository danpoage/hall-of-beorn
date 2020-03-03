using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class BardSonOfBrandCharacter : Character
    {
        public BardSonOfBrandCharacter()
            : base("Bard son of Brand", "Bard, son of Brand", "Man")
        {
            Bio = "<p>Bard II was the son of Brand and heir to the Kingdom of Dale. His father was slain in the Battle of Dale, and Bard was forced back to Erebor, where he was besieged with his ally Thorin III Stonehelm for several days. When news came from the south of the destruction of Sauron, Bard and Thorin emerged from the Lonely Mountain and broke the siege. Later he sent an ambassador to the crowning of King Elessar and thereafter his kingdom enjoyed the protection of the King of the West.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Bard_II";
            ImageArtist = Artist.Rankin_Bass;

            Alias("Bard II");
            Alias("King of Dale", "King-of-Dale-TWoR");

            addFamily("Bard the Bowman (Great Grandfather)", "Bard-the-Bowman");
            addFamily("Bain (Grandfather)");
            addFamily("Brand son of Bain (Father)", "Brand-son-of-Bain");

            addFriend("Aragorn (King Elessar)", "Aragorn");
            addFriend("Thorin III Stonhelm");
        }
        
    }
}