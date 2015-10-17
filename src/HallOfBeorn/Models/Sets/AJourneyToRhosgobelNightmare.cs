using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class AJourneyToRhosgobelNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "A Journey to Rhosgobel Nightmare";
            Abbreviation = "AJtRN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2005;

            Cards.Add(new Card()
            {
                Title = "A Journey to Rhosgobel Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Png,
                Id = "146793CB-7609-49D7-B8F5-FC25826CC85E",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Setup: Search the encounter deck for 1 copy of ~Goblin Eagle-hunter and add it to the staging area. Then shuffle the encounter deck.

Forced: The first Creature enemy revealed during each quest phase gains surge.

Response: After an Athelas card is placed in the discard pile, you may shuffle it into the encounter deck.",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for A Journey to Rhosgobel scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

4x ~Forest Grove
1x Exhaustion
2x Swarming Insects
1x Festering Wounds
3x ~Mountains of ~Mirkwood
1x Chieftan Ufthak
2x Dol Guldur Beastmaster
1x Driven by ~Shadow
1x The Necromancer's Reach
2x Necromancer's Pass
2x Enchanted ~Stream

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard A Journey to Rhosgobel encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",

                EncounterSet = "A Journey to Rhosgobel Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Jake_Murray
                /*
                UpdateScenarioCards = (groups) =>
                {
                    foreach (var group in groups)
                    {
                        var scenario = group.Scenarios.Where(x => x.Title == "A Journey to Rhosgobel").FirstOrDefault();
                        if (scenario == null)
                            continue;

                        foreach (var card in scenario.ScenarioCards.Where(x => !x.EncounterSet.EndsWith(" Nightmare")))
                        {
                            switch (card.Title)
                            {
                                case "Forest Grove":
                                    card.NightmareQuantity -= 4;
                                    break;
                                case "Exhaustion":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Swarming Insects":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Festering Wounds":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Mountains of Mirkwood":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Chieftan Ufthak":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Dol Guldur Beastmaster":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Driven by Shadow":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "The Necromancer's Reach":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Necromancer's Pass":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Enchanted Stream":
                                    card.NightmareQuantity -= 2;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    return true;
                }*/
            });
            Cards.Add(new Card()
            {
                Title = "Goblin Eagle-hunter",
                ImageType = ImageType.Png,
                Id = "1C9D123D-FEB3-4BF8-B492-865BC6F3ED3C",
                CardType = CardType.Enemy,
                EngagementCost = 48,
                Threat = 2,
                Attack = 5,
                Defense = 3,
                HitPoints = 4,
                Traits = new List<string> { "Goblin.", "Orc." },
                Text = 
@"Goblin Eagle-hunter gets +1 hit point per player.

Forced: At the end of the combat phase, deal 1 damage to Wilyador",
                Shadow = "Shadow: If Wilyador has 10 or less damage on him, deal 2 damage to Wilyador.",
                EncounterSet = "A Journey to Rhosgobel Nightmare",
                Quantity = 3,
                Number = 2,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new Card()
            {
                Title = "Treetop Bird-eater",
                ImageType = ImageType.Png,
                Id = "4ACFC32F-5ED7-40A3-9FE4-04921CFE961C",
                CardType = CardType.Enemy,
                EngagementCost = 11,
                Threat = 2,
                Attack = 4,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Creature.", "Spider." },
                Text = 
@"While Treetop Bird-eater is engaged with a player, characters controlled by that player cannot be healed.

Forced: At the beginning of the encounter phase, Treetop Bird-eater engages the player who controls Wilyador (regardless of threat).",
                EncounterSet = "A Journey to Rhosgobel Nightmare",
                Quantity = 2,
                Number = 3,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new Card()
            {
                Title = "Dark-wood Grove",
                ImageType = ImageType.Png,
                Id = "3F5EBE31-A8E4-40A7-AB6D-CEF5FEAB41FC",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 4,
                Traits = new List<string> { "Forest." },
                Text = "Dark-wood Grove gets +1 Threat and +1 quest point for each Athelas card in play.",
                Shadow = "Shadow: If defending player controls at least 1 Athelas card, attacking enemy makes an additional attack after this one.",
                EncounterSet = "A Journey to Rhosgobel Nightmare",
                Quantity = 3,
                Number = 4,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new Card()
            {
                Title = "Labyrinthine Woods",
                ImageType = ImageType.Png,
                Id = "03E19827-867B-4E23-935B-925164703A24",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 5,
                Traits = new List<string> { "Forest." },
                Text = "While Labyrinthine Woods is in the staging area, Creature enemies get +1 Threat and +1 Attack.",
                Shadow = "Shadow: After this attack, attacking enemy engages the next player and makes an immediate attack.",
                EncounterSet = "A Journey to Rhosgobel Nightmare",
                Quantity = 3,
                Number = 5,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new Card()
            {
                Title = "Pitch-dark Thicket",
                ImageType = ImageType.Png,
                Id = "27B280E9-4C7F-4FFC-A5B5-2505452DA506",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 2,
                Traits = new List<string> { "Forest." },
                Text = "While Pitch-dark Thicket is the active location, all characters lose the ranged keyword.",
                Shadow = "Shadow: Attacking enemy cannot be attacked by characters with the ranged keyword until the end of the phase.",
                FlavorText = "...so black that you really could see nothing. -The Hobbit",
                EncounterSet = "A Journey to Rhosgobel Nightmare",
                Quantity = 2,
                Number = 6,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "Shot from the Sky",
                ImageType = ImageType.Png,
                Id = "C289A0CD-FC3D-4EA9-8312-F39FD59FBDBA",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Attach to an Eagle character (Counts as a Condition attachment with the text: \"Limit 1 per character. Attached character loses the Eagle trait, and takes 1 damage each time it readies.\")",
                Shadow = "Shadow: Resolve the \"when revealed\" effect of Shot from the Sky.",
                EncounterSet = "A Journey to Rhosgobel Nightmare",
                Quantity = 3,
                Number = 7,
                Artist = Artist.Gabriel_Verdon
            });
            Cards.Add(new Card()
            {
                Title = "Noxious Supplies",
                ImageType = ImageType.Png,
                Id = "B6DE76B6-B171-4124-B026-33C72C8C587F",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Attach to Wilyador. (Counts as a Condition attachment with the text: \"Forced: When attached character is healed by a card effect other than Athelas, the amount of damage healed is reduced to 1. Then, discard Noxious Supplies.\")",
                EncounterSet = "A Journey to Rhosgobel Nightmare",
                Quantity = 3,
                Number = 8,
                Artist = Artist.Sandra_Duchiewicz
            });
        }
    }
}