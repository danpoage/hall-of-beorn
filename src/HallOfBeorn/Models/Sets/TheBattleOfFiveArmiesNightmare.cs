using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheBattleOfFiveArmiesNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Battle of Five Armies Nightmare";
            Abbreviation = "FaSN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2058;

            Cards.Add(new Card()
            {
                Title = "The Battle of Five Armies Nightmare",
                HasSecondImage = true,
                Id = "4B62A616-0F18-4577-A42D-0ACABA3703CF",
                CardType = CardType.Nightmare_Setup,
                Text =
"You are playing Nightmare mode.\r\nWhile the players are at stage 5b, this card gains: \"Forced: When the players are instructed to remove any amount of progress from a quest stage, place 1 progress here instead.\"\r\nIf there are X progress tokens here, the players lose the game. X depends on the number of players in the game:\r\n1 player: X equals 5\r\n2 players: X equals 7\r\n3 players: X equals 9\r\n4 players: X equals 11",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Battle of Five Armies Nightmare scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x Dark Bats
3x Hidden Path
2x Fighting Among Friends
1x Vanguard of Bolg
1x Ravenous Warg
4x Gundabad Climber
3x Gundabad Wolf Rider
1x Misty Mountain Eagle

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Battle of Five Armies Nightmare encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "The Battle of Five Armies Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Jason_Ward
                /*
                UpdateScenarioCards = (groups) =>
                {
                    foreach (var group in groups)
                    {
                        var scenario = group.Scenarios.Where(x => x.Title == "Flies and Spiders").FirstOrDefault();
                        if (scenario == null)
                            continue;

                        foreach (var card in scenario.ScenarioCards.Where(x => !x.EncounterSet.EndsWith(" Nightmare")))
                        {
                            switch (card.Title)
                            {
                                case "Dark Bats":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Hidden Path":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Fighting Among Friends":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Vanguard of Bolg":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Ravenous Warg":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Gundabad Climber":
                                    card.NightmareQuantity -= 4;
                                    break;
                                case "Gundabad Wolf Rider":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Misty Mountain Eagle":
                                    card.NightmareQuantity -= 1;
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
                Title = "Great Warg",
                Id = "87F3C5BC-CBEC-455B-B066-7C82FE775AFF",
                CardType = CardType.Enemy,
                EngagementCost = 25,
                Threat = 4,
                Attack = 5,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Creature." },
                Text = "Forced: After Great Warg attacks and destroys a character, remove all progress from the current quest.",
                Shadow = "Shadow: Defending player discards 1 attachment he controls.",
                EncounterSet = "The Battle of Five Armies Nightmare",
                Quantity = 3,
                Number = 2,
                Artist = Artist.Jon_Bosco
            });
            Cards.Add(new Card()
            {
                Title = "Frenzied Warg-Rider",
                Id = "{D0FDE199-F31D-4EA5-9CB4-129B90FC2CD4}",
                CardType = CardType.Enemy,
                EngagementCost = 15,
                Threat = 3,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Goblin.", "Orc." },
                Text = "Forced: When Frenzied Warg-Rider attacks, remove 1 progress from each quest stage.",
                Shadow = "Shadow: Deal 1 damage to the defending character (2 damage instead if the current quest has no progress on it).",
                EncounterSet = "The Battle of Five Armies Nightmare",
                Quantity = 4,
                Number = 3,
                Artist = Artist.Beth_Sobel
            });
            Cards.Add(new Card()
            {
                Title = "Gundabad Elite",
                Id = "5A4FCE0E-9A88-490C-A3C3-56FE747BBD35",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 2,
                Attack = 5,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Goblin.", "Orc." },
                Text = "Cannot be optionally engaged.\r\nForced: At the end of the round, if Gundabad Elite is in the staging area, either remove 2 progress from the current quest, or Gundabad Elite makes an attack against the first player.",
                EncounterSet = "The Battle of Five Armies Nightmare",
                Quantity = 4,
                Number = 4,
                Artist = Artist.Florian_Devos
            });
            Cards.Add(new Card()
            {
                Title = "Embattled Valley",
                Id = "E745CF55-FBF7-4D82-B81F-0BA4224BBECA",
                CardType = CardType.Location,
                Threat = 5,
                QuestPoints = 5,
                Traits = new List<string> { "Valley." },
                Text = "Forced: At the end of the round, each player assigns X damage among heroes he controls. X is the number of quest stages with no progress on them.\r\nTravel: The players (as a group) exhaust X characters. X is the number of quest stages with no progress on them.",
                EncounterSet = "The Battle of Five Armies Nightmare",
                Quantity = 2,
                Number = 5,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card()
            {
                Title = "Eastern Ridge",
                Id = "78D35EBB-65F9-45D2-87BD-CCDC42EBDB12",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 6,
                Traits = new List<string> { "Mountain." },
                Text = "Forced: At the end of the round, raise each player's threat by 1 for each quest stage with no progress on it.",
                Shadow = "Shadow: Until the end of the phase, attacking enemy gets +1 Defense for each quest stage with no progress on it.",
                EncounterSet = "The Battle of Five Armies Nightmare",
                Quantity = 3,
                Number = 6,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new Card()
            {
                Title = "Dread Has Come!",
                Id = "9F0316F2-C338-4967-A189-4F2DBB4DDCDF",
                CardType = CardType.Treachery,
                Text = "When Revealed: Bolg makes an attack against each player in turn order. If at least 1 character is destroyed by one of these attacks, the players cannot place progress on the current quest phase this round.",
                Shadow = "Shadow: Attacking enemy gets +2 Attack.",
                EncounterSet = "The Battle of Five Armies Nightmare",
                Quantity = 3,
                Number = 7,
                Artist = Artist.Anthony_Devine
            });
        }
    }
}