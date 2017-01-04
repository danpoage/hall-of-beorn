using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheHuntforGollum : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Hunt for Gollum";
            Abbreviation = "THfG";
            Number = 2;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Shadows of Mirkwood";

            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Bilbo Baggins",
                Id = "51223bd0-ffd1-11df-a976-0801201c9001",
                CardType = CardType.Hero,
                Sphere = Sphere.Lore,
                ThreatCost = 9,
                IsUnique = true,
                Attack = 1,
                Defense = 2,
                Willpower = 1,
                HitPoints = 2,
                Traits = new List<string>() { "Hobbit." },
                Text = "The first player draws 1 additional card in the resource phase.",
                FlavorText = "\"Well, my dear fellow,\" said bilbo, \"now you've heard the news, can't you spare me a moment? I want your help in something urgent.\" -The Fellowship of the Ring",
                HtmlTemplate = "<p>The first player draws 1 additional card in the resource phase.</p><p class='flavor-text'>&quot;Well, my dear fellow,&quot; said Bilbo, &quot;now you've heard the news, can't you spare me a moment? I want your help in something urgent.&quot;<br>&ndash;The Fellowship of the Ring</p>",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Tony_Foti
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Dúnedain Mark",
                Id = "51223bd0-ffd1-11df-a976-0801201c9002",
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Traits = new List<string>() { "Signal." },
                Text = "Attach to a hero.\r\nAttached hero gains +1 Attack.\r\nAction: Pay 1 resource from attached hero's pool to attach Dunedain Mark to another hero.",
                Quantity = 3,
                CardNumber = 2,
                Artist = Artist.Joko_Mulyono,
                SecondArtist = Artist.Lius_Lasahido
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Campfire Tales",
                Id = "51223bd0-ffd1-11df-a976-0801201c9003",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 1,
                Text = "Action: Each player draws 1 card.",
                FlavorText = "\"It is a fair tale, though it is sad, as are all the tales of Middle-earth, and yet it may lift up your hearts.\" -Strider, The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 3,
                Artist = Artist.Felicia_Cano
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Mustering the Rohirrim",
                Id = "51223bd0-ffd1-11df-a976-0801201c9004",
                CardType = CardType.Event,
                Sphere = Sphere.Spirit,
                ResourceCost = 1,
                Text = "Action: Search the top 10 cards of your deck for any 1 Rohan ally card and add it to your hand. Then, shuffle the other cards back into your deck.",
                FlavorText = "\"More speed we cannot make, if the strength of Rohan is to be gathered.\" -Éomer, The Return of the King",
                Quantity = 3,
                CardNumber = 7,
                Artist = Artist.Stu_Barnes
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Rivendell Minstrel",
                Id = "51223bd0-ffd1-11df-a976-0801201c9005",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 3,
                Attack = 0,
                Defense = 0,
                Willpower = 2,
                HitPoints = 1,
                Traits = new List<string>() { "Noldor." },
                Text = "Response: After you play Rivendell Minstrel from your hand, search your deck for 1 Song card and add it to your hand. Shuffle your deck.",
                FlavorText = "As Elrond entered and went towards the seat prepared for him, Elvish minstrels began to make sweet music. -The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 8,
                Artist = Artist.Katherine_Dinger
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Song of Kings",
                Id = "51223bd0-ffd1-11df-a976-0801201c9006",
                CardType = CardType.Attachment,
                Sphere = Sphere.Neutral,
                ResourceCost = 1,
                Traits = new List<string>() { "Song." },
                Text = "Attach to a hero.\r\nAttached hero gains a Leadership resource icon.",
                FlavorText = 
