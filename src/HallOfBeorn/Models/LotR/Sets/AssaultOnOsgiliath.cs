using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class AssaultonOsgiliath : CardSet
    {
        protected override void Initialize()
        {
            Name = "Assault on Osgiliath";
            Abbreviation = "AoO";
            Number = 19;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Against the Shadow";

            Cards.Add(new LotRCard() {
                
                Title = "Faramir",
                Id = "323ebfa3-57e5-4394-9f55-284b2f7ee0be",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Lore,
                ThreatCost = 11,
                Willpower = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string>() { "Gondor.", " Ranger.", " Noble." },
                Keywords = new List<string>() { "Ranged." },
                Text = "Faramir gets +1 Attack for each enemy in the staging area.",
                FlavorText = "\"The road may pass, but they shall not! Not while Faramir is Captain.\" -Mablung, The Two Towers",
                Quantity = 1,
                CardNumber = 81,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Sword of Morthond",
                Id = "98ba9e54-d6c3-41ff-b886-81a29e29eb64",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Traits = new List<string>() { "Item.", " Weapon." },
                Text = "Attach to a Gondor ally.\r\nAttached ally gains the Outlands trait.",
                FlavorText = "The Morthond Valye made a great bay that beat up against the sheer southern faces of the mountains.\r\n-The Return of the King",
                Quantity = 3,
                CardNumber = 82,
                Artist = Artist.Sara_K_Diesel
            });
            Cards.Add(new LotRCard() {
                
                Title = "Men of the West",
                Id = "a2d440c4-6150-4b6f-9a36-faa51ace7908",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 254,
                IsVariableCost = true,
                Traits = new List<string>() { "Outlands." },
                Text = "Action: Return X Outlands allies from your discard pile to your hand.",
                FlavorText = "Death in the morning and at day's ending\r\nlords took and lowly. Long now they sleep\r\nunder grass in Gondor by the Great River.\r\n-The Return of the King ",
                Quantity = 3,
                CardNumber = 83,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard() {
                
                Title = "Knight of Minas Tirith",
                Id = "237b31e7-d0b0-4c1e-bd4a-40a175f7d7d1",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                ResourceCost = 3,
                Willpower = 0,
                Attack = 3,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string>() { "Gondor.", " Warrior." },
                Text = "If each of your heroes has a printed Tactics resource icon, Knight of Minas Tirith gains: \"Response: After Knight of Minas Tirith enters play, choose an enemy in the staging area. Engage that enemy and exhaust Knight of Minas Tirith to declare it as attacker (and resolve its attack) against that enemy.\"",
                Quantity = 3,
                CardNumber = 84,
                Artist = Artist.Emile_Denis
            });
            Cards.Add(new LotRCard() {
                
                Title = "Gondorian Fire",
                Id = "a7f12d87-5f28-46ca-a301-0ac48ca5e471",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                ResourceCost = 0,
                Traits = new List<string>() { "Gondor." },
                Text = "Attach to a Gondor or Dúnedain hero.\r\nAction: Spend 1 resource from attached hero's resource pool to give attached hero +1 Attack for each resource in its resource pool until the end of the phase. (Limit once per phase.)",
                Quantity = 3,
                CardNumber = 85,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                
                Title = "Pelargir Shipwright",
                Id = "d8d1e7b4-3639-4ca0-bc83-daa7f78554b2",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                ResourceCost = 3,
                Willpower = 0,
                Attack = 1,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string>() { "Gondor.", " Craftsman." },
                Text = "Pelargir Shipwright gets +1 Willpower for each hero you control with a printed Spirit resource icon.",
                FlavorText = "\"It is forty leagues and two from Pelargir to the landings at the Harlond...\"\r\n-Aragorn, The Return of the King",
                Quantity = 3,
                CardNumber = 86,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Map of Earnil",
                Id = "72cb5c31-c62f-4870-a5f4-099cdec1d4a7",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                ResourceCost = 4,
                Traits = new List<string>() { "Record." },
                Text = "Attach to a Spirit hero.\r\nReduce the cost to play Map of Earnil by 1 for each hero you control with a printed Spirit resource icon.\r\nAction: Discard Map of Earnil to play any Spirit event card in your discard pile as if it were in your hand. Then, place that event on the bottom of your deck.",
                Quantity = 3,
                CardNumber = 87,
                Artist = Artist.Florian_Stitz
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ranger Bow",
                Id = "3fa0b17f-a7d1-4f0c-a779-c20cb6084e78",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Traits = new List<string>() { "Weapon." },
                Keywords = new List<string>() { "Restricted." },
                Text = "Attach to a Ranger character.\r\nAction: Exhaust Ranger Bow and attached character to deal 1 damage to an enemy in the staging area.",
                FlavorText = "Two had great bows, almost of their own height, and great quivers of long green-feathered arrows.\r\n-The Two Towers",
                Quantity = 3,
                CardNumber = 88,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new LotRCard() {
                
                Title = "Forest Patrol",
                Id = "50aa4aab-6daa-4cb5-bfb1-a13db03c1a23",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Text = "Play only if you control at least 1 Ranger character.\r\nAction: Deal 3 damage to an enemy with at least 1 Trap card attached to it.",
                FlavorText = "\"For coming unbidden to this play death is our law.\" -Anborn, The Two Towers",
                Quantity = 3,
                CardNumber = 89,
                Artist = Artist.Kristina_Gehrmann
            });
            Cards.Add(new LotRCard() {
                
                Title = "Palantir",
                Id = "1e9a6c59-8dc7-4dc4-a5a4-f5f4f9ccdc55",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Neutral,
                ResourceCost = 1,
                Traits = new List<string>() { "Artifact.", "Item." },
                Text = "Attach to a Noble hero.\r\nPlanning Action: Exhaust Palantir and attached hero to name a card type and look at the top 3 cards of the encounter deck. For each of those cards that matches the named type, draw a card. For each of those cards that does not match the named type, raise your threat by 2.",
                Quantity = 3,
                CardNumber = 90,
                Artist = Artist.Sandara_Tang
            });
            Cards.Add(new LotRCard() {
                
                Title = "Retake the City",
                StageNumber = 1,
                Id = "c46c37c3-b2e7-4e28-9466-e3a371417c8b",
                CardType = CardType.Quest,
                EncounterSet = "Assault on Osgiliath",
                Text = "Setup: Each player chooses 1 enemy and 1 unique location and add them to the staging area. Shuffle the encounter deck.",
                OppositeText = "Player card effects cannot place progress tokens on locations in the staging area.\r\nForced: When an Osgiliath location leaves play as an explored location, the first player takes control of that location.\r\nIf the players control all Osgiliath locations in play at the end of the round, they have won the game.",
                FlavorText = "You have returned to Minas Tirith just in time to join the army of Gondor as it marches to Osgiliath. An army of orcs and southrons have garrisoned the ancient city, but Lord Boromir means to retake it. Eager to strike a blow against Mordor, you will see the city retaken or die in the attempt... ",
                Quantity = 1,
                CardNumber = 91,
                Artist = Artist.Tomasz_Jedruszek,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MordorElite, EncounterSet.Southrons }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Uruk Lieutenant",
                Id = "bfa3b9da-d0e3-4ad6-8d1d-f32975f69551",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 2,
                Attack = 6,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string>() { "Orc.", " Uruk.", " Mordor." },
                Text = "When Revealed: Add the topmost Orc enemy from the encounter discard pile to the staging area.",
                Shadow = "Shadow: Defending player discards an attachment he controls. (All attachments he controls instead if undefended.)",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 2,
                EasyModeQuantity = 0,
                CardNumber = 92,
                Artist = Artist.Blake_Henriksen
            });
            Cards.Add(new LotRCard() {
                
                Title = "Uruk Soldier",
                Id = "f89b8962-1081-4f61-bc08-b2ca4eb08ba8",
                CardType = CardType.Enemy,
                EngagementCost = 30,
                Threat = 1,
                Attack = 4,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string>() { "Orc.", " Uruk.", " Mordor." },
                Text = "Forced: After Uruk Soldier attacks and destroys a character, that character's controller returns a location he controls to the staging area, if able.",
                Shadow = "Shadow: Defending player raises his threat by 1 for each location he controls.",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 4,
                CardNumber = 93,
                Artist = Artist.Blake_Henriksen
            });
            Cards.Add(new LotRCard() {
                
                Title = "Southron Phalanx",
                Id = "1c95d49a-5638-4f31-a42f-f93a5d1f50db",
                CardType = CardType.Enemy,
                EngagementCost = 25,
                Threat = 1,
                Attack = 1,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string>() { "Harad." },
                Text = "While engaged with a player, Southron Phalanx gets +1 Attack for each location that player controls.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each location the defending player controls.",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 3,
                CardNumber = 94,
                Artist = Artist.J_Lonnee
            });
            Cards.Add(new LotRCard() {
                
                Title = "Southron Commander",
                Id = "264adf61-31e1-46db-a655-7fee1d4282ae",
                CardType = CardType.Enemy,
                EngagementCost = 37,
                Threat = 3,
                Attack = 5,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string>() { "Harad." },
                Text = "When Revealed: Southron Commander makes an immediate attack from the staging area against each player who controls at least 1 location.",
                FlavorText = "\"...the Southrons were bold men and grim...\"\r\n-The Return of the King",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 2,
                EasyModeQuantity = 0,
                CardNumber = 95,
                Artist = Artist.J_Lonnee
            });
            Cards.Add(new LotRCard() {
                
                Title = "West Gate",
                Id = "5a3d198a-5c72-42ec-b5ae-f183194632cf",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 5,
                Traits = new List<string>() { "Osgiliath." },
                Text = "Action: If there is no active location, search the encounter deck and discard pile for an Osgiliath location, reveal it and add it to the staging area. Then, make West Gate the active location. Shuffle the encounter deck.\r\nForced: After the player who controls West Gate lets an attack go undefended, return West Gate to the staging area.",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 1,
                CardNumber = 96,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                
                Title = "The King's Library",
                Id = "fa9df618-126b-4ea9-95d7-22cd5dad6d2f",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 3,
                Traits = new List<string>() { "Osgiliath." },
                Text = "Travel: Reveal the top card of the encounter deck and add it to the staging area to travel here.\r\nForced: After the player who controls the King's Library lets an attack go undefended, return the King's Library to the staging area.",
                FlavorText = "\"For that is the ruin of Osgiliath on either side of Anduin, which our enemies took and burned long ago.\"\r\n-Beregond, The Return of the King",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 1,
                CardNumber = 97,
                Artist = Artist.Julian_Kok
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ancient Harbor",
                Id = "0c44ed2b-976a-4b17-b7e7-e64b20f74fd7",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 5,
                Traits = new List<string>() { "Osgiliath." },
                Text = 
@"The players cannot travel here.

Combat Action: Exhaust a hero to place 1 progress token on Ancient Harbor.\r\nForced: After the player who controls Ancient Harbor lets an attack go undefended, return Ancient Harbor to the staging area.",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 1,
                CardNumber = 98,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Old Bridge",
                Id = "e46a15c0-abbe-4a2e-8951-0e9950aa0288",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 6,
                Traits = new List<string>() { "Osgiliath." },
                Text =
@"The players cannot travel here.

Planning Action: Spend 2 resources to play 1 progress token on The Old Bridge. (1 resource instead if there is another Osgiliath location in the staging area.)\r\nForced: After the player who controls The Old Bridge lets an attack go undefended, return The Old Bridge to the staging area.",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 1,
                CardNumber = 99,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new LotRCard() {
                
                Title = "West Quarter",
                Id = "b5c7bf41-7642-4d25-9794-cb247f540182",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 3,
                Traits = new List<string>() { "Osgiliath." },
                Text = "While West Quarter is the active location, the current quest gains Siege.",
                Shadow = "Shadow: If this attack destroys a character, that character's controller must return a location he controls with the highest Threat to the staging area.",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 2,
                EasyModeQuantity = 1,
                CardNumber = 100,
                Artist = Artist.Marcia_George_Bogdan
            });
            Cards.Add(new LotRCard() {
                
                Title = "East Quarter",
                Id = "93bf98f7-fe0f-4c03-bd93-2f8d5753acce",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 3,
                Traits = new List<string>() { "Osgiliath." },
                Text = "While East Quarter is the active location, the current quest gains Battle.",
                Shadow = "Shadow: If this attack destroys a character, that character's controller must return a location he controls with the highest Threat to the staging area.",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 2,
                EasyModeQuantity = 1,
                CardNumber = 101,
                Artist = Artist.Julian_Kok
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ruined Square",
                Id = "fb301d7d-7936-49b6-a938-40ff0ca549cb",
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 2,
                Traits = new List<string>() { "Osgiliath." },
                Keywords = new List<string>() { "Surge." },
                Text = "Response: After an enemy is defeated, place 1 progress token on Ruined Square.\r\nForced: If a player controls Ruined Square when a character leaves play, return Ruined Square to the staging area.",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 3,
                CardNumber = 102,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ruined Tower",
                Id = "ae5727cb-4d88-4a28-99be-84a565292b67",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 2,
                Traits = new List<string>() { "Osgiliath." },
                Text = "Travel: If there is 1 active location, exhaust a character to travel here. (There are now 2 active locations.)\r\nForced: After the player who controls Ruined Tower loses control of a location, return Ruined Tower to the staging area.",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 3,
                CardNumber = 103,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard() {
                
                Title = "Pinned Down",
                Id = "03b6d303-7722-4319-9623-e182b50c90b2",
                CardType = CardType.Treachery,
                EncounterSet = "Assault on Osgiliath",
                Text = "When Revealed: Add X to the archery total this round. X is the number of locations the players control. If the players control less than 4 locations, Pinned Down gains surge.",
                Shadow = "Shadow: If this attack destroys a character, that character's controller must return a location he controls with the highest Threat to the staging area.",
                Quantity = 2,
                CardNumber = 104,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard() {
                
                Title = "Street Fighting",
                Id = "2573b8e3-d3a1-47c0-acc8-e6151f223383",
                CardType = CardType.Treachery,
                Text = "When Revealed: Discard cards from the top of the encounter deck until an Osgiliath location is discarded. The first player may exhaust a hero to take control of that location. Otherwise, add that location to the staging area. This effect cannot be canceled.",
                FlavorText = "And now the fighting waxed furious...\r\n-The Return of the King",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 2,
                CardNumber = 105,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard() {
                
                Title = "Counter-attack",
                Id = "1f1ad7bb-68ca-4b48-b7fa-516e5314e272",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Surge." },
                Text = "When Revealed: Each player must either return the location he controls with the highest Threat to the staging area, or raise his threat by the total Threat of all locations he controls.",
                EncounterSet = "Assault on Osgiliath",
                Quantity = 2,
                EasyModeQuantity = 1,
                CardNumber = 106,
                Artist = Artist.Blake_Henriksen,
                HasErrata = true
            });
        }
    }
}
