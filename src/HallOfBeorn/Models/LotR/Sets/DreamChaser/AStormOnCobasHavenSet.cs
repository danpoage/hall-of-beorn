/* Generated CardSet class: A Storm on Cobas Haven */

using System;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class AStormOnCobasHavenSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "A Storm on Cobas Haven";
            Abbreviation = "ASoCH";
            Number = 39;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            addHero("Na'asiyah", 8, Sphere.Tactics, 1, 2, 2, 4)
                .WithTraits("Corsair.", "Warrior.")
                .WithTextLine("Resources in Na'asiyah's resource pool cannot be used to pay for allies.")
                .WithTextLine("Action: While Na'asiyah is attacking or defending, pay 1 resource from her resource pool to give her +2 Attack or +2 Defense for this attack.")
                .WithCommunityVersion("Autumn/Na'asiyah")
                .WithInfo(109, 1, Artist.Sara_Winters);
            addAttachment("Rune-master", 1, Sphere.Leadership, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Ranger or Leadership hero.")
                .WithTextLine("Response: After a Signal attachment is attached to a hero, exhaust Rune-master to add 1 resource to that hero's resource pool.")
                .WithInfo(110, 3, Artist.Kim_Sokol);
            addEvent("Terrible to Behold", 1, Sphere.Leadership)
                .WithTextLine("Response: After you declare a Noble character as a defender against an attack made by an engaged enemy, return that enemy to the staging area. Then, cancel the attack.")
                .WithFlavorLine("So great a power and royalty was revealed in Aragorn...that many of the wild men paused, and looked back over their shoulders to the valley, and some looked up doubtfully at the sky.")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(111, 3, Artist.Jason_Cheeseman_Meyer);
            addAlly("Veteran Sword-elf", 3, Sphere.Tactics, false, 1, 1, 1, 3)
                .WithTraits("Noldor.", "Warrior.")
                .WithTextLine("~Veteran Sword-elf gets +1 Attack and +1 Defense for each copy of ~Veteran Sword-elf in your discard pile.")
                .WithFlavorLine("The elves were the first to charge. Their hatred for the goblins is cold and bitter.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(112, 3, Artist.Ramon_Puasa_Jr);
            addAttachment("Vigilant Guard", 3, Sphere.Tactics, false)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a Warrior character. Limit 1 per character.")
                .WithTextLine("Attached character gets +2 hit points.")
                .WithTextLine("Response: When another character would be assigned any amount of damage, place 1 of that damage on attached character instead.")
                .WithInfo(113, 3, Artist.Lukasz_Jaskolski);
            addEvent("Knife-work", 1, Sphere.Tactics)
                .WithTextLine("Action: Choose a player. Each enemy engaged with that player gets -1 Defense until the end of the phase. Then, the players as a group may spend 2 Lore resources to have the chosen player draw 1 card each time he attacks and destroys an enemy this phase.")
                .WithFlavorLine("\"Good!\" said Legolas. \"But my count is now two dozen. It has been knife-work up here.\" -The Two Towers")
                .WithInfo(114, 3, Artist.Joshua_Cairos);
            addAlly("Linhir Sea-captain", 3, Sphere.Spirit, false, 2, 0, 1, 2)
                .WithTraits("Gondor.")
                .WithTextLine("Response: After you play Linhir Sea-captain from your hand, if you paid all of its resouce cost from a single hero's resource pool, both that hero and Linhir Sea-captain do not exhaust to quest this round.")
                .WithInfo(115, 3, Artist.Kim_Sokol);
            addAttachment("Windfola", 1, Sphere.Spirit, true)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Spirit hero, or to Éowyn. Restricted.")
                .WithTextLine("Attached character gets +1 Willpower.")
                .WithTextLine("Response: After attached character is removed from the quest, exhaust Windfola to commit attached hero to the quest.")
                .WithFlavorLine("...the great grey steed Windfola made little of the burden; for Dernhelm was less in weight than many men, though lithe and well-knit in frame. -The Return of the King")
                .WithTemplate("<p class='main-text'>Attach to a {sphere:Spirit} hero, or to {title:Eowyn@Éowyn}. {keyword:Restricted.}</p><p class='main-text'>Attached hero gets +1 {Willpower}.</p><p class='main-text'><b>Response:</b> After attached character is removed from the quest, exhaust {self} to commit attached hero to the quest.</p><p class='flavor-text'>...the great grey steed Windfola made little of the burden; for Dernhelm was less in weight than many men, though lithe and well-knit in frame. &ndash;The Return of the King</p>")
                .WithInfo(116, 3, Artist.Sandara_Tang);
            addAlly("Ioreth", 0, Sphere.Lore, true, 0, 0, 0, 1)
                .WithTraits("Gondor.", "Healer.")
                .WithTextLine("Cannot attack or defend.")
                .WithTextLine("Action: Spend 1 Lore resource and exhaust Ioreth. Then, heal 3 points of damage on a character. Any player may trigger this action.")
                .WithFlavorLine("Thus spake Ioreth, wise-woman of Gondor: The hands of the king are the hands of a healer, and so shall the rightful king be known.")
                .WithFlavorLine("-The Return of the King")
                .WithCommunityVersion("RiddermarkLord/Ioreth-MotK-Lore-Hero")
                .WithInfo(117, 3, Artist.Aleksander_Karcz);
            addEvent("The Houses of Healing", 5, Sphere.Lore)
                .WithTextLine("You may exhaust any number of Healer characters you control as part of this card's cost. Reduce the cost to play this card by 1 for each Healer character you exhaust in this way.")
                .WithTextLine("Refresh Action: Choose a hero in any player's discard pile. Put that hero into play under its owner's control, with 1 damage token on it.")
                .WithInfo(118, 3, Artist.Mariusz_Gandzel);
            addEvent("Justice Shall Be Done", 0, Sphere.Neutral)
                .WithTextLine("Limit 1 per deck.")
                .WithTextLine("Planning Action: Add Justice Shall Be Done to the victory display to draw 3 cards and add 3 resources to the resource pool of each hero you control. At the end of the round, you are eliminated from the game.")
                .WithFlavorLine("\"...it is the last move in a great jeopardy, and for one side or the other it will bring the end of the game.\"")
                .WithFlavorLine("-Aragorn, The Return of the King")
                .WithVictoryPoints(1)
                .WithLimitOnePerDeck()
                .WithInfo(119, 3, Artist.Dmitry_Prosvirnin);
            addQuest("Outmaneuver the Enemy", EncounterSet.AStormOnCobasHaven, 1, 'A', 10)
                .WithKeywords("Sailing.")
                .WithTextLine("Setup: Prepare the Corsair deck. Players prepare their fleet. Set each copy of Dol Amroth Warship aside, out of play. Search the encounter deck for Raider Flagship and 1 copy of Scouting Ship, and add them to the staging area. Search the encounter deck for a Dol Amroth objective of your choice and add it to the staging area. Then, shuffle the encounter deck and resolve the Guarded keyword on that objective.")
                .WithFlavorLine("Corsairs are attacking Dol Amroth to cover Sahír's escape to Umbar!")
                .WithOppositeTextLine("Sailing.")
                .WithOppositeTextLine("Forced: When a Ship enemy engages you, if you are off-course (Cloudy, Rainy or Stormy), deal 2 damage to a Ship objective you control. If you are on-course (Sunny), deal 2 damage to that Ship enemy instead.")
                .WithOppositeTextLine("If your current heading is at the worst setting (Stormy), Raider Flagship gets -50 engagement cost.")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders, EncounterSet.CorsairPirates, EncounterSet.UmbarFleet, EncounterSet.VoyageAcrossBelegaer, EncounterSet.TheDreamChasersFleet)
                .WithInfo(120, 1, Artist.Adam_Lane);
            addQuest("Battle in the Bay", EncounterSet.AStormOnCobasHaven, 2, 'A', 16)
                .WithKeywords("Sailing.")
                .WithTextLine("When Revealed: Search the encounter deck and discard pile for a Ship enemy and add it to the staging area (2 Ship enemies instead if there are 3 or 4 players in the game). Shuffle the encounter deck. For each unguarded objective in the staging area, attach a non-unique Ship enemy in the staging area to that objective, guarding it.")
                .WithFlavorLine("The Corsair fleet seems to be attacking multiple key locations simultaneously. To stop the attack, you must defend Dol Amroth from the Corsair ships.")
                .WithOppositeTextLine("Sailing.")
                .WithOppositeTextLine("If your current heading is at the worst setting (Stormy), Raider Flagship gets -50 engagement cost.")
                .WithOppositeTextLine("You cannot advance while at least 1 objective is guarded by an encounter.")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders, EncounterSet.CorsairPirates, EncounterSet.UmbarFleet, EncounterSet.VoyageAcrossBelegaer, EncounterSet.TheDreamChasersFleet)
                .WithInfo(121, 1, Artist.Sergey_Glushakov);
            addQuest("Break Through the Fleet!", EncounterSet.AStormOnCobasHaven, 3, 'A', 5)
                .WithKeywords("Sailing.")
                .WithTextLine("When Revealed: The players make engagement checks against each enemy in the staging area. Raider Flagship gets -50 engagement cost during these engagement checks.")
                .WithFlavorLine("\"You have to go after Sahír!\" Imrahil yells as the battle rages on. \"We will finish this fight!\"")
                .WithOppositeTextLine("Sailing.")
                .WithOppositeTextLine("Raider Flagship gets -50 engagement cost.")
                .WithOppositeTextLine("Break Through the Fleet! has +5 quest points for each Ship enemy in play.")
                .WithOppositeTextLine("If this stage is defeated, or if Raider Flagship is in the victory display, the players have broken through the Corsair fleet and win the game!")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders, EncounterSet.CorsairPirates, EncounterSet.UmbarFleet, EncounterSet.VoyageAcrossBelegaer, EncounterSet.TheDreamChasersFleet)
                .WithInfo(122, 1, Artist.Joshua_Cairos);
            addShipObjective("Dol Amroth Warship", EncounterSet.AStormOnCobasHaven, false, 2, 2, 2, 8)
                .WithTraits("Gondor.", "Ship.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("If you are on-course (Sunny), Dol Amroth Warship gets +2 Willpower, +2 Attack, and +2 Defense.")
                .WithTextLine("Forced: When Dol Amroth Warship is destroyed, set it aside, out of play.")
                .WithInfo(123, 2, Artist.Ignacio_Bazan_Lazcano);
            addShipEnemy("Raider Flagship", EncounterSet.AStormOnCobasHaven, 50, 3, 5, 3, 18)
                .WithUnique()
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithTextLine("Boarding 1. Immune to player card effects.")
                .WithTextLine("Only Ship objectives can be declared as attackers against ~Raider Flagship.")
                .WithTextLine("Forced: At the end of the encounter phase, the engaged player reveals the top card of the ~Corsair deck and engages it.")
                .WithTemplate("<p class='main-text'>{keyword:Boarding 1.} Immune to player card effects.</p><p class='main-text'>Only {trait:Ship.@Ship} objectives can be declared as attackers againt {self}.<p class='main-text'><b>Forced:</b> At the end of the encounter phase, the engaged player reveals the top card of the Corsair deck and engages it.</p>{victory:20}")
                .WithVictoryPoints(20)
                .WithInfo(124, 1, Artist.Michael_Rasmussen);
            addShipEnemy("Corsair Skirmisher", EncounterSet.AStormOnCobasHaven, 28, 3, 4, 4, 6)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithTextLine("Boarding 1. Immune to player card effects.")
                .WithTextLine("Response: After Corsair Skirmisher is destroyed as an enemy, the engaged player may discard allies he controls with a total of at least 3 Willpower ti take control of Corsair Skirmisher as a Ship-Objective with Willpower equal to its Threat. (It loses the Ship-Enemy card type and gains the Ship-Objective card type).")
                .WithInfo(125, 2, Artist.Mariusz_Gandzel);
            addShipEnemy("Siege Ship", EncounterSet.AStormOnCobasHaven, 46, 2, 5, 5, 7)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Archery 2.")
                .WithTextLine("Archery 2. Cannot have attachments.")
                .WithTextLine("While Siege Ship is in the staging area, it gains: \"Forrced: at the end of the quest phase, if Siege Ship is not guarding an objective and there is an unguarded objective in the staging area, attach Siege Ship to that objective, guarding it.\"")
                .WithEasyModeQuantity(2)
                .WithInfo(126, 3, Artist.Michael_Rasmussen);
            addShipEnemy("Heavy Cruiser", EncounterSet.AStormOnCobasHaven, 42, 5, 7, 5, 8)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithTextLine("Boarding 2. Cannot have attachments.")
                .WithTextLine("When Revealed: Search the encounter deck and discard pile for a Dol Amroth objective and add it to the staging area. Then, attach Heavy Crusier to that objective, guarding it. Shuffle the encounter deck.")
                .WithEasyModeQuantity(0)
                .WithInfo(127, 1, Artist.Sergey_Glushakov);
            addLocation("Coast of Anfalas", EncounterSet.AStormOnCobasHaven, 3, 3)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("If you are off-course (Cloudy, Rainy, Stormy), Coast of Anfalas gets +2 Threat. Travel: Exhaust a Ship objective to travel here.")
                .WithShadow("Shadow: If you are off-course (Cloudy, Rainy, Stormy), attacking enemy gets +2 Attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(128, 3, Artist.Katy_Grierson);
            addLocation("Belfalas Islet", EncounterSet.AStormOnCobasHaven, 1, 5)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("You cannot travel to Belfalas Islet if you are off-course (Cloudy, Rainy, Stormy).")
                .WithTextLine("Response: After you travel to Belfalas Islet, choose a Ship enemy that is not guarding an objective. While Belfalas Islet is the active location, the chosen enemy is considered to be out of play.")
                .WithVictoryPoints(1)
                .WithInfo(129, 2, Artist.Ben_Zweifel);
            addLocation("Cobas Haven", EncounterSet.AStormOnCobasHaven, 2, 4)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("While Cobas Haven is the active location, reduce the Boarding X value on each Ship enemy by 1.")
                .WithFlavorLine("But beyond, in the great fief of Belfalas, dwelt Prince Imrahil in his castle of Dol Amroth by the sea...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(130, 2, Artist.Simon_Dominic);
            addTreachery("Ramming Speed!", EncounterSet.AStormOnCobasHaven)
                .WithTextLine("When Revealed: If you are off-course (Cloudy, Rainy, or Stormy), the engaged Ship enemy with the highest Attack makes an immediate attack. Until the end of the phase, add 1 to the total Threat in the staging area for each damage dealt by this attack. If no attack is made as a result of this effect, Ramming Speed! gains doomed 2.")
                .WithInfo(131, 2, Artist.Michael_Rasmussen);
            addTreachery("Taking on Water", EncounterSet.AStormOnCobasHaven)
                .WithTextLine("When Revealed: Attach to a Ship objective. (Counts as a Condition attachment with the text: \"Forced: When attached objective exhausts, deal 2 damage to it. Action: Exhaust 3 character you control to discard Taking on Water.\")")
                .WithShadow("Shadow: If defending character is a ship, attach Taking on Water to it.")
                .WithEasyModeQuantity(1)
                .WithInfo(132, 2, Artist.Ignacio_Bazan_Lazcano);
            addTreachery("The Raiders' Assault", EncounterSet.AStormOnCobasHaven)
                .WithTextLine("When Revealed: Choose a Ship enemy that is not currently guarding an objective. Attach that enemy to an unguarded objective in the staging area, guarding it (return that enemy to the staging area if it is engaged). If no Ship enemy is returned to the staging area by this effect, The Raiders' Assault gains surge.")
                .WithInfo(133, 2, Artist.Michael_Rasmussen);
            addObjective("Sea-ward Tower", EncounterSet.AStormOnCobasHaven)
                .WithUnique()
                .WithKeywords("Guarded.")
                .WithTextLine("Guarded.")
                .WithTextLine("If Sea-ward Tower is free of encounters, add it to the staging area, controlled by the players.")
                .WithTextLine("While the players control Sea-ward Tower, look at 2 additional cards from the top of the encounter deck during each Sailing test.")
                .WithInfo(134, 1, Artist.Michael_Rasmussen);
            addObjective("Tower of the Gull", EncounterSet.AStormOnCobasHaven)
                .WithUnique()
                .WithKeywords("Guarded.")
                .WithTextLine("Guarded.")
                .WithTextLine("If Tower of the Gull is free of encounters, add it to the staging area, controlled by the players.")
                .WithTextLine("Combat Action: If the players control Tower of the Gull, exhaust it to deal 2 damage to a non-unique Ship enemy. Any player may trigger this action.")
                .WithInfo(135, 1, Artist.Ryan_Yee);
            addObjective("The Beacon", EncounterSet.AStormOnCobasHaven)
                .WithUnique()
                .WithKeywords("Guarded.")
                .WithTextLine("Guarded.")
                .WithTextLine("If The Beacon is free of encounters, add it to the staging area, controlled by the players.")
                .WithTextLine("Planning Action: If the players control The Beacon, exhaust it and spend 5 resources to take control of 1 set-aside copy of Dol Amroth Warship. Any player may trigger this action.")
                .WithInfo(136, 1, Artist.Titus_Lunter);
            addObjective("Tower of the Heron", EncounterSet.AStormOnCobasHaven)
                .WithUnique()
                .WithKeywords("Guarded.")
                .WithTextLine("Guarded.")
                .WithTextLine("If Tower of the Heron is free of encounters, add it to the staging area, controlled by the players.")
                .WithTextLine("While Tower of the Heron is controlled by the players, reduce the archery total by 4.")
                .WithInfo(137, 1, Artist.Adam_Lane);
        }
    }
}