@"From the ashes a fire shall be woken,
A light from the shadows shall spring: 
Renewed shall be blade that was broken,
The crownless again shall be king.
-The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 10,
                Artist = Artist.John_Gravato
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Strider's Path",
                Id = "51223bd0-ffd1-11df-a976-0801201c9007",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Text = "Response: After a location is revealed from the encounter deck, immediately travel to that location without resolving its Travel effect. If another location is currently active, return it to the staging area.",
                FlavorText = "\"My cuts, short or long, don't go wrong.\" -Strider, The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 9,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "The Eagles Are Coming!",
                Id = "51223bd0-ffd1-11df-a976-0801201c9008",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 0,
                Traits = new List<string>() { "Eagle." },
                Text = "Action: Search the top 5 cards of your deck for any number of Eagle cards and add them to your hand. Shuffle the other cards back into your deck.",
                FlavorText = "\"The Eagles! The Eagles!\" -Bilbo Baggins, The Hobbit",
                Quantity = 3,
                CardNumber = 5,
                Artist = Artist.Jake_Murray
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Westfold Horse-Breaker",
                Id = "51223bd0-ffd1-11df-a976-0801201c9009",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                ResourceCost = 2,
                Attack = 0,
                Defense = 1,
                Willpower = 1,
                HitPoints = 1,
                Traits = new List<string>() { "Rohan." },
                Text = "Action: Discard Westfold Horse-Breaker to choose and ready a hero.",
                FlavorText = "\"Your own valour has done more, and the stout legs of the Westfold-men marching through the night.\" -Gandalf, The Two Towers",
                Quantity = 3,
                CardNumber = 6,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Winged Guardian",
                Id = "51223bd0-ffd1-11df-a976-0801201c9010",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                ResourceCost = 2,
                Attack = 0,
                Defense = 4,
                Willpower = 0,
                HitPoints = 1,
                Traits = new List<string>() { "Creature.", " Eagle." },
                Text = "Winged Guardian cannot have restricted attachments.Forced: After an attack in which Winged Guardian defends resolves, pay 1 Tactics resource or discard Winged Guardian from play.",
                Keywords = new List<string>() { "Sentinel." },
                Quantity = 3,
                CardNumber = 4,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "False Lead",
                Id = "51223bd0-ffd1-11df-a976-0801201c9011",
                CardType = CardType.Treachery,
                Text = "When Revealed: The first player chooses and shuffles a card with the printed Clue trait back into the encounter deck. If there are no Clue cards in play, False Lead gains surge.",
                EncounterSet = "The Hunt for Gollum",
                Quantity = 2,
                CardNumber = 22,
                Artist = Artist.Even_Mehl_Amundsen
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Flooding",
                Id = "51223bd0-ffd1-11df-a976-0801201c9012",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Disaster." },
                Text = "When Revealed: Remove all progress tokens from all Riverland locations.",
                Shadow = "Shadow: Resolve the 'when revealed' effect of this card.",
                Keywords = new List<string>() { "Doomed 1.", " Surge." },
                EncounterSet = "The Hunt for Gollum",
                Quantity = 2,
                CardNumber = 23,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Goblintown Scavengers",
                Id = "51223bd0-ffd1-11df-a976-0801201c9013",
                CardType = CardType.Enemy,
                EngagementCost = 12,
                Attack = 1,
                Defense = 0,
                HitPoints = 3,
                Traits = new List<string>() { "Goblin.", " Orc." },
                Text = "When Revealed: Discard the top card of each player's deck. Until the end of the phase, increase Goblintown Scavenger's Threat by the total printed cost of all cards discarded in this way.",
                Threat = 1,
                EncounterSet = "The Hunt for Gollum",
                Quantity = 2,
                EasyModeQuantity = 1,
                CardNumber = 20,
                Artist = Artist.Jarreau_Wimberly
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Hunters from Mordor",
                Id = "51223bd0-ffd1-11df-a976-0801201c9014",
                CardType = CardType.Enemy,
                EngagementCost = 34,
                Attack = 2,
                Defense = 2,
                HitPoints = 6,
                Traits = new List<string>() { "Mordor." },
                Text = "Hunters from Mordor get +2 Attack and +2 Threat for each Clue card in play.",
                Shadow = "Shadow: Deal 1 damage to each hero with a Clue card attached. (3 damage instead if this attack is undefended.)",
                Threat = 2,
                EncounterSet = "The Hunt for Gollum",
                Quantity = 5,
                EasyModeQuantity = 2,
                CardNumber = 21,
                Artist = Artist.Igor_Kieryluk
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Old Wives' Tales",
                Id = "51223bd0-ffd1-11df-a976-0801201c9015",
                CardType = CardType.Treachery,
                Traits = new List<string>() { "Gossip." },
                Text = "When Revealed: Discard 1 resource from each hero's resource pool, if able. Exhaust any hero that could not discard a resource from its pool.",
                EncounterSet = "The Hunt for Gollum",
                Quantity = 3,
                EasyModeQuantity = 1,
                CardNumber = 24,
                Artist = Artist.Brian_Valenzuela
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "River Ninglor",
                Id = "51223bd0-ffd1-11df-a976-0801201c9016",
                CardType = CardType.Location,
                Traits = new List<string>() { "Riverland." },
                Text = "While River Ninglor is the active location, remove 1 progress token from it and from the current quest at the end of each round.",
                Shadow = "Shadow: Remove 1 progress token from the current quest. (2 progress tokens instead if this attack is undefended.)",
                HtmlTemplate = "<p>While {self} is the active location, remove 1 progress token from it and from the current quest at the end of each round.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Remove 1 progress token from the current quest. (2 progress tokens instead if this attack is undefended.)</p>",
                Threat = 2,
                QuestPoints = 4,
                EncounterSet = "The Hunt for Gollum",
                Quantity = 2,
                CardNumber = 17,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "Signs of Gollum",
                Id = "51223bd0-ffd1-11df-a976-0801201c9017",
                CardType = CardType.Objective,
                Traits = new List<string>() { "Clue." },
                Text = "Response: After the players quest successfully, the players may claim Signs of Gollum if it has no attached encounters. When claimed, attach Signs of Gollum to any hero committed to the quest. (Counts as a Condition attachment with: 'Forced: After attached hero is damaged or leaves play, return this card to the top of the encounter deck.')",
                Keywords = new List<string>() { "Guarded." },
                EncounterSet = "The Hunt for Gollum",
                Quantity = 4,
                CardNumber = 14,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "The East Bank",
                Id = "51223bd0-ffd1-11df-a976-0801201c9018",
                CardType = CardType.Location,
                Traits = new List<string>() { "Riverland." },
                Text = "While The East Bank is the active location, ally cards cost 1 additional matching resource to play from hand.",
                Shadow = "Shadow: If you do not control at least 1 hero with a Clue card attached, return this enemy to the staging area after its attack resolves.",
                Threat = 3,
                QuestPoints = 3,
                EncounterSet = "The Hunt for Gollum",
                Quantity = 2,
                CardNumber = 18,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "The Eaves of Mirkwood",
                Id = "51223bd0-ffd1-11df-a976-0801201c9019",
                CardType = CardType.Location,
                Traits = new List<string>() { "Forest." },
                Text = "While The Eaves of Mirkwood is the active location, encounter card effects cannot be canceled.",
                FlavorText = "By the afternoon they had reached the eaves of Mirkwood, and were resting almost beneath the great overhanging boughs of its outer trees. -The Hobbit",
                Threat = 2,
                QuestPoints = 2,
                EncounterSet = "The Hunt for Gollum",
                Quantity = 3,
                CardNumber = 16,
                Artist = Artist.Timo_Karhula
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "The Old Ford",
                Id = "51223bd0-ffd1-11df-a976-0801201c9020",
                CardType = CardType.Location,
                Traits = new List<string>() { "Riverland." },
                Text = "X is the number of ally cards in play.",
                Shadow = "Shadow: Discard from play all allies with a printed cost lower than the number of Riverland locations in play.",
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = 2,
                EncounterSet = "The Hunt for Gollum",
                Quantity = 2,
                EasyModeQuantity = 0,
                CardNumber = 15,
                Artist = Artist.Timo_Karhula
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "The West Bank",
                Id = "51223bd0-ffd1-11df-a976-0801201c9021",
                CardType = CardType.Location,
                Traits = new List<string>() { "Riverland." },
                Text = "While The West Bank is the active location, attachment and event cards cost 1 additional matching resource to play from hand.",
                Shadow = "Shadow: If you do not control at least 1 hero with a Clue card attached, double this enemy's base Attack for this attack.",
                Threat = 3,
                QuestPoints = 3,
                EncounterSet = "The Hunt for Gollum",
                Quantity = 2,
                CardNumber = 19,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "The Hunt Begins",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801201c9022",
                CardType = CardType.Quest,
                QuestPoints = 8,
                Text = "Setup: Reveal 1 card per player from the encounter deck, and add it to the staging area.",
                FlavorText = "Gandalf has requested your assistance in the search for the elusive creature known as Gollum. Your search begins in the Anduin Valley between Mirkwood Forest and the Misty Mountains",
                OppositeText = "Forced: After the players quest successfully, the first player looks at the top 3 card fo the encounter deck. Reveal and add 1 of those cards to the staging area, and discard the other 2 cards.",
                OppositeFlavorText = "You make your way along the banks of the Anduin River, a likely place for Gollum to find food.",
                EncounterSet = "The Hunt for Gollum",
                Quantity = 1,
                CardNumber = 11,
                Artist = Artist.Igor_Kieryluk,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.JourneyAlongTheAnduin, EncounterSet.SauronsReach }
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "A New Terror Abroad",
                StageNumber = 2,
                QuestPoints = 10,
                Id = "51223bd0-ffd1-11df-a976-0801201c9024",
                CardType = CardType.Quest,
                EncounterSet = "The Hunt for Gollum",
                FlavorText = "The wood was full of the rumor of him, dreadful tales even among beasts and birds. The Woodmen said that there was some new terror abroad, a ghost that drank blood. -The Fellowship of the Ring",
                OppositeText = "Forced: At the beginning of the quest phase, the first player looks at the top 2 cards of the encounter deck. Reveal and add 1 of those cards to the staging area, and discard the other.",
                OppositeFlavorText = "Rumors have led you to the eaves of Mirkwood Forest, where the Woodmen whisper of a new terror in the night...",
                Quantity = 1,
                CardNumber = 12,
                Artist = Artist.David_A_Nash,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.JourneyAlongTheAnduin, EncounterSet.SauronsReach }
            });
            Cards.Add(new LotRCard() {
                ImageType = Models.ImageType.Jpg,
                Title = "On the Trail",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-0801201c9026",
                CardType = CardType.Quest,
                QuestPoints = 8,
                EncounterSet = "The Hunt for Gollum",
                FlavorText = "\"But at the western edge of Mirkwood the trail turned away. It wandered off southwards and passed out of the Wood-elves' ken, and was lost.\" -Gandalf, The Fellowship of the Ring",
                OppositeText = "Any player who does not control a hero with at least 1 Clue objective attached cannot commit characters to this quest. If there are ever no heroes with Clue objectives attached in play, reset the quest deck to stage 2B.\r\nIf the players defeat this stage, the players have once again found a true sign of Gollum's passing, and have won the game.",
                Quantity = 1,
                CardNumber = 13,
                Artist = Artist.Carolina_Eade,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.JourneyAlongTheAnduin, EncounterSet.SauronsReach }
            });
        }
    }
}
