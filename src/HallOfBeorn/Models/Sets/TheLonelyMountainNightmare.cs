using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheLonelyMountainNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Lonely Mountain Nightmare";
            Abbreviation = "TLMN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2057;

            Cards.Add(new Card()
            {
                Title = "The Lonely Mountain Nightmare",
                HasSecondImage = true,
                Id = "EF3EB70C-DB62-4936-8436-1C4AC260E5EC",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

While there is at least 1 card stacked underneath The Lonely Mountain, the players cannot advance to stage 3.

Smaug the Magnificent cannot take damage unless A Bare Patch is attached to him.",
                FlavorText = "The dwarves were still passing the cup from hand to hand and talking delightedly of the recovery of their treasure, when suddenly a vast rumbling woke in the mountain underneath as if it was an old volcano that had map up its mind to start eruptions once again. -The Hobbit",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Lonely Mountain scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x Dark Bats
2x Fighting Among Friends
3x Western Slopes
2x Secret Entrance
4x Belching Fire

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Lonely Moutain encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "The Lonely Mountain Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new Card()
            {
                Title = "Erebor Bats",
                Id = "80C660C1-D1E0-4E76-B0AE-DC6E8A85AF72",
                CardType = CardType.Enemy,
                EngagementCost = 15,
                Threat = 3,
                Attack = 3,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Creature." },
                Text =
@"Foced: When Erebor Bats attacks, the defending player discards 1 random card from his hand.

Burgle: The first player shuffles his deck and reveals the top card. He may discard 2 cards from his hand that match the card's cost and type.",
                EncounterSet = "The Lonely Mountain Nightmare",
                Quantity = 4,
                Number = 2,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Secret Tunnel",
                Id = "DD0ABD80-3CAE-473B-B703-709769C0DE44",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 6,
                Traits = new List<string> { "Underground." },
                Text = "Foced: After a player fails a burgle attempt, each player raises his threat by 2.\r\nTravel: Exhaust Bilbo Baggins and spend 1 Baggins resource to travel here.",
                FlavorText = "It was a red light steadily getting redder and redder. Also it was now undoubtedly hot in the tunnel. Wisps of vapour floated up and past him and he began to sweat.\r\n -The Hobbit",
                EncounterSet = "The Lonely Mountain Nightmare",
                Quantity = 3,
                Number = 3,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card()
            {
                Title = "Southern Spur",
                Id = "041F33FC-9A0C-4A44-B82D-20DB7B17ABCE",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 5,
                Traits = new List<string> { "Mountain." },
                Text = "Foced: At the end of the planning phase, each player who played at least 1 ally this phase must raise his threat by 1.",
                Shadow = "Shadow: Attacking enemy gets +2 Attack. If this attack destroys a character, raise each player's threat by 3.",
                EncounterSet = "The Lonely Mountain Nightmare",
                Quantity = 3,
                Number = 4,
                Artist = Artist.Titus_Lunter
            });
            Cards.Add(new Card()
            {
                Title = "The Front Gate",
                Id = "B3E3E92A-3E2D-43ED-AC5F-9297BF6EF6BE",
                CardType = CardType.Location,
                Threat = 5,
                QuestPoints = 2,
                Traits = new List<string> { "Mountain." },
                Text = "Foced: When the Front Gate is explored, each Dragon enemy in play makes an attack against the first player. (Deal and resolve a shadow card for this attack.)\r\nBurgle: The first player shuffles his deck and reveals the top card. He may discard 3 cards from his hand that match the revealed card's cost.",
                EncounterSet = "The Lonely Mountain Nightmare",
                Quantity = 2,
                Number = 5,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new Card()
            {
                Title = "The Dragon's Ire",
                Id = "89206288-3B44-4F10-B5A6-93D6A3D6753F",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Doomed 1." },
                Text = "When Revealed: Each Dragon enemy in play makes an immediate attack against each player in turn order. Do not deal shadow cards for these attacks. For each character that is destroyed by one of these attacks, place 1 progress on each Dragon enemy in play.",
                EncounterSet = "The Lonely Mountain Nightmare",
                Quantity = 4,
                Number = 6,
                Artist = Artist.Anthony_Feliciano
            });
            Cards.Add(new Card()
            {
                Title = "Lust for Treasure",
                Id = "26B96D8A-5D48-4459-829B-467AE4A5D692",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Doomed 1." },
                Text = "When Revealed: Each player raises his threat by 1 for each attachment attached to a character he controls.\r\nBurgle: The first player shuffles his deck and reveals the top card. He may discard 1 card from his hand that matches the revealed card's sphere, type, and cost.",
                EncounterSet = "The Lonely Mountain Nightmare",
                Quantity = 3,
                Number = 7,
                Artist = Artist.Sebastian_Giacobino
            });
        }
    }
}