using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class BeornCharacter : Character
    {
        public BeornCharacter()
            : base("Beorn", "Beorn", "Skin-Changer")
        {
            Bio =
@"<p>Beorn was a Skin-changer, a man who could assume the form of a bear.</p>
<h4>History</h4>
<p>His origins lay in the distant past, and Gandalf suspected he and his people had originally come from the mountains, until the Orcs of the Misty Mountains drove them away. He lived with his tame horses in a wooden house (Beorn's Hall) between the Misty Mountains and Mirkwood, to the east of the Great River of Wilderland.</p>
<p>Beorn named the Carrock and created the steps that led from its base to the flat top. Once Gandalf saw him as a bear sitting all alone on the top of the Carrock watching the moon sinking towards the Misty Mountains, and heard him growl in the tongue of bears 'The day will come when they will perish and I shall go back!'. While Gandalf knew him, Beorn did not know Gandalf; but he knew his cousin, Radagast.</p>
<p>During the Quest of Erebor, Beorn received Gandalf, Bilbo Baggins and the thirteen Dwarves and gave the Dwarves and Bilbo help in their quest.</p>
<p>In the Battle of Five Armies, Beorn appeared transformed into a giant bear, rescued Thorin from the Goblins and killed their leader, Bolg.</p>
<p>After Thorin's burial, Beorn followed Bilbo, Gandalf and Thranduil on their way back to the west. Beorn once more hosted Bilbo and Gandalf and other Woodmen who came to celebrate Yule.</p>
<p>Eventually, he became a 'great chief' in the Vales of Anduin, and it is said that his descendants also were skin-changers, able to take the shape of a bear.[2] His people became known as the Beornings, and they helped defend Thranduil's kingdom of northern Mirkwood.</p>
<p>Beorn presumably died some time before the War of the Ring began[5] and was succeeded by his son Grimbeorn the Old.</p>
<h4>Character</h4>
<p>Beorn was generally benevolent and hated goblins and wargs; but he was also a loner and distrustful of travelers and beggars. He was never polite, and became easily angry and appalling. He never invited people into his house and his very few friends, who lived a good way away, came no more than a couple to his house at a time. Added to this, Beorn was not fond of Dwarves.</p>
<p>Although fierce to his enemies, once convinced of the others' goodwill, he was welcoming, generous and helpful.</p>
<p>He did not eat any meat, as he could talk with his animals, who helped him. His grove was occupied by huge bees. Beorn's diet was mainly honey and cream.</p>
<h4>Etymology</h4>
<p>Beorn is an Old English word meaning 'a warrior, a hero, a man of valour' (also, poetic 'man'), cognate to Old Norse björn ('bear'). In the Scandinavian-speaking countries Björn/Bjørn is a personal name, attested since the 11th century.</p>
<h4>Other versions of the Legendarium</h4>
<p>In early manuscripts of The Hobbit, the name of the character that would become Beorn is Medwed. Medwed's ability to change shape to a bear was due to an enchantment, perhaps of his own.[10] The similarity between Medwed and Medved, the Russian word for 'bear', is striking, but it is ultimately unknown if Tolkien had this in mind.</p>
<p>In the Etymologies, Ilkorin ber ('valiant man, warrior') and Danian beorn ('man') derive from the Elvish root BER.</p>
<h4>Inspiration</h4>
<p>It has been suggested that the character Beorn was influenced by the Norse Saga of Hrólfr Kraki.[12] In the saga appears a great bear defending Hrólfr Kraki, and also a man cursed to being transformed into a bear during nighttime. The work was well-known to J.R.R. Tolkien, as one of his students and friend, Stella Miller, made a translation of the saga dedicated to Tolkien, E.V. Gordon and C.T. Onions;[7] but even more importantly as Tolkien himself wrote an unpublished short story of the tale, entitled Sellic Spell.</p>
<p>Another suggested inspiration is the character of Beowulf, 'whose name is commonly explained as Beowulf = 'bees' wolf' = honey-eater = bear, and one who breaks swords, rips off arms and cracks ribs with ursine power and clumsiness.'</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Beorn";
            ImageArtist = Artist.Joel_M_Kilpatrick;

            Alias("Chieftain of the Beornings");
            Alias("Slayer of Bolg");
            AliasLink("Fearless Killing Machine", "https://www.youtube.com/watch?v=NtG7sUqOS4w");

            addGroup("The Beornings", "The-Beornings");

            addFamily("Grimbeorn the Old (Son)", "Grimbeorn-the-Old");

            addFriend("Gandalf", "Gandalf");
            addFriend("Thorin's Company", "Thorin's-Company");

            LotRCard("Beorn-THOHaUH");
            LotRCard("Beorn-Core");
            LotRCard("Beorn's-Rage-TWH");
            DigitalCard("Beorn-Valor");
        }
    }
}