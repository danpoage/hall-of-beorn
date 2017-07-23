using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class GrimaCharacter : Character
    {
        public GrimaCharacter()
            : base("Gríma", "Gríma", "Man")
        {
            Bio =
@"<p>Gríma, called (the) Wormtongue, is a fictional character in J. R. R. Tolkien's The Lord of the Rings. He appears in the second and third volumes of the work, The Two Towers and The Return of the King, and his role is expanded upon in Unfinished Tales. He is introduced in The Two Towers as the chief advisor to King Théoden of Rohan and henchman of Saruman. Gríma serves as an archetypal sycophant, flatterer, liar, and manipulator, and is considered to be based by Tolkien on the Beowulf character Unferth.</p>
<p>The name Gríma derives from the Old English or Icelandic word meaning 'mask', 'helmet' or 'spectre'. It is also possible to link the name to the English word 'grim', which among other characteristics means 'ugly' in Old English.</p>
<p>Gríma, son of Gálmód, was at first a faithful servant, but he eventually fell in league with Saruman, and from then on worked to weaken Théoden and his kingdom through lies and persuasion.</p>
<p>Tolkien describes him as 'a wizened figure of a man, with a pale wise face, and heavy lidded eyes', with a 'long pale tongue'.</p>
<p>He was widely disliked in Edoras; everyone except Théoden called him 'Wormtongue'. Gandalf repeatedly compares him to a snake:</p>
<blockquote>
The wise speak only of what they know, Gríma son of Gálmód. A witless worm have you become. Therefore be silent, and keep your forked tongue behind your teeth. I have not passed through fire and death to bandy crooked words with a serving-man till the lightning falls.
&nbsp;&nbsp;— Gandalf, The Two Towers
<br>
See, Théoden, here is a snake! To slay it would be just. But it was not always as it now is. Once it was a man, and it did you service in its fashion.
&nbsp;&nbsp;— Gandalf, The Two Towers
</blockquote>
<p>It is implied that Saruman had promised him Éowyn, the king's niece, as a reward for his services. Her brother Éomer accused him of 'watching her under his lids and haunting her steps'. His schemes were foiled when Gandalf the White and his companions arrived at Edoras, and convinced the king that he was not as weak as his adviser had made him seem. Upon Théoden's restoration, 'many things which men had missed' were found locked in Gríma's trunk, including the king's sword, Herugrim. Théoden decided to go forth to battle at the Fords of Isen, and Gríma was given a choice: prove his loyalty and ride into battle with the king, or ride into exile. Choosing the latter, he went to Saruman at Orthanc. Following the confrontation between Saruman and Gandalf, Gríma mistakenly threw the palantír of Orthanc at the Rohirrim accompanying Gandalf, or possibly at Saruman himself, and so permitted its capture by Peregrin Took.</p>
<p>Gríma accompanied Saruman to the Shire, where Saruman sought revenge for his defeat at Orthanc in petty tyranny over the Hobbits. During this time, Saruman shortened Gríma's nickname to 'Worm'. When Saruman was overthrown by a hobbit rebellion and ordered to leave, Frodo Baggins implored Gríma not to follow him, and even offered him food and shelter. Saruman countered by revealing to the Hobbits that Gríma had murdered and possibly eaten Lotho Sackville-Baggins, a kinsman of Frodo; whereupon Gríma killed Saruman and was shot by Hobbit archers.</p>
<p>Gríma played a major role in the back-story to The Lord of the Rings, prior to his first appearance in The Two Towers. In Unfinished Tales Tolkien writes that on 20 September in T.A. 3018 Gríma was captured by the Nazgûl in the fields of the Rohirrim, while on his way to Isengard to inform Saruman of Gandalf's arrival at Edoras. He divulged what he knew of Saruman's plans to the Nazgûl, specifically his interest in the Shire, and its location. Gríma was set free, and the Nazgûl set out immediately for the Shire. In another version within the same chapter, this role is given to the squint-eyed southerner that the hobbits encounter at Bree.</p>
<p>In the same book, Tolkien intimates that Gríma may have given Théoden 'subtle poisons' that caused him to age at an accelerated pace.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Gr%C3%ADma_Wormtongue";
            ImageArtist = Artist.Harold_Shull;

            Alias("Wormtongue");
            Alias("Worm");

            addFamily("Gálmód (Father)");

            addFriend("Théoden", "Theoden");
            addFriend("Saruman", "Saruman");

            addItem("Keys of Orthanc", "Keys-of-Orthanc-VoI");

            addGroup("The Rohirrim", "The-Rohirrim");

            Card("Grima-Hero-VoI");
            Card("Grima-Objective-Ally-VoI");
            Card("Grima-ToS");
        }
    }
}