using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class ThorinStonehelmCharacter : Character
    {
        public ThorinStonehelmCharacter()
            : base("Thorin Stonehelm", "Thorin III Stonehelm", "Dwarf")
        {
                        Bio =
@"<p><b>Thorin III Stonehelm</b> (Third Age 2866 – Fourth Age) was the son and heir of Dáin II Ironfoot of Durin's folk, who was king of the Dwarves of Erebor and the Iron Hills in Wilderland.</p>
<h3>History</h3>
<p>During the Lordship of his father, Thorin was more than likely born in the Iron Hills to Dáin II Ironfoot. During his younger years he saw his people able to finally return to the Lonely Mountain after many years of further exile, and wandering. He himself became a prince with the rise of his father as King under the Mountain, and over all the Longbeards. During the War of the Ring at the age of one hundred fifty-three, Thorin fought the Easterlings in the Battle of Dale, and took refuge in Erebor after his father was killed at its gates, along with Brand king of Dale. Thorin then became King under the Mountain. When the news of Sauron's defeat in the South came to the ears of the enemy, they became dismayed and the Dwarves and Men came forth from the mountain and routed them driving them back of the river Carnen, never troubling them again. Under Thorin's leadership Erebor and Dale were rebuilt along with Dale's new king Bard II, son of Brand, and once again both their people prospered, and their realms became close allies with the Reunited Kingdom of Arnor and Gondor of King Aragorn II. During his rule Gimli, son of Glóin, led a number of Dwarves South to Aglarond, where a new colony was settled. Also during his rule mining for mithril in Moria slowly began again, although Moria was not yet permanently settled. Thorin III had a descendant who was held to be the reincarnation of Durin the Deathless, and would rule as Durin VII the Last.</p>
<h3>Etymology</h3>
<p>Thorin's name is one from the Dvergatal. It means 'Bold'. The origins of the name 'Stonehelm' are mysterious: Tolkien doesn't provide us with any account that would shed light on its meaning.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Thorin_Stonehelm";
            ImageArtist = Artist.Weta_Workshop;

            Alias("King Under the Mountain", "King-Under-the-Mountain-THOtD");
            Alias("King of Durin's Folk");

            addFamily("Dáin Ironfoot (Father)", "Dain-Ironfoot");

            addItem("Dwarven Axe", "Dwarven-Axe-Core");
            addItem("Dwarven Shield", "Dwarven-Shield-TSoH");
            addItem("Dwarf Pipe", "Dwarf-Pipe-TMk");
        }
    }
}