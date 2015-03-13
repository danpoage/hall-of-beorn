using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheSeventhLevelNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Seventh Level Nightmare";
            Abbreviation = "TSLN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2010;

            Cards.Add(new Card()
            {
                Title = "The Seventh Level Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Png,
                Id = "4A2A4373-7D97-4664-A502-C083A6D6079E",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Setup: Set Overseer Maurûl and Chamber of Records aside, out of play.

Forced: When stage 2B is revealed, make Chamber of Records the active location (returning any currently active location to the staging area) and add Overseer Maurûl to the staging area. Then, shuffle all copies of Balin's Doom in the encounter discard pile back into the encounter deck.",
                FlavorText = "\"They seem to have made a last stand by both doors,\" he said; \"but there were not many left by that time. So ended the attempt to retake Moria! It was valiant but foolish.\". -Gandalf, The Fellowship of the Ring",

                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Seventh Level scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

2x Plundered Armoury
2x Hidden ~Threat
2x Upper Hall
2x ~Goblin ~Scout
2x ~Goblin Swordsman
2x ~Goblin Spearman

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Seventh Level encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin." +
"\"Does not stack\"\r\n\r\nSome cards have passive abilities with the text \"This ability does not stack with...\" While two or more effects that do not stack with one another are active, only one of them will affect the game state.",

                EncounterSet = "The Seventh Level Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Mark_Bulahao,
                UpdateScenarioCards = (groups) =>
                {
                    foreach (var group in groups)
                    {
                        var scenario = group.Scenarios.Where(x => x.Title == "The Seventh Level").FirstOrDefault();
                        if (scenario == null)
                            continue;

                        foreach (var card in scenario.ScenarioCards.Where(x => !x.EncounterSet.EndsWith(" Nightmare")))
                        {
                            switch (card.Title)
                            {
                                case "Plundered Armoury":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Hidden Threat":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Upper Hall":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Goblin Scout":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Goblin Swordsman":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Goblin Spearman":
                                    card.NightmareQuantity -= 2;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    return true;
                }
            });
            Cards.Add(new Card()
            {
                Title = "Overseer Maurûl",
                IsUnique = true,
                ImageType = ImageType.Png,
                Id = "F61D5E3F-9CE7-4939-AF86-F77A92D3FBB0",
                CardType = CardType.Enemy,
                EngagementCost = 20,
                Threat = 3,
                Attack = 3,
                Defense = 3,
                HitPoints = 12,
                Traits = new List<string> { "Mordor.", "Orc." },
                Text = @"Overseer Maurûl gets +X Threat, +X Attack and +X Defense, where X is the highest number of resources on a Goblin enemy in play.
                
                The Players cannot win the game unless Overseer Maurûl is in the victory display.",
                VictoryPoints = 5,
                EncounterSet = "The Seventh Level Nightmare",
                Quantity = 1,
                Number = 2,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new Card()
            {
                Title = "Chamber of Records",
                IsUnique = true,
                ImageType = ImageType.Png,
                Id = "A27F95E3-3DE8-4358-831D-DD027908B955",
                CardType = CardType.Location,
                Threat = 5,
                QuestPoints = 8,
                Traits = new List<string> { "Underground." },
                Text = "Immune to player card effects.\r\nEach Goblin enemy with at least 1 resource on it is immune to player events.\r\n\r\nForced: When a Goblin enemy engages a player, add 2 resources to that enemy.",
                FlavorText = "\"Now, I fear, we must say farewell to Balin son of Fundin.\"\r\n-Gandalf, The Fellowship of the Ring",
                VictoryPoints = 5,
                EncounterSet = "The Seventh Level Nightmare",
                Quantity = 1,
                Number = 3,
                Artist = Artist.Juan_Carlos_Barquet
            });
            Cards.Add(new Card()
            {
                Title = "Orc Taskmaster",
                ImageType = ImageType.Png,
                Id = "EF2A8F64-950C-4E2A-BDC7-2D2AB35FEEFA",
                CardType = CardType.Enemy,
                EngagementCost = 44,
                Threat = 1,
                Attack = 4,
                Defense = 4,
                HitPoints = 6,
                Traits = new List<string> { "Mordor.", "Orc." },
                Text = 
@"When Revealed: Add 1 resource to each Goblin enemy in play.
                
Forced: When a Goblin enemy with at least 1 resource on it is dealt any amount of damage, remove 1 resource from that enemy and cancel all damage just dealt to it.",
                EncounterSet = "The Seventh Level Nightmare",
                Quantity = 2,
                Number = 4,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new Card()
            {
                Title = "Goblin Skirmisher",
                ImageType = ImageType.Png,
                Id = "BD58DF6F-B041-4990-817A-FB85E340383D",
                CardType = CardType.Enemy,
                EngagementCost = 15,
                Threat = 2,
                Attack = 4,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Goblin.", "Orc." },
                Text = "Each Goblin enemy gets +1 Attack for each resource on it. This ability does not stack with other copies of ~Goblin Skirmisher.",
                Shadow = "Shadow: Deal X damage to the defending character. X is the number of resources on attacking enemy.",
                EncounterSet = "The Seventh Level Nightmare",
                Quantity = 3,
                Number = 5,
                Artist = Artist.Rick_Price
            });
            Cards.Add(new Card()
            {
                Title = "Pit Goblin",
                ImageType = ImageType.Png,
                Id = "59BA724D-519F-4B9C-B0C8-2DC847A7B5DE",
                CardType = CardType.Enemy,
                EngagementCost = 36,
                Threat = 3,
                Attack = 2,
                Defense = 1,
                HitPoints = 4,
                Traits = new List<string> { "Goblin.", "Orc." },
                Text = "When Revealed: Add 2 resources to Pit Goblin.",
                Shadow = "Shadow: If attacking enemy is a Goblin, add 1 resource to it.",
                EncounterSet = "The Seventh Level Nightmare",
                Quantity = 2,
                Number = 6,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Deep-Mines",
                ImageType = ImageType.Png,
                Id = "3CDFFD2F-AD4F-494B-BEF3-51E7BF0D3831",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 6,
                Traits = new List<string> { "Underground." },
                Text = "Forced: When a Goblin enemy enters play, add 1 resource to that enemy if Deep-Mines is in the staging area.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. Then, if attacking enemy is a Goblin, deal it another shadow card.",
                EncounterSet = "The Seventh Level Nightmare",
                Quantity = 3,
                Number = 7,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new Card()
            {
                Title = "Western Hall",
                ImageType = ImageType.Png,
                Id = "271067BE-C5D3-49F2-A460-C91C35750E88",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 4,
                Traits = new List<string> { "Underground." },
                Text = "Each Goblin in play gets +1 Threat for each resource on it. This ability does not stack with other copies of Western Hall",
                FlavorText = "Away beyond the shadows at the western end of the hall there came cries and horn-calls.\r\n-The Fellowship of the Ring",
                EncounterSet = "The Seventh Level Nightmare",
                Quantity = 2,
                Number = 8,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card()
            {
                Title = "Balin's Doom",
                ImageType = ImageType.Png,
                Id = "4F0ADDDF-50F0-49FB-88A7-E2F37B1A3BCF",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge.", "Doomed 1." },
                Text = "When Revealed: Add 1 resource to each Goblin enemy in play.",
                Shadow = "Shadow: If attacking enemy is a Goblin, add 1 resource to it.",
                EncounterSet = "The Seventh Level Nightmare",
                Quantity = 3,
                Number = 9,
                Artist = Artist.Sebastian_Giacobino
            });
            Cards.Add(new Card()
            {
                Title = "Beats and Echoes",
                ImageType = ImageType.Png,
                Id = "EDFBC460-3EB4-4FA9-AFE2-6E538C86B8CE",
                CardType = CardType.Treachery,
                Text = "When Revealed: Reveal the top X cards of the encounter deck, adding all enemies to the staging area. Discard the other revealed cards without resolving them. X is 2 plus the number of players not engaged with a Goblin enemy.",
                FlavorText = "Eachoes ran along as they hurried forward; and there seemed to be the sound of many footfalls following their own. -The Fellowship of the Ring",
                EncounterSet = "The Seventh Level Nightmare",
                Quantity = 2,
                Number = 10,
                Artist = Artist.Mark_Bulahao
            });
        }
    }
}