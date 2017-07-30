using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class BomburCharacter : Character
    {
        public BomburCharacter()
            : base("Bombur", "Bombur", "Dwarf")
        {
            Bio =
@"<p>Bombur was one of the Dwarves of Thorin's company who journeyed to Erebor to challenge the dragon Smaug. Bombur's distinguishing characteristic was his size for he was the fattest of the thirteen Dwarves. After the death of Smaug, Bombur lived at the Lonely Mountain.</p>
<h4>History</h4>
<p>Bombur's parentage is unknown; the only familial connections mentioned are his brother Bofur and his cousin Bifur. Bombur was not of Durin's line although he was descended from Dwarves of Moria. His birth year is also unknown. However, from Bilbo Baggins' account of the quest to Erebor it is known that the brothers Fíli and Kíli were the youngest of the thirteen 'by some fifty years'[5] and that after Thorin had been captured, Balin was 'the eldest left'.[6] Since Fíli was born in T.A. 2859 and Balin was born in 2763,[4] this would put Bombur's birth between 2809 and 2763, and he would have been between 132 and 178 years old during the quest to Erebor. Prior to the quest Bombur probably lived in the Blue Mountains with Thorin after the loss of Thráin II.</p>
<h4>The Quest of Erebor</h4>
<p>In T.A. 2941, Bombur was one of the four Dwarves in the fifth group to arrive at Bag End. When Bilbo jerked open his door the four fell on top of one another, with Thorin on the bottom and fat Bombur on top. Bombur wore a pale green hood and asked for pork-pie and salad for his refreshment. When Thorin later called for music, Bombur played a drum.</p>
<p>Despite his size, before the Trolls could capture Bombur he fought like mad. Because of the trouble he caused them the Trolls put him near their fire.</p>
<p>Running from the Goblins through their tunnels, Bombur carried Bilbo for part of the way, although he grumbled about it as he staggered with sweat dripping from his nose.</p>
<p>In the glade of the Wargs Bombur shared a pine tree with Bifur, Bofur, and Thorin.</p>
<p>When Gandalf was telling the story of the company's adventures to Beorn, Bifur, Bofur, and Bombur were the last of the Dwarves to show up. Gandalf had told Bombur to arrive last and alone because he was the fattest, but the offended Dwarf had refused to wait.</p>
<p>Bombur's most notable 'adventure' occurred at the Enchanted River. Beorn had warned them about its water and they did try to cross without touching it, but due to the charge of the deer, Bombur fell into the river. The company threw him a rope and he caught it, but upon landing he fell into an enchanted sleep. For six days the company took turns carrying the heavy slumbering Dwarf. When finally awake he had forgotten everything since the quest began and lamented waking up to no food, especially since his dreams had been about a great forest feast. After a day of walking Bombur had had enough and refused to take another step.</p>
<p>It was then that the first of the feasts of the Elves appeared north of the path. Bombur was for rushing to it but was restrained by the caution of the others. When they did attempt to enter the feasts everything vanished and eventually all of the Dwarves except Thorin were captured by the spiders. After the spiders had strung up the Dwarves, Bombur's fatness was again a problem for it attracted the attention of one of the creatures who bit him on the nose. Bombur kicked the spider, who would have killed him had Bilbo not intervened. Despite this activity Bombur was nearly exhausted; when freed he fell off his branch and luckily had his fall cushioned by leaves.</p>
<p>After the barrel ride down the River Running both Bombur was found to be asleep or senseless.</p>
<p>While the rest of the company climbed up to the 'doorstep' on the side of the Lonely Mountain, Bombur and Bofur remained in the valley to tend to the ponies. While Bofur was willing to ascend by rope for changes of the guard, Bombur demurred, claiming that he would either grow dizzy or the rope would break.[13] However, when Smaug came roaring out to scour the mountainside Bombur's reluctance vanished and he was hauled up the cliff.</p>
<p>Although Bombur supported Thorin's decision to defy the Elves and Men and withstand a siege, he felt it was a 'sorry business altogether' and deemed Thorin 'ever a dwarf with a stiff neck'. Wishing for a strong drink and a soft bed, Bombur was easily convinced when Bilbo offered to take his turn as watchman. Bombur did sleep and thanked Bilbo later when the Hobbit woke him up after midnight.</p>
<p>Bombur fought in and survived the Battle of Five Armies. He was given his share of the treasure by Dáin Ironfoot, and made his home in Erebor.</p>
<h4>Later Life</h4>
<p>At Rivendell in December, T.A. 3018, Glóin told Frodo Baggins that Bombur was still alive and living in Erebor. In fact, Bombur appeared to have used some of his wealth to increase his girth – he was unable to move alone from couch to table and required the aid of six young Dwarves to lift him. Given his age and immobility it is doubtful that Bombur fought in the Battle of Dale.</p>
<h4>Etymology</h4>
<p>Bombur, or Bumburr, is a dwarf from the Dvergatal. His name most likely means 'the Swollen One'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Bombur";
            ImageArtist = Artist.Joe_Shawcross;

            addFamily("Bofur (Brother)", "Bofur");
            addFamily("Bifur (Cousin)", "Bifur");

            addGroup("Thorin's Company", "Thorin's-Company");

            Card("Bombur-THOtD");
            Card("Bombur-RtR");
        }
    }
}