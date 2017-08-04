using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class LegolasCharacter : Character
    {
        public LegolasCharacter()
            : base("Legolas", "Legolas", "Sindarin Elf")
        {
            Bio =
@"<p>Legolas (pronounced [ˈlɛɡɔlas]) is a fictional character in J. R. R. Tolkien's legendarium. He is a Sindarin Elf of the Woodland Realm and one of nine members of the Fellowship of the Ring.</p>
<p>Legolas was the son of Thranduil, King of the Woodland Realm of Northern Mirkwood,[1][2] who appears as 'the Elvenking' in The Hobbit.[3] Thranduil ruled over the Silvan Elves or 'Wood-elves' of Mirkwood.[1]</p>
<p>Although he lived among the Silvan Elves, Legolas was not one himself. His father Thranduil had originally come from Lindon; he and his son were actually Sindar, or 'Grey Elves', called in the singular Sinda; 'Sindarin' was their language. Thranduil himself was the son of Oropher. Legolas's mother is never mentioned; the Elves of Mirkwood have no Queen at the time of The Hobbit.</p>
<p>Legolas was introduced in The Fellowship of the Ring, at the Council of Elrond in Rivendell, where he came as a messenger from his father to discuss Gollum's escape from their guard.[1] Legolas was chosen to be a member of the Fellowship of the Ring, charged with destroying the One Ring. He accompanied the other members in their travels from Rivendell to Amon Hen, serving as the group's archer.</p>
<p>When the fellowship was trapped by a snowstorm while crossing the dangerous mountain Caradhras, Legolas scouted ahead, and told Aragorn and Boromir that the thick snow they were trying to push through was only a narrow wall, and below it the snow was more shallow.[4] When the attempt to cross Caradhras failed, Gandalf led the fellowship on a journey underground through Moria, an ancient Dwarf-kingdom, though some (including Legolas) did not wish to travel there. Before they reached Moria, Legolas helped fend off an attack by wolves in Hollin. In Moria, he helped fight off orcs and recognized 'Durin's Bane' as a Balrog of Morgoth. After Gandalf was lost, Aragorn took charge of the fellowship and led them to the Elven realm of Lothlórien, the Golden Wood. Legolas served as the initial spokesperson for the company, speaking with the inhabitants, the Galadhrim, whom he considered close kin.</p>
<p>There was initially friction between Legolas and the dwarf Gimli, because of the ancient quarrel between Elves and Dwarves arising from the destruction of Doriath in the First Age; and also because Thranduil once imprisoned Gimli's father Glóin. Moreover, the dwarves of Erebor disliked Thranduil ever since he refused to pay them for crafting his raw metals.[3] However Legolas and Gimli began to become friends when Gimli greeted the Elven queen Galadriel respectfully.[6] When the fellowship left Lothlórien, Galadriel and Celeborn gave the members gifts; Legolas received a new longbow. Legolas used the bow to bring down a 'fell beast' in the dark with one shot.</p>";

            BioSourceUrl = "https://en.wikipedia.org/wiki/Legolas";
            ImageArtist = Artist.Magali_Villeneuve;

            TheFellowshipOfTheRing();
            TheTwoTowers();
            TheReturnOfTheKing();

            Alias("Greenleaf");

            addFamily("Thranduil (Father)", "Thranduil");

            addFriend("Gimli", "Gimli");

            addItem("Mirkwood Long-knife", "Mirkwood-Long-knife-TSoH");
            addItem("Arod", "Arid-ToS");

            addGroup("The Council of Elrond", "The-Council-of-Elrond");
            addGroup("The Fellowship", "The-Fellowship");
            addGroup("The Three Hunters");

            Card("Legolas-Core");
            Card("Legolas-TSoH");
            Card("Legolas-MatPP");
            Card("Legolas-ToS");
        }
    }
}