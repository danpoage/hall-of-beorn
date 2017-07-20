using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class TheWhiteCouncilGroup : CharacterGroup
    {
        public TheWhiteCouncilGroup()
            : base("The White Council", "The Second White Council")
        {
            Bio =
@"<p>In J. R. R. Tolkien's legendarium, the White Council is a group of elves and wizards of Middle-earth, formed to contest the growing power of Dol Guldur (Sauron's stronghold in Mirkwood), at the request of Galadriel, the co-ruler of Lothlorien. In the narrative, it is officially the Second White Council, a successor of that of the Second Age.</p>
<p>The Second White Council's membership included the Wizards Saruman the White, Radagast the Brown, Gandalf the Grey, and the chiefs and rulers of the Eldar, including Lady Galadriel of Lothlórien, Master Elrond of Imladris and Círdan the Shipwright of the Grey Havens. Saruman was the head of the White Council, against the wishes of Galadriel, who later described this as the beginning of the long defeat. Other possible members are said to be among the mightiest of Elves: the Elf-lord Glorfindel; Elrond's chief counsellor Erestor; and, Celeborn, Galadriel's husband, whom Galadriel herself called 'Wise'. The two Blue Wizards were not part of the Council. Tolkien does not give a list of all the members of the council; 'other lords of the Eldar' is as close as The Silmarillion gives to a list. Unbeknownst to the other members of the Council, Círdan (and later Gandalf), Galadriel, and Elrond were also the bearers of the Three Rings of the Elves.</p>
<p>The Second White Council first met in T.A. 2463 to counter the growing threat from Dol Guldur. Gandalf travelled through Southern Mirkwood in T.A. 2850, and learned of the identity of the Necromancer, who ruled over Dol Guldur. In T.A. 2851 the White Council met to decide whether to act on Gandalf's discovery, but Saruman dissuaded the others.</p>
<p>When he realized that the One Ring was possibly still in the area of the Gladden Fields and that Sauron was actively seeking it, Saruman relented and in T.A. 2941 Sauron was driven out of Dol Guldur, only to re-appear in Mordor, long prepared for him. This White Council meeting, of late summer T.A. 2941, was also the reason that Gandalf was unable to accompany Bilbo Baggins and the dwarves on a portion of their trip to the Lonely Mountain in The Hobbit.</p>
<p>The Council last met in T.A. 2953 to discuss Sauron's attempts to find the One Ring. At this meeting Saruman insisted that the One Ring had fallen into the Anduin and had been swept out to sea. During this meeting there was much tension between Saruman and Gandalf, for Gandalf already suspected Saruman of desiring to possess the One Ring.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/White_Council";
            ImageArtist = Artist.Angus_McBride;

            addLeader("Saruman the White", "Saruman");

            addMember("Gandalf the Grey", "Gandalf");
            addMember("Galadriel", "Galadriel");
            addMember("Elrond", "Elrond");
            addMember("Radagast the Brown", "Radagast");
            addMember("Círdan the Shipwright", "Cirdan-the-Shipwright");

            Card("The-White-Council-TDT");
        }
    }
}