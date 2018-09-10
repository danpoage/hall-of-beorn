using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters.Groups
{
    public class TheBeorningsGroup : CharacterGroup
    {
        public TheBeorningsGroup()
            : base("The Beornings", "The Beornings")
        {
            Bio =
@"<p>Beornings were a people of the upper Vales of Anduin, between Mirkwood and the Misty Mountains.</p>
<h3>History</h3>
<p>As other Northmen, the Beornings descended from Men of the First Age who were related to the Edain, perhaps akin to the Third House. As such, the Beornings were close kin of the Éothéod, the Woodmen of Mirkwood and the Bardings.<p>
<p>After the Battle of Five Armies and the decimation of the Orcs of the Misty Mountains, many Northmen gathered around Beorn who became a great chief. It is possible that the Beornings became known as a people through being descendants of Beorn.</p>
<p>The Beornings kept open the passages of the Ford of Carrock and the High Pass in return for tolls, likely clearing the paths from Dale to Rivendell from evil creatures such as Orcs and Wargs.</p>
<p>In the events leading up to the War of the Ring, the Beornings helped Aragorn, who was taking Gollum to Mirkwood, to cross the Anduin.</p>
<p>During the War, Grimbeorn, son of Beorn, was the leader of the Beornings. It is possible that Sauron's forces had attacked them in early T.A. 3019: when Frodo Baggins wore the One Ring upon Amon Hen, he saw the land of the Beornings aflame.</p>
<p>After the War, the Beornings and the Woodmen were given central Eryn Lasgalen by Thranduil and Celeborn.</p>
<h3>Characteristics</h3>
<p>They spoke the Common Speech, and had perhaps also their own dialect of it or tongue.</p>
<p>Through many generations, the descendants of Beorn were like him skin-changers, able to take the shape of a bear. Some of Beorn's descendants were grim like him and even 'bad', but none of them matched Beorn in size and strength.</p>
<p>The Beornings seemed to have shared a dislike for Dwarves, perhaps related to the latters' praise of metals and the formers' disinterest in it.</p>
<p>They were known as great bakers, famous for their honey-cakes (which could feed travellers similarly to the lembas) although they were reluctant to share them with travelers around the time of the War of the Ring.</p>
<h3>Etymology</h3>
<p>Beorn is an Old English word meaning 'a warrior, a hero, a man of valour' (also, poetic 'man'), cognate to Old Norse björn ('bear'). In the Scandinavian-speaking countries Björn/Bjørn is a personal name, attested since the 11th century.</p>
<p>The ending -ings (or -ingas) is a suffix, used in the Legendarium to denote such people that belonged to a certain leader, or that were the descendants of a common fore-father. Thus, Beornings can be thought of as 'Beorn's people' or 'The people of the bear'.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Beornings";
            ImageArtist = Artist.Justin_Gerard;

            addLeader("Beorn", "Beorn");
            addLeader("Grimbeorn the Old", "Grimbeorn-the-Old");

            addArticle("https://visionofthepalantir.wordpress.com/2018/03/16/beorning/", "Vision of the Palantir Trait Review");

            LotRCard("Beorning-Beekeeper-CatC");
            LotRCard("Beorning-Guardian-CoP");
            LotRCard("Beorn's-Rage-TWH");
        }
    }
}