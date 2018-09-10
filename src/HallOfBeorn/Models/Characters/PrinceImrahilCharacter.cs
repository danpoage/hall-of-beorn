using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class PrinceImrahilCharacter : Character
    {
        public PrinceImrahilCharacter()
            : base("Prince Imrahil", "Prince Imrahil", "Man")
        {
            Bio =
@"<p>Imrahil was the twenty-second Prince of Dol Amroth. Imrahil was the son of Adrahil II. He had two older sisters, Ivriniel and Finduilas. After his father's death, he became Prince in T.A. 3010. Imrahil had four children: Elphir, Erchirion, Amrothos and Lothíriel.[1]
<p>During the War of the Ring, Imrahil came to the aid of his brother-in-law, Denethor II. On 9 March, T.A. 3019, he came into Minas Tirith with a company of knights and seven hundred soldiers.[2] On 13 March, as Southrons harrassed Faramir, Imrahil and his knights, with Gandalf, formed a sortie, and Imrahil himself saved his sister-son from his pursuers. Faramir received a poisonous wound, and Denethor fell to madness. Being the highest ranking officer in Gondor fit for battle, Imrahil took command, and quickly passed it on to Gandalf.</p>
<p>Two days later, the Battle of the Pelennor Fields raged before the city. Imrahil ventured outside the city, and witnessed the funeral procession of Théoden. He recognized that Éowyn still lived (though she lie an inch from death), and brought her to the Houses of Healing.</p>
<p>Because Éomer and his riders were outnumbered, Imrahil rode into battle, together with Húrin the Tall, Forlong of Lossarnach and Hirluin the Fair, and they were soon joined by Aragorn who landed at Harlond. Imrahil continued East, driving the frightened Variags and orcs away.</p>
<p>Imrahil survived the battle unscathed, and together with Éomer and Aragorn he came to the Great Gate of Minas Tirith.[3] Imrahil recognized that Aragorn was the rightful King, but he agreed that it was wise for Aragorn to wait to enter the city, because he knew Denethor was strong-willed and proud.</p>
<p>When Imrahil learned that Denethor was dead and Faramir dying, he suggested that Aragorn be summoned, remembering that the Kings of old were great healers. Aragorn came at Gandalf's request to heal the wounded Faramir, Éowyn, and Merry, but he declared that Prince Imrahil should rule the City until Faramir awoke, in effect granting Imrahil the position of Steward.</p>
<p>During the debate of the Captains of the West, Gandalf proposed that they march to the Morannon to distract Sauron's attention from Frodo the Ring-bearer. Imrahil said that he would follow his liege Aragorn, but since Minas Tirith was under his command the Prince advised that some should remain to defend the City. In the end it was decided that an army of 7,000 would ride forth. Imrahil laughed at the thought.[4] Húrin the Tall was left behind in command.</p>
<p>The Host of the West left Minas Tirith on 18 March. Bypassing Minas Morgul and marching North, the heralds announced the coming of King Elessar at Imrahil's advice. When Sauron's forces emerged from the Black Gate on March 25, Imrahil stood on the front line with his men. They fought the Battle of the Morannon until the One Ring was destroyed.</p>
<p>Prince Imrahil was present at the celebrations of the field of Cormallen, and the coronation of Aragorn as King Elessar, and rode with the funeral procession of King Théoden to Rohan, remaining in Edoras after the King's burial on August 10. Imrahil and Éomer became great friends, and in Fo.A. 2 Éomer wed Imrahil's daughter Lothíriel.[5]</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Imrahil";
            ImageArtist = Artist.Donato_Giancola;

            Alias("Prince of Dol Amroth", "Prince-of-Dol-Amroth-TCoC");
            Alias("Steward of Gondor", "Steward-of-Gondor-Core");

            addFamily("Adrahil II (Father)");
            addFamily("Ivriniel (Sister)");
            addFamily("Finduilas (Sister)");
            addFamily("Elphir (Son)");
            addFamily("Erchirion (Son)");
            addFamily("Amrothos (Son)");
            addFamily("Lothíriel (Daughter)");

            addFriend("Aragorn", "Argorn");
            addFriend("Faramir", "Faramir");
            addFriend("Éomer", "Eomer");

            LotRCard("Prince-Imrahil-AJtR");
            LotRCard("Prince-Imrahil-TCoC");
            LotRCard("Prince-Imrahil-TFotW");
        }
    }
}