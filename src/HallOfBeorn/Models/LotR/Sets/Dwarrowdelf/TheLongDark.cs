using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets.Dwarrowdelf
{
    public class TheLongDark : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Long Dark";
            Abbreviation = "TLD";
            Number = 12;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dwarrowdelf";

            Cards.Add(new LotRCard() {
                
                Title = "Abandoned Mine",
                Id = "51223bd0-ffd1-11df-a976-0801211c9001",
                CardType = CardType.Location,
                EncounterSet = "The Long Dark",
                Traits = new List<string>() { "Underground.", " Dark." },
                Quantity = 3,
                Text = "Lost: Return the top 2 Goblin enemies in the encounter discard pile to the staging area, if able.",
                FlavorText = "\"The wealth of Moria was not in gold and jewels, the toys of the Dwarves; nor in iron, their servant.\"\r\n-Gandalf, The Fellowship of the Ring",
                PassValue = true,
                Threat = 3,
                QuestPoints = 3,
                VictoryPoints = 0,
                CardNumber = 89,
                Artist = Artist.Paolo_Puggioni
            });
            Cards.Add(new LotRCard() {
                
                Title = "Cave Spider",
                Id = "51223bd0-ffd1-11df-a976-0801211c9002",
                CardType = CardType.Enemy,
                EncounterSet = "The Long Dark",
                Traits = new List<string>() { "Spider.", " Creature." },
                Quantity = 3,
                EngagementCost = 31,
                Attack = 2,
                Defense = 1,
                HitPoints = 4,
                Text = "When Revealed: The first player draws 1 card. Then, that player must choose and discard 4 cards from his hand, if able.\r\nForced: After ~Cave ~Spider engages a player, that player must choose and discard 1 card from his hand, if able.",
                Threat = 3,
                CardNumber = 97,
                Artist = Artist.Allison_Theus
            });
            Cards.Add(new LotRCard() {
                
                Title = "Continuing Eastward",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-0801211c9003",
                CardType = CardType.Quest,
                EncounterSet = "The Long Dark",
                Quantity = 1,
                QuestPoints = 17,
                FlavorText = "Time carries no weight in the darkness, and the hours creep by with no end in sight. The number of Orcs in the mines increase as you head toward the East-gate, but there appears to be little real organization within their ranks. You press onward!",
                OppositeText =
"When Revealed: The first player makes a locate test. If this test is failed, reveal cards from the encounter deck equal to the number of players in the game and add them to the staging area. Then, trigger all \"Lost:\" effects in play.\r\n\r\nIf the players quest unsuccessfully, trigger all \"Lost:\" effects in play.\r\n\r\nIf the players defeat this stage, they have won the game.",
                CardNumber = 87,
                Artist = Artist.David_A_Nash,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DeepsOfMoria, EncounterSet.TwistsAndTurns }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Durin's Greaves",
                Id = "51223bd0-ffd1-11df-a976-0801211c9005",
                CardType = CardType.Objective,
                EncounterSet = "The Long Dark",
                Traits = new List<string>() { "Artifact.", " Armour." },
                Quantity = 1,
                IsUnique = true,
                Text = 
@"When Revealed: The first player attaches Durin's Greaves to a hero of his choice as an attachment.
                
Attached hero gets +1 Defense.",
                CardNumber = 88,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Dwarven Forge",
                Id = "51223bd0-ffd1-11df-a976-0801211c9006",
                CardType = CardType.Location,
                EncounterSet = "The Long Dark",
                Traits = new List<string>() { "Underground.", " Dark." },
                Quantity = 2,
                Text = "Lost: Each player must choose and discard 1 card from his hand.",
                FlavorText = "There hammer on the anvil smote,\r\nThere chisel clove, and graver wrote;\r\nThere forged was blade, and bount was hilt...\r\n-The Fellowship of the Ring",
                PassValue = true,
                Threat = 2,
                QuestPoints = 4,
                VictoryPoints = 0,
                CardNumber = 90,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard() {
                
                Title = "Erebor Battle Master",
                Id = "51223bd0-ffd1-11df-a976-0801211c9007",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Dwarf.", " Warrior." },
                Quantity = 3,
                ResourceCost = 3,
                Attack = 1,
                Defense = 1,
                Willpower = 0,
                HitPoints = 2,
                Text = "Erebor Battle Master gets +1 Attack for each other Dwarf ally you control.",
                CardNumber = 79,
                Artist = Artist.Rafal_Hrynkiewicz,
                HasErrata = true
            });
            Cards.Add(new LotRCard() {
                
                Title = "Erestor",
                Id = "51223bd0-ffd1-11df-a976-0801211c9008",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Noldor." },
                Quantity = 3,
                ResourceCost = 4,
                IsUnique = true,
                Attack = 0,
                Defense = 1,
                Willpower = 2,
                HitPoints = 3,
                Text = "Action: Choose and discard 1 card from your hand to draw 1 card. (Limit once per round.)",
                FlavorText = "Beside Glorfindel there were several other counsellors of Elrond's household, of whom Erestor was the chief...\r\n-The Fellowship of the Ring",
                CardNumber = 77,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ever My Heart Rises",
                Id = "51223bd0-ffd1-11df-a976-0801211c9009",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Condition." },
                Quantity = 3,
                ResourceCost = 0,
                Text = "Attach to a Dwarf character.\r\nResponse: After you travel to a Mountain or Underground location, ready attached character and reduce your threat by 1.",
                FlavorText = "'This is more to my liking,' said the dwarf, stomping on the stones. 'Ever my heart rises as we draw near the mountains.' -The Two Towers",
                //HtmlTemplate = "<p>Attach a {trait-character:Dwarf.@Dwarf}.</p><p><b>Response:</b> After you travel to a {trait:Mountain.@Mountain} or {trait:Underground.@Underground} location, ready attached character and reduce your threat by 1</p><p class='flavor-text'>'This is more to my liking,' said the dwarf, stomping on the stones. 'Ever my heart rises as we draw near the mountains.'<br>&ndash;The Two Towers</p>",
                CardNumber = 82,
                Artist = Artist.Carolina_Eade
            });
            Cards.Add(new LotRCard() {
                
                Title = "Fatigue",
                Id = "51223bd0-ffd1-11df-a976-0801211c9010",
                CardType = CardType.Treachery,
                EncounterSet = "The Long Dark",
                Quantity = 2,
                Text = "When Revealed: Each player must exhaust 1 character he controls, if able. Then, if any player controls no unexhausted characters, Fatigue gains surge.",
                Shadow = "Shadow: The defending player must exhaust 1 character he controls, if able.",
                CardNumber = 93,
                Artist = Artist.Charles_Urbach
            });
            Cards.Add(new LotRCard() {
                
                Title = "Foul Air",
                Id = "51223bd0-ffd1-11df-a976-0801211c9011",
                CardType = CardType.Treachery,
                EncounterSet = "The Long Dark",
                Quantity = 4,
                EasyModeQuantity = 1,
                Text = "When Revealed: The first player makes a locate test. If this test is failed, deal 2 damage to all characters and trigger all 'Lost:' effects in play.",
                FlavorText = "\"...I do not like the smell of the left-hand way: there is a foul air down there, or I am not guide.\"\r\n-Gandalf, The Fellowship of the Ring",
                PassValue = true,
                CardNumber = 94,
                Artist = Artist.Jasper_Sandner
            });
            Cards.Add(new LotRCard() {
                
                Title = "Fresh Tracks",
                Id = "51223bd0-ffd1-11df-a976-0801211c9012",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Response: After an enemy is added to the staging area, deal 1 damage to that enemy. Players ignore that enemy while making engagement checks this round.",
                CardNumber = 78,
                Artist = Artist.Garret_DeChellis
            });
            Cards.Add(new LotRCard() {
                
                Title = "Gathering Ground",
                Id = "51223bd0-ffd1-11df-a976-0801211c9013",
                CardType = CardType.Treachery,
                EncounterSet = "The Long Dark",
                Quantity = 1,
                EasyModeQuantity = 0,
                Text = "When Revealed: Attach this card to a location in the staging area with the highest combined threat and remaining quest points. (Counts as a Condition attachment with the text: 'Each enemy revealed from the encounter deck gains surge.')",
                PassValue = true,
                CardNumber = 95,
                Artist = Artist.Jason_Juta
            });
            Cards.Add(new LotRCard() {
                
                Title = "Goblin Sneak",
                Id = "51223bd0-ffd1-11df-a976-0801211c9014",
                CardType = CardType.Enemy,
                EncounterSet = "The Long Dark",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 4,
                EngagementCost = 15,
                Attack = 1,
                Defense = 1,
                HitPoints = 2,
                Text = "Forced: After Goblin Sneak engages a player, discard the top card of the encounter deck. If it is a treachery card, Goblin Sneak engages the next player, if able.",
                Shadow = "Shadow: Add Goblin Sneak to the staging area.",
                //HtmlTemplate = "<p><b>Forced:</b> After {self} engages a player, discard the top card of the encounter deck. If it is a treachery card, {self} engages the next player, if able.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Add {self} to the staging area.</p>",
                Threat = 2,
                CardNumber = 98,
                Artist = Artist.Timo_Karhula
            });
            Cards.Add(new LotRCard() {
                
                Title = "Goblin Warlord",
                Id = "51223bd0-ffd1-11df-a976-0801211c9015",
                CardType = CardType.Enemy,
                EncounterSet = "The Long Dark",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 1,
                EasyModeQuantity = 0,
                EngagementCost = 39,
                Attack = 3,
                Defense = 3,
                HitPoints = 5,
                Text = "Lost: Each player must choose and discard 1 ally he controls from play, if able.",
                Shadow = "Shadow: Trigger all 'Lost:' effects in play.",
                //HtmlTemplate = "<p><b>Lost:</b> Each player must choose and discard 1 ally he controls from play, if able.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Trigger all <b>&quot;Lost:&quot;</b> effects in play.</p>",
                Threat = 4,
                CardNumber = 99,
                Artist = Artist.Matthew_Starbuck
            });
            Cards.Add(new LotRCard() {
                Title = "Háma",
                Id = "51223bd0-ffd1-11df-a976-0801211c9016",
                CardType = CardType.Hero,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Rohan.", " Warrior." },
                Quantity = 1,
                ThreatCost = 9,
                IsUnique = true,
                Attack = 3,
                Defense = 1,
                Willpower = 1,
                HitPoints = 4,
                Text = "Response: After Hama is declared as an attacker, return a Tactics event from your discard pile to your hand. Then, choose and discard 1 card from your hand. (Limit 3 times per game for the group.)",
                HtmlTemplate = "<p><b>Response:</b> After {self} is declared as an attacker, return a {sphere-event:Tactics} from your discard pile to your hand. Then, choose and discard 1 card from your hand.</p><p class='flavor-text'>&quot;Yet in doubt a man of worth will trust to his own wisdom.&quot; &ndash;The Two Towers</p>",
                CardNumber = 76,
                Artist = Artist.Magali_Villeneuve,
                HasErrata = true
            });
            Cards.Add(new LotRCard() {
                Title = "Journey in the Black Pit",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801211c9017",
                CardType = CardType.Quest,
                EncounterSet = "The Long Dark",
                Quantity = 1,
                QuestPoints = 13,
                Text = "Setup: The first player attaches ~Cave Torch to a hero of his choice.",
                OppositeText = "When Revealed: Discard cards from the top of the encounter deck until you discard X locations, where X is one less than the number of players in the game (minimum 1). Add those locations to the staging area, and shuffle the other discarded cards back into the encounter deck.\r\nEach location gets +1 threat. If the players quest unsuccessfully, trigger all \"Lost:\" effects in play.",
                FlavorText = "Your party is scouting the Mines of Moria, searching for signs of Orcs. Dark tunnels and twisting passages spread out in all directions, a labyrinthine maze that you could wander in forever if you take the wrong path.",
                CardNumber = 86,
                Artist = Artist.David_A_Nash,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DeepsOfMoria, EncounterSet.TwistsAndTurns }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Love of Tales",
                Id = "51223bd0-ffd1-11df-a976-0801211c9019",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Condition." },
                Quantity = 3,
                ResourceCost = 0,
                Text = "Attach to a Lore hero. Limit 1 per hero.\r\nResponse: After a Song card is played, exhaust Love of Tales to add 1 resource to attached hero's resource pool.",
                FlavorText = "\"I listened because I couldn't help myself, if you know what I mean. Lor bless me, sir, but I do love tales of that sort.\"\r\n-Sam Gamgee, The Fellowship of the Ring",
                CardNumber = 85,
                Artist = Artist.Winona_Nelson,
                HasErrata = true
            });
            Cards.Add(new LotRCard() {
                
                Title = "Out of Sight",
                Id = "51223bd0-ffd1-11df-a976-0801211c9020",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                Quantity = 3,
                ResourceCost = 5,
                Text = "Action: Enemies engaged with you cannot attack you this phase.",
                Keywords = new List<string>() { "Secrecy 3." },
                CardNumber = 81,
                Artist = Artist.Ilich_Henriquez,
                HasErrata = true
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ring Mail",
                Id = "51223bd0-ffd1-11df-a976-0801211c9021",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Item.", " Armor." },
                Quantity = 3,
                ResourceCost = 2,
                Text = "Attach to a Dwarf or Hobbit character.\r\nAttached character gets +1 hit point and +1 Defense.",
                FlavorText = "\"And all the arrows of all the hunters in the world would be in vain...\r\n-Gimli, The Fellowship of the Ring",
                HtmlTemplate = "<p>Attach to a {traits-character:Dwarf,Hobbit}. {keyword:Restricted.}</p><p>Attached character gets +1 hit point and +1 {Defense}.</p><p class='flavor-text'>&quot;And all the arrows of all the hunters in the world would be in vain...&quot;<br>&ndash;Gimli, The Fellowship of the Ring</p>",
                Keywords = new List<string>() { "Restricted." },
                CardNumber = 80,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                Title = "Rock Adder",
                Id = "51223bd0-ffd1-11df-a976-0801211c9022",
                
                CardType = CardType.Enemy,
                EncounterSet = "The Long Dark",
                Traits = new List<string>() { "Creature." },
                Quantity = 3,
                EngagementCost = 20,
                Attack = 3,
                Defense = 0,
                HitPoints = 3,
                Text = "Rock Adder cannot be attacked unless it has dealt at least 1 damage this round.",
                Shadow = "Shadow: If this attack is undefended, the defending player must discard 1 character he controls from play.",
                Threat = 1,
                CardNumber = 100,
                Artist = Artist.Allison_Theus
            });
            Cards.Add(new LotRCard() {
                
                Title = "Silent Caverns",
                Id = "51223bd0-ffd1-11df-a976-0801211c9023",
                CardType = CardType.Location,
                EncounterSet = "The Long Dark",
                Traits = new List<string>() { "Underground." },
                Quantity = 2,
                Text = "Lost: Exhaust all characters.",
                PassValue = true,
                Threat = 1,
                QuestPoints = 3,
                VictoryPoints = 0,
                CardNumber = 91,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Twisting Passage",
                Id = "51223bd0-ffd1-11df-a976-0801211c9024",
                CardType = CardType.Location,
                EncounterSet = "The Long Dark",
                Traits = new List<string>() { "Underground.", " Dark." },
                Quantity = 2,
                Text = "Forced: Before placing progress tokens on Twisting Passage, the first player must make a locate test. If this test is failed, do not place any progress tokens on Twisting Passage and trigger all 'Lost:' effects in play.",
                HtmlTemplate = "<p><b>Forced:</b> Before placing progress tokens on {self}, the first player must make a locate test. If this test is failed, do not place any progress tokens on {self} and trigger all <b>&quot;Lost:&quot;</b> effects in play.</p>{pass}",
                PassValue = true,
                Threat = 3,
                QuestPoints = 5,
                VictoryPoints = 0,
                CardNumber = 92,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new LotRCard() {
                
                Title = "Vast and Intricate",
                Id = "51223bd0-ffd1-11df-a976-0801211c9025",
                CardType = CardType.Treachery,
                EncounterSet = "The Long Dark",
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "When Revealed: The first player makes a locate test. If this test is failed, raise each player's threat by 7, remove all progress tokens from play, and trigger all 'Lost:' effects in play.",
                FlavorText = "The Mines of Moria were vast and intricate beyond the imagination of Gimli, Glóin's son, dwarf of the mountain-race though he was.\r\n-The Fellowship of the Ring",
                HtmlTemplate = "<p><b>When Revealed:</b> The first player makes a locate test. If this test is failed, raise each player's threat by 7, remove all progress tokens from play, and trigger all <b>&quot;Lost:&quot;</b> effects in play.</p><p class='flavor-text'>The Mines of Moria were vast and intricate beyond the imagination of Gimli, Glóin's son, dwarf of the mountain-race though he was.<br>&ndash;The Fellowship of the Ring</p>",
                CardNumber = 96,
                Artist = Artist.Eric_Braddock
            });
            Cards.Add(new LotRCard() {
                
                Title = "Warden of Healing",
                Id = "51223bd0-ffd1-11df-a976-0801211c9026",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Gondor.", " Healer." },
                Quantity = 3,
                ResourceCost = 2,
                Attack = 0,
                Defense = 1,
                Willpower = 1,
                HitPoints = 1,
                Text = "Action: Exhaust Warden of Healing to heal 1 damage on up to 2 different characters. Then, you may pay 2 Lore resources to ready Warden of Healing.",
                FlavorText = "\"But for long years we healers have only sought to patch the rents made by the men of swords.\" -Return of the King",
                CardNumber = 83,
                Artist = Artist.Paolo_Puggioni
            });
            Cards.Add(new LotRCard() {
                
                Title = "Word of Command",
                Id = "51223bd0-ffd1-11df-a976-0801211c9027",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Action: Exhaust an Istari character to search your deck for 1 card and add it to your hand. Shuffle your deck.",
                FlavorText = "\"Picking up a faggot he held it aloft for a moment, and then with a word of command, naur an edraith ammen! he thrust the end of his staff into the midst of it. At once a great spout of green and blue flame sprang out, and the wood flared and sputtered.\" -The Fellowship of the Ring",
                CardNumber = 84,
                Artist = Artist.Magali_Villeneuve
            });
        }
    }
}
