using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class BeregondCharacter : Character
    {
        public BeregondCharacter()
            : base("Beregond", "Beregond", "Man")
        {
            Bio =
@"<blockquote>&ldquo;I am no captain. Neither office nor rank nor lordship have I, being but a plain man of arms of the Third Company of the Citadel.&rdquo;
<br>― Beregond
</blockquote>
<p>Beregond, son of Baranor, was a soldier of Gondor and later Captain of the White Company.</p>
<h3>History</h3>
<h4>Early Life</h4>
<p>Beregond's fathers were from the vales of the White Mountains, and prior to that they lived in Ithilien.[1] Beregond had two sons, Bergil, who was ten years of age at the time of the War of the Ring,[1] and a younger son named Borlas.</p>
<p>Beregond was a member of the Third Company of the Citadel. He admired Faramir and saw him as a brave warrior and a great leader. Beregond did not travel outside of Minas Tirith often but understood the threat that Sauron posed to the city.</p>
<h4>War of the Ring</h4>
<p>On the morning of March 9th, T.A. 3019, Beregond was assigned to help Peregrin Took who had just become a Guard of the Citadel. As Beregond had never met a hobbit before, he was eager to meet Pippin and he was astounded that Pippin looked much like a child yet had faced more dangers than most Men of Gondor.</p>
<h4>Battle of Pelennor Fields</h4>
<p>During the Battle of Pelennor Fields, Beregond was on watch as the sentinel at the gate of the Citadel. Pippin rushed to tell him that Denethor was attempting to burn Faramir alive. Beregond knew his duty of protecting Faramir was more important than to remain at his post so he rushed to his Captain at the Silent Street. The guard to the street would not let him pass and Beregond was forced to kill him so he could enter. He regretted his decision but he was forced to act quickly. Two more servants of Denethor's guard were killed as they attempted to light the funeral pyre. He stood upon the steps with his sword to ward off the rest until Gandalf arrived. After Faramir was rescued, Denethor would still not give up, and drew a knife to attempt to kill his son, but Beregond stepped forward to block Denethor. Denethor then gave up and set himself on fire and died.</p>
<p>After helping to carry Faramir to the Houses of Healing, Gandalf gave the key to the Closed Door to the injured Faramir. Beregond stood guard over Faramir at the Houses of Healing and was present when he awoke.</p>
<h4>Battle of the Morannon</h4>
<p>Pippin and Beregond served under the command of Imrahil at the Battle of the Morannon. When a Troll-chief charged their ranks, Beregond was stunned and nearly killed, but Pippin managed to save his friend by killing the Troll, which fell on top of him.</p>
<h4>Later Life</h4>
<p>Upon Aragorn's coronation on May 1st, Beregond was brought forward to receive judgement for leaving his post and for killing Denethor's guards on hallowed ground. The penalty would have been death, but the King showed mercy as the deeds were done out of love for Faramir, and Beregond was merely forbidden from returning to the White City ever again. For his bravery in battle, Aragorn appointed him the Captain of the Guard of Faramir, which was also called the White Company. He later went to live in Emyn Arnen in Ithilien to serve his lord, Faramir, the new Prince of Ithilien.</p>
<h4>Etymology</h4>
<p>'Beregond' may stem from beren meaning 'bold' and gond meaning 'stone'. He was likely named after the steward bearing the same name.</p>
<h4>Genealogy</h4>
<p>Beregond was descended from people of the vales of the White Mountains and Ithilien. What exactly his relation to Iorlas, described only as an uncle of Bergil,[1] was, is unknown.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Beregond";
            ImageArtist = Artist.Magali_Villeneuve;

            addFamily("Bergil (Son)");

            addFriend("Denethor", "Denethor");
            addFriend("Boromir", "Boromir");
            addFriend("Faramir", "Faramir");
            addFriend("Pippin", "Pippin");

            addItem("Gondorian Shield", "Gondorian-Shield-TSF");
            addItem("Livery of the Tower", "Livery-of-the-Tower-TFotW");

            Card("Beregond-HoN");
            Card("Beregond-TFotW");
        }
    }
}