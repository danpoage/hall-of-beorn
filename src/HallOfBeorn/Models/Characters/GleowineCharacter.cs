using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class GleowineCharacter : Character
    {
        public GleowineCharacter()
            : base("Gléowine", "Gléowine", "Man")
        {
            Bio =
@"<p>Gléowine was a minstrel of the King's House of Rohan in the late Third Age.</p>
<h4>History</h4>
<p>Gléowine composed an immortalizing song about Théoden and his ancestors after the Battle of the Pelennor Fields. It was said that he never composed another song afterwards. Sadly, only the last stanza survived:</p>
<blockquote>
Out of doubt, out of dark, to the day's rising<br/>
he rode singing in the sun, sword unsheathing.<br/>
Hope he rekindled, and in hope he ended;<br/>
over death, over dread, over doom lifted<br/>
out of loss, out of life, unto long glory.
</blockquote>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Gleowine";
            ImageArtist = Artist.Oleksandra_Ishchenko;

            addFriend("Théoden", "Theoden");

            addGroup("The Rohirrim", "The-Rohirrim");

            LotRCard("Gleowine-Core");
        }
    }
}