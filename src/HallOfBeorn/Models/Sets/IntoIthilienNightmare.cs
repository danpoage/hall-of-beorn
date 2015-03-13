using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class IntoIthilienNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Into Ithilien Nightmare";
            Abbreviation = "IIN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2054;

            Cards.Add(new Card()
            {
                Title = "Into Ithilien Nightmare",
                HasSecondImage = true,
                Id = "F5979D4C-BC5B-467A-ADAB-B0EB70A0C3CC",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Setup: Set both copies of Mûmak Elite aside, out of play.

Forced: When quest stages 2A or 4A are revealed, add 1 of the previously set aside copies of Mûmak Elite to the staging area.",
                FlavorText = "For a moment he caught a glimpse of swarthy maen in red running down the slope some way off with green-clad warriors leaping after them, hewing them down as they fled. Arrows were thick in the air. -The Two Towers",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Into Ithilien scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x Blocking ~Wargs
2x Watcher in the ~Wood
3x Secluded Glade
3x ~Forest Bat
3x Southon Mercenaries
1x Overgrown Trail

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Into Ithilien encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "Into Ithilien Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Guillaume_Ducos,
                UpdateScenarioCards = (groups) =>
                {
                    foreach (var group in groups)
                    {
                        var scenario = group.Scenarios.Where(x => x.Title == "Into Ithilien").FirstOrDefault();
                        if (scenario == null)
                            continue;

                        foreach (var card in scenario.ScenarioCards.Where(x => !x.EncounterSet.EndsWith(" Nightmare")))
                        {
                            switch (card.Title)
                            {
                                case "Blocking Wargs":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Watcher in the Wood":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Secluded Glade":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Forest Bat":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Southron Mercenaries":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Overgrown Trail":
                                    card.NightmareQuantity -= 1;
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
                Title = "Mûmak Elite",
                NormalizedTitle = "Mumak Elite",
                Id = "46153486-ED33-47A8-8B6B-8DBB4049DC19",
                CardType = Models.CardType.Enemy,
                EngagementCost = 38,
                Threat = 5,
                Attack = 7,
                Defense = 5,
                HitPoints = 12,
                Traits = new List<string> { "Harad.", "Creature." },
                Text = "Cannot have attachments. Archery X.\r\nX is the number of players in the game.\r\nMûmak Elite cannot take more than 3 damage each round.",
                EncounterSet = "Into Ithilien Nightmare",
                Number = 2,
                Quantity = 2,
                Artist = Artist.Anthony_Feliciano
            });
            Cards.Add(new Card()
            {
                Title = "Haradrim Marksman",
                Id = "694BF968-E806-44EC-82BA-F229B4D7D4D6",
                CardType = Models.CardType.Enemy,
                EngagementCost = 36,
                Threat = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Harad." },
                Text = "While the current quest has battle, Haradrim Marksman gets +2 Threat and gains archery 2.\r\nWhile the current quest has siege, Haradrim Marksman gets +2 Attack and allies cannot be declared as defenders against its attacks.",
                EncounterSet = "Into Ithilien Nightmare",
                Number = 3,
                Quantity = 3,
                Artist = Artist.Florian_Devos
            });
            Cards.Add(new Card()
            {
                Title = "Haradrim Captain",
                Id = "21B838E4-0D14-432C-B123-0904D14C8996",
                CardType = Models.CardType.Enemy,
                EngagementCost = 44,
                Threat = 4,
                Attack = 4,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Harad." },
                Text = "Each Harad enemy in the staging area gains archery 1.\r\nEach engaged Harad enemy gets +1 Defense.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if it has the Harad trait).",
                EncounterSet = "Into Ithilien Nightmare",
                Number = 4,
                Quantity = 2,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new Card()
            {
                Title = "Ithilien Overlook",
                Id = "180348B9-8500-4201-A5CF-EB37502C7ADC",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 4,
                Traits = new List<string> { "Forest." },
                Keywords = new List<string>{ "Archery 2." },
                Text = "When assigning archery damage to a character, you must continue assigning archery damage to that character until that character is destroyed or there is no more archery damage to assign.",
                EncounterSet = "Into Ithilien Nightmare",
                Number = 5,
                Quantity = 3,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new Card()
            {
                Title = "Dense Thickets",
                Id = "4C42F055-4948-481D-9FF1-90431079F7EB",
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 8,
                Traits = new List<string> { "Forest." },
                Text = "While Dense Thickets is in the staging area, each Forest location in play gets +1 Threat.",
                Shadow = "Shadow: Excess damage dealt by this attack (damage that is dealt beyond the remaining hit points of the character damaged by this attack) must be assigned to a Ranger objective in play.",
                EncounterSet = "Into Ithilien Nightmare",
                Number = 6,
                Quantity = 3,
                Artist = Artist.Wibben
            });
            Cards.Add(new Card()
            {
                Title = "Cormallen Fields",
                Id = "2CFD2008-3D5D-4815-BAC8-12DD6AED3F27",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 5,
                Traits = new List<string> { "Plains.", "Riverland." },
                Text = "While the current quest has battle, Cormallen Fields gets +2 Threat.\r\nWhile the current quest has siege, when faced with the option to travel, the players must travel to Cormallen Fields, if able.",
                EncounterSet = "Into Ithilien Nightmare",
                Number = 7,
                Quantity = 2,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card()
            {
                Title = "Obsidian Arrows",
                Id = "21A706A7-E6DA-4DEE-AF67-961F384939E3",
                CardType = CardType.Treachery,
                Text = "When Revealed: The current quest gains archery 2 until the end of the round. Then, assign all archery damage to characters in play as if it were the beginning of the combat phase.",
                Shadow = "Shadow: Attacking enemy gets +X Attack. X is that enemy's archery value.",
                EncounterSet = "Into Ithilien Nightmare",
                Number = 8,
                Quantity = 2,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new Card()
            {
                Title = "Savage Fray",
                Id = "D76B2003-839A-406A-AF4D-BFBE8402E8F0",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Doomed 2." },
                Text = "When Revealed: If the current quest has a keyword, until the end of the round, switch that keyword from battle to siege, or siege to battle, if able. If the current quest does not have a keyword, Savage Fray gains surge.",
                EncounterSet = "Into Ithilien Nightmare",
                Number = 9,
                Quantity = 2,
                Artist = Artist.Tiziano_Baracchi
            });
        }
    }
}