using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class QuickbeamCharacter : Character
    {
        public QuickbeamCharacter()
            : base("Quickbeam", "Quickbeam", "Ent")
        {
            Bio = 
@"<p>Quickbeam, or in Sindarin Bregalad, was one of the younger Ents of Fangorn Forest belonging to the people of Skinbark. His name was given because of uncharacteristic hastiness.</p>
<p>The rowan-trees in his keeping (among them Carnimírië, Lassemista, and Orofarnë) suffered greatly at the hands of Saruman's Orcs, so he was the first ent to make his mind up at the Entmoot. He sheltered, in his home, the two hobbits, Merry, and Pippin while the other ents made up their minds at the entmoot. He played a great part in the Ents' resulting attack on Isengard.</p>
<p>The name Quickbeam was given to him because he was hasty for an Ent. His Sindarin name, Bregalad, means 'quick (lively) tree', derived from *breg- having to do with 'violence, suddenness' and galadh, 'tree'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Bregalad";
            ImageArtist = Artist.Mike_Nash;

            Alias("Bregalad");

            addFriend("Treebeard", "Treebeard");
            addFriend("Skinbark", "Skinbark");
            addFriend("Beechbone", "Beechbone");
            addFriend("Merry", "Merry");
            addFriend("Pippin", "Pippin");

            LotRCard("Quickbeam-CoP");
            LotRCard("Quickbeam-ToS");
        }
    }
}