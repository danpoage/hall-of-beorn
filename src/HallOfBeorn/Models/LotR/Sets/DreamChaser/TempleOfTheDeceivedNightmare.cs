using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class TempleOfTheDeceivedNightmare : CardSet
    {
        private const string setName = "Temple of the Deceived Nightmare";

        protected override void Initialize()
        {
                                    Name = setName;
            Abbreviation = "TotDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2086;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nForced: When preparing the Island Map, instead of the normal map placement, create the first three leftmost columns using the nine \"Lost Island\" cards, then create two middle columns using the siz new \"Edge of the Temple\" cards, and finally one rightmost column using the three \"Temple of the Deceived\" cards.\r\nForced: After the active location is explored, discard all player cards attached to that location.")
                .WithTemplate(
@"<p class='main-text'>You are playing Nightmare mode.</p><p class='main-text'><b>Forced:</b> When preparing the Island Map, instead of the normal map placement, create the first three leftmost columns using the nine &ldquo;Lost Island&rdquo; cards, then create two middle columns using the siz new &ldquo;Edge of the Temple&rdquo; cards, and finally one rightmost column using the three &ldquo;Temple of the Deceived&rdquo; cards.</p><p class='main-text'><b>Forced:</b> After the active location is explored, discard all player cards attached to that location.</p>")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for the Temple of the Deceived scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:

1x Jungle Path
2x Cursed Temple
1x Deeper into the Ruins
3x Sunken Ruins
2x Aimless Wandering
2x Curse of the Downfallen
1x Dwindling Supplies
3x Faithless Desecrator

Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Temple of the Deceived encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithTemplate2(
@"<p>Begin with the standard quest deck and encounter deck for the <i>Temple of the Deceived</i> scenario.</p><p>Remove the following cards, in the specified quantities, from the standard encounter deck:</p>
<ul style='list-style-type:none'><b>
<li>1x Jungle Path</li>
<li>2x Cursed Temple</li>
<li>1x Deeper into the Ruins</li>
<li>3x Sunken Ruins</li>
<li>2x Aimless Wandering</li>
<li>2x Curse of the Downfallen</li>
<li>1x Dwindling Supplies</li>
<li>3x Faithless Desecrator</li>
</b></ul>
<p>Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard <i>Temple of the Deceived</i> encounter deck.</p>
<p>Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.</p>")
                .WithInfo(1, 1, Artist.Federico_Musetti));
            addCard(LotRCard.Treachery("Call of the Curse", string.Empty, setName)
                .WithText("When Revealed: Until the end of the round, each Undead enemy gets +X Attack and +X Defense. X is the number of locations to the left of the active location (in its row). If X is 0 or 1, Call of the Curse gains surge.")
                .WithShadow("Shadow: Resolve the 'when revealed' effect of Call of the Curse.")
                .WithInfo(8, 2, Artist.Monztre));
        }
    }
}