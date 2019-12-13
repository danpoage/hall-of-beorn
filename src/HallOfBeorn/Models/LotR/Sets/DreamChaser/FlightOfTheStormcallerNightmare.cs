using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class FlightOfTheStormcallerNightmare : CardSet
    {
        private const string setName = "Flight of the Stormcaller Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "FotSN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2084;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nWhile you are at the same stage as the Stormcaller, the main quest gets +X quest points, where X is the Stormcaller's remaining hit points.")
                .WithFlavor("...the Sea became a word of fear among them, and a token of death, and they turned their faces away from the hills in the west.\r\n-The Fellowship of the Ring")
                .WithTemplate(
@"<p class='main-text'>You are playing Nightmare mode.</p>
<p class='main-text'>While you are at the same stage as the Stormcaller, the main quest gets +X quest points, where X is the Stormcaller's remaining hit points.</p>
<p class='flavor-text'>...the Sea became a word of fear among them, and a token of death, and they turned their faces away from the hills in the west.<br>&mdash;The Fellowship of the Ring</p>")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for the Flight of the Stormcaller scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:

2x Calm Waters
2x Corsair Skiff
2x Southron Sailor
2x Serpent's Blade
1x Hidden Cove
2x Jagged Reef

Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Flight on the Stormcaller encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.

☸*: Some Cards in the Flight of the Stormcaller Nightmare Deck have Sailing Success symbols (☸) with an asterisk (*) next to them. This indicates that the card has a Forced effect which will trigger when the card is discarded during a sailing test.")
                .WithTemplate2(
@"<p>Begin with the standard quest deck and encounter deck for the Flight of the Stormcaller scenario.</p><p>Remove the following cards, in the specified quantities, from the standard encounter deck:</p>
<ul style='list-style-type:none'><b>
<li>2x Calm Waters</li>
<li>2x Corsair Skiff</li>
<li>2x Southron Sailor</li>
<li>2x Serpent's Blade</li>
<li>1x Hidden Cove</li>
<li>2x Jagged Cliff</li>
</b></ul>
<p>Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Flight of the Stormcaller encounter deck.</p>
<p>Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.</p>
<p><b>☸*:</b> Some Cards in the Flight of the Nightmare Deck have Sailing Success symbols (<b>☸</b>) with an asterisk (<b>*</b>) next to them. This indicates that the card has a <b>Forced</b> effect which will trigger when the card is discarded during a sailing test.</p>")
                .WithInfo(1, 1, Artist.Federico_Musetti));
            addCard(LotRCard.Enemy("Raider of the Storm", string.Empty, setName, 28, 0, 3, 3, 4)
                .WithTraits("Corsair.")
                .WithText("While Raider of the Storm is engaged with you, each Ship enemy engaged with you gets +1 Threat, +1 Attack, +1 Defense, and contributes its Threat to the total Threat in the staging area.")
                .WithInfo(2, 2, Artist.Monztre));
            addCard(LotRCard.ShipEnemy("Tide-runner", setName, 44, 4, 4, 2, 9)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithText("Boarding 1. Cannot have attachments.\r\nWhile you are off-course (Cloudy, Rainy, or Stormy), Tide-runner is considered to be in the Stormcaller's area and the staging area, regardless of its current location.\r\nWhen Revealed: Either choose a player to engage Tide-runner, or add Tide-runner to the Stormcaller's area and it gains surge.")
                .WithInfo(3, 2, Artist.Unknown));
            addCard(LotRCard.ShipEnemy("Venom's Bite", setName, 34, 5, 8, 5, 14)
                .WithUnique()
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithText("Boarding 2. Cannot have attachments.\r\n*Forced: After this Sailing test ends, if you are off-course (Cloudy, Rainy, or Stormy), put the Venom's Bite into play in the staging area. If you are on-course (Sunny), put it into play in the Stormcaller's area instead.\r\n☸*")
                .WithVictoryPoints(5)
                .WithInfo(4, 1, Artist.Unknown));
            addCard(LotRCard.Location("Sharp Jetties", string.Empty, setName, 2, 6)
                .WithTraits("Coastland.", "Ocean.")
                .WithText("When Revealed: If your heading is off-course (Cloudy, Rainy, or Stormy), make Sharp Jetties the active location, returning any currently active location to the staging area.\r\nForced: When any amount of progress is placed on Sharp Jetties, either remove an equal amount of progress from the current quest, or deal an equal amount of damage to each Ship objective.")
                .WithInfo(5, 2, Artist.Jordan_Saia));
            addCard(LotRCard.Location("Cliffside Inlet", string.Empty, setName, 4, 3)
                .WithTraits("Coastland.", "Ocean.")
                .WithText("While Cliffside Inlet is in the staging area, the main quest gets +2 quest points.\r\nTravel: Discard cards from the top of the encounter deck until a Ship enemy is discarded. Put that enemy into play in the Stormcaller's area.\r\n☸")
                .WithInfo(6, 2, Artist.Jordan_Saia));
            addCard(LotRCard.Treachery("Dark and Stormy", string.Empty, setName)
                .WithTraits("Weather.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Deal 1 shadow card to each Ship enemy in play. Until the end of the round, shadow effects cannot be canceled.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack after this one.")
                .WithInfo(7, 2, Artist.Federico_Musetti));
            addCard(LotRCard.Treachery("Sahír's Getting Away!", string.Empty, setName)
                .WithText("When Revealed: For each Ship enemy in the Stormcaller's area, place 1 progress on the Stormcaller's quest stage. Then, either shift your heading off-course or add 8 Threat to the staging area until the end of the phase.")
                .WithShadow("Shadow: If this attack damages a Ship objective, place 1 progress on the Stormcaller's quest stage.")
                .WithInfo(8, 2, Artist.Guillaume_Ducos));
        }
    }
}
