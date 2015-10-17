using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class ShadowAndFlameNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Shadow and Flame Nightmare";
            Abbreviation = "SaFN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2058;

            Cards.Add(new Card()
            {
                Title = "Shadow and Flame Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                Id = "9331CC57-75DA-4FE0-9961-179232C03F02",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Setup: Shuffle the 10 encounter cards with the Attack trait into a separate 'Balrog deck.'

When Durin's Bane would be dealt a shadow card, deal it from the ~Balrog deck instead of the encounter deck. ~Shadow cards dealt from the ~Balrog deck are discarded into a separate ~Balrog discard pile.

At the beginning of each combat phase (or if the ~Balrog deck runs out of cards), shuffle the ~Balrog discard pile back into the ~Balrog deck.",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for Foundations of Stone scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x ~Goblin ~Scout
2x ~Goblin Tunnels
3x Stray ~Goblin
3x The Mountains' Roots
3x Ranging ~Goblin
1x Fiery Sword
1x Many Thonged Whip

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard ~Shadow and ~Flame encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.

Play Tip: This scenario contains 10 treachery cards with the Attack trait that have only a 'shadow' effect, and no 'when revealed' effect. These cards are never revealed from the encounter deck and are only ever dealt as shadow cards to Durin's Bane.",

                EncounterSet = "Shadow and Flame Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Anthony_Feliciano
                /*
                UpdateScenarioCards = (groups) =>
                {
                    foreach (var group in groups)
                    {
                        var scenario = group.Scenarios.Where(x => x.Title == "Shadow and Flame").FirstOrDefault();
                        if (scenario == null)
                            continue;

                        foreach (var card in scenario.ScenarioCards.Where(x => !x.EncounterSet.EndsWith(" Nightmare")))
                        {
                            switch (card.Title)
                            {
                                case "Goblin Scout":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Goblin Tunnels":
                                    card.NightmareQuantity -= 2;
                                    break;
                                case "Stray Goblin":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "The Mountains' Roots":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Ranging Goblin":
                                    card.NightmareQuantity -= 3;
                                    break;
                                case "Fiery Sword":
                                    card.NightmareQuantity -= 1;
                                    break;
                                case "Many Thonged Whip":
                                    card.NightmareQuantity -= 1;
                                    break;
                            }
                        }
                    }

                    return true;
                }*/
            });
            Cards.Add(new Card()
            {
                Title = "Terrible Strength",
                Id = "F0B82FA2-95E0-476A-84DC-5690632ED167",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Treachery,
                Traits = new List<string> { "Attack." },
                Shadow = "Shadow: For each excess point of combat damage dealt by this attack (damage that is dealt beyond the remaining hit points of the character damaged by this attack) you must damage another character you control. Exhaust all characters damaged by this effect.",
                EncounterSet = "Shadow and Flame Nightmare",
                Quantity = 2,
                Number = 2,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new Card()
            {
                Title = "The Dark Fire",
                Id = "C51679AE-3BF7-4B3A-81C4-EC1E854E4599",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Treachery,
                Traits = new List<string> { "Attack." },
                Shadow = "Shadow: For each point of damage dealt by this attack, heal 1 damage from Durin's Bane.",
                FlavorText = "The flames roared up to greet it, and wreathed about it; and a black smoke swirled in the air. -The Fellowship of the Ring",
                EncounterSet = "Shadow and Flame Nightmare",
                Quantity = 2,
                Number = 3,
                Artist = Artist.Anthony_Feliciano
            });
            Cards.Add(new Card()
            {
                Title = "Blazing Grip",
                Id = "886F5736-146D-42E0-9C1A-47BCE7EC0AAC",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Treachery,
                Traits = new List<string> { "Attack." },
                Shadow = "Shadow: Discard all cards attached to the defending character and deal it 1 damage. Cannot be canceled.",
                FlavorText = "Fire came from its nostrils. -The Fellowship of the Ring",
                EncounterSet = "Shadow and Flame Nightmare",
                Quantity = 2,
                Number = 4,
                Artist = Artist.Jon_Bosco
            });
            Cards.Add(new Card()
            {
                Title = "Morgoth's Bidding",
                Id = "62CDF7FE-B451-4FCB-A30C-F6C917E0168A",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Treachery,
                Traits = new List<string> { "Attack." },
                Shadow = "Shadow: If this attack destroys a character, Durin's Bane makes an additional attack against the defending player after this one.",
                FlavorText = "From out of the shadow a red sword leaped flaming. -The Fellowship of the Ring",
                EncounterSet = "Shadow and Flame Nightmare",
                Quantity = 2,
                Number = 5,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Flame of Udûn",
                NormalizedTitle = "Flame of Udun",
                Id = "488E2850-8EE2-425C-9258-6AC3B493EE4F",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Treachery,
                Traits = new List<string> { "Attack." },
                Shadow = "Shadow: Deal Durin's Bane 3 additional shadow cards from the encounter deck (not the Balrog deck).",
                FlavorText = "The dark figure streaming with fire raced towards them. -The Fellowship of the Ring",
                EncounterSet = "Shadow and Flame Nightmare",
                Quantity = 2,
                Number = 6,
                Artist = Artist.Anthony_Feliciano
            });
            Cards.Add(new Card()
            {
                Title = "Servant of Flame",
                Id = "B95E40F4-DB1A-4D87-9E15-3C247AE77913",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Enemy,
                EngagementCost = 12,
                Threat = 3,
                Attack = 3,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Mordor.", "Orc.", "Uruk." },
                Text = "Forced: While Durin's Bane has no damage, Servant of Flame gets +2 Attack and +2 Defense.",
                Shadow = "Shadow: Search the encounter deck for a treachery card with the Shadow or Flame trait and reveal it, if able. Shuffle the encounter deck.",
                EncounterSet = "Shadow and Flame Nightmare",
                Quantity = 3,
                Number = 7,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new Card()
            {
                Title = "Captain of Mordor",
                Id = "1D4246FD-3712-44EF-AE50-E241F36B019A",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Enemy,
                EngagementCost = 42,
                Threat = 4,
                Attack = 4,
                Defense = 3,
                HitPoints = 7,
                Traits = new List<string> { "Mordor.", "Orc.", "Uruk." },
                Text = "Each enemy gets -20 engagement cost.",
                Shadow = "Shadow: If this attack destroys a character, attacking enemy cannot take damage this round.",
                FlavorText = "\"And some are large and evil: Black Uruks of Mordor.\" -Gandalf, The Fellowship of the Ring",
                EncounterSet = "Shadow and Flame Nightmare",
                Quantity = 2,
                Number = 8,
                Artist = Artist.Lukasz_Jaskolski
            });
            Cards.Add(new Card()
            {
                Title = "Fiery Depths",
                Id = "E21ECEE3-8A17-4BE6-BC07-A0A39E56022A",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Location,
                Threat = 5,
                QuestPoints = 2,
                Traits = new List<string> { "Underground." },
                Text = 
@"Progress cannot be placed on Fiery Depths while it is in the staging area.

Travel: Each player must move 1 damage from Durin's Bane to a hero to travel here.",
                FlavorText = "Out of it a fierce red light came, and now and again flames licked at the brink and curled about the bases of the columns. -The Fellowship of the Ring",
                EncounterSet = "Shadow and Flame Nightmare",
                Quantity = 2,
                Number = 9,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Crumbling Stairs",
                Id = "7178014D-828F-4BDF-A1F5-7B76396BE1A5",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 7,
                Traits = new List<string> { "Underground." },
                Text = "While Crumbling Stairs is in the staging area, event cards cost 1 additional matching resource to play from hand.",
                Shadow = "Shadow: If this attack destroys a character, the defending player must discard all event cards in his hand.",
                EncounterSet = "Shadow and Flame Nightmare",
                Quantity = 2,
                Number = 10,
                Artist = Artist.Alyn_Spiller
            });
        }
    }
}