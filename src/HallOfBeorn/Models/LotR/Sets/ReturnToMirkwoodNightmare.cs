using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class ReturnToMirkwoodNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Return to Mirkwood Nightmare";
            Abbreviation = "RtMN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2008;

            Cards.Add(new LotRCard()
            {
                Title = "Return to Mirkwood Nightmare",
                Id = "C9A56A9F-F13D-4DA9-916C-D6CE5408B7A5",
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\n\r\nForced: At the beginning of the quest phase, the player who is guarding ~Gollum must either exhaust a hero he controls or resolve the \"when revealed\" effect of the topmost Tantrum card in the encounter discard pile.\r\n\r\nForced: When Stage 4A is revealed, search the encounter deck and discard pile for 1 copy of Attercop, Attercop and add it to the staging area, if able. Shuffle the encounter deck.",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Return to ~Mirkwood scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x Woodman's Glade
3x Wood Elf Path
3x Mountains of ~Mirkwood
2x ~Goblin Sniper
1x Marsh Adder
2x Wargs
2x Despair
2x The Brown Lands
2x The East Bight

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Return to ~Mirkwood encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",

                EncounterSet = "Return to Mirkwood Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ambushing Orcs",
                
                Id = "E52E3F8B-6C12-4A5C-9909-3B3A40C5DE81",
                CardType = CardType.Enemy,
                EngagementCost = 28,
                Threat = 2,
                Attack = 4,
                Defense = 3,
                HitPoints = 7,
                Traits = new List<string> { "Mordor.", "Orc." },
                Text = "When Ambushing Orcs is dealt a shadow card that targets the player guarding Gollum, that shadow card also targets each other player",
                FlavorText = "\"It was that very night of summer, yet moonless and starless, that Orcs came on us at unawares.\" -Legolas, The Fellowship of the Ring",
                EncounterSet = "Return to Mirkwood Nightmare",
                Quantity = 3,
                CardNumber = 2,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new LotRCard()
            {
                Title = "Pursuing Warg-rider",
                
                Id = "10E42DC5-566E-43B4-9C3D-CF63AF40A291",
                CardType = CardType.Enemy,
                EngagementCost = 48,
                Threat = 3,
                Attack = 4,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Goblin.", "Orc." },
                Text = "Cannot be optionally engaged.\r\nForced: After the player guarding Gollum changes, Pursuing Warg-rider engages the player guarding Gollum and makes an immediate attack against that player.",
                EncounterSet = "Return to Mirkwood Nightmare",
                Quantity = 2,
                CardNumber = 3,
                Artist = Artist.Rick_Price
            });
            Cards.Add(new LotRCard()
            {
                Title = "Web-spinner",
                
                Id = "DD05E927-C677-4C27-B694-493281C0D8FB",
                CardType = CardType.Enemy,
                EngagementCost = 33,
                Threat = 3,
                Attack = 3,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Creature.", "Spider." },
                Text = "When Revealed: The player guarding Gollum must either exhaust a hero he controls or Web-spinner gains surge.",
                Shadow = "Shadow: The player guarding Gollum must exhaust a character he controls.",
                EncounterSet = "Return to Mirkwood Nightmare",
                Quantity = 3,
                CardNumber = 4,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new LotRCard()
            {
                Title = "Deceptive Path",
                
                Id = "CFFD5078-77D7-451B-B45E-86AC11A70BA4",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 1,
                Traits = new List<string> { "Forest." },
                Text = 
@"Progress cannot be placed on Deceptive Path while it is in the staging area.

Forced: After Deceptive Path becomes the active location, shuffle the encounter discard pile into the encounter deck and discard cards from the top of the encounter deck until a location is discarded. Reveal that location and make it the active location. Then, discard Deceptive Path.",
                EncounterSet = "Return to Mirkwood Nightmare",
                Quantity = 2,
                CardNumber = 5,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "Web-wall",
                
                Id = "766CF222-9094-4076-94FD-43C871F69423",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 6,
                Traits = new List<string> { "Forest." },
                Text = "When Revealed: Reveal the topmost Spider enemy in the encounter discard pile and add it to the staging area.",
                Shadow = "Shadow: The player guarding Gollum must discard all resources from each of his heroes' resource pools.",
                EncounterSet = "Return to Mirkwood Nightmare",
                Quantity = 3,
                CardNumber = 6,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "Isolation",
                
                Id = "2AFB7882-B425-4036-9518-B6A5E317012A",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Attach Isolation to the current quest. (Counts as a Condition attachment with the text: \"All characters lost the ranged and sentinel keywords. The player guarding Gollum cannot choose a new player to guard Gollum.\")",
                FlavorText = "And he was miserable, alone, lost. -The Hobbit",
                EncounterSet = "Return to Mirkwood Nightmare",
                Quantity = 2,
                CardNumber = 7,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new LotRCard()
            {
                Title = "Befouled Equipment",
                
                Id = "DF8EC67E-9764-4C69-A06F-FCB56DA2A9AB",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Tantrum." },
                Text = "When Revealed: Discard all attachments controlled by the player guarding Gollum. Then remove all cards in that player's discard pile from the game. If no attachments are discarded as a result of this effect, Befouled Equipment gains surge.",
                Shadow = "Shadow: Discard all attachments controlled by the player guarding Gollum.",
                EncounterSet = "Return to Mirkwood Nightmare",
                Quantity = 2,
                CardNumber = 8,
                Artist = Artist.Ed_Mattinian
            });
            Cards.Add(new LotRCard()
            {
                Title = "Wickedness and Mischief",
                
                Id = "23005927-8199-44C7-8462-B6372B51E077",
                CardType = CardType.Treachery,
                Text = "When Revealed: The player guarding Gollum must either reveal the topmost Tantrum card in the encounter discard pile, or reveal 2 additional encounter cards from the encounter deck.",
                Shadow = "Shadow: Deal the topmost Tantrum card in the encounter discard pile as a new shadow card for this attack, if able.",
                EncounterSet = "Return to Mirkwood Nightmare",
                Quantity = 2,
                CardNumber = 9,
                Artist = Artist.Gabriel_Verdon
            });
        }
    }
}