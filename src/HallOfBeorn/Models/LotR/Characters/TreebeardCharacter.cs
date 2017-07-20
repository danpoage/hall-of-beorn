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
@"<p>Treebeard (Sindarin: Fangorn) is a fictional character from J. R. R. Tolkien's Middle-earth fantasy writings. The eldest of the species of Ents, he is said to live in the ancient Forest of Fangorn and stands fourteen feet (4 m) in height. He is treelike in appearance, with leafy hair and a rigid structure. His home of Fangorn Forest lies next to Isengard, where Saruman the White resides. Treebeard's motto is 'Do not be hasty.'</p>
<p>In The Two Towers he meets with Meriadoc Brandybuck and Peregrin Took, two Hobbits of the Shire known also as Merry and Pippin.[1] Treebeard is known to have a strong hatred of Orcs, and, after Saruman's betrayal of the Ents, of Saruman as well.[1][2] During his initial encounter with the two hobbits, he is so agitated that he misidentifies them as orc spies.</p>
<p>Spirits were sent by Eru Ilúvatar to inhabit the trees, which the Vala Yavanna had created along with other plants or olvar. The Vala longed for their protection since Morgoth or Melkor was destroying the trees and olvar, which could not defend themselves from him. The Ents were created by Ilúvatar at the behest of Yavanna as the Shepherds of the Forest or Tree-herders. Entwives were also created for the Ents, but, in the Second Age, were driven out by Sauron.[1][2][3]
<p>Treebeard is the oldest of three remaining original Ents.[1][4] He is said to have once roamed all of the forests in Middle-earth, which included the Misty Mountains, Mirkwood, Mordor, and the Blue Mountains. After the loss of the Entwives by the end of the Third Age, he and the remaining Ents dwelt in the Forest of Fangorn. This led the remaining Ents into isolation and all information from the outside world was cut off.[1] The arrival of Merry and Pippin shifted Treebeard's attention to take action against Saruman for hacking down his trees. He led the Ents to war against Saruman and his Orcs. Treebeard later realised that while Saruman had learned much from him, the Wizard had shared no useful information of his own.</p>
<blockquote>a large Man-like figure, at least fourteen foot high, very sturdy, with a tall head, and hardly any neck. Whether it was clad in stuff like green and grey bark, or whether that was its hide, was difficult to say. Arms, at a short distance from the trunk, were not wrinkled, but covered with a brown smooth skin. The large feet had seven toes each. Grey beard, deep brown eyes, shot with a green light.”
— The description of Treebeard in The Two Towers Volume III – 'Treebeard'
</blockquote>
<p>Treebeard had been friends with Saruman. It is described in The Two Towers that Saruman visited Treebeard in Fangorn Forest and had talked with him on various subjects of concern. Saruman gathered information from Treebeard about the Forest of Fangorn; its intertwining paths were of particular concern to him.</p>
<p>After Merry and Pippin's meeting with Treebeard, Treebeard called an Entmoot, which lasted three days, to decide to call an attack on Isengard and Saruman.[1][2][4] Since Leaflock and Skinbark were the oldest of the Ents along with Treebeard, they refused to fight, however, Treebeard thought he was going to his doom during 'the last march of the Ents.' Treebeard hoped that some of the younger Ents would come instead of just the two, and, during the night he spread the word. They later launched an assault on Isengard.</p>
<p>After Treebeard ordered the Ents to march to Isengard, the Ents felled Saruman's walls and destroyed every object in and around Isengard; the Tower of Orthanc could not be breached, but Saruman was trapped within. Treebeard stopped the attack on the tower when he realised their efforts were in vain; the tower was too strong. The Ents were ordered to unleash the waters of the River Isen, which flooded Isengard.[2] When Merry and Pippin departed Treebeard he requested them to watch for the Entwives.[1] At one point in the book, Tolkien gives hints on the whereabouts of the Entwives. It is speculated that they were spotted by Samwise Gamgee's cousin Hal in the North Farthing. However, this may or may not be conjecture:
<blockquote>But what about these Tree-men, these giants, as you might call them? They do say that one bigger than a tree was seen up away beyond the North Moors not long back ... But this one was as big as an elm tree, and walking – walking seven yards to a stride, if it was an inch.
— Samwise Gamgee and Ted Sandyman arguing over Sam's cousin's account of spotting Ents near the Shire in The Fellowship of the Ring Volume I – 'The Shadow of the Past'
</blockquote>
<p>In the Years of the Trees where the Ents were thriving in 1495 Morgoth had re-established his realm in Middle-earth.[1] With this the Entwives had moved across to the east where Anduin lay.[1] Treebeard's Entwife Fimbrethil was driven from her land and the two were separated forever. This may have been the dominant cause of the loss of the Entwives and the loss of the Entings.</p>
<p>The Elven-realm Lothlórien was situated near the North of Fangorn Forest and Treebeard had met the Lord and Lady of the Galadhrim of Lothlórien, who refer to him as 'Eldest'.[1][7] Over time the Ents and the Elves separated and the Elves had nothing more to do with the business of Ents.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Treebeard";
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