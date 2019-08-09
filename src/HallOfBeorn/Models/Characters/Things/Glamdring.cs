using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters.Things
{
    public class Glamdring : CharacterThing
    {
        public Glamdring()
            : base("Glamdring", "Glamdring", "Weapon")
        {
            Bio =
@"<blockquote>&ldquo;This, Gandalf, was Glamdring, Foe-hammer that the king of Gondolin once wore.&rdquo;<br>&ndash; <a href='/LotR/Characters/Elrond' title='Character: Elrond'>Elrond</a></blockquote>
<p><b>Glamdring</b> was a sword, said to have belonged to Turgon, but best known as the weapon of Gandalf during the War of the Ring. It was known in Westron as the Foe-hammer, and Orcs knew it as Beater.</p>
<h3>History</h3>
<h4>Beater</h4>
<p>Glamdring was originally borne by Turgon, the King of Gondolin. He must have wielded it with strength during the Nirnaeth Arnoediad or the Fall of Gondolin, for the Orcs named it &ldquo;Beater&rdquo;, and fled before it. Even up until the late Third Age, orcs of the Misty Mountains knew of this legendary sword, so it must have done some damage.</p>
<p>The name most likely originated in the Nirnaeth Arnoediad, where it is said that Turgon &ldquo;hewed his way to the side of his brother&rdquo;. No other tales mention the actions of the sword, and it is unknown what happened to it during the Fall of Gondolin. Turgon perished as the Tower of the King fell on top of him, but of the fate of Glamdring nothing is told.</p>
<h4>Survival</h4>
<p>The sword survived roughly 6500 years from the Fall of Gondolin in F.A. 510 to its eventual rediscovery in T.A. 2941. In that period, it travelled from Gondolin far to the east, thus possibly surviving the deluge of Beleriand in the War of Wrath and ended up in a Troll's Cave in the Trollshaws of Eriador. Much mystery surrounds this feat, but Elrond reasoned that Glamdring (along with Orcrist and Sting) was plundered from other plunderers, or carried off to the Misty Mountains soon after the Fall of Gondolin.</p>
<h4>At Gandalf's Side</h4>
<p>In May T.A. 2941, Gandalf, Bilbo Baggins and a group of dwarves encountered three trolls in the Trollshaws - William, Bert and Tom. The Trolls captured Bilbo and the Dwarves, but Gandalf destroyed them by exposing them to sunlight. Glamdring, along with Orcrist and Sting, were found in their cave nearby. Gandalf claimed the weapon as his own, amazed by its appearance and inscription. The inscription was set in a script of runes Gandalf did not know; he needed the knowledge of Elrond for that. Elrond translated the runes and called it by its Mannish name: &ldquo;Foe-hammer&rdquo;.</p>
<p>Gandalf would use the sword well; its first victim was the Great Goblin. Other Orcs fled as they recognized the sword as &ldquo;Beater&rdquo;. This would have meant that either some Orcs were at the Fall of Gondolin (which is unlikely, given the short lifespan of Orcs), or that they had legends about two glowing swords - Beater and Biter. Whether Gandalf used the sword again during the Quest for Erebor is uncertain, though it is likely that he wielded it in the Battle of Five Armies.</p>
<p>Gandalf bore Glamdring at his side when the Fellowship of the Ring left Rivendell in T.A. 3018. He used the blade during the Battle of the Chamber of Mazarbul, and a short time thereafter in the standoff with the Balrog. After the collapse of the bridge, Gandalf and the Balrog fought on to the Endless Stair and Durin's Tower, but in his recollection of the event he does not tell whether he used Glamdring or his staff in the Battle of the Peak.</p>
<p>Gandalf's spirit perished there but was sent back because his task was not yet complete. He had Glamdring with him when he met the Three Hunters; he gave it to Háma at Edoras when asked to surrender it.[9] Gandalf would continue to bear it throughout the War of the Ring, and carried it at his side when he, Frodo, Sam, Merry and Pippin arrived at the Prancing Pony in Bree. Gandalf and the Hobbits had seen so much war at the time that wearing a weapon did not seem odd.</p>
<h4>Fate</h4>
<p>On 29 September, T.A. 3021, Gandalf left Middle-earth and sailed into the West. Whether he took Glamdring with him is never mentioned, and is open to debate. It can be argued that he brought it over the Sea, like he did with Shadowfax, and because he had been carrying the sword for over 80 years.</p>
<h4>Appearance</h4>
<p>Glamdring and Orcrist are described as having &ldquo;beautiful scabbards and jeweled hilts&rdquo;. They would glow blue in the presence of Orcs. The &ldquo;sword of Turgon&rdquo; had &ldquo;a white and gold sword in a ruel-bone (ivory) sheath&rdquo;.</p>
<p>When he took the sword, Gandalf said he could not read the runes. Elrond did, however, as he was a savant of all kinds of runes.</p>
<h4>Etymology</h4>
<p>The word Glamdring is a Sindarin name meaning Foe-hammer in Westron; it is comprised of two elements. The first element is glam. This word has a long history in Tolkien's mind, but always had evil connotations. In its earliest appearances, it meant &ldquo;fierce hate&rdquo;, but later, its meaning became &ldquo;shouting, confused noise&rdquo;, and became (poetically) associated with Orcs (cf. glamhoth). The second element is dring, said to mean &ldquo;hammer&rdquo;. The sword was also given the crude name Beater by the Orcs.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Glamdring";
            ImageArtist = Artist.John_Howe;

            Alias("Foe-hammer", "Foe-hammer-THOHaUH");
            Alias("Beater");

            addFriend("Gandalf", "Gandalf");

            LotRCard("Glamdring-RAR");
            LotRCard("Glamdring-RD");
            LotRCard("Glamdring-THOHaUH");
        }
    }
}