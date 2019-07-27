using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class GalionCharacter : Character
    {
        public GalionCharacter()
            : base("Galion", "Galion", "Silvan Elf")
        {
            Bio =
@"<p><b>Galion</b> was a Wood-elf who served as butler in Thranduil's halls in northeastern Mirkwood.</p>
<h3>History</h3>
<p>Galion served King Thranduil (and presumably also Thranduil's son Legolas). One evening in T.A. 2941 Galion and the captain of the guards decided to taste some new wine that had recently arrived to &ldquo;see if it is fit for the king's table&rdquo;. The heady vintage from Dorwinion soon put the two Elves asleep, which gave Bilbo Baggins his chance to free Thorin and the other Dwarves (who had been imprisoned in Thranduil's dungeons during the Quest of Erebor). Using the captain's keys and his Magic Ring, Bilbo freed the Dwarves and secreted them into several empty barrels. When other Elves arrived to push the barrels in they found Galion and woke him up. When the workers noted the heaviness of some of the &ldquo;empty&rdquo; barrels, Galion growled at them and ordered them to push the barrels into the water.</p>
<h3>Etymology</h3>
<p>The name Galion is said to be not Sindarin, although perhaps &ldquo;'Sindarized' in shape&rdquo;.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Galion";
            ImageArtist = Artist.Torbjorn_Kallstrom;

            TheHobbit();

            addGroup("Mirkwood Elves");

            addFriend("Thranduil (Lord)", "Thranduil");
            addFriend("Legolas (Lord)", "Legolas");

            LotRCard("Galion-FitN");
        }
    }
}