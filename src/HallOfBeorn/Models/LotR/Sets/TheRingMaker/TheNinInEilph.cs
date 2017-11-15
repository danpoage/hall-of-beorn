using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TheNinInEilph : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Nîn-in-Eilph";
            AlternateName = "Nin-in-Eilph";
            Abbreviation = "NiE";
            Number = 26;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";

            Cards.Add(new LotRCard()
            {
                Title = "Mablung",
                Id = "6DF2AB16-492E-4C7F-B095-B7D46138AB11",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Models.LotR.Sphere.Tactics,
                ThreatCost = 10,
                Willpower = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Gondor.", "Ranger." },
                Text = "Response: After you engage an enemy, add 1 resource to Mablung's resource pool. (Limit once per phase.)",
                FlavorText = "But the Captains of the West were well warned by their scouts, skilled men from Henneth Annûn led by Mablung...\r\n-The Return of the King",
                CardNumber = 84,
                Quantity = 1,
                Artist = Artist.Sebastian_Giacobino
            });
            Cards.Add(new LotRCard()
            {
                Title = "Follow Me!",
                Id = "89EE0935-04C9-4FE7-9B6F-4C4D7893ECCE",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Text = "Action: Take control of the first player token and draw 1 card.",
                FlavorText = "\"Come! I will lead you now!\"\r\n-Aragorn, The Fellowship of the Ring",
                CardNumber = 85,
                Quantity = 3,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard()
            {
                Title = "Tighten Our Belts",
                Id = "FCF1D840-96A9-48D4-9D18-04E95664FE2E",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 0,
                Text = "Refresh Action: Choose a player. Each hero that player controls that did not spend any resources this round gains 1 resource. Only 1 copy of Tighten Our Belts can be played by the players each round.",
                FlavorText = "There was nothing now to be done but to tighten the belts round their empty stomachs, and hoist their empty sacks and packs... -The Hobbit",
                CardNumber = 86,
                Quantity = 3,
                Artist = Artist.Matt_Stawicki
            });
            Cards.Add(new LotRCard()
            {
                Title = "Galadhon Archer",
                Id = "72F9C304-0C9C-4A2E-93F3-F002159C2807",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                ResourceCost = 2,
                Willpower = 0,
                Attack = 2,
                Defense = 0,
                HitPoints = 1,
                Traits = new List<string> { "Silvan.", "Warrior." },
                Keywords = new List<string> { "Ranged." },
                Text = "Response: After Galadhon Archer enters play, deal 1 damage to an enemy not engaged with you.",
                FlavorText = "\"...they say that you breathe so loud that they could shoot you in the dark.\" -Legolas, The Fellowship of the Ring",
                CardNumber = 87,
                Quantity = 3,
                Artist = Artist.Sara_K_Diesel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Bow of the Galadhrim",
                Id = "8C207E9C-517A-422B-901A-7EC8550A0FA7",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Traits = new List<string> { "Item.", "Weapon." },
                Keywords = new List<string> { "Restricted." },
                Text = "Attach to a Silvan character with the ranged keyword.\r\nAttached character gets +1 Attack. (+2 Attack instead if attacking an enemy not engaged with you.)",
                FlavorText = "...longer and stronger than the bows of Mirkwood, and strung with a string of elf-hair. -The Fellowship of the Ring",
                CardNumber = 88,
                Quantity = 3,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new LotRCard()
            {
                Title = "Celduin Traveler",
                Id = "8FE9C322-FA5E-41D1-9152-F866F87710A2",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                ResourceCost = 3,
                Willpower = 2,
                Attack = 0,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string> { "Dale.", "Scout." },
                Keywords = new List<string> { "Secrecy 2." },
                Text = "Response: After Celduin Traveler enters play, look at the top card of the encounter deck. If it is a location, you may discard it.",
                FlavorText = "In two days going they rowed right up the Long Lake and passed out into the River Running... -The Hobbit",
                CardNumber = 89,
                Quantity = 3,
                Artist = Artist.Melanie_Maier
            });
            Cards.Add(new LotRCard()
            {
                Title = "Island Amid Perils",
                Id = "5B8E234E-FE99-43A2-B139-04EEC71DFE48",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 0,
                Text = "Action: Return a Silvan you control to your hand to reduce your threat by X where X is the printed cost of the ally returned to your hand.",
                FlavorText = "\"...we dare not by our own trust endanger our land. We live now upon an island amid many perils...\" \r\n-Haldir, The Fellowship of the Ring",
                CardNumber = 90,
                Quantity = 3,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                Title = "Mirkwood Pioneer",
                Id = "76653F75-E430-4A31-BA79-D35F1AE3B904",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 0,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string> { "Woodman." },
                Text = "You may give Mirkwood Pioneer doomed 1 when you play it from your hand. If you do it gains: \"Response: After you play Mirkwood Pioneer, choose a card in the staging area. Until the end of the round, the chosen card does not contribute its Threat.\"",
                CardNumber = 91,
                Quantity = 3,
                Artist = Artist.Melanie_Maier
            });
            Cards.Add(new LotRCard()
            {
                Title = "Wingfoot",
                Id = "3BF23B7E-44B9-4973-9C07-D288FDB24FAA",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Traits = new List<string> { "Title." },
                Text = "Attach to a Ranger hero.\r\nResponse: After attached hero commits to a quest, name enemy, location or treachery. If a card of the named type is revealed during this quest phase, exhaust Wingfoot to ready attached hero.",
                FlavorText = "\"Wingfoot I name you. This deed of the three friends should be sung in many a hall. Forty leagues and five you have measured ere the forth day is ended!\"\r\n-Éomer, The Two Towers",
                CardNumber = 92,
                Quantity = 3,
                Artist = Artist.Gabriel_Verdon,
                HasErrata = true
            });
            Cards.Add(new LotRCard()
            {
                Title = "Defender of the West",
                Id = "FA189ACD-3B81-4128-850D-F69DF9FDF6A4",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Models.LotR.Sphere.Neutral,
                ResourceCost = 1,
                Traits = new List<string> { "Title." },
                Text = "Attach to a non-objective unique ally in play.\r\nThe first player gains control of attached ally.\r\nDamage from undefended attacks against you may be assigned to attached ally.",
                FlavorText = "\"...if by life or death I can save you, I will.\"\r\n-Aragorn, The Fellowship of the Ring",
                CardNumber = 93,
                Quantity = 3,
                Artist = Artist.Romana_Kendelic
            });
            Cards.Add(new LotRCard()
            {
                Title = "Fleeing from Tharbad",
                Id = "F9BB1203-1880-466D-8D2C-0E5F965F0796",
                StageNumber = 1,
                CardType = CardType.Quest,
                QuestPoints = 0,
                OppositeText = "When Revealed: Advance to a random stage 2A.",
                OppositeFlavorText = "No traveller has entered the Nîn-in-Eilph for an age and there is no path through the shifting marshland. You must find your own way across the treacherous bog.",
                Text = "Setup: The first player takes control of Nalir. Set the Ancient Marsh-dweller aside, out of play. Each player searches the encounter deck for a different location and adds it to the staging area. Shuffle the encounter deck.",
                FlavorText = "You've entered the vast marshlands of the Nin-in-Eilph with Nalir in order to escape Bellach and his Orcs. Now, you must cross the swamp in order to reach Hollin on the other side.",
                EncounterSet = "The Nîn-in-Eilph",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WearyTravelers },
                CardNumber = 94,
                Quantity = 1,
                Artist = Artist.Igor_Kieryluk
            });
            Cards.Add(new LotRCard()
            {
                Title = "Through the Marsh",
                OppositeTitle = "No End in Sight",
                Id = "694301EA-DB10-426F-9534-7187BE76CBEE",
                CardType = CardType.Quest,
                StageNumber = 2,
                QuestPoints = 13,
                Text = "When Revealed: Raise each player's threat by 1.",
                FlavorText = "As you trudge through endless swamp, you begin to wonder if you will ever reach the other side.",
                OppositeText = "Time 3.\r\nForced: After the last time counter is removed from this stage, advance to a different stage 2A at random. Return this stage to the quest deck.\r\nPlayer card effects cannot be used to gain resources or draw cards.\r\nForced: When the players defeat this stage, advance to a random stage 3A.",
                EncounterSet = "The Nîn-in-Eilph",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WearyTravelers },
                CardNumber = 95,
                Quantity = 1,
                Artist = Artist.Mariusz_Gandzel,
                SecondArtist = Artist.Titus_Lunter
            }.WithSuffix("No End in Sight"));
            Cards.Add(new LotRCard()
            {
                Title = "Through the Marsh",
                OppositeTitle = "A Weary Passage",
                Id = "DF7328BE-5545-4A0E-9252-B82E5CF578C9",
                CardType = CardType.Quest,
                StageNumber = 2,
                QuestPoints = 13,
                Text = "When Revealed: Raise each player's threat by 1.",
                FlavorText = "As you trudge through endless swamp, you begin to wonder if you will ever reach the other side.",
                OppositeText = "Time 3.\r\nForced: After the last time counter is removed from this stage, advance to a different stage 2A at random. Return this stage to the quest deck.\r\nIn order to commit characters to the quest, a player must first discard a card at random from his hand.\r\nForced: When the players defeat this stage, advance to a random stage 3A.",
                EncounterSet = "The Nîn-in-Eilph",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WearyTravelers },
                CardNumber = 96,
                Quantity = 1,
                Artist = Artist.Mariusz_Gandzel,
                SecondArtist = Artist.Adam_Lane
            }.WithSuffix("A Weary Passage"));
            Cards.Add(new LotRCard()
            {
                Title = "Through the Marsh",
                OppositeTitle = "A Forgotten Land",
                Id = "713D0422-C8CD-42A7-90A4-17FE35E91345",
                CardType = CardType.Quest,
                StageNumber = 2,
                QuestPoints = 13,
                Text = "When Revealed: Raise each player's threat by 1.",
                FlavorText = "As you trudge through endless swamp, you begin to wonder if you will ever reach the other side.",
                OppositeText = "Time 3.\r\nForced: After the last time counter is removed from this stage, advance to a different stage 2A at random. Return this stage to the quest deck.\r\nEach player cannot play more than 1 card each round.\r\nForced: When the players defeat this stage, advance to a random stage 3A.",
                EncounterSet = "The Nîn-in-Eilph",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WearyTravelers },
                CardNumber = 97,
                Quantity = 1,
                Artist = Artist.Mariusz_Gandzel,
                SecondArtist = Artist.Adam_Lane
            }.WithSuffix("A Forgotten Land"));
            Cards.Add(new LotRCard()
            {
                Title = "Lost in the Swanfleet",
                OppositeTitle = "Impassable Marshland",
                Id = "50DB49B4-DC96-44CE-9AC4-5656EAAA05BB",
                CardType = CardType.Quest,
                StageNumber = 3,
                QuestPoints = 16,
                Text = "When Revealed: Raise each player's threat by 1. Add Ancient Marsh-dweller to the staging area (from out of play or engaged with a player) and heal all damage from it.",
                FlavorText = "Lost as you are, your presence in the marsh has not gone unnoticed. An ancient and foul swamp creature stalks your company...",
                OppositeText = "Time 3.\r\nForced: After the last time counter is removed from this stage, advance to a different stage 3A at random. Return this stage to the quest deck.\r\nEach location in play gets +1 Threat.",
                OppositeFlavorText = "Despite the size of the creatures hunting you, the swamp itself is your worst enemy. The ground sinks down beneath you and the mud pulls the boots off your feet. Every step forward is a struggle...",
                EncounterSet = "The Nîn-in-Eilph",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WearyTravelers },
                CardNumber = 98,
                Quantity = 1,
                Artist = Artist.Silver_Saaremael,
                SecondArtist = Artist.Ilich_Henriquez
            }.WithSuffix("Impassable Marshland"));
            Cards.Add(new LotRCard()
            {
                Title = "Lost in the Swanfleet",
                OppositeTitle = "A Treacherous Swamp",
                Id = "5520B64E-D343-4D82-AA67-255A53498A4E",
                CardType = CardType.Quest,
                StageNumber = 3,
                QuestPoints = 16,
                Text = "When Revealed: Raise each player's threat by 1. Add Ancient Marsh-dweller to the staging area (from out of play or engaged with a player) and heal all damage from it.",
                FlavorText = "Lost as you are, your presence in the marsh has not gone unnoticed. An ancient and foul swamp creature stalks your company...",
                OppositeText = "Time 3.\r\nForced: After the last time counter is removed from this stage, advance to a different stage 3A at random. Return this stage to the quest deck.\r\nEach player cannot ready more than 5 characters during the refresh phase.",
                OppositeFlavorText = "After wandering aimlessly for so long, harried by foul creatues, your resolve begins to waver and your companions collapse from exhaustion. If you cannot find a way across, the swamp will erase all evidence of your passage...",
                EncounterSet = "The Nîn-in-Eilph",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WearyTravelers },
                CardNumber = 99,
                Quantity = 1,
                Artist = Artist.Silver_Saaremael,
                SecondArtist = Artist.Matt_Bradbury
            }.WithSuffix("A Treacherous Swamp"));
            Cards.Add(new LotRCard()
            {
                Title = "Lost in the Swanfleet",
                OppositeTitle = "Creatures of a Forgotten Age",
                Id = "75C13731-B19C-4721-AA05-671FE5BAE81C",
                CardType = CardType.Quest,
                StageNumber = 3,
                QuestPoints = 16,
                Text = "When Revealed: Raise each player's threat by 1. Add Ancient Marsh-dweller to the staging area (from out of play or engaged with a player) and heal all damage from it.",
                FlavorText = "Lost as you are, your presence in the marsh has not gone unnoticed. An ancient and foul swamp creature stalks your company...",
                OppositeText = "Time 3.\r\nForced: After the last time counter is removed from this stage, advance to a different stage 3A at random. Return this stage to the quest deck.\r\nEach enemy in the staging area gets -20 engagement cost.",
                OppositeFlavorText = "As if the swamp itself was not bad enough, its foul denizens swarm around you, their serpentine forms slithering through the murky water that rises to your waist...",
                EncounterSet = "The Nîn-in-Eilph",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WearyTravelers },
                CardNumber = 100,
                Quantity = 1,
                Artist = Artist.Silver_Saaremael,
                SecondArtist = Artist.Silver_Saaremael
            }.WithSuffix("Creatures of a Forgotten Age"));
            Cards.Add(new LotRCard()
            {
                Title = "Out of the Swamp",
                Id = "75C43258-4AA2-4348-8766-4CBC41DAB6F6",
                CardType = CardType.Quest,
                StageNumber = 4,
                QuestPoints = null,
                Text = "When Revealed: Add Ancient Marsh-dweller to the staging area (from out of play or engaged with a player) and heal all damage on it. Then Ancient Marsh-dweller makes an attack against each player in player order.",
                FlavorText = "Beyond all hope, you have reached the edge of the swamp! You can see the gentle rise of the hills in the distance, but the huge marsh-dweller that has pursued your company now lies between you and dry land.",
                OppositeText = "Time 2.\r\nForced: After the last time counter is removed from this stage, Ancient Marsh-dweller makes an attack against each player in order. Place 2 time counters on this stage.\r\nWhen Ancient Marsh-dweller is defeated, the players win the game.",
                EncounterSet = "The Nîn-in-Eilph",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.WearyTravelers },
                CardNumber = 101,
                Quantity = 1,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new LotRCard()
            {
                Title = "Nalir",
                Id = "555E54CE-95EF-4C46-AFF1-89DED1E8376D",
                IsUnique = true,
                CardType = CardType.Objective_Ally,
                Willpower = 0,
                Attack = 1,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Dwarf." },
                Text = "The first player gains control of Nalir.\r\nForced: At the beginning of the refresh phase, raise your threat by 1 for each player in the game.\r\nIf Nalir leaves play, the players lose the game.",
                EncounterSet = "The Nîn-in-Eilph",
                CardNumber = 102,
                Quantity = 1,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ancient Marsh-dweller",
                IsUnique = true,
                Id = "0E7077B4-DCA9-4C3F-B446-1883D9DE6C2D",
                CardType = CardType.Enemy,
                EngagementCost = 45,
                Threat = 3,
                Attack = 6,
                Defense = 4,
                HitPoints = 9,
                Traits = new List<string> { "Creature." },
                Text = "Cannot have attachments.\r\nAncient Marsh-dweller gets +1 Threat and +1 Attack for each resource token on it.\r\nForced: After any number of time counters are removed from the current quest, place a resource token here.",
                EncounterSet = "The Nîn-in-Eilph",
                VictoryPoints = 5,
                CardNumber = 103,
                Quantity = 1,
                Artist = Artist.Tom_Garden
            });
            Cards.Add(new LotRCard()
            {
                Title = "Giant Swamp Adder",
                Id = "33C27FE4-18A5-444D-9310-912FA781E435",
                CardType = CardType.Enemy,
                EngagementCost = 35,
                Threat = 3,
                Attack = 3,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Creature." },
                Text = "Cannot have attachments.\r\nForced: After any number of time counters are removed from the current quest, ~Giant ~Swamp Adder attacks the engaged player.",
                FlavorText = "There were also abominable creatures haunting the reeds and tussocks... -The Fellowship of the Ring",
                EncounterSet = "The Nîn-in-Eilph",
                CardNumber = 104,
                Quantity = 4,
                EasyModeQuantity = 3,
                Artist = Artist.Dmitry_Prosvirnin
            });
            Cards.Add(new LotRCard()
            {
                Title = "Neekerbreekers",
                Id = "4A692551-0155-461A-8445-9BBAEF3748F6",
                CardType = CardType.Enemy,
                EngagementCost = 20,
                Threat = 2,
                Attack = 1,
                Defense = 1,
                HitPoints = 6,
                Traits = new List<string> { "Creature.", "Insect." },
                Text = "Forced: After any number of time counters are removed from the current quest, the engaged player must deal 2 damage to an ally he controls.",
                Shadow = "Shadow: Deal 1 damage to the defending character.",
                EncounterSet = "The Nîn-in-Eilph",
                CardNumber = 105,
                Quantity = 3,
                Artist = Artist.Dmitry_Prosvirnin
            });
            Cards.Add(new LotRCard()
            {
                Title = "Fen of Reeds",
                Id = "CC5C8C35-22A9-4B2F-84F3-CEFB538CF318",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 3,
                Traits = new List<string> { "Marsh." },
                Text = "While Fen of Reeds is in the staging area, it gains: \"Forced: After the players advance to a quest stage, each player must exhaust a character he controls.\"",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each time counter on the quest.",
                EncounterSet = "The Nîn-in-Eilph",
                CardNumber = 106,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Anthony_Feliciano
            });
            Cards.Add(new LotRCard()
            {
                Title = "Finger of Glanduin",
                Id = "2EF843B2-840E-445F-BBF0-99668D721BB9",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "River.", "Marsh." },
                Text = "While Finger of Glanduin is in the staging area, it gains : \"Forced: At the end of each round, remove 1 progress from each location in play.\"",
                Shadow = "Shadow: If this attack destroys a character remove all progress from the current quest.",
                EncounterSet = "The Nîn-in-Eilph",
                CardNumber = 107,
                Quantity = 3,
                Artist = Artist.Anthony_Feliciano
            });
            Cards.Add(new LotRCard()
            {
                Title = "Hidden Eyot",
                Id = "E22607A9-EBDB-4EE9-8713-51B40CFF7A8F",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 4,
                Traits = new List<string> { "Marsh." },
                Text = "Response: After Hidden Eyot leaves play as an explored location, place 2 time counters on the current quest.\r\nTravel: Each player must exhaust a character he controls to travel here.",
                EncounterSet = "The Nîn-in-Eilph",
                CardNumber = 108,
                Quantity = 2,
                Artist = Artist.Titus_Lunter
            });
            Cards.Add(new LotRCard()
            {
                Title = "Sinking Bog",
                Id = "E8AF5016-FB3E-4DC6-AD8C-3E754B2A7DBD",
                CardType = Models.LotR.CardType.Location,
                Threat = 1,
                QuestPoints = 5,
                Traits = new List<string> { "Marsh." },
                Text = "While Sinking Bog is in the staging area, each character gets -1 Willpower, -1 Attack, and -1 Defense for each Item attached to it. This ability does not stack with other copies of Sinking Bog.",
                Shadow = "Shadow: Defending character gets -1 Defense for this attack for each attachment attached to it.",
                EncounterSet = "The Nîn-in-Eilph",
                CardNumber = 109,
                Quantity = 3,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Shifting Marshland",
                Id = "C91E980D-CC5F-4BD6-982B-6EA12F76BD51",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Remove 1 time counter from the current quest.",
                Shadow = "Shadow: Attacking enemy makes an additional attack after this one.",
                EncounterSet = "The Nîn-in-Eilph",
                CardNumber = 110,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Rick_Price
            });
            Cards.Add(new LotRCard()
            {
                Title = "Remnants of Elder Days",
                Id = "0C1F9402-977A-4709-94D0-BA8E610D30C2",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each player must search the encounter deck or discard pile for a Creature enemy and put it into play engaged with him. Shuffle the encounter deck. This effect cannot be canceled.",
                FlavorText = "\"An evil of the Ancient World it seemed, such as I have never seen before...\"\r\n-Aragorn, The Fellowship of the Ring",
                EncounterSet = "The Nîn-in-Eilph",
                CardNumber = 111,
                Quantity = 1,
                EasyModeQuantity = 0,
                Artist = Artist.Mark_Bulahao
            });
        }
    }
}