using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class TomBombadilCharacter : Character
    {
        public TomBombadilCharacter()
            : base("Tom Bombadil", "Tom Bombadil", "Unknown")
        {
            Bio =
@"<blockquote>
&ldquo;Eldest, that's what I am... Tom remembers the first raindrop and the first acorn... he knew the dark under the stars when it was fearless – before the Dark Lord came from Outside.&rdquo;
<br>― Tom Bombadil, In the House of Tom Bombadil.
</blockquote>
<p>Tom Bombadil was an enigmatic figure that lived throughout the history of Arda. Living in the depths of the Old Forest, he seemed to possess unequaled power in the land around his dwelling. Although seemingly benevolent, he took no stance against the Dark Lords.</p>
<p>His existence passed into Hobbit lore and was referenced in poems such as The Adventures of Tom Bombadil.</p>
<h4>Origins</h4>
<blockquote>
&ldquo;He is a strange creature.&rdquo;
<br>― Elrond, The Council of Elrond
</blockquote>
<p>The origins and nature of Tom Bombadil are unknown; however, he already existed when the Dark Lord came to Arda, signifying he was alive even before the coming of the Valar.</p>
<p>His role and nature in the Elder Days is unknown, but he must have witnessed most of the major events and battles. He also witnessed the reducing of the great forests that covered all Middle-earth, and perhaps of his powers.</p>
<p>The level of his interactions with the outside world is also unclear; however, he seemed to have a name among many peoples and perhaps became a folkloric figure in the traditions and legends of Elves, Dwarves and Men.</p>
<p>During the Third Age, Tom Bombadil lived in a little house by the river Withywindle in the Old Forest, together with his lovely wife Goldberry. He had contact with the Bucklanders[3] and Farmer Maggot, and perhaps it was this to which he owed his jolly and whimsical attitude.</p>
<p>However, since he was merry and benevolent, some of the Free Peoples considered him a potential ally (for example, Elrond and Erestor considered that he should be present at the Council of Elrond). However, according to Gandalf, Tom Bombadil was perhaps not fully aware of the struggle of Light and Darkness and could not prove useful to their causes.</p>
<h4>War of the Ring</h4>
<p>On 26 September, T.A. 3018, he encountered four hobbits while he was searching for water-lilies for his wife. Two of those Hobbits, Merry and Pippin, had been captured by Old Man Willow. Tom, who was the master of the Old Forest, rescued them, and took all four of them to his house.</p>
<p>The four hobbits stayed two nights, and he told them many tales and songs. With cunning questions, he made Frodo tell him of the Ring. When Tom tried it on, nothing happened, but he then took it off and flipped it in the air and made the ring itself disappear, showing that indeed within his realm Tom was master. However, when Frodo put the ring on, Tom could still see him. He bade the Hobbit to come back and sit down; his hand was fairer without the ring.</p>
<p>The following morning, Tom warned his guests of the Barrow-downs, and advised them to pass any barrow on the western side. He also taught them a song, should they come to peril.</p>
<p>And they did come to peril. Tom chased off a wight with song, and broke the spells on the barrow in which the four hobbits were captured. While he sent the Hobbits into calm down, he went for provisions. He also brought the ponies that had belonged to Merry. After that, he broke the spells of the barrow. From the barrow's mighty hoard, he took a brooch for Goldberry, and gave a dagger to each of the hobbits. He then advised them to make for The Prancing Pony in Bree.</p>
<p>The peril of the hobbits was not over; an attack on their lives was carried out, and their ponies were set loose. The ponies apparently remembered the care they were given in the house of Tom Bombadil, and returned to stay beside Tom's own pony, Fatty Lumpkin. He returned them to Barliman Butterbur, the proprietor of The Prancing Pony. Since he had paid eighteen pence as compensation for the loss, he was now the owner of five fine ponies.</p>
<h4>Etymology and other names</h4>
<p>Tom Bombadil went by many names:</p>
<ul>
<li>To the Elves and Dúnedain, he was known as Iarwain Ben-adar, which translates to 'oldest and fatherless'.[2] Iarwain literally means 'Old-young'[7]</li>
<li>To Men of the Vales of Anduin and Rohan, he was known as Orald.[2] This is an Old English word meaning 'very ancient.[8]</li>
<li>The Dwarves knew him as Forn. This too is a reference to his age: it is Old Norse for '(belonging to) ancient (days)'.[8] In some imprints of The History of Middle-earth Index, this name was accidentally spelled with a 'P' as the first letter.[9]</li>
<li>Tom Bombadil is said to be a Bucklandish name, added by Hobbit chroniclers to his many older ones. It is, like many names of the Bucklanders, untranslatable.[3]</li>
</ul>
<h4>Inspiration</h4>
<p>Tom Bombadil was inspired primarily from a doll Tolkien's son, Michael, toyed with.</p>
<p>Paula Marmor notes that bobadil is an archaic word meaning 'braggart', as seen in the character 'Captain Bobadill' in the English play Every Man in His Humour. Because of its Bucklandish form, An Introduction to Elvish lists the name Bombadil under the 'Celtic-sounding names'. However, it is said that the word derives from Boabdil, the Spaniard name of Abu Abdillah Muhammad XII, the last Moorish ruler of Granada.</p>
<p>John D. Rateliff has noted a theory launched by scholar Justin Noetzel. In the latter's paper 'Beorn and Tom Bombadil: Mythology, Narrative, and The Most (Non) Essential Characters in Middle-earth', Noetzel suggests an association of Tom Bombadil with the Celtic Otherworld and tales of the Tuatha Dé Danann.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Tom_Bombadil";
            ImageArtist = Artist.The_Brothers_Hildebrandt;

            Alias("Iarwain Ben-adar");
            Alias("Orald");
            Alias("Forn");
            Alias("The Eldest");
            
            addFamily("Goldberry (Wife)");

            addFriend("Gandalf", "Gandalf");
            addFriend("Farmer Maggot", "Farmer-Maggot");
            addFriend("Barliman Butterbur", "Barliman-Butterbur");
            
            addItem("Fatty Lumpkin");
            addItem("Ho! Tom Bombadil", "Ho-Tom-Bombadil-FotBD");
            addItem("Old Bogey Stories", "Old-Bogey-stories-TOF");

            LotRCard("Tom-Bombadil-ToF");
            LotRCard("Tom-Bombadil-FotBD");
            DigitalCard("Tom-Bombadil-Valor");
        }
    }
}