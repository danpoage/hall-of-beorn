using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters.Things
{
    public class Sting : CharacterThing
    {
        public Sting()
            : base("Sting", "Sting", "Weapon")
        {
            Bio = 
@"<p><b>Sting</b> was an Elvish knife that was probably made in Gondolin in the First Age. Its maker and original bearer are unknown.</p>
<h3>History</h3>
<p>During the Quest of Erebor, in May 2941, Thorin and Company happened upon a trio of Trolls named Tom, Bert, and William who nearly ate them. Only the intervention of Gandalf saved the company from such a horrible fate.</p>
<p>During the scuffle, William dropped the key to their Troll's Cave, which contained all manner of treasure plundered from the trolls' victims. Bilbo Baggins recovered the key, allowing the company to claim the treasure in its entirety, including several fine Elvish blades. Glamdring went to Gandalf, while its mate Orcrist was claimed by Thorin Oakenshield. Bilbo, too, claimed a blade: merely a dagger by the standards of Men or its original Elvish makers, and but a tiny pocket-knife for the trolls whose hoard it was found in, but it made an excellent short sword for a Hobbit.</p>
<p>When Bilbo was captured by goblins while crossing the Misty Mountains, the goblins failed to notice the weapon simply because Bilbo wore it inside his breeches.[2] When Bilbo was separated from the others during their escape, this allowed him to rely on the dagger's glowing blade to light his way, as well as use it to keep a hungry Gollum at bay while he tried to find his way out of the labyrinthine tunnels in the roots of the mountains.</p>
<p>The weapon remained nameless until the company reached Mirkwood and, deep in the darkness, Bilbo and his companions were beset by the forest's Spiders. Awakening to find himself half-cocooned, Bilbo used the dagger to free himself and slay his attacker, the first time he had used it in battle. The act prompted him to name the weapon with the words, &ldquo;I will give you a name, and I will call you Sting.&rdquo; Bilbo used the newly-christened Sting to cut the spiders' silk to free his companions, and during the ensuing battle, utilized it in combination with the magic ring he had found in Gollum's cave, thrown rocks, and hurled insults to help the venom-weakened dwarves fight their way out of the spiders' nest.</p>
<p>When Bilbo returned to the Shire in 2942, he brought his little dagger with him. He displayed it above the mantleplace, where it most likely was when Gandalf and Balin visited him seven years later in 2949 [4]After the Farewell Party on September 22, 3001, Bilbo took Sting with him when he left Hobbiton, and it resided with the aged hobbit in Rivendell for the next 17 years. In 3018, just before the Fellowship of the Ring set off from Rivendell, Bilbo gave Sting to his nephew Frodo Baggins, as well as his wondrous coat of mithril mail, as a gift to protect him on the perilous journey to Mount Doom that lay ahead.</p>
<p>As a consequence of his centuries of corruption under The One Ring's influence, Gollum feared weapons of Elvish make like Sting, which made the knife a factor in aiding Frodo in temporarily taming the wretched creature. It also helped Frodo and Samwise Gamgee escape from the lair of the terrible Shelob in Cirith Ungol, and during the ensuing battle, even after paralyzing Frodo, the massive spider met its match in a determined Samwise Gamgee and learned how the Elvish weapon earned its name. Still armed with Sting, Sam stormed the Tower of Cirith Ungol in order to rescue Frodo, though he found little in the way of a fight, as the tower had seen a battle between its own forces over Frodo's mithril-mail coat.</p>
<p>After the defeat of Sauron at the end of the Third Age, when both Bilbo and Frodo sailed across the sea to the Undying Lands, Sting remained with Sam. He may have taken it with him when he, at last, followed them as was his right as the last remaining Ring-bearer, or it may have remained as an heirloom of the Gardner Family.</p>
<h3>Special Properties</h3>
<p>Sting had the (apparently) magic ability to detect the presence of goblins in its vicinity. When Orcs were nearby, it glowed blue, as Bilbo noticed when alone in the dark just prior to meeting Gollum.[2] This ability was used several times by Frodo and the Fellowship such as when the group encountered Orcs in the mines of Moria and by Aragorn upon the Fellowship's arrival at Parth Galen.</p>
<p>Sting also performed better than ordinary weapons in combat and against odd materials; it cut through the webs of giant spiders easily, whereas the blade that Sam brought from the Barrow-downs failed to cut through Shelob's webs.[6] During the Battle of the Chamber of Mazarbul, Boromir's sword glanced off of the hide of a troll, but Sting was able to deal a painful wound.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Sting";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Taste it Again", "Taste-it-Again-TLoS");

            addFriend("Bilbo Baggins", "Bilbo-Baggins");
            addFriend("Frodo Baggins", "Frodo-Baggins");
            addFriend("Sam Gamgee", "Sam-Gamgee");

            LotRCard("Sting-MG");
            LotRCard("Sting-THOHaUH");
            LotRCard("Sting-RD");
        }
    }
}