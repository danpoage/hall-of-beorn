using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheGreyHavens
{
    public class TheFateOfNumenorNightmare : CardSet
    {
        private const string setName = "The Fate of Númenor Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TFoNN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2082;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nProgress cannot be placed on non-Uncharted locations in the staging area.\r\nForced: When the players would travel to Shrine of Morgoth, if there are 3 or fewer double-sided locations in the victory display, return Shrine to Morgoth to the staging area and flip it to its Lost Island side. Remove all progress from each Uncharted location in the staging area and shuffle them so that the players do not know which one is which. Then, choose a new location to travel to.")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for The Fate of Númenor scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:

2x ~Forbidden ~Coast
2x ~Cursed ~Temple
2x Flooded ~Ruins
2x Drowned Graves
2x Lush ~Jungle
1x ~Shrine of Morgoth
3x Steep Plateau
3x Aimless Wandering
1x Mysterious Fog
1x Servant of the Deceiver
1x Lingering Malevolence
1x Drowned Dead

Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Fate of Númenor encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.

Note: As print-on-demand cardstock does not match that in the original scenario, the Uncharted deck from the original scenario should be replaced with the Uncharted deck reprinted in this Nightmare deck. This has already been taken into account in the cards listed above.")
                .WithInfo(1, 1, Artist.DinoDrawing));
            addCard(LotRCard.Location("Shrine to Morgoth", string.Empty, setName, 5, 8)
                .WithUnique()
                .WithOppositeTitle("Lost Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Uncharted.\r\nCannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Ruins.")
                .WithText("While Shrine to Morgoth is the active location, players cannot draw cards or search their decks.\r\nForced: After Shrine to Morgoth is flipped over while active, exhaust each ally in play with printed cost 2 or less. Then, each player must search the encounter deck and discard pile for an Undead enemy and put it into play engaged with him. Shuffle the encounter deck.")
                .WithVictoryPoints(5)
                .WithInfo(2, 1, Artist.Jokubas_Uoginitas));
            addCard(LotRCard.Location("Cursed Temple", string.Empty, setName, 1, 3)
                .WithOppositeTitle("Lost Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Cannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Ruins.")
                .WithText("While Cursed Temple is the active location, characters with less than 2 Willpower do not ready during the refresh phase.")
                .WithFlavor("It was not long before he had bewitched the King and was master of his counsel... –The Return of the King")
                .WithInfo(3, 1, Artist.Davis_Engel));
            addCard(LotRCard.Location("Drowned Graves", string.Empty, setName, 2, 2)
                .WithOppositeTitle("Lost Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Cannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Ruins.")
                .WithText("Forced: After Drowned Graves is flipped to this side while active, discard the top X cards of the encounter deck. Each player adds an Undead enemy discarded from this effect to the staging area. X is 2 more than the number of players in the game.")
                .WithFlavor("...their years lessened as their fear of death grew, and their joy departed. –The Return of the King")
                .WithInfo(4, 2, Artist.Juan_Carlos_Barquet));
            addCard(LotRCard.Location("Flooded Ruins", string.Empty, setName, 3, 5)
                .WithOppositeTitle("Lost Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Cannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Ruins.")
                .WithText("While Flooded Ruins is the active location, it contributes its Threat to the staging area.")
                .WithFlavor("Númenor was thrown down and swallowed in the sea... –The Return of the King")
                .WithInfo(5, 1, Artist.Juan_Carlos_Barquet));
            addCard(LotRCard.Location("Lush Jungle", string.Empty, setName, 4, 4)
                .WithOppositeTitle("Lost Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Uncharted.\r\nCannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Forest.")
                .WithText("While Lush Jungle is in the staging area, characters get –1 Attack and lose ranged.\r\nForced: After Lush Jungle is flipped over while active, return it to the staging area unless each player exhausts each ready hero he controls.")
                .WithInfo(6, 2, Artist.Katy_Grierson));
            addCard(LotRCard.Location("Desecrated Grounds", string.Empty, setName, 5, 5)
                .WithOppositeTitle("Lost Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Uncharted.\r\nCannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Ruins.")
                .WithText("Each Undead enemy gets +1 Threat and +1 Attack.\r\nForced: After Desecrated Grounds is flipped over while active, deal 1 damage to each exhausted character.")
                .WithInfo(7, 2, Artist.DinoDrawing));
            addCard(LotRCard.Location("Forsaken City", string.Empty, setName, 5, 5)
                .WithOppositeTitle("Lost Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Uncharted.\r\nCannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Ruins.")
                .WithText("Each Undead enemy gains \"immune to player card effects.\"\r\nForced: After Forsaken City is flipped over while active, each engaged Undead enemy makes an immediate attack.")
                .WithInfo(8, 2, Artist.DinoDrawing));
            addCard(LotRCard.Enemy("Guardian of the Golden King", string.Empty, setName, 41, 4, 6, 4, 10)
                .WithTraits("Undead.")
                .WithText("Forced: After attackers are declared during an attack against Guardian of the Golden King, look at the bottom card of the first player's deck. Choose and remove characters from the attack until only X or fewer characters are attacking, where X is the looked-at-card's printed cost (those characters do not ready).")
                .WithInfo(9, 2, Artist.Sam_Lamont));
            addCard(LotRCard.Location("Overgrown Steps", string.Empty, setName, 2, 1)
                .WithTraits("Forest.", "Ruins.")
                .WithText("While Overgrown Steps is in the staging area, it gains: \"Each Uncharted location in the staging area gets +1 Threat.\"\r\nTravel: Raise each player's threat by 2 to travel here.")
                .WithInfo(10, 3, Artist.Adam_Duff));
            addCard(LotRCard.Treachery("Corrupted Flora", string.Empty, setName)
                .WithTraits("Hazard.")
                .WithText("When Revealed: Each player discards the bottom card of his deck. Each player player chooses and removes his characters from the until only X or fewer of his characters are questing, where X is the printed cost of the card that player discarded. Deal 1 damage to each character still committed to the quest.")
                .WithInfo(11, 3, Artist.Jeff_Lee_Johnson));
            addCard(LotRCard.Treachery("Calphon's Folly", string.Empty, setName)
                .WithText("When Revealed: Choose an Uncharted location in the staging area and flip it over. If it has a Forced effect, resolve it as if that location were active. If it does not have a Forced effect, switch it with the active location, if able.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the active location's Threat.")
                .WithInfo(12, 2, Artist.Joshua_Cairos));
        }
    }
}