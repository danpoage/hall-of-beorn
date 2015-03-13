using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheVoiceofIsengard : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Voice of Isengard";
            AlternateName = "Voice of Isengard";
            Abbreviation = "VoI";
            Number = 22;
            SetType = Models.SetType.Deluxe_Expansion;

            Cards.Add(new Card() {
                Title = "Éomer",
                ImageType = Models.ImageType.Png,
                NormalizedTitle = "Eomer",
                Id = "FE720A40-0522-4882-B8F4-5F3E4E120E67",
                CardType = CardType.Hero,
                ThreatCost = 10,
                Willpower = 1,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Sphere = Models.Sphere.Tactics,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string>() { "Rohan.", "Noble.", "Warrior." },
                Text = "Response: After a character leaves play, Éomer gets +2 Attack until the end of the round. (Limit once per round.)",
                FlavorText = "\"I am named Éomer son of Éomund, and am called the Third Marshal of Riddermark.\" -The Two Towers",
                Number = 1,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                Title = "Gríma",
                ImageType = Models.ImageType.Png,
                NormalizedTitle = "Grima",
                Id = "2BECB7B6-5D0C-46D1-83C3-DDE505ABEB5E",
                CardType = CardType.Hero,
                ThreatCost = 9,
                Willpower = 2,
                Attack = 1,
                Defense = 2,
                HitPoints = 3,
                Sphere = Models.Sphere.Lore,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string>() { "Rohan.", "Isengard." },
                Text = "Action: Lower the cost of the next card you play from your hand this round by 1. That card gains Doomed 1. (Limit once per round.)",
                FlavorText = "\"Let your counsellor Gríma keep all things till your return - and I pray that we may see it, though no wise man will deem it hopeful.\" -The Two Towers",
                Number = 2,
                SlugIncludesType = true,
                Artist = Artist.Matt_Stewart
            });
            Cards.Add(new Card() {
                Title = "Saruman",
                ImageType = Models.ImageType.Png,
                Id = "E0C9F997-2FC0-46AA-9B50-A8F8CDC6C31B",
                CardType = CardType.Ally,
                ResourceCost = 3,
                Willpower = 3,
                Attack = 5,
                Defense = 4,
                HitPoints = 4,
                Sphere = Models.Sphere.Neutral,
                IsUnique = true,
                Quantity = 3,
                Traits = new List<string>() { "Istari.", "Isengard." },
                Keywords = new List<string> { "Doomed 3." },
                Text = 
@"At the end of the round, discard Saruman from play.

Response: After Saruman enters play, choose a non-unique enemy or location in the staging area. While Saruman is in play, the chosen enemy or location is considered to be out of play.",
                Number = 3,
                Artist = Artist.Matt_Stewart
            });
            Cards.Add(new Card() {
                Title = "Orthanc Guard",
                ImageType = Models.ImageType.Png,
                Id = "9A940560-831D-4E4A-8C46-9BFA886B9465",
                CardType = CardType.Ally,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 0,
                Defense = 2,
                HitPoints = 2,
                Sphere = Models.Sphere.Leadership,
                IsUnique = false,
                Quantity = 3,
                Traits = new List<string>() { "Isengard." },
                Text = "Response: After you raise your threat from the Doomed keyword, ready Orthanc Guard.",
                FlavorText = "\"...the keepers of the gate were on the watch for me and told me that Saruman awaited me.\" -Gandalf, The Fellowship of the Ring",
                Number = 4,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new Card() {
                Title = "Isengard Messenger",
                ImageType = Models.ImageType.Png,
                Id = "70BF219C-AF95-42EE-A2CB-92448E63F276",
                CardType = CardType.Ally,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 0,
                Defense = 1,
                HitPoints = 2,
                Sphere = Models.Sphere.Lore,
                IsUnique = false,
                Quantity = 3,
                Traits = new List<string>() { "Isengard." },
                Text = "Response: After you raise your threat from the Doomed keyword, Isengard Messenger gets +1 Willpower until the end of the round. (Limit twice per round.)",
                FlavorText = "\"I have an urgent errand,\" he said. \"My news is evil.\" -Radagast, The Fellowship of the Ring",
                Number = 5,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new Card() {
                Title = "Westfold Outrider",
                ImageType = Models.ImageType.Png,
                Id = "76F84AE2-DDB9-4402-A7FA-7A3EA13F2190",
                CardType = CardType.Ally,
                ResourceCost = 2,
                Willpower = 0,
                Attack = 2,
                Defense = 1,
                HitPoints = 2,
                Sphere = Models.Sphere.Tactics,
                IsUnique = false,
                Quantity = 3,
                Traits = new List<string>() { "Rohan.", "Scout." },
                Text = "Action: Discard Westfold Outrider to choose an enemy not engaged with you. Engage the chosen enemy.",
                FlavorText = "\"Erkenbrand of Westfold has drawn off those men he could gather towards his fastness at Helm's Deep. The rest are scattered.\"-Rider of Rohan, The Two Towers",
                Number = 6,
                Artist = Artist.Diego_Gisbert_Llorens
            });
            Cards.Add(new Card() {
                Title = "Westfold Horse-breeder",
                ImageType = Models.ImageType.Png,
                Id = "C4287846-77C8-4685-A293-9165B180DBDD",
                CardType = CardType.Ally,
                ResourceCost = 1,
                Willpower = 1,
                Attack = 0,
                Defense = 0,
                HitPoints = 1,
                Sphere = Models.Sphere.Spirit,
                IsUnique = false,
                Quantity = 3,
                Traits = new List<string>() { "Rohan." },
                Text = "Response: After Westfold Horse-breeder enters play, search the top 10 cards of your deck for a Mount attachment and add it to your hand. Shuffle your deck.",
                FlavorText = "\"They love their horses next to their kin.\" -Boromir, The Fellowship of the Ring",
                Number = 7,
                Artist = Artist.Mike_Capprotti
            });
            Cards.Add(new Card() {
                Title = "Rohan Warhorse",
                ImageType = Models.ImageType.Png,
                Id = "FEB80BF1-5F72-49B4-BFDD-7D125529C23F",
                CardType = CardType.Attachment,
                ResourceCost = 1,
                Sphere = Models.Sphere.Tactics,
                IsUnique = false,
                Quantity = 3,
                Traits = new List<string>() { "Mount." },
                Keywords = new List<string> { "Restricted." },
                Text = "Attach to a Tactics or Rohan hero.\r\nResponse: After attached hero participates in an attack that destroys an enemy, exhaust Rohan Warhorse to ready attached hero.",
                FlavorText = "Their horses were of great stature, strong and clean-limbed... -The Two Towers",
                Number = 8,
                Artist = Artist.Jeff_Lee_Johnson
            });
            Cards.Add(new Card() {
                Title = "Silver Lamp",
                ImageType = Models.ImageType.Png,
                Id = "0FF953B2-66CB-4760-9F30-56066D94448C",
                CardType = CardType.Attachment,
                ResourceCost = 2,
                Sphere = Models.Sphere.Spirit,
                IsUnique = false,
                Quantity = 3,
                Traits = new List<string>() { "Item." },
                Text = "Attach to a Spirit hero.\r\nWhile attached hero is ready, shadow cards dealt to enemies engaged with you are dealt face up. ~(Shadow card effects are still resolved when resolving enemy attacks.)",
                FlavorText = "...one of them uncovered a small lamp that gave out a slender silver beam. -The Fellowship of the Ring",
                Number = 9,
                Artist = Artist.Owen_William_Weber
            });
            Cards.Add(new Card() {
                Title = "Keys of Orthanc",
                ImageType = Models.ImageType.Png,
                Id = "F61BB4CD-9239-4AD4-9869-985DE696FFDF",
                CardType = CardType.Attachment,
                ResourceCost = 1,
                Sphere = Models.Sphere.Neutral,
                IsUnique = true,
                Quantity = 3,
                Traits = new List<string>() { "Item." },
                Text = "Attach to a hero.\r\nResponse: After you raise your threat from the Doomed keyword, exhaust Keys of Othanc to add 1 resource to attached hero's resource pool.",
                FlavorText = "\"He has the Key of Orthanc\" -Gandalf, The Two Towers",
                Number = 10,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card(){
                Title = "Legacy of Númenor",
                NormalizedTitle = "Legacy of Numenor",
                ImageType = Models.ImageType.Png,
                Id = "9482929A-87C0-4993-8E76-D80E1A40C3DA",
                CardType = CardType.Event,
                ResourceCost = 0,
                Sphere = Models.Sphere.Leadership,
                IsUnique = false,
                Quantity = 3,
                Keywords = new List<string> { "Doomed 4." },
                Text = "Action: Add 1 resource to each hero's resource pool.",
                FlavorText = "\"...in the midst of that valley is a tower of stone called Orthanc. It was not made by Saruman, but by the Men of Númenor long ago: and it is very tall and has many secrets...\" -Gandalf, The Fellowship of the Ring",
                Number = 11,
                Artist = Artist.Matt_Stewart
            });
            Cards.Add(new Card() {
                Title = "Deep Knowledge",
                ImageType = Models.ImageType.Png,
                Id = "E68FD84E-D79D-42D6-85B1-8DF6B7F5FDC8",
                CardType = CardType.Event,
                ResourceCost = 0,
                Sphere = Models.Sphere.Lore,
                IsUnique = false,
                Quantity = 3,
                Keywords = new List<string> { "Doomed 2." },
                Text = "Action: Each player draws 2 cards.",
                FlavorText = "\"His knowledge is deep, but his pride has grown with it...\" -Gandalf, The Fellowship of the Ring",
                Number = 12,
                Artist = Artist.Titus_Lunter
            });
            Cards.Add(new Card() {
                Title = "The Wizards's Voice",
                ImageType = Models.ImageType.Png,
                Id = "AB0B49A0-3A74-433F-AED3-206964FABD18",
                CardType = CardType.Event,
                ResourceCost = 0,
                Sphere = Models.Sphere.Tactics,
                IsUnique = false,
                Quantity = 3,
                Traits = new List<string>() { "Spell." },
                Keywords = new List<string> { "Doomed 3." },
                Text = "Action: Each player chooses 1 enemy engaged with him. Until the end of the phase, each chosen enemy cannot attack the player that chose it.",
                FlavorText = "...it was a delight to hear the voice speaking, all that it said seemed wise and reasonable... -The Two Towers",
                Number = 13,
                Artist = Artist.Andrew_Johanson
            });
            Cards.Add(new Card() {
                Title = "Power of Orthanc",
                ImageType = Models.ImageType.Png,
                Id = "19FE9EB6-82EE-4967-9381-E9E7C97B2463",
                CardType = CardType.Event,
                ResourceCost = 0,
                Sphere = Models.Sphere.Spirit,
                IsUnique = false,
                Quantity = 3,
                Traits = new List<string>() { "Spell." },
                Keywords = new List<string> { "Doomed 2." },
                Text = "Action: Each player may choose and discard a Condition attachment from play.",
                FlavorText = "\"But Saruman has long studied the arts of the Enemy himself, and thus we have often been able to forestall him.\" -Gandalf, The Fellowship of the Ring",
                Number = 14,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new Card() {
                Title = "The Seeing-stone",
                ImageType = Models.ImageType.Png,
                Id = "F54077B5-277B-4E73-ADE0-98D0EA9EC2AC",
                CardType = CardType.Event,
                ResourceCost = 0,
                Sphere = Models.Sphere.Neutral,
                IsUnique = false,
                Quantity = 3,
                Keywords = new List<string> { "Doomed 1." },
                Text = "Action: Search your deck for a card with the Doomed keyword and add it to your hand. Shuffle your deck.",
                FlavorText = "\"...alone it could do nothing but see small images of things far off and days remote.\" -Gandalf, The Two Towers",
                Number = 15,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card() {
                Title = "Gríma",
                NormalizedTitle = "Grima",
                ImageType = ImageType.Png,
                Id = "C6DFAF1C-E925-4EF2-A5F2-E0B30B2BC8A8",
                CardType = CardType.Objective_Ally,
                SlugIncludesType = true,
                EncounterSet = "The Fords of Isen",
                Willpower = 2,
                Attack = 1,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Rohan." },
                Text = 
@"If free of encounters, the first player gains control of Gríma.

Action: Exhaust Grima to draw a card.

If Gríma leaves play, the players lose the game.",
                FlavorText = "Behind him cringing between two other men, came Gríma the Wormtongue. -The Two Towers",
                Quantity = 1,
                Number = 16,
                Artist = Artist.Nacho_Molina
            });
            Cards.Add(new Card() {
                Title = "The Islet",
                IsUnique = true,
                ImageType = ImageType.Png,
                Id = "ED21A7D1-B4EF-4BDD-B998-CACE0FA163BD",
                CardType = CardType.Location,
                EncounterSet = "The Fords of Isen",
                Threat = 1,
                QuestPoints = 1,
                Traits = new List<string> { "River." },
                Text = "Immune to player card effects.\r\nWhile Iselet is the active location, each Dunland enemy in play gets +1 Threat.",
                FlavorText = "There were three lines of flat stepping-stones across the stream, and between them fords for horses, that went from either brink to a bare eyot in the midst. -The Two Towers",
                Quantity = 1,
                EasyModeQuantity = 1,
                Number = 17,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new Card()
            {
                Title = "Fords of Isen",
                ImageType = ImageType.Png,
                Id = "4E8365C0-15F6-44AC-A6A8-FBDDFEE22A14",
                CardType = CardType.Location,
                EncounterSet = "The Fords of Isen",
                Threat = 3,
                QuestPoints = 4,
                Traits = new List<string> { "River." },
                Text = "While Fords of Isen is in the staging area, players cannot gain resources from card effects.\r\n\r\nForced: After Fords of Isen becomes the active location, each player with fewer than 5 cards in his hand draws cards until he has 5 in his hand.",
                FlavorText = "The road dipped between rising turf-banks, carving its way through the terraces to the river's edge, and up again upon the further side. -The Two Towers",
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 18,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card()
            {
                Title = "The King's Road",
                ImageType = ImageType.Png,
                Id = "86CB2BA1-EC96-45E3-97A0-9615BB11B6A7",
                CardType = CardType.Location,
                EncounterSet = "The Fords of Isen",
                Threat = 2,
                QuestPoints = 2,
                Traits = new List<string> { "Road." },
                Text = "While any player has 3 or more cards in hand, The King's Road gets +3 quest points.\r\n\r\nWhile any player has 5 or more cards in hand, The King's Road gains: \"When faced with the option to travel, the players must travel to The King's Road, if able.\"",
                Quantity = 2,
                EasyModeQuantity = 2,
                Number = 19,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card()
            {
                Title = "Gap of Rohan",
                ImageType = ImageType.Png,
                Id = "FB63AD99-2F89-4DE6-B5C1-BF9DB78D45E0",
                CardType = CardType.Location,
                EncounterSet = "The Fords of Isen",
                Threat = 2,
                QuestPoints = 3,
                Traits = new List<string> { "Valley." },
                Text = "While Gap of Rohan is in the staging area, Dunland enemies get +1 Attack.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, remove 1 time counter from the current quest.",
                Quantity = 4,
                EasyModeQuantity = 2,
                Number = 20,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card()
            {
                Title = "Pillaging and Burning",
                ImageType = ImageType.Png,
                Id = "880C9C97-3664-4EE1-8E96-00F96D4D9D0A",
                CardType = CardType.Treachery,
                EncounterSet = "The Fords of Isen",
                Text = "When Revealed: Each player draws a card. Each player raises his threat by 1 for each card in his hand.",
                Shadow = "Shadow: Defending player discards an attachment he controls (each attachment he controls instead if this attack is undefended).",
                Quantity = 2,
                EasyModeQuantity = 1,
                Number = 21,
                Artist = Artist.Sabin_Boykinov
            });
            Cards.Add(new Card()
            {
                Title = "Down from the Hills",
                ImageType = ImageType.Png,
                Id = "F3203B8D-A669-4693-8F72-D53508462C16",
                CardType = CardType.Treachery,
                EncounterSet = "The Fords of Isen",
                Text = "When Revealed: Each player must choose: Either remove 1 time counter from the current quest, or search the encounter deck and discard pile for a Dunland enemy, reveal it, and add it to the staging area. Shuffle the encounter deck. If any player has 5 or more cards in hand, this effect cannot be canceled.",
                Quantity = 1,
                EasyModeQuantity = 0,
                Number = 22,
                Artist = Artist.David_Horne
            });
            Cards.Add(new Card()
            {
                Title = "Ill Tidings",
                ImageType = ImageType.Png,
                Id = "66EE86BE-D5D4-41AC-97F1-610110F3EB02",
                CardType = CardType.Treachery,
                EncounterSet = "The Fords of Isen",
                Text = "When Revealed: The first player draws this card into his hand. Ill Tidings cannot leave that player's hand. Then, if the first player has 5 or more cards in his hand, Ill Tidings gains surge.",
                FlavorText = "\"Troubles follow you like crows, and ever the oftener the wrose.\" -Gríma, The Two Towers",
                Quantity = 2,
                EasyModeQuantity = 2,
                Number = 23,
                Artist = Artist.John_Gravato
            });
            Cards.Add(new Card()
            {
                Title = "Mugash",
                IsUnique = true,
                SlugIncludesType = true,
                ImageType = ImageType.Png,
                Id = "EB8CE576-9546-4D19-9070-F7D47638E069",
                CardType = CardType.Enemy,
                EncounterSet = "To Catch an Orc",
                EngagementCost = 1,
                Threat = 4,
                Attack = 7,
                Defense = 4,
                HitPoints = 8,
                Traits = new List<string> { "Orc.", "Uruk." },
                Text = "Cannot have attachments.\r\nForced: After Mugash is defeated, the first player attaches a hero he controls and exhausts that hero. (Counts as a Captive attachment with the text: \"Attached hero cannot ready. If attached hero leaves play, the players lose the game.\")",
                Quantity = 1,
                EasyModeQuantity = 1,
                Number = 24,
                Artist = Artist.Brent_Hollowel
            });
            Cards.Add(new Card()
            {
                Title = "Mugash's Guard",
                ImageType = ImageType.Png,
                Id = "E0BA3FAF-C260-45B8-A918-CE2A74E1920B",
                CardType = CardType.Enemy,
                EncounterSet = "To Catch an Orc",
                EngagementCost = 40,
                Threat = 3,
                Attack = 6,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Orc.", "Uruk." },
                Text = "While a player controls a hero with Mugash attached, Mugash's Guard engages that player.\r\n\r\nForced: After Mugash's Guard destroys a character, if Mugash is attached to a hero, return Mugash to the staging area.",
                VictoryPoints = 3,
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 25,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card()
            {
                Title = "Methedras Orc",
                ImageType = ImageType.Png,
                Id = "83B385DA-EB5D-4B20-8C6E-E3133C9CF29F",
                CardType = CardType.Enemy,
                EncounterSet = "To Catch an Orc",
                EngagementCost = 30,
                Threat = 3,
                Attack = 5,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Orc." },
                Text = "Forced: When Methedras ~Orc attacks, the defending player shuffles 1 random card from his hand into his out-of-play deck.",
                Shadow = "Shadow: If this attack destroys a character, remove 1 time counter from the current quest.",
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 26,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card()
            {
                Title = "Methedras",
                ImageType = ImageType.Png,
                Id = "11C24A02-4D8F-4D49-9A55-04348FD61C18",
                CardType = CardType.Location,
                EncounterSet = "To Catch an Orc",
                Threat = 2,
                QuestPoints = 3,
                Traits = new List<string> { "Mountain." },
                Text = "While Methedras is the active location, each location in the staging area gets +1 Threat.\r\n\r\nForced: When Methedras leaves play as an explored location, each player Searches 3.",
                FlavorText = "Beyond there glimmered far away, as if floating on a grey cloud, the white head of tall Methedras, the last peak of the Misty Mountains. -The Two Towers",
                Quantity = 4,
                EasyModeQuantity = 4,
                Number = 27,
                Artist = Artist.Stacey_Diana_Clark
            });
            Cards.Add(new Card()
            {
                Title = "Orc Cave",
                ImageType = ImageType.Png,
                Id = "472DE81E-675F-4A0C-BD30-A22E415884A9",
                CardType = CardType.Location,
                EncounterSet = "To Catch an Orc",
                Threat = 3,
                QuestPoints = 4,
                Traits = new List<string> { "Mountain.", "Cave." },
                Text = "Forced: After ~Orc Cave leaves play as an explored location, the first player Searches 5.\r\n\r\nTravel: Discard the top X cards of the encounter deck to travel here. X is the number of players in the game. Add each Orc enemy discarded this way to the staging area.",
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 28,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card()
            {
                Title = "Mugash's Lair",
                ImageType = ImageType.Png,
                Id = "29B4F4B0-7C3B-4702-A24B-92FF83D3F6B9",
                CardType = CardType.Location,
                EncounterSet = "To Catch an Orc",
                Threat = 4,
                QuestPoints = 2,
                Traits = new List<string> { "Mountain.", "Cave." },
                Text = "Forced: At the beginning of the encounter phase, reveal the top card of each player's out-of-play deck. Add each revealed enemy to the staging area and discard the rest.",
                Shadow = "Shadow: Defending player discards an attachment he controls.",
                Quantity = 2,
                EasyModeQuantity = 2,
                Number = 29,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card()
            {
                Title = "Orc Territory",
                ImageType = ImageType.Png,
                Id = "08040309-1CF0-401B-9125-E6A7D0E1B875",
                CardType = CardType.Treachery,
                EncounterSet = "To Catch an Orc",
                Text = "When Revealed: Each player searches the encounter deck and discard pile for a location and adds it to the staging area. If the total Threat in the staging area is less than the total Willpower of all characters committed to the quest, each Orc enemy engaged with a player makes an immediate attack.",
                Quantity = 2,
                EasyModeQuantity = 0,
                Number = 30,
                Artist = Artist.Joel_Hustak
            });
            Cards.Add(new Card()
            {
                Title = "Mugash",
                IsUnique = true,
                SlugIncludesType = true,
                ImageType = ImageType.Png,
                Id = "D926470B-02E3-4A06-9428-5F3F5186E62A",
                CardType = CardType.Objective,
                EncounterSet = "Into Fangorn",
                Traits = new List<string> { "Orc.", "Uruk." },
                Keywords = new List<string> { "Guarded." },
                Text = "Action: Exhaust a hero to claim this objective when it is free of encounters. Attach Mugash to that hero.\r\n\r\nForced: After attached hero takes damage, return Mugash to the top of the encounter deck.",
                Quantity = 1,
                EasyModeQuantity = 1,
                Number = 31,
                Artist = Artist.Brent_Hollowel
            });
            Cards.Add(new Card()
            {
                Title = "Edge of Fangorn",
                IsUnique = true,
                ImageType = ImageType.Png,
                Id = "12EE099F-7D5D-42FB-8A09-4420030CAA3C",
                CardType = CardType.Location,
                EncounterSet = "Into Fangorn",
                Threat = 2,
                QuestPoints = 2,
                Traits = new List<string> { "Forest." },
                Text = "Immune to player card effects.\r\nTravel: Search the encounter deck and discard pile for a Huorn enemy and add it to the staging area to travel here (2 Huorn enemies instead if there are 3 or more players in the game).",
                FlavorText = "\"...we are on the very edge of Fangorn, and it is perilous to touch the trees of that wood, it is said.\"\r\n-Aragorn, The Two Towers",
                VictoryPoints = 1,
                Quantity = 1,
                EasyModeQuantity = 1,
                Number = 32,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new Card()
            {
                Title = "Dark-Hearted Huorn",
                ImageType = ImageType.Png,
                Id = "E8C84525-B138-47D8-9761-9336A87A9A77",
                CardType = CardType.Enemy,
                EncounterSet = "Into Fangorn",
                EngagementCost = 1,
                Threat = 2,
                Attack = 4,
                Defense = 4,
                HitPoints = 5,
                Traits = new List<string> { "Huorn." },
                Keywords = new List<string> { "Hinder." },
                Text = "Cannot have attachments.\r\nForced: At the beginning of each resource phase, the engaged player must raise his threat by 2.",
                FlavorText = "\"There is a great power in them, and they seem able to wrap themselves in shadow...\" -Merry, The Two Towers",
                Quantity = 4,
                EasyModeQuantity = 3,
                Number = 33,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new Card()
            {
                Title = "Angry Huorn",
                ImageType = ImageType.Png,
                Id = "599FBFC7-1864-4959-9096-7531741C5004",
                CardType = CardType.Enemy,
                EncounterSet = "Into Fangorn",
                EngagementCost = 38,
                Threat = 3,
                Attack = 5,
                Defense = 4,
                HitPoints = 8,
                Traits = new List<string> { "Huorn." },
                Keywords = new List<string> { "Hinder." },
                Text = "Cannot have attachments.\r\nForced: At the beginning of each resource phase, Angry Huorn attacks the engaged player.",
                FlavorText = "\"I should be terrified of meeting them, if there were no true Ents about to look after them.\" -Merry, The Two Towers",
                Quantity = 3,
                EasyModeQuantity = 2,
                Number = 34,
                Artist = Artist.Jim_Pavelec
            });
            Cards.Add(new Card()
            {
                Title = "Deadly Huorn",
                ImageType = ImageType.Png,
                Id = "C56394C3-4953-4896-8D47-3E84547D4789",
                CardType = CardType.Enemy,
                EncounterSet = "Into Fangorn",
                EngagementCost = 34,
                Threat = 2,
                Attack = 3,
                Defense = 4,
                HitPoints = 6,
                Traits = new List<string> { "Huorn." },
                Keywords = new List<string> { "Hinder." },
                Text = "Cannot have attachments.\r\nForced: At the beginning of each resource phase, the engaged player must deal 3 damage to a character he controls.",
                FlavorText = "\"We could not see them, of course, but the whole air was full of creaking.\" -Merry, The Two Towers",
                Quantity = 3,
                EasyModeQuantity = 2,
                Number = 35,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new Card()
            {
                Title = "Heart of Fangorn",
                ImageType = ImageType.Png,
                Id = "4B4E19C1-A025-46D1-95B3-D7BF85052B45",
                CardType = CardType.Location,
                EncounterSet = "Into Fangorn",
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Forest." },
                Text = "While Heart of Fangorn is in the staging area, each player cannot refresh more than 5 characters during the refresh phase.",
                Shadow = "Attacking enemy makes an additional attack after this one.",
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 36,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new Card()
            {
                Title = "The Forest's Malice",
                ImageType = ImageType.Png,
                Id = "3A7F339F-A300-4CDA-BDB1-19A6E21789C9",
                CardType = CardType.Treachery,
                EncounterSet = "Into Fangorn",
                Text = "When Revealed: Each Huorn enemy engaged with a player makes an immediate attack. If no attack was made as a result of this effect, each player must search encounter deck and discard pile for a Huorn enemu and pit it into play engaged with him. This effect cannot be canceled.",
                Quantity = 4,
                EasyModeQuantity = 1,
                Number = 37,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new Card()
            {
                Title = "Orc Skirmisher",
                ImageType = ImageType.Png,
                Id = "5745026F-AABE-49D7-BF33-B7C70A42B93E",
                CardType = CardType.Enemy,
                EncounterSet = "Misty Mountain Orcs",
                EngagementCost = 33,
                Threat = 3,
                Attack = 4,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Orc." },
                Text = "Forced: After ~Orc Skirmisher engages a player, that player must either deal 3 damage to a character he controls, or remove 1 time counter from the current quest.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack.",
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 38,
                Artist = Artist.Diego_Gisbert_Llorens
            });
             Cards.Add(new Card()
            {
                Title = "Orc Hunter",
                ImageType = ImageType.Png,
                Id = "7D907B4B-8D64-4F15-80FB-73DD3146FA1F",
                CardType = CardType.Enemy,
                EncounterSet = "Misty Mountain Orcs",
                EngagementCost = 35,
                Threat = 2,
                Attack = 3,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Orc." },
                Text = "When Revealed: Either reveal an additional encounter card, or remove 1 time counter from the current quest.",
                Shadow = "Shadow: Attacking enemy makes an additional attack after this one.",
                Quantity = 3,
                EasyModeQuantity = 1,
                Number = 39,
                Artist = Artist.Diego_Gisbert_Llorens
            });
             Cards.Add(new Card()
            {
                Title = "Orc Hound",
                ImageType = ImageType.Png,
                Id = "16DB3C77-DCF6-4547-94ED-3249C4D18824",
                CardType = CardType.Enemy,
                EncounterSet = "Misty Mountain Orcs",
                EngagementCost = 20,
                Threat = 1,
                Attack = 2,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string> { "Creature." },
                Keywords = new List<string> { "Surge." },
                Text = "Forced: After ~Orc Hound engages a player, that player must exhaust a character he controls.",
                Quantity = 2,
                EasyModeQuantity = 1,
                Number = 40,
                Artist = Artist.Ilich_Henriquez
            });
             Cards.Add(new Card()
            {
                Title = "Orc Hunting Party",
                ImageType = ImageType.Png,
                Id = "B7380292-B4B6-495F-9A04-6AF1D3AAA7C2",
                CardType = CardType.Treachery,
                EncounterSet = "Misty Mountain Orcs",
                Text = "When Revealed: Deal each Orc enemy in play a shadow card. Each Orc enemy gets -15 engagement cost until the end of the round. If there are no Orc enemies in the staging area, Orc Hunting Party gains surge.",
                FlavorText = "'The scouts have come back at last,' said an Orc close at hand. -The Two Towers",
                Quantity = 2,
                EasyModeQuantity = 2,
                Number = 41,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card()
            {
                Title = "Dunland Prowler",
                ImageType = ImageType.Png,
                Id = "3978167C-C2A9-4ED1-9E2D-AA1B711C50A6",
                CardType = CardType.Enemy,
                EncounterSet = "Dunland Raiders",
                EngagementCost = 30,
                Threat = 1,
                Attack = 2,
                Defense = 3,
                HitPoints = 3,
                Traits = new List<string> { "Dunland." },
                Text = "While any player has 3 or more cards in hand, ~Dunland Prowler gains surge.\r\n\r\nWhile any player has 5 or more cards in hand, ~Dunland Powler gets +1 Threat.",
                FlavorText = "...the wild men of the Dunland fells. -The Two Towers",
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 42,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card()
            {
                Title = "Dunlending Bandit",
                ImageType = ImageType.Png,
                Id = "738ED376-48BF-45CF-BBB0-428DB6CB5869",
                CardType = CardType.Enemy,
                EncounterSet = "Dunland Raiders",
                EngagementCost = 33,
                Threat = 2,
                Attack = 1,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Dunland." },
                Text = "While engaged with a player, Dunlending Bandit gets +1 Attack for each card in that player's hand.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending player has at least 3 cards in his hand).",
                Quantity = 2,
                EasyModeQuantity = 2,
                Number = 43,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new Card()
            {
                Title = "Dunland Raider",
                ImageType = ImageType.Png,
                Id = "E461B1C0-6887-46DE-B1E7-A7A98F04FAEF",
                CardType = CardType.Enemy,
                EncounterSet = "Dunland Raiders",
                EngagementCost = 35,
                Threat = 3,
                Attack = 5,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Dunland." },
                Text = "Forced: After ~Dunland Raider engages a player, that player must deal X damage divided among characters he controls where X equals the number of cards in his hand.",
                Shadow = "Shadow: Discard an attachment you control.",
                Quantity = 2,
                EasyModeQuantity = 0,
                Number = 44,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card()
            {
                Title = "Old Hatreds",
                ImageType = ImageType.Png,
                Id = "AEDC7B12-2B48-4644-8881-92C6BA3E4FBA",
                CardType = CardType.Treachery,
                EncounterSet = "Dunland Raiders",
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Attach to the current quest. (Counts as a Condition attachment with the text: \"Forced: After a player draws an number of cards, raise his threat by 1.\")",
                FlavorText = "\"They hate us, and they are glad; for our doom seems certain to them.\" -Gamling, The Two Towers",
                Quantity = 2,
                EasyModeQuantity = 1,
                Number = 45,
                Artist =  Artist.Ilich_Henriquez
            });
            Cards.Add(new Card()
            {
                Title = "Dunland Tribesman",
                ImageType = ImageType.Png,
                Id = "10450FC9-315B-4F2B-B227-D4CE0E9B784C",
                CardType = CardType.Enemy,
                EncounterSet = "Dunland Warriors",
                EngagementCost = 37,
                Threat = 0,
                Attack = 4,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Dunland." },
                Text = "When Revealed: Each player draws a card.\r\n\r\nForced: After a player draws any number of cards, ~Dunland Tribesman gets +1 Threat until the end of the round.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack.",
                Quantity = 2,
                EasyModeQuantity = 2,
                Number = 46,
                Artist = Artist.David_Horne
            });
            Cards.Add(new Card()
            {
                Title = "Dunland Chieftain",
                ImageType = ImageType.Png,
                Id = "F94C1AB8-C0CE-4F1A-9B31-E0B88E833BA0",
                CardType = CardType.Enemy,
                EncounterSet = "Dunland Warriors",
                EngagementCost = 35,
                Threat = 3,
                Attack = 5,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Dunland." },
                Text = "Forced: After ~Dunland Chieftain engages a player, discard X cards from the top of the encounter deck where X is the number of cards in the engages player's hand. Put the topmost Dunland enemy discarded this way into play engaged with that player.",
                Quantity = 2,
                EasyModeQuantity = 0,
                Number = 47,
                Artist = Artist.Jim_Pavelec
            });
            Cards.Add(new Card()
            {
                Title = "Dunland Berserker",
                ImageType = ImageType.Png,
                Id = "78ACB894-103C-41CC-B2D1-F9A6F81FB322",
                CardType = CardType.Enemy,
                EncounterSet = "Dunland Warriors",
                EngagementCost = 25,
                Threat = 2,
                Attack = 2,
                Defense = 1,
                HitPoints = 4,
                Traits = new List<string> { "Dunland." },
                Text = "Forced: After the engaged player draws any number of cards. Dunland Berserker makes an immediate attack.",
                Shadow = "Shadow: Attacking enemy makes an additional attack after this one.",
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 48,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Wild Men of Dunland",
                ImageType = ImageType.Png,
                Id = "176B2C82-0C3C-48EC-BB7E-B7C61C9DDC11",
                CardType = CardType.Treachery,
                EncounterSet = "Dunland Warriors",
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Attach to the current quest. (Counts as a Condition attachment with the text: \"Forced: After a player draws any number of cards, that player deals 1 damage to a character he controls.\")",
                FlavorText = "\"I looked on the hillmen and they seemed over large for me...\" -Gimli, The Two Towers",
                Quantity = 2,
                EasyModeQuantity = 1,
                Number = 49,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Ancient Forest",
                SlugIncludesType = true,
                ImageType = ImageType.Png,
                Id = "AA0B89D9-02C5-4A15-9C81-0E1AF2CC906D",
                CardType = CardType.Location,
                EncounterSet = "Ancient Forest",
                Threat = 2,
                QuestPoints = 5,
                Traits = new List<string> { "Forest." },
                Text = "While Ancient ~Forest is in the staging area, each Forest location in the staging area gets +1 Threat and +3 quest points. This ability does not stack with other copies of Ancient ~Forest.",
                Shadow = "Shadow: Defending player exhausts a character he controls.",
                Quantity = 3,
                EasyModeQuantity = 1,
                Number = 50,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new Card()
            {
                Title = "Tangled Woods",
                ImageType = ImageType.Png,
                Id = "1DEE93C2-E861-48CD-9DD0-02CB46491D4E",
                CardType = CardType.Location,
                EncounterSet = "Ancient Forest",
                Threat = 2,
                QuestPoints = 4,
                Traits = new List<string> { "Forest." },
                Text = "While Tangled ~Woods is in the staging area, each Forest location in plays gains: \"Travel: Exhaust a hero to travel here.\" This ability does not stack with other copies of Tangled ~Woods.",
                FlavorText = "The forest was dark and close. -The Two Towers",
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 51,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card()
            {
                Title = "Turned Around",
                ImageType = ImageType.Png,
                Id = "5CEF2C98-F61D-4766-8A07-42BA17B0CB4B",
                CardType = CardType.Treachery,
                EncounterSet = "Ancient Forest",
                Text = "When Revealed: Either remove 1 time counter from a card in play, or return the active location to the staging area.",
                Shadow = "Shadow: If this attack is undefended, return the active location to the staging area.",
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 52,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card()
            {
                Title = "Prowling Wolf",
                ImageType = ImageType.Png,
                Id = "7BFE696F-DA00-4D2F-ACA9-3044F22D6431",
                CardType = CardType.Enemy,
                EncounterSet = "Broken Lands",
                EngagementCost = 28,
                Threat = 3,
                Attack = 1,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Creature." },
                Text = "While engaged with a player, Prowling Wolf gets +1 Attack for each location in the staging area.",
                Shadow = "Shadow: Defending player exhausts a character he controls.",
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 53,
                Artist = Artist.Piya_Wannachaiwong
            });
            Cards.Add(new Card()
            {
                Title = "Broken Lands",
                SlugIncludesType = true,
                ImageType = ImageType.Png,
                Id = "39982128-25C4-49E7-B7CB-66916E62A69A",
                CardType = CardType.Location,
                EncounterSet = "Broken Lands",
                Threat = 2,
                QuestPoints = 6,
                Traits = new List<string> { "Highlands." },
                Text = "While Broken Lands is in the staging area, progress cannot be placed on locations in the staging area.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each location in the staging area.",
                Quantity = 3,
                EasyModeQuantity = 3,
                Number = 54,
                Artist = Artist.Joel_Hustak
            });
            Cards.Add(new Card()
            {
                Title = "Take Cover!",
                ImageType = ImageType.Png,
                Id = "350DC354-534A-4FE6-BC4F-475F8C1DDC30",
                CardType = CardType.Treachery,
                EncounterSet = "Broken Lands",
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Either deal 1 damage to each exhausted character, or remove 1 time counter from the current quest.",
                FlavorText = "Out of the darkness arrows whistled. -The Two Towers",
                Quantity = 3,
                EasyModeQuantity = 2,
                Number = 55,
                Artist = Artist.Sandra_Duchiewicz
            });
            Cards.Add(new Card()
            {
                Title = "Low on Provisions",
                ImageType = ImageType.Png,
                Id = "E38C9171-4B13-43E0-A729-18C99C35489E",
                CardType = CardType.Treachery,
                EncounterSet = "Weary Travelers",
                Text = "When Revealed: Each player must assign X damage among characters he controls, where X is the number of characters he controls.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character is undamaged.)",
                Quantity = 3,
                EasyModeQuantity = 2,
                Number = 56,
                Artist = Artist.Regis_Moulun
            });
            Cards.Add(new Card()
            {
                Title = "Off Track",
                ImageType = ImageType.Png,
                Id = "3B4CB88B-F9E5-4C70-91A8-9F2AC1B98636",
                CardType = CardType.Treachery,
                EncounterSet = "Weary Travelers",
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Attach to a location in play. (Counts as a Condition attachment with the text: \"Limit 1 per location. Attached location gets +2 quest points and Gain: 'Forced: Remove an additional time counter from the current quest at the end of each refresh phase, if able.'\")",
                Quantity = 2,
                EasyModeQuantity = 2,
                Number = 57,
                Artist = Artist.Sarah_Morris
            });
            Cards.Add(new Card()
            {
                Title = "In Need of Rest",
                ImageType = ImageType.Png,
                Id = "C22ADAF6-954E-4212-AFA9-5CEA555117D3",
                CardType = CardType.Treachery,
                EncounterSet = "Weary Travelers",
                Text = "When Revealed: Remove a hero from the quest and attach In Need of Rest to that hero. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Forced: After a time counter is removed from the current quest, attached hero takes 1 damage.\")",
                FlavorText = "I have just about enough strength left to find some hole away up there. And then I must rest a little.\r\n-Frodo, The Return of the King",
                Quantity = 2,
                EasyModeQuantity = 1,
                Number = 58,
                Artist = Artist.Sara_Betsy
            });
            Cards.Add(new Card()
            {
                Title = "Fight at the Fords",
                HasSecondImage = true,
                StageNumber = 1,
                ImageType = ImageType.Png,
                Id = "4BEF0C09-6FB2-4021-BD27-816EEBFBDDCC",
                CardType = CardType.Quest,
                ScenarioNumber = 1,
                QuestPoints = 6,
                EncounterSet = "The Fords of Isen",
                FlavorText = "Riding north to the Gap of Rohan, you come upon a battle at the Fords of Isen. A Small number of Rohirrim have taken a defensive position, on the islet in the river's center where a large force of wild Dunlending assails them. You must move swifty lest the river run red with blood of Rohan...",
                Text = "Setup: Add The Islet to the staging area and attach Gríma to that location. Each player searches the encounter deck for 1 different Dunland enemy and adds it to the staging area. Shuffle the encounter deck.",
                Keywords = new List<string> { "Time 5." },
                OppositeText = "Forced: After the last time counter is removed from this stage, discard Gríma from play.\r\n\r\nThe players cannot advance unless the first player controls Gríma.",
                Quantity = 1,
                Number = 59,
                Artist = Artist.Cristi_Balanescu,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DunlandWarriors, EncounterSet.DunlandRaiders }
            });
            Cards.Add(new Card()
            {
                Title = "Dunlending Attack",
                HasSecondImage = true,
                StageNumber = 2,
                ImageType = ImageType.Png,
                Id = "FEBD2BE9-DF9E-4391-A498-86EE6758E2AB",
                CardType = CardType.Quest,
                ScenarioNumber = 1,
                QuestPoints = 14,
                EncounterSet = "The Fords of Isen",
                FlavorText = "After driving the Wild Men back from the islet, you are surprised to find king Théoden's personal advisor, Gríma Wormtongue, among the men defending the fords. He tells you that he was on his way to Isengard when he was caught in the attack. Before he can say more of his errand, the Dunlendings redouble their assault. \"Save me!\" Gríma cries as he shrinks behind you. The life of the king's counselor is in your hands...",
                Keywords = new List<string> { "Time 2." },
                OppositeText = "When Revealed: Each player searches the encounter deck and discard pile for 1 different Dunland enemy and adds it to the staging area. Shuffle the encounter deck.\r\n\r\nForced: After the last time counter is removed from this stage, each player assigns X damage among characters he controls where X is the number of cards in his hand. Place 2 time counters on this stage.",
                Quantity = 1,
                Number = 60,
                Artist = Artist.Cristi_Balanescu,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DunlandWarriors, EncounterSet.DunlandRaiders }
            });
            Cards.Add(new Card()
            {
                Title = "Hold the Fords",
                HasSecondImage = true,
                StageNumber = 3,
                ImageType = ImageType.Png,
                Id = "8D5B83EB-5A77-492D-897A-1A5341550731",
                CardType = CardType.Quest,
                ScenarioNumber = 1,
                QuestPoints = 16,
                EncounterSet = "The Fords of Isen",
                FlavorText = "The Dunlendings' assault is relentless and your arms grow weary. \"Take me to Isengard!\" Gríma pleads, but you will not abandon the defense. You will either break the will of the enemy, or give your life in a heroic last stand...",
                Text = "When Revealed: Each player searches the encounter deck and discard pile for 1 different Dunland enemy and adds it to the staging area. Shuffle the encounter deck.",
                Keywords = new List<string> { "Time 3." },
                OppositeText = "Forced: After the last time counter is removed from this stage, discard the top X cards from the encounter deck. X is the number of cards in the first player's hand. Add each enemy discarded this way to the staging area. Put 3 time counters on this stage.\r\n\r\nWhile there is at least 1 enemy in play, the players cannot defeat this stage. If the players defeat this stage, they win the game.",
                Quantity = 1,
                Number = 61,
                Artist = Artist.Adam_Lane,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DunlandWarriors, EncounterSet.DunlandRaiders }
            });
            Cards.Add(new Card() {
                Title = "Orders from Orthanc",
                HasSecondImage = true,
                StageNumber = 1,
                ImageType = ImageType.Png,
                Id = "3ED48AE6-66BB-45B2-B07A-0F549A952F75",
                CardType = CardType.Quest,
                ScenarioNumber = 2,
                QuestPoints = null,
                EncounterSet = "To Catch an Orc",
                FlavorText = "Saruman has tasked you with a dangerous mission: journey up the Misty Mountains' southern peack in search of the Orc, Mugash, and capture him alive.",
                Text = "Setup: Each player removes the top 20 cards of his deck and places them aside, as an out-of-play deck. The first player takes Mugash plus 1 Mugash's Guard for each other player in the game and randomly shuffles one facedown into each player's out-of-play deck. Place any remaining copies of Mugash's Guard aside, out of play.",
                OppositeFlavorText = "Mugash and his Orcs have been raiding the surrounding coutryside from their hidden lair in Methedras, and carrying loot and captives back into the mountains. It's time to put an end to this menace...",
                OppositeText = "When Revealed: Each player searches the encounter deck for a Mountain location and adds it to the staging area. Shuffle the encounter deck. Then, advance to stage 2.",
                Quantity = 1,
                Number = 62,
                Artist = Artist.Ilich_Henriquez,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountainOrcs, EncounterSet.BrokenLands }
            });
            Cards.Add(new Card() {
                Title = "Searching for Mugash",
                HasSecondImage = true,
                StageNumber = 2,
                ImageType = ImageType.Png,
                Id = "EA763FD7-64E8-4E39-B318-0F110B20F241",
                CardType = CardType.Quest,
                ScenarioNumber = 2,
                QuestPoints = null,
                EncounterSet = "To Catch an Orc",
                FlavorText = "Orcs prowl the mountainside on the lookout for intruders. A single horn-call from one of the sentries would have every Orc in Methedras scurrying out of their holes to fight. You must move carefully to avoid detection while you search for their captain...",
                Keywords = new List<string> { "Time 2." },
                OppositeText = "Forced: After the last time counter is removed for this stage, shuffle the discard pile into the encounter deck and reveal 2 encounter cards per player. Place 2 time counters on this stage.\r\n\r\nResponse: After questing successfully, cancel all progress that would be placed on this stage. Then, place 1 time counter on this stage. Or, if Mugash is in play, advance to stage 3.",
                Quantity = 1,
                Number = 63,
                Artist = Artist.Sebastian_Giacobino,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountainOrcs, EncounterSet.BrokenLands }
            });
            Cards.Add(new Card() {
                Title = "The Wizard's Prize",
                HasSecondImage = true,
                StageNumber = 3,
                ImageType = ImageType.Png,
                Id = "BAD7F11E-961B-49B0-9B67-7924E52F7309",
                CardType = CardType.Quest,
                ScenarioNumber = 2,
                QuestPoints = 15,
                EncounterSet = "To Catch an Orc",
                FlavorText = "You've found Mugash, but the Orc captain won't be taken without a fight! He howls and rages against you with the ferocity of a cornered animal. All the commotion is sure to draw more Orcs to the fray, yet you must subdue the huge Uruk before you can retreat down the mountain...",
                Keywords = new List<string> { "Time 3." },
                Text = "Forced: After the last time counter is removed from this stage, return Mugash to the staging area and reveal X encounter cards. X is the number of players in the game minus 1. Place 3 time counters on this stage.\r\n\r\nProgress cannot be placed on this stage unless Mugash is attached to a hero.\r\n\r\nIf the players defeat this stage, they win the game.",
                Quantity = 1,
                Number = 64,
                Artist = Artist.Adam_Lane,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountainOrcs, EncounterSet.BrokenLands }
            });
            Cards.Add(new Card()
            {
                Title = "Into the Woods",
                HasSecondImage = true,
                StageNumber = 1,
                ImageType = ImageType.Png,
                Id = "3D3EFB85-5EDA-45EB-A992-A8146673AECA",
                CardType = CardType.Quest,
                ScenarioNumber = 3,
                QuestPoints = 9,
                EncounterSet = "Into Fangorn",
                FlavorText = "You've captured the Orc captain, Mugash, in the mountains above Isengard. But as you make your way down Methedras, your captive escaped and flees east into Fangorn.",
                Text = "Setup: Add Edge of Fangorn to the staging area and attach Mugash to that location. Shuffle the encounter deck. Reveal X additional encounter cards where X equals the number of players in the game minus 1.",
                OppositeFlavorText = "You pursue Mugash into the ancient forest to find that the trees themselves seems to be attacking him. Without thinking, your at the tree branches to rescue your captive. That is when you first sense your own peril...",
                Keywords = new List<string> { "Time 4." },
                OppositeText = "Forced: After the last time counter is removed from this stage, shuffle Mugash into the encounter deck and advance to stage 3.\r\n\r\nThe players cannot advance to stage 2 unless Mugash is attached to a hero.",
                Quantity = 1,
                Number = 65,
                Artist = Artist.Cristi_Balanescu,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.AncientForest, EncounterSet.WearyTravelers }
            });
            Cards.Add(new Card()
            {
                Title = "Escape from Fangorn",
                HasSecondImage = true,
                StageNumber = 2,
                ImageType = ImageType.Png,
                Id = "C3572881-CF4C-421A-B555-7D40DC91E720",
                CardType = CardType.Quest,
                ScenarioNumber = 3,
                QuestPoints = 12,
                EncounterSet = "Into Fangorn",
                FlavorText = "You've rescued Mugash from the trees, but your sense the forest itself seethes with anger toward you. The thankless Orc struggles against you and the tree branches grasp at you. It's going to be a hard fight to get out of Fangorn with your captive...",
                Text = "When Revealed: Each player searches the encounter deck and discard pile for a Huorn enemy and adds it to the staging area. Shuffle the encounter deck.",
                Keywords = new List<string> { "Time 4." },
                OppositeText = "Forced: After the last time counter is removed from this stage, shuffle Mugash into the encounter deck and advance to stage 3A.\r\n\r\nThe players cannot defeat this stage unless Mugash is attached to a hero.\r\n\r\nIf the players defeat this stage, they win the game.",
                Quantity = 1,
                Number = 66,
                Artist = Artist.Alexandre_Dainche,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.AncientForest, EncounterSet.WearyTravelers }
            });
            Cards.Add(new Card()
            {
                Title = "The Angry Forest",
                HasSecondImage = true,
                StageNumber = 3,
                ImageType = ImageType.Png,
                Id = "AD53EA8E-E050-4BCE-B826-945EF6A6F227",
                CardType = CardType.Quest,
                ScenarioNumber = 3,
                QuestPoints = null,
                EncounterSet = "Into Fangorn",
                FlavorText = "Mugash has disappeared deeper into the woods. As you continue to search for him, the trees close in around you and you can feel their roots and limbs shaking with anger. Their branches rattle like a raging temptest, but without any wind. You're beginning to regret the decision to enter Fangorn. You need to find Mugash and get out...",
                Keywords = new List<string> { "Time 3." },
                OppositeText = "Forced: After the last time counter is removed from this stage, discard the top 5 cards of the encounter deck. Each player must choose an enemy or objective in the discard pile, reveal it and add it to the staging area. Place 3 time counters on this stage.\r\n\r\nForced: After placing progress here, if there is at least 6 progress on this stage and Mugash is attached to a hero, advance to stage 2A.",
                Quantity = 1,
                Number = 67,
                Artist = Artist.Alyn_Spiller,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.AncientForest, EncounterSet.WearyTravelers }
            });
        }
    }
}