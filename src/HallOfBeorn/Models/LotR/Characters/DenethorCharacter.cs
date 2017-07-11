using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class DenethorCharacter : Character
    {
        public DenethorCharacter()
            : base("Denethor", "Denethor II, son of Ecthelion", "Man")
        {
            Bio =
@"<p>Denethor II, son of Ecthelion II, is a fictional character in J. R. R. Tolkien's The Return of the King, which is the third and final part of his novel The Lord of the Rings. He is the 26th and final Ruling Steward of Gondor.</p>
<p>Denethor was born in T.A. 2930, the first son and third child of Ecthelion II.[1] Ecthelion became the 25th Ruling Steward of Gondor in T.A. 2953, and at the same time Denethor became the heir apparent, inheriting the Horn of Gondor. He succeeded his father as Denethor II in T.A. 2984.</p>
<p>As stated in the early chapters and the Appendices of The Return of the King, Denethor was widely considered a man of great will, foresight, and strength. However, he failed to reach out to his people, who flocked instead to Thorongil, an outsider who served Denethor's father with great renown. Thorongil vanished from Gondor four years before Denethor would succeed his father as Ruling Steward. Thorongil (who was secretly Aragorn, Chieftain of the Dúnedain of the North and hence a claimant to Gondor's throne) had advised Ecthelion to put faith in the wizard Gandalf, whom Denethor distrusted.</p>
<p>In T.A. 2976 Denethor had married Finduilas, daughter of Prince Adrahil of Dol Amroth. She gave birth to two sons, Boromir and Faramir, before dying when they were ten and five years old, respectively (T.A. 2988). Denethor never remarried, and became more grim and silent than before.</p>
<p>In a conversation with Pippin just before the first meeting with Denethor, Gandalf described Denethor as '…proud and subtle, a man of far greater lineage and power [than Théoden of Rohan], though he is not called a king.' Following that meeting, after Pippin has sworn fealty to Denethor, Gandalf further commented:</p>
<blockquote>He is not as other men of this time…by some chance the blood of Westernesse runs nearly true in him, as it does in his other son, Faramir, and yet did not in Boromir. He has long sight. He can perceive, if he bends his will thither, much of what is passing in the minds of men, even of those that dwell far off. It is difficult to deceive him, and dangerous to try.[2]</blockquote>
<p>Unlike Saruman, Denethor was too strong to be corrupted by Sauron. In the novel, he began secretly using a palantír to probe Sauron's strength, though he incorrectly insisted he was able to control it. The effort aged him quickly, and the knowledge of Sauron's overwhelming force depressed him greatly, mostly due to deliberately biased visions from the palantír on the part of Sauron. Boromir's death depressed Denethor further, and he became ever more grim. Nonetheless he continued to fight Sauron with every resource at his disposal until the forces of Mordor arrived at the gates of the White City, at which point he lost all hope.</p>
<p>In the published essay on the Palantiri, Tolkien wrote:</p>
<blockquote>
  <p>He [Denethor] must have guessed that the Ithil-stone [Sauron's palantír] was in evil hands, and risked contact with it, trusting his strength. His trust was not entirely unjustified. Sauron failed to dominate him and could only influence him by deceits.</p>
  <p>Saruman fell under the domination of Sauron... [while] Denethor remained steadfast in his rejection of Sauron, but was made to believe that his defeat was inevitable, and so fell into despair. The reasons for this difference were no doubt that in the first place Denethor was a man of great strength of will and maintained the integrity of his personality until the final blow of the (apparently) mortal wound of his only surviving son.[3]</p>
</blockquote>
<p>Near the novel's climactic battle, Denethor ordered the warning beacons of Gondor to be lit, and forces were called in from all of Gondor's provinces. The civilian population of Minas Tirith was sent away to safety. As invasion seemed imminent, Denethor sent the Red Arrow to the Rohirrim as a call for aid. The Council decided that Gondor could make no stroke of its own, but Denethor ordered Gondor's forces to the city's outer defences at Osgiliath and the great wall of the Rammas Echor. He wanted to make a stand, since the defences had been built at great expense and not yet been overrun, and he assumed that no help was forthcoming from Rohan since his messenger had not returned with the Red Arrow (the messenger had in fact been killed by Orcs during the ride back to Minas Tirith).</p>
<p>The outer defences were placed under the command of Faramir. Faramir knew his men could not stand against Sauron's army, but he nonetheless obeyed out of respect for his father and late brother. In the ensuing battle Faramir was badly wounded, apparently mortally; his body was carried back in the retreat to the city, which was now under siege by vastly superior forces.</p>
<p>Denethor's spirit was broken by the apparent loss of his son, and he ordered his servants to burn him alive on a pyre prepared for himself and Faramir in Rath Dínen. He took the white rod of his office and broke it over his knee, casting the pieces into the flames. He laid himself down on the pyre and so died, clasping the palantír in his hands. He also attempted to take Faramir with him, but was thwarted by the timely intervention of Peregrin Took, who saved Faramir from the flames with help from Gandalf and the guard Beregond. They were too late to save Denethor, however; he burned to death as Sauron's forces stormed the gate.</p>
<p>The Stewardship technically passed to Faramir, but he was in no condition to exercise any authority, still being close to death; he was taken to the Houses of Healing with little hope. But contrary to Denethor's forebodings, Faramir recovered, and the Stewardship was not emasculated. Indeed, when Aragorn became King, he not only confirmed the Stewardship to Faramir and his successors, but raised their rank to Princes of Ithilien.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Denethor";
            ImageArtist = Artist.Magali_Villeneuve;

            Alias("Steward of Gondor", "Steward-of-Gondor-Core");

            addFamily("Finduilas (Wife)");
            addFamily("Boromir (Son)", "Boromir");
            addFamily("Faramir (Son)", "Faramir");

            addItem("Rod of the Steward", "Rod-of-the-Steward-FotS");
            addItem("Palantir", "Palantir-AoO");

            Card("Denethor-Core");
            Card("Denethor-EaAD");
            Card("Denethor-FotS");
        }
    }
}