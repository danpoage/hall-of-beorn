using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class FoundationsofStone : CardSet
    {
        protected override void Initialize()
        {
            Name = "Foundations of Stone";
            Abbreviation = "FoS";
            Number = 13;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dwarrowdelf";

            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Asfaloth",
                Id = "51223bd0-ffd1-11df-a976-0801212c9001",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 2,
                IsUnique = true,
                Traits = new List<string>() { "Mount." },
                Text = "Attach to a Noldor or Silvan hero.\r\nAction: Exhaust Asfaloth to place 1 progress token on any location. (2 tokens instead if attached hero is Glorfindel.)",
                FlavorText = "Suddenly into view below came a white horse, gleaming in the shadows, running swiftly. In the dusk its headstall flickered and flashed as if it were studded with gems like living stars. -The Fellowship of the Ring",
                HtmlTemplate = "<p>Attach to a {traits-hero:Noldor,Silvan}.</p><b>Action:</b> Exhaust {self} to place 1 progress token on any location. (2 tokens instead if attached hero is <a title='Glorfindel Hero' href='/Cards/Search?Query=%2Btitle%3DGlorfindel&CardType=Hero' target='_blank'>Glorfindel</a>.)<p></p><p class='flavor-text'>Suddenly into view below came a white horse, gleaming in the shadows, running swiftly. In the dusk its headstall flickered and flashed as if it were studded with gems like living stars. &ndash;The Fellowship of the Ring</p>",
                Number = 110,
                Artist = Artist.Sandara_Tang
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Below the Mines",
                StageNumber = 4,
                SlugIncludesOppositeTitle = true,
                OppositeTitle = "Sheltered Rocks",
                Id = "51223bd0-ffd1-11df-a976-0801212c9002",
                CardType = CardType.Quest,
                EncounterSet = "Foundations of Stone",
                Quantity = 1,
                QuestPoints = 11,
                FlavorText = "The river has deposited you at...",
                OppositeText = "When Revealed: Create your own staging area. Reveal 2 cards from the encounter deck and add them to your staging area.\r\nForced: After the 11th progress token is placed on Sheltered Rocks, join another player at the beginning of the travel phase. If you cannot join another player, all players continue to stage 5 together.",
                Number = 114,
                Artist = Artist.Cristi_Balanescu,
                OppositeArtist = Artist.David_Lecossu,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns }
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Below the Mines",
                StageNumber = 4,
                SlugIncludesOppositeTitle = true,
                OppositeTitle = "The Endless Caves",
                Id = "51223bd0-ffd1-11df-a976-0801212c9004",
                CardType = CardType.Quest,
                EncounterSet = "Foundations of Stone",
                Quantity = 1,
                QuestPoints = 17,
                FlavorText = "The river has deposited you at...",
                OppositeText = "When Revealed: Create your own staging area. Discard all resources from your heroes.\r\nForced: After the 17th progress token is placed on The Endless Caves, join another player at the beginning of the travel phase. If you cannot join another player, all players continue on to stage 5 together.",
                Number = 115,
                Artist = Artist.Cristi_Balanescu,
                OppositeArtist = Artist.Cristi_Balanescu,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns }
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Below the Mines",
                StageNumber = 4,
                SlugIncludesOppositeTitle = true,
                OppositeTitle = "The Shivering Bank",
                Id = "51223bd0-ffd1-11df-a976-0801212c9006",
                CardType = CardType.Quest,
                EncounterSet = "Foundations of Stone",
                Quantity = 1,
                QuestPoints = 7,
                FlavorText = "The river has deposited you at...",
                OppositeText = "When Revealed: Create your own staging area. Discard your hand. Reveal 2 cards from the encounter deck and add them to your staging area.\r\nForced: After the 7th progress token is placed on The Shivering Bank, join another player at the beginning of the travel phase. If you cannot join another player, all players continue on to stage 5 together.",
                Number = 116,
                Artist = Artist.Cristi_Balanescu,
                OppositeArtist = Artist.Cristi_Balanescu,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns }
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Below the Mines",
                StageNumber = 4,
                SlugIncludesOppositeTitle = true,
                OppositeTitle = "Old One Lair",
                Id = "51223bd0-ffd1-11df-a976-0801212c9008",
                CardType = CardType.Quest,
                EncounterSet = "Foundations of Stone",
                Quantity = 1,
                QuestPoints = 5,
                FlavorText = "The river has deposited you at...",
                OppositeText = "When Revealed: Create you own staging area. Reveal 4 cards from the encounter deck and add them to your staging area.\r\nForced: After the 5th progress token is placed on Old One Lair, join another player at the beginning of the travel phase. If you cannot join another player, all players continue on to stage 5 together.",
                Number = 117,
                Artist = Artist.Cristi_Balanescu,
                OppositeArtist = Artist.Cristi_Balanescu,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns }
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Daeron's Runes",
                Id = "51223bd0-ffd1-11df-a976-0801212c9010",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Action: Draw 2 cards. Then, discard 1 card from your hand.",
                FlavorText = "\"These are Daeron's Runes, such as were used of old in Moria...\"\r\n-Gandalf, The Fellowship of the Ring",
                Number = 108,
                Artist = Artist.Carolina_Eade
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Deep Deep Dark",
                Id = "51223bd0-ffd1-11df-a976-0801212c9011",
                CardType = CardType.Treachery,
                EncounterSet = "Foundations of Stone",
                Quantity = 4,
                Text = "When Revealed: Attach 1 card from the top of the first player's deck to each Nameless enemy in play, if able.",
                Shadow = "Shadow: If attacking enemy is Nameless, the defending player must discard his hand.",
                HtmlTemplate = "<p>{keyword:Doomed 1.} {keyword:Surge.}</p><p><b>When Revealed:</b> Attach 1 card from the top of the first player's deck to each {trait:Nameless.@Nameless} enemy in play, if able.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If attacking enemy is {trait:Nameless.@Nameless}, the defending player must discard his hand.</p>",
                Keywords = new List<string>() { "Doomed 1.", " Surge." },
                Number = 123,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Drowned Treasury",
                Id = "51223bd0-ffd1-11df-a976-0801212c9012",
                CardType = CardType.Location,
                EncounterSet = "Foundations of Stone",
                Traits = new List<string>() { "Underground.", " Underwater." },
                Quantity = 3,
                Text = "If Drowned Treasury is the active location at the end of the quest phase, each player must discard 1 character he controls.\r\nResponse: After Drowned Treasury leaves play as an explored location, each player may draw 2 cards or claim 1 objective in play.",
                HtmlTemplate = "<p>If {self} is the active location at the end of the quest phase, each player must discard 1 character he controls.</p><p><b>Response:</b> After {self} leaves play as an explored location, each player may draw 2 cards or claim 1 objective in play.</p>",
                Threat = 2,
                QuestPoints = 3,
                Number = 121,
                Artist = Artist.Carolina_Eade
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Durin's Axe",
                Id = "51223bd0-ffd1-11df-a976-0801212c9013",
                CardType = CardType.Objective,
                EncounterSet = "Foundations of Stone",
                Traits = new List<string>() { "Weapon.", " Artifact." },
                Quantity = 1,
                IsUnique = true,
                Text = "Attached hero gets +3 Attack. If attached hero is a Dwarf, it gets +1 Willpower.\r\n\r\nAction: Exhaust a hero to claim this objective. Then, attach Durin's Axe to that hero as an attachment.",
                Keywords = new List<string>() { "Surge.", " Restricted." },
                Number = 119,
                Artist = Artist.Stephen_M_Mabee
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Durin's Helm",
                Id = "51223bd0-ffd1-11df-a976-0801212c9014",
                CardType = CardType.Objective,
                EncounterSet = "Foundations of Stone",
                Traits = new List<string>() { "Armor.", " Artifact." },
                Quantity = 1,
                IsUnique = true,
                Text = "Attached hero gets +1 Defense. If attached hero is a Dwarf, it gets +2 hit points.\r\n\r\nAction: Exhaust a hero to claim this objective. Then, attach Durin's Helm to that hero as an attachment.",
                Keywords = new List<string>() { "Surge." },
                Number = 120,
                Artist = Artist.Stephen_M_Mabee
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Elder Nameless Thing",
                Id = "51223bd0-ffd1-11df-a976-0801212c9015",
                CardType = CardType.Enemy,
                EncounterSet = "Foundations of Stone",
                Traits = new List<string>() { "Nameless." },
                Quantity = 3,
                EasyModeQuantity = 1,
                EngagementCost = 40,
                Attack = 0,
                IsVariableAttack = true,
                Defense = 4,
                HitPoints = 0,
                IsVariableHitPoints = true,
                Text = "Forced: After Elder ~Nameless Thing engages a player, attach the top 3 cards of that player's deck to it.\r\nX is the printed cost of all attached cards on this card. If there are no cards attached, X is 4.",
                Threat = 4,
                VictoryPoints = 3,
                Number = 126,
                Artist = Artist.Allison_Theus
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Glorfindel",
                Id = "51223bd0-ffd1-11df-a976-0801212c9016",
                CardType = CardType.Hero,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Noldor.", " Noble.", " Warrior." },
                Quantity = 1,
                ThreatCost = 5,
                IsUnique = true,
                Attack = 3,
                Defense = 1,
                Willpower = 3,
                HitPoints = 5,
                Text = "Forced: After Glorfindel exhausts to commit to a quest, raise your threat by 1.",
                FlavorText = "Glorfindel was tall and straight; his hair was of shining gold, his face fair and young and fearless and full of joy; his eyes were bright and keen, and has voice like music; on his brow sat wisdom, and in his hand was strength.\r\n-The Fellowship of the Ring",
                Number = 101,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Healing Herbs",
                Id = "51223bd0-ffd1-11df-a976-0801212c9017",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Attach to a Lore hero.\r\nAction: Discard Healing Herbs and exhaust attached hero to heal all damage on 1 character.",
                Number = 109,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Heavy Stroke",
                Id = "51223bd0-ffd1-11df-a976-0801212c9018",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Response: After a Dwarf deals X damage to an enemy during combat, deal an additional X damage to that enemy. (Limit once per phase.)",
                FlavorText = "\"Beside them Gimli stood with his stout legs apart, wielding his dwarf-axe.\" -The Fellowship of the Ring",
                Number = 105,
                Artist = Artist.Adam_Schumpert
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Imladris Stargazer",
                Id = "51223bd0-ffd1-11df-a976-0801212c9019",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Noldor." },
                Quantity = 3,
                ResourceCost = 2,
                Attack = 0,
                Defense = 1,
                Willpower = 0,
                HitPoints = 1,
                Text = "Action: Exhaust Imladris Stargazer to choose a player. That player looks at the top 5 cards of his deck and then returns them to the top of his deck in any order.",
                Number = 106,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Light of Valinor",
                Id = "51223bd0-ffd1-11df-a976-0801212c9020",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Condition." },
                Quantity = 3,
                ResourceCost = 1,
                IsUnique = true,
                Text = "Attach to a Noldor or Silvan hero.\r\nAttached hero does not exhaust to commit to a quest.",
                FlavorText = "\"... those who have dwelt in the blassed realm live at once in both worlds, and against both the Seen and Unseen they have great power.\"\r\n-Gandalf, The Fellowship of the Ring",
                HtmlTemplate = "<p>Attach to a {traits-hero:Noldor,Silvan}.</p><p>Attached hero does not exhaust to commit to a quest.</p><p class='flavor-text'>&quot;... those who have dwelt in the blassed realm live at once in both worlds, and against both the Seen and Unseen they have great power.&quot;<br>&ndash;Gandalf, The Fellowship of the Ring</i></p>",
                Number = 107,
                Artist = Artist.Lin_Bo
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Longbeard Elder",
                Id = "51223bd0-ffd1-11df-a976-0801212c9021",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 3,
                ResourceCost = 3,
                Attack = 1,
                Defense = 1,
                Willpower = 2,
                HitPoints = 2,
                Text = "Response: After Longbeard Elder commits to a quest, look at the top card of the encounter deck. If that card is a location, place 1 progress token on the current quest. Otherwise, Longbeard Elder gets -1 Willpower until the end of the phase.",
                Number = 102,
                Artist = Artist.Eric_Braddock
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Lost and Alone",
                Id = "51223bd0-ffd1-11df-a976-0801212c9022",
                CardType = CardType.Treachery,
                EncounterSet = "Foundations of Stone",
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Each player chooses and shuffles a hero he controls into his deck. When he draws that hero, he puts it into play.",
                Shadow = "Shadow: If attacking enemy is Nameless, the defending player must discard his hand.",
                HtmlTemplate = "<p><b>When Revealed:</b> Each player chooses and shuffles a hero he controls into his deck. When he draws that hero, he puts it into play.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If attacking enemy is {trait:Nameless.@Nameless}, the defending player must discard his hand.</p>",
                Number = 124,
                Artist = Artist.David_Chen
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Mithril Lode",
                Id = "51223bd0-ffd1-11df-a976-0801212c9023",
                CardType = CardType.Location,
                EncounterSet = "Foundations of Stone",
                Traits = new List<string>() { "Underground." },
                Quantity = 1,
                Text = "While Mithril Lode is the active location, it gains: 'Refresh Action: Exhaust a character you control to place X progress tokens on the current quest card, bypassing any active location. X is the exhausted character's Willpower. (Limit once per round.)'",
                Keywords = new List<string>() { "Doomed 1." },
                HtmlTemplate = "<p>{keyword:Doomed 1.}</p><p>While {self} is the active location, it gains: <blockquote><b>Refresh Action:</b> Exhaust a character you control to place X progress tokens on the current quest card, bypassing any active location. X is the exhausted character's {Willpower}. (Limit once per round.)</blockquote></p>",
                Threat = 2,
                QuestPoints = 5,
                Number = 122,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Moria Bats",
                Id = "51223bd0-ffd1-11df-a976-0801212c9024",
                CardType = CardType.Enemy,
                EncounterSet = "Foundations of Stone",
                Traits = new List<string>() { "Creature." },
                Quantity = 4,
                EngagementCost = 33,
                Attack = 1,
                Defense = 2,
                HitPoints = 1,
                Text = "Only characters with ranged can attack or defend against Moria Bats.\r\n\r\nWhile Moria Bats is engaged with a player, it gets +1 Attack for each other enemy engaged with that player.",
                Threat = 1,
                Number = 127,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Nameless Thing",
                Id = "51223bd0-ffd1-11df-a976-0801212c9025",
                CardType = CardType.Enemy,
                EncounterSet = "Foundations of Stone",
                Traits = new List<string>() { "Nameless." },
                Quantity = 5,
                EasyModeQuantity = 3,
                EngagementCost = 27,
                Attack = 0,
                IsVariableAttack = true,
                Defense = 3,
                HitPoints = 0,
                IsVariableHitPoints = true,
                Text = "Forced: After ~Nameless Thing engages a player, attach the top 2 cards of that player's deck to it.\r\nX is the printed cost of all attached cards on this card. If there are no cards attached, X is 3.",
                Threat = 3,
                VictoryPoints = 1,
                Number = 125,
                Artist = Artist.Timo_Karhula
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Out of the Depths",
                StageNumber = 5,
                Id = "51223bd0-ffd1-11df-a976-0801212c9026",
                CardType = CardType.Quest,
                EncounterSet = "Foundations of Stone",
                Quantity = 1,
                QuestPoints = 11,
                FlavorText = "The shaft shoots upwards, the glimmering lines of mithril illuminating your way out of the depths of the mountain. The makeshift ladder is narrow, but you cannot linger in the realm of those things of darkness, who gnaw at the roots of the world.",
                OppositeText = "When Revealed: Reveal 1 card from the encounter deck per player, and add it to the staging area.\r\nEach player cannot commit more allies to the quest than the number of heroes he is also committing to the quest.\r\nIf the players defeat this stage, they have won the game.",
                Number = 118,
                Artist = Artist.Anthony_Palumbo,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns }
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Path of Need",
                Id = "51223bd0-ffd1-11df-a976-0801212c9028",
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Condition." },
                Quantity = 3,
                ResourceCost = 4,
                Text = "Limit 1 per deck. Attach to a location.\r\nHeroes do not exhaust to attack, defend, or commit to a quest while attached location is the active location.",
                FlavorText = "\"However it may prove, one must tread the path that need chooses!\"\r\n-Gandalf, The Fellowship of the Ring",
                Number = 103,
                Artist = Artist.Magali_Villeneuve,
                MaxPerDeck = 1
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "The Dripping Walls",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801212c9029",
                CardType = CardType.Quest,
                EncounterSet = "Foundations of Stone",
                Quantity = 1,
                QuestPoints = 9,
                Setup = "t",
                Text = "Setup: Place the Foundations of Stone encounter set aside, out of play. The first player attaches Cave Torch to a hero of his choice.",
                FlavorText = "Your journey has led to a decrepit portion of the mines, untouched by Dwarven pick for many a year. The air grows thick with moisture, and the walls almost appear to be weeping.",
                HtmlTemplate = "<p class='flavor-text'>Your journey has led to a decrepit portion of the mines, untouched by Dwarven pick for many a year. The air grows thick with moisture, and the walls almost appear to be weeping.</p><p><b>Setup:</b> Place the <a title='Foundations of Stone Encounter Set' href='/Cards/Search?CardType=Encounter&EncounterSet=Foundations+of+Stone' target='_blank'>Foundations of Stone</a> encounter set aside, out of play. The first player attaches <a title='Cave Torch (Khazad-dûm)' href='/Cards/Details/Cave-Torch-KD' target='_blank'>Cave Torch</a> to a hero of his choice.</p>",
                OppositeFlavorText = "A low rumble sounds from below. There are a variety of underground waterways in Moria, but they should not be disturbed.",
                OppositeText = "When Revealed: Reveal 1 card from the encounter deck per player, and add it to the staging area.",
                HtmlTemplate2 = "<p class='flavor-text'>A low rumble sounds from below. There are a variety of underground waterways in Moria, but they should not be disturbed.</p><p><b>When Revealed:</b> Reveal 1 card from the encounter deck per player, and add it to the staging area.</p>",
                Number = 111,
                Artist = Artist.Ilich_Henriquez,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns }
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "The Water's Edge",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-0801212c9031",
                CardType = CardType.Quest,
                EncounterSet = "Foundations of Stone",
                Quantity = 1,
                QuestPoints = 12,
                FlavorText = "Small rivers cut their way across your path. Some are not much more than a trickle, and recent looking too. Another rumble shakes the walls, this time it seems to be above you.",
                OppositeText = "Forced: After a player commits characters to the quest, he must discard the top 2 cards of his deck.",
                Number = 112,
                Artist = Artist.Trudi_Castle,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns }
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Trollshaw Scout",
                Id = "51223bd0-ffd1-11df-a976-0801212c9033",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Noldor.", " Scout." },
                Quantity = 3,
                ResourceCost = 2,
                Attack = 2,
                Defense = 1,
                Willpower = 0,
                HitPoints = 2,
                Text = "Trollshaw Scout does not exhaust to attack.Forced: After Trollshaw Scout attacks, either discard it from play or discard 1 card from your hand.",
                Keywords = new List<string>() { "Ranged." },
                HtmlTemplate = "<p>{keyword:Ranged.}</p><p>{self} does not exhaust to attack.</p><p><b>Forced:</b> After {self} attacks, either discard it from play or discard 1 card from your hand.</p>",
                Number = 104,
                Artist = Artist.Anna_Steinbauer
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Washed Away!",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-0801212c9034",
                CardType = CardType.Quest,
                EncounterSet = "Foundations of Stone",
                Quantity = 1,
                FlavorText = "With a groan the ground crumbles under your feet, the entire section of the tunnel giving way to a deep darkness and the rush of water. There is a feeling of weightlessness, followed by the icy wet clutches of an underground river.",
                QuestPoints = 0,
                OppositeText = "When Revealed: Discard all Item, Armor, Weapon, Light cards and all encounter deck cards from play, Shuffle all enemy and treachery cards in the encounter discard pile together with the Foundations of Stone encounter set. This deck becomes the new encounter deck. remove all other encounter deck cards from the game. Then, starting with the first player, each player draws a random stage 4 quest card. Remove all other stage 4 quest cards from the game.",
                Number = 113,
                Artist = Artist.Marco_Caradonna,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.GoblinsOfTheDeep, EncounterSet.HazardsOfThePit, EncounterSet.TwistsAndTurns }
            });
        }
    }
}
