using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class GafferGamgeeCharacter : Character
    {
        public GafferGamgeeCharacter()
            : base("Gaffer Gamgee", "Hamfast Gamgee", "Hobbit")
        {
            Bio =
@"<blockquote>&ldquo;Elves and Dragons! Cabbages and potatoes are better for me and you.&rdquo;<br>
&ndash;The Gaffer</blockquote>
<p><b>Hamfast Gamgee</b>, better known as the <b>Gaffer</b>, was a Hobbit of the Shire, and the father of Samwise Gamgee.</p>
<h3>History</h3>
<p>Hamfast was born in 2926, the third son of Hobson Gamgee, who was a roper by trade.</p>
<p>He entered the service of his relative, Holman Greenhand, and became a gardener. One of his first jobs was tending the garden of Bag End. On 22 June, T.A. 2942, he and Holman tried frantically to keep the garden in order during the auction of the presumed-dead Bilbo Baggins. It is likely that at this time he already lived at Number 3, Bagshot Row.</p>
<p>Hamfast became a gardener in his own right in about T.A. 2960[3], and a local expert on potatoes. He married Bell Goodchild, and they had six children: Hamson, Halfred, Daisy, May, Samwise and Marigold. Sam became Hamfast's apprentice.</p>
<p>Sam took over most of his father's work, who had become too old for the laborous work. He became known as the &ldquo;Gaffer&rdquo;, a name Sam uses more often than &ldquo;Hamfast&rdquo;.</p>
<p>Prior to the Farewell Party, the Gaffer entertained a crowd at the Ivy Bush. Always a man of loquacity and knowledge, he argued with Sandyman, Old Noakes and Ham's neighbor Daddy Twofoot about the Bagginses and the Sackville-Bagginses.</p>
<p>On 22 September, T.A. 3018, the night of the departure of Frodo and Sam from the Shire, Khamûl, one of the Nazgûl rode up the lane, and asked the elderly hobbit about &ldquo;Baggins&rdquo;. A week later, he was visited by Gandalf who also informed about Frodo's whereabouts.</p>
<p>When Lotho and eventually Sharkey took over the Shire, the Gaffer was evicted from Bagshot Row. After the Battle of Bywater, in which he only had a marginal role, he moved back into the newly restored New Row, while Sam moved into Bag End. He was looked after by the Widow Rumble, and died in Fourth Age 7.</p>
<p>His son, Sam, named his seventh child Hamfast after his father.</p>
<h3>Etymology</h3>
<p>The name Hamfast means &ldquo;Stay-at-home&rdquo;, or literally, &ldquo;Home-fast&rdquo;. It is a translation of his Westron name, Ranugad Galbasi.[7] In the King's Letter, the name (referring to Hamfast Gardner, not the Gaffer) is translated into Sindarin as Baravorn.</p>
<p>&ldquo;Gaffer&rdquo; is a colloquial word for &ldquo;old man&rdquo;.</p>
<h3>Other Stories</h3>
<p>In the illustrated short story Mr. Bliss, there is a resident in the village named Gaffer Gamgee who struggles to listen to the discussion between Mr Binks and Sergeant Boffin about whether Mr Bliss should be locked up for failure to pay for his car. Sergeant Boffin also has a son named Sam.</p>
<h3>Inspiration</h3>
<p>In Letter 257, J.R.R. Tolkien recounts a holiday to Lamorna Cave in the early 1930's. To amuse his sons, he named a local Gaffer Gamgee. This &ldquo;curious local character&rdquo; was &ldquo;an old man who used to go about swapping gossip and weather-fashion and such like&rdquo;. The surname was chosen because it alliterated with Gaffer.</p>
<p>Tolkien had several encounters with actual Gamgees, however. Gamgee Tissue, a word young Ronald considered comical, was named after J. Sampson Gamgee (1828-1886), a famous Birmingham surgeon,[10] whilst in the Black Country dialect cotton wool was referred to as &ldquo;gamgee&rdquo;. The Gamgees were notorious surgeons - years later, Dr. Leonard Gamgee tended those war-wounded, including Lieutenant Tolkien.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Gaffer";
            ImageArtist = Artist.Romana_Kendelic;

            TheFellowshipOfTheRing();
            TheReturnOfTheKing();

            addGroup("The Shire", "The-Shire");

            addFamily("Sam Gamgee (Son)", "Sam-Gamgee");
            addFriend("Frodo Baggins", "Frodo-Baggins");

            LotRCard("Gaffer-Gamgee-MG");
        }
    }
}