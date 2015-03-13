using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.Sets
{
    public class ReturntoMirkwood : CardSet
    {
        protected override void Initialize()
        {
            Name = "Return to Mirkwood";
            Abbreviation = "RtM";
            Number = 7;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Shadows of Mirkwood";

            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Ambush",
                StageNumber = 4,
                Id = "51223bd0-ffd1-11df-a976-0801206c9001",
                CardType = CardType.Quest,
                QuestPoints = 2,
                FlavorText = "As you make the final push to Thranduil's Palace, your enemies make a desperate attempt to ambush your party, and seize Gollum for themselves.",
                OppositeText =
@"Forced: At the beginning of the combat phase, all enemies in play enage the player guarding ~Gollum.

Player cannot defeat this stage if there are any enemies in play. If players defeat this stahe, they have won the game.",
                Quantity = 1,
                EncounterSet = "Return to Mirkwood",
                Number = 129,
                Artist = Artist.John_Gravato,
                SecondArtist = Artist.Dimitri_Bielak,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.SpidersOfMirkwood, EncounterSet.Wilderlands }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Astonishing Speed",
                Id = "51223bd0-ffd1-11df-a976-0801206c9003",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                Quantity = 3,
                ResourceCost = 3,
                Text = "Action: Until the end of the phase, all Rohan characters get +2 Willpower.",
                FlavorText = "With astonishing speed and skill they checked their steeds, wheeled, and came charging round. -The Two Towers",
                Number = 122,
                Artist = Artist.Anna_Christenson
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Attercop, Attercop",
                Id = "51223bd0-ffd1-11df-a976-0801206c9004",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Creature.", " Spider." },
                Quantity = 3,
                EasyModeQuantity = 0,
                EngagementCost = 44,
                Attack = 8,
                Defense = 4,
                HitPoints = 6,
                Text = "Forced: At the beginning of the encounter phase, Attercop, Attercop automatically engages the player guarding ~Gollum, regardless of his threat.",
                FlavorText = "\"Attercop! Attercop! Won't you stop...\" -Bilbo Baggins, The Hobbit",
                Threat = 2,
                EncounterSet = "Return to Mirkwood",
                Number = 139,
                Artist = Artist.Aaron_B_Miller
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Dain Ironfoot",
                Id = "51223bd0-ffd1-11df-a976-0801206c9005",
                CardType = CardType.Hero,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 1,
                ThreatCost = 11,
                IsUnique = true,
                Attack = 2,
                Defense = 3,
                Willpower = 1,
                HitPoints = 5,
                Text = "While Dain Ironfoot is ready, Dwarf characters get +1 Attack and +1 Willpower.",
                FlavorText = "\"You have not heard of Dain and the dwarves of the Iron Hills?\" -Bilbo Baggins, The Hobbit",
                Number = 116,
                Artist = Artist.Tiziano_Baracchi
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Dawn Take You All",
                Id = "51223bd0-ffd1-11df-a976-0801206c9006",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 2,
                Text = "Play after shadow cards have been dealt, before any attacks have resolved.Combat Action: Each player may choose and discard 1 facedown shadow card from an enemy with which he is engaged.",
                FlavorText = "\"Dawn take you all, and be stone to you!\" -Gandalf, The Hobbit",
                Number = 118,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Dry Watercourse",
                Id = "51223bd0-ffd1-11df-a976-0801206c9007",
                CardType = CardType.Location,
                Traits = new List<string>() { "Forest." },
                Quantity = 3,
                Text = "While Dry Watercourse is the active location, all treachery card effects that target the player guarding ~Gollum also target each other player.",
                Threat = 2,
                QuestPoints = 2,
                EncounterSet = "Return to Mirkwood",
                Number = 132,
                Artist = Artist.Bill_Corbett
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Dúnedain Signal",
                NormalizedTitle = "Dunedain Signal",
                Id = "51223bd0-ffd1-11df-a976-0801206c9008",
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Signal." },
                Quantity = 3,
                ResourceCost = 1,
                Text = "Attach to a hero. Attached hero gains sentinel.\r\nAction: Pay 1 resource from attached hero's pool to attach Dunedain Signal to another hero.",
                Number = 117,
                Artist = Artist.Ijur
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Eagles of the Misty Mountains",
                Id = "51223bd0-ffd1-11df-a976-0801206c9009",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Creature.", " Eagle." },
                Quantity = 3,
                ResourceCost = 4,
                Attack = 2,
                Defense = 2,
                Willpower = 2,
                HitPoints = 4,
                Text = "Eagles of the Misty Mountains cannot have restricted attachments. Eagles of the Misty Mountains gets +1 Attack and +1 Defense for each facedown attachment it has.Response: After another Eagle character leaves play, you may attach that card facedown to Eagles of the Misty Mountains.",
                Number = 119,
                Artist = Artist.Sandara_Tang
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Escape Attempt",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-0801206c9010",
                CardType = CardType.Quest,
                QuestPoints = 3,
                Quantity = 1,
                FlavorText = "As soon as he thinks that no one is watching, Gollum attempts to slip his bonds and escape.",
                OppositeText = 
@"The player guarding ~Gollum cannot commit characters to this quest (unless he is the only player in the game).

If the players quest unsuccessfully, Gollum escapes and the players have lost the game.",
                EncounterSet = "Return to Mirkwood",
                Number = 127,
                Artist = Artist.Tom_Garden,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.SpidersOfMirkwood, EncounterSet.Wilderlands }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Gollum",
                Id = "51223bd0-ffd1-11df-a976-0801206c9012",
                CardType = CardType.Objective_Ally,
                Traits = new List<string>() { "Creature." },
                Quantity = 1,
                IsUnique = true,
                Attack = byte.MaxValue,
                Defense = byte.MaxValue,
                Willpower = byte.MaxValue,
                HitPoints = 5,
                Text = 
@"Damage from undefended attacks against you must be dealt to Gollum. If Gollum is destroyed, or if the player guarding ~Gollum is eliminated, the players have lost the game.
                
Forced: At the end of each round, raise the threat of the player guarding ~Gollum by 3. Then, that player may choose a new player to guard ~Gollum.",
                EncounterSet = "Return to Mirkwood",
                Number = 130,
                Artist = Artist.Tiziano_Baracchi
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Gollum's Anguish",
                Id = "51223bd0-ffd1-11df-a976-0801206c9013",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Tantrum." },
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "When Revealed: Raise the threat of the player guarding ~Gollum by 8. That player must choose a new player to guard Gollum, if able.",
                Shadow = "Shadow: Raise the threat of the player guarding ~Gollum by 4.",
                EncounterSet = "Return to Mirkwood",
                Number = 135,
                Artist = Artist.Tom_Garden
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Gollum's Bite",
                Id = "51223bd0-ffd1-11df-a976-0801206c9014",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Tantrum." },
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "When Revealed: Deal 4 damage to a hero controlled by the player guarding ~Gollum. That player must choose a new player to guard Gollum, if able.",
                Shadow = "Shadow: Deal 2 damage to a hero controlled by the player guarding ~Gollum.",
                EncounterSet = "Return to Mirkwood",
                Number = 136,
                Artist = Artist.Tom_Garden
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Mirkwood Bats",
                Id = "51223bd0-ffd1-11df-a976-0801206c9015",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Creature." },
                Quantity = 4,
                EasyModeQuantity = 2,
                EngagementCost = 22,
                Attack = 1,
                Defense = 1,
                HitPoints = 1,
                Text = "Forced: After Mirkwood Bats engages a player, deal 1 damage to each character controlled by the player guarding ~Gollum.",
                Keywords = new List<string>() { "Surge." },
                Threat = 1,
                EncounterSet = "Return to Mirkwood",
                Number = 138,
                Artist = Artist.Felicia_Cano
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Mirkwood Runner",
                Id = "51223bd0-ffd1-11df-a976-0801206c9016",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Silvan.", " Scout." },
                Quantity = 3,
                ResourceCost = 3,
                Attack = 2,
                Defense = 0,
                Willpower = 1,
                HitPoints = 2,
                Text = "While Mirkwood Runner is attacking alone, the defending enemy does not count its Defense.",
                FlavorText = "\"...let a ploughman plough, but choose an otter for swimming, and for running light over grass and leaf or over snow-an Elf.\" -Legolas, The Fellowship of the Ring",
                Number = 123,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Rumour from the Earth",
                Id = "51223bd0-ffd1-11df-a976-0801206c9017",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Action: Look at the top card of the encounter deck. Then, you may pay 1 Lore resource to return Rumour from the Earth to your hand.",
                FlavorText = "'Where sight fails the earth may bring us rumour,' said Aragorn. 'The land must groan under their hated feet.' -The Two Towers",
                Number = 124,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Shadow of the Past",
                Id = "51223bd0-ffd1-11df-a976-0801206c9018",
                CardType = CardType.Event,
                Sphere = Sphere.Neutral,
                Quantity = 3,
                ResourceCost = 2,
                Text = "Action: Move the top card of the encounter discard pile to the top of the encounter deck.",
                FlavorText = "The wizard's face remained grave and attentive, and only a flicker in his deep eyes showed that he was startled and indeed alarmed. 'It has been called that before,' he said, 'but not by you.' -The Fellowship of the Ring",
                Number = 125,
                Artist = Artist.Henning_Ludvigsen
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Support of the Eagles",
                Id = "51223bd0-ffd1-11df-a976-0801206c9019",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Boon." },
                Quantity = 3,
                ResourceCost = 3,
                Text = "Attach to a Tactics hero.\r\nAction: Exhaust Support of the Eagles to choose an Eagle ally. Until the end of the phase, attached hero adds that ally's Attack or Defense (choose 1) to its own.",
                FlavorText = "\"I would bear you, whither you will, even were you made of stone.\" -Gwaihir, The Return of the King",
                Number = 120,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "The Spiders' Ring",
                Id = "51223bd0-ffd1-11df-a976-0801206c9020",
                CardType = CardType.Location,
                Traits = new List<string>() { "Forest." },
                Quantity = 4,
                EasyModeQuantity = 2,
                Text = "While The Spider's Ring is the active location, the player guarding ~Gollum cannot change.",
                Shadow = "Shadow: If this attack is undefended, return any current active location to the staging area. The Spider's Ring becomes the active location.",
                Threat = 3,
                QuestPoints = 2,
                EncounterSet = "Return to Mirkwood",
                Number = 131,
                Artist = Artist.Andrew_Johanson
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Through the Forest",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801206c9021",
                CardType = CardType.Quest,
                QuestPoints = 12,
                Quantity = 1,
                Text = "Setup: Search the encounter deck for Gollum. Choose a player to guard Gollum at the start of the game, and place Gollum in front of that player. Then shuffle the encounter deck. Reveal 1 card per player from the encounter deck, and add it to the staging area.",
                OppositeFlavorText = 
@"Having captured Gollum, you must now escort him through Mirkwood Forest for interrogation at Thranduil's Palace.
Mirkwood is always a dangerous place, but it is even worse with Gollum. Between the outbursts, tantrums, and the flying provisions, you are not afforded a moment's peace",
                EncounterSet = "Return to Mirkwood",
                Number = 126,
                Artist = Artist.Ignacio_Bazan_Lazcano,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.SpidersOfMirkwood, EncounterSet.Wilderlands }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "To the Elvin King's Halls",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-0801206c9023",
                CardType = CardType.Quest,
                FlavorText = "Having thwarted Gollum's escape attempt, you tighten his rope and push on through Mirkwood, to Thranduil's palace.",
                OppositeText = "The player guarding ~Gollum cannot play cards from his hand.",
                QuestPoints = 7,
                Quantity = 1,
                EncounterSet = "Return to Mirkwood",
                Number = 128,
                Artist = Artist.Timo_Karhula,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.SpidersOfMirkwood, EncounterSet.Wilderlands }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Wasted Provisions",
                Id = "51223bd0-ffd1-11df-a976-0801206c9025",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Tantrum." },
                Quantity = 3,
                EasyModeQuantity = 2,
                Text = "When Revealed: Discard the top 10 cards from the deck of the player guarding ~Gollum. That player must choose a new player to guard Gollum, if able.",
                Shadow = "Shadow: Discard the top 5 cards from the deck of the player guarding ~Gollum.",
                EncounterSet = "Return to Mirkwood",
                Number = 137,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "West Road Traveller",
                Id = "51223bd0-ffd1-11df-a976-0801206c9026",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Rohan." },
                Quantity = 3,
                ResourceCost = 2,
                Attack = 0,
                Defense = 0,
                Willpower = 2,
                HitPoints = 1,
                Text = "Response: After you play West Road Traveller from your hand, switch the active location with any other location in the staging area.",
                FlavorText = "The dark world was rushing by, and the wind sang loudly in his ears. -The Return of the King",
                Number = 121,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Wood Elf Path",
                Id = "51223bd0-ffd1-11df-a976-0801206c9027",
                CardType = CardType.Location,
                Traits = new List<string>() { "Forest." },
                Quantity = 3,
                Text = "Response: After the players travel to Wood Elf Path, the player guarding ~Gollum may choose a new player to guard him.",
                Threat = 1,
                QuestPoints = 3,
                EncounterSet = "Return to Mirkwood",
                Number = 134,
                Artist = Artist.Stacey_Diana_Clark
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Woodman's Glade",
                Id = "51223bd0-ffd1-11df-a976-0801206c9028",
                CardType = CardType.Location,
                Traits = new List<string>() { "Forest." },
                Quantity = 3,
                Text = "Travel: The player guarding ~Gollum must exhaust a hero he controls to travel to Woodman's Glade.Response: After exploring Woodman's Glade, reduce the threat of each player not guarding ~Gollum by 2.",
                Threat = 2,
                QuestPoints = 2,
                EncounterSet = "Return to Mirkwood",
                Number = 133,
                Artist = Artist.Mark_Poole
            });
        }
    }
}
