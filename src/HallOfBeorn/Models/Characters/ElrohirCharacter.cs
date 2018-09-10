using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class ElrohirCharacter : Character
    {
        public ElrohirCharacter()
            : base("Elrohir", "Elrohir", "Half-elven")
        {
                        Bio =
@"<p>Elrohir and his twin brother Elladan were the children of Celebrían and Elrond. Dark-haired and grey-eyed, only those that knew them well could tell them apart.</p>
<h4>History</h4>
<p>In the year T.A. 2509, the twins' mother Celebrían went on a journey into the south to visit her own mother, Galadriel, in the land of Lórien. In the Redhorn Pass, she was captured by orcs, and tortured in their dens. Elrohir rode with his brother to rescue her, but by the time they reached her she had received a poisonous wound.[2] Though their father healed her, she would not remain in Middle-earth, and sailed into the West the following year. After this loss, Elladan and Elrohir were filled with hatred of the orcs, often riding against them with the Northern Dúnedain.</p>
<p>In the early part of the War of the Ring, the brothers' main role was to scout the land and prepare the way for the Fellowship,[4] but later they took a more active part. When Halbarad rode to Aragorn's aid with the Grey Company, Elladan and Elrohir accompanied them. They followed Aragorn through the Paths of the Dead, fought with him at Pelargir, and took part in the Battle of the Pelennor Fields, where they fought with stars bound to their brows.</p>
<p>After the War of the Ring, little is known of the brothers' fate. They returned to their father's house at Rivendell, and remained there even after he had passed across the Sea.[5] Like their sister Arwen, the sons of Elrond Half-elven were granted the choice of whether to leave Middle-earth for the Undying Lands, or remain there and become mortal as men. So they chose for a time at least, to stay in Middle-earth for reasons unknown.</p>
<h4>Other Versions of the Legendarium</h4>
<p>In earlier editions, the year T.A. 139 is given as the twins' birthdate.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Elrohir";
            ImageArtist = Artist.Magali_Villeneuve;

            TheFellowshipOfTheRing();
            TheReturnOfTheKing();

            addFamily("Elrond (Father)", "Elrond");
            addFamily("Elladan (Brother)", "Elladan");
            addFamily("Arwen Undómiel (Sister)", "Arwen-Undomiel");
            addFamily("Aragorn (Brother-in-Law)", "Aragorn");
            
            addGroup("The Grey Company", "The Grey Company");
            addGroup("Rivendell", "Rivendell");

            LotRCard("Elrohir-TRG");
            LotRCard("Elrohir-TMoF");
        }
    }
}