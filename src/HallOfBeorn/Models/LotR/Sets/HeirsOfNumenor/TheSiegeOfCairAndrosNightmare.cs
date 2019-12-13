using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.HeirsOfNumenor
{
    public class TheSiegeOfCairAndrosNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Siege of Cair Andros Nightmare";
            Abbreviation = "TSoCAN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2055;

            Cards.Add(new LotRCard()
            {
                Title = "The Siege of Cair Andros Nightmare",
                Id = "8974A088-4939-47A4-8133-55C037B03656",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Until the end of the game, player cards in the victory display do not contribute their victory points.",
                FlavorText = "\"Much must be risked in war,\" said Denethor. \"Cair Andros is manned and no more can be sent so far.\" -The Return of the King",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Siege of Cair Andros scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x Southron Mercenaries
2x Orc Arsonists
2x Orc Rabble
3x Orc Arbalesters
1x The Power of Mordor
2x Scourge of Mordor

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Siege of Cair Andros encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "The Siege of Cair Andros Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new LotRCard()
            {
                Title = "Southron Mounted Archer",
                Id = "30ADFB73-E80A-4E87-B094-BF872DEA2F29",
                CardType = CardType.Enemy,
                EngagementCost = 45,
                Threat = 3,
                Attack = 4,
                Defense = 2,
                HitPoints = 4,
                Text = "Archery 5.\r\nDamage from each round's achery total may be assigned to Battleground locations, as well as characters.",
                EncounterSet = "The Siege of Cair Andros Nightmare",
                CardNumber = 2,
                Quantity = 3,
                Artist = Artist.Dleoblack
            }.WithTraits("Harad.")
            .WithKeywords("Archery 5."));
            Cards.Add(new LotRCard()
            {
                Title = "Orc Saboteur",
                Id = "3034D622-673C-4520-BBCD-4F42D94239D4",
                CardType = CardType.Enemy,
                EngagementCost = 21,
                Threat = 2,
                Attack = 5,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Orc." },
                Text = "Damage dealt by Orc Saboteur's attacks must be dealt to a Battleground location in play, if able.",
                Shadow = "Shadow: If this attack destroys a character, deal 2 damage to a Battleground location in play.",
                EncounterSet = "The Siege of Cair Andros Nightmare",
                CardNumber = 3,
                Quantity = 3,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new LotRCard()
            {
                Title = "Orc Ravager",
                Id = "A1674F5C-F4E9-4FD4-A7BD-E8759826BE68",
                CardType = CardType.Enemy,
                EngagementCost = 30,
                Threat = 3,
                Attack = 3,
                Defense = 1,
                HitPoints = 4,
                Traits = new List<string> { "Orc." },
                Text = "Forced: When Orc Ravager is dealt a shadow card, it gets +2 Defense until the end of the phase.",
                Shadow = "Shadow: Exhaust a character you control. Deal attacking enemy another shadow card.",
                EncounterSet = "The Siege of Cair Andros Nightmare",
                CardNumber = 4,
                Quantity = 4,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new LotRCard()
            {
                Title = "Besieged Courtyard",
                Id = "EE512439-0738-40A0-B801-3B90C96E5883",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 5,
                Traits = new List<string> { "Cair Andros.", "Battleground." },
                Text = "If Besieged Courtyard has 5 or more damage, discard it and exhaust each ready character.",
                Shadow = "Shadow: Choose one: either attacking enemy makes an additional attack after this one, or deal 10 damage to a Battleground location.",
                EncounterSet = "The Siege of Cair Andros Nightmare",
                CardNumber = 5,
                Quantity = 2,
                Artist = Artist.Wibben
            });
            Cards.Add(new LotRCard()
            {
                Title = "Walls of Cair Andros",
                Id = "4B19CBB4-17BA-415C-834C-81117DD9F2DE",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 4,
                Traits = new List<string> { "Cair Andros.", "Battleground." },
                Text = "If Walls of Cair Andros has 4 or more damage, discard it and each player must assign 4 damage amoung characters he controls.",
                Shadow = "Shadow: Attacking enemy gets +X, where X is the amount of damage on the active location.",
                EncounterSet = "The Siege of Cair Andros Nightmare",
                CardNumber = 6,
                Quantity = 2,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard()
            {
                Title = "Anduin Wharf",
                Id = "80CBD292-6400-422C-A63B-072728DE543E",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 6,
                Traits = new List<string> { "Cair Andros.", "Battleground.", "Riverland." },
                Text = "If Anduin Wharf has 6 or more damage, discard it and reveal 2 cards from the top of the encounter deck.\r\nWhile Anduin Wharf is the active location, allies cost 1 additional matching resource to play from hand.",
                EncounterSet = "The Siege of Cair Andros Nightmare",
                CardNumber = 7,
                Quantity = 2,
                Artist = Artist.Wibben
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ruin and Wroth",
                Id = "B19E076C-8A64-4D68-83B8-68480ACBE943",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Doomed 2." },
                Text = "Doomed 2.\r\nWhen Revealed: Deal 2 shadow cards to each enemy in play. Deal 2 damage to each Battleground location in play.",
                Shadow = "Shadow: Discard an attachment you control.",
                EncounterSet = "The Siege of Cair Andros Nightmare",
                CardNumber = 8,
                Quantity = 3,
                Artist = Artist.Julian_Kok
            });
        }
    }
}