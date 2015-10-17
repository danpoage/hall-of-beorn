using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class JourneyAlongTheAnduinNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Journey Along the Anduin Nightmare";
            Abbreviation = "JAtAN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2001;

            Cards.Add(new Card()
            {
                Title = "Journey Along the Anduin Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                Id = "9AE317F1-0CDF-410C-A063-C6A0A340DE45",
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\n\r\nAll Troll enemies gain the text: \"Cannot have attachments.\"\r\n\r\nIf the encounter deck is empty (at any time), shuffle the encounter discard pile back into the encounter deck.",
                OppositeText = 
@"Begin with the standard quest deck and encounter deck for the Journey Along the Anduin scenario found in the LOTR LCG core set.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x Evil Storm
2x Treacherous Fog
2x Banks of the Anduin
3x Dol Guldur Orcs
2x Enchanted ~Stream
2x Despair
3x Misty ~Mountain Goblins
2x Necromancer's Pass

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Journey Along the Anduin encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "Journey Along the Anduin Nightmare",
                AlternateEncounterSet = "Journey Down the Anduin Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Alexandre_Dainche
                /*
                UpdateScenarioCards = (groups) =>
                {
                    foreach (var group in groups)
                    {
                        var scenario = group.Scenarios.Where(x => x.Title == "Journey Down the Anduin").FirstOrDefault();
                        if (scenario == null)
                            continue;

                        foreach (var card in scenario.ScenarioCards.Where(x => !x.EncounterSet.EndsWith(" Nightmare")))
                        {
                            switch (card.Title)
                            {
                                case "Evil Storm":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Treacherous Fog":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Banks of the Anduin":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Dol Guldur Orcs":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Enchanted Stream":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Despair":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Misty Mountain Goblins":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Necromancer's Pass":
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
                Title = "Marshland Outlaws",
                ImageType = ImageType.Jpg,
                Id = "A7A341CA-431A-464F-B2EE-D51840E35270",
                CardType = CardType.Enemy,
                EngagementCost = 21,
                Threat = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 8,
                Traits = new List<string> { "Marshland." },
                Text = "If you are engaged with this enemy, you cannot attack or deal damage (through effects) to enemies with a title other than Marshland Outlaws.",
                Shadow = "Shadow: Raise your threat by X. X is the amount of damage dealt by this attack.",
                EncounterSet = "Journey Along the Anduin Nightmare",
                AlternateEncounterSet = "Journey Down the Anduin Nightmare",
                Quantity = 2,
                Number = 2,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card()
            {
                Title = "Anduin Troll Spawn",
                ImageType = ImageType.Jpg,
                Id = "F06B0F8E-7587-4C4D-9A7B-D0809C83C4C1",
                CardType = CardType.Enemy,
                EngagementCost = 26,
                Threat = 2,
                Attack = 4,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Troll." },
                Text = 
@"If there is no Hill Troll in play, Anduin Troll Spawn gains surge.

Forced: At the beginning of the combat phase, Anduin Troll Spawn engages a player engaged with a Hill Troll.",
                EncounterSet = "Journey Along the Anduin Nightmare",
                AlternateEncounterSet = "Journey Down the Anduin Nightmare",
                Quantity = 3,
                Number = 3,
                Artist = Artist.Chun_Lo
            });
            Cards.Add(new Card()
            {
                Title = "Brown Water Rats",
                ImageType = ImageType.Jpg,
                Id = "AA404B97-5CED-4A8C-953E-B8D4EA694A68",
                CardType = CardType.Enemy,
                EngagementCost = 1,
                Threat = 1,
                Attack = 1,
                Defense = 1,
                HitPoints = byte.MaxValue,
                Traits = new List<string> { "Creature.", "Rat." },
                Text = "Brown Water Rats cannot be damaged.\r\nForced: If the players are on stage 3 and all remaining enemies have the printed Rat trait, discard Brown Water Rats from play.",
                Shadow = "Shadow: Attacking enemy cannot be damaged this round.",
                EncounterSet = "Journey Along the Anduin Nightmare",
                AlternateEncounterSet = "Journey Down the Anduin Nightmare",
                Quantity = 3,
                Number = 4,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card()
            {
                Title = "A Flooded Ford",
                ImageType = ImageType.Jpg,
                Id = "F5DA8E4F-B12C-4BF0-A261-EBD642F32EE9",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 6,
                Traits = new List<string> { "Riverland." },
                Text = "Each card revealed by the encounter deck gains doomed X. X is the number of progress tokens on this card.",
                Shadow = "Shadow: If this attack is undefended, put A Flooded Ford into the staging area with 1 progress token on it.",
                EncounterSet = "Journey Along the Anduin Nightmare",
                AlternateEncounterSet = "Journey Down the Anduin Nightmare",
                Quantity = 1,
                Number = 5,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new Card()
            {
                Title = "Gladden Marshlands",
                ImageType = ImageType.Jpg,
                Id = "96EE48F9-0C53-474D-A76C-EE7DC09D160B",
                CardType = CardType.Location,
                Threat = 10,
                QuestPoints = 10,
                Traits = new List<string> { "Marshland." },
                Text = "Action: Deal 1 damage to a hero you control to reduce Gladden Marshlands Threat by 1 until the end of the phase. Any player may trigger this effect.",
                Shadow = "Shadow: Each enemy engaged with the defender player gets +1 Attack until the end of the phase. (+2 Attack instead if this attack is undefended.)",
                EncounterSet = "Journey Along the Anduin Nightmare",
                AlternateEncounterSet = "Journey Down the Anduin Nightmare",
                Quantity = 3,
                Number = 6,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new Card()
            {
                Title = "Pursuit on the Shore",
                ImageType = ImageType.Jpg,
                Id = "E721FF49-E1B1-4728-970F-BC1F9834461E",
                CardType = CardType.Treachery,
                Text = "When Revealed: Search the victory display and encounter discard pile for the enemy with the most hit points. Return that enemy to the staging area. If no enemy is returned by this effect, Pursuit on the Shore gains surge. (Cannot be canceled.)",
                EncounterSet = "Journey Along the Anduin Nightmare",
                AlternateEncounterSet = "Journey Down the Anduin Nightmare",
                Quantity = 2,
                Number = 7,
                Artist = Artist.Allison_Theus
            });
            Cards.Add(new Card()
            {
                Title = "Troll Attack",
                ImageType = ImageType.Jpg,
                Id = "0969CB94-D988-4F1C-A2C0-C1779D774064",
                CardType = CardType.Treachery,
                Text = "When Revealed: All engaged Troll enemies attack. If no Troll enemies are engaged, Troll Attack gains surge.",
                Shadow = "Shadow: If attacking enemy is a Troll, resolve this attack against each player. (Attack is undefended against each player not engaged with this enemy.)",
                EncounterSet = "Journey Along the Anduin Nightmare",
                AlternateEncounterSet = "Journey Down the Anduin Nightmare",
                Quantity = 2,
                Number = 8,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card()
            {
                Title = "Smoking Blood",
                ImageType = ImageType.Jpg,
                Id = "D6E77113-ABF9-4E04-B118-2A3716FE7AA2",
                CardType = CardType.Treachery,
                Text = "When Revealed: Remove all damage from all enemies. Then, each player raises his threat by the amount of just removed from his engaged enemies. If no damage is removed by this effect, Smoking Blood gains surge.",
                Shadow = "Shadow: Move all damage on this enemy to the defending character. (If undefended, move the damage to the hero damaged by this attack.)",
                EncounterSet = "Journey Along the Anduin Nightmare",
                AlternateEncounterSet = "Journey Down the Anduin Nightmare",
                Quantity = 2,
                Number = 9,
                Artist = Artist.Magali_Villeneuve
            });
        }
    }
}