using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class CelebrimborsSecretNightmare : CardSet
    {
        private const string setName = "Celebrimbor's Secret Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "CSN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2072;

            Cards.Add(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nForced: When any amount of progress would be placed on a location in the staging area, reduce that amount to 1.\r\nScour: Deal 1 damage to a location in play.")
                .WithFlavor("\"In Eregion long ago many Elven-rings were made, magic rings as you call them, and they were, of course, of various kinds...\" -Gandalf, The Fellowship of the Ring")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for the Celebrimbor's Secret scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x Orc Skirmisher
1x Orc Hunter
3x Prowling Wolf
1x Ruined Plaza
1x City Remains
1x Ancient Foundation
3x Broken Lands
1x Spies from Mordor
2x Orc Hunting Party

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Celebrimbor's Secret encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Nele_Diel));
            Cards.Add(LotRCard.Enemy("Bellach's Bodyguard", "", setName, 45, 4, 4, 3, 6)
                .WithTraits("Mordor.", "Orc.")
                .WithText("Bellach cannot take damage.\r\nScour: Heal all damage from Bellach's Bodyguard.")
                .WithShadow("Shadow: Attacking enemy cannot take damage until the end of the phase.")
                .WithInfo(2, 3, Artist.Victor_Manuel_Leza_Moreno));
            Cards.Add(LotRCard.Enemy("Little Snuffler", "", setName, 15, 3, 3, 2, 3)
                .WithTraits("Orc.", "Snaga.")
                .WithText("When Revealed: Trigger Little Snuffler's Scour effect.\r\nScour: The first player discards a random card from his hand and assigns X damage among locations in the staging area. X is the discarded card's cost.")
                .WithInfo(3, 3, Artist.Ivan_Dixon));
            Cards.Add(LotRCard.Location("Bones of Hollin", "", setName, 3, 4)
                .WithTraits("Ost-in-Edhil.", "Ruins.")
                .WithText("Forced: After any amount of damage is placed on Bones of Hollin, raise each player's threat by that amount.\r\nTravel: Place 2 damage on an Ost-in-Edhil location in play to travel here.")
                .WithFlavor("\"...many Elves lived here in happier days, when Eregion was its name.\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(4, 3, Artist.Mark_Molnar));
            Cards.Add(LotRCard.Location("Dusty Labyrinth", "", setName, 2, 5)
                .WithTraits("Ost-in-Edhil.", "Ruins.")
                .WithText("Dusty Labyrinth gets +1 Threat for each damage on it.\r\nScour: Deal 2 damage to Dusty Labyrinth.\r\nTravel: The first player must place a card from his hand facedown underneath The Orcs' Search to travel here.")
                .WithInfo(5, 3, Artist.Nele_Diel));
            Cards.Add(LotRCard.Treachery("Hateful Search", "", setName)
                .WithText("When Revealed: Deal 1 damage to each location in the staging area. Until the end of the phase, each damaged location gets +1 Threat. If there are no locations in the staging area, Hateful Search gains surge.")
                .WithShadow("Shadow: Defending player discards a non-objective attachment he controls.")
                .WithInfo(6, 3, Artist.Claudio_Pozas));
            Cards.Add(LotRCard.Treachery("Sauron's Agent", "", setName)
                .WithText("When Revealed: Bellach makes an immediate attack against each player in turn order. Then, deal 1 damage to the active location for each character destroyed by this effect.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(7, 2, Artist.Javier_Charro_Martinez));
            Cards.Add(LotRCard.Treachery("Closing In", "", setName)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Place Closing In facedown underneath The Orcs' Search.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each card underneath The Orcs' Search.")
                .WithInfo(8, 2, Artist.Lukasz_Jaskolski));
        }
    }
}