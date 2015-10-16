using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TroubleInTharbad : CardSet
    {
        protected override void Initialize()
        {
            Name = "Trouble in Tharbad";
            Abbreviation = "TiT";
            Number = 25;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";
            PublicSlug = "trouble-in-tharbad";

            Cards.Add(new Card()
            {
                Title = "Haldir of Lórien",
                NormalizedTitle = "Haldir of Lorien",
                ImageType = ImageType.Jpg,
                Id = "15DCE26E-339E-48CA-8CF8-19A5F5BF5DD1",
                CardType = CardType.Hero,
                Sphere = Models.Sphere.Lore,
                IsUnique = true,
                ThreatCost = 9,
                Willpower = 2,
                Attack = 3,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Silvan.", "Ranger.", "Scout." },
                Keywords = new List<string> { "Ranged." },
                Text = "Combat Action: If you have not engaged an enemy this round, exhaust Haldir of Lórien to declare him as an attacker (and resolve his attack) against an enemy not engaged with you. Limit once per round.",
                FlavorText = "\"We allow no strangers to spy out the secrets of the Naith...\" -The Fellowship of the Ring",
                Number = 56,
                Quantity = 1,
                Artist = Artist.Sebastian_Giacobino
            });
            Cards.Add(new Card()
            {
                Title = "Herald of Anórien",
                NormalizedTitle = "Herald of Anorien",
                ImageType = ImageType.Jpg,
                Id = "3B790E51-01A5-4305-A273-8694964AFDAD",
                CardType = CardType.Ally,
                Sphere = Models.Sphere.Leadership,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 0,
                Defense = 1,
                HitPoints = 1,
                Traits = new List<string> { "Gondor." },
                Text = "You may give Herald of Anórien doomed 2 when you play it from your hand. If you do, it gains: \"Response: After you play Herald of Anórien, choose a player. That player may put into play 1 ally from his hand with a printed cost 2 or lower.\"",
                FlavorText = "\"Send the heralds forth! Let them summon all who dwell nigh!\" -Théoden, The Two Towers",
                Number = 57,
                Quantity = 3,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new Card()
            {
                Title = "O Lórien!",
                NormalizedTitle = "O Lorien!",
                ImageType = ImageType.Jpg,
                Id = "879112FB-689B-45AA-BD4A-DE7FDB1D31AB",
                CardType = CardType.Attachment,
                Sphere = Models.Sphere.Leadership,
                IsUnique = true,
                ResourceCost = 1,
                Traits = new List<string> { "Song." },
                Text = "Attach to a hero.\r\nAction: Exhaust O Lorien! to lower the cost of the next Silvan ally played this phase by 1 (to a minimum of 1).",
                FlavorText = "\"I sang of leaves, of leaves of gold, and\r\nleaves of gold there grew:\r\nOf wind I sang, a wind there came and in the\r\nbranches blew.\" -Galadriel, The Fellowship of the Ring",
                Number = 58,
                Quantity = 3,
                Artist = Artist.Carolina_Eade
            });
            Cards.Add(new Card()
            {
                Title = "Gwaihir",
                ImageType = Models.ImageType.Jpg,
                Id = "AAD1F231-94C0-4AF7-BD97-F1FA4A04A561",
                CardType = Models.CardType.Ally,
                Sphere = Models.Sphere.Tactics,
                IsUnique = true,
                ResourceCost = 5,
                Willpower = 2,
                Attack = 3,
                Defense = 1,
                HitPoints = 4,
                Traits = new List<string> { "Creature.", "Eagle." },
                Text = "Cannot have restricted attachments.\r\nResponse: After Gwaihir enters play, search your discard pile for an Eagle ally and put it into play under your control. At the end of the round, if that ally is still in play, add it to your hand.",
                FlavorText = "\"The North Wind blows, but we shall outfly it.\" -Gwaihir, The Return of the King",
                Number = 59,
                Quantity = 3,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new Card()
            {
                Title = "Pursuing the Enemy",
                ImageType = ImageType.Jpg,
                Id = "29FFD74F-E9E7-43EA-A259-7A22420B94BF",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 0,
                Text = "Action: Return a Silvan ally you control to your hand to choose a player. Deal 1 damage to each enemy engaged with that player.",
                FlavorText = "The marauding orcs had been waylaid and almost all destroyed; the remnant had fled westward towards the mountains, and were being pursued. -The Fellowship of the Ring",
                Number = 60,
                Quantity = 3,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new Card()
            {
                Title = "Courage Awakened",
                Id = "EE30C4EE-61A8-4A34-A516-B95CB2672F23",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 1,
                Text = "Action: Choose a hero. That hero gets +2 Willpower until the end of the phase. Then, if your threat is 20 or less and this is the first time you played a copy of Courage Awakened this round, return this card to your hand instead of discarding it.",
                FlavorText = "But the courage that had been awakened in him was now too strong: he could not leave his friends so easily. -The Fellowship of the Ring",
                Number = 61,
                Quantity = 3,
                Artist = Artist.Romana_Kendelic
            });
            Cards.Add(new Card()
            {
                Title = "Free to Choose",
                Id = "B200B774-99B8-43F6-BFBA-2EF9063270D3",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 0,
                Text = "Response: After your threat is raised by an encounter card effect, reduce your threat by an equal amount.",
                FlavorText = "Suddenly he was aware of himself again. Frodo, neither the Voice nor the Eye; free to choose, and with one remaining instant in which to do so. -The Fellowship of the Ring",
                Number = 62,
                Quantity = 3,
                Artist = Artist.Romana_Kendelic
            });
            Cards.Add(new Card()
            {
                Title = "Galadhrim Minstrel",
                Id = "7894DA0E-F6DF-4BFF-8128-B02E66371728",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 0,
                Defense = 0,
                HitPoints = 1,
                Traits = new List<string> { "Silvan.", "Minstrel." },
                Text = "Response: After Galadhrim Minstrel enters play, search the top five cards of your deck for an event card and add it to your hand. Shuffle the other cards back into your deck.",
                FlavorText = "...the language was that of Elven-song and spoke of things little known on Middle-earth. -The Fellowship of the Ring",
                Number = 63,
                Quantity = 3,
                Artist = Artist.Arden_Beckwith
            });
            Cards.Add(new Card()
            {
                Title = "Lembas",
                Id = "81A13DA7-EFE9-483F-B53D-17EAD498D5B2",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Traits = new List<string> { "Item." },
                Text = "Play only if you control a Noldor or Silvan hero. Attach to a hero.\r\nAction: Discard Lembas to ready attached hero and heal 3 damage from it.",
                FlavorText = "\"...it is more strengthing than any food made by Men, and it is more pleasant than cram, by all accounts. -Lórien Elf, The Fellowship of the Ring",
                Number = 64,
                Quantity = 3,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new Card()
            {
                Title = "Defender of the Naith",
                Id = "EEB587DB-D1F6-49A5-91A3-136F14B97320",
                CardType = CardType.Ally,
                Sphere = Sphere.Neutral,
                ResourceCost = 3,
                Willpower = 0,
                Attack = 1,
                Defense = 2,
                HitPoints = 2,
                Traits = new List<string> { "Silvan.", "Warrior." },
                Keywords = new List<string> { "Sentinel." },
                Text = "Response: After a Silvan ally you control leaves play, ready Defender of the Naith.",
                FlavorText = "\"We have been keeping watch on the rivers, ever since we saw a great troop of Orcs going North toward Moria...\" -Haldir, The Fellowship of the Ring",
                Number = 65,
                Quantity = 3,
                Artist = Artist.Christine_Griffin
            });
            Cards.Add(new Card()
            {
                Title = "Double Dealings",
                Id = "5151ED54-9132-452C-90AB-7ED2E5313B86",
                HasSecondImage = true,
                CardType = CardType.Quest,
                StageNumber = 1,
                QuestPoints = null,
                Text = "Setup: Set Bellach and The Crossing at Tharbad aside, out of play. Search the encounter deck for 1 copy of Spy From Mordor per player, and add them to the staging area. Make The Empty Mug the active location. The first player takes control of Nalir, as an ally. Shuffle the encounter deck.",
                FlavorText = "Your meeting with Nalir is interrupted by a host of Orcs led by a man, Bellach. In the ensuing chaos, you manage to escape with the Dwarf but the Orcs pursue. Outnumbered, you must throw the Orcs off your trail if you hope to escape...",
                OppositeText = 
@"Time 4.

Forced: After the last time counter is removed from this quest, reduce each player's threat elmination level by 10 for the remainder of the game. Then, place 4 time counters on this stage.

Forced: After one or more progress is placed on this quest, cancell all progress and reduce each players threat by an equal amount.

When all players have 0 threat, immediately proceed to stage 2.",
                EncounterSet = "Trouble in Tharbad",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountainOrcs },
                Number = 66,
                Quantity = 1,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new Card()
            {
                Title = "Escape from Tharbad",
                Id = "D465B5CE-493D-4163-90F4-5DED3E55CFA0",
                HasSecondImage = true,
                CardType = CardType.Quest,
                StageNumber = 2,
                QuestPoints = null,
                Text = "When Revealed: Add Bellach and The Crossing at Tharbad to the staging area. Then shuffle the encounter discard discard pile into the encounter deck and discard cards from the encounter deck until X Orc enemies have been discarded, where X is the number of players in the game. Add all discarded Orc enemies to the staging area.",
                FlavorText = "You've eluded the Orcs and you make haste for the river crossing. If you can get across, perhaps you can escape. But, Bellach has cleverly set a patrol at the ford, and you are quickly spotted. You make a dash for the river...",
                OppositeText = 
@"Time 3. 

Forced: After the last time counter is removed from the quest, either raise each player's threat by 3 or Bellach makes an immediate attack against Nalir. Then, place 3 time counters on this stage.

Progress that would be placed on this quest are instead placed on The Crossing at Tharbad.

Forced: After a character leaves play, raise its controller's threat by 2.",
                EncounterSet = "Trouble in Tharbad",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountainOrcs },
                Number = 67,
                Quantity = 1,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new Card()
            {
                Title = "Nalir",
                Id = "52000AB7-E523-45F6-B4AA-1114B8477986",
                CardType = CardType.Objective_Ally,
                Willpower = 0,
                Attack = 1,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Dwarf." },
                Text = 
@"The first player gains control of Nalir.

Forced: At the beginning of the refresh phase, raise your threat by 1 for each player in the game.

If Nalir leaves play, the players lose the game.",
                EncounterSet = "Trouble in Tharbad",
                Number = 68,
                Quantity = 1,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new Card()
            {
                Title = "The Empty Mug",
                Id = "696A364D-8114-4256-AA35-638A0D198CCB",
                CardType = CardType.Location,
                IsUnique = true,
                Threat = 1,
                QuestPoints = 4,
                Traits = new List<string> { "City." },
                Text = "Players cannot reduce their threat.\r\nWhile The Empty Mug is in the victory display, the current quest gains \"Forced: After a player card effect reduces a player's threat, remove it from the game.\"",
                VictoryPoints = 4,
                EncounterSet = "Trouble in Tharbad",
                Number = 69,
                Quantity = 1,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card()
            {
                Title = "Bellach",
                Id = "",
                CardType = CardType.Enemy,
                IsUnique = true,
                IsVariableThreat = true,
                Attack = 5,
                Defense = 4,
                HitPoints = 7,
                Traits = new List<string> { "Mordor.", "Spy." },
                Text = 
@"X is the number of players in the game.\r\nOrc and Creature enemies get -30 engagement cost and +1 Threat.

Forced: When Bellach is destroyed, shuffle him into the encounter deck.",
                EncounterSet = "Trouble in Tharbad",
                Number = 70,
                Quantity = 1,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card()
            {
                Title = "The Crossing at Tharbad",
                Id = "F293EF80-8E47-4418-9EFE-F2BB6238C215",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 10,
                Traits = new List<string> { "City.", "Ruins.", "River." },
                Text =
@"Immune to player card effects. Cannot leave the staging area.\r\nThe Crossing at Tharbad gets +2 quest points for each player in the game.
                
When The Crossing at Tharbad is explored, the players win the game.",
                EncounterSet = "Trouble in Tharbad",
                Number = 71,
                Quantity = 1,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new Card()
            {
                Title = "Spy from Mordor",
                Id = "6417354E-4762-4F31-A461-8395F2EDAB49",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 2,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Mordor.", "Orc.", "Spy." },
                Text = "Forced: When Spy from Modor attacks, remove 1 time counter from the current quest.",
                FlavorText = "\"Some spying breed of Orc, I guess, or a creature of theirs.\" -Faramir, The Two Towers",
                EncounterSet = "Trouble in Tharbad",
                Number = 72,
                Quantity = 4,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "Bellach's Marauder",
                Id = "A7C09783-E0B0-40BC-B4C2-D96B331881BF",
                CardType = CardType.Enemy,
                EngagementCost = 30,
                Threat = 3,
                Attack = 5,
                Defense = 4,
                HitPoints = 5,
                Traits = new List<string> { "Orc." },
                Text = "While Bellach's Marauder is engaged with a player, it gains: \"Forced: After a time counter is removed from the current quest, deal Bellach's Marauder 2 shadow cards.\"",
                Shadow = "Shadow: Remove 1 time counter from the current quest.",
                EncounterSet = "Trouble in Tharbad",
                Number = 73,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Alexander_Kozachenko
            });
            Cards.Add(new Card()
            {
                Title = "Streets of Tharbad",
                Id = "4D1B749A-29E4-44C8-9E63-5E2616938BB3",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 1,
                Traits = new List<string> { "City.", "Road." },
                Text = "Progress cannot be placed on Streets of Tharbad while it is in the staging area.\r\nWhile Streets of Tharbad is the active location, enemies get -20 engagement cost.",
                FlavorText = "As soon as his back was turned, a dark figure climbed quickly in over the gate and melted into the shadows of the village street. -The Fellowship of the Ring",
                EncounterSet = "Trouble in Tharbad",
                Number = 74,
                Quantity = 2,
                Artist = Artist.Nate_Abell
            });
            Cards.Add(new Card()
            {
                Title = "Tharbad Hideout",
                Id = "7F47899D-91EB-4016-B143-7EF2808716A9",
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 1,
                Traits = new List<string> { "City." },
                Keywords = new List<string> { "Surge." },
                Text = 
@"While Tharbad Hideout is the active location, time counters cannot be removed from the current quest.
                
Forced: At the beginning of the quest phase, place 1 progress on Tharbad Hideout.",
                EncounterSet = "Trouble in Tharbad",
                Number = 75,
                Quantity = 2,
                Artist = Artist.Nate_Abell
            });
            Cards.Add(new Card()
            {
                Title = "Ruins of the Second Age",
                Id = "D4411EC3-D56B-41E5-9BF0-760E4346E913",
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 5,
                Traits = new List<string> { "City.", "Ruins." },
                Text = 
@"While ~Ruins of the Second Age is in the staging area, City locations get +1 Threat.

While ~Ruins of the Second Age is the active location, deal engaged enemies 1 additional shadow card at the beginning of the combat phase.",
                FlavorText = "...as far as Tharbad, where the old North Road crossed the river by a ruined town. -The Fellowship of the Ring",
                EncounterSet = "Trouble in Tharbad",
                Number = 76,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Nate_Abell
            });
            Cards.Add(new Card()
            {
                Title = "Seedy Inn",
                Id = "7B918CB0-4C4F-4DA6-A090-8BA99A52D9FE",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "City." },
                Text = "Travel: Search the encounter deck and discard pile for a Spy enemy and add it to the staging area. Shuffle the encounter deck.",
                Shadow = "Shadow: Raise the defending player's threat by X, where X is the amount of damage dealt by this attack.",
                EncounterSet = "Trouble in Tharbad",
                Number = 77,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Claudio_Pozas
            });
            Cards.Add(new Card()
            {
                Title = "Hidden Alleyway",
                Id = "F2567C68-49A1-4BC1-9E36-C0BB1415964C",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 5,
                Traits = new List<string> { "City." },
                Text = 
@"Travel: Raise each player's threat by X to travel here. X is the number of enemies in play.

Forced: After traveling to Hidden Alleyway, add 1 time counter to the current quest.",
                EncounterSet = "Trouble in Tharbad",
                Number = 78,
                Quantity = 2,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "Decrepit Rooftops",
                Id = "89F5A19A-459C-49D6-B5A0-492672BE280C",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 3,
                Traits = new List<string> { "City." },
                Text = 
@"While Decrepit Rooftops is the active location, enemies get +1 Threat and do not make engagement checks.

Forced: After traveling to Decrepit Rooftops, return all engaged enemies to the staging area.",
                EncounterSet = "Trouble in Tharbad",
                Number = 79,
                Quantity = 2,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "Constant Tail",
                Id = "A0B25995-3D8E-4EF2-810C-BF3F375FF214",
                CardType = CardType.Treachery,
                Text = "When Revealed: Return all engaged enemies to the staging area. Then, the first player either removes 1 time counter from the current quest or each Spy enemy in the staging area gets +2 Threat until the end of the phase.",
                FlavorText = "Concealment was no longer possible, and they could only hope that no enemy or spy was observing them. -The Fellowship of the Ring",
                EncounterSet = "Trouble in Tharbad",
                Number = 80,
                Quantity = 2,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new Card()
            {
                Title = "Conspicuous Lot",
                Id = "79E29881-2AC0-4625-BBAF-32CBB42BC2BC",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each player raises his threat by 1 for each ally he controls. Then, if any player's threat is 20 or less, this card gains surge.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. (+2 Attack instead if the defending player's threat is 20 or less).",
                EncounterSet = "Trouble in Tharbad",
                Number = 81,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new Card()
            {
                Title = "Cornered",
                Id = "D8EA5691-6522-4472-BC4C-88EBA9B92248",
                CardType = CardType.Treachery,
                Text = "When Revealed: The first player either removes 1 time counter from the current quest or each enemy gets -20 engagement cost and +1 Attack until the end of the round.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending player's threat is 20 or less).",
                EncounterSet = "Trouble in Tharbad",
                Number = 82,
                Quantity = 2,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new Card()
            {
                Title = "Get That Dwarf!",
                Id = "B8B4D480-3311-46BF-964B-8519939937A4",
                CardType = CardType.Treachery,
                Text = "When Revealed: The enemy in the staging area with the highest Attack engages the first player and makes an immediate attack against Nalir. If there are no enemies in the staging area, Get That Dwarf! gains surge.",
                Shadow = "Shadow: If this attack is undefended, deal 2 damage to Nalir.",
                EncounterSet = "Trouble in Tharbad",
                Number = 83,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Ellyson_Ferrari_Lifante
            });
        }
    }
}