using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class BifurCharacter : Character
    {
        public BifurCharacter()
            : base("Bifur", "Bifur", "Dwarf")
        {
            Bio = 
@"<p>Bifur most likely lived in the Blue Mountains with Thorin after the loss of Thráin II.[2] Bifur was one of the thirteen Dwarves of Thorin's company who journeyed to Erebor to challenge the dragon Smaug. After the death of Smaug, Bifur lived at the Lonely Mountain.</p>
<h4>History</h4>
<p>Bifur was descended from Dwarves of Moria but himself was not of Durin's line.[2] He was cousin[4] of the brothers Bombur and Bofur.</p>
<p>Bifur was older than Fíli and Kíli (b. T.A. 2859[2]) at least 'by some fifty years' but younger than Balin (b. 2763[2]).[7] Bifur was born anytime between 2763 and 2809, and he would have been between 132 and 178 years old when he joined King Thorin's operation to reclaim Erebor.</p>
<h4>The Quest of Erebor</h4>
<p>In T.A. 2941, Bifur was one of the four Dwarves in the fifth group to arrive at Bag End, wearing a yellow hood. He asked for raspberry jam and apple-tart. During the evening when Thorin called for music, Bifur (along with Bofur) played a clarinet.</p>
<p>In the wolves' glade Bifur shared a pine tree with Bofur, Bombur, and Thorin.</p>
<p>When Gandalf was telling the story of the company's adventures to Beorn, Bifur, Bofur, and Bombur were the last of the Dwarves to show up.</p>
<p>After the barrel ride down the River Running both Bifur and Bofur came out fairly dry and not very knocked about, but they lay down and refused to do anything.</p>
<p>On the doorstep on the side of the Lonely Mountain, when Thorin commented that the next day was the beginning of the last week of autumn, Bifur pointedly added, 'And winter comes after autumn'.</p>
<p>Bifur fought in and survived the Battle of Five Armies. He was given his share of the treasure by Dáin Ironfoot, and made his home in Erebor.</p>
<h4>Later Life</h4>
<p>By T.A. 3018 Bifur was living in Erebor, as Glóin told Frodo Baggins at Rivendell.</p>
<h4>Etymology</h4>
<p>The name of Bívurr originates in the Dvergatal. It is of Old Frisian origin, meaning 'Beaver' or, by extension, 'Hard Worker'.</p>
<h4>Other Versions of the Legendarium</h4>
<p>In one of the earliest manuscript fragments of The Hobbit, Bifur and Bofur went into the hall and came back with their walking sticks, which they turned into clarinets.[15] In the published text the two Dwarves came back from the hall with clarinets that they had left with their walking sticks.[8] John Rateliff (author of The History of The Hobbit) said that in the earliest phase Tolkien had added fairy tale touches of Dwarven magic to emphasize the uncanny, other-worldly nature of the Dwarves as opposed to Bilbo.</p>
<p>Originally, when Bombur needed propping up in Mirkwood after being cut from the spiders' webbing, it was his cousins Bifur and Bofur who provided support.[17] In the published story this was changed to Bombur's cousin Bifur and brother Bofur.[5] Also, in the earlier version, when Smaug first came out and the Dwarves in the valley had to be hauled up to the Back Door, Bifur cried out to save Bombur and Bofur, who were both his brothers.[18] In the published text Bifur cried out for his two cousins.</p>
<p>In Tolkien's unfinished 1960 rewrite of The Hobbit, Bifur, Bofur and Bombur were Thorin's attendants.[19] John D. Rateliff assumes this made them either courtiers or honor-guard.</p>
<h4>Notes</h4>
<p>In the earliest partial manuscript of The Hobbit more of the dialog later assigned to a few of the Dwarves is more evenly distributed. In the opinion of John Rateliff (author of The History of The Hobbit) this streamlining strengthened the story through simplification, but at the cost of relegating some of the Dwarves to obscurity since they barely speak at all. Bifur is one of these 'silenced' members of the company.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Bifur";
            ImageArtist = Artist.Magali_Villeneuve;

            addFamily("Bofur (Cousin)", "Bofur");
            addFamily("Bombur (Cousin)", "Bombur");

            addFriend("Thorin Oakenshield", "Thorin-Oakenshield");
            addFriend("Glóin", "Gloin");

            addGroup("Thorin's Company", "Thorin's-Company");
        }
    }
}