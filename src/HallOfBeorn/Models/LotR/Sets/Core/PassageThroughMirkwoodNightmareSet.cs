using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Core
{
    public class PassageThroughMirkwoodNightmareSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Passage Through Mirkwood Nightmare";
            Abbreviation = "PTMN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2000;

            Cards.Add(new LotRCard()
            {
                Title = "Passage Through Mirkwood Nightmare",
                Id = "e84f94bf-201b-4adf-95d2-0012e0bb5001",
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\nForced: During setup, each player reveals 1 card from the encounter deck and adds it to the staging area.",
                OppositeText = 
@"Begin with the standard quest deck and encounter deck for the Passage Through Mirkwood scenario found in the LOTR LCG core set.

Remove the following cards, in the specified quantities, from the standard encounter deck:

Ungoliant's Spawn x1
Black ~Forest Bats x1
~Forest ~Spider x3
Dol Guldur Orcs x3
Old ~Forest ~Road x1
~Forest ~Gate x2
Mountains of ~Mirkwood x3
Caught in a Web x2

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Passage Through Mirkwood encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",

                EncounterSet = "Passage Through Mirkwood Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Stacey_Diana_Clark
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ungoliant's Spawn",
                
                Id = "E9AA70B7-D4E4-426B-ADFE-7A3F2A91FE18",
                CardType = CardType.Enemy,
                EngagementCost = 32,
                Threat = 3,
                Attack = 5,
                Defense = 3,
                HitPoints = 9,
                Traits = new List<string> { "Creature.", "Spider." },
                Text = "When Revealed: Until the end of the phase, each character currently committed to the quest gets -2 Willpower and is discarded if its Willpower is 0.",
                Shadow = "Shadow: Raise defending player's threat by 5. (Raise defending player's threat by 10 instead if undefended.)",
                EncounterSet = "Passage Through Mirkwood Nightmare",
                Quantity = 1,
                CardNumber = 2,
                Artist = Artist.Christopher_Burdett
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ungoliant's Brood",
                
                Id = "99AED5D7-2300-41DB-9D93-97DB4AFB1D32",
                CardType = CardType.Enemy,
                EngagementCost = 31,
                Threat = 2,
                Attack = 3,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Creature.", "Spider." },
                Text = "Forced: After you engage Ungoliant's Brood, your cards cannot ready for the remainder of the round.",
                Shadow = "Shadow: If this attack is undefended, exhaust all characters you control.",
                EncounterSet = "Passage Through Mirkwood Nightmare",
                Quantity = 3,
                CardNumber = 3,
                Artist = Artist.S_C_Watson
            });
            Cards.Add(new LotRCard()
            {
                Title = "Forest Flies",
                
                Id = "9FE05FBB-7A80-45F5-B004-0F1B45E66E3F",
                CardType = CardType.Enemy,
                EngagementCost = 27,
                Threat = 4,
                Attack = 1,
                Defense = 0,
                HitPoints = 3,
                Traits = new List<string> { "Creature.", "Insect." },
                Text = "Forced: After you engage Forest Flies, deal 1 damage to each exhausted character you control.",
                Shadow = "Shadow: If attacking enemy is an Insect, deal it 2 additional shadow cards.",
                EncounterSet = "Passage Through Mirkwood Nightmare",
                Quantity = 3,
                CardNumber = 4,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new LotRCard()
            {
                Title = "Spiders of Mirkwood",
                
                Id = "67F97CBB-20B1-44A8-896A-C96573A20975",
                CardType = CardType.Enemy,
                EngagementCost = 18,
                Threat = 3,
                Attack = 2,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Spider." },
                Text = "While it is engaged with you, Spiders of Mirkwood gets +1 for each exhausted character you control.",
                Shadow = "Shadow: Choose and exhaust 1 character you control. If this attack is undefended, also deal that character 2 damage.",
                EncounterSet = "Passage Through Mirkwood Nightmare",
                Quantity = 2,
                CardNumber = 5,
                Artist = Artist.Andrew_Ryan
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Spider's Web",
                
                Id = "61507870-10CC-409A-BD91-497697D4B415",
                CardType = CardType.Treachery,
                Text = "When Revealed: The player with the highest threat exhausts all heroes he controls. Then, attach this card to one of that player's heroes. (Counts as a Condition attachment with the text, \"Each time attached hero readies, deal it 1 damage.\")",
                EncounterSet = "Passage Through Mirkwood Nightmare",
                Quantity = 3,
                CardNumber = 6,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            addTreachery("Backtrack!", "Passage Through Mirkwood Nightmare")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: The topmost enemy or location card in the encounter discard pile is returned to the staging area.")
                .WithShadow("Shadow: Deal and resolve the topmost Shadow effect in the encounter discard pile for this attack.")
                .WithInfo(7, 2, Artist.Magali_Villeneuve);
            Cards.Add(new LotRCard()
            {
                Title = "Abandoned Camp",
                
                Id = "D9AEDBA6-726A-4E70-BC90-B6D7EBBE25C9",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 2,
                Traits = new List<string> { "Mirkwood." },
                Text = "Immune to player card effects.\r\nForced: After Abandoned Camp leaves play, each player must deal 2 damage to each exhausted character he controls.",
                Shadow = "Shadow: If this attack is undefended, discard all attachment cards players control.",
                EncounterSet = "Passage Through Mirkwood Nightmare",
                Quantity = 3,
                CardNumber = 8,
                Artist = Artist.Dana_Li
            });
            Cards.Add(new LotRCard()
            {
                Title = "Glade of the Spawn",
                
                Id = "09968CAF-E80A-411D-9491-BFABB78F1F67",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 4,
                Traits = new List<string> { "Mirkwood." },
                Text = "While Glade of the Spawn is the active location, it gains: \"Forced: After a Spider enemy enters play, each player must choose and exhaust 1 character he controls.\"",
                FlavorText = "...black even for that forest, like a patch of midnight that had never been cleared away. -The Hobbit",
                EncounterSet = "Passage Through Mirkwood Nightmare",
                Quantity = 2,
                CardNumber = 9,
                Artist = Artist.S_C_Watson
            });
        }
    }
}