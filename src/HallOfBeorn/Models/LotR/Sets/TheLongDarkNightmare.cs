using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheLongDarkNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Long Dark Nightmare";
            Abbreviation = "TLDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2056;

            Cards.Add(new LotRCard()
            {
                Title = "The Long Dark Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                Id = "A4144835-46A7-460A-8D58-CC1C25D973ED",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Durin's Greaves gains surge.

Lost: The first player must choose and discard an ally in play.",
                FlavorText = 
@"The world is grey, the mountains old,
The forge's fire is ashen cold
No harp is wrung, no hammer falls:
The darkness dwells in Durin's halls
The shadow lies upon his tomb
In Moria, in Khazad-dûm
-Gimli, The Fellowship of the Ring",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Long ~Dark scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

4x ~Goblin Follower
1x Branching Paths
3x Burning Low
2x Stray ~Goblin
2x Chance Encounter
2x The Mountains' Roots
1x Abandoned ~Mine
2x Fatigue
4x ~Goblin Sneak
3x Rock Adder

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Long ~Dark encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",

                EncounterSet = "The Long Dark Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new LotRCard()
            {
                Title = "Goblin Stalker",
                Id = "3E3EBBD8-C3B2-4745-98BE-F329F68AB7D1",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Enemy,
                EngagementCost = 28,
                Threat = 3,
                Attack = 2,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Goblin.", "Orc." },
                Text = 
@"Forced: When ~Goblin Stalker attacks, deal it 1 additional shadow card.

Forced: When ~Goblin Stalker is dealt a shadow card with 'PASS' printed in its text box, it gets +2 Attack until the end of the phase.",
                PassValue = true,
                EncounterSet = "The Long Dark Nightmare",
                Quantity = 4,
                CardNumber = 2,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new LotRCard()
            {
                Title = "Trapdoor Spider",
                Id = "D50CA363-DA45-4AEB-8DAC-160A23158B5D",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Enemy,
                EngagementCost = 42,
                Threat = 4,
                Attack = 5,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Creature.", "Spider." },
                Text = 
@"Forced: If Trapdoor ~Spider damage a character, discard that character from play.

Lost: Trapdoor ~Spider engages the last player and makes an immediate attack.",
                PassValue = true,
                EncounterSet = "The Long Dark Nightmare",
                Quantity = 3,
                CardNumber = 3,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new LotRCard()
            {
                Title = "Sentinel of the Deep",
                Id = "C9674FC1-259A-48DE-947A-2D04B34BFFE4",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Enemy,
                EngagementCost = 12,
                Threat = 2,
                Attack = 4,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Orc.", "Uruk." },
                Text = "While Sentinel of the Deep is engaged with a player, that player cannot draw cards from card effects.",
                Shadow = "Shadow: Defending player must choose and trigger 1 'Lost:' effect in play.",
                EncounterSet = "The Long Dark Nightmare",
                Quantity = 2,
                CardNumber = 4,
                Artist = Artist.Lukasz_Jaskolski
            });
            Cards.Add(new LotRCard()
            {
                Title = "Eastern Mines",
                Id = "FF85DD28-BAF1-4447-A088-C12B2C395778",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Location,
                Threat = 5,
                QuestPoints = 4,
                Traits = new List<string> { "Underground." },
                Text = "Travel: The first player must make a locate test to travel here. If this test is failed, return Eastern Mines to the staging area and trigger all \"Lost:\" effects in play.",
                Shadow = "Shadow: Defending player must choose and trigger 1 \"Lost:\" effect in play.",
                EncounterSet = "The Long Dark Nightmare",
                Quantity = 2,
                CardNumber = 5,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new LotRCard()
            {
                Title = "Bottomless Chasm",
                Id = "FC9A11F8-7CCA-45AE-A726-B6A8AFE1F82B",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 6,
                Traits = new List<string> { "Underground.", "Dark." },
                Text = "For each point of progress that is placed on Bottomless Chasm, the players must choose and discard 1 card from a player's hand, if able",
                Shadow = "Shadow: If this attack destroys a character, the defending player discards all cards in his hand.",
                EncounterSet = "The Long Dark Nightmare",
                Quantity = 3,
                CardNumber = 6,
                Artist = Artist.Jake_Bullock
            });
            Cards.Add(new LotRCard()
            {
                Title = "Dreadful Deep",
                Id = "73E7606B-B5E7-4AAC-BC71-2D4576E24A3C",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Treachery,
                Text = "When Revealed: Starting with the first player, each player must choose and trigger a different \"Lost:\" effect in play.",
                Shadow = "Shadow: Make a locate test. If this test is failed, return attacking enemy to the staging area after this attack and trigger all \"Lost:\" effects in play.",
                EncounterSet = "The Long Dark Nightmare",
                Quantity = 3,
                CardNumber = 7,
                Artist = Artist.Brian_Valenzuela
            });
            Cards.Add(new LotRCard()
            {
                Title = "Lost and Helpless",
                Id = "46EB8929-9363-49FE-A509-578AF5D52D7A",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Attach to a hero. (Counts as a Condition attachment with the text: \"Lost: Discard attached hero.\")",
                Shadow = "Shadow: If you have no cards in your hand, discard defending character from play.",
                EncounterSet = "The Long Dark Nightmare",
                Quantity = 2,
                CardNumber = 8,
                Artist = Artist.Ilich_Henriquez
            });
        }
    }
}