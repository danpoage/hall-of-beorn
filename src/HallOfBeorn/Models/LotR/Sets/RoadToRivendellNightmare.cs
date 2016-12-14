using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class RoadToRivendellNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Road to Rivendell Nightmare";
            Abbreviation = "RtRN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2054;

            Cards.Add(new LotRCard()
            {
                Title = "Road to Rivendell Nightmare",
                Id = "1770122B-7F4B-424A-A714-A23DB128E355",
                CardType = Models.LotR.CardType.Nightmare_Setup,
                HasSecondImage = true,
                Text =
@"You are playing in Nightmare mode.

Forced: When an enemy with the ambush keyword engages a player during the quest phase, it contributes its Threat to the total Threat in the staging area until the end of the phase.",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Road to Rivendell scenario.

Remove the following cards, in the specified quantities, from the standard encounter and quest deck:

1x Orc Outpost (quest stage 2)
2x Ruined Road
2x Barren Hills
1x Goblin Taskmaster
4x Black Uruks
3x Mountain Warg
3x Bitter Wind
2x Warg Lair
5x Goblin Spearman
2x Goblin Archer
2x Plundered Armoury

Add the new quest card in this Nightmare Deck to the normal quest deck, in stage order. Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Road to Rivendell encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",
                EncounterSet = "Road to Rivendell Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Oleg_Saakyan
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ambush in the Night",
                Id = "2EC4C17D-CB7C-4B1A-94AB-A755644577C5",
                HasSecondImage = true,
                CardType = CardType.Quest,
                StageNumber = 2,
                QuestPoints = 12,
                Text =
@"When Revealed: Search the encounter deck, discard pile and victory display for Goblin Gate and add it to the staging area, if able. Shuffle the encounter discard pile into the encounter deck. Discard cards from the top of the encounter deck until X enemies have been discarded, where X is the number of players in the game. Reveal all enemies discarded by this effect.",
                OppositeText =
@"When Revealed: The first player loses control of Arwen Undómiel and attaches her to Goblin Gate (she is now guarded by Goblin Gate). While she is guarded, the first player cannot gain control of Arwen Undómiel.

Goblin Gate gets +1 quest point for each enemy engaged with a player.

Progress cannot be placed on this stage unless the players control Arwen Undómiel.",
                EncounterSet = "Road to Rivendell Nightmare",
                Quantity = 1,
                CardNumber = 2,
                Artist = Artist.Oleg_Saakyan
            });
            Cards.Add(new LotRCard()
            {
                Title = "Uruk Elf-stalker",
                Id = "4A8E8DDA-F44E-4DD5-AACE-3D4F7C4D22EA",
                CardType = CardType.Enemy,
                EngagementCost = 5,
                Threat = 3,
                Attack = 5,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Uruk.", "Orc." },
                Keywords = new List<string> { "Ambush." },
                Text = "Forced: When Uruk Elf-stalker attacks and destroys a character, deal 1 damage to Arwen Undómiel.",
                Shadow = "Shadow: Attacking enemy gets +2 Attack.",
                EncounterSet = "Road to Rivendell Nightmare",
                Quantity = 3,
                CardNumber = 3,
                Artist = Artist.Anthony_Devine
            });
            Cards.Add(new LotRCard()
            {
                Title = "Goblin Trapper",
                Id = "93C87E29-E9DF-4596-A65D-D776CCC8F4B0",
                CardType = CardType.Enemy,
                EngagementCost = 30,
                Threat = 3,
                Attack = 3,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Goblin.", "Orc." },
                Keywords = new List<string> { "Ambush." },
                Text = "Forced: After Goblin Trapper engages a player, that player must exhaust a character he controls.",
                Shadow = "Shadow: Add Goblin Trapper to the staging area.",
                EncounterSet = "Road to Rivendell Nightmare",
                Quantity = 3,
                CardNumber = 4,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new LotRCard()
            {
                Title = "Raiding Party",
                Id = "EC66FDED-E287-4FE7-B536-B8A2CA51F767",
                CardType = CardType.Enemy,
                EngagementCost = 34,
                Threat = 2,
                Attack = 5,
                Defense = 1,
                HitPoints = 7,
                Traits = new List<string> { "Mountain.", "Orc." },
                Keywords = new List<string> { "Ambush." },
                Text = "Forced: After Raiding Party engages a player, each player discards the top card of the encounter deck, starting with the first player. Each player who discards an enemy with the ambush keyword must make an engagement check against that enemy.",
                EncounterSet = "Road to Rivendell Nightmare",
                Quantity = 2,
                CardNumber = 5,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new LotRCard()
            {
                Title = "Vicious Trackers",
                Id = "45F25FBC-4722-4C8E-9F06-F1D7E4AB27FA",
                CardType = CardType.Enemy,
                EngagementCost = 16,
                Threat = 1,
                Attack = 3,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Goblin.", "Orc." },
                Keywords = new List<string> { "Surge." },
                Text = "While Vicious Tracker is engaged with a player, that player is considered to have +20 threat for purposes of engagement checks only.",
                EncounterSet = "Road to Rivendell Nightmare",
                Quantity = 2,
                CardNumber = 6,
                Artist = Artist.Lukasz_Jaskolski
            });
            Cards.Add(new LotRCard()
            {
                Title = "Treacherous Bluffs",
                Id = "E9C28758-7EB8-4958-B324-2024D90B7DC6",
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 7,
                Traits = new List<string> { "Hills." },
                Text = "Forced: When an engaged enemy with the ambush keyword engages a player, Treacherous Bluffs gets +2 Threat until the end of the phase.",
                Shadow = "Shadow: Excess damage dealt by this attack must be assigned to Arwen Undómiel.",
                EncounterSet = "Road to Rivendell Nightmare",
                Quantity = 3,
                CardNumber = 7,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new LotRCard()
            {
                Title = "Concealed Woods",
                Id = "E9DBE592-324F-4B1D-8FC3-F1B0A685AF02",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 4,
                Traits = new List<string> { "Forest." },
                Text = "While Concealed Woods is the active location, the first enemy with the ambush keyword revealed from the encounter deck each round gains surge.",
                Shadow = "Shadow: Attacking enemy gets +2 Attack if engaged with the first player.",
                EncounterSet = "Road to Rivendell Nightmare",
                Quantity = 3,
                CardNumber = 8,
                Artist = Artist.Jake_Bullock
            });
            Cards.Add(new LotRCard()
            {
                Title = "Tumultuous Assault",
                Id = "64653BB9-7682-4EAD-9892-29E305968F89",
                CardType = CardType.Treachery,
                Text = "When Revealed: Return each engaged enemy with the ambush keyword to the staging area. Each player makes engagement checks against each enemy in the staging area, as if it were the encounter phase. If there are no enemies with the ambush keyword in play, Tumultuous Assault gains surge.",
                EncounterSet = "Road to Rivendell Nightmare",
                Quantity = 2,
                CardNumber = 9,
                Artist = Artist.Mark_Behm
            });
        }
    }
}