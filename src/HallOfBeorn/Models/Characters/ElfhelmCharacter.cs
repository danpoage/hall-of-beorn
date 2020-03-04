using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class ElfhelmCharacter : Character
    {
        public ElfhelmCharacter()
            : base("Elfhelm", "Elfhelm", "Man")
        {
            Bio =
@"<p>Elfhelm was the Marshal of the East-mark of Rohan during the War of the Ring (he served in this position from T.A. 3012-3019).</p>
<h4>History</h4>
<p>In the First Battle of the Fords of Isen on 25 February T.A. 3019, Elfhelm had been riding in haste from Edoras, leading four companies in answer to Théodred's summons. When he reached the junction of the horse-road and the road down from the Deeping, his outriders reported that two wolf-riders had been seen abroad on the fields. Sensing that something was amiss, he did not turn aside to Helm's Deep for the night as he had intended but rode with all speed towards the Fords of Isen. And though his men and horses were weary, as he came in sight of the east banks, he ordered his companies to charge.[2] The king's son, Théodred, was struck down by a great orc-man just as Grimbold reach him on a knoll east of the river. Grimbold himself was in mortal peril but Elfhelm, leading four companies of riders, charged in and saved his life. Together Elfhelm and Grimbold found that Théodred was still alive, but only long enough to speak his last words.</p>
<p>Prior to the Second Battle of the Fords of Isen on 2 March, the news of Théodred's death caused Erkenbrand of Westfold to assume command of the West-mark. He kept Grimbold in charge of the field. Elfhelm, of the Muster of Edoras, remained independent, but coordinated his efforts with Grimbold. Elfhelm deemed the Fords to be a trap and set his companies to the east of the river to hold up the enemy's advance (that they would advance soon was an opinion shared by both men). Grimbold put foot-soldiers on both sides of the Fords with Théodred's remaining cavalry on the east bank.</p>
<p>When the Second Battle began Saruman's forces heavily engaged the western forts and put troops of Uruks across the Fords. Grimbold had to retreat to the eastern bank of the Isen. At midnight Saruman's forces, now reinforced, attacked. Grimbold looked for aid from Elfhelm but none came; the greater part of Saruman's host came between Grimbold and Elfhelm and drove the latter eastwards.[3] At this point Gandalf appeared and gave orders that Elfhelm ride to Edoras.</p>
<p>After the Battle of Helm's Deep, at Harrowdale, Elfhelm was assigned to lead the first éored of the Muster of the East-mark.[1] During the ride to Gondor the men of Elfhelm's command ignored Merry riding with Dernhelm. Eventually Elfhelm spoke to Merry after he tripped over him in the dark and told him that the drums he heard were those of the Woses in Druadan Forest. After the ride through these woods Elfhelm described to the king and Éomer the lay of the land just before Minas Tirith since he had been there in days of peace. Just before the charge across the Pelennor Fields (on 25 March 3019) King Théoden placed Elfhelm and his command on the right.[5] After the initial charge, the right wing of the Rohirrim was closest to the walls of Minas Tirith and Elfhelm's riders tore into the Orcs about the siege-engines and drove their foes into the fire-pits.</p>
<p>After the Battle of Pelennor Fields, Elfhelm led three thousand Rohirrim up towards the Drúadan Forest, to destroy the last foes left of Mordor's force that had crossed the Anduin and had been assigned to block the northward road.[7] These Orcs and Easterlings actually were leaving Anórien by the time Elfhelm's riders caught up with them and they fled to Cair Andros.</p>
<p>Elfhelm was one of the chief witnesses at the coronation of Aragorn on 1 May 3019.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Elfhelm";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Mashal of the East-mark");

            addFriend("Théodred", "Theodred");
            addFriend("Grimbold", "Grimbold");
            addFriend("Éomer", "Eomer");

            addGroup("The Rohirrim", "The Rohirrim");
        }
    }
}
