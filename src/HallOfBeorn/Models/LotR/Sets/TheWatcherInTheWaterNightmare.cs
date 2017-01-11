using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheWatcherInTheWaterNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Watcher in the Water Nightmare";
            Abbreviation = "TWitWN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2055;

            Cards.Add(new LotRCard()
            {
                Title = "The Watcher in the Water Nightmare",
                Id = "F0B86657-B29E-4428-BD3D-7111E78A8B3A",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing in Nightmare mode.

While Doors of Durin is in play, The Watcher cannot be engaged.

Forced: When a Tentacle enemy is destroyed, deal 1 damage to The Watcher if it is in play.

The players cannot win the game unless both Doors of Durin and The Watcher are in the victory display.",
                FlavorText = "\"Something has crept, or has been driven out of dark waters under the mountains. There are older and fouler things than Orcs in the deep places of the world.\"\r\n-Gandalf, Lord of the Rings",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Watcher in the Water scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x The Watcher
2x Makeshift Passage
4x Black Uruks
3x Mountain Warg
2x Warg Lair

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Watcher in the Water encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",
                EncounterSet = "The Watcher in the Water Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Watcher",
                IsUnique = true,
                Id = "38396B24-B249-4A91-A458-1008FF0F0B48",
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 4,
                Attack = 7,
                Defense = 7,
                HitPoints = 21,
                Traits = new List<string> { "Creature.", "Tentacle." },
                Text = 
@"While The Watcher is in the staging area, it cannot be damaged by player card effects.

If The Watcher is in the staging area at the end of the combat phase, each player must deal 3 damage to 1 character he controls.",
                VictoryPoints = 3,
                EncounterSet = "The Watcher in the Water Nightmare",
                Quantity = 1,
                CardNumber = 2,
                Artist = Artist.Lukasz_Jaskolski
            });
            Cards.Add(new LotRCard()
            {
                Title = "Writhing Tentacle",
                Id = "08482A88-5C28-42A4-B21A-C603E2835F75",
                CardType = CardType.Enemy,
                EngagementCost = 46,
                Threat = 4,
                Attack = 4,
                Defense = 0,
                HitPoints = 3,
                Traits = new List<string> { "Tentacle." },
                Text = "Forced: When Writing Tentacle engages a player, discard the top card of the encounter deck. If that card has a shadow effect or is a Tentacle enemy, Writhing Tentacle makes an immediate attack, then attaches to the defending character as a Tentacle attachment with the text: \"Attached character cannot commit to the quest.\"",
                EncounterSet = "The Watcher in the Water Nightmare",
                Quantity = 3,
                CardNumber = 3,
                Artist = Artist.Lukasz_Jaskolski
            });
            Cards.Add(new LotRCard()
            {
                Title = "Choking Tentacle",
                Id = "4CF9E883-D264-495A-B57A-15B8B8995505",
                CardType = CardType.Enemy,
                EngagementCost = 10,
                Threat = 2,
                Attack = 5,
                Defense = 1,
                HitPoints = 4,
                Traits = new List<string> { "Tentacle." },
                Text = "Forced: After resolving an attack made by Choking Tentacle, discard the top card of the encounter deck. If that card has a shadow effect or is a Tentacle enemy, attach Choking Tentacle to a character the defending player controls as a Tentacle attachment with the text: \"Forced: After attached character readies. deal it 1 damage.\"",
                EncounterSet = "The Watcher in the Water Nightmare",
                Quantity = 4,
                CardNumber = 4,
                Artist = Artist.Jon_Bosco
            });
            Cards.Add(new LotRCard()
            {
                Title = "Banks of Sirannon",
                Id = "149AC0A6-D778-4A5E-9F6C-CE9CF91CE15F",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Mountain.", "Swamp." },
                Text = "While Banks of Sirannon is in the staging area, each Tentacle enemy gets +2 Defense.",
                Shadow = "Shadow: For each point of damage dealt by this attack, the defending player must discard a random card from his hand.",
                EncounterSet = "The Watcher in the Water Nightmare",
                Quantity = 3,
                CardNumber = 5,
                Artist = Artist.Rick_Price
            });
            Cards.Add(new LotRCard()
            {
                Title = "Hideous Depths",
                Id = "ED5D88D2-9559-4CF5-8BA5-562B383062F1",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 5,
                Traits = new List<string> { "Swamp." },
                Text = 
@"Forced: After a player looks at one or more cards in the encounter deck, shuffle the encounter deck.

Travel: Reveal the topmost Tentacle enemy in the encounter discard pile to travel here.",                
                EncounterSet = "The Watcher in the Water Nightmare",
                Quantity = 3,
                CardNumber = 6,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new LotRCard()
            {
                Title = "Pulled Under",
                Id = "B4E0019A-44E3-411C-8C8C-2812C62C41D8",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Tentacle." },
                Text = "When Revealed: Deal 3 damage to each character with a Tentacle attachment. If no characters were damaged by this effect, Pulled Under gains surge.",
                Shadow = "Shadow: If the defending character has a Tentacle attachment, discard that character.",
                EncounterSet = "The Watcher in the Water Nightmare",
                Quantity = 2,
                CardNumber = 7,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new LotRCard()
            {
                Title = "Rippling From Beneath",
                Id = "BF528396-B36D-4326-B626-1DE41267EA8B",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Tentacle." },
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Shuffle X Tentacle enemies from the encounter discard pile into the encounter deck. Heal X damage from The Watcher, if it is in play. X is the number of players in the game.",
                FlavorText = "Twenty other arms came rippling out.\r\n-The Fellowship of the Ring",
                EncounterSet = "The Watcher in the Water Nightmare",
                Quantity = 3,
                CardNumber = 8,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
        }
    }
}