using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheBattleofLakeTown : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Battle of Lake-town";
            Abbreviation = "TBoLT";
            Number = 3002;
            SetType = Models.SetType.GenCon_Expansion;
            Cycle = "GenCon";

            Cards.Add(new LotRCard()
            {
                Title = "Terror from the Mountain",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-1801203c9020",
                CardType = CardType.Quest,
                EncounterSet = "The Battle of Lake-town",
                Quantity = 1,
                QuestPoints = 14,
                Text = "Setup: Shuffle all copies of Smaug into a separate Smaug Deck. Search the encounter deck for Lake-town and add it to the staging area. Shuffle the encounter deck. Then reveal 1 card from the encounter deck per player, and add it to the staging area.",
                OppositeText = "Smaug cannot have more than 6 damage on him.\r\nWhen Revealed: Deal 1 damage to Lake-town for each player in the game.",
                FlavorText = "\"Then warning trumpets were suddenly sounded, and echoed along the rocky shores. The cheering stopped and the joy was quickly turned to dread. So it was that the dragon did not find them quite unprepared.\" - The Hobbit",
                CardNumber = 1,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Fire and Water",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-1801203c9006",
                CardType = CardType.Quest,
                
                EncounterSet = "The Battle of Lake-town",
                Quantity = 1,
                QuestPoints = 10,
                FlavorText = "\"...every vessel in the town was filled with water, every warrior was armed... before the roar of Smaug's terrible approach grew loud, and the lake rippled red as fire beneath the awful beating of his wings.\" - The Hobbit ",
                OppositeText = "Smaug cannot have more than 12 damage on him.\r\nWhen the players quest successfully, any number of progress tokens that would be placed on this quest may instead be discarded to remove the same amount of damage from Lake-town.",
                CardNumber = 2,
                Artist = Artist.Sabin_Boykinov
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "The Dragon's Wrath",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-1801203c9022",
                CardType = CardType.Quest,
                
                EncounterSet = "The Battle of Lake-town",
                Quantity = 1,
                QuestPoints = null,
                FlavorText = "\"Roaring he swept back over the town. A hail of dark arrows leaped up and snapped and rattled on his scales and jewels, and their shafts fell back kindled by his breath burning and hissing into the lake.\" - The Hobbit",
                OppositeText = "Forced: During the quest phase, reveal 1 additional card from the encounter deck.\r\nRefresh Action: Reset the quest deck to stage 2B.\r\nThe players must defeat Smaug to defeat this stage. When Smaug is defeated, compare the number of damage tokens on Lake-town with the number of Victory points in the victory display. If the players have more victory points, they have won the game. Otherwise, Lake-town has burned and the players have lost.",
                CardNumber = 3,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Smaug the Mighty",
                Id = "51223bd0-ffd1-11df-a976-1801203c9017",
                CardType = CardType.Enemy,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Dragon." },
                Quantity = 3,
                EngagementCost = 40,
                IsUnique = true,
                Attack = 5,
                Defense = 9,
                HitPoints = 20,
                Text = "Immune to player card effects.\r\nWhen Revealed: Smaug the Mighty makes an immediate attack against each player (deal and resolve a shodow card for each attack).",
                Threat = 7,
                CardNumber = 4,
                Artist = Artist.Christopher_Burdett
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Smaug the Terrible",
                Id = "51223bd0-ffd1-11df-a976-1801203c9018",
                CardType = CardType.Enemy,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Dragon." },
                Quantity = 3,
                EngagementCost = 35,
                IsUnique = true,
                Attack = 7,
                Defense = 7,
                HitPoints = 20,
                Text = "Immune to player card effects.\r\nWhen Revealed: Resolve all burn damage from all locations in play",
                Threat = 6,
                CardNumber = 5,
                Artist = Artist.Christopher_Burdett
            });
            Cards.Add(new LotRCard() {
                
                Title = "Smaug the Magnificent",
                Id = "51223bd0-ffd1-11df-a976-1801203c9016",
                CardType = CardType.Enemy,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Dragon." },
                Quantity = 3,
                EngagementCost = 30,
                IsUnique = true,
                Attack = 8,
                Defense = 8,
                HitPoints = 20,
                Text = "Immune to player card effects.\r\nExcess damage from attacks by Smaug the Magnificent must be assigned to Lake-town.When Revealed: Move 3 damage from Smaug the Magnificent to Lake-town.",
                Threat = 5,
                CardNumber = 6,
                Artist = Artist.Christopher_Burdett
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Lake-town",
                Id = "51223bd0-ffd1-11df-a976-1801203c9011",
                CardType = CardType.Objective,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "City." },
                Quantity = 1,
                IsUnique = true,
                Text = "If Lake-town has 50 or more damage on it, Lake-town has completely burned and the players have lost the game.",
                CardNumber = 7,
                Artist = Artist.Paolo_Puggioni
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "The Old Thrush",
                Id = "51223bd0-ffd1-11df-a976-1801203c9025",
                CardType = CardType.Objective,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Creature." },
                Quantity = 1,
                IsUnique = true,
                Text = "Action: Exhaust a hero to claim this objective and attach it to that hero when it is free of encounters. (Counts as an attachment with the text:'If detached discard The Old ThrushResponse: After attached hero exhausts to attack Smaug, discard X cards from hand to reduce Smaug's Defense by X.')",
                Keywords = new List<string>() { "Guarded." },
                CardNumber = 8,
                Artist = Artist.Paolo_Puggioni
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Close to the Flame",
                Id = "51223bd0-ffd1-11df-a976-1801203c9002",
                CardType = CardType.Treachery,
                EncounterSet = "The Battle of Lake-town",
                Quantity = 3,
                Text = "When Revealed: Deal 1 damage to each character in play",
                Shadow = "Shadow: Deal 1 damage to each character in play. Any player may discard a hero to cancel this effect",
                CardNumber = 9,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Scorching Blast",
                Id = "51223bd0-ffd1-11df-a976-1801203c9015",
                CardType = CardType.Treachery,
                EncounterSet = "The Battle of Lake-town",
                Quantity = 3,
                Text = "When Revealed: Resolve all burn damage from all locations in play.",
                Shadow = "Shadow: Resolve this card's 'When Revealed' effect. Any player may discard a hero to cancell this effect.",
                CardNumber = 10,
                Artist = Artist.David_Demaret
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Town-Baiting",
                Id = "51223bd0-ffd1-11df-a976-1801203c9026",
                CardType = CardType.Treachery,
                EncounterSet = "The Battle of Lake-town",
                Quantity = 3,
                Text = "When Revealed: Smaug make an attack against Lake-town. The last player may declare a defender against this attack. Excess damage from this attack must be placed on Lake-town. This effect cannot be canceled.",
                CardNumber = 11,
                Artist = Artist.Christopher_Burdett
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Dire Magnificence",
                Id = "51223bd0-ffd1-11df-a976-1801203c9003",
                CardType = CardType.Treachery,
                EncounterSet = "The Battle of Lake-town",
                Quantity = 3,
                Text = "When Revealed: Each player must choose and discard 1 ally he controls if able. Deal 2 damage to Lake-town for each player that cannot.",
                Shadow = "Shadow: If this attack destroys a character, Smaug engages the next player and makes an immediate attack against that player.",
                CardNumber = 12,
                Artist = Artist.Diego_Gisbert_Llorens
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Catching Fire",
                Id = "51223bd0-ffd1-11df-a976-1801203c9001",
                CardType = CardType.Treachery,
                EncounterSet = "The Battle of Lake-town",
                Quantity = 2,
                Text = "When Revealed: Choose and shuffle 1 Pier location from the victory display back into the encounter deck. If no location was shuffled into the encounter deck by this effect, Catching Fire gains surge",
                Shadow = "Shadow: Defending character gets -2 Defense",
                CardNumber = 13,
                Artist = Artist.Lino_Drieghe
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Reckless in His Rage",
                Id = "51223bd0-ffd1-11df-a976-1801203c9014",
                CardType = CardType.Treachery,
                EncounterSet = "The Battle of Lake-town",
                Quantity = 2,
                Text = "When Revealed: If Smaug is in play, he gets +2 Threat, +2 Attack, -2 Defense and gains the text: 'Allies cannot be declared as defenders'. This effect lasts until the end of the round",
                Shadow = "Shadow: If this attack destroys a character, resolve all burn damage on locations in play.",
                CardNumber = 14,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "West Pier",
                Id = "51223bd0-ffd1-11df-a976-1801203c9027",
                CardType = CardType.Location,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Lake-town.", " Pier." },
                Quantity = 1,
                Text = "Each location in play gains Burn 1.",
                Threat = 2,
                QuestPoints = 2,
                VictoryPoints = 2,
                CardNumber = 15,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "The Master's Manor",
                Id = "51223bd0-ffd1-11df-a976-1801203c9024",
                CardType = CardType.Location,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Lake-town." },
                Quantity = 1,
                Text = "When Revealed: Move all damage from Smaug to Lake-town",
                Shadow = "Shadow: If this attack destroys a character, defending player discards his hand.",
                Keywords = new List<string>() { "Burn 3." },
                Threat = 4,
                QuestPoints = 8,
                VictoryPoints = 8,
                CardNumber = 16,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new LotRCard() {
                
                Title = "South Pier",
                Id = "51223bd0-ffd1-11df-a976-1801203c9019",
                CardType = CardType.Location,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Lake-town.", " Pier." },
                Quantity = 1,
                Text = "When faced with the option to travel, players cannot travel to other locations.",
                Keywords = new List<string>() { "Burn 2." },
                Threat = 1,
                QuestPoints = 4,
                VictoryPoints = 4,
                CardNumber = 17,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "North Pier",
                Id = "51223bd0-ffd1-11df-a976-1801203c9013",
                CardType = CardType.Location,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Lake-town.", " Pier." },
                Quantity = 1,
                Text = "Smaug cannot be damaged.",
                Keywords = new List<string>() { "Burn 2." },
                Threat = 2,
                QuestPoints = 2,
                VictoryPoints = 2,
                CardNumber = 18,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Merchant's District",
                Id = "51223bd0-ffd1-11df-a976-1801203c9012",
                CardType = CardType.Location,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Lake-town." },
                Quantity = 4,
                Text = "Travel Action: Deal 2 damage per player to Lake-town to add this location to the victory display.",
                Shadow = "Shadow: Deal 1 damage to Lake-town (4 damage instead if undefended.)",
                Keywords = new List<string>() { "Burn 1." },
                Threat = 4,
                QuestPoints = 3,
                VictoryPoints = 3,
                CardNumber = 19,
                Artist = Artist.Stu_Barnes
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "East Pier",
                Id = "51223bd0-ffd1-11df-a976-1801203c9004",
                CardType = CardType.Location,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Lake-town.", " Pier." },
                Quantity = 1,
                Text = "'When Revealed' effects cannot be canceled",
                Keywords = new List<string>() { "Burn 1." },
                Threat = 2,
                QuestPoints = 2,
                VictoryPoints = 2,
                CardNumber = 20,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Great House",
                IsUnique = true,
                Id = "51223bd0-ffd1-11df-a976-1801203c9010",
                CardType = CardType.Location,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Lake-town." },
                Quantity = 1,
                Text = "When Revealed: Resolve all burn damage from all locations in play.",
                Keywords = new List<string>() { "Burn 3." },
                Threat = 6,
                QuestPoints = 6,
                VictoryPoints = 6,
                CardNumber = 21,
                Artist = Artist.Titus_Lunter
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Great Bridge",
                IsUnique = true,
                Id = "51223bd0-ffd1-11df-a976-1801203c9009",
                CardType = CardType.Location,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Lake-town." },
                Quantity = 1,
                Text = "When Revealed: Discard X cards from each player's deck. X is the ammount of damage on Lake-town. (If no cards are discarded by this effect, Great Bridge gains surge.)",
                Keywords = new List<string>() { "Burn 2." },
                Threat = 3,
                QuestPoints = 4,
                VictoryPoints = 4,
                CardNumber = 22,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Fisherman's Dock",
                Id = "51223bd0-ffd1-11df-a976-1801203c9008",
                CardType = CardType.Location,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Lake-town." },
                Quantity = 4,
                Text = "Travel: If there is 1 active location exhaust a hero to travel here (There are now 2 active locations)",
                Shadow = "Shadow: Add this location to the staging area.",
                Keywords = new List<string>() { "Burn 1." },
                Threat = 2,
                QuestPoints = 2,
                VictoryPoints = 2,
                CardNumber = 23,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Esgaroth Wharf",
                Id = "51223bd0-ffd1-11df-a976-1801203c9005",
                CardType = CardType.Location,
                EncounterSet = "The Battle of Lake-town",
                Traits = new List<string>() { "Lake-town." },
                Quantity = 4,
                Text = "All locations are immune to player card effects.",
                Shadow = "Shadow: attacking enemy gets +2 Attack. Then it make an additional attack after this one.",
                Keywords = new List<string>() { "Burn 1." },
                Threat = 3,
                QuestPoints = 4,
                VictoryPoints = 4,
                CardNumber = 24,
                Artist = Artist.David_Demaret
            });
        }
    }
}
