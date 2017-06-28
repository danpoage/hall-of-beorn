using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class TheUrukHaiNightmare : CardSet
    {
        private const string setName = "The Uruk-hai Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TUHN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2068;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nEach Captive is immune to player card effects.\r\nSetup: Set Mauhúr aisde, out of play.\r\nForced: When the players advance to  stage 2A, add Mauhúr to the staging area.")
                .WithFlavor("\r\n-The Two Towers")
                .WithOppositeText("Begin with the standard and encounter deck for The Passage of the Marshes scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\n3x Groping Dead\r\n3x Dead Things\r\n3x Soft Mires\r\n3x Haunted Mere\r\n3x Bitter Reek\r\nThen, shuffle the encounter cards in this Nightmare ~Deck into the remainder of the standard The Passage of the Marshes encounter deck.\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Lucas_Staniec));
            addCard(LotRCard.Enemy("Mauhúr", string.Empty, setName, 24, 4, 5, 2, 4)
                .WithUnique()
                .WithTraits("Orc.", "Uruk-hai.")
                .WithKeywords("Toughness 1.", "Archer 2.")
                .WithText("Forced: After Mauhúr attacks, increase the pursuit value by 1.")
                .WithFlavor("\"Mauhúr and his lads are in the forest, and they should turn up any time now.\" -Uglúk, The Two Towers")
                .WithVictoryPoints(4)
                .WithInfo(2, 1, Artist.Monztre));
            addCard(LotRCard.Enemy("Lugdash", string.Empty, setName, 32, 3, 4, 2, 5)
                .WithUnique()
                .WithTraits("Orc.", "Uruk-hai.")
                .WithKeywords("Toughness 2.")
                .WithText("While Lugdash is engaged with a player, each other enemy cannot take damage.")
                .WithShadow("Shadow: If attacking enemy is unique, it cannot take damage until the end of the round.")
                .WithVictoryPoints(3)
                .WithInfo(3, 1, Artist.Monztre));
            addCard(LotRCard.Enemy("Orc of the White Hand", string.Empty, setName, 28, 3, 3, 1, 3)
                .WithTraits("Orc.", "Uruk-hai.")
                .WithKeywords("Toughness 2.")
                .WithText("Forced: After Orc of the White Hand attacks and destroy a character, increase the pursuit value by 1.")
                .WithShadow("Shadow: If this attack destroys a character, increase the pursuit value by 1.")
                .WithInfo(4, 4, Artist.Guillaume_Ducos));
            addCard(LotRCard.Location("Wold of Rohan", string.Empty, setName, 5, 5)
                .WithTraits("Plains.", "Hills.")
                .WithText("Action: Increase the pursuit value by 1 to place 1 progress on Wold of Rohan.")
                .WithShadow("Shadow: Discard a non-objective attachment you control.")
                .WithFlavor("...the land sloped down into a wide shallow depression, where the ground was soft and wet. -The Two Towers")
                .WithInfo(5, 2, Artist.Tropa_Entertainment));
            addCard(LotRCard.Location("Enchanted Land", string.Empty, setName, 3, 4)
                .WithTraits("Plains.")
                .WithText("Forced: After an encounter card effect is canceled, increase the pursuit value by 1.")
                .WithShadow("Shadow: Either increase the pursuit value by 1, or attacking enemy cannot take damage until the end of the round.")
                .WithInfo(6, 3, Artist.Nicholas_Gregory));
            addCard(LotRCard.Location("The Uruk's Trail", string.Empty, setName, 3, 6)
                .WithTraits("Plains.")
                .WithText("While The Uruk's Trail is the active location, it gains: \"Response: After The Uruk's Trail is explored, reduce the pursuit value by 3.\"\r\nTravel: Search the encounter deck and discard pile for a non-unique Uruk-hai enemy and add it to the staging area. Shuffle the encounter deck.")
                .WithInfo(7, 3, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Treachery("Uglúk's Command", string.Empty, setName)
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either increase the pursuit value by 4, or Uglúk makes an immediate attack against you.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the tens digit of the pursuit value.")
                .WithInfo(8, 3, Artist.Guillaume_Ducos));
            addCard(LotRCard.Treachery("Orc-draught", string.Empty, setName)
                .WithKeywords("Peril.", "Surge.")
                .WithText("When Revealed: ")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithFlavor("The Orcs clapped and hooted. \"Can't take his medicine,\" they jeered.\r\n-The Two Towers")
                .WithInfo(9, 2, Artist.Rafal_Hrynkiewicz));
        }
    }
}