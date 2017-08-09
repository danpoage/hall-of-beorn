using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class TheGreyCompanyGroup : CharacterGroup
    {
        public TheGreyCompanyGroup()
            : base("The Grey Company", "The Grey Company")
        {
            Bio =
@"<p>The Grey Company was a company of thirty Northern Dúnedain (clad in grey) commanded by Aragorn's kinsman Halbarad.</p>
<h4>History</h4>
<p>Halbarad received a mysterious message requesting to come to the aid of his Chieftain Aragorn at Rohan (Legolas later surmised that it was actually sent by Galadriel who could read the hearts of men). Gathering thirty of his kin, and aided by Elladan and Elrohir who wished to join the war, they rode south to Rohan. They found Aragorn near Dol Baran before dawn on 6 March, T.A. 3019[2] and he admitted that Halbarad was often in his thoughts but had sent no message. Halbarad bore with him a furled standard, which was a gift from Arwen, and a message from her; and Elrohir conveyed a message from Elrond to take the Paths of the Dead. They journeyed with the Rohirrim to Helm's Deep, where they parted ways.</p>
<p>The Rangers rode through the plains of Rohan and reached Dunharrow by morning of 7 March. Théoden had not yet arrived, and Éowyn in vain begged Aragorn to avoid the Paths of the Dead.</p>
<p>Spurred only by the strength of Aragorn's will, the Company with Legolas and Gimli entered the dark path the next day. At midnight Aragorn summoned the Dead at a clearing to follow him to the Stone of Erech. After creeping in the darkness for what seemed like ages, the Company emerged from the Paths and rode quickly through the mountain fields with the Dead behind. They followed the river Morthond briefly to Erech. The inhabitants of the surrounding countryside fled in fear, calling Aragorn the 'King of the Dead'.</p>
<p>Arriving at the large, black Stone of Erech, the legion of the Oathbreakers announced their allegiance to Aragorn. Aragorn unfurled a black flag and pronounced himself the Heir of Isildur’s kingdom. The Company rides on to Anduin.</p>
<p>On 9 March they led the Oathbreakers over Tarlang's Neck, across the Ciril and Ethring on the way to Pelargir and reached Calembel.[1] A day later they passed across the river Ringló.</p>
<p>While in Lamedon, the Dead drove forth the assailants from Linhir, but the staunch defenders fled as well, except for Angbor. Aragorn bade him gather his folk and follow them. After Linhir they reached Lebennin. The Corsairs of Umbar were beaten back to Pelargir the next day.</p>
<p>On 13 March they found Pelargir overrun by Corsairs once again with fifty great ships and many more smaller vessels ready to sail to Harlond. The Company and the Dead drove the Corsairs away. After manning the Black Ships, Aragorn released the curse of the Dead.[3] Halbarad captained a Corsair ship and they sailed toward Harlond.</p>
<p>They arrived at the Battle of the Pelennor Fields on 15 March, where Halbarad fell.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Grey_Company";
            ImageArtist = Artist.Aleksander_Karcz;

            addLeader("Halabarad", "Halbarad");

            addMember("Elladan", "Elladan");
            addMember("Elrohir", "Elrohir");

            Card("The-Passing-of-the-Grey-Company-Campaign-TFotW");
        }
    }
}