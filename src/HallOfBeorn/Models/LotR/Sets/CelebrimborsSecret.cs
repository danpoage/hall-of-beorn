using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class CelebrimborsSecret : CardSet
    {
        protected override void Initialize()
        {
            Name = "Celebrimbor's Secret";
            Abbreviation = "CS";
            Number = 27;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";

            Cards.Add(new LotRCard()
            {
                Title = "Galadriel",
                Id = "39125C18-14B2-4DB5-B349-2219D85D3B9C",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Spirit,
                ThreatCost = 9,
                Willpower = 4,
                Attack = 0,
                Defense = 0,
                HitPoints = 4,
                Text = "Galadriel cannot quest, attack, or defend. Allies you control do not exhaust to commit to the quest during the round they enter play.\r\nAction: Exhaust Galadriel to choose a player. That player reduces his threat by 1 and draws 1 card. (Limit once per round.)",
                CardNumber = 112,
                Quantity = 1,
                Artist = Artist.Magali_Villeneuve
            }.WithTraits("Noldor.", "Noble."));
            Cards.Add(new LotRCard()
            {
                Title = "Heir of Mardil",
                Id = "7568B374-D46C-4473-BC15-4BCFFF626A4C",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Traits = new List<string> { "Title." },
                Text = 
@"Attach to a Noble hero.

Response: After attached hero gains any number of resources from a card effect, exhaust Heir of Mardil to ready attached hero.",
                FlavorText = "\"...in my turn I bore it, and so did each eldest son of our house, far back into the vanished years before the failing of the kings...\"\r\n-Denethor, The Return of the King",
                CardNumber = 113,
                Quantity = 3,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new LotRCard()
            {
                Title = "Orophin",
                Id = "7A0BDE3C-CA46-4560-A65A-547C35999962",
                IsUnique = true,
                CardType = Models.LotR.CardType.Ally,
                Sphere = Models.LotR.Sphere.Leadership,
                ResourceCost = 3,
                Willpower = 2,
                Attack = 2,
                Defense = 0,
                HitPoints = 2,
                Text = "Response: After Orophin enters play, return a Silvan ally from your discard pile to your hand.",
                FlavorText = "\"Orophin has now gone in haste back to our dwellings to warn our people.\" -Haldir, The Fellowship of the Ring",
                CardNumber = 114,
                Quantity = 3,
                Artist = Artist.Magali_Villeneuve
            }.WithTraits("Silvan.", "Scout.")
            .WithKeywords("Ranged."));
            Cards.Add(new LotRCard()
            {
                Title = "Henneth Annûn Guard",
                Id = "597CB12C-233C-4AB1-BC98-A8575478DE5A",
                CardType = Models.LotR.CardType.Ally,
                Sphere = Models.LotR.Sphere.Tactics,
                ResourceCost = 3,
                Willpower = 0,
                Attack = 2,
                Defense = 2,
                HitPoints = 2,
                Traits = new List<string> { "Gondor.", "Warrior." },
                Text = "You may give Henneth Annûn Guard doomed 1 when you play it from your hand. If you do, it gains :\"Response: After you play Henneth Annûn Guard, choose a character. Until the end of the round, that character gets +2 Defense and gains sentinel.\"",
                FlavorText = "\"Does he think that men sleep without watch all night?\" -Faramir, The Two Towers",
                CardNumber = 115,
                Quantity = 3,
                Artist = Artist.Kristina_Carroll
            });
            Cards.Add(new LotRCard()
            {
                Title = "Charge of the Rohirrim",
                Id = "C82DE5D2-070B-4D5F-BCE4-28FC52A80C66",
                CardType = CardType.Event,
                Sphere = Models.LotR.Sphere.Tactics,
                ResourceCost = 2,
                Text = "Action: Until the end of the phase, each Rohan character with a Mount attachment gets +3 Attack.",
                FlavorText = "\"Arise, arise, riders of Théoden!\" -Théoden, The Return of the King",
                CardNumber = 116,
                Quantity = 3,
                Artist = Artist.Igor_Kieryluk
            });
            Cards.Add(new LotRCard()
            {
                Title = "Galadriel's Handmaiden",
                Id = "D7160699-2745-45AB-AAB9-C91E05F88868",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                ResourceCost = 2,
                Willpower = 2,
                Attack = 0,
                Defense = 1,
                HitPoints = 1,
                Traits = new List<string> { "Silvan." },
                Text = "Response: After Galadriel's Handmaiden enters play, choose a player. That player reduces his threat by 1.",
                FlavorText = "Her maidens stood silent about her, and a while she looked upon her guests. -The Fellowship of the Ring",
                CardNumber = 117,
                Quantity = 3,
                Artist = Artist.Nathalia_Gomes
            });
            Cards.Add(new LotRCard()
            {
                Title = "Mirror of Galadriel",
                Id = "BEE06EAC-F67A-4928-A2BE-60B39F8ABA02",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                ResourceCost = 1,
                Traits = new List<string> { "Artifact.", "Item." },
                Text = 
@"Attach to Galadriel.

Exhaust Mirror of Galadriel to search the top 10 cards of your deck for a card and add it to your hand. Shuffle the rest back into your deck. Then, discard a random card from your hand.",
                FlavorText = "\"What you will see, if you leave the Mirror free to work, I cannot tell. For it shows things that were, things that are, things that yet may be.\"\r\n-Galadriel, The Fellowship of the Ring",
                CardNumber = 118,
                Quantity = 3,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "Wandering Ent",
                Id = "44DBC554-BB67-4B9F-B991-44B532FF51BF",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 2,
                Willpower = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Ent." },
                Text = "Cannot have restricted attachments.\r\nEnters play exhausted.",
                FlavorText = "There were songs about the hunt of the Ents for the Entwives sung among Elves and Men from Mirkwood to Gondor. -The Two Towers",
                CardNumber = 119,
                Quantity = 3,
                Artist = Artist.Dmitry_Prosvirnin
            });
            Cards.Add(new LotRCard()
            {
                Title = "Cloak of Lórien",
                Id = "67BFABC9-37C3-43E1-A747-9A0488161DCC",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Traits = new List<string> { "Item." },
                Text = "Attach to a Noldor or Silvan character.\r\nLimit 1 per character.\r\nAttached character gets +1 Defense (+2 Defense instead if the active location has the Forest trait).",
                FlavorText = "It was hard to say what colour they were: grey with the hue of twilight under the trees they seemed to be; and yet if they were moved, or set in another light, they were green as shadowed leaves... -The Fellowship of the Ring",
                CardNumber = 120,
                Quantity = 3,
                Artist = Artist.Sara_K_Diesel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Nenya",
                Id = "C401525F-CB67-405C-AE28-FC97E8D060DC",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Neutral,
                ResourceCost = 1,
                Traits = new List<string> { "Artifact.", "Ring." },
                Text = "Attach to Galadriel. She gains a Lore resource icon.\r\nQuest Action: Exhaust Nenya and Galadriel to add her Willpower to another character's Willpower until the end of the phase.",
                FlavorText = "\"The is Nenya, the Ring of Adamant, and I am its keeper.\" -Galadriel, The Fellowship of the Ring",
                CardNumber = 121,
                Quantity = 3,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Ruins of Ost-in-Edhil",
                Id = "C9A05AC5-CBD1-45BE-8942-80F50524E58D",
                CardType = CardType.Quest,
                StageNumber = 1,
                Text = "Setup: Add Bellach, The Orcs' Search, and The Secret Chamber to the staging area. Attach Celebrimbor's Mould to The Secret Chamber. Each player adds a different Ost-in-Edhil location to the staging area. Shuffle the encounter deck.",
                FlavorText = "You have finally reached the ruins of Ost-in-Edhil, but Bellach and his Orcs have arrived before you. They appear to be searching for the hidden chamber. If you want to reach it first, you will have to move quickly and carefully...",
                OppositeText = "Forced: After the last time counter is removed from this stage, trigger each Scour effect currently in play. Place 3 time counters on this stage.\r\nBallach is immune to player card effects and cannot be engaged.\r\nThe players cannot advance unless Celebrimbor's Mould is attached to a hero.",
                QuestPoints = 14,
                EncounterSet = "Celebrimbor's Secret",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountainOrcs, EncounterSet.BrokenLands },
                CardNumber = 122,
                Quantity = 1,
                Artist = Artist.Ben_Zweifel
            }.WithKeywords("Time 3."));
            Cards.Add(new LotRCard()
            {
                Title = "The Enemy's Servant",
                Id = "E6C49DD5-5AF0-4B33-8F09-D7F7AC398F33",
                CardType = CardType.Quest,
                StageNumber = 2,
                Text = "When Revealed: Trigger each Scour effect currently in play. Bellach makes an attack against the player who controls Celebrimbor's Mould. Then, attach Celebrimbor's Mould to Bellach.",
                FlavorText = "You have just recovered a partial ring-mould from Celebrimbor's secret forge when you are struck from behind. You look up to see Bellach holding the mould and gloating, \"Fools! My master will be pleased.\" As he turns to leave, he shouts to his servants, \"Kill them!\" You must escape the Orcs and recapture the mould!",
                OppositeText = "Forced: After the last time counter is removed from this stage, trigger each scour effect currently in play. Place 3 time counters on this stage.\r\nUnless there is at last 12 progress on this stage, Bellach is immune to player card effects and cannot be engaged.The players cannot win unless Celebrimbor's Mould is attached to a hero. If the players defeat this stage, they win the game.",
                QuestPoints = 12,
                EncounterSet = "Celebrimbor's Secret",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountainOrcs, EncounterSet.BrokenLands },
                CardNumber = 123,
                Quantity = 1,
                Artist = Artist.Rafal_Hrynkiewicz
            }.WithKeywords("Time 3."));
            Cards.Add(new LotRCard()
            {
                Title = "Bellach",
                Id = "1A2D5848-ADC1-4D9B-95C9-075BA51967AC",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = Card.VALUE_X,
                Attack = 5,
                Defense = 4,
                HitPoints = 7,
                Traits = new List<string> { "Mordor.", "Spy." },
                Text = "X is the number of cards underneath The Orcs' Search.\r\nScour: Each player must search the encounter deck and discard pile for an Orc enemy and add it to the staging area.",
                EncounterSet = "Celebrimbor's Secret",
                VictoryPoints = 5,
                CardNumber = 124,
                Quantity = 1,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Orcs' Search",
                Id = "C4837705-289B-4D77-8598-C4AC537FE5A4",
                CardType = CardType.Objective,
                Text = 
@"When a location has damage equal to its printed quest points, place it facedown underneath The Orcs' Search.

Forced: At the end of the refresh phase, raise each player's threat by 1 for each card underneath The Orcs' Search.",
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 125,
                Quantity = 1,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            addCard(new LotRCard()
            {
                Title = "The Secret Chamber",
                Id = "7D355C4E-216A-44E5-9D05-BDD6E12F7C3B",
                CardType = CardType.Location,
                Threat = Card.VALUE_X,
                QuestPoints = 6,
                Traits = new List<string> { "Ost-in-Edhil.", "Ruins" },
                Text = "X is the number of players in the game. Immune to player card effects.\r\nTravel: Remove 3 progress from the current quest to travel here.\r\nIf the Secret Chamber is placed underneath The Orcs' Search, the players lose the game.",
                VictoryPoints = 3,
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 126,
                Quantity = 1,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "Celebrimbor's Mould",
                IsUnique = true,
                Id = "2C357563-1797-4A84-8FA2-E3269DF34069",
                CardType = CardType.Objective,
                Traits = new List<string> { "Artifact.", "Item." },
                Text = "If Celebrimbor's Mould is free of encounters, the first player claims it and attaches it to a hero he controls.\r\nIf the attached hero leaves play, the players lose the game.",
                FlavorText = "\"Celebrimbor of Hollin drew these signs.\" -Gandalf, The Fellowship of the Ring",
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 127,
                Quantity = 1,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                Title = "Bellach's Scout",
                Id = "5957186F-8B1F-4510-A5CC-40B317E92A83",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 2,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Mordor.", "Orc." },
                Text = 
@"When Revealed: Either place 3 damage on the active location, or reveal an additional encounter card.
                
Scour: Place 1 damage on the active location.",
                Shadow = "Shadow: Place 1 damage on the active location.",
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 128,
                Quantity = 4,
                EasyModeQuantity = 3,
                Artist = Artist.Florian_Devos
            });
            Cards.Add(new LotRCard()
            {
                Title = "Prowling Orc",
                Id = "551F5BB6-6CEA-47E5-981F-2F0D9C0F457D",
                CardType = CardType.Enemy,
                EngagementCost = 45,
                Threat = 3,
                Attack = 5,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Mordor.", "Orc." },
                Text = 
@"Forced: After Prowling ~Orc attacks, place 1 damage on the active location.

Scour: Prowling ~Orc engages the player with the highest threat and makes an immediate attack.",
                FlavorText = "\"Garn! You don't even know what you're looking for.\" -Orc, The Return of the King",
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 129,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ruined Plaza",
                Id = "1B025D66-171E-4708-8C7F-F3D7C4609605",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 2,
                Traits = new List<string> { "Ost-in-Edhil.", "Ruins." },
                Text = "Forced: After Ruined Plaza enters the staging area, place 1 damage here.",
                Shadow = "Shadow: Defending player assigns X damage amoung characters he controls. X is the number of cards underneath The Orcs' Search.",
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 130,
                Quantity = 3,
                Artist = Artist.Joel_Hustak
            });
            Cards.Add(new LotRCard()
            {
                Title = "Collapsed Tower",
                Id = "09095D8A-9634-421B-A324-2100592C2A77",
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 4,
                Traits = new List<string> { "Ost-in-Edhil.", "Ruins." },
                Text = "Scour: Return this location to the staging area and place 2 damage here.",
                Shadow = "Shadow: Excess damage from this attack must be placed on the active location, if able.",
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 131,
                Quantity = 2,
                Artist = Artist.Anthony_Feliciano
            }.WithKeywords("Surge."));
            Cards.Add(new LotRCard()
            {
                Title = "Ancient Foundation",
                Id = "FFF71738-B9F8-447C-870A-75B2A5C8312D",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 4,
                Traits = new List<string> { "Ost-in-Edhil.", "Ruins." },
                Text = "Scour: Assign X damage amoung locations in play. X is the number of locations in play. This ability does not stack with other copies of Ancient Foundation.\r\nTravel: Place 1 damage on this location to travel here.",
                FlavorText = "...deep they delved us, fair they wrought us, hight they builded us; but they are gone. -Legolas, The Fellowship of the Ring",
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 132,
                Quantity = 4,
                Artist = Artist.Titus_Lunter
            });
            Cards.Add(new LotRCard()
            {
                Title = "City Remains",
                Id = "7B786B35-8477-4ED4-BC19-720B18F73DBE",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Ost-in-Edhil.", "Ruins." },
                Text = "Forced: After placing any amount of progress here, trigger the topmost **Scour** effect in the discard pile, if able.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, raise each player's threat by 1 for each card underneath The Orcs' Search.",
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 133,
                Quantity = 4,
                EasyModeQuantity = 2,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Discovered!",
                Id = "9207D66F-69AF-4F49-935B-BBBDA14B7E6B",
                CardType = CardType.Treachery,
                Text = "When Revealed: Either trigger ech Scour effect currently in play, or each player places a random card from his hand facedown underneath The Orcs' Search.",
                Shadow = "Shadow: If this attack destroy's a character, place that character facedown underneath The Orcs' Search.",
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 134,
                Quantity = 2,
                EasyModeQuantity = 0,
                Artist = Artist.Louis_Green
            });
            Cards.Add(new LotRCard()
            {
                Title = "Desecrated Ruins",
                Id = "50569FE5-5258-42DC-A7DE-0CC5061C6DB7",
                CardType = CardType.Treachery,
                Text = "When Revealed: Place 3 damage on the active location. If there is no active location, Desecrated ~Ruins gains surge.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. If this attack destroys an ally, place X damage on the active location. X is that ally's cost.",
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 135,
                Quantity = 3,
                Artist = Artist.David_Hammond
            });
            Cards.Add(new LotRCard()
            {
                Title = "Spies from Mordor",
                Id = "61056789-670B-46D3-952C-828CD916A783",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each player must exhaust X characters he controls. X is the number of cards underneath The Orcs' Search. If no characters are exhausted this way, Spies from ~Mordor gains surge.",
                Shadow = "Shadow: Defending player discards a non-objective attachment he controls.",
                EncounterSet = "Celebrimbor's Secret",
                CardNumber = 136,
                Quantity = 2,
                Artist = Artist.Florian_Devos
            });
        }
    }
}