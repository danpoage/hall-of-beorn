using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters.Groups
{
    public class TheFellowshipOfTheRingGroup : CharacterGroup
    {
        public TheFellowshipOfTheRingGroup()
            : base("The Fellowship", "The Fellowship of the Ring")
        {
            Bio =
@"<blockquote>
&ldquo;The Company of the Ring shall be Nine; and the Nine Walkers shall be set against the Nine Riders that are evil...&rdquo;
<br>― Elrond
</blockquote>
<p>The <b>Fellowship of the Ring</b>, also known as the <b>Company of the Ring</b>, was formed from nine members of the Free peoples during the War of the Ring. Its purpose was to take the One Ring to Mordor, the only place where it could be destroyed.</p>
<h4>Members</h4>
<ul>
<li>Gandalf — One of the Wizards sent to Middle-earth by the Valar. He was the leader of the Fellowship.</li>
<li>Aragorn, son of Arathorn — The Chieftain of the Dúnedain and the last heir to the throne of Gondor and Arnor. He led the Fellowship after the loss of Gandalf.</li>
<li>Boromir, son of Denethor — Captain-general of Gondor and next-in-line to be the Ruling Steward of Gondor.</li>
<li>Legolas, son of Thranduil of Mirkwood — Emissary of the Elves of Mirkwood.</li>
<li>Gimli, son of Glóin — A Dwarf of the Lonely Mountain.</li>
<li>Frodo Baggins — A Hobbit from the Shire, he was chosen to carry the One Ring.</li>
<li>Samwise Gamgee — A Hobbit, he was Frodo's gardener, servant and close friend.</li>
<li>Meriadoc 'Merry' Brandybuck — A Hobbit and cousin of Frodo, he and Pippin were best friends.</li>
<li>Peregrin 'Pippin' Took — A Hobbit and also a cousin of Frodo, he was the youngest of the Fellowship.</li>
</ul>
<h4>History</h4>
<p>The Fellowship of the Ring was formed in Rivendell with the purpose to destroy the One Ring, and the only way to do so was to throw it into the Cracks of Doom.[1] It was decided that nine walkers should contrast the nine riders of Sauron with Frodo as the Ring-bearer and Gandalf as the leader.</p>
<p>Although the purpose was fixed by the Council of Elrond, it was not decreed how, in what manner and through which route this could be done; such details were left to the Fellowship's discretion. As a consequence, the Fellowship started with no detailed plan. One option was to go directly to Mount Doom, the other was to ask help from Boromir's father, Denethor II.</p>
<p>The way of how to reach the East was a problem. After moving south from Rivendell, they encountered crebain on their arrival in Hollin. Fearing that they were used as spies by Saruman, the Fellowship spent the entire day in hiding, without a campfire.</p>
<p>When they had to pass the Misty Mountains; Boromir proposed the Gap of Rohan (the way through which he journeyed to Rivendell), Gandalf insisted on passing through Moria but Aragorn thought the Redhorn Pass would be safer. However after attempting in vain to pass the blizzard, they followed Gandalf's option.</p>
<p>After fighting with wolves and the Watcher in the Water, they managed to open the Doors of Durin and enter Moria.</p>
<p>There they found the Orcs who overran Balin's Colony years ago. They also saw Durin's Bane, who devastated Moria in the first place. Gandalf to buy them time, destroyed the Bridge of Khazad-dûm and both Maiar fell together into the abyss, while the Company escaped back to the light.</p>
<p>Aragorn was appointed the head of the Company, and their next stop was to meet with Galadriel and Celeborn, the elf-lords of Lothlórien.[4] They stayed there for several days, resting and counseling for their plan and route. On their leave, the elves gave them several useful gifts and gave them boats to sail the Anduin.</p>
<p>Meanwhile, Saruman who served Sauron, sent a band of Uruk-hai to capture the halfling who bore the Ring and bring him to Isengard.</p>
<p>Frodo began to realize not only that someone was following them, but also that the Ring was having a malevolent effect on some members of the party, especially Boromir.[7] It was he who tried to take the ring from him, after the passage through the Argonath. In the process, Frodo put on the ring to escape him, but he was followed by Sam. The rest of the Company was attacked by orcs while trying to find the Ring-bearer. Seeing no other halfling, the Orcs succeeded in capturing Merry and Pippin, killing Boromir who tried to protect them.</p>
<p>And so, the Fellowship was broken, but not yet disbanded. Sam followed Frodo down the Emyn Muil having decided to go to Mordor himself.[9] Aragorn with Gimli and Legolas (the 'Three Hunters') decided to follow the Orcs into Rohan and rescue Pippin and Merry. Unknown to them all, Gandalf had resurrected and visited Lothlórien after them.</p>
<p>After many adventures the eight remaining members of the Fellowship reunited after the downfall of Sauron.[12] When King Théoden's funeral escort set out from Minas Tirith all eight journey together until they met Treebeard at Orthanc. There Gimli and Legolas departed to visit the deep places of Fangorn Forest on their way to their own homes, and Aragorn declared that the Fellowship of the Ring was at last ended.</p>";
            
            BioSourceUrl = "http://tolkiengateway.net/wiki/Fellowship_of_the_Ring";
            ImageArtist = Artist.Michael_Komarck;

            Alias("The Company of the Ring");
            Alias("The Nine Walkers");
            
            addLeader("Gandalf", "Gandalf");
            addLeader("Aragorn", "Aragorn");

            addMember("Frodo Baggins", "Frodo-Baggins");
            addMember("Sam Gamgee", "Sam-Gamgee");
            addMember("Legolas", "Legolas");
            addMember("Gimli", "Gimli");
            addMember("Boromir", "Boromir");
            addMember("Merry", "Merry");
            addMember("Pippin", "Pippin");
            addMember("Bill the Pony", "Bill-the-Pony");

            Card("Fellowship-of-the-Ring-RD");
        }
    }
}