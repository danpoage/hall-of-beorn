using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheBlackRiders : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Black Riders";
            Abbreviation = "TBR";
            Number = 1003;
            SetType = Models.SetType.Saga_Expansion;
            Cycle = "The Lord of the Rings";

            Cards.Add(new LotRCard()
            {
                
                Title = "Frodo Baggins",
                Id = "3217a119-6b86-47dd-b451-c5e45be3f874",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Fellowship,
                ThreatCost = 0,
                Willpower = 2,
                Attack = 1,
                Defense = 2,
                HitPoints = 2,
                Traits = new List<string>() { "Hobbit.", " Ring-bearer." },
                Text = "Response: Spend 1 Fellowship resource and exhaust The One ~Ring to cancel the effect of an encounter card just revealed from the encounter deck. Shuffle that card back into the encounter deck and reveal another encounter card.",
                FlavorText = "\"I will take the Ring,\" he said, \"though I do not know the way.\" -The Fellowship of the Ring",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new LotRCard() {
                
                Title = "Sam Gamgee",
                AlternateSlug = "Sam-Jamjee-TBR",
                Id = "4124136c-8c86-4f86-830c-94c8c76df161",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Leadership,
                ThreatCost = 8,
                Willpower = 3,
                Attack = 1,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string>() { "Hobbit." },
                Text = "Response: After you engage an enemy with a higher engagement cost than your threat, ready Sam Gamgee. He gets +1 Willpower, +1 Attack and +1 Defense until the end of the round.",
                FlavorText = "\"I'm going with him...and if any of those Black Riders try to stop him, they'll have Sam Gamgee to reckon with\" -The Fellowship of the Ring",
                Quantity = 1,
                CardNumber = 2,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new LotRCard() {
                
                Title = "Merry",
                Id = "052b1f85-8b9c-4bb0-a735-bdbd5ac1b2c4",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Tactics,
                ThreatCost = 6,
                Willpower = 2,
                Attack = 0,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string>() { "Hobbit." },
                Text = "Merry gets +1 Attack for each Hobbit hero you control.\r\nResponse: After Merry participates in an attack that destroys an enemy, ready another character that participated in that attack.",
                FlavorText = "\"You can trust us to stick to you through thick and thin to the bitter end\" -The Fellowship of the Ring",
                Quantity = 1,
                CardNumber = 3,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new LotRCard() {
                
                Title = "Pippin",
                Id = "ce96b767-c569-48b8-a998-d8009b0143c7",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Lore,
                ThreatCost = 6,
                Willpower = 2,
                Attack = 1,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string>() { "Hobbit." },
                Text = "Each enemy in play gets +1 engagement cost for each Hobbit hero you control.\r\nResponse: After you engage an enemy with an engagement cost higher than your threat, draw a card.",
                FlavorText = "\"We Hobbits ought to stick together, and we will\"\r\n-The Fellowship of the Ring",
                Quantity = 1,
                CardNumber = 4,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new LotRCard() {
                
                Title = "Fatty Bolger",
                Id = "5d75d4dd-7300-43d7-87f2-963271c9c904",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Spirit,
                ThreatCost = 7,
                Willpower = 1,
                Attack = 1,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string>() { "Hobbit." },
                Text = "Action: Exhaust Fatty Bolger to choose an enemy in the staging area and raise your threat by that enemy's Threat. Until the end of the phase, that enemy does not contribute its Threat. (Limit once per round.)",
                FlavorText = "\"I only hope that you do not need rescuing before the day is out\" -The Fellowship of the Ring",
                Quantity = 1,
                CardNumber = 5,
                Artist = Artist.Sebastian_Giacobino
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Bill the Pony",
                Id = "1f7fc118-94a7-48a0-bd0c-9c15a36ddc23",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string>() { "Creature.", " Pony." },
                Text = "Cannot have attachments.\r\nLower the cost to play Bill the Pony by 2 if you control Sam Gamgee.\r\nEach Hobbit character gets +1 hit point.",
                FlavorText = "\"He gave me a look as plain as Mr. Pippin could speak it: if you don't let me go with you, Sam, I'll follow on my own\" -Sam Gamgee, The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 6,
                Artist = Artist.Christine_Bian
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Barliman Butterbur",
                Id = "77f58774-86e7-4449-b31e-3833700b3e60",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 0,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string>() { "Bree." },
                Text = "If each hero you control has the Hobbit trait, damage from undefended attacks against you may be assigned to Barliman Butterbur.",
                FlavorText = "\"But spooks or no spooks, they won't get in The Prancing Pony so easy.\" -The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 7,
                Artist = Artist.Owen_William_Weber
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Farmer Maggot",
                Id = "9d8ccd1a-48d3-4123-bcca-3c0ab88347ec",
                IsUnique = true,
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                ResourceCost = 3,
                Willpower = 1,
                Attack = 2,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string>() { "Hobbit." },
                Text = "Response: After Farmer Maggot enters play, deal 1 damage to an enemy engaged with you. (Deal 2 damage instead if that enemy's engagement cost is higher than your threat.)",
                FlavorText = "\"It is lucky for you that I know you. I was going out to set my dogs on any strangers.\" -The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 8,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Halfling Determination",
                Id = "8e7e5c8d-0ea4-46df-ae38-d8d2fee7ca8b",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Text = "Action: Choose a Hobbit character. That character gets +2 Willpower, +2 Attack and +2 Defense until the end of the phase.",
                FlavorText = "\"I have something to do before the end, and it lies ahead, not in the Shire. I must see it through, sir, if you understand me.\" -Sam Gamgee, The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 9,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Smoke Rings",
                Id = "9418c634-54c6-47de-9aae-798038a4a35b",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 2,
                Text = "Action: Reduce your threat by 1 for each Pipe you control. Each hero with a Pipe attachment gets +1 Willpower until the end of the phase.",
                FlavorText = "...he smoked and blew smoke-rings with the same vigour and delight...-The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 10,
                Artist = Artist.Lane_Brown
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Take No Notice",
                Id = "768ae041-2d15-44a3-a928-62838536a160",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                ResourceCost = 3,
                Text = "Lower the cost play Take No Notice by 1 for each Hobbit or Ranger hero you control.\r\nAction: Add 5 to each enemy's engagement cost until the end of the round.",
                FlavorText = "...they made no noise that even hobbits would hear. Event the wild things in the fields and woods hardly noticed their passing. -The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 11,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Frodo's Intuition",
                Id = "96350b97-5c68-4033-bb2f-4305696a7ae7",
                CardType = CardType.Event,
                Sphere = Sphere.Fellowship,
                ResourceCost = 2,
                Text = "Action: Each hero you control gets +1 Willpower until the end of the round. Draw 1 card for each Hobbit hero you control.",
                FlavorText = "\"I wonder if that is Gandalf coming after us\" said Frodo, but even as he said it, he had a feeling that it was not so... -The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 12,
                Artist = Artist.Winona_Nelson
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Hobbit Cloak",
                Id = "8e49ea86-375a-472e-b497-16a1164ae27f",
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Traits = new List<string>() { "Item." },
                Text = "Attach to a Hobbit hero. Limit 1 per hero.\r\nAttached hero gets +2 Defense while defending against an attack by an enemy with an engagement cost higher than your threat.",
                FlavorText = "In their dark cloaks they were invisible as if they all had magic rings. -The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 13,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Dagger of Westernesse",
                Id = "418e6de7-af19-4ea7-bfbe-2a02838c6de4",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Traits = new List<string>() { "Artifact.", "Item.", "Weapon." },
                Keywords = new List<string>() { "Restricted." },
                Text = "Attach to a hero.\r\nAttached hero gets +1 Attack (+2 Attack instead if attacking an enemy with an engagement cost higher than your threat).",
                FlavorText = "...these blades were forged many long years ago by Men of Westernesse: they were foes of the Dark Lord...\r\n-The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 14,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Hobbit Pipe",
                Id = "9c455b1a-a2d4-44f7-a9d3-9a3134c21a2a",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                ResourceCost = 0,
                Traits = new List<string>() { "Item.", "Pipe." },
                Text = "Attach to a Hobbit character. Limit 1 per character.\r\nResponse: After your threat is reduced by an event card effect, exhaust Hobbit Pipe to draw a card.",
                FlavorText = "But even the Dúnedain of Gondor allow us this credit: Hobbits first put it into pipes. Not even the Wizards first thought of that before we did. -The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 15,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Elf-stone",
                Id = "9bb32f2c-29fb-43ba-b7ba-2227b28f7b58",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Traits = new List<string>() { "Artifact.", "Item." },
                Text = "Attach to the active location. Attached location gets +1 quest point.\r\nResponse: After attached location leaves play as an explored location, the first player puts 1 ally into play from his hand.",
                FlavorText = "\"It is a beryl, an elf-stone. Whether it was set there, or let fall by chance, I cannot say, but it brings hope to me\"\r\n-Aragorn, The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 16,
                Artist = Artist.Sandara_Tang
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Mr. Underhill",
                Id = "d0ed393c-162a-4715-bed4-e338c24e9e36",
                IsUnique = true,
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 0,
                Traits = new List<string>() { "Title." },
                Keywords = new List<string>() { "Permanent." },
                Text = "Setup: Attach to the Ring-bearer.\r\nAction: Add Mr. Underhill to the victory display to choose an enemy engaged with you. Until the end of the round, that enemy cannot attack you.",
                FlavorText = "\"I will give you a travelling name now. When you go, go as Mr. Underhill.\" -Gandalf, The Fellowship of the Ring",
                VictoryPoints = 1,
                Quantity = 1,
                CardNumber = 17,
                Artist = Artist.Sebastian_Giacobino
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Tireless Ranger",
                Id = "ef014a91-c2d9-44ca-acd0-cc1a339c051f",
                IsUnique = true,
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 0,
                Traits = new List<string>() { "Title." },
                Keywords = new List<string>() { "Permanent." },
                Text = "Setup: Attach to a hero.\r\nAttached hero gets +1 defense and gains the Ranger trait.",
                FlavorText = "\"What roads would any dare to tread, what safety would there be in quiet lands, or in the homes of simple men at night, if the Dúnedain were asleep, or were all gone into the grave?\"\r\nAragorn, The Fellowship of the Ring",
                Quantity = 1,
                CardNumber = 18,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Skilled Healer",
                Id = "1d1ab8a3-ad76-4992-ae5c-6a89fd0ed463",
                IsUnique = true,
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 0,
                Traits = new List<string>() { "Title." },
                Keywords = new List<string>() { "Permanent." },
                Text = "Setup: Attach to a hero.\r\nAttached hero gets +2 hit points and gains the Healer trait.",
                FlavorText = "\"Few now have the skill of healing to match such evil weapons. But I will do what I can.\"\r\n-Aragorn, The Fellowship of the Ring",
                Quantity = 1,
                CardNumber = 19,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Valiant Warrior",
                Id = "ff574390-bd68-4277-9065-dd9dbf552d00",
                IsUnique = true,
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 0,
                Traits = new List<string>() { "Title." },
                Keywords = new List<string>() { "Permanent." },
                Text = "Setup: Attach to a hero.\r\nAttached hero gets +1 Attack and gains the Warrior trait.",
                FlavorText = "\"Three of the servants of Sauron were upon the Bridge, but they withdrew and I pursued them westward.\" -Glorfindel, The Fellowship of the Ring",
                Quantity = 1,
                CardNumber = 20,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Noble Hero",
                Id = "af49e5ea-c6a2-4be4-bbf3-ac53c100e887",
                IsUnique = true,
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 0,
                Traits = new List<string>() { "Title." },
                Keywords = new List<string>() { "Permanent." },
                Text = "Setup: Attach to a hero.\r\nAttached hero gets +1 Willpower and gainst the Noble trait.",
                FlavorText = "Venerable he seemed as a king crowned with many winters, and yet hale as a tried warrior in the fullness of his strength\r\nThe Fellowship of the Ring",
                Quantity = 1,
                CardNumber = 21,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Three is Company",
                StageNumber = 1,
                Id = "6b34adb4-b510-4db9-aaba-9a1876626dce",
                CardType = CardType.Quest,
                
                EncounterSet = "A Shadow of the Past",
                Quantity = 1,
                Text = "Setup: Set Buckleberry Ferry aside, out of play. Add 1 Black Rider to the staging area and make Bag End the active location. Shuffle the encounter deck.",
                FlavorText = "The ring Frodo Baggins inherited from his uncle Bilbo is indeed The One Ring. After conferring with the wizard Gandalf, Frodo decides to leave the Shire and take the ring to Rivendell.",
                OppositeText = "When a player fails a Hide test, each Nazgûl enemy in the staging area engages that player. (Trigger Forced effects after resolving this effect.)\r\nThe player cannot advance unless Bag End is in the victory display.",
                OppositeFlavorText = "Frodo's friend insist on joining him in his adventure, but danger finds them sooner than anticipated when Black Riders appear in the Shire.",
                QuestPoints = 1,
                CardNumber = 22,
                Artist = Artist.Cristi_Balanescu,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Hunted, EncounterSet.TheRing, EncounterSet.TheBlackRiders }
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "A Shortcut to Mushrooms",
                StageNumber = 2,
                Id = "40c7a675-d48f-4e71-8818-5f0ffb9fa0dd",
                CardType = CardType.Quest,
                
                EncounterSet = "A Shadow of the Past",
                FlavorText = "As Frodo watched he saw something dark pass across the lighter space between two trees, and then halt. It looked like the black shade of a horse led by a smaller black shadow. The black shadow stood close to the point where they had left the path, and it swayed from side to side. Frodo thought he heard the sound of snuffling. The shadow bent to the ground, and then began to crawl towards him. –The Fellowship of the Ring",
                OppositeText = "When Revealed: The first player searches the encounter deck and discard pile for a Black Rider, reveals it (cannot be canceled), and adds it to the staging area. Shuffle the encounter deck.\r\nWhen a player makes a Hide test, add 1 to the total Threat for each ally that player controls.\r\nWhen a player fails a Hide test, each Nazgûl enemy in the staging area engages that player. (Trigger Forced effects after resolving this effect.)",
                Quantity = 1,
                QuestPoints = 14,
                CardNumber = 23,
                Artist = Artist.Chris_Rahn,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Hunted, EncounterSet.TheRing, EncounterSet.TheBlackRiders }
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Escape to Buckland",
                StageNumber = 3,
                Id = "7371cfea-03d0-4bc0-98a1-d99e0acdbf88",
                CardType = CardType.Quest,
                
                Text = "When Revealed: Add Buckleberry Ferry to the staging area.",
                OppositeText = "When Revealed: The first player searches the encounter deck and discard pile for a Black Rider, reveals it (cannot be canceled), and adds it to the staging area. Shuffle the encounter deck.\r\nWhen a player fails a Hide test, each Nazgûl enemy in the staging area engages that player. (Trigger Forced effects after resolving this effect.)\r\nResponse: After a player makes a successful Hide test, place X progress on a non-unique location in play. X is twice the number of players in the game.",
                EncounterSet = "A Shadow of the Past",
                Quantity = 1,
                CardNumber = 24,
                Artist = Artist.Diego_Gisbert_Llorens,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Hunted, EncounterSet.TheRing, EncounterSet.TheBlackRiders }
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Trouble in Bree",
                StageNumber = 1,
                Id = "d0b6992d-9dc4-41fa-a483-b4ad0a3d60b3",
                CardType = CardType.Quest,
                
                Text = "Setup: Set all copies of Ringwraith, The Witch-king, Midgewater, and Weathertop aside, out of play. Add The Prancing Pony and Bill Ferny to the staging area. Shuffle the encounter deck.",
                FlavorText = "Frodo and his companions arrive at Bree to find the shadow of the Black Riders already on the crossroads town. Unsure of who to trust, they decide to lodge at The Prancing Pony. There they meet a friend of Gandalf named Strider who offers to lead them to Rivendell, but their movements are also tracked by less savory folk.",
                OppositeText = "The player cannot advance while The Prancy Pony is in play.",
                OppositeFlavorText = "In dark and loneliness they are strongest; they will not openly attack a house where there are lights and many people - not until they are desperate, not while all the long leagues of Eriador still lie before us. But their power is in terror, and already some in Bree are in their clutch. They will drive these wretches to some evil work: Ferny, and some of the strangers, and, maybe, the gatekeeper too.\r\n–Strider, The Fellowship of the Ring",
                EncounterSet = "A Knife in the Dark",
                Quantity = 1,
                QuestPoints = 8,
                CardNumber = 25,
                Artist = Artist.Darek_Zabrocki,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Hunted, EncounterSet.TheRing, EncounterSet.TheNazgul }
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Into the Wild",
                StageNumber = 2,
                Id = "28a4721b-3696-4fae-9eea-01b5a250c892",
                CardType = CardType.Quest,
                
                FlavorText = "His plan, as far as they could understand it without knowing the country, was to go towards Archet at first, but to bear right and pass it on the east, and then to steer as straight as he could over the wild lands to Weathertop Hill. In that way they would, if all went well, cut off a great loop of the Road, which further on bent southwards to avoid the Midgewater Marshes. But, of course, they would have to pass through the marshes themselves, and Strider’s description of them was not encouraging. –The Fellowship of the Ring",
                OppositeText = "When Revealed: Add Midgewater to the staging area. Each player places 1 progress on the current quest.\r\nForced: At the end of the round, eithe remove X progress from the current quest or shuffle 1 out of play Ringwraith into the encounter deck. X is the number of players in the game.\r\nThe players cannot advance while Midgewater is in play.",
                EncounterSet = "A Knife in the Dark",
                Quantity = 1,
                QuestPoints = 6,
                CardNumber = 26,
                Artist = Artist.Adam_Lane,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Hunted, EncounterSet.TheRing, EncounterSet.TheNazgul }
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "The Ringwraiths Attack",
                StageNumber = 3,
                Id = "257f9b44-2744-4f02-bbf6-115d12b52e8d",
                CardType = CardType.Quest,
                
                Text = "When Revealed: Add Weathertop and The Witch-king to the staging area. Search the encounter deck and discard pile and add each Nazgûl enemy found to the staging area. Shuffle the encounter deck.",
                FlavorText = "Strider has led Frodo and his companions to Weathertop where he hopes to meet Gandalf. Instead, they find the Black Riders waiting for them. As the sun goes down, the Nazgûl close in on their prey.",
                OppositeText = "If there are no Nazgûl enemies in play, the players win the game.",
                OppositeFlavorText = "There were five tall figures: two standing on the lip of the dell, three advancing. In their white faces burned keen and merciless eyes; under their mantles were long grey robes; upon their grey hairs were helms of silver; in their haggard hands were swords of steel. Their eyes fell on him and pierced him, as they rushed towards him. Desperate, he drew his own sword...\r\n–The Fellowship of the Ring ",
                EncounterSet = "A Knife in the Dark",
                Quantity = 1,
                CardNumber = 27,
                Artist = Artist.David_A_Nash,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Hunted, EncounterSet.TheRing, EncounterSet.TheNazgul }
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Pursued by the Enemy",
                StageNumber = 1,
                Id = "f9824e39-fda8-4e4b-bc74-83b4bd40c72d",
                CardType = CardType.Quest,
                
                Text = "Setup: Shuffle each burden card from the Flight to the Ford burden set into a Burden deck. Attach An Evil Wound to the Ring-bearer. Set Ford of Bruinen and The Witch-king aside, out of play. Add The Last Bridge and 1 Fell Rider per player to the staging area. Set the Ring-bearer's life at 15. Shuffle the encounter deck.",
                OppositeText = "The players cannot advance unless The Last Bridge is in the victory display.\r\nForced: At the end of the round, reduce the Ring-bearer's life by 1.",
                EncounterSet = "Flight to the Ford",
                Quantity = 1,
                QuestPoints = 15,
                CardNumber = 28,
                Artist = Artist.Magali_Villeneuve,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Hunted, EncounterSet.TheBlackRiders, EncounterSet.TheNazgul }
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Race To Rivendell",
                StageNumber = 2,
                Id = "6b2673af-c764-4599-a265-6e43d3b75310",
                CardType = CardType.Quest,
                
                OppositeText = "When Revealed: Add Ford of Bruinen and The Witch-king to the staging area.\r\nWhile at least 1 Nazgûl enemy is in play, Race to Rivendell gets +15 quest points.\r\nForced: At the end of the round, reduce the Ring-bearer's life by 1.\r\nIf the players defeat this stage, they have won the game.",
                EncounterSet = "Flight to the Ford",
                Quantity = 1,
                QuestPoints = 15,
                CardNumber = 29,
                Artist = Artist.Darek_Zabrocki,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Hunted, EncounterSet.TheBlackRiders, EncounterSet.TheNazgul }
            });
            Cards.Add(new LotRCard()
            {
                Title = "A Shadow of the Past",
                HasSecondImage = true,
                Id = "307411f3-4a45-44ae-bc64-4e16deb97d10",
                CardType = CardType.Campaign,
                
                Text =
@"You are playing Campaign Mode.

Setup: Attach Mr. Underhill to the Ring-bearer. Add Gandalf's Delay to the staging area. Shuffle Gildor Inglorion and The ~Ring Draws Them into the encounter deck.",
                FlavorText = "\"The Shire, he may be seeking for it now, if has has not already found out where it lies. Indeed, Frodo, I fear that he may even think that the long-unnoticed name of Baggins has become important.\"\r\n-Gandalf, The Fellowship of the Ring",
                OppositeTitle = "The Lord of the Rings Part 1",
                OppositeText = "Resolution: Choose Gandalf's Delay or The ~Ring Draws Them and add it to the Campaign Pool. Then, choose Gildor Inglorion or Mr. Underhill and add it to the Campaign Pool. The chosen cards have been earned by the players.",
                OppositeFlavorText = "The ferry-boat moved slowly across the water. The Buckland shore drew nearer. Sam was the only member of the party who had not been over the river before. He had a stange feeling as the slow gurgling stream slipped by: his old life lay behind in the mists, dark adventure lay in front. He scratched his head, and for a moment had a passing wish that Mr. Frodo could have gone on living quietly at Bag End.\r\n-The Fellowship of the Ring",
                EncounterSet = "A Shadow of the Past",
                Quantity = 1,
                CardNumber = 30,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Bag End",
                Id = "0d30fbf1-6e8f-480f-9f2f-3196777f6e11",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 0,
                QuestPoints = 3,
                Traits = new List<string>() { "Shire." },
                EncounterSet = "A Shadow of the Past",
                Text = "Response: After Bag End leaves play, each player draws 1 card for each Hobbit hero he controls.",
                FlavorText = "...it was popularly believed, whatever the old folk might say, that the Hill at Bag End was full of tunnels stuffed with treasure. -The Fellowship of the Ring",
                VictoryPoints = 1,
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 31,
                Artist = Artist.Tiziano_Baracchi
            });
            Cards.Add(new LotRCard()
            {
                
                Title = "Woody End",
                Id = "b194fe1c-18c8-47d2-a674-8e209339c7e2",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 1,
                Traits = new List<string>() { "Forest." },
                EncounterSet = "A Shadow of the Past",
                Text = "While Woody End is the active location, reduce each Hide X value by 1.",
                FlavorText = "At the south end of the greensward there was an opening. There the green floor ran on into the wood, and formed a wide space like a hall, roofed by the boughs of trees.\r\n-The Fellowship of the Ring",
                VictoryPoints = 1,
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 32,
                Artist = Artist.Julian_Kok
            });
            Cards.Add(new LotRCard()
            {
                Title = "Stock-Brook",
                Id = "2b38254c-e992-4fb5-89e8-e7f636658ce0",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 5,
                Traits = new List<string>() { "Forest.", " Stream." },
                EncounterSet = "A Shadow of the Past",
                Text = "When Revealed: Immediately travel to Stock-brook. If another location is currently active, return it to the staging area.",
                FlavorText = "\"Why, this is the Stock-brook!\" said Pippin. \"If we are going to try and get back on to our course, we must cross at once and bear right.\" -The Fellowship of the Ring",
                VictoryPoints = 1,
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 33,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                Title = "Bamfurlong",
                Id = "82c68020-eb2e-4853-9919-df3066d13721",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 2,
                Traits = new List<string>() { "Shire." },
                EncounterSet = "A Shadow of the Past",
                Text = "Response: After the players travel to Bamfurlong, each player engaged with a Nazgûl enemy may ready a hero he controls.",
                FlavorText = "\"This is Bamfurlong, old Farmer Maggot's land.\"\r\n-Pippin, The Fellowship of the Ring",
                VictoryPoints = 1,
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 34,
                Artist = Artist.Sabin_Boykinov
            });
            Cards.Add(new LotRCard()
            {
                Title = "Bucklebury Ferry",
                Id = "53ac8ba6-0487-4b1f-91e9-cf7ca9e7c1d0",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 9,
                Traits = new List<string>() { "River." },
                EncounterSet = "A Shadow of the Past",
                Text = "Immune to player card effects.\r\nWhile there is at least 1 other location in play, players cannot travel here.\r\n\r\nTravel: The first player must make a Hide 3 test to travel here.\r\n\r\nAfter Bucklebury Ferry leaves play as an explored location, the players win the game.",
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 35,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                Title = "Green Hill Country",
                Id = "98dff367-a068-4aac-a46b-7dc201aff42d",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 3,
                Traits = new List<string>() { "Forest." },
                EncounterSet = "A Shadow of the Past",
                Text = "While Green Hill Country is the active location, characters get +1 Willpower while committed to Hide tests.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if you have failed a Hide test this round)",
                Quantity = 3,
                EasyModeQuantity = 3,
                CardNumber = 36,
                Artist = Artist.Sabin_Boykinov
            });
            Cards.Add(new LotRCard()
            {
                Title = "Stock Road",
                Id = "8df24501-bfd8-4602-92e1-61f5d5cf7035",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string>() { "Road." },
                EncounterSet = "A Shadow of the Past",
                Text = "While Stock Road is in the staging area, add 2 to the total Threat of the discarded cards when a player resolves a Hide test.\r\n\r\nTravel: The first player must make a Hide 1 test to travel here.",
                Quantity = 3,
                EasyModeQuantity = 1,
                CardNumber = 37,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Marish",
                Id = "409bc89e-b5af-4626-ade6-60bcfcb290b7",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 4,
                Traits = new List<string>() { "Marshland." },
                EncounterSet = "A Shadow of the Past",
                Text = "Forced: After a player fails a Hide test, shuffle a Nazgûl enemy from the discard pile into the encounter deck, if able.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending player failed a Hide test this round).",
                Quantity = 2,
                EasyModeQuantity = 1,
                CardNumber = 38,
                Artist = Artist.Sabin_Boykinov
            });
            Cards.Add(new LotRCard()
            {
                Title = "Black Rider",
                Id = "57107fd1-0092-41d3-ae9d-8ff6c06933eb",
                CardType = CardType.Enemy,
                EngagementCost = 35,
                Threat = 4,
                Attack = 5,
                Defense = 4,
                HitPoints = 6,
                Traits = new List<string>() { "Nazgûl." },
                Keywords = new List<string>() { "Hide 2." },
                EncounterSet = "A Shadow of the Past",
                Text = "Cannot have non-Morgul attachments.\r\nForced: After engaged player fails a Hide test, Black Rider makes an immediate attack.",
                FlavorText = "The riding figure sat quite still with its head bowed, as if listening. From inside the hood came a noise as of someone sniffing...-The Fellowship of the Ring",
                Quantity = 5,
                EasyModeQuantity = 3,
                CardNumber = 39,
                Artist = Artist.Mariana_Vieira
            });
            Cards.Add(new LotRCard()
            {
                Title = "Evil Crow",
                Id = "ff597a85-6a02-4301-a9dc-4dcb4cf9b626",
                CardType = CardType.Enemy,
                EngagementCost = 25,
                Threat = 2,
                Attack = 0,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string>() { "Creature." },
                EncounterSet = "A Shadow of the Past",
                Text = "While Evil Crow is engaged with a player, that player adds 1 to the Hide value for each Hide test he makes.",
                Shadow = "Shadow: If you have failed a Hide test this round, this attack is considered undefended",
                Quantity = 3,
                EasyModeQuantity = 3,
                CardNumber = 40,
                Artist = Artist.Christine_Bian
            });
            Cards.Add(new LotRCard()
            {
                Title = "Crawling Towards Him",
                Id = "79b5dd16-2427-4950-94e9-46905eebe56d",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Peril.", " Hide 2." },
                EncounterSet = "A Shadow of the Past",
                Text = "When Revealed: If you have failed a Hide test this phase, remove each character you control from the quest.",
                Shadow = "Shadow: Return attacking enemy to the staging area after this attack.",
                Quantity = 3,
                EasyModeQuantity = 2,
                CardNumber = 41,
                Artist = Artist.Brent_Hollowel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Hunting For The Ring",
                Id = "a46578d6-303e-4f35-9a11-8b9f807427ba",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Doomed 2." },
                EncounterSet = "A Shadow of the Past",
                Text = "When Revealed: Starting with the last player, each player must either return a Nazgûl enemy engaged with him to the staging area or make a Hide 2 test.",
                FlavorText = "\"So he is seeking it, seeking it, and all his thought is bent on it.\" -Gandalf, The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 42,
                Artist = Artist.Diego_Gisbert_Llorens
            });
            Cards.Add(new LotRCard()
            {
                Title = "Have You Seen Baggins?",
                Id = "3104ef1f-4f1c-4603-87cb-f3a70f5e6710",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Peril.", " Surge." },
                EncounterSet = "A Shadow of the Past",
                Text = "When Revealed: Attach to a hero. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Forced: After a player fails a Hide test, discard attached hero.\")",
                FlavorText = "\"He is not far away. I wish to find him. If he passes will you tell me? I will come back with gold.\"\r\n-Black Rider, The Fellowship of the Ring",
                Quantity = 2,
                EasyModeQuantity = 0,
                CardNumber = 43,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard()
            {
                Title = "A Knife in the Dark",
                HasSecondImage = true,
                Id = "2efa631a-eb16-4078-84a5-18c7033b86f3",
                CardType = CardType.Campaign,
                
                Text = "You are playing Campaign Mode.",
                FlavorText = "Black horsemen have passed through Bree. On Monday one came down the Greenway, they say; and another appeared later, coming up the Greenway from the south.\r\n-Aragorn, The Fellowship of the Ring",
                OppositeTitle = "The Lord of the Rings Part 2",
                OppositeText = "Resolution: Starting with the first player, each player may choose one of the following boon cards and attach it to a hero he controls: Tireless ~Ranger, Skilled ~Healer, Valiant ~Warrior, ~Noble Hero. The chosen cards have been earned by the players.",
                OppositeFlavorText = "At that moment Frodo threw himself forward on the ground, and he heard himself crying aloud: O Elbereth! Gilthoniel! At the same time he struck at the feet of his enemy. A shrill cry rang out in the night; and he felt a pain like a dart of poisoned ice pierce his left shoulder. Even as he swooned he caught, as through a swirling mist, a glimpse of Strider leaping out of the darkness with a flaming brand of wood in either hand. With a last effort Frodo, dropping his sword, slipped the Ring from his finger and closed his right hand tight about it.\r\n-The Fellowship of the Ring",
                EncounterSet = "A Knife in the Dark",
                Quantity = 1,
                CardNumber = 44,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Prancing Pony",
                Id = "984d2a01-f12a-4e8b-800c-6a04b1904049",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 4,
                Traits = new List<string>() { "Bree." },
                EncounterSet = "A Knife in the Dark",
                Text = "Response: After players travel here, the first player puts 1 ally into play from his hand.\r\n\r\nForced: After The Prancing Pony leaves play, discard cards from the top of the encounter deck until X enemies have been discarded. X is the number of players in the game. Put each enemy discarded by this effect into play engaged with the first player.",
                VictoryPoints = 1,
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 45,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard()
            {
                Title = "Weathertop",
                Id = "ad09f848-9430-41c8-8723-671f08b79078",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 4,
                Traits = new List<string>() { "Hills.", " Ruins." },
                EncounterSet = "A Knife in the Dark",
                Text = "Immune to player card effects.\r\nWhile Weathertop is in the victory display, each enemy in play gets -1 Threat.\r\n\r\nTravel: The first player must exhaust The One ~Ring to travel here.",
                FlavorText = "\"It was burned and broken, and nothing remains of it now but a tumbled ring...\"\r\n-Strider, The Fellowship of the Ring",
                VictoryPoints = 4,
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 46,
                Artist = Artist.Julian_Kok
            });
            Cards.Add(new LotRCard()
            {
                Title = "Chetwood",
                Id = "df23bd50-5ca3-4a0e-a83c-a349632b0ff4",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 2,
                Traits = new List<string>() { "Forest." },
                EncounterSet = "A Knife in the Dark",
                Text = "While Chetwood is in the staging area, Spy enemies get +1 Threat and +1 Attack.",
                Shadow = "Shadow: Defending player discards 1 random card from his hand.",
                FlavorText = "On the third day out from Bree they came out of the Chetwood. -The Fellowship of the Ring",
                Quantity = 3,
                EasyModeQuantity = 3,
                CardNumber = 47,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                Title = "Midgewater",
                Id = "90d620e5-d7be-42e6-9756-b92761ecd8c9",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 6,
                Traits = new List<string>() { "Marshland." },
                EncounterSet = "A Knife in the Dark",
                Text = "While Midgewater is the active location, enemies cannot attack, take damage, or be engaged.\r\n\r\nForced: After Midgewater becomes the active location, return each engaged enemy in play to the staging area.",
                FlavorText = "...there was no permanent trail even for Rangers to find through their shifting quagmires.\r\n-The Fellowship of the Ring",
                VictoryPoints = 1,
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 48,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new LotRCard()
            {
                Title = "Weather Hills",
                Id = "ddb20145-e570-4099-8d8a-11d64895939b",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 2,
                Traits = new List<string>() { "Forest.", " Hills." },
                EncounterSet = "A Knife in the Dark",
                Text = "Response: After the players travel here, place 1 non-unique enemy in play facedown under this location. While an enemy is under this location, it is out of play.\r\n\r\n Forced: After this location leaves play, return each enemy under it to the staging area face-up.",
                Quantity = 3,
                EasyModeQuantity = 3,
                CardNumber = 49,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new LotRCard()
            {
                Title = "Rider of Mordor",
                Id = "33a575b4-e373-46db-b11e-90f8fc41ef6e",
                CardType = CardType.Enemy,
                EngagementCost = 35,
                Threat = 4,
                Attack = 4,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string>() { "Nazgûl." },
                EncounterSet = "A Knife in the Dark",
                Text = "Cannot have non-Morgul attachments.\r\nWhile Rider of Mordor is engaged with a player, characters that player controls get -1 Willpower.\r\n\r\nWhile The One ~Ring is exhausted, Rider of Mordor gets -10 engagement cost.",
                Quantity = 2,
                EasyModeQuantity = 2,
                CardNumber = 50,
                Artist = Artist.Ryan_Barger
            });
            Cards.Add(new LotRCard()
            {
                Title = "Bill Ferny",
                Id = "6a3e1c91-accd-476b-9ecc-ace35274a052",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 38,
                Threat = 3,
                Attack = 1,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string>() { "Bree.", " Spy." },
                EncounterSet = "A Knife in the Dark",
                Text = "Players cannot optionally engage Bill Ferny.\r\nForced: At the beginning of the staging step, either shuffle 1 out of play Ringwraith into the encounter deck or each player raises their threat by 1 for each non-Fellowship hero he committed to the quest.",
                VictoryPoints = 1,
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 51,
                Artist = Artist.Sarah_Morris
            });
            Cards.Add(new LotRCard()
            {
                Title = "Shady Bree-Lander",
                Id = "0e1451ba-5fa6-4a13-869b-d23d9ecef15e",
                CardType = CardType.Enemy,
                EngagementCost = 28,
                Threat = 2,
                Attack = 3,
                Defense = 1,
                HitPoints = 4,
                Traits = new List<string>() { "Bree.", " Spy." },
                EncounterSet = "A Knife in the Dark",
                Text = "While The One Ring is exhausted, Shady Bree-lander gains: \"Cannot be optionally engaged.\"",
                Shadow = "Shadow: Defending character get -1 Defense (-2 Defense instead if The One ~Ring is exhausted).",
                Quantity = 4,
                EasyModeQuantity = 4,
                CardNumber = 52,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                Title = "Squint-Eyed Southerner",
                Id = "795579db-249d-4c9d-850f-6f39bc96c063",
                CardType = CardType.Enemy,
                EngagementCost = 33,
                Threat = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string>() { "Spy." },
                EncounterSet = "A Knife in the Dark",
                Text = "When Revealed: You must either shuffle an out of play Ringwraith into the encounter deck or reveal an additional encounter card.",
                FlavorText = "Presently he slipped out of the door, followed by the squint-eyed southerner: the two had been whispering together a good deal during the evening.\r\n-The Fellowship of the Ring",
                Quantity = 3,
                EasyModeQuantity = 2,
                CardNumber = 53,
                Artist = Artist.Dimitri_Bielak
            });
            Cards.Add(new LotRCard()
            {
                Title = "Unwanted Attention",
                Id = "d47ece86-2645-4d35-8ab7-c439d12abe65",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Peril." },
                EncounterSet = "A Knife in the Dark",
                Text = "When Revealed: You must either remove 2 heroes you control from the quest or shuffle an out of play Ringwraith into the encounter deck.",
                Shadow = "Shadow: Return attacking enemy to the staging area after this attack.",
                Quantity = 3,
                EasyModeQuantity = 3,
                CardNumber = 54,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new LotRCard()
            {
                Title = "Black Breath",
                Id = "e6721e44-5706-4a0f-a895-ced75f9c6219",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Peril." },
                EncounterSet = "A Knife in the Dark",
                Text = "When Revealed: Attach to a hero you control. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Reduce attached hero's Willpower, Attack and Defense to 0.\")",
                FlavorText = "",
                Quantity = 2,
                EasyModeQuantity = 0,
                CardNumber = 55,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Flight to the Ford",
                HasSecondImage = true,
                Id = "0ee09c42-34c9-41aa-aa98-b582608b15bb",
                CardType = CardType.Campaign,
                
                Text =
@"You are playing Campaign Mode.

Response: After an ememy is declared as an attacker, shuffle the top card of the burden deck into the encounter deck to cancel that attack. (Any player may trigger this ability.)",
                FlavorText = "\"They have drawn off for the time being. But not far, I fear. They will come again another night, if we cannot escape. They are only waiting, because they think that their purpose is almost accomplished, and that the Ring cannot fly much further.\"\r\n-Aragorn, The Fellowship of the Ring",
                OppositeTitle = "The Lord of the Rings Part 3",
                OppositeText = "Resolution: Add each burder card in play, in the encounter deck, and in the discard pile to the Campaign Pool. The added cards have been earned by the players.",
                OppositeFlavorText = "The black horses were filled with madness, and leaping forward in terror they bore their riders into the rushing flood. Their piercing cries were drowned in the roaring of the river as it carried them away. Then Frodo felt himself falling, and the roaring and confusion seemed to rise and engulf him together with his enemies. He heard and saw no more.\r\n-The Fellowship of the Ring",
                EncounterSet = "Flight to the Ford",
                Quantity = 1,
                CardNumber = 56,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                Title = "An Evil Wound",
                Id = "71a2ca21-ff50-4a8a-b30b-7c8eaf6bf6b6",
                CardType = CardType.Objective,
                Traits = new List<string>() { "Morgul." },
                Text = "Attach to the Ring-bearer. Attached hero cannot be healed.\r\nWhen attached hero would take any amount of damage, reduce the Ring-bearer's life by an equal amount instead.\r\nIf the Ring-bearer's life reaches zero, the players lose the game.",
                EncounterSet = "Flight to the Ford",
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 57,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Last Bridge",
                Id = "bc43ae57-6010-4924-919c-b37d1e33b958",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = 4,
                Traits = new List<string>() { "Bridge.", " River." },
                EncounterSet = "Flight to the Ford",
                Text = "Immune to player card effects.\r\nX is the number of players in the game.\r\n\r\nTravel: The first player must reveal the top card of the burden deck and resolve that card as if it were just revealed from the encounter deck to travel here.",
                VictoryPoints = 3,
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 58,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ford of Bruinen",
                Id = "3cd4bb66-1621-4534-aa25-421d0d8b7189",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 6,
                Traits = new List<string>() { "River." },
                EncounterSet = "Flight to the Ford",
                Text = "Immune to player card effects.\r\nResponse: After Ford of Bruinen leaves play as an explored location, all engaged enemies are discarded.\r\n\r\nTravel: The first player must reveal the top card of the encounter deck to travel here.",
                VictoryPoints = 5,
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 59,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Troll's Camp",
                Id = "36dd0d2a-ba57-4ca0-b750-967c958e8bfb",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 2,
                Traits = new List<string>() { "Forest." },
                EncounterSet = "Flight to the Ford",
                Text = "While The Troll's Camp is the active location, each hero gets +1 Willpower, +1 Attack and +1 Defense.",
                FlavorText = "\"We are forgetting our family history! These must be the very three that were caught by Gandalf, quarrelling over the right way to cook thirteen dwarves and one hobbit.\"\r\n-Frodo, The Fellowship of the Ring",
                VictoryPoints = 1,
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 60,
                Artist = Artist.Brent_Hollowel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ettenmoors",
                Id = "ae435070-552a-43a9-816f-9f23f1a6dbba",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 3,
                Traits = new List<string>() { "Forest." },
                EncounterSet = "Flight to the Ford",
                Text = "While Ettenmoors is the active location, do not deal Nazgûl enemies a shadow card during the combat phase.\r\n\r\nForced: After any amount of progress is placed on Ettenmoors, reduce the Ring-bearer's life by 1.",
                FlavorText = "Before long Frodo was obliged to dismount and stuggle along on foot. -The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 61,
                Artist = Artist.Aaron_B_Miller
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Old Road",
                Id = "edae55ef-8025-4553-9ff8-e81526effd59",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 4,
                Traits = new List<string>() { "Road." },
                EncounterSet = "Flight to the Ford",
                Text = "Action: Place the top card of the burden deck on top of the encounter deck to place 4 progress on The Old Road. (Use this action only if you are playing campaign mode.)",
                FlavorText = "\"The Road is watched, be we should have to cross it, if we tried to take cover in the thickets away to the south.\"\r\n-Aragorn, The Fellowship of the Ring",
                Quantity = 3,
                EasyModeQuantity = 3,
                CardNumber = 62,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                Title = "Fell Rider",
                Id = "5c31f690-9802-4638-8316-5380ef32575b",
                CardType = CardType.Enemy,
                EngagementCost = 30,
                Threat = 2,
                Attack = 4,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string>() { "Nazgûl." },
                EncounterSet = "Flight to the Ford",
                Text = "Cannot have non-Morgul attachments.\r\nWhile Fell Rider is in the staging area, it gains: \"Forced: At the beginning of the encounter phase, the first player must either reduce the Ring-bearer's life by 1 or engage Fell Rider.\"",
                Quantity = 4,
                EasyModeQuantity = 4,
                CardNumber = 63,
                Artist = Artist.Aleksander_Karcz
            });
            Cards.Add(new LotRCard()
            {
                Title = "Stricken Dumb",
                Id = "821a078b-ae42-4b69-bd49-cc235916be77",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Peril." },
                EncounterSet = "Flight to the Ford",
                Text = "When Revealed: You must either shuffle the top card of the burden deck into the encounter deck and reveal an additional encounter card, or raise each player's threat by 3 and immediately end the quest phase (do not resolve the quest).",
                FlavorText = "Then the leader, who was now half across the Ford, stood up menacing in his stirrups, and raised up his hand.\r\n-The Fellowship of the Ring",
                Quantity = 3,
                EasyModeQuantity = 3,
                CardNumber = 64,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Enemy is Upon Us!",
                Id = "0e12b3e5-d330-4a13-be7b-5a07a57a2273",
                CardType = CardType.Treachery,
                EncounterSet = "Flight to the Ford",
                Text = "When Revealed: Each engaged enemy makes an immediate attack. If no attack is made this way, The Enemy is Upon Us! gains surge",
                Shadow = "Shadow: If this attack destroys a character, remove all progress from the current quest.",
                Quantity = 2,
                EasyModeQuantity = 0,
                CardNumber = 65,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                Title = "Pain Assailed Him",
                Id = "98bf5fdc-ff74-48e2-88c8-0e4134fd6984",
                CardType = CardType.Treachery,
                EncounterSet = "Flight to the Ford",
                Text = "When Revealed: Reduce the Ring-bearer's life by 1. Then, reduce the Ring-bearer's Willpower, Attack, and Defense to 0 until the end of the round.",
                Shadow = "Shadow: If this attack destroys a character, reduce the Ring-bearer's life by 1.",
                Quantity = 3,
                EasyModeQuantity = 3,
                CardNumber = 66,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Nine are Abroad",
                Id = "98a2fb10-f2fc-462c-9f2e-8945419d9c4f",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Peril." },
                EncounterSet = "Flight to the Ford",
                Text = "When Revealed: Treat the text box of each character in play as blank (except for Traits) until the end of the round. If there is a Nazgûl enemy in the staging area, The Nine are Abroad gains surge.",
                Shadow = "Shadow: Return attacking enemy to the staging area after this attack.",
                Quantity = 2,
                EasyModeQuantity = 1,
                CardNumber = 67,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Witch-king",
                Id = "c5657436-d6c8-400d-ba1f-a723799ac685",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 45,
                Threat = 5,
                Attack = 6,
                Defense = 5,
                HitPoints = 9,
                Traits = new List<string>() { "Nazgûl." },
                Text = "Immune to player card effects.\r\nThe Witch-king gets -30 engagement cost while The One ~Ring is exhausted.\r\n\r\nCharacters with 1 Willpower or less cannot defend attacks made by The Witch-king.",
                EncounterSet = "The Nazgûl",
                Quantity = 1,
                EasyModeQuantity = 1,
                CardNumber = 68,
                Artist = Artist.Jim_Pavelec
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ringwraith",
                Id = "2d819f76-77dd-47a2-9a3f-ac8b8018f0df",
                CardType = CardType.Enemy,
                EngagementCost = 35,
                Threat = 3,
                Attack = 5,
                Defense = 4,
                HitPoints = 5,
                Traits = new List<string>() { "Nazgûl." },
                EncounterSet = "The Nazgûl",
                Text = "Cannot have non-Morgul attachments.\r\nForced: When Ringwraith attacks, deal it an additional shadow card if The One ~Ring is exhausted.",
                Shadow = "Shadow: Shuffle this card into the encounter deck.",
                Quantity = 4,
                EasyModeQuantity = 2,
                CardNumber = 69,
                Artist = Artist.Tiziano_Baracchi
            });
            Cards.Add(new LotRCard()
            {
                Title = "Pale Blade",
                Id = "4b36df3f-d75b-4b3a-9324-9ab31c10d7b9",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Surge." },
                EncounterSet = "The Nazgûl",
                Text = "When Revealed: Attach to a Nazgûl enemy in play, if able. (Counts as a Weapon attachment with the text: \"Limit 1 per enemy. Attached enemy gets +1 Attack and cannot take non-combat damage.\")",
                FlavorText = "...in their haggard hands were swords of steel.\r\n-The Fellowship of the Ring",
                Quantity = 3,
                EasyModeQuantity = 1,
                CardNumber = 70,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard()
            {
                Title = "Power In Their Terror",
                Id = "4765cbea-5ae8-4e39-a811-a67f1f6ca2a0",
                CardType = CardType.Treachery,
                EncounterSet = "The Nazgûl",
                Text = "When Revealed: Each ally gets -1 Willpower until the end of the round. Deal 2 damage to each ally with 0 willpower.",
                Shadow = "Shadow: Discard a non-objective attachment you control.",
                Quantity = 3,
                EasyModeQuantity = 1,
                CardNumber = 71,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard()
            {
                Title = "Pathless Country",
                Id = "32416ec8-b50d-4cd2-a62f-10f97c87be73",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 3,
                Traits = new List<string>() { "Forest." },
                EncounterSet = "Hunted",
                Text = "Pathless Country gets +4 quest points while in the staging area.",
                Shadow = "Shadow: After this attack, the attacking enemy engages the next player then makes an immediate attack.",
                Quantity = 3,
                EasyModeQuantity = 3,
                CardNumber = 72,
                Artist = Artist.Dimitri_Bielak
            });
            Cards.Add(new LotRCard()
            {
                Title = "Piercing Cry",
                Id = "7e470346-1828-49c0-b241-58d0dbf27b4b",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Peril." },
                EncounterSet = "Hunted",
                Text = "When Revealed: Search the encounter deck and discard pile for a Nazgûl enemy. Either add it to the staging area or put it into play engaged with the first player. Shuffle the encounter deck.",
                Shadow = "Shadow: Attacking enemy makes an additional attack after this one.",
                Quantity = 3,
                EasyModeQuantity = 1,
                CardNumber = 73,
                Artist = Artist.Chris_Rallis
            });
            Cards.Add(new LotRCard()
            {
                Title = "Black Steed",
                Id = "09aeff64-6e0d-4dfa-af21-2e7805441376",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Surge." },
                EncounterSet = "The Black Riders",
                Text = "When Revealed: Attach to a Nazgûl enemy in play, if able. (Counts as a Mount attachment with the text: \"Limit 1 per enemy. Attached enemy gets -10 engagement cost and gains: 'Forced: At the end of the refresh phase, return attached enemy to the staging area.'\")",
                Quantity = 3,
                EasyModeQuantity = 1,
                CardNumber = 74,
                Artist = Artist.Sandara_Tang
            });
            Cards.Add(new LotRCard()
            {
                Title = "Rode Like a Gale",
                Id = "1851fafb-7f9a-46d7-a0f0-7fb2ad9ee567",
                CardType = CardType.Treachery,
                EncounterSet = "The Black Riders",
                Text = "When Revealed: Return each engaged Nazgûl enemy to the staging area. If no enemies were returned to the staging area by this effect, Rode Like a Gale gains surge.",
                Shadow = "Shadow: Return attacking enemy to the staging area after this attack.",
                Quantity = 2,
                EasyModeQuantity = 2,
                CardNumber = 75,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new LotRCard()
            {
                Title = "Lure of the Ring",
                Id = "48384e79-d397-4dcd-9862-8a72acb448d0",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Surge." },
                EncounterSet = "The Ring",
                Text = "When Revealed: The first player must either exhaust The One ~Ring or raise his threat 3.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if The One ~Ring is exhausted).",
                Quantity = 3,
                CardNumber = 76,
                Artist = Artist.Melanie_Maier
            });
            Cards.Add(new LotRCard()
            {
                Title = "Gildor Inglorion",
                
                Id = "6c04a40a-0666-4b4f-a768-ddff46857cf0",
                IsUnique = true,
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = CardType.Objective_Ally,
                CardSubtype = Models.CardSubtype.Boon,
                Willpower = 3,
                Attack = 2,
                Defense = 3,
                HitPoints = 3,
                Traits = new List<string>() { "Noldor." },
                Text = "The first player gains control of Gildor Inglorion.\r\nForced: At the end of the round, discard Gildor Inglorion. The first player may spend 1 Fellowship resource to cancel this effect.",
                FlavorText = "\"We think you had best come now with us.\"\r\n-The Fellowship of the Ring",
                Quantity = 1,
                CardNumber = 77,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new LotRCard()
            {
                Title = "Gandalf's Delay",
                
                Id = "d95a6076-3ead-4ff6-a1ba-ca320d2bd4e1",
                CardType = CardType.Objective,
                CardSubtype = Models.CardSubtype.Burden,
                Text = "Setup: Add Gandalf's Delay to the staging area.\r\nEach player draws 1 less card in his starting hand.",
                FlavorText = "The next day Frodo became really anxious, and kept a constant look-out for Gandalf. Thursday, his birthday morning, dawned as fair and clear as it had long ago for Bilbo's great party. Still Gandalf did not appear.\r\n-The Fellowship of the Ring",
                EncounterSet = "A Shadow of the Past",
                Quantity = 1,
                CardNumber = 78,
                Artist = Artist.Drazenka_Kimpel
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Ring Draws Them",
                Id = "1c5f4854-c10c-430b-9c40-2d84c5997b8f",
                CardType = CardType.Treachery,
                CardSubtype = Models.CardSubtype.Burden,
                Keywords = new List<string>() { "Surge." },
                Text = "When Revealed: At the end of the phase, each enemy in the staging area engages the first player. If the One ~Ring is exhausted, this effect cannot be canceled.",
                FlavorText = "\"Also,\" he added, and his voice sank to a whisper, \"the Ring draws them\" -The Fellowship of the Ring",
                EncounterSet = "A Shadow of the Past",
                Quantity = 1,
                CardNumber = 79,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new LotRCard()
            {
                Title = "Weight of the Ring",
                Id = "40c95b3d-6216-4def-bb93-f44871f3ec70",
                CardType = CardType.Treachery,
                CardSubtype = Models.CardSubtype.Burden,
                Keywords = new List<string>() { "Surge." },
                Text = "When Revealed: Attach to the Ring-bearer. (Counts as a Condition attachment with the text: \"Forced: At the beginning of each quest phase, either exhaust The One ~Ring or reveal and additional encounter card this phase.\")",
                FlavorText = "Once more the desire to slip on the Ring came over Frodo... -The Fellowship of the Ring",
                EncounterSet = "Flight to the Ford",
                Quantity = 1,
                CardNumber = 80,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new LotRCard()
            {
                Title = "Fear of Discovery",
                
                Id = "074cad39-ce55-4dc1-9775-e95363682ef7",
                CardType = CardType.Treachery,
                CardSubtype = Models.CardSubtype.Burden,
                Keywords = new List<string>() { "Surge." },
                Text = "When Revealed: The first player must either exhaust the Ring-bearer or reveal and additional encounter card",
                Shadow = "Defending player raises his threat by 3.",
                EncounterSet = "Flight to the Ford",
                Quantity = 1,
                CardNumber = 81,
                Artist = Artist.Chris_Rahn
            });
            Cards.Add(new LotRCard()
            {
                Title = "Eaten Alive!",
                Id = "e8f413bf-3593-47fc-8813-4553d55dbb2a",
                CardType = CardType.Treachery,
                CardSubtype = Models.CardSubtype.Burden,
                Keywords = new List<string>() { "Surge." },
                Text = "When Revealed: The first player must deal X damage divided among heroes he controls where X is the number of players in the game.",
                Shadow = "Shadow: Deal 1 damage to defending character.",
                EncounterSet = "Flight to the Ford",
                Quantity = 1,
                CardNumber = 82,
                Artist = Artist.Melanie_Maier
            });
            Cards.Add(new LotRCard()
            {
                Title = "Panicked",
                Id = "50c19cd1-3094-4bf7-b2dc-e21b145827b7",
                CardType = CardType.Treachery,
                CardSubtype = Models.CardSubtype.Burden,
                Keywords = new List<string>() { "Surge." },
                Text = "When Revealed: The first player raises his threat by 3 and passes the first player token to the next player.",
                Shadow = "Shadow: Defending player exhausts a character he controls.",
                EncounterSet = "Flight to the Ford",
                Quantity = 1,
                CardNumber = 83,
                Artist = Artist.Marcia_George_Bogdan
            });
            Cards.Add(new LotRCard()
            {
                Title = "Overcome by Terror",
                
                Id = "cdc303cb-bb1a-4409-a479-aa4155bd8ed5",
                CardType = CardType.Treachery,
                CardSubtype = Models.CardSubtype.Burden,
                Keywords = new List<string>() { "Surge." },
                Text = "When Revealed: The first player must exhaust The One ~Ring. If The One ~Ring is already exhausted, the first player must discard 2 cards at random from his hand.",
                Shadow = "Shadow: Defending player discards 1 card at random from his hand.",
                EncounterSet = "Flight to the Ford",
                Quantity = 1,
                CardNumber = 84,
                Artist = Artist.Daarken
            });
            Cards.Add(new LotRCard() {
                Title = "The One Ring",
                Id = "c9575426-59ea-4863-bf6a-407e9eae3f33",
                IsUnique = true,
                CardType = CardType.Objective,
                Traits = new List<string>() { "Artifact.", " Item.", " Ring." },
                Text = 
@"Setup: The first player claims The One ~Ring and attaches it to the Ring-bearer.

Attached hero does not count against the hero limit. The first player gains control of attached hero.

If The One ~Ring leaves play, the players lose the game.",
                Quantity = 1,
                CardNumber = 85,
                Artist = Artist.Mike_Nash
            });
        }
    }
}
