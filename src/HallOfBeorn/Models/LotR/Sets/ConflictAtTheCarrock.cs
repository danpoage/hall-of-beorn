using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class ConflictattheCarrock : CardSet
    {
        protected override void Initialize()
        {
            Name = "Conflict at the Carrock";
            Abbreviation = "CatC";
            Number = 3;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Shadows of Mirkwood";

            Cards.Add(new LotRCard() {
                
                Title = "Frodo Baggins",
                Id = "51223bd0-ffd1-11df-a976-0801202c9001",
                CardType = CardType.Hero,
                Sphere = Sphere.Spirit,
                ThreatCost = 7,
                IsUnique = true,
                Attack = 1,
                Defense = 2,
                Willpower = 2,
                HitPoints = 2,
                Text = "Response: After Frodo ~Baggins is damaged, cancel the damage and instead raise your threat by the amount of damage he would have been dealt. (Limit once per phase.)",
                FlavorText = "Frodo began to feel restless, and the old paths seemed too well-trodden. he looked at maps and wondered what lay beyond their edges... -The Fellowship of the Ring",
                Quantity = 1,
                CardNumber = 25,
                Artist = Artist.John_Stanko
            }.WithTraits("Hobbit."));
            Cards.Add(new LotRCard() {
                Title = "A Frightened Beast",
                Id = "51223bd0-ffd1-11df-a976-0801202c9002",
                CardType = CardType.Treachery,
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "When Revealed: Each player raises his threat by the total Threat of all cards in the staging area. Any player may choose to discard from play 1 Creature ally card he controls to cancel this effect.",
                FlavorText = "Then, one of the ponies took fright at nothing and bolted. -The Hobbit",
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 47,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard() {
                Title = "Against the Trolls",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-0801202c9003",
                CardType = CardType.Quest,
                Quantity = 1,
                QuestPoints = 1,
                FlavorText = "You approach the Carrock, and find that the Trolls have been watching you from the top of the rocky river landmark. As you approach, the Trolls close in and attack!",
                OppositeText = 
@"When Revealed: Place the unique Troll cards previously set aside into the staging area.

Players cannot defeat this stage if there are any Troll enemies in play.",
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 36,
                Artist = Artist.Diego_Gisbert_Llorens,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.JourneyAlongTheAnduin, EncounterSet.Wilderlands }
            });
            Cards.Add(new LotRCard() {
                Title = "Bee Pastures",
                Id = "51223bd0-ffd1-11df-a976-0801202c9005",
                CardType = CardType.Location,
                Traits = new List<string>() { "Wilderlands." },
                Quantity = 3,
                Text = "Response: After you travel to Bee Pastures, search the encounter deck and discard pile for Grimbeorn the Old and add him to the staging area. Then, shuffle the encounter deck.",
                Threat = 1,
                QuestPoints = 2,
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 45,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new LotRCard() {
                Title = "Beorning Beekeeper",
                Id = "51223bd0-ffd1-11df-a976-0801202c9006",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Beorning." },
                Quantity = 3,
                ResourceCost = 4,
                Attack = 2,
                Defense = 1,
                Willpower = 1,
                HitPoints = 3,
                Text = "Action: Discard Beorning Beekeeper from play to deal 1 damage to each enemy in the staging area.",
                FlavorText = "\"We are getting near,\" said Gandalf. \"We are on th eedge of his bee pastures.\" - The Hobbit",
                CardNumber = 28,
                Artist = Artist.John_Matson
            });
            Cards.Add(new LotRCard() {
                Title = "Born Aloft",
                Id = "51223bd0-ffd1-11df-a976-0801202c9007",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Condition." },
                Quantity = 3,
                ResourceCost = 0,
                Text = "Attach to an ally.\r\nAction: Discard Born Aloft from play to return attached ally to its owner's hand.",
                FlavorText = "\"Very well,\" said Gandalf. \"Take us where and as far as you will!\" -The Hobbit",
                CardNumber = 29,
                Artist = Artist.Salvador_Trakal
            });
            Cards.Add(new LotRCard() {
                Title = "Dúnedain Warning",
                Id = "51223bd0-ffd1-11df-a976-0801202c9008",
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Signal." },
                Quantity = 3,
                ResourceCost = 1,
                Text = "Attach to a hero.\r\nAttached hero gains +1 Defense.\r\nAction: Pay 1 resource from attached hero's pool to attach Dunedain Warning to another hero.",
                CardNumber = 26,
                Artist = Artist.Taufiq,
                SecondArtist = Artist.Vicki_Pangestu
            });
            Cards.Add(new LotRCard() {
                Title = "Éomund",
                Id = "51223bd0-ffd1-11df-a976-0801202c9009",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Rohan." },
                Quantity = 3,
                ResourceCost = 3,
                IsUnique = true,
                Attack = 1,
                Defense = 1,
                Willpower = 2,
                HitPoints = 2,
                Text = "Response: After Éomund leaves play, ready all Rohan characters in play.",
                FlavorText = "\"You I have not seen before, for you are young, but I have spoken with Eomund your father...\" -Aragorn, The Two Towers",
                CardNumber = 30,
                Artist = Artist.Katherine_Dinger
            });
            Cards.Add(new LotRCard() {
                Title = "A Burning Brand",
                Id = "51223bd0-ffd1-11df-a976-0801202c9010",
                CardType = CardType.Attachment,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Item." },
                Quantity = 3,
                ResourceCost = 2,
                Text = "Attach to a Lore character.\r\nWhile attached character is defending, cancel any shadow effects on cards dealt to the attacking enemy.",
                FlavorText = "\"Keep close to the fire, with your faces outward!\" cried Strider. \"Keep some of th elonger sticks ready in your hands.\" -The Fellowship of the Ring",
                HtmlTemplate = "<p>Attach to a {sphere-character:Lore}.</p><p>While attached character is defending, cancel any shadow effects on cards dealt to the attacking enemy.</p><p class='flavor-text'>&quot;Keep close to the fire, with your faces outward!&quot; cried Strider. &quot;Keep some of th elonger sticks ready in your hands.&quot;<br>&ndash;The Fellowship of the Ring</p>",
                CardNumber = 33,
                Artist = Artist.Toni_Justamante_Jacobs
            });
            Cards.Add(new LotRCard() {
                
                Title = "Grimbeorn the Old",
                AlternateSlug = "Baby-Bjorn-CatC",
                Id = "51223bd0-ffd1-11df-a976-0801202c9011",
                CardType = CardType.Objective_Ally,
                Traits = new List<string>() { "Ally." },
                Quantity = 1,
                EasyModeQuantity = 1,
                NightmareModeQuantity = 0,
                IsUnique = true,
                Attack = 4,
                Defense = 3,
                Willpower = 2,
                HitPoints = 10,
                Text = 
@"Grimbeorn the Old does not exhaust to defend against Troll enemies.

If Grimbeorn the Old has 8 or more resource tokens on him, he joins the first player as an ally.

Action: Spend 1 Leadership resource to place that resource on Grimbeorn the Old.",
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 37,
                Artist = Artist.Mark_Winters
            });
            Cards.Add(new LotRCard() {
                
                Title = "Grimbeorn's Quest",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801202c9012",
                CardType = CardType.Quest,
                QuestPoints = 7,
                Quantity = 1,
                Text = "Setup: Add The Carrock to the staging area. Remove 4 unique Troll cards and 4 copies of the 'Sacked!' card from the encounter deck and set them aside, out of play. Then shuffle 1 'Sacked!' card per player back into the encounter deck.",
                FlavorText = "While searching for Gollum in the Anduin valley, you recieve word that a group of Trolls have come to the Carrock.",
                OppositeText = "Forced: After placing the 7th progress token on Grimbeorn's Quest, The Carrock becomes the active location. Discard the previous active location from play.",
                OppositeFlavorText = "As this area is under the watch of the Beornings, you seek out their leader, Grimbeorn the Old, and discover he has already set out in a rage. You follow, hoping to find him before he confronts the Trolls.",
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 35,
                Artist = Artist.Igor_Kieryluk,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.JourneyAlongTheAnduin, EncounterSet.Wilderlands }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Longbeard Map-Maker",
                Id = "51223bd0-ffd1-11df-a976-0801202c9014",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 3,
                ResourceCost = 3,
                Attack = 1,
                Defense = 1,
                Willpower = 1,
                HitPoints = 3,
                Text = "Action: Spend 1 Lore resource to give Longbeard Map-Maker +1 Willpower until the end of the phase.",
                FlavorText = "On the table in the light of a big lamp with a red shade he spread a piece of parchment rather like a map. -The Hobbit",
                CardNumber = 32,
                Artist = Artist.Andrew_Silver
            });
            Cards.Add(new LotRCard() {
                
                Title = "Louis",
                Id = "51223bd0-ffd1-11df-a976-0801202c9015",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Troll." },
                Quantity = 1,
                EngagementCost = 34,
                IsUnique = true,
                Attack = 4,
                Defense = 2,
                HitPoints = 10,
                Text = "While Louis is engaged with a player, all Troll enemies gain, \"Forced: After this enemy attacks, the defending player must raise his threat by 3.\"\r\nResponse: After defeating Louis, you may choose and discard 1 \"Sacked!\" card from play.",
                Threat = 2,
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 38,
                Artist = Artist.Brian_Valenzuela
            });
            Cards.Add(new LotRCard() {
                
                Title = "Morris",
                Id = "51223bd0-ffd1-11df-a976-0801202c9016",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Troll." },
                Quantity = 1,
                EngagementCost = 34,
                IsUnique = true,
                Attack = 4,
                Defense = 2,
                HitPoints = 10,
                Text = "While Morris is engaged with a player, all Troll enemies get +1 Attack.\r\nResponse: After defeating Morris, you may choose and discard 1 'Sacked!' card from play.",
                Threat = 2,
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 39,
                Artist = Artist.Paul_Guzenko
            });
            Cards.Add(new LotRCard() {
                
                Title = "Muck Adder",
                Id = "51223bd0-ffd1-11df-a976-0801202c9017",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Creature." },
                Quantity = 4,
                EasyModeQuantity = 2,
                EngagementCost = 20,
                Attack = 2,
                Defense = 0,
                HitPoints = 4,
                Text = "Forced: If Muck Adder damages a character, discard that character from play.",
                Shadow = "Shadow: Defending character gets -1 Defense for the duration of this attack.",
                Threat = 1,
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 42,
                Artist = Artist.Joe_Wilson
            });
            Cards.Add(new LotRCard() {
                
                Title = "Nor am I a Stranger",
                Id = "51223bd0-ffd1-11df-a976-0801202c9018",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Title." },
                Quantity = 3,
                ResourceCost = 1,
                Text = "Attach to a character.\r\nAttached character gains the Rohan trait.",
                FlavorText = "\"Nor indeed am I a stranger: for I have been in this land before, more than once, and ridden with the host of the Rohirrim, though under other name and in other guise.\" -Aragorn, The Two Towers",
                CardNumber = 31,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Oak-wood Grove",
                Id = "51223bd0-ffd1-11df-a976-0801202c9019",
                CardType = CardType.Location,
                Traits = new List<string>() { "Forest." },
                Quantity = 3,
                Text = "While Oak-wood Grove is the active location, resource tokens from any sphere may be spent as Leadership resource tokens.",
                Threat = 2,
                QuestPoints = 1,
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 46,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new LotRCard() {
                
                Title = "River Langflood",
                Id = "51223bd0-ffd1-11df-a976-0801202c9020",
                CardType = CardType.Location,
                Traits = new List<string>() { "Riverland." },
                Quantity = 4,
                EasyModeQuantity = 2,
                Text = "While it is in the staging area, River Langflood gets +1 Threat for each Troll enemy in play.",
                Threat = 2,
                QuestPoints = 3,
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 44,
                Artist = Artist.Marco_Caradonna
            });
            Cards.Add(new LotRCard() {
                
                Title = "Roasted Slowly",
                Id = "51223bd0-ffd1-11df-a976-0801202c9021",
                CardType = CardType.Treachery,
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Destroy all heroes with the card 'Sacked!' attached. Then, shuffle Roasted Slowly back into the encounter deck.",
                Shadow = "Shadow: If attacking enemy is a Troll, remove 2 damage tokens from it.",
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 49,
                Artist = Artist.Diego_Gisbert_Llorens
            });
            Cards.Add(new LotRCard() {
                
                Title = "Rupert",
                Id = "51223bd0-ffd1-11df-a976-0801202c9022",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Troll." },
                Quantity = 1,
                EngagementCost = 34,
                IsUnique = true,
                Attack = 4,
                Defense = 2,
                HitPoints = 10,
                Text = "Forced: After Rupert attacks, shuffle all copies of the 'Sacked!' card from the discard pile back into the encounter deck.\r\nResponse: After defeating Rupert, you may choose and discard 1 'Sacked!' card from play.",
                Threat = 2,
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 41,
                Artist = Artist.Andrew_Silver
            });
            Cards.Add(new LotRCard() {
                
                Title = "Sacked!",
                Id = "51223bd0-ffd1-11df-a976-0801202c9023",
                CardType = CardType.Treachery,
                Quantity = 5,
                EasyModeQuantity = 4,
                Text = "When Revealed: Attach to a hero with no 'Sacked!' cards attached controlled by the first player. (Cannot be canceled.) Counts as a condition attachment with the text: 'Attached hero cannot attack, defend, commit to a quest, trigger its effect, or collect resources.'",
                Shadow = "Shadow: If attacking enemy is a Troll, resolve this card's 'when revealed' effect.",
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 48,
                Artist = Artist.Lorraine_Schleter
            });
            Cards.Add(new LotRCard() {
                
                Title = "Second Breakfast",
                Id = "51223bd0-ffd1-11df-a976-0801202c9024",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Action: Each player returns the topmost attachment card from his discard pile to his hand.",
                FlavorText = "...he was just sitting down to a nice little second-breakfast in the dinning-room...\r\n-The Hobbit",
                CardNumber = 27,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Song of Wisdom",
                Id = "51223bd0-ffd1-11df-a976-0801202c9025",
                CardType = CardType.Attachment,
                Sphere = Sphere.Neutral,
                Traits = new List<string>() { "Song." },
                Quantity = 3,
                ResourceCost = 1,
                Text = "Attach to a hero.\r\nAttached hero gains a Lore resource icon.",
                FlavorText = "It sit beside the fire and think\r\nof all that I have seen,\r\nof meadow-flowers and butterflies\r\nin summers that have been\r\n-The Fellowship of the Ring",
                CardNumber = 34,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Stuart",
                Id = "51223bd0-ffd1-11df-a976-0801202c9026",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Troll." },
                Quantity = 1,
                EngagementCost = 34,
                IsUnique = true,
                Attack = 4,
                Defense = 2,
                HitPoints = 10,
                Text = "While Stuart is engaged with a player, all Troll enemies get +1 Defense.\r\nResponse: After defeating Stuart, you may choose and discard 1 'Sacked!' card from play.",
                Threat = 2,
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 40,
                Artist = Artist.Paul_Guzenko
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Carrock",
                Id = "51223bd0-ffd1-11df-a976-0801202c9027",
                CardType = CardType.Location,
                Traits = new List<string>() { "Riverland." },
                Quantity = 1,
                IsUnique = true,
                Text = "Immune to player card effects.\r\nPlayers cannot travel to The Carrock except through quest card effects.While The Carrock is the active location, Troll enemies get +1 Attack and +1 Defense.",
                Threat = 2,
                QuestPoints = 6,
                EncounterSet = "Conflict at the Carrock",
                CardNumber = 43,
                Artist = Artist.Marco_Caradonna
            });
        }
    }
}
