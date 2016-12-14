using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class DungeonsDeepAndCavernsDimNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Dungeons Deep and Caverns Dim Nightmare";
            Abbreviation = "DDaCDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2052;

            Cards.Add(new LotRCard()
            {
                Title = "Dungeons Deep and Caverns Dim Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                Id = "128B10F6-8EF0-4AD2-A880-D43B175298D0",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

~Gollum cannot take damage.

Setup: Search the encounter deck for The Lower ~Gate and set it aside, out of play.

Forced: When stage 3B is revealed, add The Lower ~Gate to the staging area.",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Dungeons Deep and Caverns Dim scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x ~Goblin Miners
3x ~Goblin Axeman
3x The Goblins' Caves
3x Grip, grab! Pinch, nab!
1x Not fair! Not fair!

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Dungeons Deep and Caverns Dim encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "Dungeons Deep and Caverns Dim Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Lower Gate",
                ImageType = ImageType.Jpg,
                Id = "5EF7B3C4-C8AB-4077-B917-CAA404D1FA8A",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 8,
                Traits = new List<string> { "Mountain." },
                Text = 
@"No more than 4 progress can be placed on the current quest each round.

Creature enemies get +1 Attack.

Goblin enemies get +1 Defense.",
                FlavorText = "It was still ajar, but a goblin had pushed it nearly to. Bilbo struggled but he could not move it. -The Hobbit",
                EncounterSet = "Dungeons Deep and Caverns Dim Nightmare",
                Quantity = 1,
                CardNumber = 2,
                Artist = Artist.Nicholas_Gregory
            });
            Cards.Add(new LotRCard()
            {
                Title = "Wicked Wolf",
                ImageType = ImageType.Jpg,
                Id = "91BF1FD0-9F7F-4208-B011-93540916584F",
                CardType = CardType.Enemy,
                EngagementCost = 33,
                Threat = 4,
                Attack = 4,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Creature." },
                Text = "Forced: If Wicked Wolf is dealt a shadow card with a riddle, the defending player must exhaust a character he controls.",
                Shadow = "Shadow: Return attacking enemy to the staging area after this attack.",
                EncounterSet = "Dungeons Deep and Caverns Dim Nightmare",
                Quantity = 3,
                CardNumber = 3,
                Artist = Artist.JB_Casacop
            });
            Cards.Add(new LotRCard()
            {
                Title = "Lower Gate Sentries",
                ImageType = ImageType.Jpg,
                Id = "9652CBB6-267B-4F4D-8B45-A15D914683B2",
                CardType = CardType.Enemy,
                EngagementCost = 15,
                Threat = 2,
                Attack = 3,
                Defense = 4,
                HitPoints = 5,
                Traits = new List<string> { "Goblin.", "Orc." },
                Text = "Bilbo's Magic ~Ring does not ready during the refresh phase.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. (+3 Attack instead if Bilbo's Magic ~Ring is exhausted.)",
                EncounterSet = "Dungeons Deep and Caverns Dim Nightmare",
                Quantity = 3,
                CardNumber = 4,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new LotRCard()
            {
                Title = "Pine Slopes",
                ImageType = ImageType.Jpg,
                Id = "85EF235F-5142-4E7B-83B0-ABC1DFD0046A",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 6,
                Traits = new List<string> { "Forest." },
                Text = "Forced: Each time a Baggins resource is spent or discarded, raise each player's threat by 1.",
                Shadow = "Shadow: Deal attacking enemy 2 additional shadow cards for this attack.",
                EncounterSet = "Dungeons Deep and Caverns Dim Nightmare",
                Quantity = 3,
                CardNumber = 5,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new LotRCard()
            {
                Title = "Fallen Stones",
                ImageType = ImageType.Jpg,
                Id = "A2C71165-CE9A-4540-8E1F-8975D8E9B586",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 3,
                Traits = new List<string> { "Mountain." },
                Text = 
@"Travel: Deal 3 damage to each ready character. The first player may spend up to 3 Baggins resources to reduce the damage dealt to each character by 1 for each Baggins resource spent.

Riddle: The first player names a card title, shuffles his deck, and discards the top 5 cards. For each card that matches, place 1 progress on stage 2.",
                FlavorText = "",
                EncounterSet = "Dungeons Deep and Caverns Dim Nightmare",
                Quantity = 3,
                CardNumber = 6,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Where Isss It?",
                ImageType = ImageType.Jpg,
                Id = "BB1ED846-C9D3-4313-82F6-CE194FC84F81",
                CardType = CardType.Treachery,
                Text = 
@"When Revealed: Discard 2 resources from Bilbo Baggins's resource pool, or Gollum makes an attack against Bilbo ~Baggins.

Riddle: The first player names a sphere, a cost, and a card type, shuffles his deck, and discards the top 3 cards. For each card that matches all three items, place 1 progress on stage 2.",
                EncounterSet = "Dungeons Deep and Caverns Dim Nightmare",
                Quantity = 3,
                CardNumber = 7,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new LotRCard()
            {
                Title = "We Hates It!",
                ImageType = ImageType.Jpg,
                Id = "AA3C2832-695A-43CE-A768-B784D539169F",
                CardType = CardType.Treachery,
                Text = "When Revealed: Attach We Hates Is! to Gollum. (Counts as a Condition attachment with the text: \"If the players are on stage 3, Gollum gets +2 Attack.\")\r\n\r\nRiddle: The first player names a Trait, shuffles his deck, and discards the top card. For each card that has at least 1 matching Trait, place 1 progress on stage 2.",
                EncounterSet = "Dungeons Deep and Caverns Dim Nightmare",
                Quantity = 3,
                CardNumber = 8,
                Artist = Artist.Jake_Murray
            });
        }
    }
}