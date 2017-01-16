using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheHillsofEmynMuil : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Hills of Emyn Muil";
            Abbreviation = "THoEM";
            Number = 5;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Shadows of Mirkwood";

            addCard(new LotRCard() {
                Title = "Amon Hen",
                Id = "51223bd0-ffd1-11df-a976-0801204c9001",
                CardType = CardType.Location,
                Quantity = 1,
                IsUnique = true,
                Text = "X is double the number of players in the game.\r\nWhile Amon Hen is the active location, players cannot play events.",
                Threat = Card.VALUE_X,
                QuestPoints = 5,
                EncounterSet = "The Hills of Emyn Muil",
                VictoryPoints = 5,
                CardNumber = 83,
                Artist = Artist.Vincent_Proce
            }.WithTraits("Emyn Muil."));
            Cards.Add(new LotRCard() {
                Title = "Amon Lhaw",
                Id = "51223bd0-ffd1-11df-a976-0801204c9002",
                CardType = CardType.Location,
                Traits = new List<string>() { "Emyn Muil." },
                Quantity = 1,
                IsUnique = true,
                Text = "X is double the number of players in the game.\r\nWhile Amon Lhaw is the active location, treat all attachments as if their printed text boxes were blank.",
                Threat = Card.VALUE_X,
                QuestPoints = 5,
                EncounterSet = "The Hills of Emyn Muil",
                VictoryPoints = 5,
                CardNumber = 84,
                Artist = Artist.Vincent_Proce
            });
            Cards.Add(new LotRCard() {
                Title = "Brand son of Bain",
                Id = "51223bd0-ffd1-11df-a976-0801204c9003",
                CardType = CardType.Hero,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Dale." },
                Quantity = 1,
                ThreatCost = 10,
                IsUnique = true,
                Attack = 3,
                Defense = 2,
                Willpower = 2,
                HitPoints = 3,
                Text = "Response: After Brand son of Bain attacks and defeats an enemy engaged with another player, choose and ready one of that player's characters.",
                FlavorText = "\"The grandson of Bard the Bowman rules them, Brand son of Bain son of Bard.\"\r\n-Glóin, The Fellowship of the Ring", 
                Keywords = new List<string>() { "Ranged." },
                CardNumber = 72,
                Artist = Artist.Tiziano_Baracchi
            });
            Cards.Add(new LotRCard() {
                
                Title = "Descendant of Thorondor",
                Id = "51223bd0-ffd1-11df-a976-0801204c9004",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Creature.", " Eagle." },
                Quantity = 3,
                ResourceCost = 4,
                Attack = 2,
                Defense = 1,
                Willpower = 1,
                HitPoints = 2,
                Text = "Descendant of Thorondor cannot have restricted attachments.\r\nResponse: After Descendant of Thorondor enters or leaves play, deal 2 damage to any 1 enemy in the staging area.",
                CardNumber = 75,
                Artist = Artist.Igor_Kieryluk
            });
            Cards.Add(new LotRCard() {
                
                Title = "Gildor Inglorion",
                Id = "51223bd0-ffd1-11df-a976-0801204c9005",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Noldor." },
                Quantity = 3,
                ResourceCost = 5,
                IsUnique = true,
                Attack = 2,
                Defense = 3,
                Willpower = 3,
                HitPoints = 3,
                Text = "Action: Exhaust Gildor Inglorion to look at the top 3 cards of your deck. Switch one of those cards with a card from your hand. Then, return the 3 cards to the top of your deck, in any order.",
                FlavorText = "\"Go not to the Elves for counsel, for they will say both no and yes.\" -Frodo Baggins, The Fellowship of the Ring",
                CardNumber = 79,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Gildor's Counsel",
                Id = "51223bd0-ffd1-11df-a976-0801204c9006",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 3,
                Text = "Play during the Quest phase, before characters are committed to the Quest.\r\nAction: Reveal 1 less card from the encounter deck this phase. (To a minimum of 1.)",
                FlavorText = "\"The wide world is all about you: you can fence yourselves in, but you cannot for ever fence it out.\"\r\n-Gildor, The Fellowship of the Ring",
                CardNumber = 80,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Impassable Chasm",
                Id = "51223bd0-ffd1-11df-a976-0801204c9007",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Hazard." },
                Quantity = 4,
                EasyModeQuantity = 2,
                Text = "When Revealed: If there is an active location, remove all progress tokens from that location and return it to the staging area. If no location is moved by this effect, this card gains surge.",
                EncounterSet = "The Hills of Emyn Muil",
                CardNumber = 91,
                Artist = Artist.Noah_Bradley
            });
            Cards.Add(new LotRCard() {
                
                Title = "Keen-eyed Took",
                Id = "51223bd0-ffd1-11df-a976-0801204c9008",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Hobbit." },
                Quantity = 3,
                ResourceCost = 2,
                Attack = 0,
                Defense = 0,
                Willpower = 1,
                HitPoints = 2,
                Text = "Response: After Keen-eyed Took enters play, reveal the top card of each player's deck.\r\nAction: Return Keen-eyed Took to your hand to discard the top card of each player's deck.",
                FlavorText = "Then something Tookish woke up inside him...\r\n-The Hobbit",
                CardNumber = 73,
                Artist = Artist.Anna_Mohrbacher
            });
            Cards.Add(new LotRCard() {
                
                Title = "Meneldor's Flight",
                Id = "51223bd0-ffd1-11df-a976-0801204c9009",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Action: Choose an Eagle ally. Return that character to its owner's hand.",
                FlavorText = "Not event an eagle poised against the sun would have marked the hobbits sitting there, under the weight of doom...\r\n-The Two Towers",
                CardNumber = 76,
                Artist = Artist.A_M_Sartor
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc Horse Thieves",
                Id = "51223bd0-ffd1-11df-a976-0801204c9010",
                CardType = CardType.Enemy,
                Traits = new List<string>() { "Mordor.", " Orc." },
                Quantity = 3,
                EasyModeQuantity = 2,
                EngagementCost = 35,
                Attack = 1,
                Defense = 2,
                HitPoints = 6,
                Text = "Orc Horse Thieves get +1 Attack for each location in the staging area.",
                HtmlTemplate = "<p>{self} get +1 {Attack} for each location in the staging area.</p>",
                Keywords = new List<string>() { "Doomed 2." },
                Threat = 3,
                EncounterSet = "The Hills of Emyn Muil",
                CardNumber = 94,
                Artist = Artist.Brian_Valenzuela
            });
            Cards.Add(new LotRCard() {
                
                Title = "Rauros Falls",
                Id = "51223bd0-ffd1-11df-a976-0801204c9011",
                CardType = CardType.Location,
                Traits = new List<string>() { "Emyn Muil." },
                Quantity = 2,
                Text = "While Rauros Falls is the active location, all characters must commit to the current quest during the quest phase.",
                Shadow = "Shadow: After this attack resolves, return attacking enemy to the staging area.",
                Threat = 2,
                QuestPoints = 4,
                EncounterSet = "The Hills of Emyn Muil",
                VictoryPoints = 3,
                CardNumber = 87,
                Artist = Artist.Aaron_B_Miller
            });
            Cards.Add(new LotRCard() {
                
                Title = "Rear Guard",
                Id = "51223bd0-ffd1-11df-a976-0801204c9012",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Quest Action: Discard a Leadership ally to give each hero committed to this quest +1 Willpower until the end of the phase.",
                FlavorText = "In the dark at the rear, grim and silent, walked Aragorn.\r\n-The Fellowship of the Ring",
                CardNumber = 74,
                Artist = Artist.Lin_Bo
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ride to Ruin",
                Id = "51223bd0-ffd1-11df-a976-0801204c9013",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Action: Discard a Rohan ally to choose a location. Place 3 progress tokens on that location.",
                FlavorText = "\"Death! Ride, ride to ruin and the world's ending!\"\r\n-Éomer, The Return of the King",
                CardNumber = 78,
                Artist = Artist.Erfian_Asafat
            });
            Cards.Add(new LotRCard() {
                
                Title = "Rockslide",
                Id = "51223bd0-ffd1-11df-a976-0801204c9014",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Hazard." },
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "When Revealed: Deal 2 damage to each character committed to this quest.",
                Shadow = "Shadow: Remove defending character from combat. This attack is considered undefended.",
                EncounterSet = "The Hills of Emyn Muil",
                CardNumber = 92,
                Artist = Artist.Stu_Barnes
            });
            Cards.Add(new LotRCard() {
                
                Title = "Slick Footing",
                Id = "51223bd0-ffd1-11df-a976-0801204c9015",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Hazard." },
                Quantity = 3,
                Text = "When Revealed: Remove 1 progress token from each location in play. Then, discard the top card of each player's deck for each progress token removed by this effect.",
                EncounterSet = "The Hills of Emyn Muil",
                CardNumber = 93,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Song of Travel",
                Id = "51223bd0-ffd1-11df-a976-0801204c9016",
                CardType = CardType.Attachment,
                Sphere = Sphere.Neutral,
                Traits = new List<string>() { "Song." },
                Quantity = 3,
                ResourceCost = 1,
                Text = "Attach to a hero.\r\nAttached hero gains a Spirit resource icon.",
                FlavorText = "The Road goes ever on and on\r\nDown from the door where it began.\r\nNow far ahead the road has gone,\r\nAnd I must follow, if I can.\r\n-The Fellowship of the Ring",
                CardNumber = 81,
                Artist = Artist.Tiziano_Baracchi
            });
            Cards.Add(new LotRCard() {
                
                Title = "The East Wall of Rohan",
                Id = "51223bd0-ffd1-11df-a976-0801204c9017",
                CardType = CardType.Location,
                Traits = new List<string>() { "Emyn Muil." },
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "While The East Wall of Rohan is the active location, non-Rohan characters cost 2 additional matching resources to play.",
                HtmlTemplate = "<p>While {self} is the active location, non-{trait:Rohan.@Rohan} characters cost 2 additional matching resources to play.</p>{victory:3}",
                Threat = 4,
                QuestPoints = 2,
                EncounterSet = "The Hills of Emyn Muil",
                VictoryPoints = 3,
                CardNumber = 85,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Highlands",
                Id = "51223bd0-ffd1-11df-a976-0801204c9018",
                CardType = CardType.Location,
                Traits = new List<string>() { "Emyn Muil." },
                Quantity = 4,
                Text = "Travel: In order to travel to The Highlands, the players must reveal the top card of the encounter deck, and add it to the staging area.",
                HtmlTemplate = "<p><b>Travel:</b> In order to travel to {self}, the players must reveal the top card of the encounter deck, and add it to the staging area.</p>{victory:1}",
                Threat = 1,
                QuestPoints = 1,
                EncounterSet = "The Hills of Emyn Muil",
                VictoryPoints = 1,
                CardNumber = 90,
                Artist = Artist.Bill_Corbett
            });
            Cards.Add(new LotRCard() {
                Title = "The Hills of Emyn Muil",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801204c9019",
                CardType = CardType.Quest,
                QuestPoints = 1,
                Quantity = 1,
                Text = "Setup: Search the encounter deck for Amon Hen and Amon Lhaw, and add them to the staging area. Then shuffle the encounter deck.",
                FlavorText = "The hunt for Gollum has led you to the south, and you are now approaching Rauros falls and the nearby hills of Emyn Muil...",
                OppositeFlavorText = "You are certain that Gollum has fled into the area, and you must explore until you find the fresh trail.",
                OppositeText = "Forced: If there are no location cards in the staging area, the first treachery card revealed during the quest phase gains surge.\r\nPlayers cannot defeat this stage until there are no Emyn Muil locations in play, and they have collected at least 20 victory points.",
                EncounterSet = "The Hills of Emyn Muil",
                CardNumber = 82,
                Artist = Artist.Igor_Kieryluk,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DolGuldurOrcs, EncounterSet.SauronsReach }
            });
            Cards.Add(new LotRCard() {
                
                Title = "The North Stair",
                Id = "51223bd0-ffd1-11df-a976-0801204c9021",
                CardType = CardType.Location,
                Traits = new List<string>() { "Emyn Muil." },
                Quantity = 2,
                Text = "Forced: After traveling to The North Stair, move the top card of the encounter discard pile to the staging area. Resolve any 'when revealed' effects on that card.",
                HtmlTemplate = "<p><b>Forced:</b> After traveling to The North Stair, move the top card of the encounter discard pile to the staging area. Resolve any &quot;when revealed&quot; effects on that card.</p>{victory:3}",
                Threat = 3,
                QuestPoints = 3,
                EncounterSet = "The Hills of Emyn Muil",
                VictoryPoints = 3,
                CardNumber = 86,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Outer Ridge",
                Id = "51223bd0-ffd1-11df-a976-0801204c9022",
                CardType = CardType.Location,
                Traits = new List<string>() { "Emyn Muil." },
                Quantity = 3,
                Text = "While The Outer Ridge is the active location, each location in the staging area gets +1 Threat.",
                Shadow = "Shadow: After this attack resolves, return attacking enemy to the staging area.",
                Threat = 2,
                QuestPoints = 2,
                EncounterSet = "The Hills of Emyn Muil",
                VictoryPoints = 2,
                CardNumber = 89,
                Artist = Artist.Lin_Bo
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Riddermark's Finest",
                Id = "51223bd0-ffd1-11df-a976-0801204c9023",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Creature.", " Rohan." },
                Quantity = 3,
                ResourceCost = 2,
                Attack = 1,
                Defense = 0,
                Willpower = 1,
                HitPoints = 2,
                Text = "Action: Exhaust and discard The Riddermark's Finest to place 2 progress tokens on any location.",
                FlavorText = "\"And there are no horses like the ones that are bred in that great vale between the Misty Mountains and the White.\"\r\n-Gandalf, The Fellowship of the Ring",
                CardNumber = 77,
                Artist = Artist.Andrew_Johanson
            });
            Cards.Add(new LotRCard() {
                
                Title = "The Shores of Nen Hithoel",
                Id = "51223bd0-ffd1-11df-a976-0801204c9024",
                CardType = CardType.Location,
                Traits = new List<string>() { "Emyn Muil." },
                Quantity = 3,
                Text = "Travel: The first player must discard 1 event card from his hand to travel to this location.",
                Shadow = "Shadow: After this attack resolves, return attacking enemy to the staging area.",
                HtmlTemplate = "<p><b>Travel:</b> The first player must discard 1 {type:event} card from his hand to travel to this location.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> After this attack resolves, return attacking enemy to the staging area.</p>{victory:2}",
                Threat = 2,
                QuestPoints = 2,
                EncounterSet = "The Hills of Emyn Muil",
                VictoryPoints = 2,
                CardNumber = 88,
                Artist = Artist.Lin_Bo
            });
        }
    }
}
