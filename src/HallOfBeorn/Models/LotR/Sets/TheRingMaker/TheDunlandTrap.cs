using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TheDunlandTrap : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Dunland Trap";
            Abbreviation = "TDT";
            Number = 23;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";

            Cards.Add(new LotRCard()
            {
                Title = "Celeborn",
                
                Id = "687AD7DB-AF87-4BCE-ADEF-43BE538ED5B4",
                CardType = CardType.Hero,
                ThreatCost = 11,
                Willpower = 3,
                Attack = 2,
                Defense = 2,
                HitPoints = 4,
                Sphere = Models.LotR.Sphere.Leadership,
                IsUnique = true,
                Quantity = 1,
                Traits = new List<string>() { "Silvan.", "Noble." },
                Text = "Response: After a Silvan ally enters play, that ally gets +1 Willpower, +1 Attack and +1 Defense until the end of the round.",
                FlavorText = "\"...the lord of the Galadhrim is accounted wisest of the Elves of Middle-earth, and a giver of gifts beyond the power of kings.\" -Galadriel, The Fellowship of the Ring",
                CardNumber = 1,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                Title = "Naith Guide",
                
                Id = "B6DBC38B-BA83-49CC-AE0E-003F734117EC",
                CardType = CardType.Ally,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 1,
                Defense = 0,
                HitPoints = 1,
                Sphere = Models.LotR.Sphere.Leadership,
                Quantity = 3,
                Traits = new List<string>() { "Silvan.", "Scout." },
                Text = "Response: After Naith Guide enters play, choose a hero. That hero does not exhaust to quest this round.",
                FlavorText = "\"...I shall lead you well...\" -Haldir, The Fellowship of the Ring",
                CardNumber = 2,
                Artist = Artist.Magali_Villeneuve
            });
            Cards.Add(new LotRCard()
            {
                Title = "Swift and Silent",
                
                Id = "35690E9B-ABF4-4596-821B-9568F3F1CEA7",
                CardType = CardType.Event,
                ResourceCost = 1,
                Sphere = Models.LotR.Sphere.Leadership,
                Quantity = 3,
                Text = "Action: Ready a hero you control. Then, if your threat is 20 or less and this is the first time you played a copy of Swift and Silent this round, return this card to your hand instead of discarding it.",
                FlavorText = "A marching host of Elves had come up silently...–The Fellowship of the Ring",
                CardNumber = 3,
                Artist = Artist.Raymond_Bonilla
            });
            Cards.Add(new LotRCard()
            {
                Title = "Firefoot",
                IsUnique = true,
                
                Id = "3EBC4AF2-7A9A-4B61-9F67-D53AAC9D2802",
                CardType = CardType.Attachment,
                ResourceCost = 2,
                Sphere = Models.LotR.Sphere.Tactics,
                Quantity = 3,
                Traits = new List<string> { "Mount." },
                Keywords = new List<string> { "Restricted." },
                Text = "Attach to a Tactics or Rohan hero.\r\nAttached hero gets +1 Attack (+2 Attack instead if attached hero is Éomer).\r\nResponse: After attached hero attacks alone, exhaust Firefoot to choose a non-unique enemy engaged with you. Excess damage dealt by this attack is assigned to the chosen enemy.",
                //HtmlTemplate = "<p>Attach to a {sphere-hero:Tactics@!} or {trait-hero:Rohan.@Rohan}. {keyword:Restricted.}</p><p>Attached hero gets +1 {Attack} (+2 {Attack} instead if attached hero is {title:Éomer@Eomer}).</p><p><b>Response:</b> After attached hero attacks alone, exhaust Firefoot to choose a non-unique enemy engaged with you. Excess damage dealt by this attack is assigned to the chosen enemy.</p>",
                CardNumber = 4,
                Artist = Artist.Nora_Brisotti
            });
            Cards.Add(new LotRCard()
            {
                Title = "Close Call",
                
                Id = "DD8B3478-D0EF-434C-BF90-479538A200BB",
                CardType = CardType.Event,
                ResourceCost = 0,
                Sphere = Models.LotR.Sphere.Tactics,
                Quantity = 3,
                Keywords = new List<string> { "Doomed X." },
                Text = "Response: Cancel X damage just dealt to a hero.",
                FlavorText = "\"That spear-thrust would have skewered a wild boar!\"–Aragorn, The Fellowship of the Ring",
                CardNumber = 5,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard()
            {
                Title = "Blue Mountain Trader",
                
                Id = "98C41A39-3008-4985-805E-DC6C18973C6B",
                CardType = CardType.Ally,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 0,
                Defense = 1,
                HitPoints = 2,
                Sphere = Models.LotR.Sphere.Spirit,
                Quantity = 3,
                Traits = new List<string> { "Dwarf." },
                Text = "Action: Choose another player. That player gains control of Blue ~Mountain Trader. Then, that player moves 1 resource from the resource pool of a hero he controls to the resource pool of a hero you control, or Blue ~Mountain Trader is discarded. (Limit once per round.)",
                CardNumber = 6,
                Artist = Artist.Sara_Betsy,
                HasErrata = true
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Fall of Gil-Galad",
                
                Id = "A36F57A5-12FA-46DA-8991-FAC4313CEBB1",
                CardType = CardType.Attachment,
                ResourceCost = 1,
                Sphere = Models.LotR.Sphere.Spirit,
                Quantity = 3,
                Traits = new List<string> { "Song." },
                Text = "Limit 1 per deck. Attach to a hero.\r\nResponse: When attached hero is destroyed, add The Fall of Gil-galad to the victory display to reduce your threat by X, where X is the attached hero's threat cost.",
                FlavorText = 
@"...for into darkness fell his star
in Mordor where the shadows are.
–The Fellowship of the Ring",
                VictoryPoints = 1,
                CardNumber = 7,
                Artist = Artist.Arden_Beckwith,
                MaxPerDeck = 1
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ithilien Lookout",
                
                Id = "9AB83EED-4839-4A92-8DB7-1932DF8E6AA2",
                CardType = CardType.Ally,
                ResourceCost = 3,
                Willpower = 1,
                Attack = 2,
                Defense = 0,
                HitPoints = 2,
                Sphere = Models.LotR.Sphere.Lore,
                Quantity = 3,
                Traits = new List<string> { "Gondor.", "Ranger." },
                Keywords = new List<string> { "Secrecy 2." },
                Text = "Response: After ~Ithilien Lookout enters play, look at the top card of the encounter deck. If it is an enemy, you may discard it.",
                FlavorText = "All had swords at their sides... –The Two Towers",
                CardNumber = 8,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Tree People",
                
                Id = "8C8910B8-F4E3-471E-A973-C32A3ED27890",
                CardType = CardType.Event,
                ResourceCost = 0,
                Sphere = Models.LotR.Sphere.Lore,
                Quantity = 3,
                Text = "Action: Return a Silvan ally you control to your hand to search the top 5 cards of your deck for a Silvan ally. Put that ally into play and shuffle the other cards back into your deck. You can only play 1 copy of The Tree People each phase.",
                FlavorText = "No folk could they see, nor hear any feet upon the paths; but there were many voices, about them, and in the air above. –The Fellowship of the Ring",
                CardNumber = 9,
                Artist = Artist.Stacey_Diana_Clark
            });
            Cards.Add(new LotRCard()
            {
                Title = "The White Council",
                Id = "3D87FA7B-09A6-46C9-9117-E052902B842D",
                CardType = CardType.Event,
                ResourceCost = Card.VALUE_X,
                Sphere = Models.LotR.Sphere.Neutral,
                Quantity = 3,
                Text = "X is the number of players in the game.\r\nAction: Starting with the first player, each player chooses 1 different option: ready a hero he controls, add 1 resource to the resource pool of a hero he controls, draw 1 card, or shuffle 1 card from his discard pile into his deck.",
                FlavorText = "\"I it was who first summoned the White Council.\"\r\n–Galadriel, The Fellowship of the Ring",
                CardNumber = 10,
                Artist = Artist.Sacha_Diener
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Road to Tharbad",
                
                Id = "AA596A48-A5E8-4DC6-8789-433FD2C9BF82",
                CardType = CardType.Quest,
                StageNumber = 1,
                QuestPoints = 18,
                Quantity = 1,
                Text = "Setup: Set Chief Turch and Munuv Dûv Ravine aside, out of play. Make Old South Road the active location. Each player searches the encounter deck for a Boar Clan enemy and puts it into play engaged with him. Shuffle the encounter deck.",
                FlavorText = "You are following the Old South Road from Isengard to Tharbad on an errand for Saruman when you are attacked by Wild Men of Dunland.",
                OppositeText = 
@"Time 2. 

Forced: After the last time counter is removed from this stage, each player discards his hand and draws 2 cards. Place 2 time counters on this stage.",
                OppositeFlavorText = "Already weary from a full day of travel, you struggle to hold off the ferocious Dunlending attack. You must rally your companions and drive back the enemy, or you will be defeated.",
                EncounterSet = "The Dunland Trap",
                CardNumber = 11,
                Artist = Artist.Sacha_Diener,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DunlandWarriors, EncounterSet.WearyTravelers }
            });
            Cards.Add(new LotRCard()
            {
                Title = "A Well Laid Trap",
                
                Id = "D20381AB-5138-4C66-B072-13865CA1F2A7",
                CardType = CardType.Quest,
                StageNumber = 2,
                QuestPoints = null,
                Quantity = 1,
                Text = "When Revealed: Make Munuv Dûv Ravine the active location (returning any previous active location to the staging area). Each player discards each Item and each Mount attachment he controls. Each player chooses 1 ally he controls and discards each other ally he controls.",
                FlavorText = "You've driven back the attackers, but some of them seized your bags during the fight and took them as they fled. Inside one of those bags is the gold that Saruman gave you for your quest, so you pursue the thieves deeper into Dunland.",
                OppositeText =
@"When Revealed: Each player searches the encounter deck and discard pile for a Boar Clan enemy and puts it into play engaged with him. Shuffle the encounter deck. Each player shuffles his discard pile into his draw deck and draws 1 card.

Forced: At the end of the combat phase, advance to stage 3A.",
                OppositeFlavorText = "In your zeal to recover the gold, you have been led into an ambush.",
                EncounterSet = "The Dunland Trap",
                CardNumber = 12,
                Artist = Artist.Sacha_Diener,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DunlandWarriors, EncounterSet.WearyTravelers }
            });
            Cards.Add(new LotRCard()
            {
                Title = "No Way Out",
                
                Id = "32C557BA-7FC3-477F-872F-C531DCDD5B00",
                CardType = CardType.Quest,
                StageNumber = 3,
                QuestPoints = null,
                Quantity = 1,
                Text = "When Revealed: Put Chief Turch into play, engaged with the first player.",
                FlavorText = "The Dunlendings are more clever than you thought: using your gear as bait, they have lured you into a deep ravine where you are surrounded. A large warrior wearing a boar mantle strides forward and signals the attack. With no hope of escape, your only option is to fight...",
                OppositeText = 
@"Time X. X is 5 times the number of players in the game.

If a hero is destroyed at this stage, the players lose the game.

Forced: After the last time counter is removed from this stage, the players make engagement checks. Then, each engaged enemy makes an attack. If no heroes are destroyed by these attacks, the players win the game.",
                EncounterSet = "The Dunland Trap",
                CardNumber = 13,
                Artist = Artist.Silver_Saaremael,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.DunlandWarriors, EncounterSet.WearyTravelers }
            });
            Cards.Add(new LotRCard()
            {
                Title = "Chief Turch",
                IsUnique = true,
                //Id = "3511164D-A255-4324-A95E-1810737D9AC4",
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 3,
                Attack = 5,
                Defense = 3,
                HitPoints = 5,
                Quantity = 1,
                Traits = new List<string> { "Dunland.", "Boar Clan." },
                Text = 
@"Cannot have attachments. Cannot leave play.
Chief Turch engages the first player.

Forced: After an enemy engages a player, remove 1 time counter from the current quest.",
                FlavorText = "",
                EncounterSet = "The Dunland Trap",
                CardNumber = 14,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new LotRCard()
            {
                Title = "Munuv Dûv Ravine",
                IsUnique = true,
                Id = "DFD4D300-CC81-47ED-8421-6FA0A3ADFBF0",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 6,
                Quantity = 1,
                Traits = new List<string> { "Enedwaith.", "Hills.", "River." },
                Text = "Dunland enemies get +1 Attack and +1 Defense.",
                FlavorText = "...beyond them the green and tangled valley ran up into the long ravine between the dark arms of the mountains.\r\n-The Two Towers",
                VictoryPoints = 3,
                EncounterSet = "The Dunland Trap",
                CardNumber = 15,
                Artist = Artist.Dominique_Peyronnet
            });
            Cards.Add(new LotRCard()
            {
                Title = "Old South Road",
                IsUnique = true,
                
                Id = "2D464AC7-6602-40FB-B8C2-F2712009E000",
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 4,
                Quantity = 1,
                Traits = new List<string> { "Road." },
                Text = "Forced: At the end of the refresh phase, remove 1 time counter from the current quest.",
                FlavorText = "After some miles, however, the road ceased to roll up and down... –The Fellowship of the Ring",
                VictoryPoints = 1,
                EncounterSet = "The Dunland Trap",
                CardNumber = 16,
                Artist = Artist.David_Lecossu
            });
            Cards.Add(new LotRCard()
            {
                Title = "Boar Clan Stalker",
                
                Id = "11BD2DAA-8271-49F3-8B2B-03E41EF68CC9",
                CardType = CardType.Enemy,
                EngagementCost = 28,
                Threat = 3,
                Attack = 0,
                Defense = 0,
                HitPoints = 5,
                Quantity = 3,
                EasyModeQuantity = 2,
                Traits = new List<string> { "Dunland.", "Boar Clan." },
                Text = 
@"Boar Clan Stalker gets +1 Attack and +1 Defense for each resource token on it (limit + 4).
                
Forced: After the engaged player draws any number of cards, put a resource token on Boar Clan Stalker",
                FlavorText = "",
                EncounterSet = "The Dunland Trap",
                CardNumber = 17,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new LotRCard()
            {
                Title = "Boar Clan Warrior",
                
                Id = "24CCB412-A2EC-43FA-BB28-01DEDF9730CA",
                CardType = CardType.Enemy,
                EngagementCost = 20,
                Threat = 2,
                Attack = 3,
                Defense = 1,
                HitPoints = 4,
                Quantity = 4,
                Traits = new List<string> { "Dunland.", "Boar Clan." },
                Text = "Forced: After the engaged player draws any number of cards, deal Boar Clan Warrior a shadow card.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each shadow card on it.",
                EncounterSet = "The Dunland Trap",
                CardNumber = 18,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(new LotRCard()
            {
                Title = "Hithaeglir Foothills",
                Id = "02AB39BB-FC95-494D-9BC5-0ADE106A02BA",
                CardType = CardType.Location,
                Threat = Card.VALUE_X,
                QuestPoints = 4,
                Quantity = 2,
                EasyModeQuantity = 1,
                Traits = new List<string> { "Enedwaith.", "Hills." },
                Text = "X is the number of resource tokens on this card.\r\nForced: After a player draws any number of cards, place 1 resource token here.",
                EncounterSet = "The Dunland Trap",
                CardNumber = 19,
                Artist = Artist.Michael_Rasmussen
            }.WithKeywords("Surge."));
            Cards.Add(new LotRCard()
            {
                Title = "Hills of Dunland",
                
                Id = "CBD27C8C-FC74-41A6-97C0-70CDF8121F81",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 3,
                Quantity = 4,
                EasyModeQuantity = 2,
                Traits = new List<string> { "Enedwaith.", "Hills." },
                Text = "While Hills of Dunland is in the staging area, it gains: \"Forced: After a player draws any number of cards, discard the top card of the encounter deck. If the discarded card is a Dunland enemy, put it into play engaged with that player. This ability does not stack with other copies of Hills of Dunland.\"\r\n\r\nTravel: Each player draws a card to travel here.",
                EncounterSet = "The Dunland Trap",
                CardNumber = 20,
                Artist = Artist.Katy_Grierson
            });
            Cards.Add(new LotRCard()
            {
                Title = "Plains of Enedwaith",
                
                Id = "2D01B076-6E90-4B6C-AAC2-345EB6DCBACF",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 2,
                Quantity = 3,
                Traits = new List<string> { "Enedwaith.", "Plains." },
                Text = "While Plains of Enedwaith is the active location, players do not draw a card during the resource phase.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if undefended).",
                EncounterSet = "The Dunland Trap",
                CardNumber = 21,
                Artist = Artist.Katy_Grierson
            });
            Cards.Add(new LotRCard()
            {
                Title = "Hithaeglir Stream",
                
                Id = "5FD21DB3-B2AA-491F-AFA3-53714BC0F83F",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 4,
                Quantity = 4,
                Traits = new List<string> { "Enedwaith.", "River." },
                Text = "While Hithaeglir Stream is the active location, players draw 2 cards during the resource phase instead of 1.",
                FlavorText = "Shadow: Attacking enemy gets +1 Attack. Deal it an additional shadow card.",
                EncounterSet = "The Dunland Trap",
                CardNumber = 22,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new LotRCard()
            {
                Title = "Frenzied Attack",
                
                Id = "78997B05-A569-450C-B552-CAA76AA75E84",
                CardType = CardType.Treachery,
                Quantity = 3,
                Text = "When Revealed: Each player draws a card. Each player discard each ally from his hand. If no allies were discarded this way, Frenzied Attack gains surge.",
                Shadow = "Shadow: Until the end of the round, attacking enemy cannot take damage.",
                EncounterSet = "The Dunland Trap",
                CardNumber = 23,
                Artist = Artist.Ilich_Henriquez
            });
            Cards.Add(new LotRCard()
            {
                Title = "Dunlending Ambush",
                
                Id = "4FBFC291-E369-49BD-8B2C-562388CE3B0E",
                CardType = CardType.Treachery,
                Quantity = 3,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Attach to the active location. (Counts as a Condition attachment with the text: \"Limit 1 per location. Forced: After attached location is explored, each player searches the encounter deck and discard pile for a Dunland enemy and puts it into play engaged with him. Shuffle the encounter deck.\")",
                EncounterSet = "The Dunland Trap",
                CardNumber = 24,
                EasyModeQuantity = 1,
                Artist = Artist.Claudio_Pozas
            });
        } 
    }
}