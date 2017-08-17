using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class GrimaCharacter : Character
    {
        public GrimaCharacter()
            : base("Gríma", "Gríma", "Man")
        {
            Bio =
@"<p><b>Gríma Wormtongue</b> (died Third Age November 3, 3019)[2] was the chief advisor to King Théoden of Rohan. He was the son of Gálmód.</p>
<h4>History</h4>
<p>Gríma was secretly in thrall to Saruman, who had promised him Éowyn. Gríma not only informed Saruman about the secrets of Rohan, but also worked to weaken Théoden and his kingdom with his words and poison.</p>
<p>During the War of the Ring, the Nine Nazgûl came to Rohan and questioned Wormtongue, who, terrified, answered that the Wizard Gandalf had passed through Rohan, and also revealed to them where the Shire was. He also told them that Saruman had lied to them in this information, revealing his treachery against Sauron.</p>
<p>Upon Gandalf's arrival, he tried to discredit Gandalf, until he managed to heal Théoden. After this, 'many things which men had missed' were found locked in Gríma's trunk and he was given a grim choice: ride into battle or into exile.[1] Choosing the latter, he went to dwell with Saruman at Orthanc, where he witnessed the Battle of Isengard. Following the confrontation between Saruman and Gandalf, he mistakenly threw a 'heavy rock'—which was actually the palantír of Orthanc—at the Rohirrim accompanying Gandalf, an act for which Saruman seems to have punished him severely.</p>
<p>While being held there, he was reduced more weak and thin. When Treebeard released them in August, they left. On their way, they were confronted by Gandalf, Celeborn, Galadriel and the Hobbits on their way to northern Dunland. They found them as traveling beggars and Saruman kicked Gríma to move on, as he exclaimed how he hated his master. Galadriel told Gríma that he was free to leave him but he did not reply.</p>
<p>Saruman had already been exerting his control over the Shire from afar by sending evil Men there, thus Saruman sought his revenge in petty tyranny over the hobbits. During this time Gríma became increasingly degraded until he was a crawling wretch, almost resembling Gollum, and Saruman shortened his nickname to 'Worm'. During this time he killed Lotho Sackville-Baggins, and may have eaten him.</p>
<p>Spurred by the words of Frodo that he did not have to follow Saruman, and being pushed over the edge when Saruman scorned him, he used a hidden knife to slit the throat of Saruman and darted down the road. He was quickly killed by several Hobbit arrows, and thus Wormtongue was the final casualty of the War of the Ring.</p>
<h4>Etymology</h4>
<p>The name Gríma derives from the Old English or Icelandic word meaning 'mask, visor, helmet' or 'spectre'. It is also possible to link the name to the English word 'grim', which among other characteristics meant 'ugly' in Old English.</p>
<p>Wormtongue is a modernized form of Old English wyrm-tunge ('snake-tongue').</p>";
            
            BioSourceUrl = "http://tolkiengateway.net/wiki/Grima";
            ImageArtist = Artist.Harold_Shull;

            Alias("Wormtongue");
            Alias("Worm");

            addFamily("Gálmód (Father)");

            addFriend("Théoden", "Theoden");
            addFriend("Saruman", "Saruman");

            addItem("Keys of Orthanc", "Keys-of-Orthanc-VoI");

            addGroup("The Rohirrim", "The-Rohirrim");

            Card("Grima-Hero-VoI");
            Card("Grima-Objective-Ally-VoI");
            Card("Grima-ToS");
        }
    }
}