using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class LilyCottonCharacter
        : Character
    {
        public LilyCottonCharacter()
            : base("Lily Cotton", "Lily Cotton", "Hobbit")
        {
            Bio =
@"<p>Lily Cotton (née Brown) was the wife of Farmer Cotton.</p>
<h3>History</h3>
<p>Lily married Tolman Cotton of Bywater. Together, they had five children: Young Tom, Rose, Jolly, Nick and Nibs.</p>
<h3>Etymology</h3>
<p>Like many female hobbits, Lily was named after a flower.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Lily_Cotton";
            ImageArtist = Artist.Unknown;

            addGroup("The Shire", "The-Shire");

            addFamily("Tom Cotton (Husband)", "Tom-Cotton");
            addFamily("Rosie Cotton (Daughter)", "Rosie-Cotton");
            addFamily("Young Tom (Son)", "Young-Tom");
            addFamily("Jolly (Son)");
            addFamily("Nick (Son)");
            addFamily("Nibs (Son)");
            addFamily("Sam Gamgee (Son in Law)", "Sam-Gamgee");

            LotRCard("Lily-Cotton-TAP");
        }
    }
}