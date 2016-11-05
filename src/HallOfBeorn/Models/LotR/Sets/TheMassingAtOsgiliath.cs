using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheMassingatOsgiliath : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Massing at Osgiliath";
            Abbreviation = "TMaO";
            Number = 3001;
            SetType = Models.SetType.GenCon_Expansion;
            Cycle = "GenCon";

            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "The Witch-king",
                Id = "51223bd0-ffd1-11df-a976-1801202c9001",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                IsUnique = true,
                Attack = 6,
                Defense = 6,
                HitPoints = 11,
                Traits = new List<string>() { "Nazgûl.", " Captain." },
                NormalizedTraits = new List<string> { "Nazgul." },
                Text = 
@"No attachments.\r\nWhile The Witch-king is in the staging area, each character gets -1 Willpower.

Forced: After The Witch-king attacks, he returns to the staging area unless the defending player raises his threat by 3.",
                Threat = 6,
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Igor_Kieryluk
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Snaga Scouts",
                Id = "51223bd0-ffd1-11df-a976-1801202c9002",
                CardType = CardType.Enemy,
                EngagementCost = 1,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string>() { "Orc.", " Scout." },
                Text = "Forced: At the beginning of the encounter phase, all copies of Snaga Scouts engage the player with the lowest threat. (The first player chooses in case of a tie.)",
                Threat = 1,
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 4,
                Number = 2,
                Artist = Artist.Paul_Guzenko
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Wolves from Mordor",
                Id = "51223bd0-ffd1-11df-a976-1801202c9003",
                CardType = CardType.Enemy,
                EngagementCost = 27,
                Attack = 4,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string>() { "Creature.", " Scout." },
                Text = "Forced: After Wolves from Mordor attack and destroy a character, shuffle Wolves from Mordor into the encounter deck.",
                Shadow = "Shadow: Deal 2 damage to the defending character.",
                Threat = 1,
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 4,
                Number = 3,
                Artist = Artist.Allison_Theus
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Wainriders",
                Id = "51223bd0-ffd1-11df-a976-1801202c9004",
                CardType = CardType.Enemy,
                EngagementCost = 35,
                Attack = 3,
                Defense = 1,
                HitPoints = 4,
                Traits = new List<string>() { "Easterling.", " Scout." },
                Text = "Each damage dealt by Wainriders raises the defending player's threat by 1.",
                Threat = 2,
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 4,
                Number = 4,
                Artist = Artist.David_Chen
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Wainrider Captain",
                Id = "51223bd0-ffd1-11df-a976-1801202c9005",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Attack = 3,
                Defense = 3,
                HitPoints = 4,
                Traits = new List<string>() { "Easterling.", " Captain." },
                Text = "When Revealed: Move the top Scout enemy from the encounter discard pile to the staging area. (Top 2 Scout enemies instead if the players have crossed the Anduin.)",
                Shadow = "Shadow: If this attack is undefended, attacking enemy gets +2 Attack if it is a Scout.",
                Threat = 3,
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 3,
                Number = 5,
                Artist = Artist.David_Horne
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Uruk Vanguard",
                Id = "51223bd0-ffd1-11df-a976-1801202c9006",
                CardType = CardType.Enemy,
                EngagementCost = 45,
                Attack = 2,
                Defense = 1,
                HitPoints = 8,
                Traits = new List<string>() { "Uruk.", " Orc." },
                Text = "If the players have crossed the Anduin, Uruk Vanguard gets +3 Attack.",
                Shadow = "Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if players have crossed the Anduin).",
                Threat = 2,
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 3,
                Number = 6,
                Artist = Artist.Matthew_Starbuck
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Captured Watchtower",
                Id = "51223bd0-ffd1-11df-a976-1801202c9007",
                CardType = CardType.Location,
                Traits = new List<string>() { "West Bank." },
                Text = "If the players have crossed the Anduin, Captured Watchtower gets +3 Threat.",
                Shadow = "Shadow: Remove all defending characters from combat. This attack is considered undefended.",
                Threat = 1,
                QuestPoints = 2,
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 3,
                Number = 7,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Emyn Arnen Overlook",
                Id = "51223bd0-ffd1-11df-a976-1801202c9008",
                CardType = CardType.Location,
                Traits = new List<string>() { "East Bank.", " Highlands." },
                Text = "The first Scout enemy revealed from the encounter deck each round gains surge and doomed 2.",
                Threat = 2,
                QuestPoints = 5,
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 1,
                Number = 8,
                Artist = Artist.Igor_Kieryluk
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Morgulduin",
                Id = "51223bd0-ffd1-11df-a976-1801202c9009",
                CardType = CardType.Location,
                Traits = new List<string>() { "East Bank.", " Polluted." },
                Text = "While Morgulduin is the active Location, it gains: 'Forced: When a character commits to a Quest, deal 1 damage to that character.'",
                Shadow = "Shadow: If the players have not yet crossed the Anduin, return any current active location to the staging area. Morgulduin becomes the active location.",
                Threat = 1,
                QuestPoints = 3,
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 2,
                Number = 9,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Pelennor Fields",
                Id = "51223bd0-ffd1-11df-a976-1801202c9010",
                CardType = CardType.Location,
                Traits = new List<string>() { "West Bank." },
                Text = "If the players have crossed the Anduin, Pelennor Fields gains: 'When faced with the option to travel, the players must either travel to Pelennor Fields or raise each player's threat by 3.'",
                Threat = 1,
                QuestPoints = 7,
                VictoryPoints = 1,
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 2,
                Number = 10,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Ruins of Osgiliath",
                Id = "51223bd0-ffd1-11df-a976-1801202c9011",
                CardType = CardType.Location,
                Traits = new List<string>() { "East Bank." },
                Text = "If the players have not crossed the Anduin, Ruins of Osgiliath gets +3 Threat.",
                //HtmlTemplate = "<p>If the players have not crossed the Anduin, {self} gets +3 {threat}.</p><p class='flavor-text'>...but Osgiliath which lay between was deserted and in its ruins shadows walked.<br>&ndash;The Fellowship of the Ring</p>",
                Threat = 1,
                QuestPoints = 2,
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 3,
                Number = 11,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Cut Off",
                Id = "51223bd0-ffd1-11df-a976-1801202c9012",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each player must discard all ally cards from his hand, if able.",
                Shadow = "Shadow: Defending player must discard 1 ally card from his hand or attacking enemy gets +3 Attack. (2 allies instead if this attack is undefended.",
                Keywords = new List<string>() { "Doomed 1." },
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 4,
                Number = 12,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Dark Pursuit",
                Id = "51223bd0-ffd1-11df-a976-1801202c9013",
                CardType = CardType.Treachery,
                Text = "When Revealed: Raise the total Threat of the staging area by 1 for each Scout enemy in play. If there are no Scout enemies in play, Dark Pursuit gains surge.",
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 2,
                Number = 13,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Massing at Osgiliath",
                Id = "51223bd0-ffd1-11df-a976-1801202c9014",
                CardType = CardType.Treachery,
                Text = "When Revealed: Until the end of the phase, each card revealed by the encounter deck gains doomed 1. (Doomed 3 instead if the players have crossed the Anduin.)",
                Keywords = new List<string>() { "Surge." },
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 3,
                Number = 14,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Ranger of Ithilien",
                Id = "51223bd0-ffd1-11df-a976-1801202c9015",
                CardType = CardType.Objective_Ally,
                Attack = 2,
                Defense = 1,
                Willpower = 2,
                HitPoints = 2,
                Traits = new List<string>() { "Gondor.", " Ranger.", " Ally." },
                Text = "When Revealed: The first player takes control of Ranger of Ithilien, exhausted and committed to the quest. Then, Ranger of Ithilien gains surge.",
                Shadow = "Shadow: Deal 2 damage to attacking enemy. The defending player may exhaust a character he controls to take control of Ranger of Ithilien.",
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 2,
                Number = 15,
                Artist = Artist.Eric_Braddock
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Beyond Expectations",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-1801202c9016",
                CardType = CardType.Quest,
                ScenarioNumber = 1,
                QuestPoints = 7,
                Text = "Setup: Search the encounter deck for 12 Scout cards, and add 3 per player (one of each title), to the staging area. Remove The Witch-king from the encounter deck and set him aside, out of play. Shuffle any unused Scoutcards back into the encounter deck.",
                FlavorText = "There are reports of increased Orc activity around Ithilien, and you have been sent to investigate. You enter Osgiliath and cross the river. On the outskirts of the city, you see a horde that surpassses all expectations coming down the Morgul Road.",
                OppositeText = "Players cannot travel to West Bank locations.",
                OppositeFlavorText = "As the van of the army enters the city, some of the horde's outriders are aware of your presence, and head in your direction. Drawing back, your make a hasty retreat towards the river.",
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 1,
                Number = 16,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Through the Ruins",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-1801202c9018",
                CardType = CardType.Quest,
                ScenarioNumber = 1,
                QuestPoints = 5,
                OppositeText = "Players cannot travel to West Bank locations.\r\nEach player cannot play or put into play more than 1 card from his hand each round.",
                FlavorText = "The outriders and scouts of the army have cut you off from the bridge. You desperately seek the likeliest place to cross the Anduin.",
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 1,
                Number = 17,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Anduin Crossing",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-1801202c9020",
                CardType = CardType.Quest,
                ScenarioNumber = 1,
                QuestPoints = 1,
                OppositeText = "Progress tokens from card effects cannot be placed on this quest card or the active location.\r\nPlayers cannot travel to East Bank or West Bank locations.\r\nIn order to commit characters to the quest, a player must first choose a hero or 1 Ranger of Ithilien card he controls. Discard each chosen card from play.",
                FlavorText = "The cold waters of the Anduin river rush before you, but the current is weaker here and you have to cross. The outriders and van of the Dark Lord's army are closing fast behind, and their archers will make the attempted crossing even more dangerous. The bravest members of your band turn back to distract the oncoming horde, so that the rest of you might escape.",
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 1,
                Number = 18,
                Artist = Artist.Marco_Caradonna
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Race to Minas Tirith",
                StageNumber = 4,
                Id = "51223bd0-ffd1-11df-a976-1801202c9022",
                CardType = CardType.Quest,
                ScenarioNumber = 1,
                QuestPoints = 15,
                OppositeText = "When Revealed: Add The Witch-king to the staging area.\r\nPlayers have now crossed the Anduin. Players cannot travel to East Bank locations.If the players defeat this stage, they have won the game.",
                FlavorText = "You made it across the Anduin and are leaving Osgiliath when a fell shriek splits the air. You begin the race across the Pelennor Fields to the safety of Minas Tirith, but a new enemy follows behind.",
                EncounterSet = "The Massing at Osgiliath",
                Quantity = 1,
                Number = 19,
                Artist = Artist.Igor_Kieryluk
            });
        }
    }
}
