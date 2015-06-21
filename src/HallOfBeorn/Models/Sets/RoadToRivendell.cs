using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.Sets
{
    public class RoadtoRivendell : CardSet
    {
        protected override void Initialize()
        {
            Name = "Road to Rivendell";
            Abbreviation = "RtR";
            Number = 10;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dwarrowdelf";

            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Along the Misty Mountains",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801209c9001",
                CardType = CardType.Quest,
                EncounterSet = "Road to Rivendell",
                Quantity = 1,
                QuestPoints = 20,
                Text = "Setup: Put Arwen Undómiel into play under the control of the first player. Shuffle the encounter deck. Reveal 1 card from the encounter deck per player, and add them to the staging area.",
                FlavorText = "This is a wild and perilous country, and it is dangerous to follow the roads. The mountains rise up on the right, impassively watching your slow trek among their foothills.",
                Number = 38,
                Artist = Artist.Ben_Zweifel,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountains, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Approaching Rivendell",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-0801209c9003",
                CardType = CardType.Quest,
                EncounterSet = "Road to Rivendell",
                Quantity = 1,
                QuestPoints = 13,
                OppositeText = "When Revealed: Reveal 1 card from the encounter deck per player, and add it to the staging area.\r\nCharacters cannot be healed.\r\nIf the players defeat this stage, they have won the game.",
                FlavorText = "Orcs and other creatures have hounded you since fighting your way free of the orc outpost. Soon you will reach the safety of Rivendell's borders, but supplies have dwindled and you are dead weary from sleepless nights of keeping watch, as dark forms shadow your camp.",
                Number = 40,
                Artist = Artist.Noah_Bradley,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountains, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Arwen Undómiel",
                NormalizedTitle = "Arwen Undomiel",
                Id = "51223bd0-ffd1-11df-a976-0801209c9005",
                CardType = CardType.Objective_Ally,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Noldor.", " Noble.", " Ally." },
                Quantity = 1,
                IsUnique = true,
                Attack = 0,
                Defense = 1,
                Willpower = 2,
                HitPoints = 2,
                Text = "The first player gains control of Arwen Undómiel, as an ally.Response: After Arwen Undómiel exhausts, choose a hero. Add 1 resource to that hero's resource pool.\r\n\r\nIf Arwen Undómiel leaves play, the players are defeated.",
                HtmlTemplate = "<p>The first player gains control of {self}, as an ally.</p><p><b>Response:</b> After {self}, choose a hero. Add 1 resource to that hero's resource pool.</p><p><b>If {self} leaves play, the players are defeated.</b></p>",
                Number = 41,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Barren Hills",
                Id = "51223bd0-ffd1-11df-a976-0801209c9006",
                CardType = CardType.Location,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Hills." },
                Quantity = 2,
                Text = "While Barren Hills is the active location, ignore ambush.",
                Shadow = "Shadow: Return attacking enemy to the staging area after it attacks.",
                Threat = 2,
                QuestPoints = 4,
                Number = 45,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Bombur",
                Id = "51223bd0-ffd1-11df-a976-0801209c9007",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                Traits = new List<string>() { "Dwarf." },
                Quantity = 3,
                ResourceCost = 3,
                IsUnique = true,
                Attack = 0,
                Defense = 1,
                Willpower = 0,
                HitPoints = 3,
                Text = "Action: Exhaust Bombur to choose a location. That location gets -1 Threat until the end of the phase. (That location does not contribute its Threat instead if it is an Underground location.)",
                Number = 35,
                Artist = Artist.Winona_Nelson
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Crebain",
                Id = "51223bd0-ffd1-11df-a976-0801209c9008",
                CardType = CardType.Enemy,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Creature." },
                Quantity = 3,
                EngagementCost = 35,
                Attack = 0,
                Defense = 0,
                HitPoints = 3,
                Text = "While Crebain is in the staging area, encounter card effects cannot be canceled.",
                Shadow = "Shadow: Return attacking enemy to the staging area after it attacks.",
                Keywords = new List<string>() { "Surge." },
                Threat = 2,
                Number = 51,
                Artist = Artist.Allison_Theus
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Dúnedain Wanderer",
                NormalizedTitle = "Dunedain Wanderer",
                Id = "51223bd0-ffd1-11df-a976-0801209c9009",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Dúnedain.", " Ranger." },
                NormalizedTraits = new List<string> { "Dunedain." },
                Quantity = 3,
                ResourceCost = 5,
                Attack = 2,
                Defense = 2,
                Willpower = 1,
                HitPoints = 2,
                Keywords = new List<string>() { "Ranged.", " Sentinel.", " Secrecy 3." },
                Number = 29,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Elladan",
                Id = "51223bd0-ffd1-11df-a976-0801209c9010",
                CardType = CardType.Hero,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Noldor.", " Noble.", " Ranger." },
                Quantity = 1,
                ThreatCost = 10,
                IsUnique = true,
                Attack = 1,
                Defense = 2,
                Willpower = 2,
                HitPoints = 4,
                Text = "While Elrohir is in play, Elladan gets +2 Attack.\r\nResponse: After Elladan is declared as an attacker, pay 1 resource from his resource pool to ready him.",
                HtmlTemplate = "<p>While {title:Elrohir} is in play, {self} gets +2 {Attack}.</p><p><b>Response:</b> After {self} is declared as an attacker, pay 1 resource from his resource pool to ready him.</p><p style='text-align:center;'><i>&quot;Yes, the Dead ride behind.&quot;<br>&ndash;The Return of the King</i></p>",
                Number = 28,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Followed by Night",
                Id = "51223bd0-ffd1-11df-a976-0801209c9011",
                CardType = CardType.Treachery,
                EncounterSet = "Road to Rivendell",
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "When Revealed: The first player (choose 1): deals 1 damage to all allies in play and Followed by Night gains surge, or all enemies engaged with players make an immediate attack, if able.",
                Shadow = "Shadow: Return attacking enemy to the staging area after it attacks.",
                Number = 47,
                Artist = Artist.Jasper_Sandner
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Goblin Gate",
                Id = "51223bd0-ffd1-11df-a976-0801209c9012",
                CardType = CardType.Location,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Gate." },
                Quantity = 1,
                Text = "While Goblin Gate is the active location, the first enemy revealed from the encounter deck each round gains ambush. If that enemy engages a player, it makes an immediate attack (deal and resolve a shadow card).",
                Threat = 5,
                QuestPoints = 4,
                Number = 43,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Goblin Taskmaster",
                Id = "51223bd0-ffd1-11df-a976-0801209c9013",
                CardType = CardType.Enemy,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Goblin.", " Orc." },
                Quantity = 4,
                EngagementCost = 27,
                Attack = 2,
                Defense = 2,
                HitPoints = 4,
                Text = "Forced: After Goblin Taskmaster engages a player, that player deals 2 damage to 1 character he controls.",
                Keywords = new List<string>() { "Ambush." },
                Threat = 2,
                Number = 49,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Hail of Stones",
                Id = "51223bd0-ffd1-11df-a976-0801209c9014",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Action: Exhaust X characters to deal X damage to an enemy in the staging area.",
                Number = 32,
                Artist = Artist.Stu_Barnes
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Lure of Moria",
                Id = "51223bd0-ffd1-11df-a976-0801209c9015",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 3,
                Text = "Action: Ready all Dwarf characters.",
                Number = 30,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Orc Ambush",
                Id = "51223bd0-ffd1-11df-a976-0801209c9016",
                CardType = CardType.Treachery,
                EncounterSet = "Road to Rivendell",
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: All Orc enemies in the staging area engage the first player. If there are no Orc enemies in the staging area, return all Orc enemies in the encounter discard pile to the staging area, if able.",
                Keywords = new List<string>() { "Surge." },
                Number = 48,
                Artist = Artist.Anton_Kolyukh
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Orc Outpost",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-0801209c9017",
                CardType = CardType.Quest,
                EncounterSet = "Road to Rivendell",
                Quantity = 1,
                QuestPoints = 7,
                Number = 39,
                OppositeText = "When Revealed: Search the encounter deck and discard pile for Goblin Gate and add it to the staging area, if able. Then, if there is no active location, Goblin Gate becomes the active location.",
                FlavorText = "Heavy rain drives you to seek shelter among the caves of the mountains. They are dry, and the fire you start seeps into your bones and restores your spirit. Your eyes are heavy when teh soft clatter of falling pebbles reaches your ears. Perhaps you are not alone.",
                Artist = Artist.Nick_Deligaris,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountains, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Orc Raiders",
                Id = "51223bd0-ffd1-11df-a976-0801209c9019",
                CardType = CardType.Enemy,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Orc." },
                Quantity = 3,
                EngagementCost = 21,
                Attack = 3,
                Defense = 1,
                HitPoints = 3,
                Text = "Forced: After Orc Raiders engages a player, that player discards 2 attachments he controls, if able.",
                Keywords = new List<string>() { "Ambush." },
                Threat = 1,
                Number = 50,
                Artist = Artist.Mark_Tarrisse
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Out of the Wild",
                Id = "51223bd0-ffd1-11df-a976-0801209c9020",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 3,
                Text = "Action: Search the top 5 cards of the encounter deck for any 1 non-objective card worth no victory points and add it to your victory display. Shuffle the encounter deck.",
                Keywords = new List<string>() { "Secrecy 2." },
                Number = 36,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Pathless Country",
                Id = "51223bd0-ffd1-11df-a976-0801209c9021",
                CardType = CardType.Location,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Hills." },
                Quantity = 3,
                Text = "Forced: After at least 1 progress token is placed on Pathless Country, remove 1 progress token from it.",
                Shadow = "Shadow: Deal 1 damage to each ally in play.",
                Threat = 3,
                QuestPoints = 5,
                Number = 44,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Rider of the Mark",
                Id = "51223bd0-ffd1-11df-a976-0801209c9022",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Rohan." },
                Quantity = 3,
                ResourceCost = 3,
                Attack = 1,
                Defense = 1,
                Willpower = 2,
                HitPoints = 2,
                Text = "Action: Spend 1 Spirit resource to give control of Rider of the Mark to another player. (Limit once per round.)Response: After Rider of the Mark changes control, discard a shadow card dealt to an enemy you are engaged with.",
                Number = 33,
                Artist = Artist.David_Horne
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Rivendell Blade",
                Id = "51223bd0-ffd1-11df-a976-0801209c9023",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Item.", " Weapon." },
                Quantity = 3,
                ResourceCost = 1,
                Text = "Attach to a Noldor or Silvan character.\r\nWhen attached character attacks an enemy, that enemy gets -2 Defense until the end of the phase.",
                Keywords = new List<string>() { "Restricted." },
                Number = 31,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Ruined Road",
                Id = "51223bd0-ffd1-11df-a976-0801209c9024",
                CardType = CardType.Location,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Road." },
                Quantity = 2,
                Text = "Response: After you travel to Ruined Road, the first player places 2 progress tokens on it or readies 1 hero he controls.",
                Shadow = "Shadow: Return attacking enemy to the staging area after it attacks.",
                Threat = 1,
                QuestPoints = 5,
                Number = 42,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Sleeping Sentry",
                Id = "51223bd0-ffd1-11df-a976-0801209c9025",
                CardType = CardType.Treachery,
                EncounterSet = "Road to Rivendell",
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Deal 1 damage to each exhausted character. Then, exhaust all ready characters.",
                Shadow = "Shadow: Defending player must discard all exhausted characters he controls.",
                Number = 46,
                Artist = Artist.Tiziano_Baracchi
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Song of Eärendil",
                NormalizedTitle = "Song of Earendil",
                Id = "51223bd0-ffd1-11df-a976-0801209c9026",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                Traits = new List<string>() { "Song." },
                Quantity = 3,
                ResourceCost = 1,
                Text = 
@"Attach to a Spirit hero.

Response: After ~Song of Eärendil enters play, draw 1 card.
                
Response: After another player raises his threat, raise your threat by 1 to reduce that player's threat by 1.",
                Number = 34,
                Artist = Artist.K_R_Harris
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "The End Comes",
                Id = "51223bd0-ffd1-11df-a976-0801209c9027",
                CardType = CardType.Event,
                Sphere = Sphere.Neutral,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Response: After a Dwarf character leaves play, shuffle the encounter discard pile back into the encounter deck.",
                Number = 37,
                Artist = Artist.Ryan_Barger
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Png,
                Title = "Wild Bear",
                Id = "51223bd0-ffd1-11df-a976-0801209c9028",
                CardType = CardType.Enemy,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Creature." },
                Quantity = 3,
                EngagementCost = 34,
                Attack = 2,
                Defense = 3,
                HitPoints = 5,
                Text = "Forced: After Wild Bear engages a player, it makes an immediate attack.",
                Keywords = new List<string>() { "Ambush." },
                Threat = 0,
                Number = 52,
                Artist = Artist.Salvador_Trakal
            });
        }
    }
}
