using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.Sets
{
    public class TheHobbitOverHillandUnderHill : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Hobbit: Over Hill and Under Hill";
            Abbreviation = "THOHaUH";
            PublicSlug = "ohauh";
            Number = 1001;
            SetType = Models.SetType.Saga_Expansion;
            Cycle = "The Hobbit";

            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "A Deep Sack",
                Id = "51223bd0-ffd1-11df-a976-1801204c9001",
                CardType = CardType.Objective,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Sack." },
                Quantity = 1,
                Text = "When Sacked: Attach to the character (excluding Gandalf) with the highest printed Willpower without a Sack attached.Attached character cannot ready, attack, defend, commit to quests, or trigger effects. If this Sack card is removed, shuffle it into the sack deck.",
                Number = 48,
                Artist = Artist.David_Kegg
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "A Foul Sack",
                Id = "51223bd0-ffd1-11df-a976-1801204c9002",
                CardType = CardType.Objective,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Sack." },
                Quantity = 1,
                Text = "When Sacked: Attach to the character (excluding Gandalf) with the most attachments without a Sack attached.Attached character cannot ready, attack, defend, commit to quests, or trigger effects. If this Sack card is removed, shuffle it into the sack deck.",
                Number = 49,
                Artist = Artist.Diego_Gisbert_Llorens
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "A Large Sack",
                Id = "51223bd0-ffd1-11df-a976-1801204c9003",
                CardType = CardType.Objective,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Sack." },
                Quantity = 1,
                Text = "When Sacked: Attach to the character (excluding Gandalf) with the highest printed hit points without a Sack attached.Attached character cannot ready, attack, defend, commit to quests, or trigger effects. If this Sack card is removed, shuffle it into the sack deck.",
                Number = 47,
                Artist = Artist.Florian_Stitz
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "A Nice Pickle",
                Id = "51223bd0-ffd1-11df-a976-1801204c9004",
                CardType = CardType.Treachery,
                EncounterSet = "We Must Away, Ere Break of Day",
                Quantity = 2,
                Text = "When Revealed: Place the top X cards of the encounter discard pile on the bottom of the encounter deck. X is equal to twice the number of players in the game.",
                Shadow = "Shadow: Shuffle this card into the encounter deck.",
                Keywords = new List<string>() { "Doomed 1." },
                Number = 52,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                ScenarioTitle = "Over the Misty Mountains Grim",
                Title = "A Short Rest",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-1801204c9005",
                CardType = CardType.Quest,
                ScenarioNumber = 2,
                EncounterSet = "Over the Misty Mountains Grim",
                Quantity = 1,
                QuestPoints = 0,
                Setup = "s",
                Text = "Setup: Shuffle the Over the Misty Mountains Grim and Western Lands encounter sets into one encounter deck and make it the active encounter deck. Then, shuffle the The Great Goblin and Misty Mountain Goblins encounter sets into a second encounter deck and set it aside, inactive.",
                FlavorText = "After a refreshing stay in the House of Elrond, Bilbo and his companions resumed their quest for the Lonely Mountain. But to reach Erebor, they first had to climb the high pass over the Misty Mountains.",
                OppositeText = "When Revealed: Each player may search his deck for 1 treasure card and add it to his hand, then shuffle his deck. Advance to stage 2A.",
                Number = 26,
                Artist = Artist.Magali_Villeneuve,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WesternLands }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "A Smelly Sack",
                Id = "51223bd0-ffd1-11df-a976-1801204c9007",
                CardType = CardType.Objective,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Sack." },
                Quantity = 1,
                Text = "When Sacked: Attach to the ally (excluding Gandalf) with the highest printed cost without a Sack attached.Attached character cannot ready, attack, defend, commit to quests, or trigger effects. If this Sack card is removed, shuffle it into the sack deck.",
                Number = 44,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "A Strong Sack",
                Id = "51223bd0-ffd1-11df-a976-1801204c9008",
                CardType = CardType.Objective,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Sack." },
                Quantity = 1,
                Text = "When Sacked: Attach to the character (excluding Gandalf) with the highest printed Attack without a Sack attached.Attached character cannot ready, attack, defend, commit to quests, or trigger effects. If this Sack card is removed, shuffle it into the sack deck.",
                Number = 45,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "A Suspicious Crow",
                Id = "51223bd0-ffd1-11df-a976-1801204c9009",
                CardType = CardType.Enemy,
                EncounterSet = "Western Lands",
                Traits = new List<string>() { "Creature." },
                Quantity = 3,
                EngagementCost = 25,
                Attack = 1,
                Defense = 1,
                HitPoints = 1,
                Text = "When Revealed: Reveal the top card of the encounter discard pile and add it to the staging area, if able.",
                Shadow = "Shadow: If this attack deals at least 1 damage, shuffle this card back into the encounter deck.",
                Threat = 1,
                Number = 35,
                Artist = Artist.Dean_Spencer
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "A Tough Sack",
                Id = "51223bd0-ffd1-11df-a976-1801204c9010",
                CardType = CardType.Objective,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Sack." },
                Quantity = 1,
                Text = "When Sacked: Attach to the character (excluding Gandalf) with the highest printed Defense without a Sack attached.Attached character cannot ready, attack, defend, commit to quests, or trigger effects. If this Sack card is removed, shuffle it into the sack deck.",
                Number = 46,
                Artist = Artist.Ignacio_Bazan_Lazcano
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "A Very Good Tale",
                Id = "51223bd0-ffd1-11df-a976-1801204c9011",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Action: Exhaust 2 allies you control to shuffle your deck and discard the top 5 cards. Put up to 2 allies discarded by this effect into play under your control. The total cost of the allies put into play cannot exceed the total cost of the allies exhausted to pay for this effect.",
                Number = 14,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "A Worn Sack",
                Id = "51223bd0-ffd1-11df-a976-1801204c9012",
                CardType = CardType.Objective,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Sack." },
                Quantity = 1,
                Text = "When Sacked: Attach to hero with the most resources without a Sack attached.Attached character cannot ready, attack, defend, commit to quests, or trigger effects. If this Sack card is removed, shuffle it into the sack deck.",
                Number = 50,
                Artist = Artist.Blake_Henriksen
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "An Unexpected Party",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-1801204c9013",
                CardType = CardType.Quest,
                ScenarioNumber = 1,
                EncounterSet = "We Must Away, Ere Break of Day",
                Quantity = 1,
                QuestPoints = 7,
                Setup = "tttt",
                Text = "Setup: Remove and shuffle the 7 Sack cards into a Sack deck and set it aside face down. Remove the 3 Troll enemies and the ~Troll Cave from the encounter deck and set them aside out of play. Then, shuffle the encounter deck. Each player reveals 1 card from the top of the encounter deck and adds it to the staging area.",
                FlavorText = "The wizard Gandalf has chosen Bilbo Baggins to join Thorin and company on their quest to the Lonley Mountain.",
                OppositeFlavorText = "At first they had passed through hobbit-lands, a wild respectable country inhabited by decent folk, with good roads, an inn or two, and now and then, a dwarf or a farmer ambling by on business. Then they came to lands where people spoke strangely, and sang songs Bilbo had never heard before. - The Hobbit.",
                Number = 23,
                Artist = Artist.Chris_Rahn,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WesternLands }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Beorn",
                Id = "51223bd0-ffd1-11df-a976-1801204c9015",
                CardType = CardType.Hero,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Beorning.", " Warrior." },
                Quantity = 1,
                ThreatCost = 12,
                IsUnique = true,
                Attack = 5,
                Defense = 1,
                Willpower = 0,
                HitPoints = 10,
                Text = "Cannot have attachments. Immune to player card effects.\r\nBeorn does not exhaust to defend.",
                Keywords = new List<string>() { "Sentinel." },
                Number = 5,
                Artist = Artist.Emrah_Elmasli
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Bert",
                Id = "51223bd0-ffd1-11df-a976-1801204c9016",
                CardType = CardType.Enemy,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Troll." },
                Quantity = 1,
                EngagementCost = 23,
                IsUnique = true,
                Attack = 5,
                Defense = 2,
                HitPoints = 10,
                Text = "Players cannot play attachment cards on Troll enemies.\r\nForced: After Bert engages a player, sack 1.\r\nForced: Return Bert to the staging area at the end of the combat phase. The engaged player may raise his threat by 1 to cancel this effect.",
                Threat = 3,
                VictoryPoints = 3,
                Number = 33,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Bilbo Baggins",
                Id = "51223bd0-ffd1-11df-a976-1801204c9017",
                CardType = CardType.Hero,
                Sphere = Sphere.Baggins,
                Traits = new List<string>() { "Hobbit." },
                Quantity = 1,
                ThreatCost = 0,
                IsUnique = true,
                Attack = 1,
                Defense = 1,
                Willpower = 1,
                HitPoints = 3,
                Text = "The first player gains control of Bilbo ~Baggins.\r\nBilbo ~Baggins cannot gain resources from player card effects.\r\nIf Bilbo ~Baggins leaves play, the players lose the game.",
                Number = 1,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Bilbo's Magic Ring",
                Id = "51223bd0-ffd1-11df-a976-1801204c9018",
                CardType = CardType.Objective,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Traits = new List<string>() { "Artifact.", " Ring." },
                Quantity = 1,
                IsUnique = true,
                Text = "Attach to Bilbo ~Baggins.\r\nAction: When answering a riddle, spend 1 Baggins resource to discard an additional player card from the top of your deck.\r\n\r\nAction: Exhaust Bilbo's Magic ~Ring and raise each player's threat by 2 to add 1 Baggins resource to Bilbo ~Baggins' resource pool.",
                Number = 79,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Bofur",
                Id = "51223bd0-ffd1-11df-a976-1801204c9019",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 3,
                ResourceCost = 3,
                IsUnique = true,
                Attack = 2,
                Defense = 0,
                Willpower = 2,
                HitPoints = 3,
                Text = "Action: Exhaust Bofur to search the top 5 cards of your deck for 1 Weapon attachment. Add that card to your hand and shuffle the other cards back into your deck.",
                Number = 8,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Burglar Baggins",
                Id = "51223bd0-ffd1-11df-a976-1801204c9020",
                CardType = CardType.Event,
                Sphere = Sphere.Baggins,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Action: Bilbo ~Baggins gets +2 Willpower, +2 Attack, and +2 Defense until the end of the phase. (You may spend a Baggins resource from Bilbo ~Baggins' resource pool to play this card even if you do not control Bilbo ~Baggins.)",
                Number = 19,
                Artist = Artist.Emrah_Elmasli
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Cave Entrance",
                Id = "51223bd0-ffd1-11df-a976-1801204c9021",
                CardType = CardType.Location,
                EncounterSet = "Western Lands",
                Traits = new List<string>() { "Western Lands." },
                Quantity = 2,
                Text = "While Cave Entrance is in the staging area, it gains: 'Forced: At the end of the round, place the top X cards of the encounter discard pile on the bottom of the encounter deck. X is the number of players in the game.'",
                Threat = 1,
                QuestPoints = 3,
                Number = 41,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Chaos in the Cavern",
                Id = "51223bd0-ffd1-11df-a976-1801204c9022",
                CardType = CardType.Treachery,
                EncounterSet = "The Great Goblin",
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: All engaged enemies return to the staging area. Then, each Goblin enemy gets +1 Threat until the end of the phase.",
                Shadow = "Shadow: attacking enemy is returned to the staging area after its attack resolves.",
                Number = 71,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Come Down Little Bird",
                Id = "51223bd0-ffd1-11df-a976-1801204c9023",
                CardType = CardType.Treachery,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "When Revealed: Starting with the first player, each player must search the encounter deck and encounter discard pile for 1 Creature enemy and put it into play engaged with him. Then, shuffle the encounter deck.Riddle: The first player names a card type and cost, shuffles his deck, then discards the top 3 cards. For each of those cards that matches both items, place 1 progress token on stage 2.",
                Number = 80,
                Artist = Artist.Marco_Caradonna
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Cram",
                Id = "51223bd0-ffd1-11df-a976-1801204c9024",
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Item." },
                Quantity = 3,
                ResourceCost = 0,
                Text = "Attach to a hero.\r\nAction: Discard Cram to ready attached hero.",
                Number = 11,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Dawn Take You All",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-1801204c9025",
                CardType = CardType.Quest,
                ScenarioNumber = 1,
                EncounterSet = "We Must Away, Ere Break of Day",
                Quantity = 1,
                QuestPoints = 0,
                FlavorText = "\"Dawn take you all, and be stone to you!\" said a voice that sounded like William's but it wasn't. For just at that moment the light came over the hill, and there was a mighty twitter in the branches. William never spoke for he stood turned to stone as he stooped; and Bert and Tom were stuck like rocks as they looked at him. -The Hobbit",
                OppositeText =            
@"When Revealed: Remove all Troll enemies and Sack cards from the game. If ~Troll ~Cave is in the victory display, the players have discovered the treasure cards Sting, Glamdring, and Orcrist.

The players have won the game.",
                Number = 25,
                Artist = Artist.Titus_Lunter,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WesternLands }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Dori",
                Id = "51223bd0-ffd1-11df-a976-1801204c9027",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 3,
                ResourceCost = 3,
                IsUnique = true,
                Attack = 2,
                Defense = 1,
                Willpower = 1,
                HitPoints = 3,
                Text = "Response: After a hero is assigned any amount of damage, exhaust Dori to place that damage on Dori instead.",
                Number = 9,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                ScenarioTitle = "Over the Misty Mountains Grim",
                Title = "Down, Down to Goblin Town",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-1801204c9028",
                CardType = CardType.Quest,
                ScenarioNumber = 2,
                EncounterSet = "The Great Goblin",
                Quantity = 1,
                QuestPoints = 20,
                Text = "When Revealed: Shuffle all encounter cards back into the encounter deck and set it aside, inactive. The second encounter deck becomes the active encounter deck. Search the encounter deck for The Great Goblin and add it to the staging area. Then, shuffle the encounter deck.",
                FlavorText = "Out jumped the goblins, big goblins, great ugly-looking goblins, lots of goblins, before you could say rocks and blocks. - The Hobbit",
                OppositeText = "Players cannot defeat this stage unless The Great Goblin is in the victory display.\r\nWhen Revealed: Reveal 3 encounter cards per player, Bilbo ~Baggins may spend X resources to reduce the total number of encounter cards revealed by X. (To a minimum of 1.)\r\nIf the players defeat this stage, they have won the game.",
                Number = 28,
                Artist = Artist.Darek_Zabrocki,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.TheGreatGoblin, EncounterSet.MistyMountainGoblins }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Dreary Hills",
                Id = "51223bd0-ffd1-11df-a976-1801204c9030",
                CardType = CardType.Location,
                EncounterSet = "Western Lands",
                Traits = new List<string>() { "Western Lands." },
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "Forced: After placing 1 or more progress tokens on Dreary ~Hills, each player must discard 1 card at random from his hand.\r\n\r\nResponse: After Dreary ~Hills leaves play as an explored location, Bilbo ~Baggins gains 1 resource.",
                Threat = 3,
                QuestPoints = 2,
                Number = 39,
                Artist = Artist.David_Demaret
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Expecting Mischief",
                Id = "51223bd0-ffd1-11df-a976-1801204c9031",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Play during the quest phase, before the staging step.Action: Deal 2 damage to the first enemy revealed from the encounter deck this phase.",
                Number = 18,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Fili",
                Id = "51223bd0-ffd1-11df-a976-1801204c9032",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 3,
                ResourceCost = 3,
                IsUnique = true,
                Attack = 1,
                Defense = 1,
                Willpower = 1,
                HitPoints = 2,
                Text = "Response: After you play Fili from your hand during the planning phase, search your deck for Kili and put him into play under your control. Then, shuffle your deck.",
                Number = 6,
                Artist = Artist.Carmen_Cianelli
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Foe-hammer",
                Id = "51223bd0-ffd1-11df-a976-1801204c9033",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Response: After a hero you control attacks and destroys an enemy, exhaust a Weapon card attached to that hero to draw 3 cards.",
                Number = 15,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Front Porch",
                Id = "51223bd0-ffd1-11df-a976-1801204c9034",
                CardType = CardType.Location,
                EncounterSet = "The Great Goblin",
                Traits = new List<string>() { "Cave." },
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "While Front Porch is the active location, players cannot attack Goblin enemies.\r\n\r\nAction: The first player may spend 2 Baggins resources to treat Front Porch's printed text box as if it were blank until the end of the round.",
                Threat = 4,
                QuestPoints = 4,
                Number = 66,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Galloping Boulders",
                Id = "51223bd0-ffd1-11df-a976-1801204c9035",
                CardType = CardType.Treachery,
                EncounterSet = "Over the Misty Mountains Grim",
                Quantity = 4,
                EasyModeQuantity = 1,
                Text = "When Revealed: The first player chooses a questing character. That character takes 3 damage and is removed from the quest.",
                Shadow = "Shadow: Put this card on top of the encounter deck.",
                Number = 72,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Gandalf",
                Id = "51223bd0-ffd1-11df-a976-1801204c9036",
                CardType = CardType.Ally,
                Sphere = Sphere.Neutral,
                Traits = new List<string>() { "Istari." },
                Quantity = 3,
                ResourceCost = 5,
                IsUnique = true,
                Attack = 4,
                Defense = 4,
                Willpower = 4,
                HitPoints = 4,
                Text = "Gandalf does not exhaust to commit to a quest.Forced: At the end of the refresh phase, discard Gandalf from play. You may raise your threat by 2 to cancel this effect.",
                Number = 10,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Glamdring",
                Id = "51223bd0-ffd1-11df-a976-1801204c9037",
                CardType = CardType.Treasure,
                Sphere = Sphere.Neutral,
                Traits = new List<string>() { "Artifact.", " Item.", " Weapon." },
                Quantity = 1,
                ResourceCost = 0,
                IsUnique = true,
                Text = "Attach to a hero or Gandalf.\r\nAttached character gets +2 Attack.\r\nResponse: After attached character destroys an Orc enemy, draw 1 card.",
                Keywords = new List<string>() { "Restricted." },
                Number = 22,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Goblin Axeman",
                Id = "51223bd0-ffd1-11df-a976-1801204c9038",
                CardType = CardType.Enemy,
                EncounterSet = "Misty Mountain Goblins",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 3,
                EngagementCost = 25,
                Attack = 1,
                Defense = 2,
                HitPoints = 2,
                Text = "Goblin Axeman gets +1 Attack for each Cave location in play.",
                Shadow = "Shadow: Defending character gets -1 Defense.",
                Threat = 2,
                Number = 58,
                Artist = Artist.Florian_Stitz
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Goblin Bent-Swords",
                Id = "51223bd0-ffd1-11df-a976-1801204c9039",
                CardType = CardType.Enemy,
                EncounterSet = "The Great Goblin",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 4,
                EngagementCost = 33,
                Attack = 3,
                Defense = 2,
                HitPoints = 3,
                Text = "If The Great Goblin is in the victory display, this card gains surge.",
                Shadow = "Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if The Great Goblin is in the victory display.)",
                Threat = 2,
                Number = 62,
                Artist = Artist.Johann_Bodin
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Goblin Driver",
                Id = "51223bd0-ffd1-11df-a976-1801204c9040",
                CardType = CardType.Enemy,
                EncounterSet = "Misty Mountain Goblins",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 3,
                EngagementCost = 30,
                Attack = 2,
                Defense = 2,
                HitPoints = 3,
                Text = "When Revealed: The first player exhausts 1 character he controls.",
                Shadow = "Shadow: Defending player exhausts 1 character he controls.",
                Threat = 3,
                Number = 61,
                Artist = Artist.Stephane_Gantiez
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Goblin Miners",
                Id = "51223bd0-ffd1-11df-a976-1801204c9041",
                CardType = CardType.Enemy,
                EncounterSet = "Misty Mountain Goblins",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 3,
                EngagementCost = 25,
                Attack = 2,
                Defense = 0,
                HitPoints = 2,
                Text = "Goblin Miners gets +1 Defense for each Cave location in play.",
                Shadow = "Shadow: attacking enemy gets +1 Attack.",
                Threat = 2,
                Number = 59,
                Artist = Artist.C_B_Sorge
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Goblin Runners",
                Id = "51223bd0-ffd1-11df-a976-1801204c9042",
                CardType = CardType.Enemy,
                EncounterSet = "Misty Mountain Goblins",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 3,
                EasyModeQuantity = 1,
                EngagementCost = 20,
                Attack = 3,
                Defense = 1,
                HitPoints = 2,
                Text = string.Empty,
                Shadow = "Shadow: attacking enemy makes an additional attack immediately after this one. (Deal a new shadow card for that attack.)",
                Keywords = new List<string>() { "Surge." },
                Threat = 1,
                Number = 60,
                Artist = Artist.Stephane_Gantiez
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Goblin-cleaver",
                Id = "51223bd0-ffd1-11df-a976-1801204c9043",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Combat Action: Exhaust a Weapon card attached to a hero you control to choose an enemy engaged with you. Deal 2 damage to that enemy. (Deal 3 damage instead if the enemy is an Orc.)",
                FlavorText = "At this point Gandalf fell behind, and Thorin with him. They turned a sharp corner. \"About turn!\" he shouted. \"Draw your sword, Thorin!\" - The Hobbit",
                Number = 16,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Gollum",
                Id = "51223bd0-ffd1-11df-a976-1801204c9044",
                CardType = CardType.Enemy,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Traits = new List<string>() { "Gollum." },
                Quantity = 1,
                EngagementCost = 50,
                IsUnique = true,
                Attack = 2,
                Defense = 3,
                HitPoints = 5,
                Text = "Forced: After the first player answers a riddle and fails to find at least 1 match, ~Gollum attacks Bilbo ~Baggins. (Do not deal a shadow card for this attack.)",
                FlavorText = "\"If precious asks, and it doesn't answer, we eats it, my precious.\" - Gollum, The Hobbit",
                Threat = 0,
                Number = 74,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Great Cavern Room",
                Id = "51223bd0-ffd1-11df-a976-1801204c9045",
                CardType = CardType.Location,
                EncounterSet = "The Great Goblin",
                Traits = new List<string>() { "Cave." },
                Quantity = 3,
                Text = "While Great Cavern Room is the active location, it gains: 'Forced: After a player engages a Goblin enemy, he must deal 1 damage to a character he controls.'Forced: When faced with the option to travel, if The Great Goblin is in the victory display the players must travel to Great Cavern Room if able.",
                Threat = 2,
                QuestPoints = 3,
                Number = 67,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Great Gray Wolf",
                Id = "51223bd0-ffd1-11df-a976-1801204c9046",
                CardType = CardType.Enemy,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Traits = new List<string>() { "Creature." },
                Quantity = 1,
                EasyModeQuantity = 0,
                EngagementCost = 30,
                Attack = 5,
                Defense = 2,
                HitPoints = 5,
                Text = "Forced: If Great Gray ~Wolf is dealt a shadow card with a riddle, return all Creature enemies to the staging area at the end of the combat phase.\r\nRiddle: The first player names a card type, sphere and cost, shuffles his deck, then discards the top 3 cards. For each of those cards that matches all three items, place 1 progress token on stage 2.",
                Threat = 4,
                Number = 75,
                Artist = Artist.Allison_Theus
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Grip, Grab! Pinch, Nab!",
                Id = "51223bd0-ffd1-11df-a976-1801204c9047",
                CardType = CardType.Treachery,
                EncounterSet = "Misty Mountain Goblins",
                Quantity = 3,
                EasyModeQuantity = 0,
                Text = "When Revealed: Starting with the first player, each player must choose 1 Goblin enemy from the discard pile and add it to the staging area.",
                Shadow = "Shadow: Defending player deals damage among characters he controls equal to the number of Goblin enemies engaged with him.",
                Number = 70,
                Artist = Artist.Blake_Henriksen
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Guffawing of Giants",
                Id = "51223bd0-ffd1-11df-a976-1801204c9048",
                CardType = CardType.Treachery,
                EncounterSet = "Over the Misty Mountains Grim",
                Quantity = 2,
                Text = "When Revealed: The first player chooses 1 Stone-giant in the staging area. At the end of the quest phase, that Stone-giant engages the player with the highest threat. If there are no Stone-giant cards in the staging area, search the encounter deck for 1 Stone-giant and add it to the staging area.",
                Number = 73,
                Artist = Artist.Chun_Lo
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Hiding in the Trees",
                Id = "51223bd0-ffd1-11df-a976-1801204c9049",
                CardType = CardType.Treachery,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "When Revealed: Characters get -1 Willpower and cannot attack until the end of the round.Riddle: The first player names a card type and sphere, shuffles his deck, then discards the top 3 cards. For each of those cards that matches both items, place 1 progress token on stage 2.",
                Number = 82,
                Artist = Artist.David_Demaret
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Hobbit-lands",
                Id = "51223bd0-ffd1-11df-a976-1801204c9050",
                CardType = CardType.Location,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Western Lands." },
                Quantity = 2,
                Text = "Response: After placing 1 or more progress tokens on Hobbit-lands, the first player draws 1 card.",
                Shadow = "Shadow: Defending player must put the top card of the encounter deck discard pile on top of the encounter deck.",
                Threat = 1,
                QuestPoints = 1,
                Number = 38,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Hungry Troll",
                Id = "51223bd0-ffd1-11df-a976-1801204c9051",
                CardType = CardType.Treachery,
                EncounterSet = "We Must Away, Ere Break of Day",
                Quantity = 3,
                EasyModeQuantity = 0,
                Text = "When Revealed: The first player chooses a Troll enemy in the staging area and engages that enemy. If there are no Troll enemies in the staging area, this card gains Surge.",
                Shadow = "Shadow: Deal 4 damage to each character with a Sack card attached. (The first player may spend 2 Baggins resources to cancel this effect.)",
                Number = 54,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Into the Fire",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-1801204c9052",
                CardType = CardType.Quest,
                ScenarioNumber = 3,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Quantity = 1,
                QuestPoints = 16,
                FlavorText = "To everyone's surprise, Bilbo Baggins rejoined his companions on the eastern side of the Misty Mountains. However, their celebration was cut short by the chilling sound of wolves howling close by. To the frightened hobbit, it seemed that they had escaped from the goblins only to be eaten by wargs.",
                OppositeText = "When Revealed: The first player gains control of Bilbo Baggins. Reveal 1 encounter card per player and add it to the staging area.\r\nGollum engages the first player. Damage from undefended attacks made by Gollum must be placed on Bilbo ~Baggins.\r\nAll riddle effects are ignored. Treachery cards gain surge.\r\nIf players defeat this stage, they have won the game.",
                Number = 31,
                Artist = Artist.Adam_Schumpert,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountainGoblins }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "It Likes Riddles?",
                Id = "51223bd0-ffd1-11df-a976-1801204c9054",
                CardType = CardType.Treachery,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Quantity = 3,
                Text = "When Revealed: The first player must choose to answer the riddle on this card. If he finds at least 1 match, discard cards from the encounter deck until another card with a riddle is discarded. Then, answer that riddle.Riddle: The first player names a cost, shuffles his deck, then discards the top 2 cards. For each of those cards that matches, place 1 progress token on stage 2.",
                Number = 81,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Kili",
                Id = "51223bd0-ffd1-11df-a976-1801204c9055",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 3,
                ResourceCost = 3,
                IsUnique = true,
                Attack = 1,
                Defense = 1,
                Willpower = 1,
                HitPoints = 2,
                Text = "Response: After you play Kili from your hand during the planning phase, search your deck for Fili and put him into play under your control. Then, shuffle your deck.",
                Number = 7,
                Artist = Artist.Carmen_Cianelli
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Lake in the Cavern",
                Id = "51223bd0-ffd1-11df-a976-1801204c9056",
                CardType = CardType.Location,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Traits = new List<string>() { "Cave." },
                Quantity = 1,
                IsUnique = true,
                Text = 
