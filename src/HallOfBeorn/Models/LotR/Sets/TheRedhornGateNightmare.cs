using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheRedhornGateNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Redhorn Gate Nightmare";
            Abbreviation = "TRGN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2053;

            Cards.Add(new LotRCard()
            {
                Title = "The Redhorn Gate Nightmare",
                Id = "F8597C3E-9FCA-4ED4-9326-AD1A383605DA",
                CardType = Models.LotR.CardType.Nightmare_Setup,
                HasSecondImage = true,
                Text = 
@"You are playing in Nightmare mode.

Setup: Remove all copies of Blinding Blizzard from the encounter deck and set them aside, out of play. During this game, player cards in the victory display do not count their victory points.

Forced: When stage 2b is revealed, shuffle each set aside copy of Blinding Blizzard into the encounter deck.",
                FlavorText = "A cold wind flowed down behind them, as they turned their backs on the Redhorn Gate, and stumbled wearily down the slope. Caradhras had defeated them.\r\n-The Fellowship of the Ring",
                OppositeText = 
@"Begin with the standard quest deck and encounter deck for The Redhorn Gate scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x Black Uruks
3x Mountain Warg
1x Knees of the Mountain
2x Turbulent Waters
2x Warg Lair
1x The Dimrill Stair
2x Fell Voices
2x Fallen Stones
3x Mountain Goblin

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Redhorn Gate encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",
                EncounterSet = "The Redhorn Gate Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new LotRCard()
            {
                Title = "Wolfpelt Goblin",
                Id = "5D83D480-CDC8-4F25-8E36-E1166DF88581",
                CardType = CardType.Enemy,
                EngagementCost = 20,
                Threat = 2,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Goblin.", "Orc.", "Snow." },
                Keywords = new List<string> { "Surge." },
                Text = "Forced: After engaging Wolfpelt Goblin, the engaged player must deal X damage to 1 character he controls, where X is the active location's remaining quest points. Then, remove 2 progress from the active location, if able.",
                EncounterSet = "The Redhorn Gate Nightmare",
                Quantity = 3,
                CardNumber = 2,
                Artist = Artist.Diego_Gisbert_Llorens
            });
            Cards.Add(new LotRCard()
            {
                Title = "Silvertine Marauder",
                Id = "726E6D3C-1479-4BB5-BF7D-8C877C971179",
                CardType = CardType.Enemy,
                EngagementCost = 28,
                Threat = 2,
                Attack = 3,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Orc." },
                Text = "While attacking, Silvertine Marauder gets +2 Attack if the defending character has less than 2 Willpower.",
                Shadow = "Shadow: Attacking enemy gets +2 Attack if the defending character has less than 2 Willpower.",
                EncounterSet = "The Redhorn Gate Nightmare",
                Quantity = 4,
                CardNumber = 3,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new LotRCard()
            {
                Title = "Snow-Giant",
                Id = "CAA9EE36-ABFA-4AE4-A059-9C5812761A8F",
                CardType = CardType.Enemy,
                EngagementCost = 42,
                Threat = 4,
                Attack = 6,
                Defense = 4,
                HitPoints = 10,
                Traits = new List<string> { "Giant.", "Snow." },
                Text = 
@"While Snow-Giant is in the staging area, it attacks the first player during the combat phase, as if it were engaged.

Forced: After Snow-Giant engages you, discard the ally you control with the highest Willpower.",
                VictoryPoints = 1,
                EncounterSet = "The Redhorn Gate Nightmare",
                Quantity = 3,
                CardNumber = 4,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new LotRCard()
            {
                Title = "Icy Cavern",
                Id = "47B84E97-41DB-4F98-B3CE-5F8690EECDC6",
                CardType = CardType.Location,
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = 6,
                Traits = new List<string> { "Mountain.", "Snow." },
                Text =
@"X is the number of Snow cards in the staging area.

Travel: Search the encounter deck and discard pile for 1 copy of Freezing Cold and reveal it to travel here. Shuffle the encounter deck.",
                Shadow = "Shadow: Defending character gets -1 Willpower. Deal the attacking enemy 1 additional shadow card.",
                EncounterSet = "The Redhorn Gate Nightmare",
                Quantity = 3,
                CardNumber = 5,
                Artist = Artist.Julian_Kok
            });
            Cards.Add(new LotRCard()
            {
                Title = "Frozen Silverlode",
                Id = "56F5BD69-1A03-4180-BF93-D06B1FF66209",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Mountain.", "River." },
                Text = "While Frozen Silverlode is in the staging area, characters cannot gain Willpower from player card effects.",
                Shadow = "Shadow: Defending character gets -1 Willpower. Deal the attacking enemy 1 additional shadow card.",
                FlavorText = "\"...and there the River Silverlode rises in its icy springs.\"\r\n-Gandalf, The Fellowship of the Ring",
                EncounterSet = "The Redhorn Gate Nightmare",
                Quantity = 3,
                CardNumber = 6,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new LotRCard()
            {
                Title = "Blinding Blizzard",
                Id = "20685464-DE05-4FC3-8318-A196627EAF0B",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Snow." },
                Text = 
@"While Blinding Blizzard is in play, heroes do not collect resources during the resource phase.

When Revealed: Add Blinding Blizzard to the staging area. Progress that would be placed on the current quest or on Snow locations are instead placed on Blinding Blizzard. When the 5th progress is placed on Blinding Blizzard, discard it.",
                EncounterSet = "The Redhorn Gate Nightmare",
                Quantity = 2,
                CardNumber = 7,
                Artist = Artist.Julian_Kok
            });
            Cards.Add(new LotRCard()
            {
                Title = "Caradhras the Cruel",
                Id = "5A25C393-5FA4-4BE7-9572-7451D7D841CB",
                CardType = CardType.Treachery,
                Text = "When Revealed: Return all Snow cards in the encounter discard pile to the top of the encounter deck, in random order. Reveal the top card of the encounter deck (reveal the top 2 cards instead if there are 3 or 4 players in the game).",
                FlavorText = "\"Caradhras has not forgiven us,\" he said. \"He has more snow yet to fling at us, if we go on.\"\r\n-Gimli, The Fellowship of the Ring",
                EncounterSet = "The Redhorn Gate Nightmare",
                Quantity = 2,
                CardNumber = 8,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
        }
    }
}