using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class ConflictAtTheCarrockNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Conflict at the Carrock Nightmare";
            Abbreviation = "CatCN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2004;

            Cards.Add(new LotRCard()
            {
                Title = "Conflict at the Carrock Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                Id = "2E094DA7-6760-45AB-9E2E-E2BAA5F58BE7",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

" + "Stage 1A should read, \"Remove 5 unique Troll cards\" instead of 4.\r\n\r\n" +

"Stage 2B should read, \"When Revealed: Place Louis, Morris, Rupert and Stuart into the staging area.\"\r\n\r\n" +

@"Forced: At the end of the quest phase, if no progress was placed on the current quest this phase, place 1 progress on the current quest (bypassing the active location).

" +

"Reponse: After defeating a unique Troll enemy, you may choose and discard 1 \"Sacked!\" card from play.",

                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Conflict at the Carrock scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x Grimbeorn the Old
1x Louis
1x Morris
1x Stuart
1x Rupert
3x Bee Pastures
3x Oak-wood Grove
1x Roasted Slowly
3x Misty ~Mountain Goblins
2x Banks of the Anduin
1x Wolf Rider
2x ~Goblin Sniper
2x Wargs
2x Despair
2x The Brown Lands
2x The East Bight

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Conflict at the Carrock encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",

                EncounterSet = "Conflict at the Carrock Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new LotRCard()
            {
                Title = "Savage Hill-troll",
                ImageType = Models.ImageType.Jpg,
                Id = "8028643D-4E92-4EC0-B001-2BC5789E09C6",
                CardType = CardType.Enemy,
                EngagementCost = 21,
                Threat = 1,
                Attack = 3,
                Defense = 2,
                HitPoints = 6,
                Traits = new List<string> { "Troll." },
                Text = "While Savage Hill-troll is in the victory display, each Troll enemy gets +1 hit point.",
                Shadow = "Shadow: If attacking enemy is a Troll, defending character does not ready during the refresh phase this round.",
                VictoryPoints = 1,
                EncounterSet = "Conflict at the Carrock Nightmare",
                Quantity = 4,
                CardNumber = 2,
                Artist = Artist.Jim_Pavelec
            });
            Cards.Add(new LotRCard()
            {
                Title = "Rob and Bob",
                ImageType = Models.ImageType.Jpg,
                Id = "7BC5EAA2-B25B-418F-ACC7-5B755EC429EE",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 34,
                Threat = 4,
                Attack = 5,
                Defense = 4,
                HitPoints = 10,
                Traits = new List<string> { "Troll." },
                Text = "Forced: After Rob and Bob makes its first attack each round, if there are two or more players, it engages the next player and makes an additional attack (discard and deal a new shadow card for this attack).",
                FlavorText = "Yes, I am afraid trolls do behave like that, even those with only one head each. -The Hobbit",
                EncounterSet = "Conflict at the Carrock Nightmare",
                Quantity = 1,
                CardNumber = 3,
                Artist = Artist.Jim_Pavelec
            });
            Cards.Add(new LotRCard()
            {
                Title = "Louis",
                ImageType = Models.ImageType.Jpg,
                Id = "A3757C06-9FF4-469D-984A-B21B41CCF0CE",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 34,
                Threat = 4,
                Attack = 4,
                Defense = 2,
                HitPoints = 10,
                Traits = new List<string> { "Troll." },
                Text = "Forced: After Louis attacks, the defending player must raise his threat by 3.\r\n\r\nWhile Louis is in the victory display, each Troll enemy gains, \"Forced: After this enemy attacks, the defending player must raise his threat by 1.\"",
                VictoryPoints = 2,
                EncounterSet = "Conflict at the Carrock Nightmare",
                Quantity = 1,
                CardNumber = 4,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new LotRCard()
            {
                Title = "Morris",
                ImageType = Models.ImageType.Jpg,
                Id = "A1484DD8-DCD3-4D39-BBD6-F23DBBE794D4",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 34,
                Threat = 3,
                Attack = 4,
                Defense = 2,
                HitPoints = 10,
                Traits = new List<string> { "Troll." },
                Text = "Immune to player events.\r\nWhile Morris is in the victory display, each Troll enemy gets +1 Attack and gains \"Immune to player events.\".",
                VictoryPoints = 2,
                EncounterSet = "Conflict at the Carrock Nightmare",
                Quantity = 1,
                CardNumber = 5,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Rupert",
                ImageType = Models.ImageType.Jpg,
                Id = "F7CEA583-D1F7-4466-A318-28071E408E29",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 34,
                Threat = 2,
                Attack = 5,
                Defense = 3,
                HitPoints = 10,
                Traits = new List<string> { "Troll." },
                Text = "Rupert's Defense cannot be reduced.\r\nWhile Rupert is in the victory display, the Defense of each Troll enemy cannot be reduced.",
                VictoryPoints = 2,
                EncounterSet = "Conflict at the Carrock Nightmare",
                Quantity = 1,
                CardNumber = 6,
                Artist = Artist.Sidharth_Chatursedi
            });
            Cards.Add(new LotRCard()
            {
                Title = "Stuart",
                ImageType = Models.ImageType.Jpg,
                Id = "0ECCBF56-5D7D-498B-BC04-D05E7C072979",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 34,
                Threat = 2,
                Attack = 4,
                Defense = 4,
                HitPoints = 10,
                Traits = new List<string> { "Troll." },
                Text = "Cannot have player attachments.\r\nWhile Stuart is in the victory display, each Troll enemy gets +1 Defense and gains \"Cannot have player attachments.\"",
                VictoryPoints = 2,
                EncounterSet = "Conflict at the Carrock Nightmare",
                Quantity = 1,
                CardNumber = 7,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Troll Lair",
                ImageType = Models.ImageType.Jpg,
                Id = "A964F86A-7DC9-4892-9A35-A4E665A8AA43",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 5,
                Traits = new List<string> { "Forest." },
                Text = "While Troll Lair is in the staging area, players cannot reduce their threat.",
                Shadow = "Shadow: If attacking enemy is a Troll, remove 4 damage tokens from it.",
                EncounterSet = "Conflict at the Carrock Nightmare",
                Quantity = 3,
                CardNumber = 8,
                Artist = Artist.Ed_Mattinian
            });
            Cards.Add(new LotRCard()
            {
                Title = "Hives and Hives",
                ImageType = Models.ImageType.Jpg,
                Id = "3681AF57-1689-445D-A594-E5F0156EC90C",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Wilderlands." },
                Text = "Forced: After any amount of progress is placed on Hives and Hives, deal 1 damage to each character in play.",
                Shadow = "Shadow: Attacking enemy gets +2 Attack.",
                FlavorText = "There was a buzzing and a whirring and a droning in the air. Bees were busy everywhere. And such bees! Bilbo had never seen anything like them. -The Hobbit",
                EncounterSet = "Conflict at the Carrock Nightmare",
                Quantity = 3,
                CardNumber = 9,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "Time for Supper",
                ImageType = Models.ImageType.Jpg,
                Id = "BF6EFB7A-88A6-4B10-BFB2-38027057332E",
                CardType = CardType.Treachery,
                Text = "When Revealed: The first player chooses a hero in any player's discard pile and removes that hero from the game. Then, heal all damage from each Troll enemy in play. If no damage is removed from any Troll enemy as a result of this effect, Time for Supper gains surge.",
                FlavorText = "In the end they decided to mince them fine and boil them. So they got a black pot, and they took out their knives. -The Hobbit",
                EncounterSet = "Conflict at the Carrock Nightmare",
                Quantity = 3,
                CardNumber = 10,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new LotRCard()
            {
                Title = "Grimbeorn's Folly",
                ImageType = Models.ImageType.Jpg,
                HasSecondImage = true,
                Id = "ED52944F-1499-4A0A-BB84-3CE5C18952DE",
                CardType = CardType.Quest,
                StageNumber = 3,
                QuestPoints = null,
                Text = "When Revealed: Add Rob and Bob to the staging area. Then, each player must search the encounter deck and discard pile for a non-unique Troll enemy and add it to the staging area, if able. Shuffle the encounter deck.",
                FlavorText = "Just as you think the fight is over, you find tracks that lead you to what appears to be the leader of this group of Trolls. You can see Grimbeorn the Old, captured and ready to be cooked. It's up to you to save him!",
                OppositeText = "When Rob and Bob have been defeated, the players have rescued Grimbeon the Old from certain death, and won the game.",
                OppositeFlavorText = "A nice pickle they were all in now. -The Hobbit",
                EncounterSet = "Conflict at the Carrock Nightmare",
                Quantity = 3,
                CardNumber = 11,
                Artist = Artist.Tiziano_Baracchi
            });
        }
    }
}