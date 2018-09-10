using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class HalfastGamgeeCharacter : Character
    {
        public HalfastGamgeeCharacter()
            : base("Halfast Gamgee", "Halfast Gamgee", "Hobbit")
        {
            Bio =
@"<p>Halfast 'Hal' Gamgee was a Hobbit of the Shire.</p>
<h4>History</h4>
<p>Hal was the son of Halfred, an uncle of Samwise Gamgee. He worked for Mr. Boffin in Overhill, and often went up in the Northfarthing to hunt.</p>
<p>He had the reputation for his wild stories of things he saw. He reportedly encountered a 'Tree-man' while hunting beyond the North Moors.</p>
<h4>Etymology</h4>
<p>The name likely comes from Old English hālfæst meaning 'hale and firm'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Halfast_Gamgee";
            ImageArtist = Artist.Angela_Rizza;

            Alias("Hal");

            addFamily("Sam Gamgee (Cousin)", "Sam-Gamgee");

            addGroup("Hobbiton");

            LotRCard("Halfast-Gamgee-CoP");
        }
    }
}