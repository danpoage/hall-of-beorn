using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class TheEntsGroup : CharacterGroup
    {
        public TheEntsGroup()
            : base("The Ents", "The Ents")
        {
            Bio =
@"<p>Ents are a race of beings in J. R. R. Tolkien's fantasy world Middle-earth who closely resemble trees. They are similar to the talking trees in folklore around the world. Their name is derived from the Anglo-Saxon word for giant.</p>
<p>The Ents appear in The Lord of the Rings as ancient shepherds of the forest and allies of the free peoples of Middle-earth during the War of the Ring. The Ent who figures most prominently in the book is Treebeard, who (credibly) claims to be the oldest creature in Middle-earth. At the time The Lord of the Rings takes place, there are no young Ents (Entings) because the Entwives (female Ents) were lost. The Ents are akin to Huorns, whom Treebeard describes as a transitional form of trees which become animated or, conversely, as Ents who grow more 'treelike' over time.</p>
<p>Inspired by Tolkien and similar traditions, animated or anthropomorphic tree creatures appear in a variety of media and works of fantasy.</p>
<p>The word 'Ent' was taken from the Anglo-Saxon (Old English) word ent, meaning 'giant'. Tolkien borrowed the word from the Anglo-Saxon phrases orþanc enta geweorc ('work of cunning giants') and eald enta geweorc ('old work of giants', which describes Roman ruins). In this sense, Ents are probably the most ubiquitous of all creatures in fantasy and folklore, perhaps second only to dragons, for the word can refer to a variety of large, roughly humanoid creatures, such as giants, trolls, or even the monster Grendel from the poem Beowulf.</p>
<p>Along with Old Norse jǫtunn (Jötunn), 'ent' came from Common Germanic *etunaz.</p>
<p>Treebeard, called by Gandalf the oldest living Ent and the oldest living thing that walks in Middle-earth, is described as being around 14 feet (4 m) tall:</p>
<blockquote>
[A] large Man-like, almost Troll-like, figure, at least fourteen foot high, very sturdy, with a tall head, and hardly any neck. Whether it was clad in stuff like green and grey bark, or whether that was its hide, was difficult to say. At any rate the arms, at a short distance from the trunk, were not wrinkled, but covered with a brown smooth skin. The large feet had seven toes each. The lower part of the long face was covered with a sweeping grey beard, bushy, almost twiggy at the roots, thin and mossy at the ends. But at the moment the hobbits noted little but the eyes. These deep eyes were now surveying them, slow and solemn, but very penetrating.
</blockquote>
<p>Ents are an old race that appeared in Middle-earth when the Elves did. They were apparently created by Eru Ilúvatar at the behest of Yavanna: when she learned of Aulë's children, the Dwarves, she foresaw that they would fell trees, and desired creatures to serve as Shepherds of the Trees to protect the forests from Dwarves and other perils. Although the Ents were sentient beings from the time of their awakening, they did not know how to speak until the Elves taught them. Treebeard said that the Elves 'cured us of dumbness', that it was a great gift that could not be forgotten. ('They always wished to talk to everything, the old Elves did.')[5] In the Third Age of Middle-earth, the forest of Fangorn was the only place known still to be inhabited by Ents, although the Ent-like Huorns may have survived elsewhere, as in the Old Forest.</p>
<p>Ents exhibit wide variation in personal traits (height, heft, colouring, even the number of digits), as they came to resemble somewhat the specific types of trees that they shepherded. Quickbeam, for example, guarded Rowan trees and bore some resemblance to rowans: tall and slender, smooth-skinned, with ruddy lips and grey-green hair. Ents share some of the strengths and weaknesses of trees as well. Their skin is extraordinarily tough, and very much like wood; they can erode stone extremely rapidly, in the manner of tree roots, but they are vulnerable to fire and chopping blows from axes. Ents are also an extremely patient and cautious race, with a sense of time more suited to trees than short-lived mortals. For example, in the Entmoot regarding the attack on Isengard, their three-day deliberation was considered by some to be 'hasty'.</p>
<p>Ents are tall and very strong, capable of tearing apart rock and stone (though they use their full strength only when they are 'roused'). Tolkien describes them as tossing great slabs of stone about, and ripping down the walls of Isengard 'like bread-crust'.[6] Treebeard boasted of their strength to Merry and Pippin; he said that Ents were much more powerful than Trolls, which Morgoth made in the First Age in mockery of Ents.</p>
<p>The book further lays out the power of Ents; their bark-like skin and flesh make them difficult to harm even with axes, and a single punch from an Ent can kill; although they do hurl stones they otherwise do not use weapons.</p>
<p>The Sindarin word for Ent is Onod (plural Enyd). Sindarin Onodrim refers to the Ents as a race.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Ent";
            ImageArtist = Artist.Ted_Nasmith;

            addLeader("Treebeard", "Treebeard");

            addMember("Quickbeam", "Quickbeam");
            addMember("Skinbark", "Skinbark");
            addMember("Beechbone", "Beechbone");
            addMember("Leaflock");

            addFriend("Gandalf", "Gandalf");
            addFriend("Merry", "Merry");
            addFriend("Pippin", "Pippin");
            addFriend("Saruman (The White)", "Saruman");

            Card("Entmoot-ToS");
            Card("Boomed-and-Trumpeted-EfMG");
        }
    }
}