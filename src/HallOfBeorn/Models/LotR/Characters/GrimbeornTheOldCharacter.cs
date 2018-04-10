using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class GrimbeornTheOldCharacter : Character
    {
        public GrimbeornTheOldCharacter()
            : base("Grimbeorn the Old", "Grimbeorn the Old", "Skin-Changer")
        {
            Bio =
@"<p>Grimbeorn the Old was the son of Beorn.</p>
<h4>History</h4>
<p>Grimbeorn became a great lord in his own right. Like his father, he was the chieftain of the Beornings and he dwelt in the same regions of the Vales of Anduin. During his time, the High Pass and the Ford of Carrock were kept open and no Orc or Wolf dared to enter his land.</p>
<h4>Etymology</h4>
<p>While Beorn is a word related to 'bear', Grim (like in modern English) means 'fierce', therefore his name can be translated as 'Fierce bear'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Grimbeorn";
            ImageArtist = Artist.Diego_Gisbert_Llorens;

            Alias("Chieftain of the Beornings");

            addFamily("Beorn (Father)", "Beorn");

            Card("Grimbeorn-the-Old-TWH");
            Card("Grimbeorn-the-Old-CatC");
        }
    }
}