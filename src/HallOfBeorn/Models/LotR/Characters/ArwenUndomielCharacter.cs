using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class ArwenUndomielCharacter : Character
    {
        public ArwenUndomielCharacter()
            : base("Arwen Undómiel", "Arwen Undómiel", "Half-elven")
        {
            Bio = 
@"<p>Arwen was the youngest child of Elrond and Celebrían. Her elder brothers were the twins Elladan and Elrohir. Her name Ar-wen means 'noble maiden'. She bore the sobriquet 'Evenstar' (or Evening Star), as the most beautiful of the last generation of High Elves in Middle-earth.</p>
<p>As told in 'The Tale of Aragorn and Arwen', Aragorn in his twentieth year met Arwen for the first time in Rivendell, where he lived under Elrond's protection. Arwen, then over 2700 years old, had recently returned to her father's home after living for a while with her grandmother Lady Galadriel in Lórien. Aragorn fell in love with Arwen at first sight. Some thirty years later, the two were reunited in Lórien. Arwen reciprocated Aragorn's love, and on the mound of Cerin Amroth they committed themselves to marry each other.</p><p>Arwen first appears in the text of The Lord of the Rings in Rivendell shortly after Frodo Baggins awoke in the House of Elrond. She sat beside her father at the celebratory feast. When the Fellowship of the Ring came to Lothlórien, Aragorn remembered their earlier meeting and paused in reverence on Cerin Amroth.</p><p>Shortly before Aragorn took the Paths of the Dead, he was joined by a group of Dúnedain from the North, accompanied by Arwen's brothers, Elladan and Elrohir, who brought him as a gift from Arwen: a banner of black cloth. The banner was unfurled at the Battle of the Pelennor Fields to reveal the emblem of Elendil figured in mithril, gems, and gold; this became the first triumphant public announcement of the King's return.
<p>After the War of the Ring, Aragorn became king of Arnor and Gondor. Arwen arrived at Minas Tirith, and they were married. She gave Frodo a necklace with a white stone, which would aid him when the darkness of his injuries troubled him.</p>
<p>Arwen is a minor character in The Lord of the Rings, but she serves as inspiration and motivation for Aragorn, who must become King of both Arnor and Gondor before Elrond would allow her to marry him.</p>
<p>The Tale of Aragorn and Arwen relates that Aragorn and Arwen had a son, Eldarion, and at least two unnamed daughters. In F.A. 121, one year after Aragorn's death, Arwen gave up her life, at the age of 2,901, at Cerin Amroth.</p>";

            BioSourceUrl = "https://en.wikipedia.org/wiki/Arwen";

            TheFellowshipOfTheRing();
            TheReturnOfTheKing();

            Alias("Undómiel");
            Alias("Evenstar", "The-Evening-Star-TGH");
            Alias("Elven-light", "Elven-light-TDR");

            addFamily("Elrond (Father)", "Elrond");
            addFamily("Aragorn (Husband)", "Aragorn");
            addFamily("Elladan (Brother)", "Elladan");
            addFamily("Elrohir (Brother)", "Elrohir");

            Card("Arwen-Undomiel-TWitW");
            Card("Arwen-Undomiel-TRG");
            Card("Arwen-Undomiel-RTR");
            Card("Arwen-Undomiel-TDR");
        }
    }
}