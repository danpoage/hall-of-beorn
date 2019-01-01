using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class TheThingInTheDepthsNightmare : CardSet
    {
        private const string setName = "The Thing in the Depths Nightmare";
        private const string setStormcaller = "The Stormcaller Nightmare";
        private const string setCorsair = "Corsair Raiders Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TTiTDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2085;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nForced: After The Thing in the Depths enemy enters play, it attacks each player in turn order from the staging area (deal and resolve a shadow card for each attack).\r\nStage 3B gains: \"Forced: At the beginning of the quest phase, if there are fewer locations in play than the number of players, discard cards from the top of the encounter deck until a location is discarded. Reveal that location.\r\nForced: At the end of the refresh phase, resolve the grapple keyword on each Tentacle enemy in play.")
                .WithTemplate(
@"<p class='main-text'>You are playing Nightmare mode.</p>
<p class='main-text'>Forced: After The Thing in the Depths enemy enters play, it attacks each player in turn order from the staging area (deal and resolve a shadow card for each attack).</p><p class='main-text'>Stage 3B gains: <blockquote><b>Forced:</b> At the beginning of the quest phase, if there are fewer locations in play than the number of players, discard cards from the top of the encounter deck until a location is discarded. Reveal that location.</blockquote></p><p class='main-text'><b>Forced:</b> At the end of the refresh phase, resolve the grapple keyword on each <b><i>Tentacle</i></b> enemy in play.</p>")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for the The Thing in the Depths scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:

2x Corsair Infiltrator
1x Crew Quarters
1x Crushing Arm
1x Grasping Arm
1x Giant Arm

Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Thing in the Depths encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithTemplate2(
@"<p>Begin with the standard quest deck and encounter deck for <i>The Thing in the Depths</i> scenario.</p><p>Remove the following cards, in the specified quantities, from the standard encounter deck:</p>
<ul style='list-style-type:none'><b>
<li>2x Corsair Infiltrator</li>
<li>1x Crew Quarters</li>
<li>1x Crushing Arm</li>
<li>1x Grasping Arm</li>
<li>1x Giant Arm</li>
</b></ul>
<p>Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard <i>The Thing in the Depths</i> encounter deck.</p>
<p>Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.</p>")
                .WithInfo(1, 1, Artist.Nicholas_Gregory));
            addCard(LotRCard.Location("Captain's Quarters", string.Empty, setStormcaller, 5, 5)
                .WithUnique()
                .WithTraits("Ship.")
                .WithText("While Captain's Quarters is grappled, Raider characters are considered to have no resources.\r\nTravel: Add 2 resources to Captain Sahír (even if he is out of play) and 1 resource to each other Raider card in play.")
                .WithInfo(2, 1, Artist.Unknown));
            addCard(LotRCard.Location("Aft Cabin", string.Empty, setStormcaller, 3, 3)
                .WithTraits("Ship.", "Deck.")
                .WithText("While Aft Cabin is in the staging area, each enemy grappled with each Deck location adds 3 Threat instead of 2 Threat.\r\nForced: After an enemy is detached from Aft Cabin, that enemy gets +3 Defense until the end of the round.")
                .WithInfo(3, 3, Artist.Guillaume_Ducos));
            addCard(LotRCard.Treachery("Tumultuous Waters", string.Empty, setStormcaller)
                .WithTraits("Weather.")
                .WithText("When Revealed: Exhaust each character with 1 or less Willpower. Remove all resources from each ready hero and objective-ally.")
                .WithShadow("Shadow: If the defending character has 1 or less Willpower, treat this attack as undefended.")
                .WithInfo(4, 3, Artist.Guillaume_Ducos));
            addCard(LotRCard.Enemy("Corsair Duelist", string.Empty, setCorsair, 36, 3, 3, 1, 3)
                .WithTraits("Corsair.", "Raider.")
                .WithText("Corsair Duelist enters play with 2 resources on it.\r\nForced: When Corsair Duelist would be defeated, remove 1 resource and all damage from it instead.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each resource on it.")
                .WithInfo(5, 3, Artist.Adam_Lane));
            addCard(LotRCard.Enemy("Slithering Arm", string.Empty, setName, 0, 0, 4, 1, 5)
                .WithTraits("Creature.", "Tentacle.")
                .WithKeywords("Surge.", "Grapple (most enemies grappled).")
                .WithText("Forced: After Slitering Arm engages a player, it makes an immediate attack against that player.")
                .WithInfo(6, 3, Artist.Nicholas_Gregory));
            addCard(LotRCard.Enemy("Crashing Arm", string.Empty, setName, 27, 2, 6, 1, 7)
                .WithTraits("Creature.", "Tentacle.")
                .WithKeywords("Grapple (fewest enemies grappled).")
                .WithText("Forced: After Crashing Arm is detaced from a location, deal it 3 shadow cards.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack after this one.")
                .WithInfo(7, 3, Artist.Nicholas_Gregory));
            addCard(LotRCard.Treachery("Deep Maelstrom", string.Empty, setName)
                .WithText("When Revealed: For each location in play that is not grappled, reveal the top card of the encounter deck. If no cards are revealed by this effect, Deep Maelstrom gains Doomed 5. Cannot be canceled.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each enemy grappled with a location.")
                .WithInfo(8, 3, Artist.Guillaume_Ducos));
        }
    }
}