using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class ForlongCharacter : Character
    {
        public ForlongCharacter()
            : base("Forlong", "Forlong", "Man")
        {
            Bio =
@"<blockquote>
&ldquo;True heart, true friend! Forlong!&rdquo;
<br>― People of Minas Tirith
</blockquote>
<p>Forlong was the Lord of Lossarnach during the War of the Ring.</p>
<h4>History</h4>
<p>Forlong was famed for both his girth and his vitality at old age, which led the people of Minas Tirith to refer to him as both 'Forlong the Fat' and 'Forlong the Old'.</p>
<p>Forlong rode to the aid of Minas Tirith with two hundred of his men. His men bore great battle-axes and were well-armed. Forlong fought bravely in the Battle of the Pelennor Fields, but the opposition proved too strong. With all his men and his horse fallen around him, Forlong was killed. He was remembered in the Song of the Mounds of Mundburg.</p>
<h4>Etymology</h4>
<p>Forlong was a Pre-Númenórean name of unknown meaning.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Forlong";
            ImageArtist = Artist.Jan_Pospisil;

            Alias("Lord of Lossarnach");
            Alias("Forlong the Fat");
            Alias("Forlong the Old");

            addFriend("Hirluin the Fair", "Hirluin-the-Fair");

            addGroup("Gondor", "Gondor");

            Card("Forlong-TDF");
        }
    }
}