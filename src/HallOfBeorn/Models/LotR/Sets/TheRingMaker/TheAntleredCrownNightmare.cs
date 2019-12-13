using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TheAntleredCrownNightmare : CardSet
    {
        private const string setName = "The Antlered Crown Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TACN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2073;

            Cards.Add(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nLocations with time counters on them cannot be discarded from play by player card effect.")
                .WithFlavor("A smoke as of fire and battle arose, and again the sun went down in a burning red that faded into a grey mist...\r\n-The Fellowship of the Ring")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for THe Antlered Crown scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x Dunland Prowler
1x Dunland Berserker
2x Dunlending Bandit
3x Raven Skirmisher
3x Raven War-camp
2x Driven Back

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Antlered Crown encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.\r\nNote: Dunlending Horde has the 'Dunlending Warriors' encounter set icon and should be shuffled into the Raven deck during setup.")
                .WithInfo(1, 1, Artist.Yog_Joshi));
            Cards.Add(LotRCard.Enemy("Dunlending Horde", "", setName, 32, 4, 6, 3, 8)
                .WithTraits("Dunland.")
                .WithText("Cannot have attachments or take non-combat damage.\r\nForced: After the engaged player draws any number of cards, heal all damage from Dunlending Horde.")
                .WithInfo(2, 2, Artist.David_Keen));
            Cards.Add(LotRCard.Enemy("Raven Clan Elite", "", setName, 28, 2, 4, 2, 4)
                .WithTraits("Dunland.", "Raven Clan.")
                .WithText("When Revealed: Either remove 1 time counter from a location in play, or Raven Clan Elite make an immediate attack against the first player.")
                .WithFlavor("\"Death to the Fogoil! Death to the Strawheads!\"\r\n-Dunlending, The Two Towers")
                .WithInfo(3, 4, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Enemy("Raven Clan Druid", "", setName, 26, 3, 2, 3, 5)
                .WithTraits("Dunland.", "Raven Clan.")
                .WithText("Forced: After the engaged player draws any number of cards, remove 1 time counter from a location play.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the Time X value on the active location.")
                .WithInfo(4, 3, Artist.David_Keen));
            Cards.Add(LotRCard.Location("Raven Stronghold", "", setName, 2, 5)
                .WithTraits("Dunland.")
                .WithKeywords("Time 3.")
                .WithTextLine("Time 3.")
                .WithTextLine("Forced: After the last time counter is removed from this location, each player reveals the top card of the Raven deck and adds it to the staging area.\r\nForced: When this location is explored, add the top card of the Raven deck to the staging area.")
                .WithInfo(5, 4, Artist.Yog_Joshi));
            Cards.Add(LotRCard.Location("Highlands of Dunland", "", setName, 4, 4)
                .WithTraits("Dunland.")
                .WithKeywords("Time 2.")
                .WithTextLine("Time 2.")
                .WithTextLine("Forced: After the last time counter is removed from this location, return each enemy in play to the staging area.")
                .WithShadow("Shadow: Either remove 1 time counter from a location in play, or return attacking enemy to the staging area after this attack.")
                .WithInfo(6, 2, Artist.Michael_Rasmussen));
            Cards.Add(LotRCard.Treachery("Raven Talisman", "", setName)
                .WithText("When Revealed: Each player draws 1 card. Until the end of the round, add 1 to the total Threat in the staging area for each card in the first player's hand.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, discard your hand and draw 3 cards.")
                .WithInfo(7, 2, Artist.Ivan_Dixon));
            Cards.Add(LotRCard.Treachery("Gathering Forces", "", setName)
                .WithText("When Revealed: Add the top 2 cards of the Raven deck to the staging area. If any player has 5 or more cards in hand, this effect cannot be cancelled.")
                .WithShadow("Shadow: Put the top card of the Raven deck into play, engaged with you.")
                .WithInfo(8, 2, Artist.David_Keen));
        }
    }
}