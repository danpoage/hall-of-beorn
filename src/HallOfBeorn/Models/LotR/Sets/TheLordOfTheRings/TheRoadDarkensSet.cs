using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class TheRoadDarkensSet : CardSet
    {
        private const string setSouth = "The Ring Goes South";

        protected override void Initialize()
        {
            Name = "The Road Darkens";
            Abbreviation = "RD";
            Number = 1004;
            SetType = Models.SetType.Saga_Expansion;
            Cycle = "The Lord of the Rings";

            Cards.Add(new LotRCard()
            {
                Title = "Frodo Baggins",
                IsUnique = true,
                Id = "BC8E79AD-1B4A-4B63-A7CA-966E28D39403",
                
                CardType = CardType.Hero,
                Sphere = Models.LotR.Sphere.Fellowship,
                ThreatCost = 0,
                Willpower = 2,
                Attack = 1,
                Defense = 2,
                HitPoints = 2,
                Traits = new List<string> { "Hobbit.", "Ring-bearer." },
                Text = "Response: After Frodo ~Baggins exhausts to defend an attack, exhaust The One ~Ring and spend 1 Fellowship resource to target the attacking enemy. Then, this attack deals no damage and each player raises his threat by 2.",
                FlavorText = "\"But there is more about you now than appears on the surface.\" -Bilbo, The Fellowship of the Ring",
                CardNumber = 1,
                Quantity = 1,
                Artist = Artist.Sebastian_Giacobino
            });
            addHero("Gandalf", 14, Sphere.Neutral, 3, 3, 3, 5)
                .WithTraits("Istari.")
                .WithTextLine("Play with the top card of your deck faceup. Once per phase, you may play the top card of your deck as if it was in your hand. When playing a card this way, Gandalf is considered to have the printed Leadership, Lore, Tactics, and Spirit icons.")
                .WithFlavorLine("\"I am a servant of the Secret Fire, wielder of the flame of Anor.\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("Hrodebert/Gandalf-Hero-1")
                .WithCommunityVersion("Hrodebert/Gandalf-Hero-2")
                .WithInfo(2, 1, Artist.Matt_Stewart);
            Cards.Add(new LotRCard()
            {
                Title = "Galadriel",
                IsUnique = true,
                Id = "B081B837-C996-4F1C-AD97-0CCBCD3D9A8C",
                
                CardType = CardType.Ally,
                Sphere = Models.LotR.Sphere.Leadership,
                ResourceCost = 3,
                Willpower = 3,
                Attack = 0,
                Defense = 0,
                HitPoints = 3,
                Traits = new List<string> { "Noldor.", "Noble." },
                Text = "At the end of the round, discard Galadriel from play.\r\nResponse: After you play Galadriel from your hand, search the top 5 cards of your deck for an attachment of cost 3 or less and put it into play. Put the remaining cards back in any order.",
                CardNumber = 3,
                Quantity = 3,
                Artist = Artist.Sebastian_Giacobino
            });
            Cards.Add(new LotRCard()
            {
                Title = "Boromir",
                IsUnique = true,
                Id = "13C3F24D-27BE-485D-8CAB-5A639802CDDF",
                
                CardType = CardType.Ally,
                Sphere = Models.LotR.Sphere.Tactics,
                ResourceCost = 4,
                Willpower = 1,
                Attack = 3,
                Defense = 1,
                HitPoints = 4,
                Traits = new List<string> { "Gondor.", "Warrior." },
                Text = "Boromir gets +2 Defense while defending against an enemy with an engagement cost higher than your threat.\r\nResponse: After Boromir takes any amount of damage, ready him.",
                CardNumber = 4,
                Quantity = 3,
                Artist = Artist.Chris_Rahn
            });
            Cards.Add(new LotRCard()
            {
                Title = "Elrond",
                IsUnique = true,
                Id = "47BF974D-65B3-4AB7-AD01-B0AC41D9ADE4",
                
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 3,
                Willpower = 3,
                Attack = 2,
                Defense = 3,
                HitPoints = 3,
                Traits = new List<string> { "Noldor.", "Healer." },
                Text = "At the end of the round, discard Elrond from play.\r\nResponse: After Elrond enters play, choose one: heal all damage on a hero, discard a Condition attachment, or each player draws 1 card.",
                CardNumber = 5,
                Quantity = 3,
                Artist = Artist.Allen_Douglas
            });
            Cards.Add(new LotRCard()
            {
                Title = "Bilbo Baggins",
                IsUnique = true,
                Id = "8382124A-14F3-46B4-A24C-DA520299A81B",
                
                CardType = CardType.Ally,
                Sphere = Models.LotR.Sphere.Spirit,
                ResourceCost = 2,
                Willpower = 2,
                Attack = 0,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string> { "Hobbit." },
                Text = "Response: After Bilbo ~Baggins enters play, search your deck for a Pipe attachment and add it to your hand. Shuffle your deck.",
                FlavorText = "\"Elves may thrive on speech alone, and Dwarves endure great weariness, but I am an old Hobbit, and I miss my meal at noon.\" -The Fellowship of the Ring",
                CardNumber = 6,
                Quantity = 3,
                Artist = Artist.Sebastian_Giacobino
            });
            Cards.Add(new LotRCard()
            {
                Title = "Flame of Anor",
                Id = "AF117DE3-66FE-4E0E-A9FB-AD1618CFDEA9",
                
                CardType = CardType.Event,
                Sphere = Models.LotR.Sphere.Neutral,
                ResourceCost = 1,
                Traits = new List<string> { "Spell." },
                Text = "Action: Add Flame of Anor to the victory display and discard the top card of your deck to ready an Istari character you control. That character gets +X Attack until the end of the phase where X is the discarded card's cost.",
                FlavorText = "\"You cannot pass!\" -Gandalf, The Fellowship of the Ring",
                VictoryPoints = 1,
                CardNumber = 7,
                Quantity = 3,
                Artist = Artist.Diego_Gisbert_Llorens 
            });
            Cards.Add(new LotRCard()
            {
                Title = "Gandalf's Staff",
                IsUnique = true,
                Id = "5B66215C-663A-4F31-BD5B-34EB484F8146",
                
                CardType = CardType.Attachment,
                Sphere = Sphere.Neutral,
                ResourceCost = 2,
                Traits = new List<string> { "Artifact.", "Item.", "Staff." },
                Keywords = new List<string> { "Restricted." },
                Text = "Attach to Gandalf. Restricted.\r\nAction: Exhaust Gandalf's Staff to (choose one): choose a player to draw 1 card, add 1 resource to a hero's resource pool, or discard a shadow card from a non-unique enemy.",
                FlavorText = "...he held his staff aloft, and from its tip there came a feint radiance. -The Fellowship of the Ring",
                CardNumber = 8,
                Quantity = 3,
                Artist = Artist.Victor_Maury
            });
            Cards.Add(new LotRCard()
            {
                Title = "Wizard Pipe",
                Id = "DD619FB9-8CCE-4306-978A-B6E89E243A5A",
                
                CardType = CardType.Attachment,
                Sphere = Models.LotR.Sphere.Neutral,
                ResourceCost = 1,
                Traits = new List<string> { "Item.", "Pipe." },
                Text = "Attach to an Istari character. Limit 1 per character.\r\nAction: Exhaust Wizard ~Pipe to exchange a card in your hand with the top card of your deck.",
                FlavorText = "...there was a long silence, broken only by the soft puffs of Gandalf's pipe, as he blew white smoke-rings out of the window. -The Fellowship of the Ring",
                CardNumber = 9,
                Quantity = 3,
                Artist = Artist.Tiziano_Baracchi
            });
            Cards.Add(new LotRCard()
            {
                Title = "Fellowship of the Ring",
                IsUnique = true,
                Id = "FC5068A4-CBD5-4831-A7AE-32DDB306DAD1",
                
                CardType = CardType.Attachment,
                Sphere = Models.LotR.Sphere.Fellowship,
                ResourceCost = 2,
                Traits = new List<string> { "Fellowship." },
                Text = "Attach to the Ring-bearer.\r\nEach hero gets +1 Willpower.\r\nForced: After a character is destroyed, discard Fellowship of the Ring.",
                CardNumber = 10,
                Quantity = 3,
                Artist = Artist.Michael_Komarck
            });
            addAttachment("Sting", 2, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Hobbit hero. Restricted.")
                .WithTextLine("Attached hero gets +1 Willpower, +1 Attack, and +1 Defense.")
                .WithTextLine("Response: After attached hero exhausts to defend an attack, discard the top card of the encounter deck. Deal damage to the attacking enemy equal to the discarded card's Threat.")
                .WithInfo(11, 1, Artist.Magali_Villeneuve);
            addAttachment("Mithril Shirt", 1, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Artifact.", "Item.", "Armor.")
                .WithTextLine("Attach to the Ring-bearer.")
                .WithTextLine("Attached hero gets +1 Defense and +1 hit point.")
                .WithFlavorLine("\"I should feel happier if I knew you were wearing it. I have a fancy it would turn even the knives of the Black Riders...\"")
                .WithFlavorLine("-Bilbo, The Fellowship of the Ring")
                .WithInfo(12, 1, Artist.Sara_Betsy);
            Cards.Add(new LotRCard()
            {
                Title = "Glamdring",
                IsUnique = true,
                Id = "921B7E59-0CFC-4B12-A95A-CB37A49587A0",
                
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 2,
                Traits = new List<string> { "Artifact.", "Item.", "Weapon." },
                Keywords = new List<string> { "Restricted." },
                Text = "Attach to a Warrior hero or Gandalf. Restricted.\r\nAttached character gets +2 Attack.\r\nResponse: After attached character destroys an Orc enemy, draw 1 card.",
                FlavorText = "\"...at his side was the elven-sword Glamdring, the mate of Orcrist that lay now upon the breast of Thorin under the Lonely Mountain.\" -The Fellowship of the Ring",
                CardNumber = 13,
                Quantity = 1,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                Title = "Andúril",
                IsUnique = true,
                Id = "A4E77553-5376-452A-974B-601C35FEB5BA",
                
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 3,
                Traits = new List<string> { "Artifact.", "Item.", "Weapon." },
                Keywords = new List<string> { "Restricted." },
                Text = "Attach to a Noble hero or Aragorn. Restricted.\r\nAttached hero gets +1 Willpower, +1 Attack, and +1 Defense.\r\nResponse: After an attack in which the attached hero defended resolves, exhaust Andúril to target the enemy that just attacked. Declare attached hero as an attacker against that enemy (and resolve the attack).",
                CardNumber = 14,
                Quantity = 1,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                Title = "Phial of Galadriel",
                IsUnique = true,
                Id = "5AFC42BF-3E61-4FB8-AF2C-AB40E27AFF3F",
                
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 0,
                Traits = new List<string> { "Item.", "Gift." },
                Text = "Setup: Attach to a hero in play.\r\nAdd Phial of Galadriel to the victory display and remove it from the campaign pool, to give each enemy engaged with you -4 Attack until the end of the round.",
                FlavorText = "\"May it be a light to you in dark places, when all other lights go out.\" -Galadriel, The Fellowship of the Ring",
                VictoryPoints = 3,
                CardNumber = 15,
                Quantity = 1,
                Artist = Artist.Cynthia_Sheppard
            });
            Cards.Add(new LotRCard()
            {
                Title = "Three Golden Hairs",
                IsUnique = true,
                Id = "19CB3A5F-5D58-41E5-846D-733261B554A6",
                
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 0,
                Traits = new List<string> { "Item.", "Gift." },
                Text = "Setup: Attach to a hero in play.\r\nAction: Add Three Golden Hairs to the victory display and remove it from the campaign pool, to lower each player's threat by 3. Then, each player draws 3 cards.",
                FlavorText = "\"...your hands shall flow with gold, and yet over you gold shall have no dominion.\" -Galadriel, The Fellowship of the Ring",
                VictoryPoints = 3,
                CardNumber = 16,
                Quantity = 1,
                Artist = Artist.Rovina_Cai
            });
            Cards.Add(new LotRCard()
            {
                Title = "Lórien Rope",
                IsUnique = true,
                Id = "DF542407-56E4-4643-BD32-5BE349AA86FF",
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 0,
                Traits = new List<string> { "Item.", "Gift." },
                Text = "Setup: Attach to a hero in play.\r\nAction: Add Lórien Rope to the victory display, and remove it from the campaign pool to give each location in the staging area -2 Threat until the end of the phase.",
                FlavorText = "\"What a piece of luck you had that rope!\" -Frodo, The Two Towers",
                VictoryPoints = 3,
                CardNumber = 17,
                Quantity = 1,
                Artist = Artist.Rick_Price
            });
            Cards.Add(new LotRCard()
            {
                Title = "Leaf-wrapped Lembas",
                IsUnique = true,
                Id = "AA0E8E20-FA34-4ED6-8BF4-C4BE15CA17F2",
                
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 0,
                Traits = new List<string> { "Item.", "Gift." },
                Text = "Setup: Attach to a hero in play.\r\nAction: Add Leaf-wrapped Lembas to the victory display, and remove it from the campaign pool, to ready all heroes in play.",
                FlavorText = "Often in their hearts they thanked the lady of Lórien for the gift of lembas, for they could eat of it and find new strength even as they ran. -The Two Towers",
                VictoryPoints = 3,
                CardNumber = 18,
                Quantity = 1,
                Artist = Artist.Owen_William_Weber
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Ring Goes South",
                CardType = Models.LotR.CardType.Campaign,
                Id = "DFF44707-3468-4E8F-AB49-DF4E5E6D93FC",
                OppositeTitle = "The Lord of the Rings Part 4",
                Text = "You are playing in Campaign Mode.\r\nSetup: Each player may change hero cards he controls without incurring the +1 threat penalty. The players have earned the boon cards: Sting, Mithril Shirt, Glamdring, and Andúril. Each player chooses one and adds it to his hand. If any of those boon cards remain unchosen, shuffle them into the first player's deck.",
                FlavorText = "\"I think that this task is appointed for you, Frodo; and that if you do not find a way, no one will.\" -Elrond, The Fellowship of the Ring",
                OppositeText = "Resolution: If Lust for the Ring is attached to a hero, the players have earned that burden.",
                OppositeFlavorText = "They were just in time. Sam and Frodo were only a few steps up, and Gandalf had just begun to climb, when the groping tentacles writhed across the narrow shore and fingered the cliff-wall and the doors. One came wriggling over the threshold, glistening in the starlight. Gandalf turned and paused. If he was considering what word would close the gate again from within, there was no need. Many coiling arms seized the doors on either side, and with horrible strength, swung them round. With a shattering echo they slammed, and all light was lost. -The Fellowship of the Ring",
                EncounterSet = "The Ring Goes South",
                CardNumber = 19,
                Quantity = 1,
                Artist = Artist.Ignacio_Bazan_Lazcano
            }.WithSlugSuffix("Campaign"));
            Cards.Add(new LotRCard()
            {
                Title = "The Council of Elrond",
                Id = "D49C15DD-1D36-4716-A754-B192CC59D5E3",
                CardType = CardType.Quest,
                StageNumber = 1,
                EncounterSet = "The Ring Goes South",
                Text = "Setup: Set Lust for the Ring, Redhorn Pass, Doors of Durin and Watcher in the Water aside, out of play. Shuffle the encounter deck.",
                FlavorText = "In the House of Elrond, the evil wound that Frodo received on Weathertop is healed and he is reunited with his uncle Bilbo. The One Ring cannot remain hidden in Rivendell for long, so Lord Elrond summons a council to decide what should be done to protect the Free Peoples of Middle-earth.",
                QuestPoints = null,
                OppositeText = "Forced: At the end of the planning phase, each player places the top card of his deck faceup in front of him, in player order, until there are a total of 4 faceup cards between the players. The first player chooses 1 faceup card to be played for 0 cost, 1 to add to its owner's hand, 1 to discard, and 1 to shuffle into its owner's deck. Then, either shuffle Lust for the Ring into the encounter deck, or raise each player's threat by 5. Advance to stage 2.",
                CardNumber = 20,
                Quantity = 1,
                Artist = Artist.Ignacio_Bazan_Lazcano
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Nine Walkers",
                Id = "855DC3F7-9DB8-48BB-9BA1-ABDCEEAE1074",
                CardType = CardType.Quest,
                StageNumber = 2,
                EncounterSet = "The Ring Goes South",
                Text = "When Revealed: Make Redhorn Pass the active location. The first player reveals cards from the encounter deck until there is at least X Threat in the staging area. X is twice the number of players in the game.",
                FlavorText = "The Council decides The One Ring must be cast into Mount Doom. Frodo is appointed eight companions to help him compete this quest and the Company of the Ring sets out from Rivendell into Hollin on their way to Mordor...",
                QuestPoints = 8,
                OppositeText = "During the travel phase, the players must travel to a location, if able.\r\nForced: After an enemy engages a player, place 1 damage on the active location, if able.",
                OppositeFlavorText = "\"Hollin is no longer wholesome for us: it is being watched.\" -Aragorn, The Fellowship of the Ring",
                CardNumber = 21,
                Quantity = 1,
                Artist = Artist.Matt_Bradbury
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Hunt is Up!",
                Id = "15A0614C-85DB-4FA1-8BD6-7C53CC9357A0",
                CardType = CardType.Quest,
                StageNumber = 3,
                EncounterSet = "The Ring Goes South",
                Text = "When Revealed: Each player searches the encounter deck and discard pile for an enemy and adds it to the staging area. One of those enemies must be Great Warg Chief, if able. Shuffle the encounter deck.",
                FlavorText = "Suddenly Aragorn leapt to his feet, \"How the wind howls!\" he cried. \"It is howling with wolf-voices. The Wargs have come west of the Mountains!\" -The Fellowship of the Ring",
                QuestPoints = 12,
                OppositeText = "During the travel phase, the players must travel to a location, if able.\r\nForced: After an enemy engages a player, place 1 damage on the active location, if able.",
                OppositeFlavorText = "The Fellowship is being hunted by Wargs!",
                CardNumber = 22,
                Quantity = 1,
                Artist = Artist.Mark_Bulahao
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Gates of Moria",
                Id = "855B100F-5BE9-4651-91D8-C559DAAE5E77",
                CardType = CardType.Quest,
                StageNumber = 4,
                EncounterSet = "The Ring Goes South",
                Text = "When Revealed: Make Doors of Durin the active location. Add Watcher in the Water to the staging area. Discard all tokens from the Ring-bearer and place it (and each card attached to it) facedown under Watcher in the Water.",
                FlavorText = "Pursued by evil Wargs and foul weather, the Company of the Ring decides to enter the Mines of Moria. But as they seek the hidden gate, a foul creature seizes the Ring-bearer with one of its many groping arms...",
                QuestPoints = null,
                OppositeText = "There can be 2 active locations. During the travel phase, the players must travel to a location, if able.\r\nForced: After an enemy engages a player, place 1 damage on each active location.\r\nIf Doors of Durin is explored, the players win the game.",
                OppositeFlavorText = "The Fellowship is being hunted by Wargs!",
                CardNumber = 23,
                Quantity = 1,
                Artist = Artist.Mark_Bulahao
            });
            addEnemy("Watcher in the Water", setSouth, 50, 5, 6, 5, 12)
                .WithUnique()
                .WithTraits("Creature.")
                .WithKeywords("Indestructible.")
                .WithText("Immune to player card effects. Cannot leave the staging area but is considered to be engaged with each player.\r\nForced: After placing the 6th damage here, the first player takes control of the Ring-bearer, exhausted with 1 damage on it.")
                .WithTemplate("<p class='main-text'>{keyword:Indestructible.} Immune to player card effects.</p><p class='main-text'>Cannot leave the staging area but is considered to be engaged with each player.</p><p class='main-text'><b>Forced:</b> After placing the 6th damage here, the first player takes control of the {trait:Ring-bearer.@Ring-bearer}, exhausted with 1 damage on it.</p>")
                .WithInfo(24, 1, Artist.Florian_Devos);
            Cards.Add(new LotRCard()
            {
                Title = "Great Warg Chief",
                Id = "17C446FC-31C8-458F-9F89-036E82A728EC",
                
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 30,
                Threat = 4,
                Attack = 5,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Creature.", "Warg." },
                Text = "Cannot have attachments.\r\nForced: After Great Warg Chief enages you, discard cards from the encounter deck until a Warg enemy is discarded. Put that enemy into play engaged with you.",
                EncounterSet = "The Ring Goes South",
                CardNumber = 25,
                Quantity = 1,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new LotRCard()
            {
                Title = "Hound of Sauron",
                Id = "5BB5992A-37AC-406D-8448-0ABC11A3AB1C",
                
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 1,
                Attack = 4,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Creature.", "Warg." },
                Keywords = new List<string> { "Surge." },
                Text = "Hound of Sauron gets -5 engagement cost for each enemy in the staging area.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it was engaged with round).",
                EncounterSet = "The Ring Goes South",
                CardNumber = 26,
                Quantity = 4,
                EasyModeQuantity = 2,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new LotRCard()
            {
                Title = "Howling Warg",
                Id = "0EB61219-35A9-4F46-8E08-8101A352477F",
                
                CardType = CardType.Enemy,
                EngagementCost = 38,
                Threat = 2,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Creature.", "Warg." },
                Text = "Forced: After Howling Warg attacks, place 1 damage on an active location.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place 1 damage on an active location.",
                EncounterSet = "The Ring Goes South",
                CardNumber = 27,
                Quantity = 4,
                Artist = Artist.Dylan_Pierpont
            });
            Cards.Add(new LotRCard()
            {
                Title = "Crebain from Dunland",
                Id = "CAC621B7-8DA4-4891-A2FB-6CDA4CBF1FED",
                
                CardType = CardType.Enemy,
                EngagementCost = 28,
                Threat = 3,
                Attack = 1,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string> { "Creature." },
                Keywords = new List<string> { "Peril." },
                Text = 
@"When Revealed: Either exhaust a hero you control, or engaged Crebain from Dunland.

Forced: After Crebain from Dunland engages a player, reveal the top card of the encounter deck.",
                EncounterSet = "The Ring Goes South",
                CardNumber = 28,
                Quantity = 2,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new LotRCard()
            {
                Title = "Redhorn Pass",
                IsUnique = true,
                Id = "BB618ACA-4B66-4C3C-A7F0-D973812492B4",
                
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 6,
                Traits = new List<string> { "Mountain." },
                Text = "Immune to player card effects.\r\nForced: When Redhorn Pass is explored, each player assigns X damage among characters he controls. X is the number of damage here.",
                FlavorText = "\"We may well be seen by watchers on that narrow path...\" -Gandalf, The Fellowship of the Ring",
                VictoryPoints = 1,
                EncounterSet = "The Ring Goes South",
                CardNumber = 29,
                Quantity = 1,
                Artist = Artist.Katy_Grierson
            });
            Cards.Add(new LotRCard()
            {
                Title = "Doors of Durin",
                IsUnique = true,
                Id = "FFD1FDEF-1A8F-4550-A66E-2ACC91F9EE91",
                
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 9,
                Traits = new List<string> { "Gate." },
                Text =
@"Immune to player card effects.

Progress cannot be placed on each other active location before it can be placed here. Progress cannot be placed here unless the first player controls the Ring-bearer.
                
If there are 9 damage tokens, the players lose the game.",
                VictoryPoints = 1,
                EncounterSet = "The Ring Goes South",
                CardNumber = 30,
                Quantity = 1,
                Artist = Artist.Nate_Abell
            });
            Cards.Add(new LotRCard()
            {
                Title = "Tree-crowned Hill",
                Id = "E5ADB36D-58A3-480B-8782-E3750B71BDD0",
                
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 6,
                Traits = new List<string> { "Hills." },
                Text =
@"While Tree-crowned hill is the active location, each enemy gets -1 Threat.
                
Forced: When Tree-crowned hill is explored, the players, as a group, exhaust X characters in play. X is the number of damage here.",
                FlavorText = "For their defense in the night the Company climbed to the top of the small hill... -The Fellowship of the Ring",
                VictoryPoints = 1,
                EncounterSet = "The Ring Goes South",
                CardNumber = 31,
                Quantity = 1,
                Artist = Artist.Ferdinand_Dumago_Ladera
            });
            Cards.Add(new LotRCard()
            {
                Title = "Hills of Hollin",
                Id = "6194470F-0592-4ECD-9D8A-21D413F96500",
                
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 4,
                Traits = new List<string> { "Hills." },
                Text =
@"While ~Hills of Hollin is the active location, each enemy in the staging area gets +5 engagement cost.
                
Forced: When ~Hills of Hollin is explored, each player raises his threat by 1 for each damage here.",
                FlavorText = "For their defense in the night the Company climbed to the top of the small hill... -The Fellowship of the Ring",
                VictoryPoints = 1,
                EncounterSet = "The Ring Goes South",
                CardNumber = 32,
                Quantity = 3,
                Artist = Artist.Mikhail_Yakovlev
            });
            Cards.Add(new LotRCard()
            {
                Title = "Redhorn Foothills",
                Id = "C1D01F3E-8DCD-489C-AD0D-18CFEF78DAC2",
                
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 5,
                Traits = new List<string> { "Hills." },
                Text = "While ~Hills of Hollin is the active location, it gains: \"Forced: After an enemy is added to the staging area, it gets -5 engagement cost until the end of the round.\"\r\nForced: When Redhorn Foothills is explored, each player must discard X cards from his hand at random. X is the number of damage here.",
                EncounterSet = "The Ring Goes South",
                CardNumber = 33,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Victor_Garcia
            });
            Cards.Add(new LotRCard()
            {
                Title = "Eregion",
                Id = "B8F593C8-3BDD-4E98-AE44-1EBA952754B6",
                
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 4,
                Traits = new List<string> { "Hills." },
                Text = "Forced: When Eregion is explored, the players, as a group, must discard X allies from play. X is the number of damage here.",
                Shadow = "Shadow: Defending player discards a non-objective attachment he controls.",
                EncounterSet = "The Ring Goes South",
                CardNumber = 34,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                Title = "Regiments of Crows",
                Id = "F9524610-C38E-41B8-A26F-D11BC6EB8969",
                
                CardType = CardType.Treachery,
                Text = "When Revealed: Place 3 damage on each active location.",
                Shadow = "Shadow: Undefended damage from this attack must be assigned to the active location.",
                FlavorText = "\"I think they are spying out the land.\" -Aragorn, The Fellowship of the Ring",
                EncounterSet = "The Ring Goes South",
                CardNumber = 35,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Sandra_Duchiewicz
            });
            Cards.Add(new LotRCard()
            {
                Title = "Snowdrifts",
                Id = "45A01A09-7FB1-4AA6-AF9B-D06D86764C3C",
                
                CardType = CardType.Treachery,
                Traits = new List<string> { "Weather." },
                Text = "When Revealed: Attach to the active location. (Countss as a Condition attachment with the text, \"Limit 1 per location. No more than 3 progress can be placed on attached location each round.\") If Snowdrifts is not attached to the active location, it gains surge.",
                FlavorText = "Soon even Boromir found it hard to keep going. -The Fellowship of the Ring",
                EncounterSet = "The Ring Goes South",
                CardNumber = 36,
                Quantity = 2,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new LotRCard()
            {
                Title = "Bitter Cold",
                Id = "B83DC4E9-DD6C-4D4A-ABC5-C0A846DEB571",
                
                CardType = CardType.Treachery,
                Traits = new List<string> { "Weather." },
                Text = "When Revealed: Each player must choose: either discard each ally he controls, or raise his threat by 1 for each ally he controls.",
                Shadow = "Shadow: Attacking enemy makes an additional attack after this one.",
                EncounterSet = "The Ring Goes South",
                CardNumber = 37,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Carly_Janine_Mazur
            });
            Cards.Add(new LotRCard()
            {
                Title = "Storm of Howls",
                Id = "1CFB37BB-1DD1-44DC-A907-778EE15D9EE9",
                
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Peril." },
                Text = "When Revealed: Either the Warg enemy in the staging area with the highest engagement cost attacks you, or each Warg enemy gets -20 engagement until the end of the round. If no Warg enemy is in the staging area, Storm of Howls gains surge.",
                EncounterSet = "The Ring Goes South",
                CardNumber = 38,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Jake_Bullock
            });
            Cards.Add(new LotRCard()
            {
                Title = "Journey in the Dark",
                CardType = Models.LotR.CardType.Campaign,
                Id = "952913FB-ACC2-4A0C-A802-D841D9F18198",
                OppositeTitle = "The Lord of the Rings Part 5",
                Text = "You are playing in Campaign Mode.\r\nSetup: Shuffle the burder treachery cards Pursued by the Enemy and Shadow of Fear, into the encounter deck. Add the burden objective cards Grievous Wound and Overcome by Grief to the staging area.",
                FlavorText = "\"Well, well!\" said the wizard. \"The passage is blocked behind us now and there is only one way out - on the other side of the mountains.\" -The Fellowship of the Ring",
                OppositeText = "Resolution: The first player must choose one of the burden treachery cards (Pursued by the Enemy or Shadow of Fear), and one of the burden objective cards (Grievous Wound or Overcome by Grief) and add to the Campaign Pool. If The Balrog is still in play, the first player must choose all 4 burden cards instead. The chosen burdens have been earned by the players.",
                OppositeFlavorText = "They ran on. The light grew before them; great shafts pierced the roof. They ran swifter. They passed into a hall, bright with daylight from its high windows in the east. They fled across it. Through its huge broken doors they passed, and suddenly before them the Great Gates opened, an arch of blazing light. -The Fellowship of the Ring",
                EncounterSet = "Journey in the Dark",
                CardNumber = 39,
                Quantity = 1,
                Artist = Artist.Juan_Carlos_Barquet
            }.WithSlugSuffix("Campaign"));
            Cards.Add(new LotRCard()
            {
                Title = "The Long Dark of Moria",
                Id = "1C1EC6D0-14E5-4563-A52C-7B2B51FCA760",
                CardType = CardType.Quest,
                StageNumber = 1,
                EncounterSet = "Journey in the Dark",
                Text = "Setup: Set The ~Balrog, The Great ~Bridge, and Chamber of Mazarbul aside out of play. Add Doom, Doom, Doom to the staging area and place 10 damage tokens on it. Each player adds 1 different location to the staging area.",
                FlavorText = "Trapped inside the Mines of Moria, the Company of the Ring must find their way through many twisting passages to reach the eastern door. But with every step they take into the Mines, there is a growing sense of dread...",
                QuestPoints = 14,
                OppositeText = "Forced: After a player optionally engages an enemy, remove 1 damage from Doom, Doom, Doom.",
                OppositeFlavorText = "There were not only many roads to choose from, there were also in many places holes and pitfalls, and dark wells beside the path in which their passing feet echoed. -The Fellowship of the Ring",
                CardNumber = 40,
                Quantity = 1,
                Artist = Artist.Juan_Carlos_Barquet
            });
            Cards.Add(new LotRCard()
            {
                Title = "Drums in the Deep",
                Id = "8AF12E34-E1F4-490E-9926-74929D6F9649",
                CardType = CardType.Quest,
                StageNumber = 2,
                EncounterSet = "Journey in the Dark",
                Text = "When Revealed: Add Chamber of Mazarbul to the staging area.",
                FlavorText = "Then there came an echoing blast: a great horn was blown in the hall, and answering horns and harsh cries were heard further off. There was a hurrying sound of many feet. -The Fellowship of the Ring",
                QuestPoints = 9,
                OppositeText = "If there are no enemies in the staging area at the beginning of the quest phase, the first player reveals an additional encounter card during the staging step.\r\nThe players cannot advance unless there are X resource tokens on this stage. X is the number of players times 3.\r\nForced: After an enemy is defeated, place 1 resource token on this stage.",
                CardNumber = 41,
                Quantity = 1,
                Artist = Artist.Nate_Abell
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Bridge of Khazad-dûm",
                Id = "F836D78D-C291-43DE-A562-144D4ABC4F4A",
                CardType = CardType.Quest,
                StageNumber = 3,
                EncounterSet = "Journey in the Dark",
                Text = "When Revealed: Add The Great ~Bridge to the staging area. Each player reveals 1 encounter card and removes 1 damage token from ~Doom, ~Doom, ~Doom.",
                FlavorText = "The outer door could only be reached by a slender bridge of stone, without kerb or rail, that spanned the chasm with one curving spring of fifty feet. -The Fellowship of the Ring",
                QuestPoints = 15,
                OppositeText = "No more than 5 progress can be placed on this stage each round.\r\nThe players cannot defeat this stage while The Great Bridge is in play. If the players defeat this stage, they win the game.",
                OppositeFlavorText = "\"Now for the last race!\" said Gandalf. \"If the sun is shining outside we may still escape. After me!\" -The Fellowship of the Ring",
                CardNumber = 42,
                Quantity = 1,
                Artist = Artist.Silver_Saaremael
            });
            Cards.Add(new LotRCard()
            {
                Title = "Doom, Doom, Doom",
                Id = "4289DFBC-7164-490F-9905-92BA78C0037F",
                
                CardType = CardType.Objective,
                Traits = new List<string> { "Shadow.", "Flame." },
                Text = 
@"Forced: At the end of the quest phase, remove 1 damage token from Doom, Doom, Doom. Then, if there are no damage tokens here, add The ~Balrog to the staging area.

Forced: At the end of the quest phase, The ~Balrog makes an attack if it is in play.",
                EncounterSet = "Journey in the Dark",
                CardNumber = 43,
                Quantity = 1,
                Artist = Artist.Silver_Saaremael
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Balrog",
                Id = "88D5E35D-37C2-404C-83B6-F30D916405E0",
                
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 5,
                Attack = 8,
                Defense = 9,
                HitPoints = 25,
                Traits = new List<string> { "Balrog.", "Shadow.", "Flame." },
                Keywords = new List<string> { "Indestructible." },
                Text = "Cannot be optionally engaged. The Balrog and shadow cards dealt to The Balrog are immune to player card effects.\r\nWhile in the staging area, The ~Balrog is considered to be engaged with the first player and only the first player can declare attackers against The ~Balrog.",
                VictoryPoints = 50,
                EncounterSet = "Journey in the Dark",
                CardNumber = 44,
                Quantity = 1,
                Artist = Artist.Jim_Pavelec
            });
            Cards.Add(new LotRCard()
            {
                Title = "Orc-chieftain",
                Id = "54E8B892-5DDF-4883-B54B-563323884C3A",
                
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 4,
                Attack = 4,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Orc.", "Uruk." },
                Text = "Cannot have attachmnets. Allies cannot defend against Orc-chieftain.\r\nForced: At the beginning of the encounter phase, Orc-chieftain engages the first player.",
                FlavorText = "...he charged into the Company and thrust his spear straight at Frodo. -The Fellowship of the Ring",
                EncounterSet = "Journey in the Dark",
                CardNumber = 45,
                Quantity = 1,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new LotRCard()
            {
                Title = "Great Cave-troll",
                Id = "052DC0A2-B1D6-4833-960E-FE8C34A0857B",
                
                CardType = CardType.Enemy,
                EngagementCost = 36,
                Threat = 3,
                Attack = 6,
                Defense = 4,
                HitPoints = 6,
                Traits = new List<string> { "Troll." },
                Text = "Cannot have attachments.\r\nFor each point of excess damage dealt by Cave-troll (damage that is dealt beyond the remaining hit points of the character damaged by its attack) remove 1 progress from the current quest.",
                EncounterSet = "Journey in the Dark",
                CardNumber = 46,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Nicholas_Gregory
            });
            Cards.Add(new LotRCard()
            {
                Title = "Uruk from Mordor",
                Id = "48E64AED-A5E7-4427-946C-C24260DA163E",
                
                CardType = CardType.Enemy,
                EngagementCost = 34,
                Threat = 2,
                Attack = 4,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Orc.", "Uruk." },
                Text = "When Revealed: Uruk from Mordor makes an immediate attack against the first player.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, attacking enemy makes an additional attack.",
                EncounterSet = "Journey in the Dark",
                CardNumber = 47,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new LotRCard()
            {
                Title = "Moria Orc",
                Id = "30D5D5BB-6517-4BCA-B06C-273D27CBFB25",
                
                CardType = CardType.Enemy,
                EngagementCost = 38,
                Threat = 2,
                Attack = 3,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Orc." },
                Text = "When Revealed: Either remove 1 damage from Doom, Doom, Doom, or reveal an additional encounter card.",
                Shadow = "Shadow: The defending player raises his threat by 1 for each enemy engaged with him.",
                EncounterSet = "Journey in the Dark",
                CardNumber = 48,
                Quantity = 3,
                Artist = Artist.Ben_Peek
            });
            Cards.Add(new LotRCard()
            {
                Title = "Moria Archer",
                Id = "798A9EB5-AB16-4DC6-9228-61E670EF5784",
                CardType = CardType.Enemy,
                EngagementCost = 42,
                Threat = Card.VALUE_X,
                Attack = 3,
                Defense = 3,
                HitPoints = 3,
                Traits = new List<string> { "Orc." },
                Keywords = new List<string> { "Peril.", "Archery 2." },
                Text = "X is the number of players in the game.\r\nWhen Revealed: Assign X damage among characters you control.",
                EncounterSet = "Journey in the Dark",
                CardNumber = 49,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Ben_Peek
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Great Bridge",
                IsUnique = true,
                Id = "F42AAEF4-1F89-417B-8E7D-483F91C62527", 
                CardType = CardType.Location,
                Threat = 5,
                QuestPoints = 5,
                Traits = new List<string> { "Underground.", "Bridge." },
                Text = "Immune to player card effects.\r\nResponse: When The Great ~Bridge is explored, discard a hero from play to deal X damage to The ~Balrog. X is that hero's threat cost. Then, The ~Balrog loses all keywords for the remainder of the game. Any player may trigger this response.",
                EncounterSet = "Journey in the Dark",
                VictoryPoints = 5,
                CardNumber = 50,
                Quantity = 1,
                Artist = Artist.Emilio_Rodriguez
            });
            Cards.Add(new LotRCard()
            {
                Title = "Chamber of Mazarbul",
                IsUnique = true,
                Id = "5206815D-292B-475C-9887-FE9CBB2D4CAF",
                
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 4,
                Traits = new List<string> { "Underground." },
                Text = "Immune to player card effects.\r\nThe player cannot advance to the next stage.\r\nTravel: Each player searches the encounter deck and discard pile for a different enemy and adds it to the staging area to travel here. One of those enemies must be Orc-chieftain, if able.",
                EncounterSet = "Journey in the Dark",
                VictoryPoints = 4,
                CardNumber = 51,
                Quantity = 1,
                Artist = Artist.Emilio_Rodriguez
            });
            Cards.Add(new LotRCard()
            {
                Title = "Mines of Moria",
                Id = "BE234B07-D1FD-4673-9680-639CE3104424",
                
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 4,
                Traits = new List<string> { "Underground." },
                Text = "Whiles Mines of Moria is in the staging area, progress must be placed on Mines of Moria before it can be placed on the current quest.",
                Shadow = "Shadow: Defending player discards a non-objective attachment he controls (2 non-objective attachments instead if his threat is 35 or higher).",
                EncounterSet = "Journey in the Dark",
                CardNumber = 52,
                Quantity = 4,
                Artist = Artist.Juan_Carlos_Barquet
            });
            Cards.Add(new LotRCard()
            {
                Title = "Many-pillared Hall",
                Id = "8C8FC2DF-034B-43CB-BD08-8F6EE7911732",
                
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 6,
                Traits = new List<string> { "Underground." },
                Text = "Many-pillared Hall gets +1 Threat for each Many-pillared Hall in play.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending player's threat is 35 or higher).",
                EncounterSet = "Journey in the Dark",
                CardNumber = 53,
                Quantity = 4,
                EasyModeQuantity = 3,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "Darkened Stairway",
                Id = "D3E23B2F-CEFA-4E83-A724-1151D2090433",
                
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 2,
                Traits = new List<string> { "Underground." },
                Text = "Forced: After Darkened Stairway is explored, discard the top card of the encounter deck. If the discarded card is a location, add it to the staging area.",
                FlavorText = "Frodo caught glimpses of stairs and arches and of other passages and tunnels, sloping up, or running steeply down, or opening blankly dakr on either side. -The Fellowship of the Ring",
                EncounterSet = "Journey in the Dark",
                CardNumber = 54,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Nate_Abell
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ancient Guardroom",
                Id = "20B1B404-F6E5-4E29-B9D8-C869525AA272",
                
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Underground." },
                Text = "While Ancient Guardroom is the active location, each enemy in play gets -1 Attack.\r\nTravel: Discard the top card of the encounter deck to travel here. Each player raises his threat by X, where X is the discarded card's Threat.",
                EncounterSet = "Journey in the Dark",
                CardNumber = 55,
                Quantity = 2,
                Artist = Artist.Pedro_Amato
            });
            Cards.Add(new LotRCard()
            {
                Title = "They Are Coming!",
                Id = "33A5425A-1827-4672-8B7B-28FA52CBD2C2",
                
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Doomed 2." },
                Text = "When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top of the encounter deck until X enemies are discarded. X is the number of players in the game. Add each enemy discarded this way to the staging area.",
                EncounterSet = "Journey in the Dark",
                CardNumber = 56,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Sara_Betsy
            });
            Cards.Add(new LotRCard()
            {
                Title = "We Cannot Get Out",
                Id = "BF2720F0-A766-48AB-B23E-408FB6ECFFD2",
                
                CardType = CardType.Treachery,
                Text = "When Revealed: Each player assigns X damage among characters he controls. X is the number of exhausted characters he controls.",
                Shadow = "Shadow: Assign X damage among characters you control. X is the number of enemies engaged with you.",
                EncounterSet = "Journey in the Dark",
                CardNumber = 57,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Nate_Abell
            });
            Cards.Add(new LotRCard()
            {
                Title = "Deep Fissure",
                Id = "49C6D3E2-52D6-4807-BB52-D2C3AA062836",
                
                CardType = CardType.Treachery,
                Traits = new List<string> { "Hazard." },
                Text = "When Revealed: Remove a character you control from the quest and discard the top card of the encounter deck. If that character's printed Willpower is less than the discarded card's Threat, discard that character.",
                FlavorText = "...it was long before Pippin could summon enough courage to leap... -The Fellowship of the Ring",
                EncounterSet = "Journey in the Dark",
                CardNumber = 58,
                Quantity = 3,
                Artist = Artist.Pedro_Amato
            });
            Cards.Add(new LotRCard()
            {
                Title = "Fool of a Took!",
                Id = "0777D985-660F-4CC7-BE97-7B4BD09FDB13",
                
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Doomed 1." },
                Text = "When Revealed: Remove 1 damage token from Doom, Doom, Doom, or The Balrog makes an attack, if able.",
                Shadow = "Shadow: If this attack destroys a character, reveal 1 card from the encounter deck.",
                EncounterSet = "Journey in the Dark",
                CardNumber = 59,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Chris_Rahn
            });
            Cards.Add(new LotRCard()
            {
                Title = "Breaking of the Fellowship",
                CardType = Models.LotR.CardType.Campaign,
                Id = "EC6105D0-33EE-436B-83CC-A7DF744E68CC",
                OppositeTitle = "The Lord of the Rings Part 6",
                Text = "You are playing in Campaign Mode.\r\nSetup: Starting with the first player, each player chooses 1 of the following boon cards: Phial of Galadriel, Three Golden Hairs, Lórien Rope, or Leaf-wrapped Lembas, and attaches it to a hero he controls. The chosen boon cards have been earned by the players. Shuffle Followed by Night and Ill Fate into the encounter deck.",
                FlavorText = "\"But this I will say to you: your Quest stands upon the edge of a knife. Stray but a little and it will fail, to the ruin of all.\" -Galadriel, The Fellowship of the Ring",
                OppositeText = "Resolution: If Fallen into Evil is attached to a hero, add that hero to the list of Fallen Heroes in the Campaign Log.\r\nThe first player chooses either Followed by Night or Ill Fate to be added to the campaign pool. The chosen burden card has been earned by the players.\r\nEach player chooses 1 hero he controls (other than the Ring-bearer or Aragorn) to be taken captive. Record the name of each \"captive\" in the Notes section of the Campaign Log.",
                OppositeFlavorText = "I would have guided Frodo to Mordor and gone with him to the end; but if I seek him now in the wilderness, I must abandon the captives to torment and death. My heart speaks clearly at last: the fate of the Bearer is in my hands no longer. The Company has played its part. Yet we that remain cannot forsake our companions while we have strength left. Come! We will go now. Leave all that can be spared behind! We will press on by day and dark! -Aragorn, The Two Towers",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 60,
                Quantity = 1,
                Artist = Artist.Katy_Grierson
            }.WithSlugSuffix("Campaign"));
            Cards.Add(new LotRCard()
            {
                Title = "The Great River",
                Id = "9B5F7D5B-895F-479A-937B-7F4ADB7ECEEB",
                CardType = CardType.Quest,
                StageNumber = 1,
                QuestPoints = 12,
                Text = "Setup: Set Frodo's Choice, Seat of Seeing, and Parth Galen aside, out of play. Add The Argonath and Sarn Gebir to the staging area.",
                FlavorText = "Having barely escaped from Moria, the Company of the Ring flees into the forest of Lórien where they are welcomed by the Elves of the Golden Wood and supplied with boats and other gifts by their Lord and Lady, Celeborn and Galadriel. Then, after a brief rest, they set out upon the River Anduin.",
                OppositeText = "Enemies get +2 Defense and cannot be engaged. Skip the encounter phase.\r\nThe players cannot advance while The Argonath is in play.",
                OppositeFlavorText = "So the Company went on their long way, down the wide hurrying waters, borne ever southwards. Bare woods stalked along either bank, and they could not see any glimpse of the lands behind. -The Fellowship of the Ring",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 61,
                Quantity = 1,
                Artist = Artist.Katy_Grierson
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Company Divided",
                Id = "40144880-A0D8-4B0D-94C1-4E882C10A10E",
                CardType = CardType.Quest,
                StageNumber = 2,
                QuestPoints = null,
                Text = "When Revealed: Remove the Ring-bearer, and each card attached to it, from the game (treat The One Ring's text as blank while resolving this effect). Reduce each enemy's engagement cost to 0 until the end of the encounter phase. Skip the travel phase this round.",
                FlavorText = "The river has carried the Company as far as it can and the time has come for Frodo to choose which way to go. He asks for an hour to decide, but after he disappears Orcs are discovered prowling the woods and the Company scatters to find him...",
                OppositeText = "Forced: At the end of the refresh phase, shuffle Seat of Seeing and Forod's Choice into the encounter discard pile. Then, place the encounter discard pile on the bottom of the encounter deck. Starting with the first player, each player creates his own staging area and advances to a different stage 3A of his choice. In player order, each player moves 1 encounter card from this staging area to his. When there are no encounter cards left at this stage, discard it.",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 62,
                Quantity = 1,
                Artist = Artist.Claudio_Pozas
            });
            Cards.Add(new LotRCard()
            {
                Title = "Searching the Woods",
                Id = "F97A9D56-D91E-42CA-805C-6F0326B9F606",
                CardType = CardType.Quest,
                StageNumber = 3,
                QuestPoints = null,
                Text = "Forced: After stage 2B is discarded, if the total Threat of the encounter cards in this staging area is less than 4, reveal 1 encounter card.",
                FlavorText = "Sam had dashed off first. Merry and Pippin had followed, and were already disappearing westward into the trees by the shore, shouting: Frodo! Frodo! in their clear, high hobbit-voices. -The Fellowship of the Ring",
                OppositeText = "If Frodo's Choice is not in play, any time players would place progress on this quest, discard an equal number of cards from the encounter deck instead.\r\nForced: After Frodo's Choice is revealed at this stage, advance to stage 4A.\r\nResponse: After you quest successfully, discard a non-unique location in the staging area.",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 63,
                Quantity = 1,
                Artist = Artist.Anthony_Devine
            });
            Cards.Add(new LotRCard()
            {
                Title = "Guard the Hobbits",
                Id = "93652F64-1A7A-453D-95B5-5C8DBCF1EDFF",
                CardType = CardType.Quest,
                StageNumber = 3,
                QuestPoints = null,
                Text = "Forced: After stage 2B is discarded, if the total Threat of encounter cards in this staging area is less than 4, reveal 1 encounter card.",
                FlavorText = "\"Boromir! I do not know what part you have played in this mischief, but help now! Go after those two young hobbits, and guard them at the least, even if you cannot find Frod.\" -Aragorn, The Fellowship of the Ring",
                OppositeText = "If Frodo's Choice is not in play, any time players would place progress on this quest, discard an equal number of cards from the encounter deck instead.\r\nForced: After Frodo's Choice is revealed at this stage, advance to stage 4A.\r\nResponse: After you quest successfully, choose a player. Ready each of that player's heroes.",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 64,
                Quantity = 1,
                Artist = Artist.Rovina_Cai
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Seat of Amon Hen",
                Id = "B3AEC66C-0D33-4043-8719-A75782AE3CA4",
                CardType = CardType.Quest,
                StageNumber = 3,
                QuestPoints = null,
                Text = "Forced: After stage 2B is discarded, if the total Threat of encounter cards in this staging area is less than 4, reveal 1 encounter card.",
                FlavorText = "\"I am going to the top, to the Seat of Amon Hen, to see what may be seen. And look! It is as my heart guessed, Frodo went this way. Follow me, and keep your eyes open!\" -Aragorn, The Fellowship of the Ring",
                OppositeText = "If Frodo's Choice is not in play, any time players would place progress on this quest, discard an equal number of cards from the encounter deck instead.\r\nForced: After Frodo's Choice is revealed at this stage, advance to stage 4A.\r\nResponse: After you quest successfully, choose a player. That player draws 2 cards and lowers his threat by 2.",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 65,
                Quantity = 1,
                Artist = Artist.Stacey_Diana_Clark
            });
            Cards.Add(new LotRCard()
            {
                Title = "Orc Hunting",
                Id = "BFA38F37-C2BC-42E1-9595-A2BB78712952",
                CardType = CardType.Quest,
                StageNumber = 3,
                QuestPoints = null,
                Text = "Forced: After stage 2B is discarded, if the total Threat of encounter cards in this staging area is less than 4, reveal 1 encounter card.",
                FlavorText = "So it was that Legolas and Gimli found him. They came from the western slopes of the hill, silently, creeping through the trees as if they were hunting. Gimli had his axe in hand, and Legolas his long knife: all his arrows were spent. -The Two Towers",
                OppositeText = "If Frodo's Choice is not in play, any time players would place progress on this quest, discard an equal number of cards from the encounter deck instead.\r\nForced: After Frodo's Choice is revealed at this stage, advance to stage 4A.\r\nResponse: After you quest successfully, discard an enemy engaged with a player.",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 66,
                Quantity = 1,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Ring-bearer Sets Out",
                Id = "E667DDD0-93ED-4B3C-AE34-AD69A3D5220C",
                CardType = CardType.Quest,
                StageNumber = 4,
                QuestPoints = 16,
                Text = "When Revealed: Add Parth Galen to the staging area. If it is your quest phase, end the phase (do not resolve the quest).",
                FlavorText = "\"Now, Sam,\" said Frodo, \"don't hinder me! The others will be coming back at any minute. If they catch me here, I shall have to argue and explain, and I shall never have the heart of the chance to get off. But I must go at once. It's the only way.\" -The Fellowship of the Ring",
                OppositeText = "During the quest phase, reveal 1 additional encounter card for each player in the game.\r\nResponse: After an enemy is revealed at this stage, raise your threat by X to engage that enemy. X is that enemy's Threat. Each player (at any stage) may trigger this ability once per round.\r\nWhen this stage is defeated, the players win the game.",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 67,
                Quantity = 1,
                Artist = Artist.Gabriel_Verdon
            });
            Cards.Add(new LotRCard()
            {
                Title = "Frodo's Choice",
                Id = "3B61F8AD-26C3-476D-A7E4-A3966860F66C",
                
                CardType = CardType.Objective,
                Traits = new List<string> { "Doom." },
                Text = "If Frodo's Choice is discarded, reveal it instead.\r\nWhen Revealed: Take control of the first player token and the Ring-bearer (and each card attached to it). Attach to the Ring-bearer. For the rest of the game, you cannot lose control of the first player token.",
                FlavorText = "\"I will go alone.\" -Frodo, The Fellowship of the Ring",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 68,
                Quantity = 1,
                Artist = Artist.Sandra_Duchiewicz
            });
            Cards.Add(new LotRCard()
            {
                Title = "Uruk-hai Captain",
                Id = "E7DB332C-2DF7-4DC0-89DD-B1395CC0289C",
                
                CardType = CardType.Enemy,
                EngagementCost = 36,
                Threat = 3,
                Attack = 5,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Orc.", "Uruk-hai" },
                Keywords = new List<string> { "Toughness 2." },
                Text = "Cannot have attachments.\r\nAllies with fewer printed hit points than Uruk-hai ~Captain cannot defend against Uruk-hai ~Captain.",
                Shadow = "Shadow: Attacking enemy makes an additional attack after this one.",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 69,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Joel_Hustak
            });
            Cards.Add(new LotRCard()
            {
                Title = "Uruk-hai Archer",
                Id = "E5C15C13-4405-4B0A-961A-B192D1B9FD5B",
                CardType = CardType.Enemy,
                EngagementCost = 44,
                Threat = Card.VALUE_X,
                Attack = 4,
                Defense = 1,
                HitPoints = 4,
                Traits = new List<string> { "Orc.", "Uruk-hai" },
                Keywords = new List<string> { "Peril.", "Toughness 1.", "Archery X." },
                Text = "X is the number of players at this stage.\r\nWhen Revealed: Discard an ally you control.",
                FlavorText = "...they had bows of yew, in length and shape like the bows of Men. -The Fellowship of the Ring",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 70,
                Quantity = 4,
                EasyModeQuantity = 3,
                Artist = Artist.Florian_Devos
            });
            Cards.Add(new LotRCard()
            {
                Title = "Uruk-hai Tracker",
                Id = "8A96B065-F74A-4BCB-849B-1B0E3DBCA0F8",
                
                CardType = CardType.Enemy,
                EngagementCost = 33,
                Threat = 1,
                Attack = 3,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Orc.", "Uruk-hai" },
                Keywords = new List<string> { "Surge.", "Toughness 1.", "Archery 1." },
                Text = "Uruk-hai Tracker gets +2 Attack against characters with 2 or fewer printed hit points.",
                Shadow = "Shadow: Discard a non-objective attachment you control.",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 71,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Tey_Bartolome
            });
            Cards.Add(new LotRCard()
            {
                Title = "Uruk-hai Hunter",
                Id = "28C5F71C-940B-405A-A73C-85DFE6A5F925",
                
                CardType = CardType.Enemy,
                EngagementCost = 28,
                Threat = 2,
                Attack = 4,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Orc.", "Uruk-hai" },
                Keywords = new List<string> { "Peril.", "Toughness 1." },
                Text = "When Revealed: Either choose a player to reveal an additional encounter card, or Uruk-hai Hunter makes an immediate attack against you.",
                FlavorText = "\"I fear that the Orcs may already be on this side of the water.\" -Aragorn, The Fellowship of the Ring",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 72,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Gabriel_Verdon
            });
            Cards.Add(new LotRCard()
            {
                Title = "Parth Galen",
                IsUnique = true,
                Id = "25D83563-9FAD-44C8-8C5D-A2F05A516BB2",
                
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 4,
                Traits = new List<string> { "River.", "Lawn." },
                Text = "Immune to player card effects.\r\nTravel: Search the encounter deck and discard pile for an enemy and add it to the staging area to travel here. Shuffle the encounter deck.\r\nWhile Parth Galen is in play, the players cannot win the game.",
                VictoryPoints = 1,
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 73,
                Quantity = 1,
                Artist = Artist.Katy_Grierson
            });
            Cards.Add(new LotRCard()
            {
                Title = "Seat of Seeing",
                IsUnique = true,
                Id = "76932935-59DA-4F1D-91C6-AD058099F22C",
                
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 6,
                Traits = new List<string> { "Hills." },
                Text = "Immune to player card effects.\r\nResponse: When Seat of Seeing is explored, choose a burden card in play, in the encounter deck, or in the discard pile, and remove it from the game. Shuffle the encounter deck. (If you are playing campaign mode, remove that card from the campaign pool.)",
                VictoryPoints = 1,
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 74,
                Quantity = 1,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Argonath",
                IsUnique = true,
                Id = "DB8709C6-128D-4C9F-B6FA-4D5C6E3EB63C",
                CardType = CardType.Location,
                Threat = Card.VALUE_X,
                QuestPoints = 2,
                Traits = new List<string> { "River." },
                Text = "Immune to player card effects. X is the number of players in the game.\r\nThe players cannot travel here while Sarn Gebir is in play. While The Argonath is the active location, skip the combat phase.",
                FlavorText = "\"Behold the Argonath, the Pillars of the Kings!\" -Aragorn, The Fellowship of the Ring",
                VictoryPoints = 1,
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 75,
                Quantity = 1,
                Artist = Artist.Juan_Carlos_Barquet
            });
            Cards.Add(new LotRCard()
            {
                Title = "Sarn Gebir",
                IsUnique = true,
                Id = "54DF1D26-07FC-432E-91D7-48655404DF2B",
                
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 4,
                Traits = new List<string> { "River." },
                Text = "Immune to player card effects.\r\nForced: When Sarn Gebir is explored, deal 1 damage to each exhausted character.",
                FlavorText = "\"Boats of the Elves would not sink, maybe.\" he said, \"but that does not say that we should come through Sarn Gebir alive. None have ever done so yet.\" -Boromir, The Fellowship of the Ring",
                VictoryPoints = 1,
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 76,
                Quantity = 1,
                Artist = Artist.Katy_Grierson
            });
            Cards.Add(new LotRCard()
            {
                Title = "River Anduin",
                Id = "1C0B30DD-A330-4F26-8807-331C9934150A",
                
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 5,
                Traits = new List<string> { "River." },
                Text = "While River Anduin is in the staging area it gains: \"Forced: At the end of the travel phase, each player at this stage raises his threat by 1. Then, River Anduin moves to the staging area to the left, if able.\"",
                FlavorText = "\"Anduin flows faster than I thought.\" -Aragorn, The Fellowship of the Ring",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 77,
                Quantity = 4,
                Artist = Artist.Victor_Garcia
            });
            Cards.Add(new LotRCard()
            {
                Title = "Wooded Shoreline",
                Id = "1449ACED-E191-42E7-9F2A-473D37192C5D",
                
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 4,
                Traits = new List<string> { "River.", "Forest." },
                Text = "While Wooded Shoreline is in the staging area, it gains archery 2.\r\nTravel: Search the encounter deck and discard pile for an enemy and add it to the staging area to travel here. Shuffle the encounter deck.",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 78,
                Quantity = 3,
                EasyModeQuantity = 1,
                Artist = Artist.Anthony_Feliciano
            });
            Cards.Add(new LotRCard()
            {
                Title = "Slopes of Amon Hen",
                Id = "C2172E7C-9A7D-4E85-B337-0BD39B66F842",
                
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Forest.", "Hills." },
                Text = "Travel: A player at this staging area must engage an enemy in any staging area to travel here.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character has fewer printed hit points than the attacking enemy).",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 79,
                Quantity = 3,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                Title = "Growing Threat",
                Id = "911E2D42-C072-4C05-8F54-8870BEFB15DA",
                
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Peril." },
                Text = "When Revealed: Either move 1 enemy engaged with you to the first player's staging area, or Growing Threat gains doomed 2 and surge.",
                Shadow = "Shadow: After this attack, move attacking enemy to the first player's staging area.",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 80,
                Quantity = 2,
                Artist = Artist.Greg_Opalinski
            });
            Cards.Add(new LotRCard()
            {
                Title = "Orcs of the White Hand",
                Id = "92AA6365-6E59-481A-AE38-006C23148056",
                
                CardType = CardType.Treachery,
                Text = "When Revealed: Remove all damage from each enemy at this stage. Each enemy at this stage gets +1 Threat, +1 Attack, and +1 Defense until the end of the round.",
                Shadow = "Shadow: If the defending character has fewer printed hit points than the attacking enemy, this attack is considered undefended.",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 81,
                Quantity = 2,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new LotRCard()
            {
                Title = "Black Feathered Arrows",
                Id = "BB56207A-0B48-4769-B868-FD97CB1CE1CF",
                
                CardType = CardType.Treachery,
                Text = "When Revealed: Until the end of the round, add 1 to the archery total at this stage for each ally currently at this stage.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character has fewer printed hit points than the attacking enemy).",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 82,
                Quantity = 3,
                Artist = Artist.Mark_Erwan_Tarrisse
            });
            Cards.Add(new LotRCard()
            {
                Title = "Fallen Into Evil",
                Id = "0B8ABA0E-4E46-4F8A-A4C9-41FFC4174DE3",
                
                CardType = CardType.Treachery,
                Traits = new List<string> { "Corruption." },
                Text = "When Revealed: Attach to a non-Fellowship hero and move it to the first player's staging area. (Counts as a Condition attachment with the text: \"Attached hero loses the hero card type and gains the enemy card type with Threat equal to its Willpower and engagement cost equal to its threat cost. If Fallen into Evil is discarded, return attached hero to its owner's control\")",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 83,
                Quantity = 1,
                EasyModeQuantity = 0,
                Artist = Artist.Claudio_Pozas
            });
            Cards.Add(new LotRCard()
            {
                Title = "Lust for the Ring",
                Id = "BF5429AB-9AD8-4BD1-AFB0-A781D0846B6B",
                
                CardType = CardType.Treachery,
                CardSubtype = CardSubtype.Burden,
                Traits = new List<string> { "Corruption." },
                Keywords = new List<string> { "Peril.", "Surge." },
                Text = "When Revealed: Attach to a non-Fellowship hero in play. Counts as a Condition attachment with the text: \"Forced: After The One ~Ring exhausts, raise each player's threat by 1 and reduce attached hero's Willpower to 0 until the end of the round.\"",
                EncounterSet = "The Ring Goes South",
                CardNumber = 84,
                Quantity = 1,
                Artist = Artist.Arden_Beckwith
            });
            Cards.Add(new LotRCard()
            {
                Title = "Shadow of Fear",
                Id = "BAFE055D-1A5A-45E7-A34B-929B247D7D1A",
                
                CardType = CardType.Treachery,
                CardSubtype = CardSubtype.Burden,
                Keywords = new List<string> { "Doomed 1.", "Surge." },
                Text = "When Revealed: Treat the printed text box of each character in play as blank (except for Traits) until the end of the round.",
                Shadow = "Shadow: Defending character does not count its Defense.",
                EncounterSet = "Journey in the Dark",
                CardNumber = 85,
                Quantity = 1,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new LotRCard()
            {
                Title = "Pursued by the Enemy",
                Id = "9C98A2E1-01D7-4E47-B7E5-DD40E297FE04",
                
                CardType = CardType.Treachery,
                CardSubtype = CardSubtype.Burden,
                Keywords = new List<string> { "Doomed 1.", "Surge." },
                Text = "When Revealed: Each enemy engaged with a player, and not in the staging area, makes an immediate attack.",
                Shadow = "Shadow: Attacking enemy makes an additional attack after this one.",
                EncounterSet = "Journey in the Dark",
                CardNumber = 86,
                Quantity = 1,
                Artist = Artist.Claudio_Pozas
            });
            Cards.Add(new LotRCard()
            {
                Title = "Overcome by Grief",
                Id = "12A3B17C-F6C0-4493-B340-D5834CA375B9",
                
                CardType = CardType.Objective,
                CardSubtype = CardSubtype.Burden,
                Traits = new List<string> { "Despair." },
                Text = "Setup: Add Overcome by Grief to the staging area.\r\nForced: After a character is destroyed, if Overcome by Grief is unattached, attach to a hero. (Counts as a Condition attachment with the text: \"Forced: After a character you control is destroyed, exhaust attached hero. Until the end of the round, attached hero cannot ready.\")",
                EncounterSet = "Journey in the Dark",
                CardNumber = 87,
                Quantity = 1,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new LotRCard()
            {
                Title = "Grievous Wound",
                Id = "B8C72B5E-3A9A-4161-A167-4F8EB59FDD84",
                
                CardType = CardType.Objective,
                CardSubtype = CardSubtype.Burden,
                Traits = new List<string> { "Wound." },
                Text = "Setup: Add Grievous Wound to the staging area.\r\n\"Forced: After a hero takes damage, if Grievous Wound is unattached, attach to that hero. (Counts as a Condition attachment with the text: \"Forced: After attached hero exhausts, deal 1 damage to it.\")",
                EncounterSet = "Journey in the Dark",
                CardNumber = 88,
                Quantity = 1,
                Artist = Artist.Sara_K_Diesel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Followed by Night",
                Id = "876E404F-F85A-4218-B7D8-6466ACA84ABC",
                
                CardType = CardType.Treachery,
                CardSubtype = CardSubtype.Burden,
                Keywords = new List<string> { "Peril.", "Surge." },
                Text = "When Revealed: Put the topmost enemy of the encounter deck discard pile into play engaged with you.",
                FlavorText = "\"Quite apart from murder by night on his own account, he may put any enemy that is about on our track.\" -Aragorn, The Fellowship of the Ring",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 89,
                Quantity = 1,
                Artist = Artist.Gabriel_Verdon
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ill Fate",
                Id = "ED9A877D-E9FD-4DCC-A346-E6958CF1E8C6",
                
                CardType = CardType.Treachery,
                CardSubtype = CardSubtype.Burden,
                Traits = new List<string> { "Despair." },
                Keywords = new List<string> { "Peril.", "Surge." },
                Text = "When Revealed: Attach to a hero you control. (Counts as a Condition attachment with the text: \"Forced: After a character you control is destroyed, raise your threat by 2.\")",
                FlavorText = "\"Alas! An ill fate is on me this day, and all that I do goes amiss.\" -Aragorn, The Fellowship of the Ring",
                EncounterSet = "Breaking of the Fellowship",
                CardNumber = 90,
                Quantity = 1,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                Title = "The One Ring",
                Id = "90F20B2B-F4AB-40D6-AB04-864ECD053790",
                
                IsUnique = true,
                CardType = CardType.Objective,
                Traits = new List<string> { "Artifact.", "Item.", "Ring." },
                Text =
@"Setup: The first player claims The One ~Ring and attaches it to the Ring-bearer.

Attached hero does not count against the hero limit. The first player gains control of attached hero.

If The One Ring leaves play, the players lose the game.",
                CardNumber = 91,
                Quantity = 1,
                Artist = Artist.Mike_Nash
            });
        }
    }
}