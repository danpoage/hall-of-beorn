using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class TempleOfTheDeceivedNightmareSet : CardSet
    {
        protected override void Initialize()
        {
            Name = EncounterSet.TempleOfTheDeceivedNightmare.Name;
            Abbreviation = "TotDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2086;

            addNightmareSetup(EncounterSet.TempleOfTheDeceivedNightmare.Name)
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
                .WithInfo(1, 1, Artist.Federico_Musetti);
            addLocation("Desecrated Ruins", EncounterSet.TempleOfTheDeceivedNightmare.Name, 4, 6)
                .WithOppositeTitle("Edge of the Temple")
                .WithTraits("Ruins.")
                .WithKeywords("Uncharted.")
                .WithText("Forced: When Desecrated Ruins is flipped over while active, remove all resources from each hero and objective-ally.")
                .WithFlavor("Tar-Palantir attempted to ammend the evil: but it was too late, and there was rebellion and strife in Númenor\r\n-The Return of the King")
                .WithOppositeText("Uncharted. Cannot have player card attachments.\r\nForced: After Edge of the Temple becomes the active location, flip it over.\r\nAction: Remove 8 progress from Edge of the Temple to look at its facedown side.")
                .WithInfo(2, 3, Artist.Federico_Musetti);
            addLocation("Temple Foothills", EncounterSet.TempleOfTheDeceivedNightmare.Name, 2, 5)
                .WithOppositeTitle("Edge of the Temple")
                .WithTraits("Ruins.")
                .WithKeywords("Uncharted.")
                .WithText("While Temple Foothills is the active location, the players, as a group, cannot play more than 1 card each round.")
                .WithOppositeText("Uncharted. Cannot have player card attachments.\r\nForced: After Edge of the Temple becomes the active location, flip it over.\r\nAction: Remove 8 progress from Edge of the Temple to look at its facedown side.")
                .WithInfo(3, 3, Artist.Julian_Kok);
            addLocation("Cursed Temple", EncounterSet.TempleOfTheDeceivedNightmare.Name, 3, 4)
                .WithOppositeTitle("Edge of the Temple")
                .WithTraits("Ruins.")
                .WithKeywords("Uncharted.")
                .WithText("Forced: When Cursed Temple is flipped over while active, discard 3 cards at random from each player's hand.\r\nWhile Cursed Temple is the active location, each player cannot draw cards by card effects.")
                .WithOppositeText("Uncharted. Cannot have player card attachments.\r\nForced: After Edge of the Temple becomes the active location, flip it over.\r\nAction: Remove 8 progress from Edge of the Temple to look at its facedown side.")
                .WithInfo(4, 3, Artist.Julian_Kok);
            addEnemy("King's Knight", EncounterSet.TempleOfTheDeceivedNightmare.Name, 23, 4, 4, 4, 6)
                .WithTraits("Undead.")
                .WithText("Forced: After King's Knight attacks, if no damage was dealt by its attack, return it to the staging area.")
                .WithShadow("Shadow: If no damage is dealt by this attack, return attacking enemy to the staging area after this attack.")
                .WithInfo(5, 2, Artist.Chris_Grun);
            addEnemy("Cursed Soldier", EncounterSet.TempleOfTheDeceivedNightmare.Name, 28, 3, 3, 3, 4)
                .WithTraits("Undead.")
                .WithText("While the active location is in the top rown, Cursed Soldier gets +3 Threat.\r\nWhile the active location is in the middle row, Cursed Soldier gets +3 Attack.\r\nWhile the active location is in the bottom row, Cursed Soldier gets +3 Defense.")
                .WithInfo(6, 2, Artist.Chris_Grun);
            addTreachery("Deceitful Island", EncounterSet.TempleOfTheDeceivedNightmare.Name)
                .WithKeywords("Doomed 3.")
                .WithText("When Revealed: Switch the placement of the active location with the location above or below it, or to its left (the active location does not change). Then, flip each adjacement location to its \"Lost Island\" or \"Edge of the Temple\" side.")
                .WithInfo(7, 2, Artist.Jordan_Saia);
            addTreachery("Call of the Curse", EncounterSet.TempleOfTheDeceivedNightmare.Name)
                .WithText("When Revealed: Until the end of the round, each Undead enemy gets +X Attack and +X Defense. X is the number of locations to the left of the active location (in its row). If X is 0 or 1, Call of the Curse gains surge.")
                .WithShadow("Shadow: Resolve the 'when revealed' effect of Call of the Curse.")
                .WithInfo(8, 2, Artist.Monztre);
            addTreachery("Sudden Precipice", EncounterSet.TempleOfTheDeceivedNightmare.Name)
                .WithText("When Revealed: Attach to the active location. (Counts as a Condition attachment with the text: \"Forced: After you travel from attached location to the right, deal 2 damage to each exhausted character.\")")
                .WithShadow("Shadow: Attacking enemy makes an additional attack after this one.")
                .WithInfo(8, 3, Artist.Federico_Musetti);
        }
    }
}
