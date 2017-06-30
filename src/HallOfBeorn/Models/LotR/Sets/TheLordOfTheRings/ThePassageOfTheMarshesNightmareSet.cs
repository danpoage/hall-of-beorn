using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class ThePassageOfTheMarshesNightmareSet : CardSet
    {
        private const string setName = "The Passage of the Marshes Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TPotMN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2071;
   
            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nForced: When a location in the staging are is explored, raise each player's threat by X, where X is that location's Mire value.")
                .WithFlavor("Often they floundered, stepping or falling hands-first into waters as noisome as a cesspool, till they were slimed and fouled almost up to their necks and stank in one another's nostrils. -The Two Towers")
                .WithOppositeText("Begin with the standard quest deck and encounter deck for The Passage of the Marshes scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\n3x Groping Dead\r\n3x Dead Things\r\n3x Soft Mires\r\n3x Haunted Mere\r\n3x Bitter Reek\r\nThen, shuffle the encounter cards in this Nightmare ~Deck into the remainder of the standard The Passage of the Marshes encounter deck.\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Lucas_Staniec));
            addCard(LotRCard.Location("Festering Mere", string.Empty, setName, 5, 6)
                .WithTraits("Marsh.")
                .WithKeywords("Mire 2.")
                .WithText("Forced: When Festering Mire is discarded by the Mire keyword, each player discards his hand.\r\nTravel: Each player discard 1 random card from his hand to travel here.")
                .WithVictoryPoints(2)
                .WithInfo(2, 3, Artist.Lucas_Staniec));
            addCard(LotRCard.Location("Candle-lit Pool", string.Empty, setName, 4, 5)
                .WithTraits("Marhs.")
                .WithKeywords("Mire 3.")
                .WithText("Forced: When Candle-lit Pool is discarded by the Mire keyword, each player searches the encounter deck and discard pile for an Undead enemy and puts it into play engaged with him.\r\nTravel: Spend 2 Fellowship resources to travel here.")
                .WithVictoryPoints(3)
                .WithInfo(3, 3, Artist.Guillaume_Ducos));
            addCard(LotRCard.Location("Great Reed Thicket", string.Empty, setName, 2, 3)
                .WithTraits("Marsh.")
                .WithKeywords("Mire 2.")
                .WithText("Forced: When Great Reed Thicket is discarded by the Mire keyword, either flip Sméagol to Gollum, or Gollum makes an immediate attack.\r\nTravel: Exhaust Sméagol to travel here.")
                .WithVictoryPoints(2)
                .WithInfo(4, 2, Artist.Lucas_Staniec));
            addCard(LotRCard.Enemy("Pale Faces", string.Empty, setName, 30, 2, 4, 3, 5)
                .WithTraits("Undead.")
                .WithText("The engaged player cannot reduce his threat.\r\nForced: When Pale Faces attacks, raise your threat by 4.")
                .WithShadow("Shadow: Attacking enemy get +X Attack, where X is the Mire X value of the active location.")
                .WithInfo(5, 3, Artist.Alexander_Kozachenko));
            addCard(LotRCard.Enemy("Rotting Thing", string.Empty, setName, 34, 4, 6, 3, 8)
                .WithTraits("Undead.")
                .WithText("Cannot have attachments.\r\nThe engaged player cannot reduce his threat.\r\nForced: After Rotting Thing attacks and destroys a character, place 1 mire token on the active location for each excess point of damage.")
                .WithInfo(6, 3, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Treachery("Rot and Vapors", string.Empty, setName)
                .WithText("When Revealed: Each player must choose: either raise your threat by 1 for each questing character you control, or deal 1 damage to each character you control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place 1 mire token on the active location.")
                .WithInfo(7, 3, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Treachery("Gollum's Rage", string.Empty, setName)
                .WithKeywords("Peril.", "Surge.")
                .WithText("When Revealed: Deal Gollum's Rage to Gollum as a facedown shadow card, if able.")
                .WithShadow("Shadow: If attacking enemy is Gollum, it gets +1 Attack and makes an additional attack against you after this one.")
                .WithInfo(8, 2, Artist.Anthony_Devine));
        }
    }
}