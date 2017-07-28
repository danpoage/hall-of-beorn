using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class BoromirCharacter : Character
    {
        public BoromirCharacter()
            : base("Boromir", "Boromir", "Man")
        {
            Bio =
@"<p>Boromir is a fictional character in J. R. R. Tolkien's legendarium. He appears in the first two volumes of The Lord of the Rings (The Fellowship of the Ring and The Two Towers), and is mentioned in the last volume, The Return of the King. He is the heir of Denethor II (the 26th Ruling Steward of Gondor) and the elder brother of Faramir. In the course of the story Boromir joins the Fellowship of the Ring.</p>
<p>Boromir is portrayed as a noble character who believes passionately in the greatness of his kingdom, who would have defended its people to the last. Boromir's great stamina and physical strength, together with a forceful and commanding personality, made him a widely admired commander in Gondor's army: he was made Captain of the White Tower, and quickly became Captain-General, also bearing the title High Warden of the White Tower. He was also heir apparent to the Stewardship. Boromir led many successful forays against Sauron's forces, prior to his journey north to Rivendell, which brought him great esteem in the eyes of his father, Denethor.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Boromir";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Captain of the White Tower", "Captain-of-Gondor-TAC");
            Alias("High Warden of the White Tower");

            addFamily("Denethor (Father)", "Denethor");
            addFamily("Faramir (Brother)", "Faramir");

            addFriend("Beregond", "Beregond");

            addItem("Horn of Gondor", "Horn-of-Gondor-Core");
            addItem("Gondorian Shield", "Gondorian-Shield-TSF");

            addGroup("The Council of Elrond", "The-Council-of-Elrond");
            addGroup("The Fellowship", "The-Fellowship");

            Card("Boromir-TDM");
            Card("Boromir-HoN");
            Card("Boromir-TSoA");
            Card("Boromir-RD");
        }
    }
}