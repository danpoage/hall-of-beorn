using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class RosieCottonCharacter : Character
    {
        public RosieCottonCharacter()
            : base("Rosie Cotton", "Rose Cotton", "Hobbit")
        {
            Bio = 
@"<p>The Cotton family was a working class family of Hobbits.</p>
<p>Cottar, the founder of the Cotton clan, was born some two hundred years before the War of the Ring. It was his grandson, Holman, who was the first to take the surname Cotton. 'Long Hom', as Holman was known, is also the first of the Cottons to be explicitly connected with the village of Bywater, which remained the seat of the family from that time on.</p>
<p>Holman's son Tolman farmed the lands to the south of Bywater, and it was he who made the family one of the most important in the Shire. He played a significant part in the decisive Battle of Bywater, the most important step in the recovery of the Shire from Sharkey's Men, and his daughter Rose married Samwise Gamgee in the following spring.</p>
<h4>Etymology</h4>
<p>The name Cotton is a real-life English surname and means 'cottage town'.</p>
<p>Thus the name could represent a possible Old Hobbitish Cottun 'town with cottages'.</p>
<p>It is also a translation of the Westron Hlothran, associated with the name Hlothram. Hlothran was 'a fairly common village-name in the Shire', though none is mentioned (or noteworthy enough) on any map.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Cotton_Family";
            ImageArtist = Artist.Sceith_A;

            Alias("Rosie Cotton");

            addGroup("The Shire", "The-Shire");

            addFamily("Tom Cotton (Father)", "Tom-Cotton");
            addFamily("Sam Gamgee (Husband)", "Sam-Gamgee");
            addFamily("Tolman 'the younger' (Brother)");
            addFamily("Wilcome (Brother)");
            addFamily("Bowman (Brother)");
            addFamily("Carl (Brother)");

            Card("Rosie-Cotton-TMoF");
        }
    }
}