using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheThreeTrials : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Three Trials";
            Abbreviation = "TTT";
            Number = 24;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";
            DisablePublicImages = true;

            Cards.Add(new Card()
            {
                Title = "Idraen",
                ImageType = Models.ImageType.Jpg,
                Id = "1AB9D3C4-C97E-4121-B08C-968839DABE6D",
                CardType = CardType.Hero,
                ThreatCost = 11,
                Willpower = 2,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Sphere = Models.Sphere.Spirit,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string>() { "Dúnedain.", "Ranger.", "Scout." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger.", "Scout." },
                Text = "Response: After a location is explored, ready Idraen.",
                FlavorText = "\"Where now are the Dúnedain, Elessar, Elessar? Why do thy kinsfolk wander afar?\" -Galadriel, The Two Towers",
                Number = 25,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new Card()
            {
                Title = "Rivendell Scout",
                ImageType = ImageType.Jpg,
                Id = "DACE5750-8E0F-4CBB-BF33-470792092026",
                CardType = CardType.Ally,
                Sphere = Models.Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string> { "Noldor.", "Scout." },
                Keywords = new List<string> { "Secrecy 2." },
                Text = string.Empty,
                FlavorText = "\"Elrond is sending Elves, and they will get in touch with the Rangers, and maybe with Thranduil's folk in Mirkwood.\" -Gandalf, The Fellowship of the Ring",
                Number = 26,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new Card()
            {
                Title = "Feigned Voices",
                ImageType = ImageType.Jpg,
                Id = "9B821B9F-6279-4EDF-8D1A-BF208C310AC9",
                CardType = CardType.Event,
                Sphere = Models.Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Combat Action: Return a Silvan ally you control to your hand to choose an enemy engaged with a player. That enemy cannot attack that player this phase.",
                FlavorText = "\"The three of us could not challenge a hundred, so we went ahead and spoke with feigned voices, leading them on into the wood.\" -Haldir, The Fellowship of the Ring",
                Number = 27,
                Artist = Artist.Sara_Betsy
            });
            Cards.Add(new Card()
            {
                Title = "Rúmil",
                NormalizedTitle = "Rumil",
                ImageType = ImageType.Jpg,
                Id = "56ADA7E6-4981-4BEB-851B-E12633FE1408",
                CardType = CardType.Ally,
                Sphere = Models.Sphere.Tactics,
                Quantity = 3,
                IsUnique = true,
                ResourceCost = 4,
                Willpower = 2,
                Attack = 2,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string> { "Silvan.", "Scout." },
                Keywords = new List<string> { "Ranged." },
                Text = "Response: After you play Rúmil from your hand, choose an enemy engaged with a player. Deal X damage to that enemy where X is the number of ranged characters you control.",
                FlavorText = "...the Company set out again, guided now by Haldir and his brother Rúmil. -The Fellowship of the Ring",
                Number = 28,
                Artist = Artist.Melanie_Maier
            });
            Cards.Add(new Card()
            {
                Title = "Elven Mail",
                ImageType = ImageType.Jpg,
                Id = "5AA8270F-DA60-4B28-8B8C-6EFB1D0E012C",
                CardType = CardType.Attachment,
                Sphere = Models.Sphere.Tactics,
                Quantity = 3,
                ResourceCost = 2,
                Traits = new List<string> { "Item.", "Armor." },
                Keywords = new List<string> { "Restricted." },
                Text = "Attach to a Noldor or Silvan character.\r\nAttached character gets +2 hit points and gains sentinel.",
                FlavorText = "...they were tall and and clad in grey mail, and from their shoulders hung long white cloaks. -The Fellowship of the Ring",
                Number = 29,
                Artist = Artist.Sara_Betsy
            });
            Cards.Add(new Card()
            {
                Title = "Greyflood Wanderer",
                ImageType = ImageType.Jpg,
                Id = "02F7C276-FDBE-4574-915D-3FC01B479879",
                CardType = CardType.Ally,
                Sphere = Models.Sphere.Spirit,
                Quantity = 3,
                ResourceCost = 3,
                Willpower = 2,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string>() { "Dúnedain.", "Scout." },
                NormalizedTraits = new List<string> { "Dunedain.", "Scout." },
                Text = "You may give Greyflood Wanderer doomed 2 when you play from your hand. If you do, it gains: \"Response: After you play Greyflood Wanderer, place 1 progress token on each location in play.\"",
                FlavorText = "...others had gone west, and with the help of Aragorn and the Rangers had searched the lands far down the Greyflood... -The Fellowship of the Ring",
                Number = 30,
                Artist = Artist.Arden_Beckwith
            });
            Cards.Add(new Card()
            {
                Title = "Warden of Arnor",
                ImageType = ImageType.Jpg,
                Id = "12423D4F-1E04-48C2-96A8-3E012DB954AA",
                CardType = CardType.Attachment,
                Sphere = Models.Sphere.Spirit,
                IsUnique = true,
                Quantity = 3,
                ResourceCost = 1,
                Traits = new List<string> { "Title." },
                Text = "Attach to a Scout hero.\r\nWhile attached character is committed to the quest, place 1 progress on the first location revealed by the encounter deck each round.",
                FlavorText = "\"I have had a hard life and a long: and the leagues that lie between here and Gondor are a small part in the count of my journeys.\" -Aragorn, The Fellowship of the Ring",
                Number = 31,
                Artist = Artist.Melanie_Maier
            });
            Cards.Add(new Card()
            {
                Title = "Message from Elrond",
                ImageType = ImageType.Jpg,
                Id = "D1C87F36-6371-47B1-90D1-E5A5767050F9",
                CardType = CardType.Event,
                Sphere = Models.Sphere.Lore,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Action: Choose a player. That player may choose 1 card from his hand and add it to another player's hand. At the end of the round, if the chosen card is in that player's hand or in play, shuffle it into its owner's deck.",
                FlavorText = "\"But we have heard rumours of your coming, for the messengers of Elrond passed by Lórien on the way home up the Dimrill Stair. -Haldir, The Fellowship of the Ring",
                Number = 32,
                Artist = Artist.Arden_Beckwith
            });
            Cards.Add(new Card()
            {
                Title = "Noiseless Movement",
                ImageType = ImageType.Jpg,
                Id = "EBC8BD16-93D7-483D-B001-E0C21D727B31",
                CardType = CardType.Event,
                Sphere = Models.Sphere.Lore,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Action: Choose an enemy in the staging area. That enemy does not make engagement checks this round. Then, if your threat is 20 or less and this is the first time you played a copy of Noiseless Movement this round, return this card to your hand instead of discarding it.",
                FlavorText = "...the woodland folk were altogether noiseless in their movements. -The Fellowship of the Ring",
                Number = 33,
                Artist = Artist.Jordy_Lakiere
            });
            Cards.Add(new Card()
            {
                Title = "Leaf Brooch",
                ImageType = ImageType.Jpg,
                Id = "4C52BE83-0B8F-4D9A-A54D-4D8BF23B34A4",
                CardType = CardType.Attachment,
                Quantity = 3,
                ResourceCost = 1,
                Sphere = Sphere.Neutral,                
                Traits = new List<string> { "Item." },
                Text = "Attach to a hero. Limit 1 per hero.\r\nThe first event card you play each round that matches attached hero's printed sphere gains secrecy 1.",
                FlavorText = "Each cloak was fastened about the neck with a brooch like a green leaf veined with silver. -The Fellowship of the Ring",
                Number = 34,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card()
            {
                Title = "The Trials Begin",
                ImageType = ImageType.Jpg,
                HasSecondImage = true,
                Id = "C3367A1E-7110-4025-8274-DBA2836778BC",
                CardType = Models.CardType.Quest,
                Quantity = 1,
                StageNumber = 1,
                QuestPoints = null,
                FlavorText = "At the edge of a cursed forest, the Boar Shaman explains that you must undertake three trials in order to recover the Antlered Crown, or face death. Each trial will test your worthiness. Guardian spirits watch over three sacred swords, protecting them from the undeserving.",
                Text = "Setup: Set aside all 3 Guardian enemies, all 3 Key objectives, all 3 Barrow locations, and Hallowed Circle.",
                OppositeText = "When Revealed: The players advance to a stage 2A quest of their choice.",
                OppositeFlavorText = "Three ancient barrows mark the locations for the trials, each the resting place of a different guardian spirit. The Boar Clan waits at the forest's edge for any sign of your victory... or your death. Your only option is to press onward, heading towards the site of one of the three trials...",
                EncounterSet = "The Three Trials",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.AncientForest },
                Number = 35,
                Artist = Artist.Dleoblack
            });
            Cards.Add(new Card()
            {
                Title = "The Trial of Strength",
                ImageType = ImageType.Jpg,
                HasSecondImage = true,
                Id = "704201A2-5A88-465A-B304-1AF7CBCEA156",
                CardType = CardType.Quest,
                Quantity = 1,
                StageNumber = 2,
                QuestPoints = null,
                FlavorText = "A rotting corpse guards the inner chamber of this barrow, holding in its grasp a worn sword that looks like one of the keys the Boar Shaman described to you. When you reach for the key, the guardian springs to life and attacks you!",
                Text = "When Revealed: Randomly choose 1 of the remaining set aside Guardian enemies and 1 of the remaining set aside Barrow locations, reveal them, and add them to the staging area. Find the set aside Key objective that shares a Trait with the just revealed Guardian enemy and attach it to that enemy.",
                OppositeText = 
@"Each Guardian enemy engages the first player. Barrow locations cannot be the active location and are immune to player card effects.

When the players control the current trial's Key objective, add all Barrow locations in play to the victory display and immediately advance to a stage 2A of the players' choice. If all stage 2 quests have been defeated, advance to stage 3A, instead.",
                EncounterSet = "The Three Trials",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.AncientForest },
                Number = 36,
                Artist = Artist.Matt_Bradbury
            });
            Cards.Add(new Card()
            {
                Title = "The Trial of Perseverance",
                ImageType = ImageType.Jpg,
                HasSecondImage = true,
                Id = "AF8B9515-2CCE-45CC-BB9C-D77733AD45F4",
                CardType = CardType.Quest,
                Quantity = 1,
                StageNumber = 2,
                QuestPoints = null,
                FlavorText = "A huge barrow towers before you, cold mist enveloping the entrance. The key is somewhere inside, but a heavy chill fills you with dread and unease...",
                Text = "When Revealed: Randomly choose 1 of the remaining set aside Barrow locations and add it to the staging area. Then, randomly choose 1 of the remaining set aside Key objectives and attach it to that Barrow location. Find the set aside Guardian enemy that shares a Trait with the Key objective in play and reveal it, adding it to the staging area.",
                OppositeText =
@"Each Guardian enemy engages the first player. Guardian enemies cannot be damaged or leave play except by quest effect.

When the players control the current trial's Key objective, add all Guardian enemies in play to the victory display and immediately advance to a stage 2A of the players' choice. If all stage 2 quests have been defeated, advance to stage 3A, instead.",
                EncounterSet = "The Three Trials",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.AncientForest },
                Number = 37,
                Artist = Artist.Silver_Saaremael
            });
            Cards.Add(new Card()
            {
                Title = "The Trial of Intuition",
                ImageType = ImageType.Jpg,
                HasSecondImage = true,
                Id = "3C484CBD-ADFF-4C20-8AF3-FDFAD91C50EA",
                CardType = CardType.Quest,
                Quantity = 1,
                StageNumber = 2,
                QuestPoints = null,
                FlavorText = "You have found the barrow where the trial should take place, but the key cannot be found. You are sure the key's guardian is watching you... Where is the key?",
                Text = "When Revealed: Randomly choose 1 of the remaining set aside Guardian enemies and 1 of the remaining set aside Barrow locations, reveal them, and add them to the staging area. Shuffle the encounter discard pile into the encounter deck. Find the set aside Key objective that shares a Trait with the just revealed Guardian enemy and suffle it into the bottom 10 cards of the encounter deck.",
                OppositeText =
@"Each Guardian enemy engages the first player. Any time players would place progress on this quest, discard an equal number of cards from the encounter deck instead. (Progress is placed on the active location before triggering this effect.)

When the players control the current trial's Key objective, add all Guardian enemies and Barrow locations in play to the victory display and immediately advance to a stage 2A of the players' choice. If all stage 2 quests have been defeated, advance to stage 3A, instead.",
                EncounterSet = "The Three Trials",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.AncientForest },
                Number = 38,
                Artist = Artist.Matt_Bradbury
            });
            Cards.Add(new Card()
            {
                Title = "The Antlered Crown",
                ImageType = ImageType.Jpg,
                HasSecondImage = true,
                Id = "9331EBC1-B5A5-407F-9841-D753BD080546",
                CardType = CardType.Quest,
                Quantity = 1,
                StageNumber = 3,
                QuestPoints = 1,
                FlavorText = "You have finally completed the trials and recovered each key. None have made it this far before. You hasten to the hallowed circle in the center of the forest. All that's left is to insert the hilts of these swords into the marked stone the shaman described, and the Antlered Crown will be yours. As you advance, a thick fog gathers around you and growing dread tugs at your mind.",
                Text = "When Revealed: Add Hallowed Circle to the staging area. Reveal each Guardian enemy in the victory display, adding them to the staging area.",
                OppositeFlavorText = "Out of the fog, the angry guardian spirits emerge once more, determined to stop you from retrieving the crown. You desperately rush to the circle while fending them off.",
                OppositeText = 
@"Each Guardian enemy engages the player who controls the Key objective with a Trait shared by that enemy.

Players cannot defeat this stage unless Hallowed Circle is in the victory display. If the players defeat this stage, they win the game.",
                EncounterSet = "The Three Trials",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.AncientForest },
                Number = 39,
                Artist = Artist.Claudio_Pozas
            });
            Cards.Add(new Card()
            {
                Title = "Boar's Guardian",
                ImageType = ImageType.Jpg,
                Id = "FE9E3B29-2686-4E9B-B52C-741B807CF527",
                CardType = Models.CardType.Enemy,
                IsUnique = true,
                Quantity = 1,
                EngagementCost = 50,
                Threat = 1,
                Attack = 4,
                Defense = 4,
                HitPoints = 10,
                Traits = new List<string> { "Guardian.", "Boar." },
                Keywords = new List<string> { "Time 2." },
                Text = "Cannot have non-Key attachments.\r\nForced: After the last time counter is removed from Boar's Guardian, the engaged player must discard an ally he controls. Place 2 time counters on Boar's Guardian.",
                VictoryPoints = 3,
                EncounterSet = "The Three Trials",
                Number = 40,
                Artist = Artist.Alexander_Kozachenko
            });
            Cards.Add(new Card()
            {
                Title = "Wolf's Guardian",
                ImageType = ImageType.Jpg,
                Id = "AD0ABA5C-2151-4332-BBB8-ECACF73694C2",
                CardType = Models.CardType.Enemy,
                IsUnique = true,
                Quantity = 1,
                EngagementCost = 50,
                Threat = 2,
                Attack = 5,
                Defense = 3,
                HitPoints = 12,
                Traits = new List<string> { "Guardian.", "Wolf." },
                Keywords = new List<string> { "Time 3." },
                Text = "Cannot have non-Key attachments.\r\nForced: After the last time counter is removed from Wolf's Guardian, it makes an immediate attack against the engaged player. Place 3 time counters on Wolf's Guardian.",
                VictoryPoints = 3,
                EncounterSet = "The Three Trials",
                Number = 41,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card()
            {
                Title = "Raven's Guardian",
                ImageType = ImageType.Jpg,
                Id = "9D1F0475-0703-4FE3-8A29-81E521D69ADB",
                CardType = Models.CardType.Enemy,
                IsUnique = true,
                Quantity = 1,
                EngagementCost = 50,
                Threat = 3,
                Attack = 3,
                Defense = 5,
                HitPoints = 8,
                Traits = new List<string> { "Guardian.", "Raven." },
                Keywords = new List<string> { "Time 4." },
                Text = "Cannot have non-Key attachments.\r\nForced: After the last time counter is removed from Raven's Guardian, deal 1 damage to each character controlled by the engaged player. Place 4 time counters on Raven's Guardian.",
                VictoryPoints = 3,
                EncounterSet = "The Three Trials",
                Number = 42,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card()
            {
                Title = "Key of the Boar",
                ImageType = ImageType.Jpg,
                Id = "FB7F9E37-61DD-4BD2-BEA2-5035DC8FC4FE",
                CardType = Models.CardType.Objective,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string> { "Item.", "Key.", "Boar." },
                Text = 
@"If unattached, the first player must claim Key of the Boar and attach it to a hero he controls.

If Key of the Boar is discarded, add it to the staging area.",
                Shadow = "Shadow: Shuffle Key of the Boar back into the encounter deck.",
                EncounterSet = "The Three Trials",
                Number = 43,
                Artist = Artist.Ellyson_Ferrari_Lifante
            });
            Cards.Add(new Card()
            {
                Title = "Key of the Wolf",
                ImageType = ImageType.Jpg,
                Id = "DC98A8D8-3232-487E-8581-41128F6BD3C2",
                CardType = Models.CardType.Objective,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string> { "Item.", "Key.", "Wolf." },
                Text = 
@"If unattached, the first player must claim Key of the Wolf and attach it to a hero he controls.

If Key of the Wolf is discarded, add it to the staging area.",
                Shadow = "Shadow: Shuffle Key of the Wolf back into the encounter deck.",
                EncounterSet = "The Three Trials",
                Number = 44,
                Artist = Artist.Ellyson_Ferrari_Lifante
            });
            Cards.Add(new Card()
            {
                Title = "Key of the Raven",
                ImageType = ImageType.Jpg,
                Id = "E723AC0A-3193-4759-A86B-58A2FA904EB5",
                CardType = Models.CardType.Objective,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string> { "Item.", "Key.", "Raven." },
                Text = 
@"If unattached, the first player must claim Key of the Raven and attach it to a hero he controls.

If Key of the Raven is discarded, add it to the staging area.",
                Shadow = "Shadow: Shuffle Key of the Raven back into the encounter deck.",
                EncounterSet = "The Three Trials",
                Number = 45,
                Artist = Artist.Ellyson_Ferrari_Lifante
            });
            Cards.Add(new Card()
            {
                Title = "Hill Barrow",
                ImageType = ImageType.Jpg,
                Id = "F7A746AE-3F01-42D2-8BBA-7E87CE46F4DF",
                CardType = Models.CardType.Location,
                Quantity = 1,
                Threat = 4,
                QuestPoints = 6,
                Traits = new List<string> { "Barrow.", "Forest.", "Hills." },
                Text = "Forced: When a Guardian enemy attacks, deal it 1 additional shadow card.",
                FlavorText = "They heard of the Great Barrows, and the green mounds, and the stone-rings upon the hills and in the hollows among the hills. -The Fellowship of the Ring",
                VictoryPoints = 2,
                EncounterSet = "The Three Trials",
                Number = 46,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "Cave Barrow",
                ImageType = ImageType.Jpg,
                Id = "B3DD5D12-DB0F-4096-8F5F-D73D22185C23",
                CardType = Models.CardType.Location,
                Quantity = 1,
                Threat = 3,
                QuestPoints = 8,
                Traits = new List<string> { "Barrow.", "Forest.", "Hills." },
                Text = "The players, as a group, cannot have more than 5 allies in play. (If there are more than 5 allies in play, discard allies until only 5 remain.)",
                FlavorText = "Raising himself on one arm he looked, and saw now in the pale light that they were in a kind of passage which behind them turned a corner. -The Fellowship of the Ring",
                EncounterSet = "The Three Trials",
                Number = 47,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "Stone Barrow",
                ImageType = ImageType.Jpg,
                Id = "3ECA9B52-EBEC-490C-A6F8-6B1F48818B6F",
                CardType = Models.CardType.Location,
                Quantity = 1,
                Threat = 2,
                QuestPoints = 10,
                Traits = new List<string> { "Barrow.", "Forest.", "Hills." },
                Text = "Forced: After a Guardian enemy attacks, raise each player's threat by X, where X is that enemy's Threat.",
                FlavorText = "Stone rings grinned out of the ground like broken teeth in the moonlight. -The Fellowship of the Ring",
                VictoryPoints = 2,
                EncounterSet = "The Three Trials",
                Number = 48,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "Hallowed Circle",
                ImageType = ImageType.Jpg,
                Id = "394D9B67-A302-4493-8D3F-497F5327DD4A",
                CardType = Models.CardType.Location,
                IsUnique = true,
                Quantity = 1,
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = 12,
                Traits = new List<string> { "Forest.", "Hills." },
                Text =
@"Immune to player card effects. X is the number of players in the game.

Travel: The players must exhaust 3 Key objectives.

Forced: After the players travel here, each engaged Guardian enemy makes an immediate attack.",
                VictoryPoints = 5,
                EncounterSet = "The Three Trials",
                Number = 49,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "Spirit of the Wild",
                ImageType = ImageType.Jpg,
                Id = "9D9C0590-43C6-434D-A277-CA2EE47B3132",
                CardType = Models.CardType.Enemy,
                Quantity = 5,
                EasyModeQuantity = 4,
                EngagementCost = 28,
                Threat = 1,
                Attack = 1,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Undead.", "Spirit." },
                Text = "Cannot have attachments.\r\nSpirit of the Wild gets +1 Threat and +1 Attack for each Key objectives the players control.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each Key objective the players control.",
                EncounterSet = "The Three Trials",
                Number = 50,
                Artist = Artist.Alexander_Kozachenko
            });
            Cards.Add(new Card()
            {
                Title = "Cursed Forest",
                ImageType = ImageType.Jpg,
                Id = "DEB14C86-8786-4166-A8CB-1D85CDDB350D",
                CardType = Models.CardType.Location,
                Quantity = 2,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Forest." },
                Text = "Travel: Search the encounter deck and discard pile for a Spirit enemy and add it to the staging area.",
                Shadow = "Shadow: If this attack destroys a character, remove a time counter from an enemy, if able.",
                EncounterSet = "The Three Trials",
                Number = 51,
                Artist = Artist.Anthony_Feliciano
            });
            Cards.Add(new Card()
            {
                Title = "Grim Foothills",
                ImageType = ImageType.Jpg,
                Id = "3B2A21DF-E6D2-4A3F-8F22-D059E32BB051",
                CardType = Models.CardType.Location,
                Quantity = 3,
                EasyModeQuantity = 2,
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = 3,
                Traits = new List<string> { "Hills." },
                Keywords = new List<string> { "Doomed 2." },
                Text = "X is the number of players in the game.\r\nWhile Grim Foothills is in the staging area, progress must be placed on Grim Foothills before it can be placed on the active location.",
                EncounterSet = "The Three Trials",
                Number = 52,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card()
            {
                Title = "Curse of the Wild Men",
                ImageType = ImageType.Jpg,
                Id = "E1286A47-B5AC-4F10-806E-8C2179AB3B7D",
                CardType = Models.CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "When Revealed: Deal 1 damage to each non-unique character in play. If the players control 3 Key objectives, Curse of the Wild Men gains surge.",
                Shadow = "Shadow: Attacking enemy gets +1 AQttack for each Key objective the players control.",
                EncounterSet = "The Three Trials",
                Number = 53,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card()
            {
                Title = "The Guardian's Fury",
                ImageType = ImageType.Jpg,
                Id = "75C803E2-AA34-4D40-BD00-7A17DA344842",
                CardType = Models.CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Each Guardian enemy makes an attack. If there are no Guardian enemies in play, reveal a random Guardian enemy from the victory display, and add it to the staging area.",
                Shadow = "If the attacking enemy is a Guardian, it makes an additional attack after this one.",
                EncounterSet = "The Three Trials",
                Number = 54,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card()
            {
                Title = "Wild Tenacity",
                ImageType = ImageType.Jpg,
                Id = "3CF889F6-7603-48C0-8A98-2B6DD5EC3633",
                CardType = Models.CardType.Treachery,
                Quantity = 3,
                EasyModeQuantity = 2,
                Text = "When Revealed: Remove X time counters from each enemy in play with the time keyword, where X is the number of players.",
                Shadow = "Shadow: If attacking enemy is a Guardian, deal it 2 additional shadow cards for this attack.",
                EncounterSet = "The Three Trials",
                Number = 55,
                Artist = Artist.Darek_Zabrocki
            });
        }
    }
}