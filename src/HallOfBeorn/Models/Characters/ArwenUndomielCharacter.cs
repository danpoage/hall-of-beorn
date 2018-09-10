using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class ArwenUndomielCharacter : Character
    {
        public ArwenUndomielCharacter()
            : base("Arwen Undómiel", "Arwen Undómiel", "Half-elven")
        {
            Bio = 
@"<blockquote>
&ldquo;Frodo saw her whom few mortals had yet seen; Arwen, daughter of Elrond, in whom it was said that the likeness of Lúthien had come on earth again; and she was called Undómiel, for she was the Evenstar of her people.&rdquo;
<br>― The Fellowship of the Ring, Many Meetings
</blockquote>
<p>Arwen Undómiel (Arwen is S, pron. [ˈarwen]; Undómiel is Q, pron. [unˈdoːmi.el]), often called Arwen Evenstar, was the betrothed of Aragorn II. She is the daughter of Elrond and Celebrían.</p>
<p>She was considered to be the fairest of the Children of Ilúvatar, resembling Lúthien of the First Age who would never again appear in Middle-earth. Her romance with Aragorn was reminiscent of that between the Man Beren and the Elf Lúthien. Few other marriages between Man and Elf were known. Like Lúthien, she rejected her Elven immortality to marry Aragorn and die with him.</p>
<h4>History</h4>
<p>Arwen was born in T.A. 241 and was the younger sister of Elladan and Elrohir. From her mother she inherited the Elfstone.[4] As a Half-elven she shared the right of her father to choose her fate. She lived most of her life in her homestead in Imladris or Lothlórien with her grandparents.</p>
<p>Her father fostered the sons of the Chieftains of the Dúnedain, who were the exiled Heirs of Isildur.[5] It was in T.A. 2952 when she returned from Lothlórien to Rivendell when she met a young foster-son of her father, Aragorn. The young Dúnadan fell in love when he first saw her, but Elrond insisted that Arwen could not marry Aragorn until he became king of both Gondor and Arnor. Whatever Arwen's choice, she would be parted from either Elrond or Aragorn for ever.</p>
<p>It was not until they met many years later in Lórien that she returned in love, and in T.A. 2980 they plighted their troth on Cerin Amroth. Aragorn gave her the Ring of Barahir. After Aragorn left for his travels and deeds, Arwen continually served as inspiration and motivation for him, who had to become King before he could wed her and devoted many long years to this cause.</p>
<p>When Aragorn brought the Hobbits to Rivendell, during the War of the Ring, he reunited with Arwen. Frodo saw Aragorn with her at one point—the first hint of their relationship.[2] Later, when the Fellowship came to Lothlórien, Aragorn remembered their earlier meeting on Cerin Amroth. When the Fellowship departed and Galadriel offered them her gifts, Arwen's Elfstone was the gift for Aragorn, which he would wear ever after.[6]. This giving held the function of a wedding gift from the family of the bride to the groom, foretelling his marriage to Arwen.</p>
<p>When Éowyn fell in love with Aragorn it was his fidelity to Arwen that forbade him from reciprocating, thereby motivating Éowyn's subsequent actions.</p>
<p>While Aragorn was out in the War, Arwen made, with her hands, the Livery of Elendil in mithril, gems and gold on black cloth. This was taken by her brothers and a group of Rangers of the North to Aragorn before taking the Paths of the Dead, and was an encouraging sign for him to take the difficult path. It was unfurled at the Battle of the Pelennor Fields to triumphantly announce the King's return.</p>
<p>Aragorn wed Arwen after the War of the Ring when he finally became a King of the new Reunited Kingdom. Arwen chose a fate different from her father's and did not sail to the West. As Queen of Gondor, Arwen bore one son, Eldarion, and several daughters. Even after Aragorn's death, Arwen did not repent, and eventually gave up her life in Fo.A. 121, at Cerin Amroth in Lórien, and she was buried there.</p>
<h4>Genealogy</h4>
<p>Arwen was actually a very distant relative of Aragorn, being his first cousin sixty-three times removed. By their marriage, the long-sundered lines of the Half-elven were joined.[11] Their union also served to unite and preserve the bloodlines of the Three Kings of the High Elves (Ingwë, Finwë, and brothers Olwë and Elwë) as well as the only line with Maiarin blood through Arwen's great-great grandmother, Melian.</p>
<h4>Etymology</h4>
<p>Arwen means 'Noble Maiden' in Sindarin (from ara- = 'noble' and gwenn = 'maiden').[12] Tolkien remarked that it also means 'greatly blessed' in Welsh.</p>
<p>The Quenya form of her name is not entirely certain, but in his Quenya greeting, Aragorn refers to her again as 'Arwen' (Arwen vanimelda, namárië!).[14] This suggests that the form Arwen itself is also coincidentally a valid, or at least understandable, Quenya calque (using ar-, stem Arwend-).</p>
<p>Her epessë, Undómiel, means 'Evenstar', from Undómë 'evening twilight' and el 'star'.</p>";

            BioSourceUrl = "http://tolkiengateway.net/wiki/Arwen";
            ImageArtist = Artist.Magali_Villeneuve;

            TheFellowshipOfTheRing();
            TheReturnOfTheKing();

            Alias("Undómiel");
            Alias("Evenstar", "The-Evening-Star-TGH");
            Alias("Elven-light", "Elven-light-TDR");

            addFamily("Elrond (Father)", "Elrond");
            addFamily("Celebrían (Mother)", "Celebrian");
            addFamily("Aragorn (Husband)", "Aragorn");
            addFamily("Elladan (Brother)", "Elladan");
            addFamily("Elrohir (Brother)", "Elrohir");

            addGroup("Rivendell", "Rivendell");
            addGroup("Lórien", "Lorien");

            addItem("Celebrían's Stone", "Celebrian's-Stone-Core");

            LotRCard("Arwen-Undomiel-TWitW");
            LotRCard("Arwen-Undomiel-TRG");
            LotRCard("Arwen-Undomiel-RTR");
            LotRCard("Arwen-Undomiel-TDR");
            LotRCard("Arwen-Undomiel-TPLES");

            DigitalCard("Arwen-Starter");
        }
    }
}