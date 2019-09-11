using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class AngborTheFearlessCharacter : Character
    {
        public AngborTheFearlessCharacter()
            : base("Angbor the Fearless", "Angbor the Fearless", "Man")
        {
            Bio =
@"<p><b>Angbor the Fearless</b> was the Lord of Lamedon at the time of the War of the Ring.</p>
<h4>History</h4>
<p>On 11 March, T.A. 3019, Angbor led the men of Lamedon in a fight against invaders from Umbar and Harad who sought to capture Linhir and the fords of the River Gilrain. However, the battle halted and all the men of both sides fled upon the arrival of Aragorn with the Army of the Dead - all save Angbor who alone had the heart to face them. Aragorn bade Angbor to gather his folk and follow him to Pelargir where &ldquo;the Heir of Isildur will have need of you.&rdquo;</p>
<p>As Aragorn pressed on to Pelargir, Angbor mustered as many horsemen as he could, helped by the fast-spreading rumour of the return of the Heir of Isildur. His force arrived at the riverside city on 13 March after the Shadow Host had cleared the ships. Afterwards, as Aragorn, Gimli, Legolas, the Grey Company, and the freed men of Gondor rowed north upon the Anduin, Angbor led his horsemen north by land.</p>
<p>In the debate on 16 March before the march to the Morannon, Imrahil expressed concern for the defense of Gondor. Aragorn assured him that new strength was on the way, stating that Angbor, whom he named &ldquo;the fearless&rdquo;, was marching with 4,000 men through Lossarnach. Angbor's strength would be nearing Minas Tirith as Aragorn departed, thus leaving the city with a better defense than when the assault began.</p>
<h4>Etymology</h4>
<p>Angbor means &ldquo;Iron Fist&rdquo;, from ang = &ldquo;iron&rdquo; and paur = &ldqou;fist, hand&rdquo;.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Angbor_the_Fearless";
            ImageArtist = Artist.Suzanne_Helmigh;

            Alias("Lord of Lamedon");
            addFriend("Aragorn", "Aragorn");
            addGroup("Gondor", "Gondor");

            LotRCard("Angbor-the-Fearless-TCoU");
        }
    }
}