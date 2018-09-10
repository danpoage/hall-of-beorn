using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class IorethCharacter : Character
    {
        public IorethCharacter()
            : base("Ioreth", "Ioreth", "Man")
        {
            Bio =
@"<p>Ioreth was a woman of Gondor during the War of the Ring.</p>
<h4>History</h4>
<p>Ioreth was originally from Imloth Melui in Lossarnach, but moved to Minas Tirith and worked in the Houses of Healing. By T.A. 3019 she was the oldest woman working there and was well versed in old lore, which helped restore the health of Faramir. She was very talkative, which annoyed Aragorn and Gandalf.</p>
<h4>Etymology</h4>
<p>Ioreth means 'old woman' in Sindarin; iaur 'old' plus feminine ending -eth. In draft, Tolkien had spelt her name Yoreth.</p>
<p>Like 'Gamling', it was specifically chosen to suit the character of the old nurse.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Ioreth";
            ImageArtist = Artist.Christina_Wald;

            addGroup("Gondor", "Gondor");

            LotRCard("Ioreth-ASoCH");
            LotRCard("Ioreth-TPLES");
        }
    }
}