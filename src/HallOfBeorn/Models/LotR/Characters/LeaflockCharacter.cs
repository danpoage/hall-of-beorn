using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class LeaflockCharacter : Character
    {
        public LeaflockCharacter()
            : base("Leaflock", "Leaflock", "Ent")
        {
                        Bio =
@"<p>Leaflock, called Finglas in Sindarin, was one of the Ents of Fangorn Forest. Finglas, Fladrif, and Fangorn, were the oldest of the Ents of Fangorn Forest still alive in the later Third Age.</p>
<p>According to Treebeard, Leaflock had become tired, sometimes sleeping through entire seasons (although formerly he used to rouse up in winter), and tree-like with a covering of leafy hair.</p>
<h4>Etymology</h4>
<p>The name Finglas is apparently composed by the two elements fing/find 'lock of hair' and las 'leaf'.</p>
<p>The element lock in Leaflock here has the meaning of 'hair' since it is a translation of his Sindarin name.</p>
<p>The name obviously refers to his being 'Covered with leafy hair'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Leaflock";
            ImageArtist = Artist.Mike_Nash;

            addFriend("Treebeard", "Treebeard");

            addGroup("The Ents", "The-Ents");

            Card("Leaflock-DoCG");
        }
    }
}