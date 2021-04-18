using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class HerubrandCharacter
        : Character
    {
        public HerubrandCharacter()
            : base("Herubrand", "Herubrand", "Man")
        {
            Bio =
@"<p><b>Herubrand</b> was a man of Rohan during the War of the Ring.</p>
<h4>History</h4>
<p>Herubrand fought and died in the Battle of the Pelennor Fields. His name is remembered in the poem Song of the Mounds of Mundburg.</p>
<h4>Etymology</h4>
<p>Herubrand is Old English for &ldquo;war-sword&rdquo;.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Herubrand";
            ImageArtist = Artist.Tiziano_Baracchi;

            addGroup("Rohan", "Rohan");

            LotRCard("Herubrand-CoE");
        }
    }
}