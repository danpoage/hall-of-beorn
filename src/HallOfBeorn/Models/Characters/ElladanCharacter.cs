using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class ElladanCharacter : Character
    {
        public ElladanCharacter()
            : base("Elladan", "Elladan", "Half-elven")
        {
            Bio =
@"<p>Elladan and his twin brother Elrohir were the children of Celebrían and Elrond. The first of the twins, Elladan ('Elf-Man') was named so as a token of his ancestry; he was descended not only from the royal houses of the Noldor, the Vanyar and the Sindar, but also from the Houses of Hador, Haleth and Bëor of the Edain.</p>
<h4>Description</h4>
<p>The brothers were tall, dark-haired and grey-eyed, and so much alike that only those that knew them well could tell them apart. To Meriadoc Brandybuck their elven-fair faces seemed neither old or young. While in the Grey Company they wore cloaks of silver-grey over a bright mail.</p>
<h4>History</h4>
<p>In the year T.A. 2509, the twins' mother Celebrían went on a journey into the south to visit her own mother, Galadriel, in the land of Lórien. In the Redhorn Pass, she was captured by orcs, and tortured in their dens. Elladan rode with his brother to rescue her, but by the time they reached her she had received a poisonous wound.[2] Though their father healed her, she would not remain in Middle-earth, and sailed into the West the following year. After this loss, Elladan and Elrohir were filled with hatred of the orcs, often riding against them with the Northern Dúnedain.[4] In 2933 they saw Arathorn II killed by orcs while hunting with him.</p>
<p>In the early part of the War of the Ring, the brothers' main role was to scout the land and prepare the way for the Fellowship; around November T.A. 3018 they were sent by Elrond to a secret errand, passed down the Silverlode into a 'strange country' and were the last to return to Rivendell, in December.</p>
<p>Later they took a more active part. When Halbarad rode to Aragorn's aid with the Grey Company, Elladan and Elrohir accompanied them.[3] They followed Aragorn through the Paths of the Dead, fought with him at Pelargir, and took part in the Battle of the Pelennor Fields, where they fought with stars bound to their brows.</p>
<p>After the War of the Ring, little is known of the brothers' fate. They returned to their father's house at Rivendell, and remained there even after he had passed across the Sea.[7] Like their sister Arwen, the sons of Elrond Half-elven were granted the choice of whether to leave Middle-earth for the Undying Lands, or remain there and become mortal as men. So they chose, for a time at least, to stay in Middle-earth for reasons unknown.</p>
<h4>Other Versions of the Legendarium</h4>
<p>In earlier editions, the year T.A. 139 is given as the twins' birthdate.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Elladan";
            ImageArtist = Artist.Magali_Villeneuve;

            TheFellowshipOfTheRing();
            TheReturnOfTheKing();

            addFamily("Elrond (Father)", "Elrond");
            addFamily("Elrohir (Brother)", "Elrohir");
            addFamily("Arwen Undómiel (Sister)", "Arwen-Undomiel");
            addFamily("Aragorn (Brother-in-Law)", "Aragorn");
            
            addGroup("The Grey Company", "The Grey Company");
            addGroup("Rivendell", "Rivendell");

            LotRCard("Elladan-RtR");
            LotRCard("Elladan-TMoF");
        }
    }
}