using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheLostRealm : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Lost Realm";
            Abbreviation = "TLR";
            Number = 29;
            SetType = Models.SetType.Deluxe_Expansion;

            Cards.Add(new Card()
            {
                Title = "Aragorn",
                Id = "D315D327-EDF2-45EC-802F-EB67103AA6F2",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Models.Sphere.Tactics,
                ThreatCost = 12,
                Willpower = 2,
                Attack = 3,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Dúnedain.", "Ranger.", "Warrior." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger.", "Warrior." },
                Text = "Each enemy engaged with you gets -1 Defense.\r\nResponse: After Aragorn participates in an attack that destroys an enemy, choose an enemy not engaged with you and engage that enemy.",
                FlavorText = "\"I serve no man,\" said Aragorn; \"but the servants of Sauron I pursue into whatever land they may go.\" -The Two Towers",
                Artist = Artist.Sebastian_Giacobino,
                Number = 1,
                Quantity = 1
            });
            Cards.Add(new Card()
            {
                Title = "Halbarad",
                Id = "FF755E95-4B65-47FC-BAC9-F9FE3ECA6AD6",
                IsUnique = true,
                CardType = CardType.Hero,
                Sphere = Models.Sphere.Leadership,
                ThreatCost = 10,
                Willpower = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Dúnedain.", "Ranger." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger." },
                Text = "While you are engaged with any enemy, Halbarad does not exhaust to commit to a quest.\r\nYou may optionally engage 1 additional enemy during the encounter phase.",
                FlavorText = "\"Little do they know of our long labour for the safekeeping of their borders, and yet I grudge it not.\" -The Return of the King",
                Artist = Artist.Smirtouille,
                Number = 2,
                Quantity = 1
            });
            Cards.Add(new Card()
            {
                Title = "Weather Hills Watchman",
                Id = "859D6FC7-8A16-4D38-87AB-4324536D9DE9",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string> { "Dúnedain." },
                NormalizedTraits = new List<string> { "Dunedain." },
                Text = "Response: After Weather Hills Watchman enters play, search the top 5 cards of your deck for a Signal card and add it to your hand. Shuffle the other cards back into your deck.",
                FlavorText = "\"Rangers use runes, and they come here sometimes.\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Kim_Sokol,
                Number = 3,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Dúnedain Hunter",
                NormalizedTitle = "Dunedain Hunter",
                Id = "8E8D4D02-E6C9-4E42-AC81-F545658F996A",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                ResourceCost = 0,
                Willpower = 1,
                Attack = 3,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Dúnedain.", "Ranger." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger." },
                Text = "Forced: After Dúnedain Hunter enters play, search the top 5 cards of the encounter deck for a non-unique enemy and put it into play engaged with you. If no enemy enters play by this effect, discard Dúnedain Hunter. Shuffle the encounter deck.",
                Artist = Artist.Louis_Green,
                Number = 4,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Sarn Ford Sentry",
                Id = "CDEC0EB5-6C35-421A-9194-77CAAE3B539B",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 3,
                Willpower = 2,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string> { "Dúnedain.", "Scout." },
                NormalizedTraits = new List<string> { "Dunedain.", "Scout." },
                Text = "Response: After Sarn Ford Sentry enters play, draw 1 card for each enemy engaged with you.",
                FlavorText = "\"Lonely men are we, Rangers of the wild, hunters but hunters ever of the servants of the Enemy...\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Smirtouille,
                Number = 5,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Warden of Annúminas",
                NormalizedTitle = "Warden of Annuminas",
                Id = "C9AB1B34-0511-4B08-A47A-4D0A64405449",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                ResourceCost = 4,
                Willpower = 0,
                Attack = 2,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Dúnedain.", "Ranger." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger." },
                Text = "Warden of Annúminas gets +1 Willpower for each enemy engaged with you.",
                FlavorText = "Rangers passed at times beyond the hills, but they were few and did not stay. -The Fellowship of the Ring",
                Artist = Artist.Smirtouille,
                Number = 6,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Ranger Summons",
                Id = "79A265E7-CD1B-4170-806A-C442B0F5D9DD",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Traits = new List<string> { "Signal." },
                Text = "Play only if you control a Dúnedain hero.\r\nPlanning Action: Shuffle 1 of your set aside Ranger of th North allies with the encounter keyword into the encounter deck. Then, remove Ranger Summons from the game.",
                FlavorText = "\"We rode as swiftly as we might when your summons came.\" -Halbarad, The Return of the King",
                Artist = Artist.Smirtouille,
                Number = 7,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Tireless Hunters",
                Id = "AE28E1EF-4359-4971-ABAA-435A44A3303B",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Text = "Play only before the resolving enemy attacks step.\r\nCombat Action: Choose an enemy not engaged with you. Engage that enemy. Then, discard a shadow card from that enemy, if able.",
                FlavorText = "\"Many evil things there are that your strong walls and bright swords do not stay.\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Ilich_Henriquez,
                Number = 8,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Expert Trackers",
                Id = "976EA200-579A-45CE-B82D-1D1013F643BB",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                ResourceCost = 0,
                Text = "Response: After you engage an enemy, exhaust a Scout or Ranger character to place X progress tokens on a location. X is the engaged enemy's printed Threat.",
                FlavorText = "\"At last!\" said Aragorn. \"Here are the tracks that we seek!\" -The Two Towers",
                Artist = Artist.Alexandr_Shaldin,
                Number = 9,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Heir of Valandil",
                Id = "A474448A-F0A6-4F8F-9FD3-497031C15B4E",
                IsUnique = true,
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                ResourceCost = 2,
                Traits = new List<string> { "Title." },
                Text = "Attach to a Dúnedain hero.\r\nPlanning Action: Exhaust Heir of Valandil to reduce the cost of the next Dúnedain ally you play this phase by 1 for each enemy engaged with you.",
                FlavorText = "\"But my home, such as I have, is in the North. For here the heirs of Valandil have ever dwelt in long line unbroken from father unto son for many generations.\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Smirtouille,
                Number = 10,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Athelas",
                Id = "52B91199-3718-49AF-BF7D-D7E37699956B",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Traits = new List<string> { "Item." },
                Text = "Attach to a Dúnedain or Healer character.\r\nAction: Discard Athelas and exhaust attached character to heal all damage on a character. You may discard a Condition attachment from that character.",
                FlavorText = "\"...it is a healing plant that the Men of the West brought to Middle-earth. Athelas they named it...\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Cristi_Balanescu,
                Number = 11,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Secret Vigil",
                Id = "94D07579-97E4-4806-868A-BD47D8915C6A",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                ResourceCost = 1,
                Traits = new List<string> { "Condition." },
                Text = "Attach to an enemy. Limit 1 per enemy.\r\nAttached enemy gets -1 Threat.\r\nResponse: When attached enemy is destroyed, reduce each player's threat by the attached enemy's printed Threat.",
                FlavorText = "\"If simple folk are free from care and fear, simple they will be, and we must be secret to keep them so.\" -Aragorn, The Fellowship of the Ring",
                Artist = Artist.Piya_Wannachaiwong,
                Number = 12,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Star Brooch",
                Id = "18D8333D-8A53-4629-BF85-AFDB01536308",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                ResourceCost = 1,
                Traits = new List<string> { "Item." },
                Text = "Attach to a Dúnedain or Noldor hero. Limit 1 per hero.\r\nWhile you are engaged with an enemy, attached hero gets +1 Willpower and cannot have its Willpower reduced.",
                FlavorText = "...each cloak was pinned upon the left shoulder by a brooch of silver shaped like a rayed star. -The Return of the King",
                Artist = Artist.Alexandr_Elichev,
                Number = 13,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Gather Information",
                Id = "0B4029A2-FE36-47F5-A588-1243EFCAFC14",
                CardType = CardType.Player_Side_Quest,
                Sphere = Sphere.Neutral,
                ResourceCost = 0,
                QuestPoints = 4,
                Text = "Limit 1 per deck.\r\nResponse: After this stage is defeated, each player may search his deck for 1 card and add it to his hand. Each player shuffles his deck.",
                FlavorText = "Aragorn halted and examined the tracks closely. -The Tower Towers",
                VictoryPoints = 1,
                Artist = Artist.Smirtouille,
                Number = 14,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Ranger of the North",
                Id = "056C5C1A-D944-4734-835B-0EF3995EFC08",
                CardType = CardType.Ally,
                Sphere = Sphere.Neutral,
                ResourceCost = byte.MaxValue,
                Willpower = 2,
                Attack = 2,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Dúnedain.", "Ranger." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger." },
                Keywords = new List<string> { "Encounter.", "Surge.", "Ranged.", "Sentinel." },
                Text = "When Revealed: The first player chooses a player to take control of Ranger of the North. Then, either deal 2 damage to an enemy or place 2 progress tokens on a location.",
                Artist = Artist.Alvaro_Calvo_Escudero,
                Number = 15,
                Quantity = 3,
            });
            Cards.Add(new Card()
            {
                Title = "Iârion",
                NormalizedTitle = "Iarion",
                Id = "93F6B7C3-2F83-4E1C-8E3E-E3C9F1044A18",
                CardType = CardType.Objective_Ally,
                ScenarioTitle = "The Lost Realm",
                Willpower = 0,
                IsVariableWillpower = true,
                Attack = 0,
                IsVariableAttack = true,
                Defense = 0,
                IsVariableDefense = true,
                HitPoints = 4,
                Traits = new List<string> { "Dúnedain.", "Ranger." },
                NormalizedTraits = new List<string> { "Dunedain.", "Ranger." },
                Text = "X is the number of quest cards in play.\r\nThe first player gains control of Iârion.\r\nResponse: After a side quest is revealed from the encounter deck, ready Iârion.\r\nIf Iârion leaves play, the players lose the game.",
                Artist = Artist.JB_Casacop,
                Number = 16,
                Quantity = 1
            });
            Cards.Add(new Card()
            {
                Title = "Orc War Party",
                Id = "27E03560-6816-4AC3-8B49-1F81586DF47B",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 3,
                Attack = 6,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Orc." },
                Text = "Cannot have attachments.\r\nWhile Orc War Party is in the staging area, enemies in the staging area cannot take damage.\r\nThe players cannot win the game while Orc War Party is in play.",
                FlavorText = "They kept no order, thrusting, jostling, and cursing; yet their speed was very great. -The Two Towers",
                Artist = Artist.Anthony_Feliciano,
                Number = 17,
                Quantity = 1
            });
            Cards.Add(new Card()
            {
                Title = "Chetwood Forest",
                Id = "5395CF56-5550-4760-813D-5BE67E1A3AEB",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Arnor.", "Forest." },
                Text = "Travel: One player chooses and engages an enemy in the staging area.",
                Shadow = "Shadow: Defending player either exhausts a hero he controls, or returns attacking enemy to the staging area after this attack.",
                Artist = Artist.Unknown,
                Number = 18,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Make Camp",
                Id = "8C631517-6E71-43DD-93A6-383F4C1B2696",
                CardType = CardType.Encounter_Side_Quest,
                QuestPoints = 6,
                Keywords = new List<string> { "Surge." },
                Text = "Characters cannot be healed.\r\nResponse: After Make Camp is defeated, each player heals up to 3 damage from a hero he controls.",
                FlavorText = "Your companions are exhausted from tireless effort, but you must find a safe place to make camp before you can tend to their needs.",
                VictoryPoints = 10,
                Artist = Artist.Romana_Kendelic,
                Number = 55,
                Quantity = 1
            });
            Cards.Add(new Card()
            {
                Title = "Dead Lord",
                Id = "D5FE657C-31FF-4786-8A0F-234453CDFADA",
                CardType = CardType.Enemy,
                EngagementCost = 33,
                Threat = 3,
                Attack = 4,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Undead." },
                Text = "Forced: After Dead Lord engages you, put the topmost Undead enemy in the discard pile into play engaged with you.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, reveal 1 encounter card.",
                Artist = Artist.Florian_Devos,
                Number = 60,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Cursed Dead",
                Id = "A16D47E6-12B0-4EA2-A71E-F2786F0B1AF0",
                CardType = CardType.Enemy,
                EngagementCost = 27,
                Threat = 1,
                Attack = 3,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string> { "Undead." },
                Text = "When Revealed: Put each copy of Cursed Dead in the discard pile into play in the staging area.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if there is a copy of the defending character in its owner's discard pile).",
                Artist = Artist.Unknown,
                Number = 61,
                Quantity = 3
            });
            Cards.Add(new Card()
            {
                Title = "Seal the Tomb",
                Id = "A07A38A1-29B9-409F-BCFA-8014AE5A8F78",
                CardType = CardType.Encounter_Side_Quest,
                QuestPoints = 6,
                Keywords = new List<string> { "Surge." },
                Text = "Forced: At the end of the refresh phase, discard the top 3 cards of the encounter deck. Return the topmost Undead enemy in the encounter discard pile to the staging area.",
                FlavorText = "The undead keep rising from the grave. For each one that you strike down, another takes its place. You must do something to stem the tide...",
                VictoryPoints = 10,
                Artist = Artist.Guillaume_Ducos,
                Number = 63,
                Quantity = 1
            });
        }
    }
}