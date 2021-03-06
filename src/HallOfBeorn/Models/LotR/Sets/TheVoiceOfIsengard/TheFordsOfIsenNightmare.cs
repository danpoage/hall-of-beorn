﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheVoiceOfIsengard
{
    public class TheFordsOfIsenNightmare : CardSet
    {
        const string setName = "The Fords of Isen Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TFoIN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2065;

            Cards.Add(new LotRCard()
            {
                Title = setName,
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\nForced: After the players advance to a new quest stage, each player with fewer than 3 cards in his hand draws 3 cards.",
                FlavorText = "\"Not in half a thousand years have they forgotten their grievance that the lords of Gondor gave the Mark to Eorl the young and made alliance with him.\" -Gamling, The Two Towers",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the The Fords of Isen scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x ~Dunland Prowler
2x Dunlending Bandit
1x ~Dunland Berserker
2x Gap of ~Rohan
2x The King's ~Road

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Fords of Isen encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(LotRCard.Enemy("Dunland Assassin", "", setName, 45, 3, 3, 3, 5)
                .WithTraits("Dunland.")
                .WithText("Dunland Assassin cannot be optionally engaged by a player with 3 or more cards in his hand.\r\nWhile Dunland Assassin is in the staging area, it gains: \"Forced: After the first player draws any number of cards, Dunland Assassin makes an immediate attack against him.\"")
                .WithInfo(2, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Enemy("Vengeful Hillman", "", setName, 27, 2, 4, 2, 4)
                .WithTraits("Dunland.")
                .WithText("Forced: After Vengeful Hillman attacks and destroys a character, remove 1 progress the current quest card for each card in the defending player's hand.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithInfo(3, 3, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Enemy("Savage Hillman", "", setName, 20, 1, 2, 1, 3)
                .WithTraits("Dunland.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("While the engaged player has 3 or more cards in hand, Savage Hillman cannot take damage.\r\nWhile the engaged player has 5 or more cards in hand, Savage Hillman gets +2 Attack.")
                .WithInfo(4, 3, Artist.Suzanne_Helmigh));
            addLocation("Western Shore", setName, Card.VALUE_X, 4)
                .WithTraits("River.", "Valley.")
                .WithTextLine("X is the number of cards in the first player's hand.")
                .WithTextLine("While Western Shore is in the staging area, each enemy gets -X engagement cost.")
                .WithShadow("Shadow: If you have 5 or more cards in your hand, this attack is considered undefended.")
                .WithInfo(5, 3, Artist.Julian_Kok);
            addLocation("Eastern Shore", setName, 3, 4)
                .WithTraits("River.", "Valley.")
                .WithText("While Eastern Shore is in the staging area, each player cannot play more than 1 event each round.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, remove 1 time counter from the current quest.")
                .WithInfo(6, 3, Artist.Julian_Kok);
            Cards.Add(LotRCard.Location("Isen River", "", setName, 2, 5)
                .WithTraits("River.")
                .WithText("While Isen River is in the staging area, each player cannot discard cards from his hand.\r\nForced: After Isen River becomes the active location, each player draws a card")
                .WithFlavor("Now further, and now nearer Isen flowed in its stony bed.\r\n-The Two Towers")
                .WithInfo(7, 3, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Treachery("Brutal Assault", "", setName)
                .WithText("When Revealed: Each player assigns X damage among characters he controls, where X is the number of cards in his hand.")
                .WithShadow("Shadow: Assign X damage among characters you control. X is the number of cards in your hand.")
                .WithInfo(8, 2, Artist.JB_Casacop));
        }
    }
}