using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class TreebeardCharacter : Character
    {
        public TreebeardCharacter()
            : base("Treebeard", "Treebeard", "Ent")
        {
            Bio =
@"<blockquote>
&ldquo;It is not wizardry, but a power far older. A power that walked the earth, ere elf sang or hammer rang.&rdquo;
<br>― Gandalf, The Two Towers
</blockquote>
<p><b>Treebeard</b>, also known as <b>Fangorn</b>, was the oldest of the Ents, a tree-like being who was a sort of 'shepherd of trees'. Very tall and stiff-limbed, with bark-like skin and leafy hair, like most Ents, Treebeard took a long time to make up his mind. He repeatedly spoke of not 'being hasty'.</p>
<p>Treebeard is described along with Tom Bombadil as the oldest being in Middle-earth. By the later Third Age, he lived in Fangorn Forest, which was named after him (or he after it).</p>
<h4>History</h4>
<p>Treebeard was the eldest person of Middle-earth, obviously being created along with the Ents during the Years of the Trees, before the creation of the stars; although he said that there were trees in Fangorn that were 'older than he'. His realm was the immense forest that spanned from Beleriand and Eriador to Calenardhon and saw it destroyed and diminishing by the centuries. From the Elder Days, Treebeard had memories of the willow-meads of Tasarinan, the elm-woods of Ossiriand, the pine-trees of Dorthonion and the beeches of Neldoreth.</p>
<p>He was with his beloved Fimbrethil, but as with all of the other Entwives, she left for the gardens of the Entwives, and had been missing ever since, especially after Sauron's forces destroyed those lands in the Second Age.</p>
<p>The forests of the Ents diminished and Fangorn Forest was one of their remnants, where Treebeard and other Ents retreated. There he kept his Ent-houses one of which was the Wellinghall in the flanks of Methedras.</p>
<p>During the War of the Ring, in 29 February T.A. 3019 he discovered Meriadoc Brandybuck ('Merry') and Peregrin Took ('Pippin') after they escaped from Orcs. He welcomed them to the Wellinghall. The hobbits brought news of the Wizard Saruman's treachery and his Orcs damaging the trees, but Treebeard already knew of these disasters.</p>
<p>The Ents—usually a very patient, deliberate people—did become angry at Saruman, whose armies were cutting down large numbers of their trees. Treebeard convened an Entmoot, a meeting of the Ents at Derndingle.</p>
<p>After lengthy deliberation Treebeard led them marching on Saruman's fortress at Isengard in March 3, accompanied by the two Hobbits: the last march of the Ents. In the Battle of Isengard they destroyed the valley and trapped Saruman in the tower of Orthanc. Treebeard appointed the two Hobbits door-wardens of Orthanc. There Treebeard also saw Wormtongue who brought a message for Saruman, and caught him and captured him inside Orthanc.</p>
<p>Two days later they were soon joined by a company of Rohirrim with Gandalf, returning victorious from the Battle of the Hornburg. After deposing Saruman, Gandalf asked Treebeard to pour back the water into Orthanc so that Saruman can never escape. Treebeard declared that trees would return and that the new forest would be called the 'Watchwood'.</p>
<p>The following months the Ents destroyed the Ring of Isengard, filling it with trees; Treebeard saw the flight of many Orcs who met their doom in the forest. He kept their prisoner informed, who would come to the window of Orthanc to listen.</p>
<p>The Wizard withered away and eventually managed to make the Ents pity him, and on August 15 they let them leave Isengard. However, before he left, Treebeard made him lock the tower and hand over the key of Orthanc. A week later Treebeard welcomed Gandalf, King Elessar and company at Orthanc, and related these news.</p>
<p>Presumably Treebeard stayed for some time in the Treegarth of Orthanc, which King Elessar declared an Entish realm.</p>
<h4>Etymology</h4>
<p>Treebeard is the direct translation of the Sindarin name Fangorn (from fang = 'beard' and orn = 'tree').</p>
<h4>Inspiration</h4>
<p>Treebeard's booming voice was inspired by the way C.S. Lewis spoke.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Treebeard";
            ImageArtist = Artist.Suzanne_Helmigh;

            Alias("Fangorn");
            Alias("The Ent");

            addFriend("Quickbeam", "Quickbeam");
            addFriend("Skinbark", "Skinbark");
            addFriend("Beechbone", "Beechbone");
            addFriend("Galadriel", "Galadriel");
            addFriend("Gandalf", "Gandalf");
            addFriend("Saruman", "Saruman");
            addFriend("Merry", "Merry");
            addFriend("Pippin", "Pippin");

            addItem("Ent Draught", "Ent-Draught-ToS");

            Card("Treebeard-ToS");
            Card("Treebeard-TAC");
        }
    }
}