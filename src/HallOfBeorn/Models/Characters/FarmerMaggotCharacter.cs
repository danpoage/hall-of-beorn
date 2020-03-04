using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class FarmerMaggotCharacter : Character
    {
        public FarmerMaggotCharacter()
            : base("Farmer Maggot", "Farmer Maggot", "Hobbit")
        {
            Bio =
@"<p>Farmer Maggot was a Hobbit who at the time of the War of the Ring owned a farm called Bamfurlong in the Marish in the Eastfarthing of the Shire. Like most inhabitants of the Marish, which was fertile but boggy, Maggot and his family lived in a house instead of a hobbit-hole. Maggot had a wife, at least two sons and three daughters, plus a few other hobbits who belonged to the farm.</p>
<p>Farmer Maggot was a shrewd hobbit who was familiar with Tom Bombadil and friendly to all Brandybucks. Living in the borderlands Maggot had to be more on his guard than most Hobbits and for protection he kept three huge dogs called Grip, Fang, and Wolf.</p>
<h4>History</h4>
<p>When Frodo Baggins was young he lived in Brandy Hall and used to sneak into Farmer Maggot's fields to steal mushrooms. After catching Frodo thieving several times, Maggot finally beat the young mushroom poacher and had his dogs chase Frodo all the way to the Bucklebury Ferry. Frodo remained terrified of the old farmer and his dogs thereafter.</p>
<p>On 25 September of T.A. 3018, Maggot was approached by a Black Rider who asked him if he has seen Baggins. Maggot told him that the Bagginses were in Hobbiton. The rider said that this Baggins had left Hobbiton and that he would reward Maggot with gold if he informed him the next time he came. Maggot however, despite the chill this stranger caused him, was enraged by his trespassing and threatened him with his dogs. Though Maggot's dogs yelped and ran, the rider, infuriated by the hobbit's defiance, hissed and left like thunder.</p>
<p>Later that day Frodo, Sam and Pippin came to Maggot's farm. After Mrs. Maggot served the travelers mugs of beer, Maggot related his story about the stranger. Frodo thanked the farmer for his hospitality and said that they had to hurry along. Maggot then offered the hobbits supper and said that he would take them by wagon to the Ferry thereafter. The invitation was gratefully accepted.</p>
<p>In the night Maggot and his passengers headed for the Ferry, and they encountered Merry looking for them. Upon reaching their destination, Maggot set out for home after giving Frodo a gift from Mrs Maggot. The gift was a basket of mushrooms.</p>
<h4>Etymology</h4>
<p>Tolkien says that the name 'Maggot' was a Hobbitish name whose meaning has been lost in history. Maggot should not be understood as the English word maggot or larva. The similarity is coincidental.</p>
<h4>Other Versions of the Legendarium</h4>
<p>In the first phase of writing The Lord of the Rings the visit to Farmer Maggot was roughly the same as the final version, but in a much abbreviated form. Bingo (who would later be named Frodo Baggins) had never stolen mushrooms from Bamfurlong. The farmer had only one small dog named Gip and while he had a wife, no children or other members of the household were mentioned. At the first sight of the dog, Bingo put on his Ring and stayed invisible during the visit. Odo and Frodo Took (who were later changed into Pippin and Sam) enjoyed a beer while Maggot told them of the visit by the Black Rider. At the end of the story invisible Bingo lifted Maggot's mug and drank his beer, scaring the old farmer who was glad to see the two (visible) hobbits run away. The hobbits did not get a wagon ride to the Ferry nor did they receive any mushrooms.</p>
<p>When J.R.R. Tolkien came to write about Tom Bombadil he toyed with the idea of making Farmer Maggot some other creature than a hobbit, possibly akin to Tom himself. As this notion brewed a line was given to Frodo Took stating that Maggot was 'not a hobbit – not a pure hobbit anyway' and that he had hair under his chin.</p>
<p>Farmer Maggot changed considerably in the second phase of writing the story, although he was still a hobbit. Now the One Ring was much more dangerous and Bingo was not supposed to wear it frivolously. However, Tolkien still wanted to retain the mysteriously levitating beer mug incident, which meant that Bingo had to wear the Ring in Maggot's house. To justify this the visit to Bamfurlong took on a much darker hue. Young Bingo used to steal mushrooms. One day, in fear of being mauled, he threw a rock at one of the farmer's dogs and killed it. Maggot beat Bingo and told him he would kill him the next time he trespassed, and would have killed him then if Bingo had not belonged to a rich and powerful family. When the hobbits approached the farm, terrified Bingo slipped on the Ring. Inside the house Maggot emphasized his unrelenting hostility toward all Bagginses. Bingo pulls the floating beer mug trick but then berates the bewildered farmer, pushes him into the fire-irons, and makes his hat sail out of the house.</p>
<p>Christopher Tolkien commented that the difficulty of keeping the Ring secret eventually killed this version. When the story was rewritten again to make Maggot a shrewd but kindly soul the last of the lighthearted tricks with the Ring was removed from the developing story.</p>
<p>In yet another version of the beginning Farmer Maggot's hostility, it was Bilbo and Bingo who stumbled onto Maggot's farm one foggy evening. They accidentally got into his garden and Maggot set a great wolf-like dog upon them. Bilbo broke the dog's head to save Bingo from a mauling and Maggot flung Bilbo into a ditch. Maggot threatened to kill Bingo, Bilbo threatened to come back armed, and Maggot said he had a weapon or two himself.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Farmer_Maggot";
            ImageArtist = Artist.Adam_Lane;

            addFamily("Mrs. Maggot");

            addFriend("Tom Bombadil", "Tom-Bombadil");
            addFriend("Frodo Baggins", "Frodo-Baggins");
            
            addGroup("The Shire", "The-Shire");
        }
    }
}
