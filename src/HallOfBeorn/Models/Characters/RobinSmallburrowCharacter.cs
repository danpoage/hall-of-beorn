using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class RobinSmallburrowCharacter : Character
    {
        public RobinSmallburrowCharacter()
            : base("Robin Smallburrow", "Robin Smallburrow", "Hobbit")
        {
            Bio =
@"<p>Robin Smallburrow was a Shirriff from Hobbiton.</p>
<h4>History</h4>
<p>Born and raised in Hobbiton, Robin was of old a friend of the Gamgees. He loved being outdoors, and became a Shirriff so he could meet new people (and, equally important, inns).</p>
<p>Originally one of only twelve, during Lotho Sackville-Baggins' reign, Robin found himself in over his head. He was reassigned to the First Eastfarthing Troop in Frogmorton, tasked with enforcing The Rules.</p>
<p>Robin was one of the Shirriffs sent to arrest four Hobbits who had illegally entered the Shire at the Brandywine Bridge. It was more of an escort than an arrest, as Robin and his troops were on foot and the four Hobbits had ponies. At the Three-Farthing Stone, the Shirriffs gave up and let their prisoners go on without them.</p>
<h4>Etymology</h4>
<p>The name 'Smallburrow' may imply Robin came from a poor family, as only the poor and the rich lived in smials. His name bears some resemblance to the mythical Robin Goodfellow.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Robin_Smallburrow";
            ImageArtist = Artist.Aleksander_Karcz;

            addFriend("Sam Gamgee", "Sam-Gamgee");
            addFriend("Gaffer Gamgee");

            addGroup("The Shire", "The-Shire");
            //addGroup("Shirrif");
        }
    }
}
