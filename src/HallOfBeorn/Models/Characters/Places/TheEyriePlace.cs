using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters.Places
{
    public class TheEyriePlace : CharacterPlace
    {
        public TheEyriePlace()
            : base("The Eyrie", "The Eyrie")
        {
            Bio =
@"<blockquote>&ldquo;The Lord of the Eagles bids you to bring your prisoners to the Great Shelf&rdquo;<br>&ndash;An Eagle</blockquote>
<p><b>The Eagle's Eyrie</b> was a home of the <a href='/Characters/The-Eagles' target='_blank' title='Character Group: The Eagles'>Eagles</a> located on the eastern side of the Misty Mountains. Its exact location is unknown, however it is presumably close to the High Pass and Goblin-town. It was from this location that the Eagles helped the Elves of Rivendell keep watch over the lands east of the Misty Mountains, gathering information about the Orcs in the region.</p>
<h3>History</h3>
<p>In T.A. 2941 the eagles of the eyrie rescued Thorin and Company from the tops of the trees at the Warg's clearing and took them to the Eagle's Eyrie. Here they met the Great Eagle, ate their first food since escaping the Goblins, and spent the night. The next morning the eagles took the company from the Eyrie to the Carrock.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Eagle's_Eyrie";
            ImageArtist = Artist.Matt_Stewart;

            addGroup("The Eagles", "The-Eagles");
            addLeader("Gwaihir", "Gwaihir");
            addMember("Landroval", "Landroval");
            addMember("Meneldor", "Meneldor");

            addFriend("Gandalf", "Gandalf");
            addFriend("Radagast", "Radagast");

            LotRCard("To-the-Eyrie-AJtR");
        }
    }
}