using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.Sets
{
    public class AJourneytoRhosgobel : CardSet
    {
        protected override void Initialize()
        {
            Name = "A Journey To Rhosgobel";
            Abbreviation = "AJtR";
            Number = 4;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Shadows of Mirkwood";

            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Prince Imrahil",
                Id = "51223bd0-ffd1-11df-a976-0801203c9001",
                CardType = CardType.Hero,
                Sphere = Sphere.Leadership,
                ThreatCost = 11,
                IsUnique = true,
                Attack = 3,
                Defense = 2,
                Willpower = 2,
                HitPoints = 4,
                Traits = new List<string>() { "Gondor.", " Noble." },
                Text = "Response: After a character leaves play, ready Prince Imrahil. (Limit once per round.)",
                FlavorText = "But beyond, in the great fief of Belfalas, dwelt Prince Imrahil in his castle of Dol Amroth by the sea, and he was of high blood, and his fold also, tall men and proud with sea-grey eyes. -The Return of the King.",
                Quantity = 1,
                Number = 50,
                Artist = Artist.David_A_Nash
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Haldir of Lórien",
                NormalizedTitle = "Haldir of Lorien",
                Id = "51223bd0-ffd1-11df-a976-0801203c9002",
                CardType = CardType.Ally,
                Sphere = Sphere.Lore,
                ResourceCost = 4,
                IsUnique = true,
                Attack = 2,
                Defense = 2,
                Willpower = 2,
                HitPoints = 3,
                Traits = new List<string>() { "Silvan." },
                Keywords = new List<string>() { "Ranged.", " Sentinel." },
                FlavorText = "\"But there are some of us still who go abroad for the gathering of news and the watching of our enemies, and they speak the languages of other lands.\" -The Fellowship of the Ring",
                Quantity = 3,
                Number = 57,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Radagast",
                Id = "51223bd0-ffd1-11df-a976-0801203c9003",
                CardType = CardType.Ally,
                Sphere = Sphere.Neutral,
                ResourceCost = 5,
                IsUnique = true,
                Attack = 1,
                Defense = 1,
                Willpower = 2,
                HitPoints = 3,
                Traits = new List<string>() { "Istari." },
                Text = "Radagast collects 1 resource each resource phase. These resources can be used to pay for Creature cards played from your hand.\r\nAction: Spend X resources from Radagast's pool to heal X wounds on any 1 Creature.",
                FlavorText = "\"I have an urgent errand. My news is evil.\"",
                Quantity = 3,
                Number = 59,
                Artist = Artist.Rio_Sabda
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Landroval",
                Id = "51223bd0-ffd1-11df-a976-0801203c9004",
                CardType = CardType.Ally,
                Sphere = Sphere.Tactics,
                ResourceCost = 5,
                IsUnique = true,
                Attack = 3,
                Defense = 1,
                Willpower = 1,
                HitPoints = 4,
                Traits = new List<string>() { "Creature.", " Eagle." },
                Text = "Landroval cannot have restricted attachments.\r\nResponse: After a hero card is destroyed, return Landroval to his owner's hand to put that hero back into play, with 1 damage token on it. (Limit once per game.)",
                Keywords = new List<string>() { "Sentinel." },
                Quantity = 3,
                Number = 53,
                Artist = Artist.Allison_Theus
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Ancient Mathom",
                Id = "51223bd0-ffd1-11df-a976-0801203c9005",
                CardType = CardType.Attachment,
                Sphere = Sphere.Spirit,
                ResourceCost = 1,
                Traits = new List<string>() { "Mathom." },
                Text = "Attach to a location.\r\nResponse: After attached location is explored, the first player draws 3 cards.",
                FlavorText = "The Mathom-house it was called; for anything that Hobbits had no immediate use for, but were unwilling to throw away, they called a mathom. Their dwellings were apt to become rather crowded with mathoms... -The Fellowship of the Ring",
                Quantity = 3,
                Number = 56,
                Artist = Artist.Anna_Mohrbacher
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Infighting",
                Id = "51223bd0-ffd1-11df-a976-0801203c9006",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                ResourceCost = 1,
                Text = "Action: Move any number of damage from one enemy to another.",
                FlavorText = "That's cursed rebel-talk, and I'll stick you, if you don't shut it down, see? -Orc Soldier, The Return of the King",
                Quantity = 3,
                Number = 58,
                Artist = Artist.Felicia_Cano
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Parting Gifts",
                Id = "51223bd0-ffd1-11df-a976-0801203c9007",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                ResourceCost = 0,
                Text = "Action: Move any number of resource tokens from a Leadership hero's resource pool to any other hero's resource pool.",
                FlavorText = "Inside the hall there was piled a large assortment of packages and parcels and small articles of furniture. -The Fellowship of the Ring",
                Quantity = 3,
                Number = 52,
                Artist = Artist.Cristi_Balanescu
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Dúnedain Quest",
                NormalizedTitle = "Dunedain Quest",
                Id = "51223bd0-ffd1-11df-a976-0801203c9008",
                CardType = CardType.Attachment,
                Sphere = Sphere.Leadership,
                ResourceCost = 2,
                Traits = new List<string>() { "Signal." },
                Text = "Attach to a hero.\r\nAttached hero gains +1 Willpower.\r\nAction: Pay 1 resource from attached hero's pool to attach Dunedain Quest to another hero.",
                Quantity = 3,
                Number = 51,
                Artist = Artist.Leonardo_Borazio
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Escort from Edoras",
                Id = "51223bd0-ffd1-11df-a976-0801203c9009",
                CardType = CardType.Ally,
                Sphere = Sphere.Spirit,
                ResourceCost = 2,
                Attack = 0,
                Defense = 0,
                Willpower = 2,
                HitPoints = 1,
                Traits = new List<string>() { "Rohan." },
                Text = "While committed to a quest, Escort from Edoras gets +2 Willpower.\r\nForced: After resolving a quest to which Escort from Edoras was committed, discard Escort from Edoras from play.",
                Quantity = 3,
                Number = 55,
                Artist = Artist.Mark_Winters
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "To the Eyrie",
                Id = "51223bd0-ffd1-11df-a976-0801203c9010",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                ResourceCost = 2,
                Text = "Response: After an ally is destroyed, exhaust 1 Eagle character to move that ally from the discard pile to its owner's hand.",
                FlavorText = "The pale peaks of the mountains were coming nearer, moonlit spikes of rock sticking out of black shadows. -The Hobbit",
                Quantity = 3,
                Number = 54,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Festering Wounds",
                Id = "51223bd0-ffd1-11df-a976-0801203c9011",
                CardType = CardType.Treachery,
                Text = "When Revealed: Deal 2 damage to each wounded character.",
                Shadow = "Shadow: Deal 1 damage to each wounded character. (2 damage instead if this attack is undefended.)",
                EncounterSet = "A Journey to Rhosgobel",
                Quantity = 2,
                EasyModeQuantity = 1,
                Number = 69,
                Artist = Artist.Taufiq,
                SecondArtist = Artist.Julia_Laud
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Athelas",
                Id = "51223bd0-ffd1-11df-a976-0801203c9012",
                CardType = CardType.Objective,
                Traits = new List<string>() { "Item." },
                Text = "Action: Exhaust a hero to claim this objective if it has no encounters attached. Then, attach Athelas to that hero.",
                Keywords = new List<string>() { "Guarded." },
                EncounterSet = "A Journey to Rhosgobel",
                Quantity = 4,
                Number = 63,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Black Forest Bats",
                Id = "51223bd0-ffd1-11df-a976-0801203c9013",
                CardType = CardType.Enemy,
                EngagementCost = 26,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string>() { "Creature." },
                Text = "Only Eagle characters or characters with ranged can attack or defend against Black Forest Bats.",
                Shadow = "Shadow: If this attack is undefended, the damage must be placed on Wilyador.",
                HtmlTemplate = "<p>Only {trait:Eagle.@Eagle} characters or characters with {keyword:Ranged.@ranged} can attack or defend against {self}.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If this attack is undefended, the damage must be placed on Wilyador</p>",
                Threat = 1,
                EncounterSet = "A Journey to Rhosgobel",
                Quantity = 5,
                Number = 71,
                Artist = Artist.Aurelien_Hubert
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Exhaustion",
                Id = "51223bd0-ffd1-11df-a976-0801203c9014",
                CardType = CardType.Treachery,
                Text = "When Revealed: Deal 2 damage to each exhausted character.",
                Shadow = "Shadow: Deal 1 damage to each exhausted character.",
                EncounterSet = "A Journey to Rhosgobel",
                Quantity = 4,
                EasyModeQuantity = 1,
                Number = 67,
                Artist = Artist.Marco_Caradonna
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Forest Grove",
                Id = "51223bd0-ffd1-11df-a976-0801203c9015",
                CardType = CardType.Location,
                Traits = new List<string>() { "Forest." },
                Text = "Response: After the players explore Forest Grove, search the encounter deck and discard pile for 1 Athelas objective, and add it to the staging area. Then, shuffle the encounter deck.",
                HtmlTemplate = "<p><b>Response:</b> After the players explore {self}, search the encounter deck and discard pile for 1 <a href='/Cards/Details/Athelas-AJtR' title='Athelas' target='_blank'>Athelas</a> objective, and add it to the staging area. Then, shuffle the encounter deck.</p>",
                Threat = 2,
                QuestPoints = 3,
                EncounterSet = "A Journey to Rhosgobel",
                Quantity = 4,
                Number = 66,
                Artist = Artist.Anna_Mohrbacher
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Mirkwood Flock",
                Id = "51223bd0-ffd1-11df-a976-0801203c9016",
                CardType = CardType.Enemy,
                EngagementCost = 32,
                Attack = 2,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string>() { "Creature." },
                Text = "Only Eagle characters or characters with ranged can attack or defend against Mirkwood Flock.",
                Shadow = "Shadow: If this attack is undefended, the damage must be placed on Wilyador.",
                HtmlTemplate = "<p>Only {trait:Eagle.@Eagle} characters or characters with {keyword:Ranged.@ranged} can attack or defend against {self}.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If this attack is undefended, the damage must be placed on Wilyador</p>",
                Threat = 1,
                EncounterSet = "A Journey to Rhosgobel",
                Quantity = 4,
                Number = 70,
                Artist = Artist.Brandon_Leach
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Rhosgobel",
                Id = "51223bd0-ffd1-11df-a976-0801203c9017",
                CardType = CardType.Location,
                IsUnique = true,
                Traits = new List<string>() { "Forest." },
                Text = "X is the number of players in the game.\r\nWhile Rhosgobel is in the staging area, Wilyador cannot be healed.\r\nTravel: Players must complete stage one of this quest before they can travel to Rhosgobel.",
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = 4,
                EncounterSet = "A Journey to Rhosgobel",
                Quantity = 1,
                VictoryPoints = 4,
                Number = 65,
                Artist = Artist.Ben_Zweifel
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Swarming Insects",
                Id = "51223bd0-ffd1-11df-a976-0801203c9018",
                CardType = CardType.Treachery,
                Text = "When Revealed: Deal 1 damage to each character without any attachments.",
                Shadow = "Shadow: If a character (including Wilyador) has more damage than each other character, deal 3 additional damage to that character.",
                EncounterSet = "A Journey to Rhosgobel",
                Quantity = 4,
                EasyModeQuantity = 1,
                Number = 68,
                Artist = Artist.Taufiq,
                SecondArtist = Artist.Julia_Laud
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Wilyador",
                Id = "51223bd0-ffd1-11df-a976-0801203c9019",
                CardType = CardType.Objective_Ally,
                IsUnique = true,
                Attack = 1,
                Defense = 1,
                Willpower = 1,
                HitPoints = 20,
                Traits = new List<string>() { "Creature.", " Eagle." },
                Text = "No attachments. The first player gains control of Wilyador.\r\nForced: At the end of each round, Wilyador suffers 2 damage.\r\nWilyador cannot be healed of more than 5 wounds by a single effect. If Wilyador leaves play, the players have lost the game.",
                HtmlTemplate = "<p>No attachments. The first player gains control of {self}.<p><b>Forced:</b> At the end of each round, {self} suffers 2 damage.</p><p>{self} cannot be healed of more than 5 wounds by a single effect. If {self} leaves play, the players have lost the game.</p>",
                EncounterSet = "A Journey to Rhosgobel",
                Quantity = 1,
                Number = 64,
                Artist = Artist.Taufiq,
                SecondArtist = Artist.Julia_Laud
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "The Wounded Eagle",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801203c9020",
                CardType = CardType.Quest,
                QuestPoints = 8,
                Setup = "ss",
                FlavorText = "After a fierce conflict with a group of Trolls, you come across a fallen Eagle, grievously wounded and on the verge of death.",
                Text = "Setup: Search the encounter deck for Rhosgobel and Wilyador, and add them to the staging area with 2 damage tokens on Wilyador. Then, shuffle the encounter deck.",
                OppositeFlavorText = "The Eagle's wounds cannot be tended in the wilderness, so you attempt to bring the creature to Rhosgobel, where the wisdom of Radagast the Brown may be its only hope.",
                EncounterSet = "A Journey to Rhosgobel",
                Quantity = 1,
                Number = 60,
                Artist = Artist.Joko_Mulyono,
                SecondArtist = Artist.Fandy_Sugiarto,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DolGuldurOrcs, EncounterSet.SpidersOfMirkwood }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Radagast's Request",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-0801203c9022",
                CardType = CardType.Quest,
                QuestPoints = 12,
                EncounterSet = "A Journey to Rhosgobel",
                FlavorText = "The Eagle's health has grown worse, but you have at last arrived at Rhosgobel, where Radagast examines the bird. He then asks you to head out into the wilderness to find the healing plant, Athelas. Meantime, any healing lore or supplies your party has it its disposal could be used to assist in comforting the Eagle until you return.",
                OppositeText = "Reponse: After the quest phase begins, the first player may place X damage tokens on Wilyador to look at the top 3 cards of the encounter deck. Reveal and add 1 of these cards to the staging area, and discard the other 2. X is the number of players in the game.\r\nForced: After a card effect heals Wilyador, remove that card from the game.",
                Quantity = 1,
                Number = 61,
                Artist = Artist.Ijur,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DolGuldurOrcs, EncounterSet.SpidersOfMirkwood }
            });
            Cards.Add(new Card() {
                ImageType = Models.ImageType.Jpg,
                Title = "Return to Rhosgobel",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-0801203c9024",
                CardType = CardType.Quest,
                QuestPoints = 0,
                EncounterSet = "A Journey to Rhosgobel",
                FlavorText = "Feeling tha time is runing out on Wilyador's life, you gather the Athelas you have found and head back to Rhosgobel. You arrive at night, wondering if you have found enough of the herb...",
                OppositeText = "When Revealed: Heal 5 wounds from Wilyador for each Athelas objective card the players control.\r\nIf Wilyador is completely healed when this effect resolves, Wilyador survives and the players have won the game. Otherwise, the players have lost the game.",
                Quantity = 1,
                Number = 62,
                Artist = Artist.Ben_Zweifel,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DolGuldurOrcs, EncounterSet.SpidersOfMirkwood }
            });
        }
    }
}
