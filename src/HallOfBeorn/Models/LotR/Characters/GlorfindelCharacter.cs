using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class GlorfindelCharacter : Character
    {
        public GlorfindelCharacter()
            : base("Glorfindel", "Glorfindel", "Noldor Elf")
        {
            Bio =
@"<p>Glorfindel (IPA: [ɡlɔrˈfindɛl]) is a fictional character in J.R.R. Tolkien's Middle-earth legendarium. He is introduced in various material relating to the First Age of Middle-earth, including The Silmarillion. The name is also used for a character in The Lord of the Rings, which takes place in Middle-earth's Third Age. In late writings, Tolkien works out how the two characters were one and the same, though this is not evident from the published versions of The Silmarillion and The Lord of the Rings.</p>
<p>The character and his name (meaning 'blond, golden-haired') were among the first created, when Tolkien first conceived of what would become his Middle-earth legendarium in 1916–17.</p>
<p>Glorfindel was born around the time of the Years of the Trees in Valinor. He was part of the host of Turgon, but only followed him because of his kinship. He took no part in the Kinslaying of the Alqualondë. After the Noldor's exile, his history became more obscure.
<p>Glorfindel next appears in The Fall of Gondolin[1] about the conquest of the Elven city Gondolin by the Dark Lord Morgoth.[2] It was the first part of The Book of Lost Tales to be written, in 1916–17.[1] As his ideas evolved, Tolkien wrote about this event various times, and it appears in compressed form in The Silmarillion; by the time he wrote Lord of the Rings, Tolkien had superseded or abandoned many of his original ideas.</p>
<p>From the beginning, Glorfindel appears as a noble lord, known as one of King Turgon's chief lieutenants. In the original Fall of Gondolin, he was called the chief of the House of the Golden Flower. After fighting in the city's defence, Glorfindel escaped together with Tuor, Idril, Eärendil and many others. The survivors passed through the Encircling Mountains above Gondolin. However, they were ambushed by enemies, including a Balrog. Glorfindel duelled and killed the Balrog, but was himself killed. His body was buried under a mound of stones, set there by the great eagle Thorondor, who lifted him up from the abyss. The Fall of Gondolin relates that 'Glorfindel and the Balrog' became an Elven proverb to describe great skill and courage in battle.[1]</p>
<p>Glorfindel's spirit afterwards passed to the halls of Mandos,where the Valar sent him back to Middle-Earth on a similar mission as the Istari, who appeared several thousand years later.[3]</p>
<p>In The Fall of Gondolin Tolkien writes that Glorfindel's name 'meaneth Goldtress for his hair was golden'.[1] Christopher Tolkien comments that 'this was from the beginning the meaning of his name', as the character is called 'yellow-haired Glorfindel'[4] in The Silmarillion.[1]</p>
<p>In The Silmarillion Glorfindel appeared as one of Turgon's captains who oversaw his retreat during the Battle of Unnumbered Tears.[4]</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Glorfindel";
            ImageArtist = Artist.Magali_Villeneuve;

            TheFellowshipOfTheRing();
            TheSilmarillion();
            ChildrenOfHurin();

            Alias("Lord of the House of the Golden Flower of Gondolin");

            addFriend("Elrond", "Elrond");

            addItem("Asfaloth", "Asfaloth");
            addItem("Elf-stone", "Elf-stone-TBR");

            Card("Glorfindel-Core");
            Card("Glorfindel-FoS");
            Card("Glorfindel-FotS");
        }
    }
}