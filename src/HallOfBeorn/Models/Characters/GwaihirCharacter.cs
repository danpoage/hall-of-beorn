using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class GwaihirCharacter : Character
    {
        public GwaihirCharacter()
            : base("Gwaihir", "Gwaihir", "Eagle")
        {
            Bio =
@"<p>Gwaihir was the greatest and the swiftest of the Eagles of Middle-earth at the time of the War of the Ring.</p>
<h4>History</h4>
<p>A descendant of Thorondor, it is said that Gwaihir was his vassal in the First Age and with his brother Landroval helped him rescue Beren and Lúthien from Angband.</p>
<p>In the Third Age he was the greatest and the swiftest of the Eagles of the North.</p>
<p>When the Eagles heard about Gollum's escape from Mirkwood, Gwaihir was sent to bear the news to Isengard, as they had been told by Radagast.</p>
<p>During the War of the Ring, he noticed Gandalf on the pinnacle of Orthanc while trapped by Saruman and carried him to Edoras. Later he was sent by Galadriel to find Gandalf; he found him on the peak of Celebdil after the Battle of the Peak, and carried him to Lothlórien.</p>
<p>Gwaihir, Meneldor and Landroval helped the Free peoples in the Battle of the Morannon; in the aftermath, they brought Frodo and Sam out of Mordor after the One Ring was destroyed.</p>
<h4>Etymlogy</h4>
<p>Gwaihir comes from Sindarin gwaew ('wind') and possibly hîr 'lord'. His name could thus likely be translated as 'Windlord'.</p>
<h4>Other versions of the Legendarium</h4>
<p>Eagles named 'Gwaihir' and 'Landroval' (or, in even earlier texts, 'Gwaewar' and 'Lhandroval') appeared in early Silmarillion, as vassals of Thorondor who helped to bear Beren and Lúthien from Angband[1]. These references were removed by Christopher Tolkien to escape the seeming discrepancy with The Lord of the Rings, although later he admitted that he was not sure about his father's intentions.</p>
<p>It is generally thought that Gwaihir is the Lord of the Eagles of The Hobbit, although Tolkien never makes a connection nor mentions that Gwaihir was Lord of the Eagles. This notion is also seen in Robert Foster's The Complete Guide to Middle-earth.</p>
<p>In the whole Lord of the Rings Gwaihir carries Gandalf twice, and by the end of the book Gandalf says that Gwaihir had carried him twice[8]; this implies that Gwaihir never carried him before the timeframe of the book.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Gwaihir";
            ImageArtist = Artist.Jake_Murray;

            Alias("The Windlord");

            addFamily("Landroval (Brother)", "Landroval");

            addPlace("The Eyrie", "The-Eyrie");
            
            addGroup("The Eagles");
        }
    }
}
