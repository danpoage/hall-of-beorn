﻿//CardSet: Mustering of the Rohirrim
/* Generated CardSet class: Mustering of the Rohirrim */

using System;

namespace HallOfBeorn.Models.LotR.Sets.OathsOfTheRohirrim
{
    public class MusteringOfTheRohirrimSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Mustering of the Rohirrim";
            Abbreviation = "MotR";
            Number = 10006;
            SetType = Models.SetType.A_Long_extended_Party;
            Cycle = "Oaths of the Rohirrim";

            addHero("Rowan", 10, Sphere.Leadership, 2, 1, 3, 3)
                .WithTraits("Woodman.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: After you play an attachment on a location, add 1 resource to the pool of a hero you control. (Limit once per round.)")
                .WithTextLine("Quest Action: Choose a player to take control of the first player token. Each player can only be chosen once per game.")
                .WithInfo(144, 1, Artist.yangzheyy);
            addHero("Osbera", 10, Sphere.Lore, 2, 1, 2, 5)
                .WithSlugSuffix("SideA")
                .WithTraits("Beorning.")
                .WithTextLine("Reduce the total Threat in the staging area by 1 for each damaged Beorning character you control (limit –5 Threat).")
                .WithTextLine("Response: After you engage an enemy, spend 1 resource from Osbera’s pool to flip her.")
                .WithFlavorLine("“I don’t need your service, thank you. But I expect you need mine.”")
                .WithFlavorLine("—Beorn, The Hobbit")
                .WithSideA()
                .WithInfo(145, 1, Artist.Torbjorn_Kallstrom);
            addHero("Osbera", 10, Sphere.Tactics, 1, 3, 1, 5)
                .WithSlugSuffix("SideB")
                .WithTraits("Creature.", "Beorning.")
                .WithTextLine("Cannot have restricted attachments. If you are not engaged with an enemy, flip Osbera.")
                .WithTextLine("Response: Deal 1 damage to a Beorning character you control to cancel 2 points of damage just dealt to a character you control. (Limit once per round.)")
                .WithFlavorLine("“Not eaten up by Wargs or goblins or wicked bears yet I see.”")
                .WithFlavorLine("—Beorn, The Hobbit")
                .WithSideB()
                .WithInfo(145, 1, Artist.Torbjorn_Kallstrom);
            addAttachment("Woodmen's Outpost", 1, Sphere.Leadership, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a location. Limit 1 per location.")
                .WithTextLine("Response: After attached location is explored, each character controlled by the first player gets +1 Attack and +1 Defense until the end of the round.")
                .WithFlavorLine("“…even the Wargs dared not attack them if there were many together, or in the bright day.”")
                .WithFlavorLine("—The Hobbit")
                .WithInfo(146, 3, Artist.Jon_Hodgson);
            addAttachment("Lie of the Land", 1, Sphere.Spirit, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a location.")
                .WithTextLine("Action: Exhaust a Scout character to place 1 progress on attached location. If that location is not explored by this effect, you may attach Lie of the Land to another location.")
                .WithFlavorLine("“We shall have to scour the lands all round for many long leagues before any move is made.”")
                .WithFlavorLine("—Gandalf, The Fellowship of the Ring")
                .WithInfo(147, 3, Artist.Sarel_Theron);
            addAlly("Hunting Dogs", 3, Sphere.Spirit, false, 2, 2, 0, 2)
                .WithTraits("Creature.", "Scout.")
                .WithKeywords("Devoted.")
                .WithTextLine("Devoted. Cannot have attachments.")
                .WithTextLine("Response: After a location with an attachment is explored, ready Hunting Dogs.")
                .WithFlavorLine("“Hound is hungry, hare is fearful.”")
                .WithFlavorLine("—Treebeard, The Two Towers")
                .WithInfo(148, 3, Artist.Charmaine_Zoe);
            addAlly("Beorning Pony", 2, Sphere.Tactics, false, 1, 1, 1, 2)
                .WithTraits("Creature.", "Beorning.", "Pony.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Response: After Beorning Pony enters play, discard the top 5 cards of your deck. Then, you may spend 1 Tactics resource to add one of the cards discarded by this effect to your hand.")
                .WithFlavorLine("There was just room to get the ponies through with a squeeze, when they had been unpacked and unsaddled.")
                .WithFlavorLine("—The Hobbit")
                .WithInfo(149, 3, Artist.Torbjorn_Kallstrom);
            addAlly("Birna", 3, Sphere.Tactics, true, 2, 0, 1, 3)
                .WithTraits("Beorning.")
                .WithTextLine("Action: Exhaust Birna and spend 1 Tactics resource to put a Beorning ally from your discard pile into play. At the end of the phase, if that ally is still in play or in your discard pile, shuffle it into your deck.")
                .WithFlavorLine("In that last hour Beorn himself had appeared - no one knew how or from where.")
                .WithFlavorLine("—The Hobbit")
                .WithInfo(150, 3, Artist.Simone_De_Salvatore);
            addEvent("Descendants of Beorn", 0, Sphere.Tactics)
                .WithTextLine("Response: When a Beorning ally you control leaves play, add 1 resource to a Beorning hero’s pool for each damage token that was on that ally (up to that ally’s printed hit points).")
                .WithFlavorLine("He tossed wolves and goblins from his path like straws and feathers.")
                .WithFlavorLine("—The Hobbit")
                .WithInfo(151, 3, Artist.Jon_Hodgson);
            addAttachment("Beorn’s Welcome", 1, Sphere.Tactics, false)
                .WithTraits("Boon.")
                .WithTextLine("Play only if you control a Beorning hero. Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Response: After you spend any resources from attached hero’s pool for a purpose other than paying to play a card, exhaust Beorn’s Welcome to add 1 resource to attached hero’s pool.")
                .WithFlavorLine("“I am Gandalf,” said the wizard. “Never heard of him,” growled the man.")
                .WithFlavorLine("—The Hobbit")
                .WithInfo(152, 3, Artist.Jon_Hodgson);
            addAttachment("Subdued", 1, Sphere.Tactics, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a damaged enemy engaged with you. Limit 1 per enemy.")
                .WithTextLine("Attached enemy gets −4 Attack.")
                .WithFlavorLine("His miserable enemy lay grovelling on the stones whimpering.")
                .WithFlavorLine("—The Two Towers")
                .WithInfo(153, 3, Artist.Alan_Lee);
            addEvent("Without My Hat", 2, Sphere.Neutral)
                .WithTextLine("Limit 1 copy of Without My Hat in the victory display.")
                .WithTextLine("Action: Add Without My Hat to the victory display to search your collection for an attachment. If no copy of that attachment was in your deck during setup, add it to your hand.")
                .WithVictoryPoints(1)
                .WithInfo(154, 3, Artist.Vincent_Van_Gogh);
            addEnemy("Raven Clan Warchief", EncounterSet.MusteringOfTheRohirrim, 30, 4, 5, 4, 7)
                .WithUnique()
                .WithTraits("Dunland.", "Raven Clan.", "Massing.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: When Raven Clan Warchief attacks, place 1 damage token on Massing at the Isen.")
                .WithTextLine("Forced: When Raven Clan Warchief is defeated, shuffle him and the encounter discard pile into the encounter deck.")
                .WithInfo(155, 1, Artist.XallowArt);
            addLocation("The Far Bank", EncounterSet.MusteringOfTheRohirrim, 2, 1)
                .WithUnique()
                .WithTraits("Massing.")
                .WithTextLine("Immune to player card effects. The players cannot travel to The Far Bank.")
                .WithTextLine("Enemies in play get +5 engagement cost.")
                .WithTextLine("Forced: After a player optionally engages an enemy, that enemy makes an immediate attack against them.")
                .WithInfo(156, 1, Artist.arvdevable);
            addTreachery("Bitter Betrayal", EncounterSet.MusteringOfTheRohirrim)
                .WithTraits("Massing.")
                .WithTextLine("When Revealed: The highest cost ally each player controls makes an immediate attack against the player that controls it. Until the end of these attacks, each of these cards loses the ally card type and gains the enemy card type. Then, remove those allies from the game. Add Bitter Betrayal to the victory display. This effect cannot be canceled.")
                .WithVictoryPoints(1)
                .WithInfo(157, 1, Artist.Bitbox_Ltd);
            addTreachery("Coup", EncounterSet.MusteringOfTheRohirrim)
                .WithTraits("Massing.")
                .WithTextLine("When Revealed: Each player must choose: either raise your threat by 6, or discard a hero you control from play. Add Coup to the victory display. This effect cannot be canceled.")
                .WithFlavorLine("“When I heard that Shadowfax had come back riderless, I rejoiced at the return of the horse, but still more at the lack of the rider.”")
                .WithFlavorLine("—Gríma, The Two Towers")
                .WithVictoryPoints(1)
                .WithInfo(158, 1, Artist.Laura_Csajagi);
            addTreachery("Scattered to the Winds", EncounterSet.MusteringOfTheRohirrim)
                .WithTraits("Massing.")
                .WithTextLine("When Revealed: Each player chooses half the non-objective allies they control (rounded up) and shuffles them into their owner’s deck. Add Scattered to the Winds to the victory display. This effect cannot be canceled.")
                .WithFlavorLine("“We shall all be scattered and lost.”")
                .WithFlavorLine("—Aragorn, The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithInfo(159, 1, Artist.Eliott_Bon);
            addEnemy("Orc-host Remnant", EncounterSet.MusteringOfTheRohirrim, 33, Card.VALUE_X, Card.VALUE_X, 4, 12)
                .WithUnique()
                .WithTraits("Orc.")
                .WithTextLine("X is the number of damage tokens on Orc-host Remnant. Cannot have attachments. Only the engaged player may declare attackers or defenders against Orc-host Remnant.")
                .WithTextLine("Forced: After Orc-host Remnant takes any amount of damage, return it to the staging area.")
                .WithVictoryPoints(5)
                .WithInfo(160, 1, Artist.Bayard_Wu);
            addEnemy("Curuwyn The Whisperer", EncounterSet.MusteringOfTheRohirrim, 20, 5, 4, 6, 4)
                .WithUnique()
                .WithTraits("Assassin.", "Gondor.")
                .WithTextLine("Forced: At the beginning of the encounter phase, Curuwyn The Whisperer engages the player with the highest threat.")
                .WithTextLine("Forced: After Curuwyn The Whisperer attacks, the defending player must either place 1 damage token on Massing at the Isen, or raise their threat by 4.")
                .WithVictoryPoints(5)
                .WithInfo(161, 1, Artist.Akunohako);
            addEnemy("Felberen Scion of Freca", EncounterSet.MusteringOfTheRohirrim, 30, 3, 5, 5, 4)
                .WithUnique()
                .WithTraits("Assassin.", "Dunland.", "Rohan.")
                .WithTextLine("Forced: At the beginning of the encounter phase, Felberen Scion of Freca engages the player with the most cards in hand.")
                .WithTextLine("Forced: After Felberen Scion of Freca attacks, the defending player must either place 1 damage token on Massing at the Isen, or discard their hand.")
                .WithVictoryPoints(5)
                .WithInfo(162, 1, Artist.Conor_Burke);
            addEnemy("Smeóhbrand Rogue of Orthanc", EncounterSet.MusteringOfTheRohirrim, 25, 5, 4, 4, 6)
                .WithUnique()
                .WithTraits("Assassin.", "Isengard.", "Rohan.")
                .WithTextLine("Forced: At the beginning of the encounter phase, Smeóhbrand Rogue of Orthanc engages the player who controls the fewest characters.")
                .WithTextLine("Forced: After Smeóhbrand Rogue of Orthanc attacks for the first time each round, he makes an additional attack. The engaged player may place 1 damage token on Massing at the Isen to cancel this effect.")
                .WithVictoryPoints(5)
                .WithInfo(163, 1, Artist.Jarek_Nocon);
            addLocation("Írensaga", EncounterSet.MusteringOfTheRohirrim, 4, 8)
                .WithUnique()
                .WithTraits("Mountain.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Írensaga gets +2Per Player quest points. While Írensaga is the active location, players cannot play allies.")
                .WithTextLine("Forced: At the end of the round, if Írensaga is in the staging area, place 1 damage token on Massing at the Isen.")
                .WithVictoryPoints(5)
                .WithInfo(164, 1, Artist.Bastien_Grivet);
            addEncounterSideQuest("Assassin at Edoras", EncounterSet.MusteringOfTheRohirrim, 6)
                .WithTraits("Mustering.")
                .WithTextLine("When Revealed: The first player randomly selects a set aside Assassin enemy and adds it to the staging area. Each other player reveals an encounter card.")
                .WithTextLine("Assassin enemies are immune to player card effects. While Assassin at Edoras has any remaining quest points, Assassin enemies cannot take damage.")
                .WithTextLine("This stage cannot be defeated while an Assassin enemy is in play.")
                .WithFlavorLine("Under threat of assassination, Thengel has placed Edoras on high alert.")
                .WithSideA()
                .WithInfo(165, 1, Artist.Sergey_Zabelin);
            addObjectiveAlly("Host of Rohan", EncounterSet.MusteringOfTheRohirrim, 3, 4, 3, 5)
                .WithTraits("Rohan.")
                .WithKeywords("Immune to player card effects.", "Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("The first player gains control of Host of Rohan.")
                .WithTextLine("Action: The players as a group may spend 2 resources to ready Host of Rohan. (Limit once per phase.)")
                .WithTextLine("If Host of Rohan leaves play, remove it from the game.")
                .WithFlavorLine("Safe from harm, the king is now free to dispatch his hosts.")
                .WithSideB()
                .WithInfo(165, 1, Artist.Julia_Alekseeva);
            addEncounterSideQuest("Road to Ruin", EncounterSet.MusteringOfTheRohirrim, 1)
                .WithTraits("Mustering.")
                .WithTextLine("When Revealed: The first player adds Orc-host Remnant to the staging area and deals 4 damage to it. Each other player reveals an encounter card.")
                .WithTextLine("Forced: At the end of the round, deal 1 damage to Orc-host Remnant.")
                .WithTextLine("This stage cannot be defeated unless Orc-host Remnant is in the victory display.")
                .WithFlavorLine("The regrouping orcish warband threatens the embattled horsebreakers on the road.")
                .WithInfo(166, 1, Artist.Ignacio_Bazan_Lazcano);
            addObjective("Folcwine", EncounterSet.MusteringOfTheRohirrim)
                .WithUnique()
                .WithTraits("Mount.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Exhaust Folcwine to either ready attached hero, or give attached hero +1 Willpower, +1 Attack, and +1 Defense until the end of the phase.")
                .WithFlavorLine("The last foal of Felaróf the Mighty, wrested from the clutches of the orcish horde.")
                .WithInfo(166, 1, Artist.ASTERAS);
            addEncounterSideQuest("Winter in Westemnet", EncounterSet.MusteringOfTheRohirrim, 1)
                .WithTraits("Mustering.")
                .WithTextLine("When Revealed: The first player adds Írensaga to the staging area. Each other player reveals an encounter card.")
                .WithTextLine("Enemies get +1 Threat and do not make engagement checks.")
                .WithTextLine("This stage cannot be defeated unless Írensaga is in the victory display.")
                .WithFlavorLine("Éomund’s scouts have ranged far and wide in their hunt for Gálmód. News of his capture will surely bring new allies to your cause.")
                .WithInfo(167, 1, Artist.Heerie);
            addObjective("Devoted Determination", EncounterSet.MusteringOfTheRohirrim)
                .WithTraits("Condition.")
                .WithTextLine("The first ally played by each player each round does not require a resource match.")
                .WithFlavorLine("With the conspirator Gálmód in chains, allies come to honor their oaths.")
                .WithInfo(167, 1, Artist.Wouter_Florusse);
            addObjective("Massing at the Isen", EncounterSet.MusteringOfTheRohirrim)
                .WithTextLine("Forced: At the end of the round, place 1 damage token here.")
                .WithTextLine("If there are 5 or more damage tokens here, remove 5 of them and reveal the top card of the Massing deck. If you cannot, the players lose the game.")
                .WithFlavorLine("Ealdwulf prepares his army for war on the banks of the Isen River.")
                .WithInfo(168, 1, Artist.Bethesda_Softworks);
            addLocation("Deeping-stream", EncounterSet.MusteringOfTheRohirrim, 3, 1)
                .WithUnique()
                .WithTraits("Plains.", "River.")
                .WithTextLine("Deeping-stream gets +3Per Player quest points.")
                .WithTextLine("Forced: At the end of the round, place 1 damage token on Massing at the Isen.")
                .WithFlavorLine("You must ride from your paltry camp beside the Glittering Caves, ere Ealdwulf sunders the kingdom of Rohan with his ambition.")
                .WithVictoryPoints(5)
                .WithInfo(169, 1, Artist.Laszlo_Neogrady);
            addEnemy("Aldburg Provocateur", EncounterSet.MusteringOfTheRohirrim, 35, 4, 2, 4, 3)
                .WithTraits("Rohan.", "Traitor.")
                .WithTextLine("Each card played by the engaged player gains Doomed 1.")
                .WithFlavorLine("“There is a third kind: pickers of bones, meddlers in other men’s sorrows, carrion-fowl that grow fat on war.”")
                .WithFlavorLine("—Gríma, The Two Towers")
                .WithEasyModeQuantity(1)
                .WithInfo(170, 3, Artist.Matt_Donnici);
            addEnemy("Pernicious Plotter", EncounterSet.MusteringOfTheRohirrim, 40, 2, 2, 2, 2)
                .WithTraits("Rohan.", "Brigand.", "Traitor.")
                .WithTextLine("Forced: At the end of the round, place 1 damage token on Massing at the Isen.")
                .WithShadow("Shadow: Either place 1 damage token on Massing at the Isen, or return attacking enemy to the staging area after this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(171, 3, Artist.Tatiana_Tyukina);
            addEnemy("Sniveling Courtier", EncounterSet.MusteringOfTheRohirrim, 11, 2, 0, 0, 1)
                .WithTraits("Rohan.", "Servant.", "Traitor.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible.")
                .WithTextLine("Forced: After Sniveling Courtier makes an undefended attack against you, either place 1 damage token on Massing at the Isen, or raise your threat by 3.")
                .WithTextLine("Refresh Action: The engaged player may spend 2 resources to discard Sniveling Courtier.")
                .WithInfo(172, 3, Artist.Bethesda_Softworks);
            addEnemy("Spiteful Hunter", EncounterSet.MusteringOfTheRohirrim, 32, 3, 1, 2, 3)
                .WithTraits("Rohan.", "Brigand.", "Traitor.")
                .WithTextLine("Spiteful Hunter gets +1 Attack for each exhausted hero controlled by the defending player.")
                .WithShadow("Shadow: Either place 1 damage token on Massing at the Isen, or attacking enemy gets +3 Attack.")
                .WithInfo(173, 2, Artist.Runar_Steinn);
            addEnemy("Raven Clan Sharpshooter", EncounterSet.MusteringOfTheRohirrim, 41, 2, 4, 1, 3)
                .WithTraits("Dunland.", "Raven Clan.")
                .WithTextLine("While any player has 3 or more cards in hand, Raven Clan Sharpshooter gains Archery 3.")
                .WithTextLine("While any player has 5 or more cards in hand, Raven Clan Sharpshooter cannot be optionally engaged.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(174, 3, Artist.Paolo_Puggioni);
            addLocation("Orator’s Hall", EncounterSet.MusteringOfTheRohirrim, 2, 6)
                .WithUnique()
                .WithTraits("Village.")
                .WithTextLine("The players cannot travel to Orator’s Hall. Progress cannot be placed here by player card effects.")
                .WithTextLine("Planning Action: Exhaust a hero you control to place progress on Orator’s Hall equal to that hero’s printed Willpower. If Orator’s Hall is explored by this effect, remove 1 damage token from Massing at the Isen. Any player may trigger this effect.")
                .WithVictoryPoints(1)
                .WithInfo(175, 1, Artist.Nele_Diel);
            addLocation("Traitor’s Redoubt", EncounterSet.MusteringOfTheRohirrim, 4, 4)
                .WithUnique()
                .WithTraits("Fortification.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Travel: Each player searches the encounter deck and discard pile for a Traitor enemy and puts it into play engaged with them.")
                .WithTextLine("Response: When Traitor’s Redoubt leaves play as an explored location, remove 1 damage token from Massing at the Isen.")
                .WithVictoryPoints(1)
                .WithInfo(176, 1, Artist.Bethesda_Softworks);
            addLocation("Plains of Strife", EncounterSet.MusteringOfTheRohirrim, 1, 6)
                .WithTraits("Plains.", "Battleground.")
                .WithKeywords("Vast.")
                .WithTextLine("Vast.")
                .WithTextLine("While Plains of Strife is in the staging area, Rohan enemies get +1 Threat.")
                .WithTextLine("While Plains of Strife is the active location, Rohan enemies get +1 Attack.")
                .WithShadow("Shadow: If attacking enemy has the Rohan trait, it makes an additional attack against you after this one.")
                .WithInfo(177, 2, Artist.Vilius_Petrauskas);
            addTreachery("Cutthroat’s Strike", EncounterSet.MusteringOfTheRohirrim)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("While attached to an enemy, counts as a Condition attachment with the text: “Forced: When attached enemy attacks, it gets +5 Attack for that attack. Then, discard Cutthroat’s Strike.”")
                .WithTextLine("When Revealed: Attach to the enemy in play with the lowest engagement cost without a copy of Cutthroat’s Strike attached.")
                .WithEasyModeQuantity(1)
                .WithInfo(178, 2, Artist.Bethesda_Softworks);
            addQuest("Oaths of the Rohirrim", EncounterSet.MusteringOfTheRohirrim, 1, 'A', 6)
                .WithTextLine("Setup: Shuffle the 5 cards with the Massing trait together into a Massing deck. Search the encounter deck for Írensaga, Orc-host Remnant, each Assassin enemy, and each Mustering side quest and set them aside, out of play. The first player adds Massing at the Isen to the staging area and makes Deeping-stream the active location. Each player searches the encounter deck for a different Traitor enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("The traitor Ealdwulf is raising an army to usurp the throne of Thengel-King.")
                .WithOppositeTextLine("When Revealed: Each player must choose: either place 1 damage token on Massing at the Isen, or reveal an encounter card.")
                .WithOppositeFlavorLine("If you hope to meet Ealdwulf’s challenge, you must spend the coming months rallying the scattered hosts of Rohan. His long-planned conspiracy gives him a head start, but your swift horses may yet carry you across many leagues to bring warning to those lords who remain loyal to Thengel’s banner.")
                .WithIncludedEncounterSets(EncounterSet.RohanLands, EncounterSet.RohanWeather)
                .WithInfo(179, 1, Artist.Ted_Nasmith);
            addQuest("Seeking Support", EncounterSet.MusteringOfTheRohirrim, 2, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: The first player chooses a set aside Mustering side quest and reveals it.")
                .WithFlavorLine("As you journey across Rohan, you find her in distress. None may ride to your aid until you locate the éored dispatched to the White Mountains, beseech the aid of Thengel, and rout the orcish horse-thieves marauding the countryside. Wherever you go, Ealdwulf’s agents seek to waylay and beguile you.")
                .WithOppositeTextLine("Seeking Support cannot be chosen as the current quest during the quest phase.")
                .WithOppositeTextLine("Forced: When a Mustering side quest is completed, flip it over and reveal it. Then, the first player chooses another set aside Mustering side quest and reveals it. If the first player is unable to do so, advance to stage 3.")
                .WithOppositeFlavorLine("With each dawn, Ealdwulf’s army grows more prepared. You must make haste.")
                .WithIncludedEncounterSets(EncounterSet.RohanLands, EncounterSet.RohanWeather)
                .WithInfo(180, 1, Artist.Onur_Bakar);
            addQuest("Halls of Ealdwulf", EncounterSet.MusteringOfTheRohirrim, 3, 'A', 7)
                .WithTextLine("When Revealed: Place 1Per Player damage tokens on Massing at the Isen. Add the remaining set aside Assassin enemies to the staging area.")
                .WithFlavorLine("You return to Aldburg to confront Ealdwulf. The traitor’s war party has already departed, but he has left behind a parting gift: two grimacing assassins, their blades sharp and glinting.")
                .WithOppositeTextLine("Assassin enemies are immune to player card effects.")
                .WithOppositeTextLine("This stage cannot be defeated while an Assassin enemy is in play. When this stage is defeated, the players win the game.")
                .WithOppositeFlavorLine("Ealdwulf’s assassins fall upon you ferociously, hacking and muttering with a cold sense of hate.")
                .WithIncludedEncounterSets(EncounterSet.RohanLands, EncounterSet.RohanWeather)
                .WithInfo(181, 1, Artist.Pete_Amachree);
        }
    }
}
