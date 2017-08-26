using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;

namespace HallOfBeorn.Models.LotR.Sets.Dwarrowdelf
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

            Cards.Add(new LotRCard() {
                
                Title = "Along the Misty Mountains",
                StageNumber = 1,
                Id = "51223bd0-ffd1-11df-a976-0801209c9001",
                CardType = CardType.Quest,
                EncounterSet = "Road to Rivendell",
                Quantity = 1,
                QuestPoints = 20,
                Text = "Setup: Put Arwen Undómiel into play under the control of the first player. Shuffle the encounter deck. Reveal 1 card from the encounter deck per player, and add them to the staging area.",
                HtmlTemplate = "<p class='flavor-text'>Your party has braved the snows of the pass, but now must travel North along the Misty Mountains for league upon league as you escort Arwen to her father's house.</p><p><b>Setup:</b> Put <a title='Arwen Undómiel (Road to Rivendell)' href='/Cards/Details/Arwen-Undomiel-RtR' target='_blank'>Arwen Undómiel</a> into play under the control of the first player. Shuffle the encounter deck. Reveal 1 card from the encounter deck per player, and add them to the staging area.</p>",
                HtmlTemplate2 = "<p class='flavor-text'>This is a wild and perilous country, and it is dangerous to follow the roads. The mountains rise up on the right, impassively watching your slow trek among their foothills.</p>",
                CardNumber = 38,
                Artist = Artist.Ben_Zweifel,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountains, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                
                Title = "Approaching Rivendell",
                StageNumber = 3,
                Id = "51223bd0-ffd1-11df-a976-0801209c9003",
                CardType = CardType.Quest,
                EncounterSet = "Road to Rivendell",
                Quantity = 1,
                QuestPoints = 13,
                OppositeText = "When Revealed: Reveal 1 card from the encounter deck per player, and add it to the staging area.\r\nCharacters cannot be healed.\r\nIf the players defeat this stage, they have won the game.",
                FlavorText = "Orcs and other creatures have hounded you since fighting your way free of the orc outpost. Soon you will reach the safety of Rivendell's borders, but supplies have dwindled and you are dead weary from sleepless nights of keeping watch, as dark forms shadow your camp.",
                CardNumber = 40,
                Artist = Artist.Noah_Bradley,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountains, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                Title = "Arwen Undómiel",
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
                HtmlTemplate = "<p>The first player gains control of {self}, as an ally.</p><p><b>Response:</b> After {self} exhausts, choose a hero. Add 1 resource to that hero's resource pool.</p><p><b>If {self} leaves play, the players are defeated.</b></p>",
                CardNumber = 41,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Barren Hills",
                Id = "51223bd0-ffd1-11df-a976-0801209c9006",
                CardType = CardType.Location,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Hills." },
                Quantity = 2,
                Text = "While Barren Hills is the active location, ignore ambush.",
                Shadow = "Shadow: Return attacking enemy to the staging area after it attacks.",
                //HtmlTemplate = "<p>While {self} is the active location, ignore ambush.</p>{shadow}<p><b>Shadow:</b> Return attacking enemy to the staging area after it attacks.</p>",
                Threat = 2,
                QuestPoints = 4,
                CardNumber = 45,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new LotRCard() {
                
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
                CardNumber = 35,
                Artist = Artist.Winona_Nelson
            });
            Cards.Add(new LotRCard() {
                
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
                HtmlTemplate = "<p>{keyword:Surge.@Surge}<p><p>While {self} is in the staging area, encounter card effects cannot be canceled.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Return attacking enemy to the staging area after it attacks.</p>",
                Keywords = new List<string>() { "Surge." },
                Threat = 2,
                CardNumber = 51,
                Artist = Artist.Allison_Theus
            });
            Cards.Add(new LotRCard() {
                Title = "Dúnedain Wanderer",
                Id = "51223bd0-ffd1-11df-a976-0801209c9009",
                CardType = CardType.Ally,
                Sphere = Sphere.Leadership,
                Traits = new List<string>() { "Dúnedain.", " Ranger." },
                HtmlTemplate = "<p>{keyword:Ranged.} {keyword:Sentinel.} {keyword:Secrecy 3.}</p><p class='flavor-text'>They roamed at will southwards, and eastwards even as far as the Misty Mountains; but they were no few and rarely seen.<br>&ndash;The Fellowship of the Ring</p>",
                Quantity = 3,
                ResourceCost = 5,
                Attack = 2,
                Defense = 2,
                Willpower = 1,
                HitPoints = 2,
                Keywords = new List<string>() { "Ranged.", "Sentinel.", "Secrecy 3." },
                CardNumber = 29,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard() {
                
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
                HtmlTemplate = "<p>While {title:Elrohir} is in play, {self} gets +2 {Attack}.</p><p><b>Response:</b> After {self} is declared as an attacker, pay 1 resource from his resource pool to ready him.</p><p class='flavor-text'>&quot;Yes, the Dead ride behind.&quot;<br>&ndash;The Return of the King</p>",
                CardNumber = 28,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Followed by Night",
                Id = "51223bd0-ffd1-11df-a976-0801209c9011",
                CardType = CardType.Treachery,
                EncounterSet = "Road to Rivendell",
                Quantity = 3,
                EasyModeQuantity = 1,
                Text = "When Revealed: The first player (choose 1): deals 1 damage to all allies in play and Followed by Night gains surge, or all enemies engaged with players make an immediate attack, if able.",
                Shadow = "Shadow: Return attacking enemy to the staging area after it attacks.",
                HtmlTemplate = "<p><b>When Revealed:</b> The first player (choose 1): deals 1 damage to all allies in play and {self} gains surge, or all enemies enaged with players make an immediate attack, if able.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Return attacking enemy to the staging area after it attacks.</p>",
                CardNumber = 47,
                Artist = Artist.Jasper_Sandner
            });
            Cards.Add(new LotRCard() {
                
                Title = "Goblin Gate",
                Id = "51223bd0-ffd1-11df-a976-0801209c9012",
                CardType = CardType.Location,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Gate." },
                Quantity = 1,
                Text = "While Goblin Gate is the active location, the first enemy revealed from the encounter deck each round gains ambush. If that enemy engages a player, it makes an immediate attack (deal and resolve a shadow card).",
                HtmlTemplate = "<p>While {self} is the active location, the first enemy revealed from the encounter deck each round gains ambush. If that enemy engages a player, it makes an immediate attack <i>(deal and resolve a shadow card)</i>.</p><p class='flavor-text'>A crack had opened at the back of the cave, and was already a wide passage.<br>&ndash;The Hobbit</p>",
                Threat = 5,
                QuestPoints = 4,
                CardNumber = 43,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new LotRCard() {
                
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
                //HtmlTemplate = "<p>{keyword:Ambush.@Ambush} <i>(After this enemy enters play, each player makes an engagement check against it.)</i></p><p><b>Forced:</b> After {self} engages a player, that player deals 2 damage to 1 character he controls.</p>",
                Threat = 2,
                CardNumber = 49,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Hail of Stones",
                Id = "51223bd0-ffd1-11df-a976-0801209c9014",
                CardType = CardType.Event,
                Sphere = Sphere.Tactics,
                Quantity = 3,
                ResourceCost = 1,
                Text = "Action: Exhaust X characters to deal X damage to an enemy in the staging area.",
                CardNumber = 32,
                Artist = Artist.Stu_Barnes
            });
            Cards.Add(new LotRCard() {
                
                Title = "Lure of Moria",
                Id = "51223bd0-ffd1-11df-a976-0801209c9015",
                CardType = CardType.Event,
                Sphere = Sphere.Leadership,
                Quantity = 3,
                ResourceCost = 3,
                Text = "Action: Ready all Dwarf characters.",
                HtmlTemplate = "<p><b>Action:</b> Ready all {trait:Dwarf.@Dwarf} characters.</p><p class='flavor-text'>'The road that I speak of leads to the Mines of Moria,' said Gandalf. Only Gimli lifted up his head; a smouldering fire was in his eyes.<br>&ndash;The Fellowship of the Ring</p>",
                CardNumber = 30,
                Artist = Artist.Mike_Nash
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc Ambush",
                Id = "51223bd0-ffd1-11df-a976-0801209c9016",
                CardType = CardType.Treachery,
                EncounterSet = "Road to Rivendell",
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: All Orc enemies in the staging area engage the first player. If there are no Orc enemies in the staging area, return all Orc enemies in the encounter discard pile to the staging area, if able.",
                Keywords = new List<string>() { "Surge." },
                CardNumber = 48,
                Artist = Artist.Anton_Kolyukh
            });
            Cards.Add(new LotRCard() {
                
                Title = "Orc Outpost",
                StageNumber = 2,
                Id = "51223bd0-ffd1-11df-a976-0801209c9017",
                CardType = CardType.Quest,
                EncounterSet = "Road to Rivendell",
                Quantity = 1,
                QuestPoints = 7,
                CardNumber = 39,
                OppositeText = "When Revealed: Search the encounter deck and discard pile for Goblin Gate and add it to the staging area, if able. Then, if there is no active location, Goblin Gate becomes the active location.",
                FlavorText = "Heavy rain drives you to seek shelter among the caves of the mountains. They are dry, and the fire you start seeps into your bones and restores your spirit. Your eyes are heavy when teh soft clatter of falling pebbles reaches your ears. Perhaps you are not alone.",
                //HtmlTemplate = "<p class='flavor-text'>Heavy rain drives you to seek shelter among the caves of the mountains. They are dry, and the fire you start seeps into your bones and restores your spirit. Your eyes are heavy when teh soft clatter of falling pebbles reaches your ears. Perhaps you are not alone.</p>",
                //HtmlTemplate2 = "<p><b>When Revealed:</b> Search the encounter deck and discard pile for <a title= 'Goblin Gate (Road to Rivendell)' href='/Cards/Details/Goblin-Gate-RtR' target='_blank'>Goblin Gate</a> and add it to the staging area, if able. Then, if there is no active location, <a title= 'Goblin Gate (Road to Rivendell)' href='/Cards/Details/Goblin-Gate-RtR' target='_blank'>Goblin Gate</a> becomes the active location.</p>",
                Artist = Artist.Nick_Deligaris,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MistyMountains, EncounterSet.PlunderingGoblins }
            });
            Cards.Add(new LotRCard() {
                
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
                //HtmlTemplate = "<p>{keyword:Ambush.@Ambush} <i>(After this enemy enters play, each player makes an engagement check against it.)</i></p><p><b>Forced:</b> After {self} engages a player, that player discards 2 attachments he controls, if able.</p>",
                Threat = 1,
                CardNumber = 50,
                Artist = Artist.Mark_Tarrisse
            });
            Cards.Add(new LotRCard() {
                
                Title = "Out of the Wild",
                Id = "51223bd0-ffd1-11df-a976-0801209c9020",
                CardType = CardType.Event,
                Sphere = Sphere.Lore,
                Quantity = 3,
                ResourceCost = 3,
                Text = "Action: Search the top 5 cards of the encounter deck for any 1 non-objective card worth no victory points and add it to your victory display. Shuffle the encounter deck.",
                Keywords = new List<string>() { "Secrecy 2." },
                CardNumber = 36,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard() {
                
                Title = "Pathless Country",
                Id = "51223bd0-ffd1-11df-a976-0801209c9021",
                CardType = CardType.Location,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Hills." },
                Quantity = 3,
                Text = "Forced: After at least 1 progress token is placed on Pathless Country, remove 1 progress token from it.",
                Shadow = "Shadow: Deal 1 damage to each ally in play.",
                HtmlTemplate = "<p><b>Forced:</b> After at least 1 progress token in placed on {self}, remove 1 progress token from it.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Deal 1 damage to each ally in play.</p>",
                Threat = 3,
                QuestPoints = 5,
                CardNumber = 44,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new LotRCard() {
                
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
                HtmlTemplate = "<p><b>Action:</b> Spend 1 {sphere:Spirit} resource to give control of {self} to another player. (Limit once per round.)</p><p><b>Response:</b> After {self} changes control, discard a shadow card dealt to an enemy you are engaged with.</p>",
                CardNumber = 33,
                Artist = Artist.David_Horne
            });
            Cards.Add(new LotRCard() {
                
                Title = "Rivendell Blade",
                Id = "51223bd0-ffd1-11df-a976-0801209c9023",
                CardType = CardType.Attachment,
                Sphere = Sphere.Tactics,
                Traits = new List<string>() { "Item.", " Weapon." },
                Quantity = 3,
                ResourceCost = 1,
                Text = "Attach to a Noldor or Silvan character.\r\nWhen attached character attacks an enemy, that enemy gets -2 Defense until the end of the phase.",
                Keywords = new List<string>() { "Restricted." },
                CardNumber = 31,
                Artist = Artist.Sara_Biddle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Ruined Road",
                Id = "51223bd0-ffd1-11df-a976-0801209c9024",
                CardType = CardType.Location,
                EncounterSet = "Road to Rivendell",
                Traits = new List<string>() { "Road." },
                Quantity = 2,
                Text = "Response: After you travel to Ruined Road, the first player places 2 progress tokens on it or readies 1 hero he controls.",
                Shadow = "Shadow: Return attacking enemy to the staging area after it attacks.",
                HtmlTemplate = "<p><b>Response:</b> After you travel to {self}, the first player places 2 progress tokens on it or readies 1 hero controls.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Return attacking enemy to the staging area after it attacks.</p>",
                Threat = 1,
                QuestPoints = 5,
                CardNumber = 42,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new LotRCard() {
                
                Title = "Sleeping Sentry",
                Id = "51223bd0-ffd1-11df-a976-0801209c9025",
                CardType = CardType.Treachery,
                EncounterSet = "Road to Rivendell",
                Quantity = 2,
                EasyModeQuantity = 0,
                Text = "When Revealed: Deal 1 damage to each exhausted character. Then, exhaust all ready characters.",
                Shadow = "Shadow: Defending player must discard all exhausted characters he controls.",
                CardNumber = 46,
                Artist = Artist.Tiziano_Baracchi
            });
            addCard(LotRCard.Attachment("Song of Eärendil", string.Empty, Sphere.Spirit, 1)
                .WithTraits("Song.")
                .WithText("Attach to a Spirit hero.\r\nResponse: After ~Song of Eärendil enters play, draw 1 card.\r\nResponse: After another player raises his threat, raise your threat by 1 to reduce that player's threat by 1.")
                .WithTemplate("<p>Attach to a {sphere:Spirit} hero.</p><p><b>Response:</b> After {self} enters play, draw 1 card.</p><p><b>Response:</b> After another player raises his threat, raise your threat by 1 to reduce that player's threat by 1.</p>")
                .WithInfo(34, 3, Artist.K_R_Harris));
            Cards.Add(new LotRCard() {
                Title = "The End Comes",
                Id = "51223bd0-ffd1-11df-a976-0801209c9027",
                CardType = CardType.Event,
                Sphere = Sphere.Neutral,
                Quantity = 3,
                ResourceCost = 0,
                Text = "Response: After a Dwarf character leaves play, shuffle the encounter discard pile back into the encounter deck.",
                HtmlTemplate = "<p><b>Response:</b> After a {trait:Dwarf.@Dwarf} character leaves play, shuffle the encounter discard pile back into the encounter deck.</p><p class='flavor-text'>'He is dead then,', said Frodo. 'I feared it was so.'<br>&ndash;The Fellowship of the Ring</p>",
                CardNumber = 37,
                Artist = Artist.Ryan_Barger
            });
            Cards.Add(new LotRCard() {
                
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
                //HtmlTemplate = "<p>{keyword:Ambush.@Ambush} <i>(After this enemy enters play, each player makes an engagement check against it.)</i></p><p><b>Forced:</b> After {self} engages a player, it makes an immediate attack.</p>",
                Threat = 0,
                CardNumber = 52,
                Artist = Artist.Salvador_Trakal
            });
        }
    }
}
