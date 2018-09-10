using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class HamaCharacter : Character
    {
        public HamaCharacter()
            : base("Háma", "Háma", "Man")
        {
            Bio =
@"<blockquote>
&ldquo;The staff in the hand of a wizard may be more than a prop for age. Yet in doubt a man of worth will trust to his own wisdom.&rdquo;
<br>― Háma
</blockquote>
<p><b>Háma</b> was the Doorward of Théoden and Captain of the King's Guard of Rohan. He was a loyal and devoted man, though he often anticipated his orders.</p>
<h4>History</h4>
<p>Háma served as the doorguard of Edoras, the abode of the King of Rohan. On 2 March T.A. 3019, four guests arrived at his post: Aragorn, Gimli, Legolas and Gandalf.[2] He stood by the rules of the house, and ordered them all to surrender their weapons. He entered into a long argument with Aragorn who refused to hand Andúril to anyone else until he agreed to do so at the wish of Gandalf. He permitted Gandalf to keep his staff, a deliberate decision which would prove decisive in the healing of his king.</p>
<p>For this oversight, Háma was reprimanded by Théoden, and briefly relieved of his position as the doorguard. Háma did his Lord's bidding, and also released Éomer from captivity. The King's sister-son was imprisoned by Gríma Wormtongue, who was shortly before overthrown with the use of Gandalf's staff. Háma arrested Gríma, and found various missing items in his possession, including Herugrim, the King's sword.</p>
<p>Háma rode with Théoden to the Hornburg, and fought in the battle that ensued shortly after. He fell before the great gate, and his body was hacked to pieces by a horde of Uruks.[3] He was given the honour of being buried in a grave of his own under the shadow of the Hornburg. Despite his annoyance with his doorward, Théoden obviously had an affection for Háma, and grieved at his fall, so much so that that he personally cast first earth on his grave.</p>
<p>On 5 March when Théoden rejected the words of Saruman the hewing of Háma's body before the gate of the Hornburg was among the grievances he cited.</p>
<h4>Etymology</h4>
<p>The name Háma comes from Old English, and means as much as 'home, house, dwelling'. The same element is used in Hamfast.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Hama";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Captain of the King's Guard");
            Alias("Doorwarden of Meduseld");

            addFriend("Théoden", "Theoden");
            addFriend("Éomer", "Eomer");

            addGroup("The Rohirrim", "The-Rohirrim");

            LotRCard("Hama-TLD");
            LotRCard("Hama-ToS");
        }
    }
}