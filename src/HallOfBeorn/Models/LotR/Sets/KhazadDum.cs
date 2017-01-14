using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class Khazaddum : CardSet
    {
        protected override void Initialize()
        {
            Name = "Khazad-dûm";
            NormalizedName = "Khazad-dum";
            Abbreviation = "KD";
            Number = 8;
            SetType = Models.SetType.Deluxe_Expansion;

            Cards.Add(new LotRCard() {
                
                Title = "A Foe Beyond",
                Id = "51223bd0-ffd1-11df-a976-0801207c9001",
                CardType = CardType.Treachery,
                EncounterSet = "Flight from Moria",
                Quantity = 4,
                EasyModeQuantity = 1,
                Text = "When Revealed: The last player deals damage equal to The ~Nameless Fear's attack to a hero he controls. This effect cannot be canceled.",
                Shadow = "Shadow: Deal damage equal to The ~Nameless Fear's Attack to the defending character.",
                CardNumber = 28,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard() {
                Title = "A Presence in the Dark",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801207c9002",
                CardType = CardType.Quest,
                
                EncounterSet = "Flight from Moria",
                Quantity = 1,
                Text = "Setup: Prepare the quest deck. Add The Nameless Fear to the staging area. Remove all copies of A Foe Beyond from the encounter deck. Then, shuffle 1 copy of A Foe Beyond per player back into the encounter deck.",
                OppositeText = "When Revealed: Reveal 1 encounter card per player, and add it to the staging area. Then, add A Presence in the Dark to your victory display.",
                VictoryPoints = 2,
                CardNumber = 69,
                Artist = Artist.Igor_Kieryluk,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.HazardsOfThePit, EncounterSet.DeepsOfMoria, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                
                Title = "A Way Up",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-0801207c9004",
                CardType = CardType.Quest,
                
                EncounterSet = "Into the Pit",
                OppositeText = 
@"Heroes do not collect resources during the resource phase.

If players defeat this stage, they win the game.",
                Quantity = 1,
                CardNumber = 66,
                Artist = Artist.Ben_Zweifel,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.TwistsAndTurns, EncounterSet.HazardsOfThePit, EncounterSet.GoblinsOfTheDeep }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Abandoned Tools",
                Id = "51223bd0-ffd1-11df-a976-0801207c9006",
                CardType = CardType.Objective,
                EncounterSet = "Flight from Moria",
                Traits = new List<string>() { "Tools." },
                Quantity = 1,
                Text = "Action: Exhaust a hero to claim this objective if it has no encounters attached. Then, attach Abandoned ~Tools to that hero. (If detached, return Abandoned ~Tools to the staging area.)",
                Keywords = new List<string>() { "Guarded.", " Restricted." },
                CardNumber = 29,
                Artist = Artist.Stu_Barnes
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ancestral Knowledge",
                Id = "51223bd0-ffd1-11df-a976-0801207c9007",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Action: Exhaust a Dwarf character to place 2 progress tokens on the active location. (4 progress tokens instead if it is an Underground or Mountain location.)",
                CardNumber = 12,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard() {
                
                Title = "Bifur",
                Id = "51223bd0-ffd1-11df-a976-0801207c9008",
                CardType = CardType.Hero,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 1,
                ThreatCost = 7,
                IsUnique = true,
                Attack = 1,
                Defense = 2,
                Willpower = 2,
                HitPoints = 3,
                Text = "Action: Pay 1 resource from a hero's resource pool to add 1 resource to Bifur's resource pool. Any player may trigger this ability. (Limit once per round.)",
                FlavorText = "\"And winter comes after autumn.\" - Bifur, The Hobbit",
                CardNumber = 2,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Bitter Wind",
                Id = "51223bd0-ffd1-11df-a976-0801207c9009",
                CardType = CardType.Treachery,
                EncounterSet = "Misty Mountains",
                Quantity = 3,
                Text = "When Revealed: The first player must discard 3 resources from each hero he controls.",
                Shadow = "Shadow: Defending player must discard 2 resources from each hero he controls.",
                CardNumber = 56,
                Artist = Artist.Anthony_Palumbo
            });
            Cards.Add(new LotRCard() {
                
                Title = "Black Uruks",
                Id = "51223bd0-ffd1-11df-a976-0801207c9010",
                CardType = CardType.Enemy,
                EncounterSet = "Misty Mountains",
                Traits = new List<string>() { "Uruk.", " Orc." },
                Quantity = 4,
                EngagementCost = 32,
                Attack = 3,
                Defense = 3,
                HitPoints = 2,
                Text = "When Revealed: The first player must choose and discard an attachment from a questing character, if able.",
                Shadow = "Shadow: If this attack is undefended, deal 2 additional shadow cards to attacking enemy.",
                Threat = 2,
                CardNumber = 54,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new LotRCard() {
                
                Title = "Book of Mazarbul",
                Id = "51223bd0-ffd1-11df-a976-0801207c9011",
                CardType = CardType.Objective,
                EncounterSet = "The Seventh Level",
                Traits = new List<string>() { "Item.", " Artifact." },
                Quantity = 1,
                IsUnique = true,
                Text = "Action: Exhaust a hero to claim this objective. Then, attach Book of Mazarbul to that hero. (If detached, return Book of Mazarbul to the staging area.)Attached hero cannot attack and does not exhaust to commit to a quest.",
                Keywords = new List<string>() { "Restricted." },
                CardNumber = 24,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Boots from Erebor",
                Id = "51223bd0-ffd1-11df-a976-0801207c9012",
                CardType = CardType.Attachment,
                Sphere = Sphere.Neutral,
                Traits = new List<string>() { "Item." },
                Quantity = 3,
                ResourceCost = 0,
                Text = "Attach to a Dwarf or Hobbit character. Limit 1 Boots from Erebor per character.\r\nAttached character gets +1 hit point.",
                CardNumber = 13,
                Artist = Artist.Carolina_Eade
            });
            Cards.Add(new LotRCard() {
                
                Title = "Branching Paths",
                Id = "51223bd0-ffd1-11df-a976-0801207c9013",
                CardType = CardType.Location,
                EncounterSet = "Twists and Turns",
                Traits = new List<string>() { "Underground.", " Dark." },
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "While Branching Paths is in the staging area, each Dark location gets +1 Threat.Forced: After Branching Paths leaves play as an explored location, look at the top 3 cards of the encounter deck. Players must choose 1 of those to reveal and add to the staging area, moving the other 2 to the bottom of the deck.",
                Threat = 1,
                QuestPoints = 3,
                CardNumber = 36,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Bridge of Khazad-dûm",
                Id = "51223bd0-ffd1-11df-a976-0801207c9014",
                CardType = CardType.Location,
                EncounterSet = "Into the Pit",
                Traits = new List<string>() { "Underground.", " Bridge." },
                Quantity = 1,
                IsUnique = true,
                Text = "While Bridge of Khazad-dûm is the active location, players cannot play cards.",
                Threat = 3,
                QuestPoints = 3,
                VictoryPoints = 2,
                CardNumber = 18,
                Artist = Artist.Lin_Bo
            });
            Cards.Add(new LotRCard() {
                
                Title = "Burning Low",
                Id = "51223bd0-ffd1-11df-a976-0801207c9015",
                CardType = CardType.Treachery,
                EncounterSet = "Twists and Turns",
                Quantity = 3,
                Text = "When Revealed: Each enemy and location currently in the staging area gets +1 Threat until the end of the phase. (+3 Threat instead if it is a Dark location.) Players may exhaust a Cave Torch to cancel this effect.",
                Shadow = "Shadow: attacking enemy gets +2 Attack.",
                CardNumber = 40,
                Artist = Artist.Anthony_Palumbo
            });
            Cards.Add(new LotRCard() {
                
                Title = "Cave In",
                Id = "51223bd0-ffd1-11df-a976-0801207c9016",
                CardType = CardType.Treachery,
                EncounterSet = "Hazards of the Pit",
                Traits = new List<string>() { "Hazard." },
                Quantity = 3,
                Text = "When Revealed: Remove all progress tokens from the current quest card and active location. If Cave In removed no progress tokens, it gains surge.",
                CardNumber = 48,
                Artist = Artist.Winona_Nelson
            });
            Cards.Add(new LotRCard() {
                
                Title = "Cave Torch",
                Id = "51223bd0-ffd1-11df-a976-0801207c9017",
                CardType = CardType.Objective,
                EncounterSet = "Twists and Turns",
                Traits = new List<string>() { "Light." },
                Quantity = 1,
                Text = "Attach to a hero.\r\nAction: Exhaust Cave Torch to place up to 3 progress tokens on a Dark location.Forced: After Cave Torch exhausts, discard the top card of the encounter deck. If that card is an enemy, add it to the staging area.",
                Keywords = new List<string>() { "Restricted." },
                HtmlTemplate = "<p>Attach to a {type:Hero@hero}. {keyword:Restricted.}</p><p><b>Action:</b> Exhaust self to place up to 3 progress on a {trait:Dark.@Dark} location.</p><p><b>Forced:</b> After {self} exhausts, discard the top card of the encounter deck. If that card is an enemy, add it to the staging area.</p>",
                CardNumber = 41,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new LotRCard() {
                
                Title = "Cave-troll",
                Id = "51223bd0-ffd1-11df-a976-0801207c9018",
                CardType = CardType.Enemy,
                EncounterSet = "The Seventh Level",
                Traits = new List<string>() { "Troll." },
                Quantity = 2,
                EasyModeQuantity = 1,
                EngagementCost = 33,
                Attack = 6,
                Defense = 4,
                HitPoints = 7,
                Text = "For each excess point of combat damage dealt by Cave-troll (damage that is dealt beyond the remaining hit points of the character damaged by its attack) you must damage another character you control.",
                Threat = 4,
                VictoryPoints = 2,
                CardNumber = 20,
                Artist = Artist.Timo_Karhula
            });
            Cards.Add(new LotRCard() {
                
                Title = "Chance Encounter",
                Id = "51223bd0-ffd1-11df-a976-0801207c9019",
                CardType = CardType.Treachery,
                EncounterSet = "Deeps of Moria",
                Quantity = 3,
                Text = "When Revealed: Put the top enemy in the encounter discard pile into play, engaged with the first player. If this effect put no enemies into play, Chance Encounter gains surge.",
                Shadow = "Shadow: attacking enemy gets +1 Attack. (+3 Attack instead if engaged with the first player.)",
                CardNumber = 45,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Chieftain of the Pit",
                Id = "51223bd0-ffd1-11df-a976-0801207c9020",
                CardType = CardType.Enemy,
                EncounterSet = "Plundering Goblins",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 1,
                EasyModeQuantity = 0,
                EngagementCost = 27,
                Attack = 5,
                Defense = 2,
                HitPoints = 4,
                Text = "When Revealed: Chieftain of the Pit gets +3 Attack until the end of the round.",
                Shadow = "Shadow: attacking enemy attacks again after this attack. Deal it another shadow card for the next attack.",
                Threat = 2,
                CardNumber = 30,
                Artist = Artist.John_Stanko
            });
            Cards.Add(new LotRCard() {
                
                Title = "Crumbling Ruin",
                Id = "51223bd0-ffd1-11df-a976-0801207c9021",
                CardType = CardType.Treachery,
                EncounterSet = "Hazards of the Pit",
                Traits = new List<string>() { "Hazard." },
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Each player must exhaust a character and discard the top card of his deck, if able. If the printed cost of the discarded card is equal to or higher than the remaining hit points of the exhausted character, discard the exhausted character.",
                CardNumber = 49,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Dark and Dreadful",
                Id = "51223bd0-ffd1-11df-a976-0801207c9022",
                CardType = CardType.Treachery,
                EncounterSet = "Hazards of the Pit",
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "When Revealed: Deal 1 damage to each exhausted character. (2 damage instead if the active location is a Dark location.)",
                Shadow = "Shadow: Deal 1 damage to the defending character. (Attacking enemy gets +2 Attack instead if this attack is undefended.)",
                CardNumber = 50,
                Artist = Artist.Igor_Kieryluk
            });
            Cards.Add(new LotRCard() {
                
                Title = "Dreadful Gap",
                Id = "51223bd0-ffd1-11df-a976-0801207c9023",
                CardType = CardType.Location,
                EncounterSet = "Hazards of the Pit",
                Traits = new List<string>() { "Underground.", " Hazard." },
                Quantity = 1,
                EasyModeQuantity = 0,
                Text = "When Revealed: Immediately travel to Dreadful Gap. If another location is currently active, return it to the staging area.X is the number of characters in play.",
                Threat = 2,
                QuestPoints = Card.VALUE_X,
                VictoryPoints = 3,
                CardNumber = 52,
                Artist = Artist.Stu_Barnes
            });
            Cards.Add(new LotRCard() {
                
                Title = "Durin's Song",
                Id = "51223bd0-ffd1-11df-a976-0801207c9024",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Song." },
                Quantity = 3,
                ResourceCost = 1,
                Text = "Action: Choose a Dwarf hero. That hero gets +2 Willpower, +2 Attack, and +2 Defense until the end of the round.",
                FlavorText = 
@"A king he was on carven throne
In many-pillared halls of stone
With golden roof and silver floor,
And runes of power upon the door.
-The Fellowship of the Ring ",
                CardNumber = 4,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard() {
                
                Title = "Dwalin",
                Id = "51223bd0-ffd1-11df-a976-0801207c9025",
                CardType = CardType.Hero,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 1,
                ThreatCost = 9,
                IsUnique = true,
                Attack = 2,
                Defense = 2,
                Willpower = 1,
                HitPoints = 4,
                Text = "Response: After Dwalin attacks and destroys an Orc enemy, lower your threat by 2.",
                CardNumber = 1,
                Artist = Artist.Tony_Foti
            });
            Cards.Add(new LotRCard() {
                
                Title = "Dwarrowdelf Axe",
                Id = "51223bd0-ffd1-11df-a976-0801207c9026",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Item.", " Weapon." },
                Quantity = 3,
                ResourceCost = 1,
                Text = "Attach to a Dwarf character.\r\nAttached character gets +1 Attack.\r\nResponse: After attached character attacks, deal 1 damage to the defending enemy.",
                FlavorText = "\"We make good armour and keen swords, but we cannot again make mail or blade to match those that were made before the dragon came.\" -Gloin, The Fellowship of the Ring",
                Keywords = new List<string>() { "Restricted." },
                CardNumber = 7,
                Artist = Artist.Carolina_Eade
            });
            Cards.Add(new LotRCard() {
                
                Title = "East-gate",
                Id = "51223bd0-ffd1-11df-a976-0801207c9027",
                CardType = CardType.Location,
                EncounterSet = "Into the Pit",
                Traits = new List<string>() { "Gate." },
                Quantity = 1,
                IsUnique = true,
                Text = "Immune to card effects.\r\nPlayers cannot optionally engage enemies and no engagement checks are made.Forced: After East-gate leaves play as an explored location, add First Hall to the staging area.",
                Threat = 7,
                QuestPoints = 7,
                VictoryPoints = 1,
                CardNumber = 16,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard() {
                
                Title = "Entering the Mines",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801207c9028",
                CardType = CardType.Quest,
                
                EncounterSet = "Into the Pit",
                Quantity = 1,
                Text = "Setup: Search the encounter deck for East-gate and Cave Torch. Put East-gate into play as the active location, and have the first player attach Cave Torch to a hero of his choice. Set First Hall and Bridge of Khazad-dum aside, out of play. Shuffle the encounter deck.",
                OppositeText = 
@"When Revealed: Reveal 1 encounter card per player, and add it to the staging area.

Player cannot advance to the next stage of the scenario unless Bridge of Khazad-dum is in their victory display.",
                FlavorText = "You have been sent by the White Council to Moria, to deliver a message to Balin and his Dwarven colony. No one has heard from him in a while.",
                OppositeFlavorText = "The doors of the East-gate hang crooked on their henges. The darkness inside the doorway is still and impenetrable, shutting out the last beams of a sinking sun.",
                CardNumber = 64,
                Artist = Artist.Ben_Zweifel,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.TwistsAndTurns, EncounterSet.HazardsOfThePit, EncounterSet.GoblinsOfTheDeep }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Erebor Record Keeper",
                Id = "51223bd0-ffd1-11df-a976-0801207c9030",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 3,
                ResourceCost = 1,
                Attack = 0,
                Defense = 0,
                Willpower = 1,
                HitPoints = 1,
                Text = 
@"Erebor ~Record Keeper cannot attack or defend.

Action: Exhaust Erebor ~Record Keeper and pay 1 Lore resource to choose and ready a Dwarf character.",
                CardNumber = 11,
                Artist = Artist.Andrew_Johanson
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ever Onward",
                Id = "51223bd0-ffd1-11df-a976-0801207c9031",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 3,
                Text = "Response: After players quest unsuccessfully, choose a player. That player does not raise his threat.",
                CardNumber = 5,
                Artist = Artist.Dleoblack
            });
            Cards.Add(new LotRCard() {
                
                Title = "First Hall",
                Id = "51223bd0-ffd1-11df-a976-0801207c9032",
                CardType = CardType.Location,
                EncounterSet = "Into the Pit",
                Traits = new List<string>() { "Underground." },
                Quantity = 1,
                IsUnique = true,
                Text = "Travel: Each player must raise his threat by 3 to travel here.Forced: After First Hall leaves play as an explored location, add Bridge of Khazad-dum to the staging area.",
                Threat = 2,
                QuestPoints = 2,
                VictoryPoints = 1,
                CardNumber = 17,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                
                Title = "Fouled Well",
                Id = "51223bd0-ffd1-11df-a976-0801207c9033",
                CardType = CardType.Location,
                EncounterSet = "Hazards of the Pit",
                Traits = new List<string>() { "Underground.", " Dark.", " Hazard." },
                Quantity = 3,
                Text = "When Revealed: Each player may choose and discard 1 card at random from his hand. If all players did not discard 1 card, Fouled Well gains surge.",
                Threat = 3,
                QuestPoints = 5,
                CardNumber = 53,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new LotRCard() {
                
                Title = "Goblin Archer",
                Id = "51223bd0-ffd1-11df-a976-0801207c9034",
                CardType = CardType.Enemy,
                EncounterSet = "Plundering Goblins",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 2,
                EngagementCost = 48,
                Attack = 1,
                Defense = 3,
                HitPoints = 1,
                Text = "Players cannot optionally engaged Goblin Archer.\r\nCharacters with ranged are eligible to attack Goblin Archer while it is in the staging area.Forced: After an enemy is revealed from the encounter deck, the first player must deal 1 damage to 1 character he controls.",
                Threat = 2,
                CardNumber = 32,
                Artist = Artist.Salvador_Trakal
            });
            Cards.Add(new LotRCard() {
                
                Title = "Goblin Follower",
                Id = "51223bd0-ffd1-11df-a976-0801207c9035",
                CardType = CardType.Enemy,
                EncounterSet = "Twists and Turns",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 4,
                EngagementCost = 33,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Text = "When Revealed: Goblin Follower engages the last player.",
                Shadow = "Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if attacking the last player.)",
                Threat = 1,
                CardNumber = 35,
                Artist = Artist.Salvador_Trakal
            });
            Cards.Add(new LotRCard() {
                
                Title = "Goblin Patrol",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-0801207c9036",
                CardType = CardType.Quest,
                
                EncounterSet = "Into the Pit",
                OppositeText =
@"When Revealed: Each player must search the encounter deck and discard pile for 1 enemy of his choice, and add it to the staging area. One choice must be Patrol Leader, if able.

Forced: After an enemy is revealed from the encounter deck, discard it instead of adding it to the staging area.

If there are no enemies in play, immediately advance to the next stage of the scenario. (Players can also advance by placing 11 progress tokens on ~Goblin Patrol.)",
                FlavorText = "The skeletons of Dwarves and Orcs lie undisturbed, but you have discovered no recent sign of the Dwarven colony. The sound of scampering feet travels to your ears, and you move in that direction to investigate. There is a patrol of Goblins, marching in a loose formation through the shadows.",
                Quantity = 1,
                CardNumber = 65,
                Artist = Artist.Ilich_Henriquez,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.TwistsAndTurns, EncounterSet.HazardsOfThePit, EncounterSet.GoblinsOfTheDeep }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Goblin Scout",
                Id = "51223bd0-ffd1-11df-a976-0801207c9038",
                CardType = CardType.Enemy,
                EncounterSet = "Goblins of the Deep",
                Traits = new List<string>() { "Goblin.", " Orc.", " Scout." },
                Quantity = 3,
                EngagementCost = 37,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Text = "Each player with a threat of 25 or higher cannot optionally engage Goblin Scout.",
                Threat = 3,
                CardNumber = 60,
                Artist = Artist.Winona_Nelson
            });
            Cards.Add(new LotRCard() {
                
                Title = "Goblin Spearman",
                Id = "51223bd0-ffd1-11df-a976-0801207c9039",
                CardType = CardType.Enemy,
                EncounterSet = "Plundering Goblins",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 5,
                EngagementCost = 15,
                Attack = 2,
                Defense = 2,
                HitPoints = 2,
                Text = "Goblin Spearman gets +2 Attack if its attack is undefended.",
                Shadow = "Shadow: Add Goblin Spearman to the staging area.",
                Threat = 2,
                CardNumber = 31,
                Artist = Artist.Salvador_Trakal
            });
            Cards.Add(new LotRCard() {
                
                Title = "Goblin Swordsman",
                Id = "51223bd0-ffd1-11df-a976-0801207c9040",
                CardType = CardType.Enemy,
                EncounterSet = "Goblins of the Deep",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 5,
                EngagementCost = 20,
                Attack = 3,
                Defense = 1,
                HitPoints = 2,
                Text = "Goblin Swordsman gets +2 Attack if its attack is undefended.",
                Shadow = "Shadow: Add Goblin Swordsman to the staging area.",
                Threat = 1,
                CardNumber = 61,
                Artist = Artist.Winona_Nelson
            });
            Cards.Add(new LotRCard() {
                
                Title = "Goblin Tunnels",
                Id = "51223bd0-ffd1-11df-a976-0801207c9041",
                CardType = CardType.Location,
                EncounterSet = "Goblins of the Deep",
                Traits = new List<string>() { "Underground.", " Dark." },
                Quantity = 2,
                Text = "While Goblin Tunnels is in the staging area, it gains: 'Forced: After a Goblin is revealed from the encounter deck, remove a progress token from the current quest card.'",
                Shadow = "Shadow: attacking enemy gets +1 Attack. (+3 Attack instead if attacking enemy is a Goblin.)",
                Threat = 2,
                QuestPoints = 7,
                CardNumber = 63,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                
                Title = "Great Cave-troll",
                Id = "51223bd0-ffd1-11df-a976-0801207c9042",
                CardType = CardType.Enemy,
                EncounterSet = "Deeps of Moria",
                Traits = new List<string>() { "Troll." },
                Quantity = 2,
                EasyModeQuantity = 0,
                EngagementCost = 38,
                Attack = 7,
                Defense = 3,
                HitPoints = 10,
                Text = "Immune to ranged damage.\r\nNo attachments can be played on Great Cave-troll.",
                Threat = 2,
                VictoryPoints = 3,
                CardNumber = 42,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Hidden Threat",
                Id = "51223bd0-ffd1-11df-a976-0801207c9043",
                CardType = CardType.Treachery,
                EncounterSet = "The Seventh Level",
                Quantity = 2,
                Text = "When Revealed: Each player must raise his threat by 1 for each enemy in the staging area. Then, the last player discards an attachment he controls.",
                CardNumber = 22,
                Artist = Artist.Ryan_Barger
            });
            Cards.Add(new LotRCard() {
                
                Title = "Khazâd! Khazâd!",
                Id = "51223bd0-ffd1-11df-a976-0801207c9044",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Action: Choose a Dwarf character. Until the end of the phase, that character gets +3 Attack.",
                FlavorText = "Down from the wall leapt Gimli with a fierce cry the echoed in the cliffs. \"Khazâd! Khazâd!\" He soon had work enough.\r\n-The Two Towers",
                HtmlTemplate = "<p><b>Action:</b> Choose a {trait-character:Dwarf.@Dwarf} character. Until the end of the phase, that character gets +3 {Attack}.</p><p class='flavor-text'>Down from the wall leapt Gimli with a fierce cry the echoed in the cliffs. &quot;Khazâd! Khazâd!&quot; He soon had work enough.<br>&ndash;The Two Towers</p>",
                CardNumber = 8,
                Artist = Artist.Igor_Kieryluk
            });
            Cards.Add(new LotRCard() {
                
                Title = "Knees of the Mountain",
                Id = "51223bd0-ffd1-11df-a976-0801207c9045",
                CardType = CardType.Location,
                EncounterSet = "Misty Mountains",
                Traits = new List<string>() { "Mountain." },
                Quantity = 1,
                Text = "While Knees of the Mountain is in the staging area, it gains: 'Forced: After an enemy engages a player, it gets +1 Attack until the end of the round.'",
                Threat = 2,
                QuestPoints = 3,
                CardNumber = 57,
                Artist = Artist.Stacey_Diana_Clark
            });
            Cards.Add(new LotRCard() {
                
                Title = "Lightless Passage",
                Id = "51223bd0-ffd1-11df-a976-0801207c9046",
                CardType = CardType.Location,
                EncounterSet = "Twists and Turns",
                Traits = new List<string>() { "Underground.", " Dark." },
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "Travel: Players must exhaust a Cave Torch to travel here.",
                Shadow = "Shadow: Cancel all combat damage dealt to attacking enemy.",
                Threat = 4,
                QuestPoints = 4,
                CardNumber = 37,
                Artist = Artist.Stu_Barnes
            });
            Cards.Add(new LotRCard() {
                
                Title = "Many Roads",
                Id = "51223bd0-ffd1-11df-a976-0801207c9047",
                CardType = CardType.Treachery,
                EncounterSet = "Twists and Turns",
                Quantity = 1,
                Text = "When Revealed: Shuffle all locations in the encounter discard pile back into the encounter deck.",
                Keywords = new List<string>() { "Surge." },
                CardNumber = 39,
                Artist = Artist.Stu_Barnes
            });
            Cards.Add(new LotRCard() {
                
                Title = "Massing in the Deep",
                Id = "51223bd0-ffd1-11df-a976-0801207c9048",
                CardType = CardType.Treachery,
                EncounterSet = "Deeps of Moria",
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Reveal X additional cards from the encounter deck and add them to the staging area. X is the number of players in the game.",
                Shadow = "Shadow: attacking enemy gets +X Attack. X is the number of players in the game.",
                Keywords = new List<string>() { "Doomed 1." },
                CardNumber = 46,
                Artist = Artist.Noah_Bradley
            });
            Cards.Add(new LotRCard() {
                
                Title = "Mountain Warg",
                Id = "51223bd0-ffd1-11df-a976-0801207c9049",
                CardType = CardType.Enemy,
                EncounterSet = "Misty Mountains",
                Traits = new List<string>() { "Creature." },
                Quantity = 3,
                EasyModeQuantity = 2,
                EngagementCost = 30,
                Attack = 4,
                Defense = 2,
                HitPoints = 4,
                Text = "If Mountain Warg is dealt a shadow card with no effect, return Mountain Warg to the staging area after it attacks.",
                Shadow = "Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if a Mountain is the active location.)",
                Threat = 2,
                CardNumber = 55,
                Artist = Artist.Allison_Theus
            });
            Cards.Add(new LotRCard() {
                
                Title = "Narvi's Belt",
                Id = "51223bd0-ffd1-11df-a976-0801207c9050",
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Item." },
                Quantity = 3,
                ResourceCost = 2,
                IsUnique = true,
                Text = "Attach to a Dwarf hero.\r\nAction: Exhaust Narvi's Belt to give attached hero a Leadership, Lore, Tactics, or Spirit icon until the end of the phase.",
                CardNumber = 3,
                Artist = Artist.Carolina_Eade,
                HasErrata = true
            });
            Cards.Add(new LotRCard() {
                
                Title = "New Devilry",
                Id = "51223bd0-ffd1-11df-a976-0801207c9051",
                CardType = CardType.Treachery,
                EncounterSet = "Flight from Moria",
                Quantity = 3,
                Text = "When Revealed: If the players are not on stage 1, shuffle the current quest card into the quest deck, then reveal a new quest card. Otherwise, New Devilry gains surge.",
                Shadow = "Shadow: If this attack is undefended, raise your threat by The Nameless Fear's Threat.",
                CardNumber = 26,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc Drummer",
                Id = "51223bd0-ffd1-11df-a976-0801207c9052",
                CardType = CardType.Enemy,
                EncounterSet = "Deeps of Moria",
                Traits = new List<string>() { "Orc.", " Summoner." },
                Quantity = 1,
                EasyModeQuantity = 0,
                EngagementCost = 50,
                Attack = 1,
                Defense = 3,
                HitPoints = 1,
                Text = "While Orc Drummer is in the staging area, each enemy gets +X Threat. X is the number of players in the game.",
                Threat = 1,
                CardNumber = 43,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc Horn Blower",
                Id = "51223bd0-ffd1-11df-a976-0801207c9053",
                CardType = CardType.Enemy,
                EncounterSet = "The Seventh Level",
                Traits = new List<string>() { "Orc.", " Summoner." },
                Quantity = 1,
                EasyModeQuantity = 0,
                EngagementCost = 45,
                Attack = 1,
                Defense = 1,
                HitPoints = 3,
                Text = "When Revealed: Reveal 1 card from the encounter deck and add it to the staging area.",
                Keywords = new List<string>() { "Surge." },
                Threat = 2,
                CardNumber = 21,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard() {
                
                Title = "Patrol Leader",
                Id = "51223bd0-ffd1-11df-a976-0801207c9054",
                CardType = CardType.Enemy,
                EncounterSet = "Into the Pit",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 2,
                EasyModeQuantity = 1,
                EngagementCost = 30,
                Attack = 4,
                Defense = 3,
                HitPoints = 4,
                Text = "Forced: Before Patrol Leader is dealt damage, discard the top card of the encounter deck. If the discarded card is an enemy, cancel that damage.",
                Shadow = "Shadow: Cancel all damage dealt to this enemy.",
                Threat = 3,
                CardNumber = 14,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Plundered Armoury",
                Id = "51223bd0-ffd1-11df-a976-0801207c9055",
                CardType = CardType.Location,
                EncounterSet = "Plundering Goblins",
                Traits = new List<string>() { "Underground." },
                Quantity = 2,
                Text = "While Plundered Armoury is in the staging area, enemies get +1 Attack.Response: After Plundered Armoury leaves play as an explored location, each player may attach a Weapon or Armour attachment from his hand to 1 character he controls.",
                Threat = 3,
                QuestPoints = 2,
                CardNumber = 34,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                
                Title = "Search for an Exit",
                SlugIncludesOppositeTitle = true,
                StageNumber = 2,
                OppositeTitle = "Heading Down",
                Id = "51223bd0-ffd1-11df-a976-0801207c9056",
                CardType = CardType.Quest,
                
                EncounterSet = "Flight from Moria",
                Quantity = 1,
                Text = "While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.",
                OppositeText = "Forced: If Heading Up is in the player's victory display at the end of any quest phase, shuffle Heading Up back into the quest deck. Players may bypass this quest card at the end of the combat phase.",
                FlavorText = "As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...",
                QuestPoints = 5,
                VictoryPoints = 1,
                CardNumber = 70,
                Artist = Artist.Cristi_Balanescu,
                BackArtist = Artist.Magali_Villeneuve,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.HazardsOfThePit, EncounterSet.DeepsOfMoria, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Search for an Exit",
                SlugIncludesOppositeTitle = true,
                StageNumber = 2,
                OppositeTitle = "Heading Up",
                Id = "51223bd0-ffd1-11df-a976-0801207c9058",
                CardType = CardType.Quest,
                
                EncounterSet = "Flight from Moria",
                Quantity = 1,
                Text = "While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.",
                OppositeText = "Forced: If Heading Down is in the player's victory display at the end of any quest phase, shuffle Heading DOwn back into the quest deck.",
                FlavorText = "As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...",
                QuestPoints = 7,
                VictoryPoints = 1,
                CardNumber = 71,
                Artist = Artist.Cristi_Balanescu,
                BackArtist = Artist.Magali_Villeneuve,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.HazardsOfThePit, EncounterSet.DeepsOfMoria, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Search for an Exit",
                SlugIncludesOppositeTitle = true,
                StageNumber = 2,
                OppositeTitle = "A Wrong Turn",
                Id = "51223bd0-ffd1-11df-a976-0801207c9060",
                CardType = CardType.Quest,
                
                EncounterSet = "Flight from Moria",
                Quantity = 1,
                Text = "While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.",
                OppositeText = "When Revealed: Reveal 1 encounter card per players, and add it to the staging area. Players may bypass this quest at the end of the combat phase.",
                FlavorText = "As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...",
                QuestPoints = 1,
                VictoryPoints = 2,
                CardNumber = 72,
                Artist = Artist.Cristi_Balanescu,
                BackArtist = Artist.David_Lecossu,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.HazardsOfThePit, EncounterSet.DeepsOfMoria, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Search for an Exit",
                SlugIncludesOppositeTitle = true,
                StageNumber = 2,
                OppositeTitle = "Narrow Paths",
                Id = "51223bd0-ffd1-11df-a976-0801207c9062",
                CardType = CardType.Quest,
                
                EncounterSet = "Flight from Moria",
                Quantity = 1,
                Text = "While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.",
                OppositeText = "When Revealed: Each player chooses 1 questing character he controls. Each questing character not chosen does not count its willpower until the end of the turn. Forced: After placing the 1st progress token on Narrow Paths, search the encounter deck and discard pile for Abandoned Tools and add it to the staging area, if able. Players may bypas this quest card at the end of the combat phase.",
                FlavorText = "As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...",
                QuestPoints = 3,
                VictoryPoints = 1,
                CardNumber = 73,
                Artist = Artist.Cristi_Balanescu,
                BackArtist = Artist.Ilich_Henriquez,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.HazardsOfThePit, EncounterSet.DeepsOfMoria, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Search for an Exit",
                SlugIncludesOppositeTitle = true,
                StageNumber = 2,
                OppositeTitle = "Hasty Council",
                Id = "51223bd0-ffd1-11df-a976-0801207c9064",
                CardType = CardType.Quest,
                
                EncounterSet = "Flight from Moria",
                Quantity = 1,
                Text = "While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.",
                OppositeText = "When Revealed: Shuffle all copies of A Foe Beyond from the encounter discard pile back into the encounter deck. Reveal the top 2 cards of the quest deck. Choose 1 to become the active quest (flipped to side 2B) and put the other on the bottom of the quest deck. Then, add Hasty Council to your victory display.",
                FlavorText = "As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...",
                VictoryPoints = 2,
                CardNumber = 74,
                Artist = Artist.Cristi_Balanescu,
                BackArtist = Artist.Stacey_Diana_Clark,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.HazardsOfThePit, EncounterSet.DeepsOfMoria, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Search for an Exit",
                SlugIncludesOppositeTitle = true,
                StageNumber = 2,
                OppositeTitle = "Blocked By Shadow",
                Id = "51223bd0-ffd1-11df-a976-0801207c9066",
                CardType = CardType.Quest,
                
                EncounterSet = "Flight from Moria",
                Quantity = 1,
                Text = "While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.",
                OppositeText = 
@"When Revealed: The first player chooses 1 of the following:
• Each player discards 1 card from the top of the encounter deck. If the card is a treachery card, the discarding player is eliminated from the game.
• Reveals the next quest card, putting Blocked by ~Shadow on the bottom of the quest deck. 

Players may bypass this quest card at the end of the combat phase. If the players defeat this stage, they escape and win the game.",
                FlavorText = "As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...",
                QuestPoints = 9,
                CardNumber = 75,
                Artist = Artist.Cristi_Balanescu,
                BackArtist = Artist.Magali_Villeneuve,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.HazardsOfThePit, EncounterSet.DeepsOfMoria, EncounterSet.PlunderingGoblins }
            });
            addCard(new LotRCard()
            {
                
                Title = "Search for an Exit",
                SlugIncludesOppositeTitle = true,
                StageNumber = 2,
                OppositeTitle = "Escape from Darkness",
                Id = "51223bd0-ffd1-11df-a976-0801207c9068",
                CardType = CardType.Quest,
                
                EncounterSet = "Flight from Moria",
                Quantity = 1,
                Text = "While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.",
                OppositeText = "Abandoned ~Tools gains: \"Refresh Action: Exhaust attached hero to put a progress token on ~Escape from Darkness.\"\r\nPlayers may bypass this quest card at the end of the combat phase. Progress tokens cannot be placed on Escape from Darkness except by Abandoned Tools. If the players defeat this stage, they escape and win the game.",
                FlavorText = "As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...",
                QuestPoints = 4,
                CardNumber = 76,
                Artist = Artist.Cristi_Balanescu,
                BackArtist = Artist.Magali_Villeneuve,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.HazardsOfThePit, EncounterSet.DeepsOfMoria, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                Title = "Search for the Chamber",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801207c9070",
                CardType = CardType.Quest,
                
                EncounterSet = "The Seventh Level",
                Quantity = 1,
                Text = "Setup: Search the encounter deck for Book of Mazarbul, and have the first player attach it to a hero of his choice. Shuffle the encounter deck.",
                OppositeText = "When Revealed: Reveal 1 encounter card per player, and add it to the staging area.",
                CardNumber = 67,
                Artist = Artist.Cristi_Balanescu,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Shadow of Fear",
                Id = "51223bd0-ffd1-11df-a976-0801207c9072",
                CardType = CardType.Treachery,
                EncounterSet = "Flight from Moria",
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "When Revealed: The first player attaches Shadow of Fear to one of his heroes. (Counts as a Condition attachment with the text: 'Limit 1 per hero. Attached hero cannot exhaust or ready and its text box is treated as if it were blank. Action: Pay 3 resources from attached hero's pool to discard this card.')",
                CardNumber = 27,
                Artist = Artist.Gabrielle_Portal
            });
            Cards.Add(new LotRCard() {
                
                Title = "Signs of Conflict",
                Id = "51223bd0-ffd1-11df-a976-0801207c9073",
                CardType = CardType.Treachery,
                EncounterSet = "Into the Pit",
                Quantity = 5,
                EasyModeQuantity = 2,
                Text = string.Empty,
                Shadow = "Shadow: Defending player raises his threat by 2.",
                Keywords = new List<string>() { "Doomed 2.", "Surge." },
                CardNumber = 15,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard() {
                Title = "Stairs of Náin",
                Id = "51223bd0-ffd1-11df-a976-0801207c9074",
                CardType = CardType.Location,
                EncounterSet = "Into the Pit",
                Traits = new List<string>() { "Underground." },
                Quantity = 2,
                Text = "Travel: The first player must exhaust 1 character he controls to travel here.",
                Shadow = "Shadow: Defending player must choose and exhaust 1 character he controls.",
                Threat = 2,
                QuestPoints = 4,
                CardNumber = 19,
                Artist = Artist.Lin_Bo
            });
            Cards.Add(new LotRCard() {
                
                Title = "Stray Goblin",
                Id = "51223bd0-ffd1-11df-a976-0801207c9075",
                CardType = CardType.Enemy,
                EncounterSet = "Deeps of Moria",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 3,
                EngagementCost = 29,
                Attack = 0,
                Defense = 2,
                HitPoints = 2,
                Text = "X is the number of players in the game.",
                Shadow = "Shadow: attacking enemy gets +X Attack. X is the number of players in the game.",
                Threat = Card.VALUE_X,
                CardNumber = 44,
                Artist = Artist.Mike_Capprotti
            });
            Cards.Add(new LotRCard() {
                
                Title = "Sudden Pitfall",
                Id = "51223bd0-ffd1-11df-a976-0801207c9076",
                CardType = CardType.Treachery,
                EncounterSet = "Hazards of the Pit",
                Traits = new List<string>() { "Hazard." },
                Quantity = 1,
                EasyModeQuantity = 0,
                Text = "When Revealed: The first player must discard 1 questing character he controls, if able. This effect cannot be canceled.",
                Shadow = "Shadow: Discard the defending character from play.",
                CardNumber = 51,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Fate of Balin",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-0801207c9077",
                CardType = CardType.Quest,
                
                EncounterSet = "The Seventh Level",
                OppositeText = 
@"When Revealed: Remove Book of Mazarbul from the game.

Forced: At the end of the staging step, reveal the top X cards of the encounter deck, adding all enemies to the staging area. Discard the other revealed cards without resolving them. X is the number of players.

If the players defeat this stage, they win the game.",
                Quantity = 1,
                CardNumber = 68,
                Artist = Artist.Ben_Zweifel,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Mountains' Roots",
                Id = "51223bd0-ffd1-11df-a976-0801207c9079",
                CardType = CardType.Location,
                EncounterSet = "Deeps of Moria",
                Traits = new List<string>() { "Underground." },
                Quantity = 3,
                Text = "X is the number of players in the game.",
                Shadow = "Shadow: attacking enemy gets +X Attack. X is the number of players in the game.",
                Threat = Card.VALUE_X,
                QuestPoints = Card.VALUE_X,
                CardNumber = 47,
                Artist = Artist.Stu_Barnes
            });
            Cards.Add(new LotRCard() {
                Title = "The Nameless Fear",
                Id = "51223bd0-ffd1-11df-a976-0801207c9080",
                CardType = CardType.Enemy,
                EncounterSet = "Flight from Moria",
                Traits = new List<string>() { "Flame.", " Shadow." },
                Quantity = 1,
                EngagementCost = 50,
                IsUnique = true,
                Attack = Card.VALUE_X,
                Defense = Card.VALUE_X,
                HitPoints = 27,
                Text = "Immune to player card effects.\r\nThe Nameless Fear cannot engage or be engaged.\r\nX is the number of victory points in the victory display.",
                Threat = Card.VALUE_X,
                CardNumber = 25,
                Artist = Artist.Timo_Karhula
            });
            Cards.Add(new LotRCard() {
                
                Title = "Turbulent Waters",
                Id = "51223bd0-ffd1-11df-a976-0801207c9081",
                CardType = CardType.Location,
                EncounterSet = "Misty Mountains",
                Traits = new List<string>() { "Mountain." },
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "While Turbulent Waters is the active location, players cannot optionally engage enemies.",
                Threat = 3,
                QuestPoints = 2,
                CardNumber = 58,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new LotRCard() {
                
                Title = "Undisturbed Bones",
                Id = "51223bd0-ffd1-11df-a976-0801207c9082",
                CardType = CardType.Treachery,
                EncounterSet = "Plundering Goblins",
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "When Revealed: Each player must deal X damage to 1 ally he controls. X is the number of allies he controls.",
                Shadow = "Shadow: If the defending character is an ally, discard it from play.",
                CardNumber = 33,
                Artist = Artist.Carolina_Eade
            });
            Cards.Add(new LotRCard() {
                
                Title = "Untroubled by Darkness",
                Id = "51223bd0-ffd1-11df-a976-0801207c9083",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                Quantity = 3,
                ResourceCost = 2,
                Text = "Action: Each Dwarf character gets +1 Willpower until the end of the phase. (+2 Willpower instead if the active location is an Underground or Dark location.)",
                CardNumber = 10,
                Artist = Artist.Tiziano_Baracchi
            });
            Cards.Add(new LotRCard() {
                
                Title = "Upper Hall",
                Id = "51223bd0-ffd1-11df-a976-0801207c9084",
                CardType = CardType.Location,
                EncounterSet = "The Seventh Level",
                Traits = new List<string>() { "Underground." },
                Quantity = 3,
                Keywords = new List<string>() { "Doomed 2." },
                Threat = 3,
                QuestPoints = 4,
                CardNumber = 23,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new LotRCard() {
                
                Title = "Veteran of Nanduhirion",
                Id = "51223bd0-ffd1-11df-a976-0801207c9085",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Dwarf.", " Warrior." },
                Quantity = 3,
                ResourceCost = 4,
                Attack = 3,
                Defense = 2,
                Willpower = 0,
                HitPoints = 3,
                Text = "Veteran of Nanduhirion enters play with 1 damage on it.",
                FlavorText = "With cries of \"Moria!\" and \"Dain, Dain!\" the dwarves of the Iron Hills plunged in... -The Hobbit",
                CardNumber = 6,
                Artist = Artist.Dleoblack
            });
            Cards.Add(new LotRCard() {
                
                Title = "Warg Lair",
                Id = "51223bd0-ffd1-11df-a976-0801207c9086",
                CardType = CardType.Location,
                EncounterSet = "Misty Mountains",
                Traits = new List<string>() { "Mountain." },
                Quantity = 2,
                Text = "When Revealed: Search the encounter deck and discard pile for 1 copy of Mountain Warg and add it to the staging area, if able. Shuffle the encounter deck.Response: After Warg Lair leaves play as an explored location, each player draws 1 card.",
                Threat = 1,
                QuestPoints = 3,
                CardNumber = 59,
                Artist = Artist.Roman_V_Papsuev
            });
            Cards.Add(new LotRCard() {
                
                Title = "Watchful Eyes",
                Id = "51223bd0-ffd1-11df-a976-0801207c9087",
                CardType = CardType.Treachery,
                EncounterSet = "Goblins of the Deep",
                Quantity = 3,
                EasyModeQuantity = 0,
                Text = "When Revealed: The first player attaches Watchful Eyes to one of his heroes. (Counts as a Condition attachment with the text: 'Limit 1 per hero. Forced: If attached hero is exhausted at the end of the combat phase, reveal 1 card from the encounter deck and add it to the staging area.')",
                CardNumber = 62,
                Artist = Artist.Tiziano_Baracchi
            });
            Cards.Add(new LotRCard() {
                
                Title = "Zigil Miner",
                Id = "51223bd0-ffd1-11df-a976-0801207c9088",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 3,
                ResourceCost = 2,
                Attack = 1,
                Defense = 1,
                Willpower = 1,
                HitPoints = 1,
                Text = "Action: Exhaust Zigil Miner and name a number to discard the top 2 cards of your deck. If at least one of those cards has cost equal to the named number, choose a hero you control. For each card that matches the named number, add 1 resource to that hero's resource pool.",
                CardNumber = 9,
                Artist = Artist.Magali_Villeneuve,
                HasErrata = true
            });
            Cards.Add(new LotRCard() {
                
                Title = "Zigil Mineshaft",
                Id = "51223bd0-ffd1-11df-a976-0801207c9089",
                CardType = CardType.Location,
                EncounterSet = "Twists and Turns",
                Traits = new List<string>() { "Underground.", " Dark." },
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "Action: Raise each player's threat by 1 to place 1 progress token on Zigil Mineshaft.",
                Threat = 5,
                QuestPoints = 5,
                CardNumber = 38,
                Artist = Artist.David_Lecossu
            });
        }
    }
}
