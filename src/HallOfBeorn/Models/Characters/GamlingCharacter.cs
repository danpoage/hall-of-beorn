using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class GamlingCharacter : Character
    {
        public GamlingCharacter()
            : base("Gamling", "Gamling", "Man")
        {
            Bio =
@"<p>Gamling (late Third Age) was a man of Rohan, probably Erkenbrand's lieutenant, and the leader of the watchers of Helm's Dike.</p>
<h4>History</h4>
<p>An old man during the War of the Ring, Gamling was still a commanding presence at the time of the Battle of the Hornburg. During the battle Gamling was the first to realize that Orcs had penetrated the Deep through its culvert, and he led the counterattack himself.</p>
<p>Gamling seems to have been brought up in the western valleys of Rohan; he understood the tongue of Dunland that was still spoken in those regions.</p>
<p>When the Deeping Wall was taken, Gamling was one of those swept back into the narrows. When the battle was over Gamling, Éomer, Gimli and others came forth from the caves.</p>
<h4>Etymology</h4>
<p>Gamling translates to 'old man' from the Old English term, 'gamol', meaning 'old, aged, ancient', but only found in Old English in verse-language.</p>
<p>Gamling is somewhat anglicized/modernized while genuinely it should be Gameling. It would be one of the words and names that hobbits recognized as similar to Hobbitish (like Shadowfax or Wormtongue).</p>
<h4>Inspiration</h4>
<p>Tolkien noted that it is the origin of the surnames Gamlen, Gam(b)lin. It appears in the medieval poem The Tale of Gamelin (inspiration of Shakespeare's As You Like It.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Gamling";
            ImageArtist = Artist.Chris_J_Anderson;

            addFriend("Erkenbrand", "Erkenbrand");

            addGroup("The Rohirrim", "The-Rohirrim");
        }
    }
}
