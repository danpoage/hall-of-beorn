using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheLostRealm : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Lost Realm";
            Abbreviation = "TLR";
            Number = 29;
            SetType = Models.SetType.Deluxe_Expansion;

            Cards.Add(new Card()
            {
                Title = "Aragorn",
                Id = "D315D327-EDF2-45EC-802F-EB67103AA6F2",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Models.Sphere.Tactics,
                ThreatCost = 12,
                Willpower = 2,
                Attack = 3,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Dúnedain.", "Ranger.", "Warrior." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger.", "Warrior." },
                Text = "Each enemy engaged with you gets -1 Defense.\r\nResponse: After Aragorn participates in an attack that destroys an enemy, choose an enemy not engaged with you and engage that enemy.",
                FlavorText = "\"I serve no man,\" said Aragorn; \"but the servants of Sauron I pursue into whatever land they may go.\" -The Two Towers",
                Artist = Artist.Sebastian_Giacobino,
                Number = 1,
                Quantity = 1
            });
            Cards.Add(new Card()
            {
                Title = "Halbarad",
                Id = "FF755E95-4B65-47FC-BAC9-F9FE3ECA6AD6",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Models.Sphere.Leadership,
                ThreatCost = 10,
                Willpower = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Dúnedain.", "Ranger." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger." },
                Text = "While you are engaged with any enemy, Halbarad does not exhaust to commit to a quest.\r\nYou may optionally engage 1 additional enemy during the encounter phase.",
                FlavorText = "\"Little do they know of our long labour for the safekeeping of their borders, and yet I grudge it not.\" -The Return of the King",
                Artist = Artist.Smirtouille,
                Number = 2,
                Quantity = 1
            });
            Cards.Add(new Card()
            {
                Title = "Weather Hills Watchman",
                Id = "859D6FC7-8A16-4D38-87AB-4324536D9DE9",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string> { "Dúnedain." },
                NormalizedTraits = new List<string> { "Dunedain." },
                Text = "Response: After Weather Hills Watchman enters play, search the top 5 cards of your deck for a Signal card and add it to your hand. Shuffle the other cards back into your deck.",
                FlavorText = "\"Rangers use runes, and they come here sometimes.\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Kim_Sokol,
                Number = 3,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Dúnedain Hunter",
                NormalizedTitle = "Dunedain Hunter",
                Id = "8E8D4D02-E6C9-4E42-AC81-F545658F996A",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                ResourceCost = 0,
                Willpower = 1,
                Attack = 3,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Dúnedain.", "Ranger." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger." },
                Text = "Forced: After Dúnedain Hunter enters play, search the top 5 cards of the encounter deck for a non-unique enemy and put it into play engaged with you. If no enemy enters play by this effect, discard Dúnedain Hunter. Shuffle the encounter deck.",
                Artist = Artist.Louis_Green,
                Number = 4,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Sarn Ford Sentry",
                Id = "CDEC0EB5-6C35-421A-9194-77CAAE3B539B",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 3,
                Willpower = 2,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string> { "Dúnedain.", "Scout." },
                NormalizedTraits = new List<string> { "Dunedain.", "Scout." },
                Text = "Response: After Sarn Ford Sentry enters play, draw 1 card for each enemy engaged with you.",
                FlavorText = "\"Lonely men are we, Rangers of the wild, hunters but hunters ever of the servants of the Enemy...\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Smirtouille,
                Number = 5,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Warden of Annúminas",
                NormalizedTitle = "Warden of Annuminas",
                Id = "C9AB1B34-0511-4B08-A47A-4D0A64405449",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                ResourceCost = 4,
                Willpower = 0,
                Attack = 2,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Dúnedain.", "Ranger." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger." },
                Text = "Warden of Annúminas gets +1 Willpower for each enemy engaged with you.",
                FlavorText = "Rangers passed at times beyond the hills, but they were few and did not stay. -The Fellowship of the Ring",
                Artist = Artist.Smirtouille,
                Number = 6,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Ranger Summons",
                Id = "79A265E7-CD1B-4170-806A-C442B0F5D9DD",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Traits = new List<string> { "Signal." },
                Text = "Play only if you control a Dúnedain hero.\r\nPlanning Action: Shuffle 1 of your set aside Ranger of the North allies with the encounter keyword into the encounter deck. Then, remove Ranger Summons from the game.",
                FlavorText = "\"We rode as swiftly as we might when your summons came.\" -Halbarad, The Return of the King",
                Artist = Artist.Smirtouille,
                Number = 7,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Tireless Hunters",
                Id = "AE28E1EF-4359-4971-ABAA-435A44A3303B",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Text = "Play only before the resolving enemy attacks step.\r\nCombat Action: Choose an enemy not engaged with you. Engage that enemy. Then, discard a shadow card from that enemy, if able.",
                FlavorText = "\"Many evil things there are that your strong walls and bright swords do not stay.\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Ilich_Henriquez,
                Number = 8,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Expert Trackers",
                Id = "976EA200-579A-45CE-B82D-1D1013F643BB",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                ResourceCost = 0,
                Text = "Response: After you engage an enemy, exhaust a Scout or Ranger character to place X progress tokens on a location. X is the engaged enemy's printed Threat.",
                FlavorText = "\"At last!\" said Aragorn. \"Here are the tracks that we seek!\" -The Two Towers",
                Artist = Artist.Alexandr_Shaldin,
                Number = 9,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Heir of Valandil",
                Id = "A474448A-F0A6-4F8F-9FD3-497031C15B4E",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                ResourceCost = 2,
                Traits = new List<string> { "Title." },
                Text = "Attach to a Dúnedain hero.\r\nPlanning Action: Exhaust Heir of Valandil to reduce the cost of the next Dúnedain ally you play this phase by 1 for each enemy engaged with you.",
                FlavorText = "\"But my home, such as I have, is in the North. For here the heirs of Valandil have ever dwelt in long line unbroken from father unto son for many generations.\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Smirtouille,
                Number = 10,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Athelas",
                Id = "52B91199-3718-49AF-BF7D-D7E37699956B",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Traits = new List<string> { "Item." },
                Text = "Attach to a Dúnedain or Healer character.\r\nAction: Discard Athelas and exhaust attached character to heal all damage on a character. You may discard a Condition attachment from that character.",
                FlavorText = "\"...it is a healing plant that the Men of the West brought to Middle-earth. Athelas they named it...\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Cristi_Balanescu,
                Number = 11,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Secret Vigil",
                Id = "94D07579-97E4-4806-868A-BD47D8915C6A",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Traits = new List<string> { "Condition." },
                Text = "Attach to an enemy. Limit 1 per enemy.\r\nAttached enemy gets -1 Threat.\r\nResponse: When attached enemy is destroyed, reduce each player's threat by the attached enemy's printed Threat.",
                FlavorText = "\"If simple folk are free from care and fear, simple they will be, and we must be secret to keep them so.\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Piya_Wannachaiwong,
                Number = 12,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Star Brooch",
                Id = "18D8333D-8A53-4629-BF85-AFDB01536308",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                ResourceCost = 1,
                Traits = new List<string> { "Item." },
                Text = "Attach to a Dúnedain or Noldor hero. Limit 1 per hero.\r\nWhile you are engaged with an enemy, attached hero gets +1 Willpower and cannot have its Willpower reduced.",
                FlavorText = "...each cloak was pinned upon the left shoulder by a brooch of silver shaped like a rayed star. -The Return of the King",
                Artist = Artist.Alexandr_Elichev,
                Number = 13,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Gather Information",
                Id = "0B4029A2-FE36-47F5-A588-1243EFCAFC14",
                CardType = CardType.Player_Side_Quest,
                Sphere = Sphere.Neutral,
                ResourceCost = 0,
                QuestPoints = 4,
                Text = "Limit 1 per deck.\r\nResponse: After this stage is defeated, each player may search his deck for 1 card and add it to his hand. Each player shuffles his deck.",
                FlavorText = "Aragorn halted and examined the tracks closely. -The Tower Towers",
                VictoryPoints = 1,
                Artist = Artist.Smirtouille,
                Number = 14,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Ranger of the North",
                Id = "056C5C1A-D944-4734-835B-0EF3995EFC08",
                CardType = CardType.Ally,
                Sphere = Sphere.Neutral,
                ResourceCost = byte.MaxValue,
                Willpower = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Dúnedain.", "Ranger." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger." },
                Keywords = new List<string> { "Encounter.", "Surge.", "Ranged.", "Sentinel." },
                Text = "When Revealed: The first player chooses a player to take control of Ranger of the North. Then, either deal 2 damage to an enemy or place 2 progress tokens on a location.",
                Artist = Artist.Alvaro_Calvo_Escudero,
                Number = 15,
                Quantity = 3,
            });
            Cards.Add(new Card()
            {
                Title = "Iârion",
                NormalizedTitle = "Iarion",
                Id = "93F6B7C3-2F83-4E1C-8E3E-E3C9F1044A18",
                CardType = CardType.Objective_Ally,
                ScenarioTitle = "The Lost Realm",
                Willpower = 0,
                IsVariableWillpower = true,
                Attack = 0,
                IsVariableAttack = true,
                Defense = 0,
                IsVariableDefense = true,
                HitPoints = 4,
                Traits = new List<string> { "Dúnedain.", "Ranger." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger." },
                Text = "X is the number of quest cards in play.\r\nThe first player gains control of Iârion.\r\nResponse: After a side quest is revealed from the encounter deck, ready Iârion.\r\nIf Iârion leaves play, the players lose the game.",
                Artist = Artist.JB_Casacop,
                Number = 16,
                Quantity = 1,
                EncounterSet = "Iârion"
            });
            Cards.Add(new Card()
            {
                Title = "Orc War Party",
                Id = "27E03560-6816-4AC3-8B49-1F81586DF47B",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 3,
                Attack = 6,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Orc." },
                Text = "Cannot have attachments.\r\nWhile Orc War Party is in the staging area, enemies in the staging area cannot take damage.\r\nThe players cannot win the game while Orc War Party is in play.",
                FlavorText = "They kept no order, thrusting, jostling, and cursing; yet their speed was very great. -The Two Towers",
                Artist = Artist.Anthony_Feliciano,
                Number = 17,
                Quantity = 3,
                EasyModeQuantity = 1,
                EncounterSet = "Intruders in Chetwood"
            });
            Cards.Add(new Card()
            {
                Title = "Chetwood Forest",
                Id = "5395CF56-5550-4760-813D-5BE67E1A3AEB",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Arnor.", "Forest." },
                Text = "Travel: One player chooses and engages an enemy in the staging area.",
                Shadow = "Shadow: Defending player either exhausts a hero he controls, or returns attacking enemy to the staging area after this attack.",
                Artist = Artist.Michael_Wolmarans,
                Number = 18,
                Quantity = 3,
                EasyModeQuantity = 2,
                EncounterSet = "Intruders in Chetwood"
            });
            Cards.Add(Card.Location("Borders of Bree-land", "1999261E-2DEC-40EC-86DC-6874A803F5CD", "Intruders in Chetwood", 2, 4)
                .WithTraits("Arnor.")
                .WithText("While Borders of Bree-land is in the staging area it gains: \"Forced: At the beginning of the quest phase, return 1 enemy engaged with a player to the staging area.\"")
                .WithShadow("Shadow: Defending character gets -1 Defense for each quest stage in play.")
                .WithInfo(19, 2, Artist.Jake_Bullock));
            Cards.Add(Card.Location("Outlying Homestead", "BE8A5A2A-1190-4B23-A306-F95BC9265CC3", "Intruders in Chetwood", 2, 8)
                .WithTraits("Arnor.")
                .WithKeywords("Doomed 1.")
                .WithText("While Outlying Homestead is in the staging area, players cannot reduce their threat.\r\nTravel: Reveal a card from the encounter deck.")
                .WithFlavor("They were far beyond the borders of the Bree-land, out in the pathless wilderness... -The Fellowship of the Ring")
                .WithInfo(20, 3, Artist.Ed_Mattinian)
                .WithEasyModeQuantity(2));
            Cards.Add(Card.Treachery("Sudden Assault", "8B9BD048-01E3-4941-88AB-51A2E29E91E1", "Intruders in Chetwood")
                .WithText("When Revealed: If the total Willpower of character committed to the quest is greater than the total Threat in the staging area, each enemy in the staging area makes an immediate attack against the first player. If no attach is made this way, search the encounter deck and discard pile for an Orc War Party and add it to the staging area. Shuffle the encounter deck. This effect cannot be canceled.")
                .WithInfo(21, 2, Artist.Jon_Bosco)
                .WithEasyModeQuantity(0));
            Cards.Add(Card.Treachery("Surprising Speed", "B933B8D3-3F5F-41AB-AAF3-E2BEC40D8DD6", "Intruders in Chetwood")
                .WithText("When Revealed: Each player returns 1 enemy engaged with him to the staging area. If no enemy was returned to the staging area this way, Surprising Speed gains surge and doomed 1.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. Return attacking enemy to the staging area after this attack.")
                .WithInfo(22, 3, Artist.Matthew_Cowdery)
                .WithEasyModeQuantity(2));
            Cards.Add(Card.EncounterSideQuest("Orc Rearguard", "8AA24D7D-EF41-44BA-9EC4-BF1A8337A39A", "Intruders in Chetwood", 3)
                .WithText("No more than 3 progress tokens can be placed on the current quest each round.\r\nWhile Orc Rearguard is the current quest it gains: \"Forced: At the end of the staging step, reveal 1 card from the encounter deck.\"")
                .WithFlavor("Some of the Orcs have broken from the war party to hinder your pursuit. Until you deal with them, it will be difficult to continue your chase...")
                .WithVictoryPoints(10)
                .WithInfo(23, 1, Artist.Jon_Bosco));
            Cards.Add(Card.EncounterSideQuest("Rescue Iârion", "EC970E93-A6A1-4BEC-9C36-DBCF8C6F27A5", "Intruders in Chetwood", 6)
                .WithNormalizedTitle("Rescue Iarion")
                .WithKeywords("Time 4.")
                .WithText("When Revealed: The first player loses control of Iârion and places him facedown underneath this stage. When this stage is defeated, the first player takes control of Iârion and exhausts him.\r\nForced: After the last time counter is removed from this stage, discard Iârion.")
                .WithFlavor("While scouting ahead, Iârion is ambushed by several Orcs. The Ranger is knoced unconscious and dragged away by the Orcs. You must rescue him!")
                .WithVictoryPoints(10)
                .WithInfo(24, 1, Artist.JB_Casacop));
            Cards.Add(Card.Enemy("Cornered Orc", "88156181-C4C7-4B09-8F88-72AFA59C809B", "Intruders in Chetwood", 20, 2, 2, 1, 2)
                .WithTraits("Orc.")
                .WithText("Forced: After Corned Orc engages a player, it makes an immediate attack.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character is damaged).")
                .WithInfo(25, 5, Artist.Tey_Bartolome)
                .WithEasyModeQuantity(4));
            Cards.Add(Card.Location("Amon Forn", "0D0849D8-358C-4859-9337-CBB4DC949F35", "The Weather Hills", 4, 6)
                .WithUnique()
                .WithTraits("Arnor.", "Ruins.")
                .WithText("Immune to player card effects.\r\nWhile Amon Forn is the active location, it gains: \"Forced: After an Orc enemy is added to the staging area, it makes an immediate attack against the first player.\"\r\nThe players cannot win while Amon Forn is in play.")
                .WithVictoryPoints(3)
                .WithInfo(26, 1, Artist.Dimitri_Bielak));
            Cards.Add(Card.Location("Weathered Hilltop", "24F367E0-0664-4D44-8BE6-3F591A750376", "The Weather Hills", 1, 5)
                .WithTraits("Arnor.", "Hills.")
                .WithText("Weathered Hilltop gets +1 Threat for each resource token on it.\r\nForced: After a Weather treachery is revealed from the encounter deck, place 1 resource token here.")
                .WithFlavor("\"There is little shelter or defence here...\" -Aragorn, The Fellowship of the Ring")
                .WithInfo(27, 3, Artist.Ed_Mattinian));
            Cards.Add(Card.Location("Exposed Ridge", "E94ACE01-D2FF-4B0C-B652-0B6E3E0594B3", "The Weather Hills", 3, 3)
                .WithTraits("Arnor.", "Hills.")
                .WithText("While Exposed Ridge is the active location, it gains: \"Forced: At the end of the refresh phase, each player deals 1 damage to a character he controls.\"")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each damaged character the defending player controls.")
                .WithInfo(28, 3, Artist.Alyn_Spiller)
                .WithEasyModeQuantity(2));
            Cards.Add(Card.Location("Sheltered Valley", "D5129DC3-C295-4A1C-A9C9-3A154F7C755A", "The Weather Hills", 2, 4)
                .WithTraits("Arnor.", "Hills.")
                .WithText("While Sheltered Valley is the active location, it gains: \"Response: When Sheltered Valley is explored, heal all damage from 1 character.\"\r\nTravel: Remove 1 resource token from the Mission objective.")
                .WithInfo(29, 2, Artist.Juan_Carlos_Barquet));
            Cards.Add(Card.Location("Concealed Orc-camp", "AF11F2AF-D9DC-4001-8375-99F7548C21A7", "The Weather Hills", 2, 2)
                .WithTraits("Arnor.", "Hills.")
                .WithText("While Concealed Orc-camp is the active location is gains: \"Response: When Concealed Orc-camp is explored, place 1 resource token on the Mission objective.\"\r\nTravel: The first player searches the encounter deck and discard pile for an Orc enemy and put it into play engaged with him. Shuffle the encounter deck.")
                .WithInfo(30, 3, Artist.Mariusz_Gandzel));
            Cards.Add(Card.Treachery("Ice Storm", "79EB9FDC-9806-4A6B-9F2A-025EF37F141D", "The Weather Hills")
                .WithTraits("Weather.")
                .WithText("When Revealed: Each player assigns X damage among characters he controls, where X is the number of cards in play. Then, exhaust each damaged character.")
                .WithShadow("Shadow: Assign X damage among characters you control. X is the number of quest cards in play.")
                .WithInfo(31, 2, Artist.Romana_Kendelic)
                .WithEasyModeQuantity(1));
            Cards.Add(Card.EncounterSideQuest("Find Shelter", "", "The Weather Hills", 6)
                .WithKeywords("Surge.", "Time 4.")
                .WithText("Forced: After the last time counter is removed from this quest cards, each player deals 4 damage to a hero he controls. Then, place 4 time counters on this quest card.")
                .WithFlavor("The weather is growing steadily worse, and black clouds loom on the horizon. You must find a safe place to shelter or be caught in the storm...")
                .WithVictoryPoints(10)
                .WithInfo(32, 1, Artist.Smirtouille));
            Cards.Add(Card.Enemy("Thaurdir", "E4252842-3141-4279-A8D1-E73C913723DB", "Deadmen's Dike", 1, 4, 6, 4, 9)
                .WithUnique()
                .WithTraits("Undead.", "Wraith.")
                .WithKeywords("Indestructible.")
                .WithText("Cannot have attachments.\r\nForced: After a treachery card with the Sorcery trait is revealed from the encounter deck, Thaurdir makes an immediate attack against the first player.")
                .WithInfo(33, 1, Artist.Joel_Hustak));
            Cards.Add(Card.Enemy("Thaurdir's Damned", "DB77627C-9B7B-455C-AFBA-E6116B80CCB3", "Deadmen's Dike", 35, 3, 5, 2, 6)
                .WithTraits("Undead.", "Wraith.")
                .WithText("Forced: After Thaurdir's Damned engages you, discard the top 2 cards of your deck and assign X damage among characters you control. X is the combined printed cost of the discarded cards.")
                .WithFlavor("\"I saw them; grim faces and evil...\" -Frodo, The Two Towers")
                .WithInfo(34, 3, Artist.Jim_Pavelec)
                .WithEasyModeQuantity(1));
            Cards.Add(Card.Enemy("Baleful Shade", "C8B1CA1C-E3FA-48CF-8FE2-850EDDCDFFD7", "Deadmen's Dike", 30, 2, 2, 1, 5)
                .WithTraits("Undead.", "Wraith.")
                .WithText("Forced: When Baleful Shade attacks, the defending player discards the top card of his deck. If the discarded card is an ally, Baleful Shade gets +2 Attack for this attack.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(35, 4, Artist.Florian_Devos));
            Cards.Add(Card.Location("Broken Battlements", "010935A5-F579-4E39-B373-2C5D335241F1", "Deadmen's Dike", 2, 6)
                .WithTraits("Fornost.", "Ruins.")
                .WithKeywords("Time 3.")
                .WithText("Forced: After the last time counter is removed from Broken Battlements, each player discards the top 5 cards of his deck and places 1 time counter here.\r\nTravel: Each player discard the top card of his deck.")
                .WithFlavor("\"Men call it Deadman's Dike, and they fear to tread there.\" -Elrond, The Fellowship of the Ring")
                .WithInfo(36, 3, Artist.Juan_Carlos_Barquet)
                .WithEasyModeQuantity(2));
            Cards.Add(Card.Location("Norbury Tombs", "30C0BBDB-E891-4277-9B52-F3045E20B8E3", "Deadmen's Dike", 2, 5)
                .WithTraits("Fornost.", "Ruins.")
                .WithText("While Norbury Tombs is the active location, it gains: \"Respnse: When Norbury Tombs is explored, each player shuffles the top 5 cards of his discard pile into his deck.\"\r\nTravel: Return the topmost enemy in the encounter discard pile to the staging area.")
                .WithInfo(37, 2, Artist.Julian_Kok));
            Cards.Add(Card.Location("Fornost Square", "57E770A2-8DD9-4EB8-9698-8DA7AC186D4D", "Deadmen's Dike", 1, 4)
                .WithTraits("Fornost.", "Ruins.")
                .WithText("Fornost Square gets +1 Threat for each resource token on it.\r\nForced: After the first player discards any number of cards from the top of his deck, place 1 resource token here.")
                .WithFlavor("\"...the heirs of Valandil removed and dwelt at Fornost on the high North Downs, and that now too is desolate.\" -Elrond, The Fellowship of the Ring")
                .WithInfo(38, 3, Artist.Mariusz_Gandzel));
            Cards.Add(Card.Location("Haunted Keep", "7FD9F281-8C01-4D7B-90F9-15DB53512B06", "Deadmen's Dike", 3, 3)
                .WithTraits("Fornost.", "Ruins.")
                .WithText("While Haunted Keep is the active location, the first Undead enemy revealed each round gains surge.")
                .WithShadow("Shadow: Defending player discards the top card of his deck. Attacking enemy gets +X Attack where X is the discarded card's printed cost.")
                .WithInfo(39, 3, Artist.Dimitri_Bielak)
                .WithEasyModeQuantity(2));
            Cards.Add(Card.Location("Deadmen's Gate", "76181197-E3B1-4332-86CF-81034FCD05EC", "Deadmen's Dike", 4, 4)
                .WithTraits("Fornost.", "Ruins.")
                .WithText("While Deadmen's Gate is the active location, it gains: \"Forced: After a player triggers an 'Action' or 'Response' effect, he must discard the top card of his deck.\"")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithInfo(40, 2, Artist.Michael_Wolmarans)
                .WithEasyModeQuantity(1));
            Cards.Add(Card.Treachery("Unnatural Fog", "67D5DF46-8965-4A83-B2AE-620E4F8B9E62", "Deadmen's Dike")
                .WithTraits("Sorcery.")
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Each player must either discard 1 card from the top of his deck for each questing character he controls, or remove each character he controls from the quest.")
                .WithFlavor("The mist was flowing past him now in shreds and tatters. -The Fellowship of the Ring")
                .WithInfo(41, 2, Artist.Joel_Hustak)
                .WithEasyModeQuantity(1));
            Cards.Add(Card.EncounterSideQuest("The Shadow World", "FE6434AC-6D53-43DF-8C35-D9B171481D8D", "Deadmen's Dike", 5)
                .WithKeywords("Surge.")
                .WithText("Forced: At the end of the refresh phase, each player discards the top X cards of his deck, where X is the number of Undead enemies engaged with him.")
                .WithFlavor("The more you struggle against the undead, the deeper you are drawn into the wraith-world. You must escape before madness or despair takes you...")
                .WithVictoryPoints(10)
                .WithInfo(42, 1, Artist.Guillaume_Ducos));
            Cards.Add(Card.Enemy("Angmar Orc", "D01FE640-3D69-428E-B854-DFD83A4CDDB0", "Angmar Orcs", 25, 2, 2, 3, 3)
                .WithTraits("Orc.")
                .WithText("When Revealed: Either discard 1 ally from play, or reveal an additional encounter card.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys an ally, return attacking enemy to the staging area.")
                .WithInfo(43, 3, Artist.Tey_Bartolome));
            Cards.Add(Card.Enemy("Angmar Marauder", "6DE617AC-669D-428C-8DCE-57FA54AC660B", "Angmar Orcs", 30, 3, 3, 2, 4)
                .WithTraits("Orc.")
                .WithText("Forced: After Angmar Marauder attacks and destroys an ally, return it to the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each ally the defending player controls.")
                .WithInfo(44, 3, Artist.Anthony_Feliciano)
                .WithEasyModeQuantity(2));
            Cards.Add(Card.Enemy("Angmar Captain", "11588D48-BA35-446B-BBFC-8345DCEF9DBB", "Angmar Orcs", 35, 3, 5, 2, 5)
                .WithTraits("Orc.")
                .WithText("Forced: After Angmar Captain attacks and destroys an ally, discard the top card of the defending player's deck. If the discarded card is an ally, Angmar Captain makes an additional attack against the defending player.")
                .WithFlavor("In the twilight he saw a large black Orc... -The Two Towers")
                .WithInfo(45, 2, Artist.Joel_Hustak)
                .WithEasyModeQuantity(1));
            Cards.Add(Card.EncounterSideQuest("Orc Ambush", "1A7EA85D-32F2-4F1E-A25A-3FB33A867017", "Angmar Orcs", 4)
                .WithText("Each Orc enemy gets +1 Threat, +1 Attack and +1 Defense.\r\nWhen Revealed: Each player must search the encounter deck and discard pile for an Orc enemy and put it into play engaged with him. Shuffle the encounter deck.")
                .WithFlavor("Several Orcs spring upon you from their hiding place! Their surprise attack puts you on the defensive. You must fight to gain the upper hand.")
                .WithInfo(46, 1, Artist.Mark_Bulahao));
            Cards.Add(Card.Location("Rugged Country", "EA214A25-E43E-4AC6-869D-1A79A0E56995", "Rollig Hills", 2, 3)
                .WithTraits("Arnor.")
                .WithText("If the current quest is a side quest, Rugged Country gets +2 Threat.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each quest card in play.")
                .WithInfo(47, 3, Artist.Juan_Carlos_Barquet));
            Cards.Add(Card.Location("Shrouded Hills", "013955B7-0138-43B4-B871-0C296C93FADE", "Eriador Wilds", 254, 5)
                .WithTraits("Arnor.", "Hills.")
                .WithText("X is the number of quest cards in play.\r\nWhile there is only 1 quest card in play, Shrouded Hills gains surge.")
                .WithFlavor("As the sun rose and passed noon they glimpsed far off in the east the grey-green lines of the Downs... -The Fellowship of the Ring")
                .WithInfo(48, 2, Artist.Alvaro_Calvo_Escudero)
                .WithEasyModeQuantity(1));
            Cards.Add(Card.Treachery("Pressing Needs", "096615FE-29F3-4EF0-9862-3F9B351914E3", "Eriador Wilds")
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Either search the encounter deck and discard pile for an encounter side quest and reveal it, or choose a different quest card in play to be the current quest until the end of the phase. Shuffe the encounter deck.")
                .WithFlavor("\"But often I must put mirth aside.\" -Aragorn, The Fellowship of the Ring")
                .WithInfo(49, 2, Artist.Mark_Bulahao)
                .WithEasyModeQuantity(1));
            Cards.Add(Card.Treachery("Weight of Responsibility", "60CEC16F-7A19-4908-B2AD-7CD61599B6F9", "Eriador Wilds")
                .WithText("When Revealed: Reveal 1 encounter card for each quest card in play.")
                .WithShadow("Shadow: Defending player discards 1 attachment for each quest card in play.")
                .WithInfo(50, 2, Artist.Dleoblack)
                .WithEasyModeQuantity(1));
            Cards.Add(Card.EncounterSideQuest("Lost in the Wilderness", "3C8C30DE-F17A-4191-A0DF-C3A079251583", "Eriador Wilds", 4)
                .WithText("When Revealed: Each player places all cards in his hand facedown underneath Lost in the Wilderness.\r\nForced: When Lost in the Wilderness is defeated, return each card underneath it to its owner's hand.")
                .WithFlavor("You've lost your way in the vastness of Arnor. You must search around until you find your trail again.")
                .WithVictoryPoints(10)
                .WithInfo(51, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(new Card()
            {
                Title = "Make Camp",
                Id = "8C631517-6E71-43DD-93A6-383F4C1B2696",
                CardType = CardType.Encounter_Side_Quest,
                QuestPoints = 6,
                Keywords = new List<string> { "Surge." },
                Text = "Characters cannot be healed.\r\nResponse: After Make Camp is defeated, each player heals up to 3 damage from a hero he controls.",
                FlavorText = "Your companions are exhausted from tireless effort, but you must find a safe place to make camp before you can tend to their needs.",
                VictoryPoints = 10,
                Artist = Artist.Romana_Kendelic,
                Number = 55,
                Quantity = 1
            });
            Cards.Add(new Card()
            {
                Title = "Dead Lord",
                Id = "D5FE657C-31FF-4786-8A0F-234453CDFADA",
                CardType = CardType.Enemy,
                EngagementCost = 33,
                Threat = 3,
                Attack = 4,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Undead." },
                Text = "Forced: After Dead Lord engages you, put the topmost Undead enemy in the discard pile into play engaged with you.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, reveal 1 encounter card.",
                Artist = Artist.Florian_Devos,
                Number = 60,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Cursed Dead",
                Id = "A16D47E6-12B0-4EA2-A71E-F2786F0B1AF0",
                CardType = CardType.Enemy,
                EngagementCost = 27,
                Threat = 1,
                Attack = 3,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string> { "Undead." },
                Text = "When Revealed: Put each copy of Cursed Dead in the discard pile into play in the staging area.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if there is a copy of the defending character in its owner's discard pile).",
                Artist = Artist.Unknown,
                Number = 61,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Seal the Tomb",
                Id = "A07A38A1-29B9-409F-BCFA-8014AE5A8F78",
                CardType = CardType.Encounter_Side_Quest,
                QuestPoints = 6,
                Keywords = new List<string> { "Surge." },
                Text = "Forced: At the end of the refresh phase, discard the top 3 cards of the encounter deck. Return the topmost Undead enemy in the encounter discard pile to the staging area.",
                FlavorText = "The undead keep rising from the grave. For each one that you strike down, another takes its place. You must do something to stem the tide...",
                VictoryPoints = 10,
                Artist = Artist.Guillaume_Ducos,
                Number = 63,
                Quantity = 1
            });
        }
    }
}