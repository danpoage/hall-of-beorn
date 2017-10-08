using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.AgainstTheShadow
{
    public class TheDruadanForestNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Drúadan Forest Nightmare";
            Abbreviation = "TDFN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2057;

            Cards.Add(new LotRCard()
            {
                Title = "The Drúadan Forest Nightmare",
                Id = "2795E34C-6744-425F-8696-1A27A66E3742",
                CardType = CardType.Nightmare_Setup,
                Text = 
@"You are playing Nightmare mode.

Heroes do not collect resources during the resource phase.

Setup: Add resources to each hero's resource pool until each hero has 5 resources. Search the encounter deck for 1 copy of Gard of Poisons and add it to the staging area. Shuffle the encounter deck.

Forced: After stage 2B is revealed, each hero with fewer than 3 resources gains resources until is has 3.",
                FlavorText = "\"Remnants of an older time they be, living few and secretly, wild and wary as the beasts.\" -Elfhelm, The Return of the King",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Drúadan ~Forest scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

2x Lost Companion
3x Secluded Glade
1x Overgrown Trail
1x Drû-buri-Drû
1x Drúadan Elite
1x Drúadan Hunter
1x Stars in the Sky
1x Men in the ~Dark

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Drúadan ~Forest encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "The Drúadan Forest Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Smirtouille
            });
            Cards.Add(new LotRCard()
            {
                Title = "Drû-buri-Drû",
                IsUnique = true,
                Id = "BCE2E476-6F9D-4AAA-A749-6FA7126FDE5B",
                CardType = Models.LotR.CardType.Enemy,
                EngagementCost = 1,
                Threat = 4,
                Attack = 5,
                Defense = 4,
                HitPoints = 3,
                Traits = new List<string> { "Wose." },
                Text = "Drû-buri-Drû cannot take more than 1 damage each round.\r\nWhile Drû-buri-Drû is in play, other Wose enemies get +1 Attack and +1 Defense.\r\nUnless Drû-buri-Drû is in the victory display, the players cannot win the game.",
                EncounterSet = "The Drúadan Forest Nightmare",
                Quantity = 1,
                CardNumber = 2,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new LotRCard()
            {
                Title = "Drúadan Warrior",
                Id = "43BE3381-32F8-430A-A44E-C8B57A824FB3",
                CardType = Models.LotR.CardType.Enemy,
                EngagementCost = 20,
                Threat = 2,
                Attack = 5,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Wose." },
                Keywords = new List<string> { "Prowl 2." },
                Text = "Each hero with no resources in its resource pool cannot be declared as an attacker or defender against Drúadan Warrior.",
                EncounterSet = "The Drúadan Forest Nightmare",
                Quantity = 3,
                CardNumber = 3,
                Artist = Artist.Tey_Bartolome
            });
            Cards.Add(new LotRCard()
            {
                Title = "Drúadan Stalker",
                Id = "33D50B0D-9F82-49CD-A1DD-73008DA04A35",
                CardType = Models.LotR.CardType.Enemy,
                EngagementCost = 43,
                Threat = 4,
                Attack = 3,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Wose." },
                Keywords = new List<string> { "Archery 3." },
                Text = "As an additional cost to optionally engage Drúadan Stalker, you must spend 2 resources.",
                EncounterSet = "The Drúadan Forest Nightmare",
                Quantity = 3,
                CardNumber = 4,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new LotRCard()
            {
                Title = "Devil's Mirk",
                Id = "D4C07C41-6B3D-463F-9767-DB42C424192C",
                CardType = Models.LotR.CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Forest." },
                Text = "Immune to player card effects.\r\nWhile Devil's Mirk is in the staging area, characters cannot be healed.\r\nWhile Devil's Mirk is the active location, each Wose enemy gets +2 Defense.",
                EncounterSet = "The Drúadan Forest Nightmare",
                Quantity = 3,
                CardNumber = 5,
                Artist = Artist.Bill_Thompson
            });
            Cards.Add(new LotRCard()
            {
                Title = "Eilenach",
                Id = "33083879-E3E1-4842-8A03-FFABC4900529",
                CardType = Models.LotR.CardType.Location,
                Threat = 5,
                QuestPoints = 4,
                Traits = new List<string> { "Forest.", "Hills." },
                Text = "Players cannot travel to Eilenach unless there is at least 1 resource in each hero's resource pool.",
                Shadow = "Shadow: If the defending character has no resources, deal it 1 damage.",
                FlavorText = "...standing up from the long ridges of the Drúadan Forest... -The Return of the King",
                EncounterSet = "The Drúadan Forest Nightmare",
                Quantity = 2,
                CardNumber = 6,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "Stonewain Valley",
                Id = "CDF2CC0B-2FAB-4A29-944B-95BE00416244",
                CardType = Models.LotR.CardType.Location,
                Threat = 1,
                QuestPoints = 6,
                Traits = new List<string> { "Forest." },
                Text = "While Stonewain Valley is in the staging area, resources discarded or spent by the first player for any reason are placed on Stonewain Valley.\r\nStonewain Valley gets +1 Threat for each resource on it.",
                FlavorText = "\"Way is wide for four horses in Stonewain Valley yonder,\" he waved his hand southwards: \"but narrow at beginning and at end.\" -Ghân-buri-Ghân, The Return of the King",
                EncounterSet = "The Drúadan Forest Nightmare",
                Quantity = 2,
                CardNumber = 7,
                Artist = Artist.Jake_Bullock
            });
            Cards.Add(new LotRCard()
            {
                Title = "Drums of the Wild Men",
                Id = "30901B1E-FDAA-477A-A54D-BCE163E82FAA",
                CardType = Models.LotR.CardType.Treachery,
                Text = "When Revealed: Each player must trigger the prowl keyword on each enemy engaged with him, as if that enemy had been revealed from the encounter deck. Then, return each engaged Wose enemy to the staging area. If no enemies are returned to the staging area by this effect, Drums of the Wild Men gains surge.",
                EncounterSet = "The Drúadan Forest Nightmare",
                Quantity = 2,
                CardNumber = 8,
                Artist = Artist.Smirtouille
            });
            Cards.Add(new LotRCard()
            {
                Title = "Poison-darts",
                Id = "27037F3E-B1E4-43B5-9C14-952661626477",
                CardType = Models.LotR.CardType.Treachery,
                Traits = new List<string> { "Item." },
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Attach to the enemy in play with the highest engagement cost. (Counts as a Weapon attachment with the text: \"Attached enemy gets +2 Attack and gains Archery 2.\")",
                FlavorText = "Merry did not like this talk of wild men and poisoned darts... -The Return of the King",
                EncounterSet = "The Drúadan Forest Nightmare",
                Quantity = 3,
                CardNumber = 9,
                Artist = Artist.Melanie_Maier
            });
        }
    }
}