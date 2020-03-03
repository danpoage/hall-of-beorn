using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class ErkenbrandCharacter : Character
    {
        public ErkenbrandCharacter()
            : base("Erkenbrand", "Erkenbrand", "Man")
        {
            Bio =
@"<blockquote>
&ldquo;Amid them strode a man tall and strong. His shield was red. As he came to the valley's brink, he set to his lips a great black horn and blew a ringing blast. 'Erkenbrand!' the Riders shouted. 'Erkenbrand!'&rdquo;
<br>― The Two Towers, Helm's Deep
</blockquote>
<p>Erkenbrand was one of the Rohirrim. He was the Lord of the Westfold during the War of the Ring. He was the uncle of Dúnhere.</p>
<h4>History</h4>
<p>Erkenbrand was presumably born in the Hornburg, and followed his father as the Lord of the Westfold. He became a valiant knight in the service of the King of Rohan, but nothing is told of the deeds of those times. He retired, and settled in the Hornburg.</p>
<p>When the shadow from Isengard began to grow, Erkenbrand strengthened the defenses of the Hornburg and the Deeping Wall. After the death of Théodred on 25 February, T.A. 3019 in the First Battle of the Fords of Isen, Erkenbrand took command of the western defenses of Rohan. He sent a messenger to Théoden in Edoras to inform him of the ill news and ask for reinforcements, but Gríma Wormtongue delayed the message.</p>
<p>Elfhelm eventually rode to the Fords of Isen with the men of Edoras, where they joined Grimbold of Grimslade, who was left in charge of the Fords when Erkenbrand tried to send stragglers from the first battle to Helm's Deep. Erkenbrand had left around 1000 troopers under Gamling the Old to guard his home.</p>
<p>On March 2, the Second Battle of the Fords of Isen was fought, and the defenses on the Isen were driven back by Saruman's forces. Erkenbrand had managed to gather around a thousand soldiers when they came across Gandalf. Gandalf told them Théoden sought the refuge of the Hornburg, and that they would join the battle. They arrived at dawn of March 4, and turned the tide of the Battle of the Hornburg.</p>
<p>Erkenbrand did not come to Minas Tirith to fight in the Battle of the Pelennor Fields; instead, he stayed behind to guard Rohan. He was granted this command because of his age, experience and authority.</p>
<p>After the War of the Ring, King Éomer named Erkenbrand Marshal of the West-mark.</p>
<h4>Appearance</h4>
<p>Erkenbrand was said to have been tall and strong, and reminiscent of Helm Hammerhand. He bore a red shield and a black horn.</p>
<h4>Etymology</h4>
<p>Erkenbrand is a name that possibly was derived from two Old English words: eorcan (meaning 'precious') and brand (meaning 'fire-brand, torch; sword').</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Erkenbrand";
            ImageArtist = Artist.Sebastian_Giacobino;

            TheTwoTowers();

            Alias("Lord of the Westfold");
            Alias("Marshal of thw West-mark");

            addFriend("Éomer", "Eomer");
            addFriend("Grimbold", "Grimbold");
            addFriend("Elfhelm", "Elfhelm");

            addGroup("The Rohirrim", "The-Rohirrim");

            DigitalCard("Erkenbrand-Valor");
        }
    }
}