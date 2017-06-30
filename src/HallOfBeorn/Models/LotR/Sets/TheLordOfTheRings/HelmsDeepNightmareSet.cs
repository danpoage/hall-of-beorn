using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class HelmsDeepNightmareSet : CardSet
    {
        private const string setName = "Helm's Deep Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "HDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2069;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.")
                .WithFlavor("Arrows thick as the rain came whistling over the battlements, and fell clinking and glancing on the stones. Some found a mark. The assault on Helm's Deep had begun...\r\n-The Two Towers")
                .WithOppositeText("Begin with the standard quest deck and encounter deck for the Helm's Deep scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\n1x Isengard Uruk\r\n3x Uruk-hai Fighter\r\n3x Wild Hillman\r\n3x The Hornburg\r\n1x Deeping Wall\r\n2x Postern Door\r\n2x Reckless Hate\r\nThen, shuffle the encounter cards in this Nightmare ~Deck into the remainder of the standard Helm's Deep encounter deck.\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Enemy("Host of Isengard", string.Empty, setName, 48, 4, 8, 2, 8)
                .WithTraits("Orc.", "Uruk-hai.")
                .WithKeywords("Toughness 2.")
                .WithText("Cannot have attachments.\r\nWhile Host of Isengard is in the staging area, it gains: \"Forced: At the end of the round, place 1 progress on the current quest (bypassing any active location).\"")
                .WithInfo(2, 3, Artist.Nicholas_Gregory));
            addCard(LotRCard.Enemy("Bloodied Berserker", string.Empty, setName, 28, 3, 4, 2, 4)
                .WithTraits("Dunland.")
                .WithText("Forced: When Bloodied Berserker is dealt a shadow card with no effect, either place 2 progress on the active location, or Bloodied Berserker makes an additional attack against you.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithInfo(3, 4, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Location("Helm's Dike", string.Empty, setName, 3, 2)
                .WithTraits("Helm's Deep.")
                .WithText("While Helm's Dike is the active location, each enemy gets -10 engagement cost.\r\nForced: When Helm's Dike is explored, shuffle the encounter discard pile into the encounter deck and discard cards from the top until an enemy is discarded. Add the discarded enemy to the staging area.")
                .WithInfo(4, 2, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Location("Hornburg Wall", string.Empty, setName, 3, 3)
                .WithTraits("Helm's Deep.")
                .WithText("Each enemy gains Toughness 1.\r\nForced: When Hornburg Wall is explored, exhaust each ally in play.")
                .WithShadow("Shadow: Discard a non-objective attachment you control.")
                .WithInfo(5, 3, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Location("Glittering Caves", string.Empty, setName, 2, 2)
                .WithTraits("Helm's Deep.")
                .WithText("Immune to player card effects.\r\nThe players cannot travel here unless they are at stage 4B.\r\nWhile Glittering Caves is the active location, it gains: \"Skip the combat phase. Forced: At the end of the round, add Glittering Caves to the victory display and raise each player's threat by 2.\"")
                .WithVictoryPoints(2)
                .WithInfo(6, 2, Artist.Monztre));
            addCard(LotRCard.Treachery("Rain of Arrows", string.Empty, setName)
                .WithText("When Revealed: Either remove 1 resource token from The Defense of Helm's Deep, or each location in the staging area gains archery 1 until the end of the round.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(7, 3, Artist.Tropa_Entertainment));
            addCard(LotRCard.Treachery("Crippling Weariness", string.Empty, setName)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each player exhausts a character he controls. Until the end of the round, characters cannot be readied by player card effects.")
                .WithShadow("Shadow: Until the end of the round, defending character cannot ready.")
                .WithInfo(8, 2, Artist.Kim_Sokol));
        }
    }
}