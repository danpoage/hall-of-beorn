using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.ShadowsOfMirkwood
{
    public class TheHuntForGollumNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Hunt for Gollum Nightmare";
            Abbreviation = "THfGN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2003;

            Cards.Add(new LotRCard()
            {
                Title = "The Hunt for Gollum Nightmare",
                Id = "EAC4C67B-297A-4E6D-AA8E-DA33D57C87E7",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Forced: At the end of the refresh phase, choose an unclaimed Clue card not attached to a Mordor enemy and attach it to a Mordor enemy, if able. (If it was guarded, detach the encounter guarding it first. The newly attached Mordor enemy is now guarding it.)

If at any point there are four or more Clue cards attached to Mordor enemies, the players lose the game.",
                FlavorText = "\"Through Mirkwood and back again it led them, though they never caught him.\"\r\n-Gandalf, The Fellowship of the Ring",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Hunt for ~Gollum scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

2x ~River Ninglor
1x The Eaves of ~Mirkwood
2x False Lead
2x Misty ~Mountain Goblins
2x Banks of the Anduin
3x Gladden Fields
3x Eastern Crows
2x Treacherous Fog
3x Evil Storm

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Hunt for ~Gollum encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",

                EncounterSet = "The Hunt for Gollum Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Ignacio_Bazan_Lazcano
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ravenous Hawk",
                
                Id = "47DFC868-233F-4746-BD7B-566C068979FB",
                CardType = CardType.Enemy,
                EngagementCost = 42,
                Threat = 2,
                Attack = 3,
                Defense = 3,
                HitPoints = 4,
                Traits = new List<string> { "Creature." },
                Text = "Forced: When a card effect instructs a player to \"look\" at cards in the encounter deck and Ravenous Hawk is among those cards, that player must put Ravenous Hawk into play engaged with him. (This does not satisfy the Forced effect of stage 1B or 2B).",
                EncounterSet = "The Hunt for Gollum Nightmare",
                Quantity = 3,
                CardNumber = 2,
                Artist = Artist.Nacho_Molina
            });
            Cards.Add(new LotRCard()
            {
                Title = "Hunting Warg",
                
                Id = "CCC072EA-E465-435A-B35A-17434AE875A2",
                CardType = CardType.Enemy,
                EngagementCost = 15,
                Threat = 1,
                Attack = 3,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Creature.", "Mordor." },
                Text = "Forced: At the beginning of the refresh phase, if Hunting Warg entered play this round, search the encounter deck and discard pile for 1 copy of Hunters from Mordor and add it to the staging area, if able. Shuffle the encounter deck.",
                FlavorText = "\"...where the warg howls, there also the orc prowls.\"\r\n-Aragorn, The Fellowship of the Ring",
                EncounterSet = "The Hunt for Gollum Nightmare",
                Quantity = 2,
                CardNumber = 3,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new LotRCard()
            {
                Title = "Watched Path",
                
                Id = "F57F373C-8DB0-4B64-B24E-1035586955F5",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 4,
                Traits = new List<string> { "Forest.", "Road." },
                Text = "Each player who does not control at least 1 Clue card cannot draw cards through card effects.",
                Shadow = "Shadow: If you do not control at least 1 Clue card, discard all cards from your hand.",
                FlavorText = "\"The Road is watched, but we should have to cross it...\"\r\n-Aragorn, The Fellowship of the Ring",
                EncounterSet = "The Hunt for Gollum Nightmare",
                Quantity = 2,
                CardNumber = 4,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "Hunter's Lookout",
                
                Id = "05B0B319-AD3B-48D3-BBCC-EA14CCC25D51",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 6,
                Traits = new List<string> { "Riverland." },
                Text = "Each Mordor enemy with at least 1 Clue card attached gets +2 Defense.",
                Shadow = "Shadow: Attacking enemy gets +1 Defense for each Clue card in play until the end of the round.",
                EncounterSet = "The Hunt for Gollum Nightmare",
                Quantity = 2,
                CardNumber = 5,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "Dark Pools",
                
                Id = "F138439D-B974-4F34-9060-F7BB9732D504",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 2,
                Traits = new List<string> { "Marshland." },
                Text = 
@"Progress cannot be placed on Dark Pools while it is in the staging area.

Forced: After Dark Pools becomes the active location, each player must discard an ally with the highest printed cost among the allies he controls.",
                FlavorText = "'And there in the dark pools amid the Gladden Fields,'he said, 'the Ring passed out of knowledge and legend...'\r\n-The Fellowship of the Ring",
                EncounterSet = "The Hunt for Gollum Nightmare",
                Quantity = 3,
                CardNumber = 6,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Enemy's Trail",
                
                Id = "4ABD5D9D-97E6-4937-BD4B-3F149A149569",
                CardType = CardType.Treachery,
                Text = "When Revealed: Search the encounter discard pile for a Clue card and attach it to a Mordor enemy in play, if able. If no card is attached by this effect, The Enemy's Trail gains surge.",
                Shadow = "Shadow: Search the encounter discard pile for a Clue card and attach it to a Mordor enemy in play, if able.",
                EncounterSet = "The Hunt for Gollum Nightmare",
                Quantity = 2,
                CardNumber = 7,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard()
            {
                Title = "Restless Hunters",
                
                Id = "2B86BFA7-483E-4643-BD16-D63FC990DEE9",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: The first player chooses a Clue card attached to a hero and attaches it to a Mordor enemy in play, if able.",
                Shadow = "Shadow: Damage from this attack must be applied to a hero you control with a Clue card attached, if able.",
                EncounterSet = "The Hunt for Gollum Nightmare",
                Quantity = 3,
                CardNumber = 8,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Trail Goes Cold",
                
                Id = "6F9650AD-DDE1-41F5-81DE-5F4E7EEDB208",
                CardType = CardType.Treachery,
                Text = "When Revealed: Attach to the active location and remove all progress from that location. (Counts as a Condition attachment with the text:\"Limit 1 per location. Attached location contributes its Threat during the quest phase as if it were in the staging area.\")\r\n\r\nIf The Trail Goes Cold does not attach to a location as a result of this effect, it gains surge.",
                EncounterSet = "The Hunt for Gollum Nightmare",
                Quantity = 2,
                CardNumber = 9,
                Artist = Artist.Christine_Mitzuk
            });
        }
    }
}