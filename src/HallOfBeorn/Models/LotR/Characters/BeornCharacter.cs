using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class BeornCharacter : Character
    {
        public BeornCharacter()
            : base("Beorn", "Beorn", "Skin-Changer")
        {
            Bio =
@"<p>Beorn is a fictional character created by J. R. R. Tolkien. He appears in The Hobbit as a 'skin-changer', a man who could assume the form of a great black bear.</p>
<h4>The Hobbit</h4>
<p>The Man named Beorn lived with his animal retinue (horses, dogs, sheep, and cows, among others) in a wooden house between the Misty Mountains and Mirkwood, to the east of the Anduin. According to Gandalf, Beorn 'does not eat them; neither does he hunt or eat wild animals'.[1] Gandalf believed that Beorn was either a descendant of the bears who had lived in the Misty Mountains before the arrival of the giants, or he was a descendant of the men who had lived in the region before the arrival of the dragons or Orcs from the north.</p>
<p>Beorn was of immense size and strength for a man, and retained his size and strength in bear-form. He had black hair (in either form) and a thick black beard and broad shoulders (in human form). While not a 'giant' outright, Beorn's human form was of such great size that the three and a half foot tall Bilbo judged that he could have easily walked between Beorn's legs without touching his body. Beorn also named the Carrock and created the steps that led from its base to its flat top.</p>
<p>In The Hobbit, Beorn received Gandalf, Bilbo Baggins, and 13 Dwarves, and aided them in their quest to reclaim their kingdom beneath the Lonely Mountain. He was convinced of their trustworthiness after confirming their tale of encountering the Goblins of the Misty Mountains and Gandalf's slaying of their leader, the Great Goblin. In addition to giving the group much-needed supplies and lodging, Beorn gave them vital information about what path to take while crossing Mirkwood.</p>
<p>Later, hearing of a vast host of Goblins on the move, Beorn arrived at the Lonely Mountain in time to strike the decisive blow in the Battle of Five Armies. In his bear form he slew the Goblin leader, Bolg and his bodyguards. Without direction, the Goblin army scattered and were easy pickings for the other armies of Men, Elves, Dwarves, and Eagles. Beorn often left his home during the narrative of The Hobbit for hours or days at a time, for purposes not completely explained.</p>
<p>Later in the Hobbit, it is said that 'Beorn indeed became a great chief afterwards in those regions and ruled a wide land between the mountains and the wood; and it is said that for many generations the men of his line had the power of taking bear's shape, and some were grim men and bad, but most were in heart like Beorn, if less in size and strength.' (The Hobbit Chapter 18 The Return Journey). It appears the ability to change shape into a bear was not exclusive to Beorn as an individual and may, in fact, have been an ability of a small sub-set within the race of Men.</p>
<h4>The Lord of the Rings</h4>
<p>In the years between the Battle of Five Armies and the War of the Ring, possibly spurred by his interaction with Thorin's company, Beorn emerged from his reclusion, and rose to become a leader of the woodmen living between the Anduin river and the fringes of Mirkwood. As stated by Glóin in The Fellowship of the Ring, the Beornings also 'keep open the High Pass and the Ford of Carrock.'</p>
<p>Some time before the War of the Ring itself began, Beorn was succeeded by his son Grimbeorn the Old. His death is not included in the chronologies in The Return of the King's appendices.</p>
<h4>Concept and creation</h4>
<p>In naming his character, Tolkien used beorn, an Old English word for man and warrior (with implications of freeman and nobleman in Anglo-Saxon society).[2] It is related to the Scandinavian names Björn (Swedish and Icelandic) and Bjørn (Norwegian and Danish), meaning bear; and the figure of Beorn can be related to the traditional Northern heroes Bodvar Bjarki and Beowulf.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Beorn";
            ImageArtist = Artist.Joel_M_Kilpatrick;

            Alias("Chieftain of the Beornings");
            Alias("Slayer of Bolg");
            AliasLink("Fearless Killing Machine", "https://www.youtube.com/watch?v=NtG7sUqOS4w");

            addFamily("Grimbeorn the Old (Son)", "Grimbeorn-the-Old");

            addFriend("Gandalf", "Gandalf");
            addFriend("Thorin's Company", "Thorin's-Company");

            Card("Beorn-THOHaUH");
            Card("Beorn-Core");
        }
    }
}