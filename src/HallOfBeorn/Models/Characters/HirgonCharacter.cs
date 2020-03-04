using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class HirgonCharacter : Character
    {
        public HirgonCharacter()
            : base("Hirgon", "Hirgon", "Man")
        {
            Bio =
@"<p>Hirgon was an emissary of Gondor who presented the Red Arrow to Théoden King of Rohan.</p>
<p>Hirgon had set out on the command of Denethor, Steward of Gondor, with a companion, and narrowly escaped Orcs in Anórien's woods. He presented the Arrow on 9 March T.A. 3019[2] and rode back toward Minas Tirith the next day.</p>
<p>Hirgon and his companion were caught by Sauron's forces at the Rammas Echor, and were slain before they could reach the White City. When Théoden' Riders found their bodies, Théoden understood that Denethor did not receive his message that the Riders were coming for help.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Hirgon";
            ImageArtist = Artist.Aleksander_Karcz;

            addFriend("Denethor", "Denethor");
            addFriend("Théoden", "Theoden");

            addGroup("Gondor", "Gondor");

            addItem("The Red Arrow", "The-Red-Arrow-BtS");
        }
    }
}
