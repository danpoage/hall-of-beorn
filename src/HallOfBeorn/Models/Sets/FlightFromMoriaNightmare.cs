using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class FlightFromMoriaNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Flight from Moria Nightmare";
            Abbreviation = "FfMN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2011;

            Cards.Add(new Card()
            {
                Title = "Flight from Moria Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                Id = "96C0EDF3-550B-4966-99D6-095521DCCB5A",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

When a quest card is bypassed, shuffle it into the quest deck instead of placing it on the bottom.

While the ~Escape from Darkness quest card is in play, the Refresh Action on Abandoned ~Tools can only be triggered once each round.",
                FlavorText = "\"Fly! This is a foe beyond any of you.\". -Gandalf, The Fellowship of the Ring",

                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Flight from Moria scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x Blocked by ~Shadow
1x New Devilry
3x Stray ~Goblin
2x The Mountains' Roots
3x Chance Encounter
2x ~Goblin ~Archer
1x ~Goblin Spearman
2x Plundered Armoury
3x ~Cave In
2x ~Dark and Dreadful

Shuffle the new stage 2 quest cards in this Nightmare Deck into the quest deck along with the rest of the scenario's stage 2 quest cards, leaving stage 1A on top of the quest deck. Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Flight from Moria encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",
                EncounterSet = "Flight from Moria Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new Card()
            {
                Title = "Search for an Exit",
                OppositeTitle = "Pursued By Shadow",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                SlugIncludesOppositeTitle = true,
                Id = "A1380AE9-1895-48A7-9C5D-FF3D941DD1D9",
                CardType = CardType.Quest,
                StageNumber = 2,
                Text = "While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.",
                FlavorText = "As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, your must escape from the Black Pit...",
                OppositeText = "Forced: At the end of the round, shuffle the discard pile into the encounter deck and discard the top 5 cards. Resolve the " + 
                "\"when revealed\" effects of each copy of A Foe Beyond discarded by this effect.\r\n\r\n" +
@"No more than 1 progress can be placed on this stage each round. If the players defeat this stage, they win the game.

Players may bypass this quest card at the end of the combat phase.",
                QuestPoints = 5,
                EncounterSet = "Flight from Moria Nightmare",
                Quantity = 1,
                Number = 2,
                Artist = Artist.Cristi_Balanescu,
                OppositeArtist = Artist.Gabriel_Verdon
            });
            Cards.Add(new Card()
            {
                Title = "Search for an Exit",
                OppositeTitle = "Blocked by Flame",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                SlugIncludesOppositeTitle = true,
                Id = "1A4E5458-13CC-41B1-8A44-6FC3FF25693E",
                CardType = CardType.Quest,
                StageNumber = 2,
                Text = "While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.",
                FlavorText = "As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, your must escape from the Black Pit...",
                OppositeText = 
@"The ~Nameless Fear attacks each player in turn order during the combat phase (deal and discard a shadow card for each attack). Characters are eligible to attack The ~Nameless Fear while it is in the staging area.

If The ~Nameless Fear has 10 or more damage on it, remove all damage from it and advance to the next stage. Players may bypass this quest card at the end of the combat phase.",
                QuestPoints = null,
                VictoryPoints = 1,
                EncounterSet = "Flight from Moria Nightmare",
                Quantity = 1,
                Number = 3,
                Artist = Artist.Cristi_Balanescu,
                OppositeArtist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Search for an Exit",
                OppositeTitle = "Ghâsh",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                SlugIncludesOppositeTitle = true,
                Id = "A1EDC2C0-0F79-45C1-BFF6-B314BEDFBC6B",
                CardType = CardType.Quest,
                StageNumber = 2,
                Text = "While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.",
                FlavorText = "As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, your must escape from the Black Pit...",
                OppositeText = 
@"When Revealed: Deal 1 damage to each questing character.

Players may bypass this quest card at the end of the combat phase.",
                OppositeFlavorText = "\"As I stood there I could hear orc-voices on the other side: at any moment I though they would burst it open. I could not hear what was said; they seemed to be talking in their own hideous language. All I caught was ghâsh: that is 'fire'.\"\r\n-Gandalf, The Fellowship of the Ring",
                QuestPoints = 1,
                VictoryPoints = 1,
                EncounterSet = "Flight from Moria Nightmare",
                Quantity = 1,
                Number = 4,
                Artist = Artist.Cristi_Balanescu,
                OppositeArtist = Artist.Mark_Behm
            });
            Cards.Add(new Card()
            {
                Title = "Swarming Goblins",
                ImageType = ImageType.Jpg,
                Id = "AE6D95BC-A85D-49F9-93D1-58730B3A2982",
                CardType = CardType.Enemy,
                EngagementCost = 10,
                Threat = 1,
                Attack = 3,
                Defense = 1,
                HitPoints = 6,
                Traits = new List<string> { "Goblin.", "Orc." },
                Keywords = new List<string> { "Surge." },
                Text = "While you are engaged with Swarming Goblins, it gains: \"Forced: When a quest card is bypassed, search the encounter discard pile for a copy of ~Goblin Spearman and put it into play engaged with you.\"",
                EncounterSet = "Flight from Moria Nightmare",
                Quantity = 3,
                Number = 5,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new Card()
            {
                Title = "Coal-Black Orc",
                ImageType = ImageType.Jpg,
                Id = "7DDD73A9-F6E1-4610-B78D-3D349C9CC057",
                CardType = CardType.Enemy,
                EngagementCost = 34,
                Threat = 0,
                IsVariableThreat = true,
                Attack = 0,
                IsVariableAttack = true,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Orc." },
                Text = "X is the number of victory points in the victory display.",
                Shadow = "Shadow: Attacking enemy gets +X Attack. X is the number of victory points in the victory display.",
                EncounterSet = "Flight from Moria Nightmare",
                Quantity = 3,
                Number = 6,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card()
            {
                Title = "Shadowed Corridor",
                ImageType = ImageType.Jpg,
                Id = "0653EEE7-63F0-4A2B-AB65-B487A842A288",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 6,
                Traits = new List<string> { "Underground.", "Dark." },
                Text = "As an additional cost to bypass a quest card, each player must raise his threat by 2.",
                Shadow = "Shadow: If the defending character is a hero, discard all resources in its resource pool. Deal attacking enemy another shadow card for each resource discarded in this way.",
                EncounterSet = "Flight from Moria Nightmare",
                Quantity = 4,
                Number = 7,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new Card()
            {
                Title = "Dismay and Fear",
                ImageType = ImageType.Jpg,
                Id = "8724509F-5380-42E1-9434-FFFF1B03091D",
                CardType = CardType.Treachery,
                Text = "When Revealed: Choose and remove characters from the quest until the total Willpower of characters removed from the quest is equal to or higher than The ~Nameless Fear's Threat.",
                Shadow = "Shadow: Discard each attachment you control with a cost less than The ~Nameless Fear's Threat.",
                EncounterSet = "Flight from Moria Nightmare",
                Quantity = 3,
                Number = 8,
                Artist = Artist.Dleoblack
            });
            Cards.Add(new Card()
            {
                Title = "An Evil Fortune",
                ImageType = ImageType.Jpg,
                Id = "D69789C5-FA48-44FA-80B2-158134CFEF33",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Shadow.", "Flame." },
                Keywords = new List<string> { "Surge.", "Doomed 1." },
                Text = "When Revealed: Add this card to the victory display.",
                Shadow = "Shadow: If this attack destroys a character, add this card to the victory display.",
                VictoryPoints = 1,
                EncounterSet = "Flight from Moria Nightmare",
                Quantity = 3,
                Number = 9,
                Artist = Artist.Mark_Behm
            });
        }
    }
}