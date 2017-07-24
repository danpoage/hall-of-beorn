using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class CelebornCharacter : Character
    {
        public CelebornCharacter()
            : base("Celeborn", "Celeborn", "Sindarin Elf")
        {
            Bio =
@"<p>Celeborn (pronounced with a hard c as in cat; IPA: [ˈkelebɔːn]) is a fictional character in J.R.R. Tolkien's Middle-earth legendarium. Celeborn is an Elf, and the husband of Galadriel. He appears in The Lord of the Rings as the Lord of the Galadhrim, and co-ruler along with Galadriel of Lothlórien. He was the father of Celebrían (the wife of Elrond), and thus the grandfather of Arwen Evenstar and her older brothers Elladan and Elrohir. He was also a kinsman of the First Age Elven King Thingol. Celeborn means '(tall) silver tree' in Tolkien's invented language of Sindarin.</p>
<p>He is also referred to as Lord of Lothlórien or Lord of the Wood interchangeably. Within Lothlórien itself he is called simply Lord Celeborn or The Lord (more often with Galadriel as The Lord and Lady). He is called Celeborn the Wise by Galadriel.</p>
<p>Celeborn is also the name of the White Tree that flourished in Tol Eressëa. It was a seeding of the tree Galathilion, which in turn was made by Yavanna in the image of Telperion, the elder of the Two Trees of Valinor. Celeborn was an ancestor to the White Trees of Númenor and of Gondor.</p>
<p>Celeborn first appears in The Fellowship of the Ring. He also appears briefly in Tolkien's (at the time unpublished) existing legends of the First Age, The Silmarillion; in chapters 13, 22, 24 and also 'Of the Rings of Power and the Third Age'. Tolkien felt that an Elf of Celeborn's importance should have noble ancestry, and spent several years trying to resolve his origins.</p>
<p>Most existing writings portray Celeborn as a Sindarin Elf from Doriath, the kingdom of Thingol. In one speculative text by Tolkien, published in Unfinished Tales,[3] Celeborn is the grandson of Thingol's younger brother Elmo (who appears nowhere else). That Celeborn and Thingol are related is suggested by their silver hair, a colour associated with the House of Elwë and Olwë and rarely mentioned outside of the royal house of the Sindar. Míriel Serindë, mother of Fëanor, also has silver hair, as did Eärwen, daughter of Olwë and mother of Galadriel. This Sindarin origin for Celeborn was adopted by Christopher Tolkien for The Silmarillion, which describes Celeborn as 'a kinsman of Thingol' and adds a paragraph about Celeborn's marriage to Galadriel.</p>
<p>Late in his life Tolkien proposed a different scenario (also described in Unfinished Tales): Celeborn was a Telerin Elf from Valinor, the grandson of Olwë, named Teleporno in Telerin. (This brings him closer to being a peer and equal of Galadriel and makes their partnership more balanced.) He met Galadriel when she was living in the Telerin city Alqualondë, before the rebellion of the Noldor. They decided to travel together to Middle-earth, without asking permission from the Valar to do so. They made their way to Middle-earth independently of Fëanor, and in some versions of the story Galadriel fell under the Ban of the Valar, in other versions not. Tolkien never mentions the Ban applying to Celeborn. According to this narrative, the name Teleporno was 'Sindarized' as Celeborn: Telerin telpe ('silver') (Noldorin Quenya tyelpe) was translated to Sindarin keleb (or celeb).</p>
<p>This altered origin was not adopted in the published Silmarillion, primarily because it would have necessitated a major rewrite of the earlier parts to account for a separate departure of Galadriel. A further problem was that this descent would have made Celeborn Galadriel's first cousin, and Elves never married close kin.</p>
<p>Early in the Second Age, Celeborn apparently ruled over Elves in Lindon. Celeborn and Galadriel later rule over the Elves of Eregion (at least in some accounts), before settling in Lothlórien.</p>
<p>At the end of the Third Age Celeborn crossed the Anduin with many elves of Lothlórien to found 'East Lórien'. When Galadriel left Middle-earth shortly afterward, Celeborn settled in Rivendell to join his grandsons Elladan and Elrohir. The prologue to The Fellowship of the Ring states that 'there is no record of the day when at last he sought the Grey Havens, and with him went the last living memory of the Elder Days in Middle-earth'.</p>";
            BioSourceUrl = "https://en.wikipedia.org/wiki/Celeborn";
            ImageArtist = Artist.Magali_Villeneuve;

            TheFellowshipOfTheRing();
            TheReturnOfTheKing();
            UnfinishedTales();
            TheSilmarillion();

            Alias("Teleporno");
            Alias("The Wise");
            Alias("Lord of the Galadhrim");
            Alias("Lord of Lothlórien");

            addFamily("Galadriel (Wife)", "Galadriel");
            addFamily("Celebrían (Daughter)");
            addFamily("Elrond (Son-in-Law)", "Elrond");
            addFamily("Elladan (Grandson)", "Elladan");
            addFamily("Elrohir (Grandson)", "Elrohir");
            addFamily("Arwen Undómiel (Granddaughter)", "Arwen");

            addFriend("Haldir of Lórien", "Haldir-of-Lorien");
            addFriend("Orophin", "Orophin");
            addFriend("Rúmil", "Rumil");

            addItem("O Lórien!", "O-Lorien-TiT");

            Card("Celeborn-TDT");
        }
    }
}