@"X is twice the number of players in the game.

Players cannot travel here.

Immune to player card effects.

Forced: After players advance to stage 3, remove Lake in the Cavern from the game.",
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = byte.MaxValue,
                Number = 78,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Late Adventurer",
                Id = "51223bd0-ffd1-11df-a976-1801204c9057",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Quest Action: Exhaust a character you control that is not committed to the quest to commit that character to the quest.",
                FlavorText = "To the end of his days Bilbo could never remember how he found himself outside, without a hat, walking-stick or any money, or anything that he usually took when he went out. -The Hobbit",
                Number = 17,
                Artist = Artist.Carmen_Cianelli
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Lone-Lands",
                Id = "51223bd0-ffd1-11df-a976-1801204c9058",
                CardType = CardType.Location,
                EncounterSet = "Western Lands",
                Traits = new List<string>() { "Western Lands." },
                Quantity = 2,
                Text = "Forced: After placing 1 or more progress tokens on Lone-Lands, each player removes 1 resource from one of his hero's resource pools, if able.\r\n\r\nResponse: After Lone-Lands leaves play as an explored location, Bilbo ~Baggins gains 1 resource.",
                Threat = 2,
                QuestPoints = 3,
                Number = 40,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Lots or None at All",
                Id = "51223bd0-ffd1-11df-a976-1801204c9059",
                CardType = CardType.Treachery,
                EncounterSet = "We Must Away, Ere Break of Day",
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "When Revealed: If there is a Troll enemy in the staging area, Sack 1. If there are no Troll enemies in the staging area, this card gains Doomed 2.",
                Shadow = "Shadow: If the attacking enemy is a Troll, Sack 1. (The first player may spend 1 Baggins resource to cancel this effect.)",
                Number = 51,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "More Like a Grocer",
                Id = "51223bd0-ffd1-11df-a976-1801204c9060",
                CardType = CardType.Treachery,
                EncounterSet = "Western Lands",
                Quantity = 1,
                Text = "When Revealed: Discard all Baggins resources.",
                FlavorText = "\"As soon as I clapped eyes on the little fellow bobbing and puffing on the mat, I had my doubts. He looks more like a grocer than a burglar!\" -Glóin The Hobbit",
                Shadow = "Shadow: Resolve this card's 'When Revealed' effect.",
                Number = 57,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "No Campfire",
                Id = "51223bd0-ffd1-11df-a976-1801204c9061",
                CardType = CardType.Treachery,
                EncounterSet = "Western Lands",
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Each player must choose one: increase his threat by 4, or reveal an additional encounter card from the encounter deck and add it to the staging area.",
                Shadow = "Shadow: The defending player raises his threat by 2.",
                Keywords = new List<string>() { "Doomed 1." },
                Number = 55,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Nori",
                Id = "51223bd0-ffd1-11df-a976-1801204c9062",
                CardType = CardType.Hero,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 1,
                ThreatCost = 9,
                IsUnique = true,
                Attack = 1,
                Defense = 2,
                Willpower = 2,
                HitPoints = 4,
                Text = "Response: After you play a Dwarf character from your hand, reduce your threat by 1.",
                FlavorText = "\"Nori, at your service.\" -Nori, The Hobbit",
                Number = 3,
                Artist = Artist.Blake_Henriksen,
                HasErrata = true
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Not Fair! Not Fair!",
                Id = "51223bd0-ffd1-11df-a976-1801204c9063",
                CardType = CardType.Treachery,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Quantity = 1,
                Text = "When Revealed: The first player names a card type and then discards the top 3 cards of the encounter deck. For each of those cards that does not match the named type, remove 1 progress token from stage 2. This effect cannot be canceled.",
                Number = 84,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Orcrist",
                Id = "51223bd0-ffd1-11df-a976-1801204c9064",
                CardType = CardType.Treasure,
                Sphere = Sphere.Neutral,
                Traits = new List<string>() { "Artifact.", " Item.", " Weapon." },
                Quantity = 1,
                ResourceCost = 0,
                IsUnique = true,
                Text = "Attach to a hero.\r\nAttached character gets +2 Attack.Response: After attached hero destroys an Orc enemy, add 1 resource to that hero's resource pool.",
                FlavorText = "\"This, Thorin, the runes name Orcrist, the Goblin-cleaver in the ancient tongue of Gondolin; it was a famous blade.\" -Elrond, The Hobbit",
                Keywords = new List<string>() { "Restricted." },
                Number = 21,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Ori",
                Id = "51223bd0-ffd1-11df-a976-1801204c9065",
                CardType = CardType.Hero,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 1,
                ThreatCost = 8,
                IsUnique = true,
                Attack = 2,
                Defense = 1,
                Willpower = 2,
                HitPoints = 3,
                Text = "If you control at least 5 Dwarf characters, draw 1 additional card at the beginning of the resource phase.",
                FlavorText = "\"He could write well and speedily, and often used the Elvish characters.\" -Gimli, The Fellowship of the Ring",
                Number = 4,
                Artist = Artist.Blake_Henriksen
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Out of the Frying Pan",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-1801204c9066",
                CardType = CardType.Quest,
                ScenarioNumber = 3,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Quantity = 1,
                QuestPoints = 14,
                Setup = "stt",
                Text = "Setup: Add Lake in the Cavern to the staging area. Create a riddle area with stage 2A and follow the setup instructions on that card.",
                FlavorText = "After killing the Great Goblin, Bilbo's companions fought to win their escape from the goblins. By the time they realized that Bilbo had been lost in the darkness, it was too late to turn back and search for him.",
                OppositeText = "Players cannot advance to stage 3A unless both 1B and 2B are complete.\r\nForced: Reveal 1 additional encounter card per player during the staging step.",
                Number = 29,
                Artist = Artist.Adam_Schumpert,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountainGoblins }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Overhanging Rock",
                Id = "51223bd0-ffd1-11df-a976-1801204c9068",
                CardType = CardType.Location,
                EncounterSet = "Over the Misty Mountains Grim",
                Traits = new List<string>() { "Mountain." },
                Quantity = 2,
                Text = "While Overhanging Rock is the active location, it gains: \"Action: Spend 1 Baggins resource to look at the top 2 cards of your deck. Add 1 of those to your hand and discard the other.\"",
                FlavorText = "\"This won't do at all!\" said Thorin. \"If we don't get blown off or drowned, or struck by lightning, we shall be picked up by some giant and kicked sky-high for a football.\" -Thorin Oakenshield, The Hobbit",
                Threat = 2,
                QuestPoints = 3,
                Number = 68,
                Artist = Artist.Helmutt
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Riddles in the Dark",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-1801204c9069",
                CardType = CardType.Quest,
                ScenarioNumber = 3,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Quantity = 1,
                QuestPoints = 9,
                Text = "Setup: Search the encounter deck for Gollum and Bilbo's Magic Ring. Place Gollum and Bilbo ~Baggins in the riddle area and attach Bilbo's Magic Ring to Bilbo ~Baggins. Then, shuffle the encounter deck.",
                FlavorText = "During the confusion, bilbo stumbled won a tunnel and into Gollum's cave. There the Hobbit had to outwit the creature Gollum in a dangerous riddle contest to discover the way out.",
                OppositeText = "Players cannot advance to stage 3A unless both 1B and 2B are complete.\r\nProgress tokens cannot be added to, or removed from, this quest except by answering riddles.\r\nCards in the riddle area are immune to player card effects and cannot leave the riddle area except by quest effects.",
                Number = 30,
                Artist = Artist.Magali_Villeneuve,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountainGoblins }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Roast 'Em or Boil 'Em?",
                Id = "51223bd0-ffd1-11df-a976-1801204c9071",
                CardType = CardType.Treachery,
                EncounterSet = "We Must Away, Ere Break of Day",
                Quantity = 3,
                EasyModeQuantity = 2,
                Text = "When Revealed: Deal 1 damage to each ally. (2 damage instead if there is a Troll enemy in the staging area.)",
                Shadow = "Shadow: Search the encounter deck for ~Troll Camp and add it to the staging area. Then, shuffle the encounter deck.",
                Number = 53,
                Artist = Artist.Chun_Lo
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Roast Mutton",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-1801204c9072",
                CardType = CardType.Quest,
                ScenarioNumber = 1,
                EncounterSet = "We Must Away, Ere Break of Day",
                Quantity = 1,
                QuestPoints = 1,
                Text = "When Revealed: Add the set-aside Troll enemies and the ~Troll Cave to the staging area. Shuffle the encounter discard pile back into the encounter deck.",
                FlavorText = "Obviously trolls. Even Bilbo, in spite of his sheltered life, could see that: from the great heavy faces of them, and their size, and the shape of their legs, not to mention their language, which was not drawing-room fashion at all - The Hobbit",
                OppositeText = "Forced: If there are no Troll enemies left in play, or if there are no cards left in the encounter deck, advance it to the next stage.\r\nAny time players would place progress tokens on this quest, discard an equal number of cards from the encounter deck instead. (Progress is placed on the active location before triggering this effect.)",
                Number = 24,
                Artist = Artist.Darek_Zabrocki,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WesternLands }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Spare Hood and Cloak",
                Id = "51223bd0-ffd1-11df-a976-1801204c9074",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Item." },
                Quantity = 3,
                ResourceCost = 0,
                Text = "Attach to a character.\r\nAction: Exhaust Spare Hood and Cloak and exhaust attached character to ready another character. Then, attach Spare Hood and Cloak to that character.",
                FlavorText = "\"You will have to manage without pocket-handkerchiefs, and a good many other things, before you get to the journey's end. As for a hat, I have got a spare hood and cloak in my luggage.\" -Dwalin, The Hobbit",
                Number = 12,
                Artist = Artist.David_Kegg
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Sting",
                Id = "51223bd0-ffd1-11df-a976-1801204c9075",
                CardType = CardType.Treasure,
                Sphere = Sphere.Neutral,
                Traits = new List<string>() { "Artifact.", " Item.", " Weapon." },
                Quantity = 1,
                ResourceCost = 0,
                IsUnique = true,
                Text = "Attach to Bilbo ~Baggins.\r\nBilbo ~Baggins gets +1 Willpower, +1 Attack, and +1 Defense.\r\n\r\nResponse: After Bilbo ~Baggins exhausts to defend, discard the top card of the encounter deck. Deal damage to the attacking enemy equal to the discarded card's Threat.",
                FlavorText = "\"I shall call you Sting.\" -Bilbo, The Hobbit",
                Keywords = new List<string>() { "Restricted." },
                Number = 20,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Stone-Giant",
                Id = "51223bd0-ffd1-11df-a976-1801204c9076",
                CardType = CardType.Enemy,
                EncounterSet = "Over the Misty Mountains Grim",
                Traits = new List<string>() { "Giant." },
                Quantity = 3,
                EasyModeQuantity = 1,
                EngagementCost = 40,
                Attack = 6,
                Defense = 3,
                HitPoints = 9,
                Text = "While at least one Stone-Giant is in the staging area, the Galloping Boulders card gains surge.\r\n\r\nForced: After Stone-Giant engages a player, that player chooses and discards 1 ally he controls.",
                Threat = 4,
                Number = 64,
                Artist = Artist.Timo_Karhula
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "The Goblins' Caves",
                Id = "51223bd0-ffd1-11df-a976-1801204c9077",
                CardType = CardType.Location,
                EncounterSet = "Misty Mountain Goblins",
                Traits = new List<string>() { "Cave." },
                Quantity = 3,
                EasyModeQuantity = 2,
                Text = "While The Goblins' Caves is the active location, Goblin enemies get +1 Threat.",
                Shadow = "Shadow: Defending player raises his threat by X. X is the number of Goblin enemies engaged with him.",
                Threat = 3,
                QuestPoints = 3,
                Number = 65,
                Artist = Artist.David_Demaret
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "The Great Goblin",
                Id = "51223bd0-ffd1-11df-a976-1801204c9078",
                CardType = CardType.Enemy,
                EncounterSet = "The Great Goblin",
                SlugIncludesType = true,
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 1,
                EngagementCost = 15,
                IsUnique = true,
                Attack = 5,
                Defense = 2,
                HitPoints = 8,
                Text = "Forced: After The Great Goblin attacks, discard X cards from the encounter deck where X is the number of players in the game. Add each Goblin enemy discarded by this effect to the staging area.",
                Threat = 3,
                VictoryPoints = 3,
                Number = 63,
                Artist = Artist.Johann_Bodin
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "The High Pass",
                Id = "51223bd0-ffd1-11df-a976-1801204c9079",
                CardType = CardType.Location,
                EncounterSet = "Over the Misty Mountains Grim",
                Traits = new List<string>() { "Mountain." },
                Quantity = 1,
                IsUnique = true,
                Text = "X is the number of players in the game.\r\n\r\nForced: At the end of the round, remove X progress tokens from the current quest.",
                FlavorText = "There were many paths that led up into those mountains, and many passes over them. But most of the paths were cheats and deceptions and led nowhere or to bad ends. -The Hobbit",
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = 5,
                Number = 69,
                Artist = Artist.Titus_Lunter
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                ScenarioTitle = "Over the Misty Mountains Grim",
                Title = "The Mountain Pass",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-1801204c9080",
                CardType = CardType.Quest,
                ScenarioNumber = 2,
                EncounterSet = "Over the Misty Mountains Grim",
                Quantity = 1,
                QuestPoints = 16,
                FlavorText = "When he peeped out in the lightning-flashes, he saw that across the valley the stone-giants were out and were hurling rocks at one another for a game, and catching them, and tossing them down into the darkness where they smashed the trees far below, or splintered into little bits with a bang. - The Hobbit ",
                OppositeText = "When Revealed: Search the encounter deck for 1 copy of Stone-giant and add it to the staging area. Then, shuffle the encounter deck. Reveal 1 card per player from the encounter deck and add it to the staging area.",
                Number = 27,
                Artist = Artist.Chun_Lo,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WesternLands }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "The Wargs' Glade",
                Id = "51223bd0-ffd1-11df-a976-1801204c9082",
                CardType = CardType.Location,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Traits = new List<string>() { "Forest." },
                Quantity = 3,
                Text = "Forced: After a character takes damage from an attack made by a Creature enemy, remove 1 progress from the current quest.Riddle: The first player names a sphere, shuffles his deck, and discards the top card. For each of those cards that matches, place 1 progress token on stage 2.",
                Threat = 2,
                QuestPoints = 4,
                Number = 77,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Thorin Oakenshield",
                Id = "51223bd0-ffd1-11df-a976-1801204c9083",
                CardType = CardType.Hero,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Dwarf.", " Noble.", " Warrior." },
                Quantity = 1,
                ThreatCost = 12,
                IsUnique = true,
                Attack = 3,
                Defense = 1,
                Willpower = 3,
                HitPoints = 5,
                Text = "If you control at least 5 Dwarf characters, add 1 additional resource to Thorin Oakenshield's pool when you collect resources during the resource phase.",
                Number = 2,
                Artist = Artist.Tiziano_Baracchi
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Thror's Map",
                Id = "51223bd0-ffd1-11df-a976-1801204c9084",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Artifact.", " Item." },
                Quantity = 3,
                ResourceCost = 1,
                IsUnique = true,
                Text = "Attach to a hero.\r\nTravel Action: Exhaust Thror's Map to choose a location in the staging area. Make that location the active location. (If there is another active location, return it to the staging area.)",
                FlavorText = "\"This was made by Thror, your grandfather, Thorin.\" he said in answer to the dwarves' excited questions. \"It is a plan of the Mountain.\" -Gandalf, The Hobbit",
                Number = 13,
                Artist = Artist.Jake_Murray,
                HasErrata = true
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Tom",
                Id = "51223bd0-ffd1-11df-a976-1801204c9085",
                CardType = CardType.Enemy,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Troll." },
                Quantity = 1,
                EngagementCost = 33,
                IsUnique = true,
                Attack = 5,
                Defense = 2,
                HitPoints = 11,
                Text = "Troll enemies can only be attacked by one character at a time.\r\nForced: After Tom engages a player, sack 1.\r\nForced: Return Tom to the staging area at the end of the combat phase. The engaged player may raise his threat by 1 to cancel this effect.",
                Threat = 3,
                VictoryPoints = 4,
                Number = 34,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Troll Camp",
                Id = "51223bd0-ffd1-11df-a976-1801204c9086",
                CardType = CardType.Location,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Forest.", " Trollshaws." },
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "While ~Troll Camp is in the staging area, Troll enemies get +1 Threat for each player in the game.\r\n\r\nWhile ~Troll Camp is in play, Bilbo ~Baggins gains: \"Action: Exhaust Bilbo ~Baggins and spend 1 Baggins resource to remove 1 Sack card from a character. Bilbo ~Baggins may trigger this effect even with a Sack card attached to him.\"",
                Threat = 3,
                QuestPoints = 3,
                Number = 36,
                Artist = Artist.Stephane_Gantiez
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Troll Cave",
                Id = "51223bd0-ffd1-11df-a976-1801204c9087",
                CardType = CardType.Location,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Cave.", " Trollshaws." },
                Quantity = 1,
                Text = "Immune to player card effects.\r\nPlayers cannot travel to ~Troll Cave unless Bilbo ~Baggins has the ~Troll Key attached and the first player spends 5 Baggins resources. (2 Baggins resources instead if Bilbo ~Baggins has the ~Troll Purse attached.)",
                Threat = 2,
                QuestPoints = 4,
                VictoryPoints = 2,
                Number = 37,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Troll Key",
                Id = "51223bd0-ffd1-11df-a976-1801204c9088",
                CardType = CardType.Objective,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Item." },
                Quantity = 1,
                IsUnique = true,
                Text = "If ~Troll Key is discarded, add it to the staging area.If ~Troll Key is unattached and in the staging area, attach it to a Troll enemy, if able.Response: After attached Troll enemy takes damage as the result of an attack, the first player may exhaust Bilbo ~Baggins to claim this objective and attach it to him.",
                Number = 43,
                Artist = Artist.Trudi_Castle,
                HasErrata = true
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Troll Purse",
                Id = "51223bd0-ffd1-11df-a976-1801204c9089",
                CardType = CardType.Objective,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Item." },
                Quantity = 1,
                IsUnique = true,
                Text = "If ~Troll Purse is discarded, add it to the staging area.\r\n\r\nIf ~Troll Purse is unattached and in the staging area, attach it to a Troll enemy, if able.\r\n\r\nResponse: After attached Troll enemy is destroyed, the first player may spend 1 Baggins resource to claim this objective and attach it to Bilbo ~Baggins.",
                Number = 42,
                Artist = Artist.Blake_Henriksen,
                HasErrata = true
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "What's In My Pocket?",
                Id = "51223bd0-ffd1-11df-a976-1801204c9090",
                CardType = CardType.Treachery,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Quantity = 2,
                Text = "When Revealed: The first player must choose to answer the riddle on this card. This effect cannot be canceled.Riddle: The first player names a sphere and cost, shuffles his deck, then discards the top 2 cards. For each of those cards that matches both items, place 1 progress token on stage 2.",
                Number = 83,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Wild Wargs",
                Id = "51223bd0-ffd1-11df-a976-1801204c9091",
                CardType = CardType.Enemy,
                EncounterSet = "Dungeons Deep and Caverns Dim",
                Traits = new List<string>() { "Creature." },
                Quantity = 4,
                EngagementCost = 25,
                Attack = 3,
                Defense = 2,
                HitPoints = 3,
                Text = "Forced: If Wild Wargs is dealt a shadow card with a riddle, it gets +2 Attack.Riddle: The first player names a card type, shuffles his deck, and discards the top 2 cards. For each of those cards that matches, place 1 progress token on stage 2.",
                Threat = 3,
                Number = 76,
                Artist = Artist.Piya_Wannachaiwong
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "William",
                Id = "51223bd0-ffd1-11df-a976-1801204c9092",
                CardType = CardType.Enemy,
                EncounterSet = "We Must Away, Ere Break of Day",
                Traits = new List<string>() { "Troll." },
                Quantity = 1,
                EngagementCost = 38,
                IsUnique = true,
                Attack = 5,
                Defense = 2,
                HitPoints = 12,
                Text = "Troll enemies not engaged with a player cannot take damage.\r\nForced: After William engages a player, sack 2.\r\nForced: Return William to the staging area at the end of the combat phase. The engaged player may raise his threat by 1 to cancel this effect.",
                Threat = 3,
                VictoryPoints = 5,
                Number = 32,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Wind-whipped Rain",
                Id = "51223bd0-ffd1-11df-a976-1801204c9093",
                CardType = CardType.Treachery,
                EncounterSet = "Western Lands",
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "When Revealed: Discard all non-treasure, non-objective attachments in play.",
                Shadow = "Shadow: The defending character gets -1 Defense.",
                Number = 56,
                Artist = Artist.Blake_Henriksen
            });
        }
    }
}
