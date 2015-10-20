using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class FoundationsOfStoneNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Foundations of Stone Nightmare";
            Abbreviation = "FoSN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2057;

            Cards.Add(new Card()
            {
                Title = "Foundations of Stone Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                Id = "42D3C22B-7DAA-4C93-A7EE-2AA5927E8304",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Forced: When stage 3b is revealed, discard all Mount and Artifact cards from play. Each player must also discard allies he controls until the total printed cost of allies he controls is 6 or less.",
                FlavorText = "\"Far, far below the deepest delving of the Dwarves, the world is gnawed by nameless things. Even Sauron knows them not.\"\r\n-Gandalf, The Two Towers",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for Foundations of Stone scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x ~Goblin ~Scout
2x ~Goblin Swordsman
1x ~Goblin Follower
3x Burning Low
1x Branching Paths
1x Many Roads
3x ~Cave In
3x Drowned Treasury
1x Mitril Lode
4x Moria Bats

During setup, players are instructed to set the Foundations of Stone encounter set aside, out of play. Shuffle the encounter cards in this Nightmare Deck with the Goblins of the Deep encounter set icon into the standard encounter deck. Then shuffle the encounter cards in this Nightmare Deck with the Foundations of Stone encounter set icon into the remainder of the set aside Foundations of Stone encounter set.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",

                EncounterSet = "Foundations of Stone Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Mithril Seeker",
                Id = "7B51A03B-2531-4BCA-85C0-3056B8BB8E2E",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Enemy,
                EngagementCost = 18,
                Threat = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Goblin.", "Orc." },
                Text = 
@"Mithril Seeker gets +1 Attack for each resource on it.

Forced: When Mithril Seeker attacks, move 1 resource from each of the defending player's heroes to Mithril Seeker.",
                FlavorText = "\"Of what they brought to light the Orcs have gathered nearly all, and given it in tribute to Sauron, who covets it.\"\r\n-Gandalf, The Fellowship of the Ring",
                EncounterSet = "Goblins of the Deep Nightmare",
                Quantity = 3,
                Number = 2,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new Card()
            {
                Title = "Giant Cave Centipede",
                Id = "F196C7C0-B375-4DF9-BBD1-961945D2CD5A",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Enemy,
                EngagementCost = 28,
                Threat = 3,
                Attack = 3,
                Defense = 5,
                HitPoints = 4,
                Traits = new List<string> { "Creature.", "Insect." },
                Text = 
@"When Revealed: Each player at this stage shuffles the card in his hand with the highest printed cost back into his deck.

Forced: At the end of the combat phase, if ~Giant Centipede is engaged with a player, that player chooses and adds it to a different player's staging area.",
                EncounterSet = "Goblins of the Deep Nightmare",
                Quantity = 2,
                Number = 3,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new Card()
            {
                Title = "Unspeakable Thing",
                Id = "D004426E-A967-4D47-AA80-58067833C531",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Enemy,
                EngagementCost = 15,
                Threat = 5,
                Attack = 0,
                IsVariableAttack = true,
                Defense = 5,
                HitPoints = 0,
                IsVariableHitPoints = true,
                Traits = new List<string> { "Nameless." },
                Text = 
@"Forced: When Unspeakable Thing enages a player or attacks a player, attach the top card of that player's deck to it.

X is the printed cost of all attached cards on this card. If there are no cards attached, X is 5.",
                EncounterSet = "Foundations of Stone Nightmare",
                Quantity = 3,
                Number = 4,
                Artist = Artist.Florian_Devos
            });
            Cards.Add(new Card()
            {
                Title = "Primeval Thing",
                Id = "93BC53CD-B8C6-4385-B80E-AD244AC73CA6",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Enemy,
                EngagementCost = 45,
                Threat = 6,
                Attack = 0,
                IsVariableAttack = true,
                Defense = 6,
                HitPoints = 0,
                IsVariableHitPoints = true,
                Traits = new List<string> { "Nameless." },
                Text = 
@"Forced: When Primeval Thing enters play, attach cards from the top of the first player's deck to it until the total printed cost of all attached cards is 6 or higher.

X is the printed cost of all attached cards on this card. If there are no cards attached, X is 6.",
                EncounterSet = "Foundations of Stone Nightmare",
                Quantity = 2,
                Number = 5,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Nest of Horrors",
                Id = "E4C39446-C358-40B4-8487-BA73FD9BDDF6",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 4,
                Traits = new List<string> { "Underground.", "Dark." },
                Text = "While Nest of Horrors is in the staging area, it gains: \"Forced: When one or more cards are attached to a Nameless enemy from the top of a player's deck, attach an additional card from the top of that player's deck.\"\r\nTravel: Each player at this stage discards the top card of the encounter deck to travel here. Reveal each Nameless enemy discarded by this effect.",
                EncounterSet = "Foundations of Stone Nightmare",
                Quantity = 3,
                Number = 6,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Shivering River",
                Id = "2CA05E2A-9775-40BC-A7D6-16C0B746A75C",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 7,
                Traits = new List<string> { "Underground.", "River." },
                Text = "While Shivering ~River is in the staging area, it contributes its Threat to the total Threat in each other player's staging area.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. (+3 Attack instead if there is more than one player at this staging area.)",
                EncounterSet = "Foundations of Stone Nightmare",
                Quantity = 3,
                Number = 7,
                Artist = Artist.Jake_Bullock
            });
            Cards.Add(new Card()
            {
                Title = "Chill of the Roots",
                Id = "A374694E-1C4F-4A4D-9510-7980D4912D8D",
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Treachery,
                Text = "When Revealed: Each player must either discard his hand, or raise his threat by the number of cards in his hand. If no cards were discarded by this effect, Chill of the Roots gains surge.",
                Shadow = "Shadow: If attacking enemy is Nameless, attach the top card of the defending player's deck to it.",
                EncounterSet = "Foundations of Stone Nightmare",
                Quantity = 3,
                Number = 8,
                Artist = Artist.Dleoblack
            });
        }
    }
}