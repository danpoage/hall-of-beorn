using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class YoungTomCharacter
        : Character
    {
        public YoungTomCharacter()
            : base("Young Tom", "Tolman Cotton (The Younger)", "Hobbit")
        {
            Bio =
@"<p>Tolman &ldquo;Tom&rdquo; Cotton, Jr was the eldest son of Farmer Cotton.</p>
<h3>History</h3>
<p>When Tom was young, he was known as &ldquo;Young Tom&rdquo; to distinguish him from his father with whom they had the same name. Father and son fought in the Battle of Bywater. After the War of the Ring, he married Sam Gamgee's youngest sister, Marigold.</p>
<p>He briefly served as Deputy-Mayor in S.R. 1442, when Sam traveled to Gondor.</p>
<h3>Etymology</h3>
<p>Tolman comes from Old English tōl + mann meaning &ldquo;tool person&rdquo;. In early phases of writing Appendix F, his father's original Westron name was given as Tomacca Lothran or (earlier) Tomakli Lothron.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Tolman_Cotton_Junior";
            ImageArtist = Artist.Unknown;

            Alias("Young Tom");

            addGroup("The Shire", "The-Shire");

            addFamily("Tom Cotton (Father)", "Tom-Cotton");
            addFamily("Lily Cotton (Mother)", "Lily-Cotton");
            addFamily("Rosie Cotton (Sister)", "Rosie Cotton");
            addFamily("Jolly (Brother)");
            addFamily("Nick (Brother)");
            addFamily("Nibs (Brother)");
            addFamily("Sam Gamgee (Brother in Law)", "Sam-Gamgee");

            LotRCard("Young-Tom-TAP");
        }
    }
}