using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class AStormOnCobasHaven : CardSet
    {
        private const string setName = "A Storm on Cobas Haven";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "ASoCH";
            Number = 39;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(LotRCard.Hero("Na'asiyah", string.Empty, Sphere.Tactics, 8, 1, 2, 2, 4)
                .WithTraits("Corsair.", "Warrior.")
                .WithText("Resources in Na'asiyah's resource pool cannot be used to pay for allies.\r\nAction: While Na'asiyah is attacking or defending, pay 1 resource from her resource pool to give her +2 Attack or +2 Defense for this attack.")
                .WithInfo(109, 1, Artist.Sara_Winters));
            Cards.Add(LotRCard.Attachment("Rune-master", string.Empty, Sphere.Leadership, 1)
                .WithUnique()
                .WithTraits("Title.")
                .WithText("Attach to a Ranger or Leadership hero.\r\nResponse: After a Signal attachment is attached to a hero, exhaust Rune-master to add 1 resource to that hero's resource pool.")
                .WithInfo(110, 3, Artist.Kim_Sokol));
            Cards.Add(LotRCard.Event("Terrible to Behold", string.Empty, Sphere.Leadership, 1)
                .WithText("Response: After you declare a Noble character as a defender against an attack made by an engaged enemy, return that enemy to the staging area. Then, cancel the attack.")
                .WithFlavor("So great a power and royalty was revealed in Aragorn...that many of the wild men paused, and looked back over their shoulders to the valley, and some looked up doubtfully at the sky.\r\n-The Two Towers")
                .WithInfo(111, 3, Artist.Jason_Cheeseman_Meyer));
            Cards.Add(LotRCard.Ally("Veteran Sword-elf", Sphere.Tactics, 3, 1, 1, 1, 3)
                .WithTraits("Noldor.", "Warrior.")
                .WithText("~Veteran Sword-elf gets +1 Attack and +1 Defense for each copy of ~Veteran Sword-elf in your discard pile.")
                .WithFlavor("The elves were the first to charge. Their hatred for the goblins is cold and bitter.\r\n-The Hobbit")
                .WithInfo(112, 3, Artist.Ramon_Puasa_Jr));
            Cards.Add(LotRCard.Attachment("Vigilant Guard", string.Empty, Sphere.Tactics, 3)
                .WithTraits("Skill.")
                .WithText("Attach to a Warrior character. Limit 1 per character.\r\nAttached character gets +2 hit points.\r\nResponse: When another character would be assigned any amount of damage, place 1 of that damage on attached character instead.")
                .WithInfo(113, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.Event("Knife-work", "", Sphere.Tactics, 1)
                .WithText("Action: Choose a player. Each enemy engaged with that player gets -1 Defense until the end of the phase. Then, the players as a group may spend 2 Lore resources to have the chosen player draw 1 card each time he attacks and destroys an enemy this phase.")
                .WithFlavor("\"Good!\" said Legolas. \"But my count is now two dozen. It has been knife-work up here.\" -The Two Towers")
                .WithInfo(114, 3, Artist.Joshua_Cairos));
            Cards.Add(LotRCard.Ally("Linhir Sea-captain", Sphere.Spirit, 3, 2, 0, 1, 2)
                .WithTraits("Gondor.")
                .WithText("Response: After you play Linhir Sea-captain from your hand, if you paid all of its resouce cost from a single hero's resource pool, both that hero and Linhir Sea-captain do not exhaust to quest this round.")
                .WithInfo(115, 3, Artist.Kim_Sokol));
            Cards.Add(LotRCard.Attachment("Windfola", string.Empty, Sphere.Spirit, 1)
                .WithUnique()
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Spirit hero, or to Éowyn.\r\nAttached character gets +1 Willpower.\r\nResponse: After attached character is removed from the quest, exhaust Windfola to commit attached hero to the quest.")
                .WithFlavor("...the great grey steed Windfola made little of the burden; for Dernhelm was less in weight than many men, though lithe and well-knit in frame. -The Return of the King")
                .WithInfo(116, 3, Artist.Sandara_Tang));
            Cards.Add(LotRCard.Ally("Ioreth", Sphere.Lore, 0, 0, 0, 0, 1)
                .WithUnique()
                .WithTraits("Gondor.", "Healer.")
                .WithText("Cannot attack or defend.\r\nAction: Spend 1 Lore resource and exhaust Ioreth. Then, heal 3 points of damage on a character. Any player may trigger this action.")
                .WithFlavor("Thus spake Ioreth, wise-woman of Gondor: The hands of the king are the hands of a healer, and so shall the rightful king be known. -The Return of the King")
                .WithInfo(117, 3, Artist.Aleksander_Karcz));
            Cards.Add(LotRCard.Event("The Houses of Healing", string.Empty, Sphere.Lore, 5)
                .WithText("Response: You may exhaust any number of Healer characters you control as part of this card's cost. Reduce the cost to play this card by 1 for each Healer character you exhaust in this way.\r\nRefresh Action: Choose a hero in any player's discard pile. Put that hero into play under its owner's control, with 1 damage token on it.")
                .WithInfo(118, 3, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Event("Justice Shall Be Done", "", Sphere.Neutral, 0)
                .WithText("Limit 1 per deck.\r\nPlanning Action: Add Justice Shall Be Done to the victory display to draw 3 cards and add 3 resources to the resource pool of each hero you control. At the end of the round, you are eliminated from the game.")
                .WithFlavor("\"...it is the last move in a great jeopardy, and for one side or the other it will bring the end of the game.\"\r\n-Aragorn, The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(119, 3, Artist.Dmitry_Prosvirnin));
            Cards.Add(LotRCard.Quest("Outmaneuver the Enemy", 1, setName, 10)
                .WithFlavor("Corsairs are attacking Dol Amroth to cover Sahír's escape to Umbar!")
                .WithText("Setup: Prepare the Corsair deck. Players prepare their fleet. Set each copy of Dol Amroth Warship aside, out of play. Search the encounter deck for Raider Flagship and 1 copy of Scouting Ship, and add them to the staging area. Search the encounter deck for a Dol Amroth objective of your choice and add it to the staging area. Then, shuffle the encounter deck and resolve the Guarded keyword on that objective.")
                .WithKeywords("Sailing.")
                .WithOppositeText("Forced: When a Ship enemy engages you, if you are off-course (Cloudy, Rainy or Stormy), deal 2 damage to a Ship objective you control. If you are on-course (Sunny), deal 2 damage to that Ship enemy instead.\r\nIf your current heading is at the worst setting (Stormy), Raider Flagship gets -50 engagement cost.")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders, EncounterSet.CorsairPirates, EncounterSet.UmbarFleet, EncounterSet.VoyageAcrossBelegaer, EncounterSet.TheDreamChasersFleet)
                .WithInfo(120, 1, Artist.Adam_Lane));
            Cards.Add(LotRCard.Quest("Battle in the Bay", 2, setName, 16)
                .WithFlavor("The Corsair fleet seems to be attacking multiple key locations simultaneously. To stop the attack, you must defend Dol Amroth from the Corsair ships.")
                .WithText("When Revealed: Search the encounter deck and discard pile for a Ship enemy and add it to the staging area (2 Ship enemies instead if there are 3 or 4 players in the game). Shuffle the encounter deck. For each unguarded objective in the staging area, attach a non-unique Ship enemy in the staging area to that objective, guarding it.")
                .WithKeywords("Sailing.")
                .WithOppositeText("If your current heading is at the worst setting (Stormy), Raider Flagship gets -50 engagement cost.\r\nYou cannot advance while at least 1 objective is guarded by an encounter.")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders, EncounterSet.CorsairPirates, EncounterSet.UmbarFleet, EncounterSet.VoyageAcrossBelegaer, EncounterSet.TheDreamChasersFleet)
                .WithInfo(121, 1, Artist.DinoDrawing));
            Cards.Add(LotRCard.Quest("Break Through the Fleet!", 3, setName, 5)
                .WithFlavor("\"You have to go after Sahír!\" Imrahil yells as the battle rages on. \"We will finish this fight!\"")
                .WithText("When Revealed: The players make engagement checks against each enemy in the staging area. Raider Flagship gets -50 engagement cost during these engagement checks.")
                .WithKeywords("Sailing.")
                .WithOppositeText("Raider Flagship gets -50 engagement cost.\r\nBreak Through the Fleet! has +5 quest points for each Ship enemy in play.\r\nIf this stage is defeated, or if Raider Flagship is in the victory display, the players have broken through the Corsair fleet and win the game!")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders, EncounterSet.CorsairPirates, EncounterSet.UmbarFleet, EncounterSet.VoyageAcrossBelegaer, EncounterSet.TheDreamChasersFleet)
                .WithInfo(122, 1, Artist.Joshua_Cairos));
            Cards.Add(LotRCard.ShipObjective("Dol Amroth Warship", setName, 2, 2, 2, 8)
                .WithTraits("Gondor.", "Ship.")
                .WithText("Immune to player card effects.\r\nIf you are on-course (Sunny), Dol Amroth Warship gets +2 Willpower, +2 Attack, and +2 Defense.\r\nForced: When Dol Amroth Warship is destroyed, set it aside, out of play.")
                .WithInfo(123, 2, Artist.Ignacio_Bazan_Lazcano));
            Cards.Add(LotRCard.ShipEnemy("Raider Flagship", setName, 50, 3, 5, 3, 18)
                .WithUnique()
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithText("Immune to player card effectss.\r\nOnly Ship enemies can be declared as attackers against Raider Flagship.\r\nForced: At the end of the encounter phase, the engaged player reveals the top card of the Corsair deck and engages it.")
                .WithVictoryPoints(20)
                .WithInfo(124, 1, Artist.Michael_Rasmussen));
            Cards.Add(LotRCard.ShipEnemy("Corsair Skirmisher", setName, 28, 3, 4, 4, 6)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithText("Immune to player card effects.\r\nResponse: After Corsair Skirmisher is destroyed as an enemy, the engaged player may discard allies he controls with a total of at least 3 Willpower ti take control of Corsair Skirmisher as a Ship-Objective with Willpower equal to its Threat. (It loses the Ship-Enemy card type and gains the Ship-Objective card type).")
                .WithInfo(125, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.ShipEnemy("Siege Ship", setName, 46, 2, 5, 5, 7)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Archery 2.")
                .WithText("Cannot have attachments.\r\nWhile Siege Ship is in the staging area, it gains: \"Forrced: at the end of the quest phase, if Siege Ship is not guarding an objective and there is an unguarded objective in the staging area, attach Siege Ship to that objective, guarding it.\"")
                .WithEasyModeQuantity(2)
                .WithInfo(126, 3, Artist.Michael_Rasmussen));
            Cards.Add(LotRCard.ShipEnemy("Heavy Cruiser", setName, 42, 5, 7, 5, 8)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithText("Cannot have attachments.\r\nWhen Revealed: Search the encounter deck and discard pile for a Dol Amroth objective and add it to the staging area. Then, attach Heavy Crusier to that objective, guarding it. Shuffle the encounter deck.")
                .WithEasyModeQuantity(0)
                .WithInfo(127, 1, Artist.DinoDrawing)); //Navigation symbol
            Cards.Add(LotRCard.Location("Coast of Anfalas", string.Empty, setName, 3, 3)
                .WithTraits("Coastland.", "Ocean.")
                .WithText("If you are off-course (Cloudy, Rainy, Stormy), Coast of Anfalas gets +2 Threat. Travel: Exhaust a Ship objective to travel here.")
                .WithShadow("Shadow: If you are off-course (Cloudy, Rainy, Stormy), attacking enemy gets +2 Attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(128, 3, Artist.Katy_Grierson));
            Cards.Add(LotRCard.Location("Belfalas Islet", string.Empty, setName, 1, 5)
                .WithTraits("Coastland.", "Ocean.")
                .WithText("You cannot travel to Belfalas Islet if you are off-course (Cloudy, Rainy, Stormy).\r\nResponse: After you travel to Belfalas Islet, choose a Ship enemy that is not guarding an objective. While Belfalas Islet is the active location, the chosen enemy is considered to be out of play.")
                .WithVictoryPoints(1)
                .WithInfo(129, 2, Artist.Ben_Zweifel));
            Cards.Add(LotRCard.Location("Cobas Haven", string.Empty, setName, 2, 4)
                .WithTraits("Coastland.", "Ocean.")
                .WithText("While Cobas Haven is the active location, reduce the Boarding X value on each Ship enemy by 1.")
                .WithFlavor("But beyond, in the great fief of Belfalas, dwelt Prince Imrahil in his castle of Dol Amroth by the sea...\r\n-The Return of the King")
                .WithInfo(130, 2, Artist.Simon_Dominic));
            Cards.Add(LotRCard.Treachery("Ramming Speed!", string.Empty, setName)
                .WithText("When Revealed: If you are off-course (Cloudy, Rainy, or Stormy), the engaged Ship enemy with the highest Attack makes an immediate attack. Until the end of the phase, add 1 to the total Threat in the staging area for each damage dealt by this attack. If no attack is made as a result of this effect, Ramming Speed! gains doomed 2.")
                .WithInfo(131, 2, Artist.Michael_Rasmussen)); //Navigation symbol
            Cards.Add(LotRCard.Treachery("Taking on Water", string.Empty, setName)
                .WithText("When Revealed: Attach to a Ship objective. (Counts as a Condition attachment with the text: \"Forced: When attached objective exhausts, deal 2 damage to it. Action: Exhaust 3 character you control to discard Taking on Water.\")")
                .WithShadow("Shadow: If defending character is a ship, attach Taking on Water to it.")
                .WithEasyModeQuantity(1)
                .WithInfo(132, 2, Artist.Ignacio_Bazan_Lazcano));
            Cards.Add(LotRCard.Treachery("The Raiders' Assault", string.Empty, setName)
                .WithText("When Revealed: Choose a Ship enemy that is not currently guarding an objective. Attach that enemy to an unguarded objective in the staging area, guarding it (return that enemy to the staging area if it is engaged). If no Ship enemy is returned to the staging area by this effect, The Raiders' Assault gains surge.")
                .WithInfo(133, 2, Artist.Michael_Rasmussen)); //Navigation symbol
            Cards.Add(LotRCard.Objective("Sea-ward Tower", string.Empty, setName)
                .WithUnique()
                .WithKeywords("Guarded.")
                .WithText("If Sea-ward Tower is free of encounters, add it to the staging area, controlled by the players.\r\nWhile the players control Sea-ward Tower, look at 2 additional cards from the top of the encounter deck during each Sailing test.")
                .WithInfo(134, 1, Artist.Michael_Rasmussen)); //Navigation symbol
            Cards.Add(LotRCard.Objective("Tower of the Gull", string.Empty, setName)
                .WithUnique()
                .WithKeywords("Guarded.")
                .WithText("If Tower of the Gull is free of encounters, add it to the staging area, controlled by the players.\r\nCombat Action: If the players control Tower of the Gull, exhaust it to deal 2 damage to a non-unique Ship enemy. Any player may trigger this action.")
                .WithInfo(135, 1, Artist.Ryan_Yee)); //Navigation symbol
            Cards.Add(LotRCard.Objective("The Beacon", string.Empty, setName)
                .WithUnique()
                .WithKeywords("Guarded.")
                .WithText("If The Beacon is free of encounters, add it to the staging area, controlled by the players.\r\nPlanning Action: If the players control The Beacon, exhaust it and spend 5 resources to take control of 1 set-aside copy of Dol Amroth Warship. Any player may trigger this action.")
                .WithInfo(136, 1, Artist.Titus_Lunter)); //Navigation symbol
            Cards.Add(LotRCard.Objective("Tower of the Heron", string.Empty, setName)
                .WithUnique()
                .WithKeywords("Guarded.")
                .WithText("If Tower of the Heron is free of encounters, add it to the staging area, controlled by the players.\r\nWhile Tower of the Heron is controlled by the players, reduce the archery total by 4.")
                .WithInfo(137, 1, Artist.Adam_Lane)); //Navigation symbol
        }
    }
}