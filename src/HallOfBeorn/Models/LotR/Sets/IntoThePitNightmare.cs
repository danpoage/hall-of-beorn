using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class IntoThePitNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Into the Pit Nightmare";
            Abbreviation = "ItPN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2009;

            Cards.Add(new LotRCard()
            {
                Title = "Into the Pit Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                Id = "97E64088-69B6-4A71-87B5-7F11FBAD94E3",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Forced: After ~Cave Torch exhausts, place 1 damage token on this card. Then, if there are 5 or more damage tokens on this card, remove ~Cave Torch from the game.",
                FlavorText = "All about them as they lay hung the darkness, hollow and immense, and they were oppressed by the lonliness and vastness of the dolven halls and endlessly branching stairs and passages. -The Fellowship of the Ring",

                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Into the Pit scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x ~Goblin Patrol
2x Stairs of Náin
2x ~Goblin Follower
2x Crumbling Ruin
3x ~Cave In
2x Fouled Well
2x ~Goblin Tunnels
5x ~Goblin Swordsman

Add the new quest card in this Nightmare Deck to the normal quest deck, in stage order. Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Into the Pit encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",

                EncounterSet = "Into the Pit Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new LotRCard()
            {
                Title = "Goblin Ambush",
                ImageType = Models.ImageType.Jpg,
                HasSecondImage = true,
                Id = "F2F24396-EBA3-45D6-B7BD-01FAF787F13C",
                CardType = CardType.Quest,
                StageNumber = 2,
                QuestPoints = 254,
                IsVariableQuestPoints = true,
                Text = "When Revealed: The first player must search the encounter deck and discard pile for X Orc enemies and add them to the staging area, where X is 1 plus the number of players in the game. One of these choices must be Patrol Sentry and one must be Patrol Leader, if able.",
                FlavorText = "You hear the sounds of many scampering feet. As you move closer to investiage, you find your party set upon on all sides by a patrol of Orcs!",
                OppositeText = 
@"X is 1 plus the number of players in the game.

Forced: After an enemy is defeated, place 1 progress on this stage.

Progress cannot be placed on ~Goblin Ambush expect by the above effect.",
                EncounterSet = "Into the Pit Nightmare",
                Quantity = 1,
                CardNumber = 2,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new LotRCard()
            {
                Title = "Patrol Sentry",
                ImageType = Models.ImageType.Jpg,
                Id = "0BDB88B6-B3D2-4C7D-9498-B3A3B8A4DA6E",
                CardType = CardType.Enemy,
                EngagementCost = 20,
                Threat = 1,
                Attack = 4,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Goblin.", "Orc." },
                Text = "Forced: After Cave Torch exhausts, Patrol Sentry makes an immediate attack against the engaged player, if able.",
                Shadow = "Shadow: Add Patrol Sentry to the staging area.",
                EncounterSet = "Into the Pit Nightmare",
                Quantity = 4,
                CardNumber = 3,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new LotRCard()
            {
                Title = "Goblin Lurker",
                ImageType = Models.ImageType.Jpg,
                Id = "31A590D5-B68B-4F6B-96AE-E2042CA1B0A0",
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 3,
                Attack = 2,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Goblin.", "Orc." },
                Text = "Cannot be optionally engaged.\r\n\r\nIf the active location is a Dark location, Goblin Lurker gets +3 Attack and -40 engagement cost.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if the active location is a Dark location.)",
                EncounterSet = "Into the Pit Nightmare",
                Quantity = 3,
                CardNumber = 4,
                Artist = Artist.Piya_Wannachaiwong
            });
            Cards.Add(new LotRCard()
            {
                Title = "Shadow Dweller",
                ImageType = Models.ImageType.Jpg,
                Id = "19EA237D-1722-4086-A72A-3795AEB5E651",
                CardType = CardType.Enemy,
                EngagementCost = 0,
                Threat = 1,
                Attack = 7,
                Defense = 7,
                HitPoints = 8,
                Traits = new List<string> { "Creature." },
                Keywords = new List<string> { "Surge." },
                Text = "Shadow Dweller does not make engagement checks while Cave Torch is in play.",
                Shadow = "Shadow: Shuffle Shadow Dweller back into the encounter deck.",
                EncounterSet = "Into the Pit Nightmare",
                Quantity = 2,
                CardNumber = 5,
                Artist = Artist.Mark_Bulahao
            });
            Cards.Add(new LotRCard()
            {
                Title = "Twisting Shadows",
                ImageType = Models.ImageType.Jpg,
                Id = "580CB1FA-38F7-4A24-9007-9F45BDE823DA",
                CardType = CardType.Location,
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = 254,
                IsVariableQuestPoints = true,
                Traits = new List<string> { "Underground.", "Dark." },
                Text = "X is the number of Dark locations in play.\r\n\r\nWhen Revealed: Remove all progress from each Dark location in play.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each Dark location in play.",
                EncounterSet = "Into the Pit Nightmare",
                Quantity = 3,
                CardNumber = 6,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                Title = "Narrow Fissure",
                ImageType = Models.ImageType.Jpg,
                Id = "291F486B-DC64-4AAE-B479-F7730786E2EA",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 1,
                Traits = new List<string> { "Underground.", "Hazard." },
                Keywords = new List<string> { "Doomed 1." },
                Text = "Each Dark location in play gets +2 quest points.\r\n\r\nWhile Cave Torch is ready, progress cannot be placed on Narrow Fissure.",
                FlavorText = "There were fissures and chasms in the walls...\r\n-The Fellowship of the Ring",
                EncounterSet = "Into the Pit Nightmare",
                Quantity = 3,
                CardNumber = 7,
                Artist = Artist.Katy_Grierson
            });
            Cards.Add(new LotRCard()
            {
                Title = "Shadow-fall",
                ImageType = ImageType.Jpg,
                Id = "58254459-502F-4C22-B1CD-BA3FA15D4C6B",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Attach to a non-Dark location in play. (Counts as a Condition attachment with the text: \"Attached location gains the Dark trait and gets +3 quest points.\")",
                Shadow = "Shadow: Attacking enemy gets +3 Defense this phase.",
                EncounterSet = "Into the Pit Nightmare",
                Quantity = 3,
                CardNumber = 8,
                Artist = Artist.Anthony_Feliciano
            });
        }
    }
}