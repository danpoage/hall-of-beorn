using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters.Places
{
    public class FangornPlace : CharacterPlace
    {
        public FangornPlace()
            : base("Fangorn", "Fangorn Forest")
        {
            Bio =
@"<blockquote>&ldquo;All that lies north of Rohan is now to us so far away that fancy can wander freely there&rdquo;<br>&ndash;Boromir</blockquote>
<p><b>Fangorn Forest</b> was a deep, dark woodland that grew beneath the southern Misty Mountains, under the eastern flanks of that range. It gained notoriety as the habitat of the Ents in the Third Age. The forest, known as Entwood in Rohan, was named after the oldest Ent, Fangorn. Fangorn Forest was the oldest part of Treebeard's realm, and here the Ents retreated. Fangorn was within the borders of Gondor, but centuries passed without any Gondorian visiting it to prove or disprove the legends around it.</p>
<h3>Description</h3>
<p>Legolas described Fangorn as &ldquo;tense&rdquo; and &ldquo;old, very old...and full of memory&rdquo;, and the Dwarf Gimli said that &ldquo;the air is stuffy... lighter than Mirkwood, but it is musty and shabby.&rdquo; Peregrin Took described it as &ldquo;very dim, and stuffy&rdquo;, comparing it to the Old Took's room in the Great Smials. Meriadoc Brandybuck contrasted the forest with Bilbo's description of the pitch-dark Mirkwood, saying, &ldquo;This is just dim, and frightfully tree-ish.&rdquo;</p>
<h3>History</h3>
<h4>First and Second Age</h4>
<p>Fangorn Forest was the easternmost survivor of the immense forest that spanned all of Eriador and Calenardhon in the First Age and early Second Age, but which was destroyed by the Númenóreans and Sauron. Before the deforestation of these regions by Númenórean shipbuilders, Fangorn Forest was much larger, and was connected to the Old Forest.</p>
<h4>Third Age</h4>
<p>Saruman often used to walk in Fangorn and talk with Treebeard, if he met him, and was always eager to listen to anything the old Ent told him about the forest. However, he never repaid Treebeard in the same way. Saruman used this knowledge of the forest's secrets for his own advantage.</p>
<p>Beginning in T.A. 2953 Saruman started fortifying Isengard and eventually his Orcs started abusing and harassing the forest, its trees and Ents, for his fortifications and war machines.</p>
<h4>War of the Ring</h4>
<p>On 28 February of T.A. 3019, Éomer's Éored attacked and slaughtered the band of Uruk-hai of Uglúk under the eaves of Fangorn.[5] This allowed Meriadoc Brandybuck and Peregrin Took to escape the Orcs and pass into the forest. There they met Treebeard and informed him of the danger that Saruman posed to the Ents and their forest. Following the Entmoot the rest of the Ents finally agreed to march against Isengard, taking Merry and Pippin with them and sending Huorns to Helm's Deep to deal with the Orcs there. Treebeard was angered by Saruman's Orcs chopping down parts of the forest. This was one of the reasons the Ents decided to attack Isengard.</p>
<p>On March 1, T.A. 3019, Aragorn, Gimli and Legolas entered the forest in search of Merry and Pippin. Rather than the two young hobbits, they encountered the White Wizard. At first they believed it to be Saruman before realising that it was Gandalf, returned from death.</p>
<h3>Etymology</h3>
<p>Fangorn is a Sindarin word that translates as &ldquo;Treebeard&rdquo; (from fang = &ldquo;beard&rdquo; and orn = &ldquo;tree&rdquo;). Entwood is a modernization of Old English Entwudu (wudu &ldquo;wood&rdquo;), so modernised because it was recognisable by speakers of Westron. Gondorians used that name, assimilated to their own language.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Fangorn_Forest";
            ImageArtist = Artist.Donato_Giancola;

            addGroup("The Ents", "The-Ents");

            addLeader("Treebeard", "Treebeard");
            addMember("Quickbeam", "Quickbeam");
            addMember("Beechbone", "Beechbone");
            addMember("Skinbark", "Skinbark");
            addMember("Leaflock", "Leaflock");
            addMember("Ent-of-Fangorn-ToS");
            addMember("Huorn-of-Fangorn-TCaON");

            addFriend("Merry", "Merry");
            addFriend("Pippin", "Pippin");

            LotRCard("Heart-of-Fangorn-VoI");
            LotRCard("Edge-of-Fangorn-VoI");
        }
    }
}