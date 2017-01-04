using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class WeMustAwayEreBreakOfDayNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "We Must Away, Ere Break of Day Nightmare";
            Abbreviation = "WMAEBoDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2050;

            Cards.Add(new LotRCard()
            {
                Title = "We Must Away, Ere Break of Day Nightmare",
                HasSecondImage = true,
                
                Id = "4AB41CDE-413A-4410-89D9-E201DA9D21AD",
                CardType = CardType.Nightmare_Setup,
                Text = 
@"You are playing Nightmare mode.

The objective cards ~Troll Key and ~Troll Purse gain surge.",
                FlavorText = "A nice pickle they were all in now: all neatly tied up in sacks, with three angry trolls (and two with burns and bashes to remember) sitting by them, arguing whether they should roast them slowly, or mince them fine and boil them, or just sit on them one by one and squash them into jelly... -The Hobbit",  
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the We Must Away, Ere Break of Day scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x A Suspicious Crow
1x Lone-lands
1x Dreary ~Hills
2x Hobbit-lands
2x A Nice Pickle

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard We Must Away, Ere Break of Day encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.

Play Tip: The treachery card, ~Night Wanes Slow, has a Forced effect that triggers when it is discarded from the encounter deck as a result of stage 2B's effect. When discarding cards from the encounter deck at stage 2B, discard them one at a time in case ~Night Wanes Slow is one of them.",
                EncounterSet = "We Must Away, Ere Break of Day Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard()
            {
                Title = "A Murder of Crows",
                
                Id = "648EE911-F664-4866-9C33-8ABBE5A65CCA",
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 4,
                Attack = 4,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Creature." },
                Text = 
@"When Revealed: Reveal a random card from the encounter discard pile and add it to the staging area, if able.

Forced: If A Murder of Crows would be destroyed, shuffle it back into the encounter deck instead.",
                EncounterSet = "We Must Away, Ere Break of Day Nightmare",
                Quantity = 3,
                CardNumber = 2,
                Artist = Artist.Niten
            });
            Cards.Add(new LotRCard()
            {
                Title = "Red River-bank",
                
                Id = "6CA9F51F-BDE1-40C9-9FAF-5CF8C6AF2124",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 5,
                Traits = new List<string> { "Western Lands.", "Riverland." },
                Text = "Forced: At the beginning of the refresh phase, place the top card of the encounter discard pile on the bottom of the encounter deck and raise each player's threat bu that card's Threat.",
                FlavorText = "I don't know what river is way, a rushing red one, swollen with the rains of the last few days... -The Hobbit",
                EncounterSet = "We Must Away, Ere Break of Day Nightmare",
                Quantity = 3,
                CardNumber = 3,
                Artist = Artist.JB_Casacop
            });
            Cards.Add(new LotRCard()
            {
                Title = "Wicked Hilltops",
                
                Id = "E022C71D-E74B-4C0C-A4D7-419EAB8C7FAB",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 5,
                Traits = new List<string> { "Western Lands.", "Hills." },
                Text = "Forced: After placing 1 or more progress tokens on Wicked Hilltops, each player must discard an ally he controls without an attached Sack card.",
                Shadow = "Shadow: Attacking enemy gets +2 Attack. (+3 Attack instead if attacking enemy is a Troll.)",
                EncounterSet = "We Must Away, Ere Break of Day Nightmare",
                Quantity = 3,
                CardNumber = 4,
                Artist = Artist.Wibben
            });
            Cards.Add(new LotRCard()
            {
                Title = "Comfortable Light",
                
                Id = "96F490CC-350A-4E64-B984-DE9653BACFFA",
                CardType = CardType.Location,
                Threat = 5,
                QuestPoints = null,
                Traits = new List<string> { "Trollshaws." },
                Text = 
@"Progress cannot be placed here.

Travel: Sack 1.

Forced: After Comfortable Light becomes the active location, discard it.",
                FlavorText = "Out of the dark mass of the trees they could now see a light shining, a reddish comfortable-looking light... -The Hobbit",
                EncounterSet = "We Must Away, Ere Break of Day Nightmare",
                Quantity = 3,
                CardNumber = 5,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new LotRCard()
            {
                Title = "Mince Them Fine",
                
                Id = "634A723D-7A73-4C69-9C45-E32ABFC00D65",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each engaged Troll enemy makes an immediate attack. If the players are at stage 1, immediately advance to stage 2A.",
                Shadow = "Shadow: If attacking enemy is a Troll, return it to the staging area after this attack.",
                EncounterSet = "We Must Away, Ere Break of Day Nightmare",
                Quantity = 3,
                CardNumber = 6,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard()
            {
                Title = "Night Wanes Slow",
                
                Id = "7F724BF7-CA78-45D7-B2E9-2D05F357357D",
                CardType = CardType.Treachery,
                Text = 
@"Forced: When this card is discarded from the top of the encounter deck as a result of a quest card effect, immediately stop making progress and end the quest phase.

When Revealed: Shuffle the encounter discard pile into the encounter deck. Reveal 1 additional encounter card.",
                Shadow = "",
                FlavorText = "",
                EncounterSet = "We Must Away, Ere Break of Day Nightmare",
                Quantity = 2,
                CardNumber = 7,
                Artist = Artist.Wibben
            });
            Cards.Add(new LotRCard()
            {
                Title = "One By One",
                
                Id = "59E3A03C-07EB-4859-BA57-14DC29645425",
                CardType = CardType.Treachery,
                Text = "When Revealed: Choose and destroy a character with a Sack card attached. Then, return that Sack card to the top of the Sack deck and Sack 1.",
                FlavorText = "...at last they decided to sit on the sacks one by one and squash them, and boil them next time. -The Hobbit",
                EncounterSet = "We Must Away, Ere Break of Day Nightmare",
                Quantity = 2,
                CardNumber = 8,
                Artist = Artist.Rafal_Hrynkiewicz
            });
        }
    }
}