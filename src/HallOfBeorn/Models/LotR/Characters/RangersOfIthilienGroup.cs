using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class RangersOfIthilienGroup : CharacterGroup
    {
        public RangersOfIthilienGroup()
            : base("Rangers of Ithilien", "Rangers of Ithilien")
        {
            Bio =
@"<p>In J. R. R. Tolkien's legendarium, the Rangers of Ithilien, also known as the Rangers of the South and Rangers of Gondor, were an elite group of the Southern Dúnedain warriors who scouted in and guarded the land of Ithilien.</p>
<p>The Rangers were first formed at the end of the twenty-ninth century of the Third Age by a decree of the Ruling Steward of Gondor, for Ithilien was frequently subjected to enemies from Mordor and Minas Morgul. One of their chief bases was Henneth Annûn, the Window of the Sunset.
<p>These Rangers were descendants of those who lived in Ithilien before it was overrun and, more distantly, of the ancient Númenóreans. Like their cousins, the Rangers of the North, they were able to speak Sindarin (or some variation of it), their preferred language as opposed to the Common Speech. Their camouflaging green and brown raiment proved to be a useful asset to their secret activities, which mainly concerned crossing the Anduin to assault the Enemy in a manner much akin to guerilla warfare. They were skilled with swords and bows or spears.</p>
<p>During the Fourth Age, it is presumed that most of these men became a part of the White Company, the guards of Faramir, the first Prince of Ithilien.</p>
<p>During the War of the Ring, the Rangers of Ithilien were led by Captain Faramir, and some of its members included Anborn, Damrod, and Mablung.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Rangers_of_Ithilien";
            ImageArtist = Artist.David_A_Nash;

            addLeader("Faramir", "Faramir");

            addMember("Mablung", "Mablung");
            addMember("Damrod", "Damrod");
            addMember("Anborn", "Anborn");

            Card("Ranger-of-Ithilien-TMaO");
            Card("Ithilien-Tracker-HoN");
            Card("Ithilien-Guardian-HoN");
            Card("Ithilien-Archer-EaAD");
            Card("Ithilien-Lookout-TDT");
            Card("Guardian-of-Ithilien-TCoC");
            Card("Ranger-Bow-AoO");
            Card("Ranger-Spear-TCoC");
            Card("Forest-Snare-Core");
            Card("Ranger-Spikes-HoN");
            Card("Ithilien-Pit-EaAD");
            Card("Poisoned-Stakes-TBoG");
            Card("Entangling-Nets-TotD");
            Card("Followed-CoP");
            Card("Ambush-TLoS");
            Card("Advance-Warning-TDF");
            Card("Forest-Patrol-AoO");
            Card("Arrows-from-the-Trees-TotD");
            Card("Coney-in-a-Trap-TMk");
            Card("In-the-Shadows-TLoS");
        }
    }
}