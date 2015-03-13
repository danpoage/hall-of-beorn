using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheAntleredCrown : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Antlered Crown";
            Abbreviation = "TAC";
            Number = 28;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";

            Cards.Add(new Card()
            {
                Title = "Erkenbrand",
                Id = "4845B24F-B80E-4E1E-AF65-B066A9CC5285",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Sphere.Leadership,
                ThreatCost = 10,
                Willpower = 1,
                Attack = 2,
                Defense = 3,
                HitPoints = 4,
                Traits = new List<string> { "Rohan.", "Warrior." },
                Keywords = new List<string> { "Sentinel." },
                Text = "While Erkenbrand is defending, he gains: \"Response: Deal 1 damage to Erkenbrand to cancel a shadow effect just triggered.\"",
                FlavorText = "Down from the hills leaped Erkenbrand, lord of Westfold. -The Two Towers",
                Number = 137,
                Quantity = 1,
                Artist = Artist.Sebastian_Giacobino
            });
            Cards.Add(new Card()
            {
                Title = "Warden of Helm's Deep",
                Id = "7A0EF66E-78D4-4491-9794-4C2D422153D5",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                ResourceCost = 3,
                Willpower = 0,
                Attack = 1,
                Defense = 3,
                HitPoints = 2,
                Traits = new List<string> { "Rohan.", "Warrior." },
                Keywords = new List<string> { "Sentinel."  },
                Text = "",
                FlavorText = "They now learned to their joy that Erkenbrand had left many men to hold Helm's Gate, and more had since escaped thither. -The Two Towers",
                Number = 138,
                Quantity = 3,
                Artist = Artist.Jarreau_Wimberly
            });
            Cards.Add(new Card()
            {
                Title = "The Day's Rising",
                IsUnique = true,
                Id = "8EFF9151-549A-4A15-B68F-051925DC9A25",
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Traits = new List<string> { "Song." },
                Text = "Attach to a hero with sentinel.\r\nResponse: After attached hero defends against an attack and takes no damage while defending that attack, exhaust Day's Rising to add 1 resource to the attached hero's resource pool.",
                FlavorText = "Out of doubt, out of dark to the day's rising\r\nI came singing in the sun, sword unsheathing.\r\n-Éomer, The Return of the King",
                Number = 139,
                Quantity = 3,
                Artist = Artist.Jarreau_Wimberly
            });
            Cards.Add(new Card()
            {
                Title = "Captain of Gondor",
                IsUnique = true,
                Id = "B4C7608C-3DE1-4ED0-9A70-DCA3754A05ED",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Traits = new List<string> { "Title." },
                Text = "Attach to a Warrior hero.\r\nResponse: After you optionally engage an enemy, exhaust ~Captain of ~Gondor to give attached hero +1 Attack and +1 Defense until the end of the round.",
                FlavorText = "\"Boromir it was that drove the enemy at last back from this western shore...\" -Beregond, The Return of the King",
                Number = 140,
                Quantity = 3,
                Artist = Artist.Jarreau_Wimberly
            });
            Cards.Add(new Card()
            {
                Title = "Booming Ent",
                Id = "2F6D2218-B8A6-4392-B990-10072C01B166",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                ResourceCost = 2,
                Willpower = 0,
                Attack = 2,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Ent." },
                Text = "Cannot have restricted attachments. Enters play exhausted.\r\nBooming ~Ent gets +1 Attack for each damaged Ent character you control.",
                FlavorText = "\"...a man that hacks once at an Ent never gets a chance of a second blow.\" -Merry, The Two Towers",
                Number = 141,
                Quantity = 3,
                Artist = Artist.Jarreau_Wimberly
            });
            Cards.Add(new Card()
            {
                Title = "Ride Them Down",
                Id = "EE872CB0-4A05-478B-8AFE-2B2C7D62E471",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 2,
                Text = "Quest Action: Choose a non-unique enemy in the staging area. Until the end of the phase, progress that would be placed on the quest from questing successfully is instead assigned as damage to the chosen enemy. (Progress must still be placed on any active location first.)",
                FlavorText = "Like thunder they broke upon the enemy... -The Return of the King",
                Number = 142,
                Quantity = 3,
                Artist = Artist.Emile_Denis
            });
            Cards.Add(new Card()
            {
                Title = "Shadows Give Way",
                Id = "165E6952-E91F-488C-AF2A-7B386EBA06C3",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 3,
                Text = "You must use resources from 3 different heroes' pools to pay for this card.\r\nAction: Discard each shadow card from each enemy in play.",
                FlavorText = "At that moment he caught a flash of white and silver coming from the North, like a small star down on the dusky fields. -The Return of the King",
                Number = 143,
                Quantity = 3,
                Artist = Artist.Jordy_Lakiere
            });
            Cards.Add(new Card()
            {
                Title = "Don't Be Hasty!",
                Id = "DCC98174-CD80-4F70-8606-359D40475BA5",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                ResourceCost = 0,
                Text = "Response: When an encounter card is revealed but before resolving any of that card's keywords or \"when revealed\" effects, choose a character comited to the quest. Ready that character and remove it from the quest.",
                FlavorText = "\"Don't be hasty, that is my motto.\" -Treebeard, The Two Towers",
                Number = 144,
                Quantity = 3,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new Card()
            {
                Title = "Waters of Nimrodel",
                Id = "84206FDC-00CF-466D-9747-D556CF67BD95",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                ResourceCost = 3,
                Keywords = new List<string> { "Doomed 3." },
                Text = "Action: Heal all damage on each character in play.",
                FlavorText = "For a moment Frodo stood near the brink and let the water flow over his tired feet. It was cold but its touch was clean, and as he went on and it mounted to his knees, he felt that the strain of travel and all weariness was washed from his limbs. -The Fellowship of the Ring",
                Number = 145,
                Quantity = 3,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "Treebeard",
                IsUnique = true,
                Id = "5B45DA78-E5E1-4F6B-A0B7-B2234A2C927D",
                CardType = CardType.Ally,
                Sphere = Sphere.Neutral,
                ResourceCost = 4,
                Willpower = 2,
                Attack = 4,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Ent." },
                Text = "Cannot have restricted attachments. Treebeard enters play exhausted and collects 1 resource each resource phase. These resources can be used to pay for Ent cards played from your hand.\r\nAction: Pay 2 resources from Treebeard's pool to ready an Ent character.",
                Number = 146,
                Quantity = 3,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new Card()
            {
                Title = "Battle for Dunland",
                Id = "7417FF88-C605-445C-8EF1-9817BF0C9CF7",
                CardType = CardType.Quest,
                HasSecondImage = true,
                StageNumber = 1,
                QuestPoints = 10,
                Keywords = new List<string> { "Time 3." },
                Text = "Setup: The first player takes control of Chief Turch. Set ~Raven Chief and ~Raven Chief's Camp aside, out of play. Reveal 1 copy of ~Dunland Battlefield and make it the active location. Reveal 1 copy of ~Raven War-camp and add it to the staging area. Create the ~Raven deck (see insert) and set it next to the quest deck. Each player chooses 1 different enemy from the ~Raven deck and adds it to the staging area. Shuffle the encounter deck and ~Raven deck.",
                OppositeText = "Forced: After the last time counter is removed from this stage, remove 1 time counter from each location in play. Place 3 time counters on this stage.",
                OppositeFlavorText = "On your return journey to Isengard, you find war in Dunland. The Raven Clan has refused the Boar's claim to The Antlered Crown, and chief Turch asks you to join his Clan as they march to battle. Seeing an opportunity to earn Saruman the friendship of a unified Dunland, you agree to join forces and fight...",
                EncounterSet = "The Antlered Crown",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DunlandRaiders, EncounterSet.DunlandWarriors },
                Number = 147,
                Quantity = 1,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card()
            {
                Title = "The Raven Clan",
                Id = "156DF256-E17E-4D82-B0A2-4F13B94F1D03",
                CardType = CardType.Quest,
                HasSecondImage = true,
                StageNumber = 2,
                QuestPoints = 15,
                Keywords = new List<string> { "Time 3." },
                Text = "When Revealed: Shuffle the ~Raven deck discard pile into the ~Raven deck. Then, starting with the first player, each player takes the top card of the ~Raven deck and adds it to the staging area.",
                OppositeText = "Forced: After the last time counter is removed from this stage, reveal the top card of the ~Raven deck and add it to the staging area. Place 3 time counters on this stage.\r\nEach location in the staging area gets +2 quest points.",
                FlavorText = "Chief Turch's goal is to defeat the Raven Clan before they can marshal their full strength, but Dunland is a vast country and there is much ground to cover. The longer it takes to subdue the enemy, the more time they have to gather...",
                EncounterSet = "The Antlered Crown",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DunlandRaiders, EncounterSet.DunlandWarriors },
                Number = 148,
                Quantity = 1,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card()
            {
                Title = "The Last Stage",
                Id = "B2362439-CE94-48F2-ADD1-F49FB16C7A3E",
                CardType = CardType.Quest,
                HasSecondImage = true,
                StageNumber = 3,
                QuestPoints = null,
                Keywords = new List<string> { "Time 2." },
                Text = "When Revealed: Add ~Raven Chief and ~Raven Chief's Camp to the staging area. Take the top X cards from the ~Raven deck and add them to the staging area. X is the number of players minus 1.",
                FlavorText = "The warriors of the Raven Clan won't stop figting as long as their leader spurs them on. You must find the Raven Chief and defeat him in order to break the spirit of his men and bring and end to this conflict...",
                OppositeText = "Forced: After the last time counter is removed from this stage, each engaged enemy makes an attack. Place 2 time counter on this stage.\r\nAt the end of the round, if ~Raven Chief is in the victory display, the players win the game.",
                EncounterSet = "The Antlered Crown",
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DunlandRaiders, EncounterSet.DunlandWarriors },
                Number = 149,
                Quantity = 1,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(new Card()
            {
                Title = "Chief Turch",
                IsUnique = true,
                Id = "DFAD5078-E858-4B85-A340-B31363F10C0A",
                CardType = CardType.Objective_Ally,
                Willpower = 1,
                Attack = 3,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Dunland.", "Boar Clan." },
                Text = "The first player gains control of Chief Turch.\r\nImmune to player card effects. Chief Turch does not exhaust to defend.\r\nIf Chief Tuch leaves play, the players lose the game.",
                EncounterSet = "The Antlered Crown",
                Number = 150,
                Quantity = 1,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Raven Chief",
                IsUnique = true,
                Id = "CA8FB834-2E48-4396-B33F-44C05134B388",
                CardType = CardType.Enemy,
                EngagementCost = 15,
                Threat = 4,
                Attack = 5,
                Defense = 5,
                HitPoints = 9,
                Traits = new List<string> { "Dunland.", "Raven Clan." },
                Text = "Cannot have attachments. While ~Raven Chief's Camp is in play, ~Raven Chief cannot be damaged.\r\nForced: When ~Raven Chief attacks, remove 1 time counter from the active location, if able.",
                VictoryPoints = 3,
                EncounterSet = "The Antlered Crown",
                Number = 151,
                Quantity = 1,
                Artist = Artist.Scott_Murphy
            });
            Cards.Add(new Card()
            {
                Title = "Raven Chief's Camp",
                IsUnique = true,
                Id = "31FD7E78-05B0-4B37-9744-26ACC46541A3",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 9,
                Traits = new List<string> { "Dunland." },
                Keywords = new List<string> { "Time 3." },
                Text = "Immune to player card effects.\r\nForced: After the last time counter is removed from this location, exhaust each damaged character. Place 3 time counters on this location.",
                VictoryPoints = 3,
                EncounterSet = "The Antlered Crown",
                Number = 152,
                Quantity = 1,
                Artist = Artist.Victor_Garcia
            });
            Cards.Add(new Card()
            {
                Title = "Raven Warrior",
                Id = "3896483D-E6A5-4FAE-8965-63CAB7CF97A3",
                CardType = CardType.Enemy,
                EngagementCost = 36,
                Threat = 3,
                Attack = 4,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Dunland.", "Raven Clan." },
                Text = "Forced: After ~Raven Warrior engages a player. remove X time counters from locations in play. X is the number of cards in engaged player's hand.",
                Shadow = "Shadow: Defending player discards an attachment he controls.",
                EncounterSet = "The Antlered Crown",
                Number = 153,
                Quantity = 4,
                EasyModeQuantity = 3,
                Artist = Artist.Nicholas_Gregory
            });
            Cards.Add(new Card()
            {
                Title = "Raven Skirmisher",
                Id = "BEF1B5F4-C613-4895-8AC5-8AF0D630C29D",
                CardType = CardType.Enemy,
                EngagementCost = 26,
                Threat = 2,
                Attack = 3,
                Defense = 2,
                HitPoints = 2,
                Traits = new List<string> { "Dunland.", "Raven Clan." },
                Text = "When Revealed: Either remove 1 time counter from the active location, or reveal an additional encounter card.",
                Shadow = "Shadow: Attacking enemy gets +X Attack, where X is the Time X value on the active location.",
                EncounterSet = "The Antlered Crown",
                Number = 154,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Nicholas_Gregory
            });
            Cards.Add(new Card()
            {
                Title = "Raven War-camp",
                Id = "73530F69-E6DE-48F2-ADAC-FC2A8706AF37",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 4,
                Traits = new List<string> { "Dunland." },
                Keywords = new List<string> { "Time 3." },
                Text = "Forced: After the last time counter is removed from this location, starting with the first player, each player draws the top card of the ~Raven deck and puts it into play engaged with him.",
                FlavorText = "All the camp was soon astir. -The Two Towers",
                EncounterSet = "The Antlered Crown",
                Number = 155,
                Quantity = 4,
                EasyModeQuantity = 2,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new Card()
            {
                Title = "Raven Village",
                Id = "C5B4B14A-FB15-4438-B697-0464FE4FE6A9",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 3,
                Traits = new List<string> { "Dunland." },
                Keywords = new List<string> { "Time 2." },
                Text = "Forced: After the last time counter is removed from this location, reveal the top card of the ~Raven deck and add it to the staging area.",
                Shadow = "Shadow: Deal attacking enemy 2 additional shadow cards from the Raven deck.",
                EncounterSet = "The Antlered Crown",
                Number = 156,
                Quantity = 3,
                Artist = Artist.Lino_Drieghe
            });
            Cards.Add(new Card()
            {
                Title = "Dunland Battlefield",
                Id = "EDB5006A-9CAC-42D7-9728-8EB8DC6F6677",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 5,
                Traits = new List<string> { "Dunland." },
                Keywords = new List<string> { "Time 3." },
                Text = "Forced: After the last time counter is removed from this location, each player assigns X damage among characters he controls, where X is the number of cards in his hand.",
                Shadow = "Shadow: Deal 1 damage to the defending character.",
                EncounterSet = "The Antlered Crown",
                Number = 157,
                Quantity = 3,
                Artist = Artist.Victor_Garcia
            });
            Cards.Add(new Card()
            {
                Title = "Raven Country",
                Id = "2CD84B2E-B8D0-453A-B299-7099FAE95953",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 6,
                Traits = new List<string> { "Dunland." },
                Keywords = new List<string> { "Time 4." },
                Text = "Forced: After the last time counter is removed from this location, each player raises his threat by the number of cards in his hand.",
                Shadow = "Shadow: Defending player assigns X damage among characters he controls. X is the Time X value on the active location.",
                EncounterSet = "The Antlered Crown",
                Number = 158,
                Quantity = 2,
                Artist = Artist.Victor_Garcia
            });
            Cards.Add(new Card()
            {
                Title = "Raising the Cry",
                Id = "95EFF90E-2EFC-4E04-9377-D2B3BCC02102",
                CardType = CardType.Treachery,
                Text = "When Revealed: Remove 1 time counter from each location in play. Place X time counters on each location in play with no time counters on it. X is the \"Time X\" value on that location. If there are not locations in the staging area, Raising the Cry gains surge.",
                FlavorText = "...a cry went up into the shuddering air...\r\n-The Return of the King",
                EncounterSet = "The Antlered Crown",
                Number = 159,
                Quantity = 3,
                EasyModeQuantity = 2,
                Artist = Artist.Nicholas_Gregory
            });
            Cards.Add(new Card()
            {
                Title = "Fierce Folk",
                Id = "4648E4F9-67D3-4903-BCA7-6E377504CA8D",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Doomed 3." },
                Text = "When Revealed: Each player draws 3 cards. Until the end of the round, players cannot play events.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, remove 1 time counter from the active location.",
                EncounterSet = "The Antlered Crown",
                Number = 160,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new Card()
            {
                Title = "Driven Back",
                Id = "5FF7138B-872C-4FD4-9C2E-7ABA9B7FEE25",
                CardType = CardType.Treachery,
                Text = "When Revealed: Remove all progress from each location in the staging area. Increase the total Threat in the staging area by 1 for each progress removed this way. If no progress was removed by this effect, Driven Back gains surge.",
                FlavorText = "\"We are overmastered.\" -Ceorl, The Two Towers",
                EncounterSet = "The Antlered Crown",
                Number = 161,
                Quantity = 2,
                Artist = Artist.Igor_Kieryluk
            });
        }
    }
}