using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets.TheHobbit
{
    public class OntheDoorstepSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Hobbit: On the Doorstep";
            Abbreviation = "THOtD";
            PublicSlug = "otd";
            Number = 1002;
            SetType = Models.SetType.Saga_Expansion;
            Cycle = "The Hobbit";

            addHero("Bilbo Baggins", 0, Sphere.Baggins, 1, 1, 1, 3)
                .WithTraits("Hobbit.", "Burglar.")
                .WithTextLine("Bilbo ~Baggins does not count against the hero limit and cannot gain resources from non-treasure cards.")
                .WithTextLine("The first player gains control of Bilbo ~Baggins.")
                .WithTextLine("Action: Spend 1 Baggins resource to search your deck for a treasure card and add it to your hand.")
                .WithTextLine("If Bilbo ~Baggins leaves play, the players have lost the game.")
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addHero("Balin", 9, Sphere.Leadership, 2, 1, 2, 4)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: Pay 1 resource from Balin's resource pool to cancel a shadow effect just triggered during an attack. Then, deal the attacking enemy another shadow card. (Limit once per attack.)")
                .WithFlavorLine("\"Well, it is the first time that even a mouse has crept along carefully and quietly under my very nose and not been spotted.\"")
                .WithFlavorLine("-The Hobbit")
                .WithCommunityVersion("RiddermarkLord/Balin-1")
                .WithCommunityVersion("RiddermarkLord/Balin-2")
                .WithCommunityVersion("Hrodebert/Balin-Full-Bleed")
                .WithCommunityVersion("Hrodebert/Balin-Standard-Layout")
                .WithCommunityVersion("Hrodebert/Balin-Zoom-Bleed")
                .WithInfo(2, 1, Artist.Winona_Nelson);
            addHero("Bard the Bowman", 11, Sphere.Tactics, 2, 3, 2, 4)
                .WithTraits("Esgaroth.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("When Bard the Bowman makes a ranged attack, the enemy he attacks gets -2 Defense until the end of the phase.")
                .WithFlavorLine("Now he shot with a great yew bow, till all his arrows but one were spent.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(3, 1, Artist.Magali_Villeneuve);
            addHero("Óin", 8, Sphere.Spirit, 2, 1, 1, 4)
                .WithTraits("Dwarf.")
                .WithTextLine("While you control at least 5 Dwarf characters, Óin gets +1 Attack and gains the Tactics resource icon.")
                .WithFlavorLine("Dwarves can make fire almost anywhere out of almost anything, wind or no wind...")
                .WithFlavorLine("-The Hobbit")
                .WithCommunityVersion("RiddermarkLord/Oin-Spirit-Hero-1")
                .WithCommunityVersion("Hrodebert/Oin-Spirit-Hero")
                .WithInfo(4, 1, Artist.Jeff_Lee_Johnson);
            addHero("Bombur", 8, Sphere.Lore, 0, 1, 2, 5)
                .WithTraits("Dwarf.")
                .WithTextLine("When counting the number of Dwarf characters you control, Bombur counts as two.")
                .WithFlavorLine("\"Bombur is fattest and will do for two, he had better come alone and last.\"")
                .WithFlavorLine("-Gandalf, The Hobbit")
                .WithCommunityVersion("RiddermarkLord/Bombur-Lore-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Bombur-Lore-Hero-2")
                .WithInfo(5, 1, Artist.Ilich_Henriquez);
            addAlly("Glóin", 3, Sphere.Leadership, true, 2, 1, 1, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("While you control at least 5 Dwarf characters, Glóin gains: 'Response: After you play Glóin from your hand, choose a hero. Add 2 resources to that hero's resource pool.'")
                .WithFlavorLine("Glóin lit several more torches, and then they all crept out, one by one...")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(6, 3, Artist.Jeff_Lee_Johnson);
            addAlly("Bifur", 3, Sphere.Lore, true, 1, 2, 1, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("While you control at least 5 Dwarf characters, Bifur gains: 'Response: After you play Bifur from your hand, draw 2 cards.'")
                .WithFlavorLine("\"My cousins! Bombur and Bofur - we have forgotten them, they are down in the valley!\"")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(7, 3, Artist.Taylor_Ingvarsson);
            addAlly("Dwalin", 3, Sphere.Spirit, true, 1, 1, 2, 3)
                .WithTraits("Dwarf.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("While you control at least 5 Dwarf characters, lower the cost to play Dwalin by 2.")
                .WithCommunityVersion("RiddermarkLord/Dwalin-MotK-Spirit-Hero")
                .WithInfo(8, 3, Artist.Melanie_Maier);
            addEvent("Straight Shot", 0, Sphere.Tactics)
                .WithTextLine("Action: Exhaust a Weapon attachment to choose a non-unique enemy with 0 Defense. Discard the chosen enemy.")
                .WithFlavorLine("In it smote and vanished, barb, shaft and feather, so fierce was its flight.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(9, 3, Artist.Ilich_Henriquez);
            addEvent("Desperate Alliance", 0, Sphere.Spirit)
                .WithTextLine("Action: Choose a hero you control. Until the end of the phase, give control of that hero and all resources in that hero's resource pool to another player. (Limit 1 per phase.)")
                .WithFlavorLine("\"Come!\" called Gandalf. \"There is yet time for council.\"")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(10, 3, Artist.Magali_Villeneuve);
            addEvent("Ravens of the Mountain", 1, Sphere.Lore)
                .WithTextLine("Action: Exhaust a hero you control to shuffle the encounter deck and look at its top card. Place progress tokens on the current quest equal to the revealed card's Threat. Then, put that card back on top of the encounter deck.")
                .WithFlavorLine("As they worked the ravens brought them constant tidings.")
                .WithFlavorLine("-The Hobbit")
                .WithErrata(1)
                .WithInfo(11, 3, Artist.Adam_Lane);
            addEvent("To me! O my kinsfolk!", 1, Sphere.Leadership)
                .WithTextLine("Action: If you control at least 1 Dwarf hero, put a Dwarf ally from your discard pile into play under your control. Put that ally on the bottom of your deck at the end of the phase.")
                .WithFlavorLine("Out leapt the King under the Mountain, and his companions followed him.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(12, 3, Artist.Tiziano_Baracchi);
            addEvent("The Lucky Number", 1, Sphere.Baggins)
                .WithTextLine("Action: Choose a character in play (other than Bilbo ~Baggins). Add Bilbo ~Baggins' total Willpower, Attack, and Defense to that character's Willpower, Attack, and Defense respectively until the end of the phase.")
                .WithInfo(13, 3, Artist.Magali_Villeneuve);
            addAttachment("Great Yew Bow", 2, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero with the printed Ranged keyword. Restricted.")
                .WithTextLine("Combat Action: Choose an enemy in the staging area. Exhaust Great Yew Bow and attached hero to make a ranged attack against that enemy. Declare attached hero as the attacker. No other attackers can be declared for this attack.")
                .WithInfo(14, 3, Artist.Sara_Biddle);
            addAttachment("Black Arrow", 0, Sphere.Tactics, true)
                .WithTraits("Artifact.", "Item.")
                .WithText("Limit 1 per deck. Attach to a hero with Ranged.\r\nResponse: After attached hero declares an attack, add Black Arrow to the victory display to give attached hero +5 Attack for this attack.")
                .WithFlavor("\"I have saved you to the last...\" -Bard, The Hobbit")
                .WithVictoryPoints(1)
                .WithLimitOnePerDeck()
                .WithInfo(15, 3, Artist.Melissa_Findley);
            addAttachment("Thrór's Key", 1, Sphere.Spirit, true)
                .WithTraits("Artifact.", "Item.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Response: After a location is added to the staging area, attach Thror's Key to that location. While attached to a location, Thror's Key gains: 'Treat attached location's printed text box as blank, except for traits.'")
                .WithFlavorLine("\"The key that went with the map! Try it now while there is still time!\"") 
                .WithFlavorLine("-Bilbo, The Hobbit")
                .WithInfo(16, 3, Artist.Eric_Braddock);
            addAttachment("Expert Treasure-hunter", 0, Sphere.Lore, false)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Response: After attached hero quests successfully, name a card type and discard the top card of your deck. If the discarded card is the named type, take it into your hand.")
                .WithErrata(1)
                .WithInfo(17, 3, Artist.Magali_Villeneuve);
            addAttachment("King Under the Mountain", 2, Sphere.Leadership, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Dwarf hero.")
                .WithTextLine("Action: Exhaust King Under the Mountain to look at the top 2 cards of your deck. Add 1 to your hand and discard the other.")
                .WithFlavorLine("\"Long ago in my grandfather Thror's time our family was driven out of the far North, and came back with all their wealth and tools to this Mountain on the map.\"")
                .WithFlavorLine("-Thorin, The Hobbit")
                .WithInfo(18, 3, Artist.Magali_Villeneuve);
            addTreasure("Bilbo's Magic Ring", 0, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.", "Ring.")
                .WithTextLine("Attach to Bilbo ~Baggins.")
                .WithTextLine("Action: Exhaust Bilbo's Magic ~Ring and raise your threat by 1 to gain 1 Baggins resource. (Limit once per round.)")
                .WithTextLine("Response: After Bilbo ~Baggins exhausts to defend an attack, exhaust Bilbo's Magic ~Ring and raise your threat by 3 to cancel all damage from this attack.")
                .WithAges(Age.Second_Age, Age.Third_Age)
                .WithInfo(19, 1, Artist.Magali_Villeneuve);
            addTreasure("The Arkenstone", 0, Sphere.Neutral, true)
                .WithTraits("Artifact.", " Erebor.", " Item.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Exhaust The Arkenstone and raise your threat by X to lower by X the cost of the next ally you play this phase that matches the attached hero's sphere.")
                .WithFlavorLine("\"...the Heart of the Mountain; and it is also the heart of Thorin. He values it above a rive of gold.\"")
                .WithFlavorLine("-Bilbo, The Hobbit")
                .WithInfo(20, 1, Artist.Mike_Nash);
            addTreasure("Mithril Shirt", 0, Sphere.Neutral, true)
                .WithTraits( "Artifact.", "Erebor.", "Item.")
                .WithTextLine("Attach to Bilbo ~Baggins.")
                .WithTextLine("Attached hero gets +1 Defense and +1 hit point.")
                .WithFlavorLine("\"Mr. Baggins!\" he cried. \"Here is the first payment of your reward! Cast off your old coat and put on this!\"")
                .WithFlavorLine("-Thorin, The Hobbit")
                .WithInfo(21, 1, Artist.Tiziano_Baracchi);
            addTreasure("Thrór's Battle Axe", 0, Sphere.Neutral, true)
                .WithTraits("Artifact.", " Erebor.", " Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gets +2 Attack.")
                .WithTextLine("Response: After attached hero attacks and destroys an enemy, deal 1 damage to another enemy engaged with you.")
                .WithFlavorLine("Royal indeed did Thorin look, clad in a coat of gold-plated rings, with a silver hafted axe...")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(22, 1, Artist.Tiziano_Baracchi);
            addTreasure("Thrór's Hunting Bow", 0, Sphere.Neutral, true)
                .WithTraits("Artifact.", " Erebor.", " Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gains Ranged.")
                .WithTextLine("When making a ranged attack, attached hero gets +2 Attack.")
                .WithFlavorLine("Thorin seized a bow of horn and shot an arrow at the speaker.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(23, 1, Artist.David_Horne);
            addTreasure("Thrór's Golden Cup", 0, Sphere.Neutral, true)
                .WithTraits("Artifact.", " Erebor.", " Item.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Add Thror's Golden Cup to the victory display to draw 3 cards.")
                .WithFlavorLine("...the great golden cup of Thror, two-handed, hammered and carven with birds and flowers whose eyes and petals were of jewels...")
                .WithFlavorLine("-The Hobbit")
                .WithVictoryPoints(3)
                .WithInfo(24, 1, Artist.Melanie_Maier);
            addQuest("Into Mirkwood", EncounterSet.FliesAndSpiders.Name, 1, 'A', 9)
                .WithTextLine("Setup: Each player may shuffle 1 copy Bilbo's Magic ~Ring into his deck. Search the encounter deck for The Spider's Glade and set it aside, out of play. Then, shuffle the encounter deck and reveal 1 encounter card per player.")
                .WithFlavorLine("\"Stick to the forest-track, keep your spirits up, hope for the best, and with a tremendous slice of luck you may come out one day and see the Long Marshes lying below you, and beyond them, high in the East, the Lonely Mountain where dear old Smaug lives.\"")
                .WithFlavorLine("-Gandalf, The Hobbit")
                .WithOppositeTextLine("Unconscious characters cannot quest, attack, defend, collect resources, trigger abilities, be poisoned, or ready (except by effects that target unconscious character).")
                .WithIncludedEncounterSets(EncounterSet.Wilderland)
                .WithInfo(67, 1, Artist.Magali_Villeneuve);

            Cards.Add(new LotRCard() {
                
                Title = "Lost in the Dark",
                StageNumber = 2,
                Id = "a4ffb8cd-fd95-4b47-95d1-637bd2bd78a1",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = null,
                EncounterSet = "Flies and Spiders",
                FlavorText = "The nights were the worst. It then became pitch-dark - not what you call pitch-dark, but really pitch, so black that you really could see nothing. Bilbo tried flapping his hand in front of his nose but he could not see it at all. Well, perhaps it is not true to say they could see nothing: they could see eyes. -The Hobbit",
                OppositeText = "When Revealed: Reveal stage 3 and create a separate staging area for the first player use that stage. If there are not other players in the game, discard this stage and each card in the staging area. All other players advance to stage 4.",
                OppositeFlavorText = "... the cries of the others got steadily further and fainter, and though after a while it seemed to him they changed to yells and cries for help in the far distance, all noise at last died right away, and he was left alone in complete silence and darkness. -The Hobbit",
                CardNumber = 68,
                Artist = Artist.Adam_Lane,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland },
            }.WithErrataOpposite(1));
            Cards.Add(new LotRCard() {
                
                Title = "Captured by Spiders",
                StageNumber = 3,
                Id = "d99e07f6-7a57-4b5f-a108-13bd7ce6fa4b",
                CardType = CardType.Quest,
                
                Quantity = 1,
                Text = "When Revealed: Remove all resources from each hero's resource pool. Then, make each character you control (except Bilbo ~Baggins) unconscious.",
                FlavorText = "Bilbo was horrified, now that he noticed them for the first time dangling in the shadows, to see a dwarvish foot sticking out from the bottoms of some of the bundles, or here and there the tip of a nose, or a bit of beard or of a hood. -The Hobbit",
                EncounterSet = "Flies and Spiders",
                OppositeText = 
@"Unconscious characters cannot quest, attack, defend, collect resources, trigger abilities, be poisoned, or ready (except by effects that target unconscious character).

Do not pass the first player token. When this stage is complete, do not advance to stage 4 until the end of the quest phase. (Combine staging areas if necessary.)

Action: Spend 2 Baggins resources to ready and unconscious character you control.",
                CardNumber = 69,
                Artist = Artist.Ben_Zweifel,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Battle with the Spiders",
                StageNumber = 4,
                Id = "1ee75e10-bcc5-4243-ab28-3dc1978a50af",
                CardType = CardType.Quest,
                
                Quantity = 1,
                Text = "When Revealed: Add The Spider's Glade to the staging area.",
                FlavorText = "Then the battle began. Some of the dwarves had knives, and some had sticks, and all of them could get stones; and Bilbo had his elvish dagger. Again and again the spiders were beaten off, and many of them were killed. But it could not go on for long. -The Hobbit",
                OppositeText = 
@"Unconscious characters cannot quest, attack, defend, collect resources, trigger abilities, be poisoned, or ready (except by effects that target unconscious character).

Progress cannot be placed on this stage while The Spider's Glade is in play.

Action: Spend 2 Baggins resources to ready an unconscious character you control.

If the players defeat this stage, they have won the game and discovered the treasure card Bilbo's Magic Ring.",
                EncounterSet = "Flies and Spiders",
                CardNumber = 70,
                Artist = Artist.Darek_Zabrocki,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland }
            });
            Cards.Add(new LotRCard() {
                Title = "A Warm Welcome",
                StageNumber = 1,
                Id = "57fc374c-ca6d-4556-9181-c1b578d7a01d",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = null,
                Text = "Setup: Search the encounter deck for Smaug the Golden, Smaug the Magnificent, The Lonely Mountain, and A Bare Patch. Set Smaug the Magnificent and A Bare Patch aside, out of play. Add Smaug the Golden and The Lonely Mountain to the staging area. Shuffle the five Erebor treasure cards and stack them facedown under The Lonely Mountain.",
                OppositeText = "Skip the Quest phase.\r\nForced: At the end of the round, advance to stage 2.",
                OppositeFlavorText = "So one day, although autumn was now getting far on, and winds were cold, and leaves were falling fast, three large boats left Lake-town, laden with rowers, dwarves, Mr. Baggins, and many provisions. -The Hobbit",
                EncounterSet = "The Lonely Mountain",
                CardNumber = 71,
                Artist = Artist.Ben_Zweifel,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland }
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Burglar's Turn",
                StageNumber = 2,
                Id = "4355352b-307e-407b-98f9-3d4fb2a14a49",
                CardType = CardType.Quest,
                
                Quantity = 1,
                EncounterSet = "The Lonely Mountain",
                FlavorText = "There he lay, a vast red-golden dragon, fast asleep; thrumming came from his jaws and nostrils, and wisps of smoke, but his fires were low in slumber. Beneath him, under all his limbs and his huge coiled tail, and about him on all sides stretching away across the unseen floors, lay countless piles of precious things, gold wrought and unwrought, gems and jewels, and silver red-stained in the ruddy light. -The Hobbit",
                OppositeText =
@"Forced: After questing successfully, place 1 progress on Smaug the Golden. Then, he first player makes a burgle attempt. If successful, the first player takes the top card from under The Lonely Mountain into his hand. Then, the players may advance to stage 3.

Forced: After the first player makes an unsuccessful burgle attempt, Smaug the Golden attacks the first player.",
                CardNumber = 72,
                Artist = Artist.Diego_Gisbert_Llorens,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Inside Information",
                StageNumber = 3,
                Id = "a944e2e1-56e4-461d-b703-db991b673b9b",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 20,
                Text = "When Revealed: Set Smaug the Golden aside, out of play. Add Smaug the Magnificent and A Bare Patch to the staging area.",
                FlavorText = "They debated long on what was to be done, but they could think of no way of getting rid of Smaug - which had always been a weak point in their plans, as Bilbo felt inclined to point out. - The Hobbit",
                OppositeText =
@"Players cannot defeat this stage while Smaug the Magnificent is in play.

Forced: If the total number of progress on this stage is greater than the total remaining hit points on Smaug the Magnificent, remove Smaug the Magnificent from play.

If the players defeat this stage, they have won the game and discovered any treasure successfully burgled from The Lonely Mountain.",
                EncounterSet = "The Lonely Mountain",
                CardNumber = 73,
                Artist = Artist.Sidharth_Chatursedi,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland }
            });
            Cards.Add(new LotRCard() {
                Title = "Thieves! Fire! Murder!",
                StageNumber = 4,
                Id = "240a9f5b-17dc-4182-b854-3d2dd5a33f68",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 7,
                Text = "When Revealed: Remove all progress from Smaug the Golden and set him aside, out of play. Then, add Smaug the Magnificent to the staging area.",
                FlavorText = "He issued from the Gate, the waters rose in fierce whistling steam and up he soared blazing into the air and settled on the mountain-top in a spout of green and scarlet flame -The Hobbit",
                OppositeText =
@"Forced: After placing the 7th progress token on this stage, remove all damage from Smaug the Magnificent and set him aside, out of play. Then, add Smaug the Golden to the staging area and reset the quest deck to stage 2B.",
                OppositeFlavorText = "To hunt the whole mountain till he had caught the thief and had torn and trampled him was his one thought -The Hobbit",
                EncounterSet = "The Lonely Mountain",
                CardNumber = 74,
                Artist = Artist.Chris_Rahn,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland }
            });
            Cards.Add(new LotRCard() {
                Title = "The Gathering of the Clouds",
                StageNumber = 1,
                Id = "dfd05c9f-1dc1-4af6-a22f-fe39969c6371",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = null,
                Text = "Setup: Search the encounter deck for Bolg and add it to the staging area. Then, shuffle the encounter deck and reveal 1 encounter card per player.",
                FlavorText = "\"Dread has come upon you all! Alas! It has come more swiftly than I guessed. The Goblins are upon you! Bolg of the North is coming. O Dain! whose father you slew in Moria. Beehold! the bats are above his army like a sea of locusts. They ride upon wolves and Wargs are in their train!\" - Gandalf, The Hobbit",
                OppositeText = "When Revealed: Put stage 2, stage 3 and stage 4 into play at the same time. Then remove this stage from play.",
                OppositeFlavorText = "Ever since the fall of the Great Goblin of the Misty Mountains the hatred of their race for the dwarves had been rekindled to fury. Messengers had passed to and from between all their cities, colonies and strongholds; for they resolved now to win the dominion of the north. -The Hobbit",
                EncounterSet = "The Battle of Five Armies",
                CardNumber = 75,
                Artist = Artist.Sidharth_Chatursedi,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland }
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Eastern Spur",
                StageNumber = 2,
                Id = "aa3355cb-57e1-4d8b-8a1b-9be22581a9f3",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 8,
                EncounterSet = "The Battle of Five Armies",
                FlavorText = "Bard and some of the nimblest of men and elves climbed to the height of the Eastern shoulder to gain a view of the North. Soon they could see the lands before the Mountain's feet black with a hurrying multitude. -The Hobbit",
                OppositeText = 
@"Players cannot advance from this stage unless stage 3 and stage 4 are complete.

Forced: If there is no progress on this stage at the end of the round, each player must discard 1 random card from his hand.",
                CardNumber = 76,
                Artist = Artist.Darek_Zabrocki,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Battle in the Dale",
                StageNumber = 3,
                Id = "81e81787-13b1-4bbf-a9ef-b8516deebbbc",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 8,
                Keywords = new List<string> { "Battle." },
                EncounterSet = "The Battle of Five Armies",
                FlavorText = "As soon as the host of their enemies was dense in the valley, they sent against it a shower of arrows, and each flickered as it fled as if with stinging fire. Behind the arrows a thousand of their spearmen leapt down and charged. The yells were deafening. The rocks were stained black with goblin blood. -The Hobbit",
                OppositeText = 
@"Players cannot advance from this stage unless stage 2 and stage 4 are complete.

Forced: If there is no progress on this stage at the end of the round, the first player adds the topmost enemy in the discard pile to the staging area, if able.",
                CardNumber = 77,
                Artist = Artist.Adam_Schumpert,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland }
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Defense of Ravenhill",
                StageNumber = 4,
                Id = "54ed3453-1df4-458d-bc7d-e1f7c10de237",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = 8,
                Keywords = new List<string> { "Siege." },
                EncounterSet = "The Battle of Five Armies",
                FlavorText = "On all this Bilbo looked with misery. He had taken his stand on Ravenhill among the Elves - partly because there was more chance of escape from that point, and partly (with the more Tookish part of his mind) because if he was going to be in a last desperate stand, he preferred on the whole to defend the Elvenking. -The Hobbit",
                OppositeText =
@"Players cannot advance from this stage unless stage 2 and stage 3 are complete.

Forced: If there is no progress on this stage at the end of the round, each player must discard all resources from each hero's resource pool.",
                CardNumber = 78,
                Artist = Artist.Adam_Lane,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland }
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Clouds Burst",
                StageNumber = 5,
                Id = "82514713-7cc4-4b76-a5f2-42a69ccff76b",
                CardType = CardType.Quest,
                
                Quantity = 1,
                QuestPoints = null,
                EncounterSet = "The Battle of Five Armies",
                FlavorText = "Soon the attackers were attacked, and they were forced into a great ring, facing every way, hemmed all about with goblins and wolves returning to the assault. The bodyguard of Bolg came howling against them, and drove in upon their ranks like waves upon cliffs of sand. -The Hobbit",
                OppositeText =
@"When Revealed: Each player must search the encounter deck and discard pile for a copy of Bodyguard of Bolg and add it to the staging area, if able. Shuffle the encounter deck.

Progress cannot be placed in this stage. While Bolg is in the staging area, it is considered to be engaged with the first player.

If Bolg is destroyed, the players win the game.",
                CardNumber = 79,
                Artist = Artist.Adam_Schumpert,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.Wilderland }
            });
            Cards.Add(new LotRCard() {
                
                Title = "A Bare Patch",
                Id = "9a37677f-6bb6-4ff1-bf0e-8d0798e268c9",
                CardType = CardType.Objective,
                Quantity = 1,
                Traits = new List<string>() { "Information." },
                Text = "While attached, Smaug the Magnificent gets -3 Defense.Response: After the players quest successfully, the first player makes a burgle attempt. If successful, attach A Bare Patch to Smaug the Magnificent.",
                EncounterSet = "The Lonely Mountain",
                CardNumber = 39,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Belching Fire",
                Id = "6f999889-bd70-42c9-ad2a-b159a5e2f73c",
                CardType = CardType.Treachery,
                Quantity = 4,
                Text = "When Revealed: Each Dragon enemy in the staging area makes an immediate attack against the player with the highest total Willpower committed to the quest. (Do not deal a shadow card for this attack.)\r\n\r\nBurgle: The first player shuffles his deck and reveals the top card. He may discard 1 card from his hand that matches the revealed card's type and cost.",
                EncounterSet = "The Lonely Mountain",
                CardNumber = 50,
                Artist = Artist.Christina_Davis
            });
            Cards.Add(new LotRCard() {
                
                Title = "Bodyguard of Bolg",
                Id = "66812347-fac2-4a76-aa69-ac0861071c0d",
                CardType = CardType.Enemy,
                Quantity = 4,
                Traits = new List<string>() { "Goblin.", " Orc." },
                HitPoints = 5,
                Attack = 4,
                Defense = 2,
                Text =
@"Bolg cannot take damage.

Forced: When this enemy attacks, deal it an additional shadow card for each quest stage in play with no progress tokens on it.",
                FlavorText = "...with them came the bodyguard of Bolg, goblins of huge size with scimitars of steel. -The Hobbit",
                EncounterSet = "The Battle of Five Armies",
                EngagementCost = 35,
                Threat = 2,
                CardNumber = 54,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new LotRCard() {
                
                Title = "Bolg",
                Id = "624d5999-1a76-4783-b4e4-d9b596242d18",
                CardType = CardType.Enemy,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string>() { "Goblin.", " Orc." },
                HitPoints = 8,
                Attack = 6,
                Defense = 3,
                Text = "Immune to player card effects.\r\nX is the number of players in the game.Cannot leave the staging area.The first Goblin revealed each round gains surge.",
                EncounterSet = "The Battle of Five Armies",
                EngagementCost = 50,
                Threat = Card.VALUE_X,
                CardNumber = 53,
                Artist = Artist.Jim_Pavelec
            });
            Cards.Add(new LotRCard() {
                
                Title = "Caught in Webs",
                Id = "7a165c5c-caba-4af1-880e-845a124344d7",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: Choose a hero to be removed from the quest and make that hero unconscious. If no hero was removed from the quest by this effect, this card gains surge.",
                FlavorText = "\"What nasty thick skins they have to be sure, but I'll wager there is good juice inside.\" -Spider, The Hobbit",
                EncounterSet = "Flies and Spiders",
                CardNumber = 33,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard() {
                
                Title = "Crazy Cob",
                Id = "b06030a9-7ab9-48a6-b7da-5ffd8ce3a1a6",
                CardType = CardType.Enemy,
                Keywords = new List<string>() { "Venom." },
                Quantity = 3,
                EasyModeQuantity = 2,
                Traits = new List<string>() { "Creature.", " Spider." },
                HitPoints = 2,
                Attack = 3,
                Defense = 2,
                Text = "When Revealed: This enemy attacks the character with the most poison attached.",
                EncounterSet = "Flies and Spiders",
                EngagementCost = 30,
                Shadow = "Shadow: Defending character gets 1 poison.",
                Threat = 2,
                CardNumber = 29,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new LotRCard() {
                
                Title = "Croaking Crows",
                Id = "babeedb8-f7cd-4e8a-a5c4-fbfdd57238fb",
                CardType = CardType.Enemy,
                Keywords = new List<string>() { "Surge." },
                Quantity = 3,
                Traits = new List<string>() { "Creature." },
                HitPoints = 2,
                Attack = 1,
                Defense = 1,
                Text = "Forced: When a location is revealed from the encounter deck, put 1 progress on Smaug the Golden.\r\n\r\nBurgle: The first player shuffles his deck and reveals the top card. He may discard 1 card from his hand that matches the revealed card's sphere and type.",
                EncounterSet = "The Lonely Mountain",
                EngagementCost = 33,
                Threat = 1,
                CardNumber = 42,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new LotRCard() {
                
                Title = "Dark Bats",
                Id = "323842f5-457f-4dd4-95b8-eb19c24664cb",
                CardType = CardType.Enemy,
                Quantity = 3,
                Traits = new List<string>() { "Creature." },
                HitPoints = 1,
                Attack = 2,
                Defense = 0,
                Text = "Forced: After Dark Bats damages a character, attach it to that character. (While attached, counts as a Condition attachment with the text: 'Attached character gets -1 Willpower, -1 Attack, and -1 Defense.')",
                EncounterSet = "Wilderland",
                EngagementCost = 15,
                Shadow = "Shadow: Attach this card to the defending character.",
                Threat = 2,
                CardNumber = 36,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new LotRCard() {
                
                Title = "Desolation of Smaug",
                Id = "435e12a1-d479-42f6-a40d-8067615ec9e1",
                CardType = CardType.Location,
                Quantity = 3,
                Traits = new List<string>() { "Wasteland." },
                Text = "While Desolation of Smaug is the active location, the first treachery card revealed each round gains surge.Burgle: The first player shuffles his deck and reveals the top card. He may discard 2 cards from his hand that match the revealed card's cost.",
                QuestPoints = 3,
                EncounterSet = "The Lonely Mountain",
                Threat = 3,
                CardNumber = 46,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                
                Title = "Dragon-Spell",
                Id = "db6355c7-3edd-4573-a63c-1b6fc08bb8fa",
                CardType = CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 0,
                Traits = new List<string>() { "Enchantment." },
                Text = "When Revealed: Attach to the hero with the most resources without Dragon-Spell attached. (Counts as a Condition attachment with the text: 'Attached hero gets -1 Willpower for each resource in its resource pool. Forced: When attached hero spends resources, attached hero takes X damage. X is equal to the number of resources spent.')",
                EncounterSet = "The Lonely Mountain",
                CardNumber = 51,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard() {
                
                Title = "Fat Spider",
                Id = "5b038648-7a06-4014-b207-a5d68c99e76d",
                CardType = CardType.Enemy,
                Keywords = new List<string>() { "Venom." },
                Quantity = 4,
                EasyModeQuantity = 3,
                Traits = new List<string>() { "Creature.", " Spider." },
                HitPoints = 6,
                Attack = 1,
                Defense = 1,
                Text = "This enemy gets +3 Attack while engaged with a player who controls at least 1 poisoned character.",
                EncounterSet = "Flies and Spiders",
                EngagementCost = 28,
                Shadow = "Shadow: Defending character gets 1 poison. (Give 2 poison to a character you control if undefended.)",
                Threat = 2,
                CardNumber = 31,
                Artist = Artist.Piya_Wannachaiwong
            });
            Cards.Add(new LotRCard() {
                
                Title = "Fighting Among Friends",
                Id = "ffe307bf-dd8e-4df3-9355-55564137d311",
                CardType = CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: The first player names a sphere. Then, all non-Baggins characters who do not belong to the named sphere are removed from the quest.",
                EncounterSet = "Wilderland",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. (+2 Attack instead if undefended.)",
                CardNumber = 37,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Forest Stream",
                Id = "818e2f2f-4070-4056-85bd-5e729ccbad30",
                CardType = CardType.Location,
                Quantity = 2,
                Traits = new List<string>() { "Forest.", " River." },
                Text = "While Forest Stream is the active location, poisoned characters cannot quest.Response: After Forest Stream leaves play as an explored location, discard 4 poison.",
                FlavorText = "It flowed fast and strong but not very wide right across the way, and it was black, or looked it in the gloom. -The Hobbit",
                QuestPoints = 4,
                EncounterSet = "Flies and Spiders",
                Threat = 2,
                CardNumber = 27,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Giant Web",
                Id = "eb353293-1a80-445c-b4a9-422c83dadfd5",
                CardType = CardType.Location,
                Quantity = 4,
                EasyModeQuantity = 3,
                Traits = new List<string>() { "Forest." },
                Text = "While Giant Web is the active location, each character gets -1 Willpower, -1 Attack, and -1 Defense for each poison it has.Response: After Giant Web leaves play as an explored location, ready an unconscious character.",
                QuestPoints = 3,
                EncounterSet = "Flies and Spiders",
                Threat = 3,
                CardNumber = 26,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Goblins are Upon You!",
                Id = "ac4724db-a3cc-4984-bef5-f51b0f4421f8",
                CardType = CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Each player must search the encounter deck and discard pile for a Goblin enemy and put it into play, engaged with him. Then, shuffle the encounter deck. (This effect cannot be canceled.)",
                EncounterSet = "The Battle of Five Armies",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each Goblin enemy engaged with you.",
                CardNumber = 65,
                Artist = Artist.Diego_Gisbert_Llorens
            });
            Cards.Add(new LotRCard() {
                
                Title = "Great Hall",
                Id = "1c65b78b-6b68-458f-9510-a00a9576a042",
                CardType = CardType.Location,
                Quantity = 3,
                EasyModeQuantity = 0,
                Traits = new List<string>() { "Underground." },
                Text = "While Great Hall is the active location, it gains: 'Forced: Put 1 progress on Smaug the Golden at the end of each round.'Burgle: The first player shuffles his deck and reveals the top card. He may discard 3 cards from his hand that match the revealed card's type.",
                QuestPoints = 4,
                EncounterSet = "The Lonely Mountain",
                Threat = 4,
                CardNumber = 44,
                Artist = Artist.Emilio_Rodriguez
            });
            Cards.Add(new LotRCard() {
                
                Title = "Gundabad Climber",
                Id = "771c6c83-a602-4c35-92f6-5ac349c4ec8c",
                CardType = CardType.Enemy,
                Quantity = 4,
                Traits = new List<string>() { "Goblin.", " Orc." },
                HitPoints = 2,
                Attack = 2,
                Defense = 2,
                Text = "When Revealed: Remove 1 progress from every quest stage in play. (2 progress instead if 3 or more players in the game.)",
                FlavorText = "Goblins had scaled the Mountain from the other side and already many were on the slopes aboe the Gate... -The Hobbit",
                EncounterSet = "The Battle of Five Armies",
                EngagementCost = 33,
                Threat = 1,
                CardNumber = 56,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard() {
                
                Title = "Gundabad Wolf Rider",
                Id = "058a5508-6b20-4305-94ea-53d5d2f33595",
                CardType = CardType.Enemy,
                Quantity = 3,
                Traits = new List<string>() { "Goblin.", " Orc." },
                HitPoints = 3,
                Attack = 3,
                Defense = 0,
                Text = "Forced: When this enemy attacks, remove 1 progress from the current quest.",
                EncounterSet = "The Battle of Five Armies",
                EngagementCost = 15,
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each quest stage in play with no progress on it.",
                Threat = 1,
                CardNumber = 55,
                Artist = Artist.Andrew_Olson
            });
            Cards.Add(new LotRCard() {
                
                Title = "Hatred Rekindled",
                Id = "87d2f0c4-8874-4910-9bb4-4f2d06c64168",
                CardType = CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 1,
                Text = "When Revealed: Each enemy engaged with a player makes an immediate attack. Do not deal shadow cards for attacks made by this effect. If no attacks were made by this effect, this card gains surge.",
                EncounterSet = "The Battle of Five Armies",
                Shadow = "Shadow: Attacking enemy makes an additional attack immediately after this one.",
                CardNumber = 64,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new LotRCard() {
                
                Title = "Heedless of Order",
                Id = "19e2470a-94c6-4f14-b824-7d2f952b60fd",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Surge." },
                Quantity = 2,
                Text = "When Revealed: Choose a different quest to be the current quest until the end of the round, if able. If the current quest did not change as a result of this effect, this card gains Doomed 3.",
                FlavorText = "Down, heedless of order, rushed all the dwarves of Dain to his help. Down too came many of the Lake-men, for Bard could not restrain them... -The Hobbit",
                EncounterSet = "The Battle of Five Armies",
                CardNumber = 66,
                Artist = Artist.Sidharth_Chatursedi
            });
            Cards.Add(new LotRCard() {
                
                Title = "Hidden Path",
                Id = "3f78ed57-49cc-4886-b84f-3fe886203794",
                CardType = CardType.Location,
                Quantity = 3,
                Traits = new List<string>() { "Forest.", " Mountain." },
                Text = "While Hidden Path is the active location, locations in the staging area get -1 Threat.Travel: Spend 2 Baggins resources to travel here.",
                FlavorText = "About midday, creeping behind a great stone that stood alone like a pillar, Bilbo came on what looked like rough steps going upwards. -The Hobbit",
                QuestPoints = 1,
                EncounterSet = "Wilderland",
                Threat = 3,
                CardNumber = 35,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Known to an Ounce",
                Id = "da46fcb3-2810-4c21-9070-43969532ef9b",
                CardType = CardType.Treachery,
                Quantity = 2,
                Text = "When Revealed: Each player discards 2 random cards from hand. Until the end of the phase, each Dragon enemy in play gets +1 Threat for each event discarded by this effect.Burgle: The first player shuffles his deck and reveals the top card. He may discard 1 card from his hand that matches the revealed card's sphere and cost.",
                EncounterSet = "The Lonely Mountain",
                CardNumber = 49,
                Artist = Artist.Alex_Stone
            });
            Cards.Add(new LotRCard() {
                
                Title = "Lazy Lob",
                Id = "8815a340-fc16-41c5-ac2c-d647876c2bbd",
                CardType = CardType.Enemy,
                Keywords = new List<string>() { "Venom." },
                Quantity = 3,
                EasyModeQuantity = 1,
                Traits = new List<string>() { "Creature.", " Spider." },
                HitPoints = 3,
                Attack = 3,
                Defense = 0,
                Text = "When Revealed: Each character committed to the quest gets 1 poison.",
                EncounterSet = "Flies and Spiders",
                EngagementCost = 33,
                Shadow = "Shadow: If defending character is poisoned, make that character unconscious.",
                Threat = 3,
                CardNumber = 30,
                Artist = Artist.Andrew_Olson
            });
            Cards.Add(new LotRCard() {
                
                Title = "Misty Mountain Eagle",
                Id = "6e193811-584d-4888-a1b8-5296522b5cd1",
                CardType = CardType.Objective_Ally,
                Quantity = 1,
                Traits = new List<string>() { "Creature.", " Eagle." },
                Willpower = 3,
                HitPoints = 2,
                Attack = 3,
                Defense = 3,
                Text = "Action: The first player may spend 2 Baggins resources to (choose one): take control of Misty ~Mountain ~Eagle, or discard this ally to discard a non-unique enemy in the staging area.",
                EncounterSet = "The Battle of Five Armies",
                Shadow = "Shadow: Deal 3 damage to attacking enemy.",
                CardNumber = 52,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Northern Slopes",
                Id = "29005ca1-107a-4473-8769-ce7d944e9844",
                CardType = CardType.Location,
                Quantity = 3,
                EasyModeQuantity = 2,
                Traits = new List<string>() { "Mountain." },
                Text = "While Northern Slopes is in the staging area, each Goblin enemy gets +1 Attack and +1 Defense.While Northern Slopes is the active location, it gains: 'Forced: When a character leaves play, remove 1 progress from the current quest, if able.'",
                QuestPoints = 3,
                EncounterSet = "The Battle of Five Armies",
                Threat = 3,
                CardNumber = 60,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                
                Title = "Old Tomnoddy",
                Id = "b0d31a1c-2155-4a97-a5ff-912e32a4809e",
                CardType = CardType.Enemy,
                Keywords = new List<string>() { "Venom." },
                Quantity = 3,
                EasyModeQuantity = 1,
                Traits = new List<string>() { "Creature.", " Spider." },
                HitPoints = 4,
                Attack = 5,
                Defense = 2,
                Text = "Forced: At the end of each round, each player must give a hero he controls 1 poison.",
                FlavorText = "...hairy legs waving, nippers an dspinners snapping, eyes popping, full of froth and rage. -The Hobbit",
                EncounterSet = "Flies and Spiders",
                EngagementCost = 37,
                Threat = 3,
                CardNumber = 28,
                Artist = Artist.Jim_Pavelec
            });
            Cards.Add(new LotRCard() {
                
                Title = "Poisoned by Spiders",
                Id = "31ada226-448d-48f8-9f9a-c1f5046ad041",
                CardType = CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Each character takes damage equal to the number of poison it has. If no characters were damaged by this effect, this card gains surge.",
                EncounterSet = "Flies and Spiders",
                Shadow = "Shadow: Discard an unconscious character you control.",
                CardNumber = 34,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new LotRCard() {
                
                Title = "Pretending to Sleep",
                Id = "b7b62c58-7d5d-483d-807e-f4d7e2869579",
                CardType = CardType.Treachery,
                Keywords = new List<string>() { "Surge." },
                Quantity = 3,
                EasyModeQuantity = 0,
                Text = "When Revealed: Put 1 progress token on Smaug the Golden. Then, spend X Baggins resources or advance to stage 4A. X is the number of progress tokens on Smaug the Golden.Burgle: The first player shuffles his deck and reveals the top card. He may discard 2 cards from his hand that match the revealed card's type.",
                EncounterSet = "The Lonely Mountain",
                CardNumber = 48,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ravenhill",
                Id = "f388bf8b-461c-4478-8155-74775bf27714",
                CardType = CardType.Location,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string>() { "Ruins.", " Mountain." },
                Text = "Immune to player card effects.\r\nForced: Remove 2 progress from stage 4B at the end of each round, if able.Travel: Spend 3 Baggins resources to travel here. (1 Baggins resource instead if stage 4B is the current quest.)",
                QuestPoints = 2,
                EncounterSet = "The Battle of Five Armies",
                Threat = 2,
                VictoryPoints = 3,
                CardNumber = 62,
                Artist = Artist.Emilio_Rodriguez
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ravenous Warg",
                Id = "f29b2736-9499-4e1d-9e53-96be59f78741",
                CardType = CardType.Enemy,
                Quantity = 3,
                EasyModeQuantity = 1,
                Traits = new List<string>() { "Creature." },
                HitPoints = 3,
                Attack = 3,
                Defense = 1,
                Text = "Forced: When Ravenous Warg attacks, the defending player must declare the character he controls with the most damage as the defender. (Even if exhausted.)",
                EncounterSet = "The Battle of Five Armies",
                EngagementCost = 30,
                Shadow = "Shadow: Defending character gets -1 Defense for each quest stage in play with no progress on it.",
                Threat = 2,
                CardNumber = 59,
                Artist = Artist.Jim_Pavelec
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ruins of Dale",
                Id = "ee451e81-d7ee-40a6-9079-7f6538a26a26",
                CardType = CardType.Location,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string>() { "Ruins.", " Valley." },
                Text = "Immune to player card effects.\r\nForced: Remove 2 progress from stage 3B at the end of each round, if able.Travel: Spend 3 Baggins resources to travel here. (1 Baggins resource instead if stage 3B is the current quest.)",
                QuestPoints = 2,
                EncounterSet = "The Battle of Five Armies",
                Threat = 2,
                VictoryPoints = 3,
                CardNumber = 61,
                Artist = Artist.Titus_Lunter
            });
            Cards.Add(new LotRCard() {
                
                Title = "Secret Entrance",
                Id = "de8d68fc-15c4-4689-933e-1b2ca638cd78",
                CardType = CardType.Location,
                Quantity = 2,
                Traits = new List<string>() { "Mountain." },
                Text = "While Secret Entrance is the active location, The Lonely Mountain's Threat is reduced by half (round up). Travel: The first player must exhaust a hero and name a card type to travel here. Then, look at the top card of the encounter deck. If the looked at card is not the named type, return Secret Entrance to the staging area. (The players cannot travel again this round.)",
                QuestPoints = 1,
                EncounterSet = "The Lonely Mountain",
                Threat = 1,
                CardNumber = 45,
                Artist = Artist.Darek_Zabrocki,
            }.WithErrata(1));
            
            
            addLocation("The Spider's Glade", EncounterSet.FliesAndSpiders, 1, 9)
                .WithUnique()
                .WithTraits("Forest.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Travel: Exhaust Bilbo ~Baggins to travel here.Forced: At the start of each quest phase, search the encounter deck for 1 Spider enemy and add it to the staging area. (2 Spider enemies instead if 3 or more players are at this stage.) Shuffle the encounter deck.")
                .WithInfo(25, 1, Artist.Joel_Hustak);

            addEnemy("Wicked Spider", EncounterSet.FliesAndSpiders, 25, 1, 4, 1, 3)
                .WithTraits("Creature.", "Spider.")
                .WithKeywords("Venom.")
                .WithTextLine("Venom.")
                .WithTextLine("Forced: When this enemy attacks, defending player must attach 1 poison to a character he controls.")
                .WithShadow("Shadow: Defending character gets 2 poison.")
                .WithInfo(32, 5, Artist.Aurelien_Hubert);

            addTreachery("Weighed Down", EncounterSet.Wilderland)
                .WithTextLine("When Revealed: Until the end of the round, exhausted characters get -1 Willpower, -1 Attack, and -1 Defense.")
                .WithShadow("Shadow: If the defending character is destroyed by this attack, its controller must raise his threat by 5.")
                .WithEasyModeQuantity(1)
                .WithInfo(38, 2, Artist.Anna_Steinbauer);

            addEnemy("Smaug the Golden", EncounterSet.TheLonelyMountain, 50, Card.VALUE_X, 6, 9, 20)
                .WithUnique()
                .WithTraits("Dragon.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Immune to player card effects")
                .WithTextLine("X is the number of non-Burglar characters committed to the quest.")
                .WithTextLine("Forced: After the 6th progress token is placed here, the players advance to stage 4A.")
                .WithInfo(40, 1, Artist.Christopher_Burdett);
            addEnemy("Smaug the Magnificent", EncounterSet.TheLonelyMountain, 50, 6, 8, 8, 20)
                .WithUnique()
                .WithTraits("Dragon.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Immune to player card effects.")
                .WithTextLine("Cannot leave the staging area (except by quest effect) but is considered to be engaged with the first player.")
                .WithTextLine("Forced: If Smaug the Magnificent is dealt a shadow card with a burgle effect, he makes an additional attack immediately after this one.")
                .WithInfo(41, 1, Artist.Christopher_Burdett);

            addLocation("The Lonely Mountain", EncounterSet.TheLonelyMountain, 12, 4)
                .WithSlugSuffix("Location")
                .WithUnique()
                .WithTraits("Mountain.")
                .WithTextLine("While at least 1 card is stacked underneath, The Lonely Mountain is immune to player card effects, cannot leave the staging area, and gets -2 Threat for each card stacked under it.Action: While making a burgle attempt, the first player may spend 2 Baggins resources to take the revealed card into hand and reveal the next card of his deck.")
                .WithVictoryPoints(10)
                .WithInfo(43, 1, Artist.Joel_Hustak);

            addLocation("Western Slopes", EncounterSet.TheLonelyMountain, 2, 5)
                .WithTraits("Mountain.")
                .WithTextLine("Response: When Western Slopes leaves play as an explored location (choose one): the first player draws 2 cards, or remove 1 progress token from Smaug the Golden.")
                .WithTextLine("Burgle: The first player shuffles his deck and reveals the top card. He may discard 2 cards from his hand that match the revealed card's sphere.")
                .WithInfo(47, 3, Artist.Sara_K_Diesel);

            addEnemy("Vanguard of Bolg", EncounterSet.TheBattleOfFiveArmies, 20, 1, 1, 1, 4)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("This enemy gets +1 Threat, +1 Attack, and +1 Defense for each quest stage in play with no progress on it.")
                .WithShadow("Shadow: If this attack destroys a character, remove all progress from the current quest.")
                .WithEasyModeQuantity(3)
                .WithInfo(57, 4, Artist.Diego_Gisbert_Llorens);
            addEnemy("Gundabad Archer", EncounterSet.TheBattleOfFiveArmies, 40, 2, 2, 1, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("When Revealed: Each player must deal 2 damage to a character he controls.")
                .WithShadow("Shadow: Deal 1 damage to defending character for each quest stage in play with no progress on it.")
                .WithInfo(58, 2, Artist.Florian_Stitz);

            addLocation("The Front Gate", EncounterSet.TheBattleOfFiveArmies, 2, 2)
                .WithUnique()
                .WithTraits("Ruins.", "Mountain.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: Remove 2 progress from stage 2B at the end of each round, if able.Travel: Spend 3 Baggins resources to travel here. (1 Baggins resource instead if stage 2B is the current quest.)")
                .WithVictoryPoints(3)
                .WithInfo(63, 1, Artist.Emilio_Rodriguez);
        }
    }
}
