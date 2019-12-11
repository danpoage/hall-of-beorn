/* Generated CardSet class: Heirs of Númenor */

using System;

namespace HallOfBeorn.Models.LotR.Sets.HeirsOfNumenor
{
    public class HeirsOfNumenorSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Heirs of Númenor";
            Abbreviation = "HoN";
            Number = 15;
            SetType = Models.SetType.Deluxe_Expansion;

            addHero("Beregond", 10, Sphere.Tactics, 0, 1, 4, 4)
                .WithTraits("Gondor.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Lower the cost to play Weapon and Armor attachments on Beregond by 2.")
                .WithFlavorLine("\"It is over-late to send for aid when you are already besieged.\" -The Return of the King")
                .WithTemplate("<p>{keyword:Sentinel.}</p><p>Lower the cost to play {traits-attachment:Weapon,Armor@attachments} on {self} by 2.</p><p class='flavor-text'>&quot;It is over-late to send for aid when you are already besiged.&quot; &ndash;The Return of the King</p>")
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addHero("Boromir", 11, Sphere.Leadership, 1, 3, 2, 5)
                .WithTraits("Gondor.", "Warrior.", "Noble.")
                .WithTextLine("While Boromir has at least 1 resource in his resource pool, Gondor allies get +1 Attack.")
                .WithFlavorLine("\"By our valour the wild fold of the East are still restrained, and the terror of Morgul kept at bay...\" -The Fellowship of the Ring")
                .WithInfo(2, 1, Artist.Magali_Villeneuve);
            addAlly("Errand-rider", 1, Sphere.Leadership, false, 0, 0, 0, 2)
                .WithTraits("Gondor.")
                .WithTextLine("Action: Exhaust Errand-rider to move 1 resource from the resource pool of a hero you control to another hero's resource pool.")
                .WithFlavorLine("For the people of the City used horses very little and they were seldom seen in their streets, save only those ridden by the errand-riders of their lord. -The Return of the King")
                .WithInfo(3, 3, Artist.Anna_Steinbauer);
            addAlly("Citadel Custodian", 5, Sphere.Leadership, false, 1, 0, 1, 3)
                .WithTraits("Gondor.")
                .WithTextLine("Lower the cost to play Citadel Custodian by 1 for each Gondor ally in play.")
                .WithInfo(4, 3, Artist.Lorraine_Schleter);
            addEvent("Mutual Accord", 0, Sphere.Leadership)
                .WithTextLine("Action: Until the end of the phase, each Gondor card in play gains the Rohan trait, and each Rohan card in play gains the Gondor trait.")
                .WithFlavorLine("\"These are the Rohirrim, as we name them, masters of horses... and have ever proved true to us, aiding us at need, and guarding our northern marches and the Gap of Rohan.\" -Faramir, The Two Towers")
                .WithInfo(5, 3, Artist.Darek_Zabrocki);
            addEvent("Wealth of Gondor", 0, Sphere.Leadership)
                .WithTextLine("Action: Choose a Gondor hero. Add 1 resource to that hero's resource pool.")
                .WithFlavorLine("Kings made tombs more splendid than houses of the living, and counted old names in the rolls of their descent dearer than the names of sons. -The Two Towers")
                .WithInfo(6, 3, Artist.Darek_Zabrocki);
            addAlly("Defender of Rammas", 2, Sphere.Tactics, false, 0, 1, 4, 1)
                .WithTraits("Gondor.", "Warrior.")
                .WithFlavorLine("\"And the Enemy must pay dearly for the crossing of the River.\" -Denethor, The Return of the King")
                .WithInfo(7, 3, Artist.Marcia_GeorgeBogdan);
            addEvent("Behind Strong Walls", 1, Sphere.Tactics)
                .WithTextLine("Action: Ready a defending Gondor character. That character gets +1 Defense until the end of the phase.")
                .WithFlavorLine("...seven walls of stone so strong and old that it seemed to have been not builded by carven by giants out of the bones of the earth. -The Return of the King")
                .WithInfo(8, 3, Artist.Matt_Smith);
            addAttachment("Spear of the Citadel", 2, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Tactics character. Restricted.")
                .WithTextLine("Limit 1 per character.")
                .WithTextLine("Response: After attached character is declared as a defender, deal 1 damage to the attacking enemy.")
                .WithInfo(9, 3, Artist.Dan_Masso);
            addAlly("Damrod", 4, Sphere.Spirit, true, 1, 2, 2, 2)
                .WithTraits("Gondor.", "Ranger.")
                .WithTextLine("Action: Discard Damrod from play to lower your threat by 1 for each enemy in the staging area.")
                .WithInfo(10, 3, Artist.Magali_Villeneuve);
            addEvent("Light the Beacons", 5, Sphere.Spirit)
                .WithTextLine("Action: All characters get +2 Defense and do not exhaust to defend until the end of the round.")
                .WithFlavorLine("\"The beacons of Gondor are alight, calling for aid.\" -Gandalf, The Return of the King")
                .WithInfo(11, 3, Artist.Titus_Lunter);
            addEvent("A Watchful Peace", 1, Sphere.Spirit)
                .WithTextLine("Response: After a location worth no victory points leaves play as an explored location, return it to the top of the encounter deck.")
                .WithErrata()
                .WithInfo(12, 3, Artist.Titus_Lunter);
            addAttachment("Blood of Númenor", 0, Sphere.Spirit, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a Gondor or Dúnedain hero.")
                .WithTextLine("Action: Spend 1 resource from attached hero's resource pool to give attached hero +1 Defense for each resource in its resource pool until the end of the phase. (Limit once per phase.)")
                .WithFlavorLine("\"Believe not that in the land of Gondor the blood of Numenor is spent, nor all its pride and dignity forgotten.\" -Boromir, The Fellowship of the Ring")
                .WithInfo(13, 3, Artist.Magali_Villeneuve);
            addAlly("Hunter of Lamedon", 2, Sphere.Lore, false, 1, 1, 1, 1)
                .WithTraits("Gondor.", "Outlands.")
                .WithTextLine("Response: After you play Hunter of Lamedon from your hand, reveal the top card of your deck. If it is an Outlands card, add it to your hand. Otherwise, discard it.")
                .WithFlavorLine("From Lamedon, a few grim hillmen without a captain. -The Return of the King")
                .WithInfo(14, 3, Artist.Lorraine_Schleter);
            addAlly("Ithilien Tracker", 2, Sphere.Lore, false, 0, 1, 0, 3)
                .WithTraits("Gondor.", "Ranger.")
                .WithTextLine("Action: Exhaust Ithilien Tracker to lower the Threat of the next enemy added to the staging area to 0 until the end of the phase.")
                .WithFlavorLine("Green gauntlets covered their hands, and their faces were hooded and masked with green, except for their eyes, which were very keen and bright. -The Two Towers")
                .WithInfo(15, 3, Artist.David_A_Nash);
            addAlly("Master of Lore", 3, Sphere.Lore, false, 1, 0, 1, 1)
                .WithTraits("Gondor.")
                .WithTextLine("Action: Exhaust Master of ~Lore to name a card type. Lower the cost for you to play the next Lore card of that type by 1 until the end of the phase (to a minimum of 1).")
                .WithFlavorLine("\"If Cirith Ungol is named, old men and masters of lore will blanch and fall silent.\" -Faramir, The Two Towers")
                .WithErrata()
                .WithInfo(16, 3, Artist.Ilich_Henriquez);
            addAttachment("Ranger Spikes", 2, Sphere.Lore, false)
                .WithTraits("Trap.")
                .WithTextLine("Play Ranger Spikes into the staging area unattached.If unattached, attach Ranger Spikes to the next eligible enemy that enters the staging area.Players do not make engagement checks against attached enemy. Attached enemy gets -2 Threat.")
                .WithInfo(17, 3, Artist.Titus_Lunter);
            addAlly("Envoy of Pelargir", 2, Sphere.Neutral, false, 1, 1, 0, 1)
                .WithTraits("Gondor.")
                .WithTextLine("Response: After Envoy of Pelargir enters play, add 1 resource to a Gondor or Noble hero's resource pool.")
                .WithInfo(18, 3, Artist.Magali_Villeneuve);
            addObjective("Alcaron's Scroll", EncounterSet.PerilInPelargir)
                .WithUnique()
                .WithTraits("Scroll.")
                .WithTextLine("If unattached, return Alcaron's Scroll to the staging area and it gains: 'Action: Exhaust a hero to attach Alcaron's Scroll to that hero.'Forced: When the hero with Alcaron's Scroll attached is damaged by an enemy attack, attach Alcaron's Scroll to that enemy.")
                .WithInfo(19, 1, Artist.Jason_Ward);
            addEnemy("Harbor Thug", EncounterSet.PerilInPelargir, 25, 2, 3, 1, 3)
                .WithTraits("Thug.")
                .WithTextLine("Forced: When the player whose hero has Alcaron's Scroll attached raises his threat, Harbor Thug engages that player.")
                .WithShadow("Shadow: Any damage dealt by this attack is dealt to the hero with Alcaron's Scroll attached, if able.")
                .WithInfo(20, 5, Artist.Ellyson_Ferrari_Lifante);
            addLocation("The Leaping Fish", EncounterSet.PerilInPelargir, 2, 6)
                .WithUnique()
                .WithSlugSuffix("Location")
                .WithTraits("City.")
                .WithTextLine("If Alcaron's Scroll is attached to a hero, The Leaping Fish gains: 'Forced: At the beginning of the quest phase discard X cards from the top of the encounter deck where X is the number of players in the game. Add each enemy discarded by this effect to the staging area.'")
                .WithVictoryPoints(3)
                .WithInfo(21, 1, Artist.Darek_Zabrocki);
            addLocation("Pelargir Docks", EncounterSet.PerilInPelargir, 4, 3)
                .WithTraits("City.", "River.")
                .WithTextLine("While Pelargir Docks is the active location, enemies get +1 Attack and +1 Defense.")
                .WithFlavorLine("...they saw the River like a ribbon laid down to Pelargir, and beyond that was a light on the hem of the sky that spoke of the Sea. -The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(22, 2, Artist.Emilio_Rodriguez);
            addLocation("Harbor Storehouse", EncounterSet.PerilInPelargir, 1, 4)
                .WithTraits("City.")
                .WithTextLine("Forced: Each time a location is discarded from the top of the encounter deck, raise each player's threat by 1.")
                .WithShadow("Shadow: Deal attacking enemy an additional shadow card for each Thug enemy in play.")
                .WithInfo(23, 2, Artist.Titus_Lunter);
            addTreachery("Collateral Damage", EncounterSet.PerilInPelargir)
                .WithTextLine("When Revealed: Discard 2 cards from the top of the encounter deck. Discard an additional 2 cards for each copy of Collateral Damage in the discard pile. Then, raise each player's threat by 2 for each location discarded by this effect.")
                .WithShadow("Shadow: Any damage dealt by this attack is dealt to the hero with Alcaron's Scroll attached, if able.")
                .WithInfo(24, 4, Artist.Darek_Zabrocki);
            addObjective("Celador", EncounterSet.IntoIthilien)
                .WithUnique()
                .WithTraits("Gondor.", "Ranger.")
                .WithTextLine("While Celador is in the staging area, he is committed to the current quest.")
                .WithTextLine("Forced: After players quest unsuccessfully or a character leaves play, deal 1 damage to Celador.")
                .WithTextLine("If Celador leaves play, remove him from the game.")
                .WithInfo(25, 1, Artist.Magali_Villeneuve);
            addObjective("Ithilien Guardian", EncounterSet.IntoIthilien)
                .WithTraits("Gondor.", "Ranger.")
                .WithTextLine("While ~Ithilien ~Guardian is in the staging area, he is committed to the current quest.")
                .WithTextLine("When Revealed: Add ~Ithilien ~Guardian to the staging area and ~Ithilien ~Guardian gains surge.")
                .WithShadow("Shadow: Deal 2 damage to the attacking enemy.")
                .WithInfo(26, 2, Artist.Magali_Villeneuve);
            addEnemy("Southron Company", EncounterSet.IntoIthilien, 34, 1, 3, 1, 5)
                .WithTraits("Harad.")
                .WithTextLine("Southron Company gets +2 Threat and +2 Attack while the current quest card has the battle or siege keyword.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if the current quest card has a keyword.)")
                .WithInfo(27, 4, Artist.Ignacio_Bazan_Lazcano);
            addLocation("Ithilien Road", EncounterSet.IntoIthilien, 4, 4)
                .WithTraits("Forest.", "Road.")
                .WithTextLine("While Ithilien Road is the active location, the engagement cost of each enemy in the staging area is 0.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after it attacks.")
                .WithInfo(28, 2, Artist.Trudi_Castle);
            addTreachery("Blocking Wargs", EncounterSet.IntoIthilien)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Deal 1 damage to each character committed to the quest.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithErrata()
                .WithEasyModeQuantity(2)
                .WithInfo(29, 4, Artist.Marcia_GeorgeBogdan);
            addEnemy("Orc Scramblers", EncounterSet.TheSiegeOfCairAndros, 15, 1, 2, 1, 2)
                .WithTraits("Orc.", "Besieger.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Deal 1 damage to each Battleground location in play, if able.")
                .WithShadow("Shadow: Deal 2 damage to The Citadel if it is in play. Otherwise, attacking enemy gets +2 Attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(30, 3, Artist.Anton_Kokarev);
            addEnemy("Battering Ram", EncounterSet.TheSiegeOfCairAndros, 33, 2, 7, 3, 5)
                .WithTraits("Besieger.")
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("When Revealed: If the active location is a Battleground, deal 3 damage to it.")
                .WithShadow("Shadow: Deal 2 damage to The Approach if it is in play. Otherwise, attacking enemy gets +2 Attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(31, 3, Artist.Lin_Bo);
            addEnemy("Siege Raft", EncounterSet.TheSiegeOfCairAndros, 30, 3, 4, 1, 6)
                .WithTraits("Besieger.")
                .WithTextLine("When Revealed: Deal 2 damage to the lowest Threat Battleground location in play, if able.")
                .WithShadow("Shadow: Deal 2 damage to The Banks if it is in play. Otherwise, attacking enemy gets +2 Attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(32, 2, Artist.Marco_Caradonna);
            addLocation("The Citadel", EncounterSet.TheSiegeOfCairAndros, 3, 11)
                .WithTraits("Cair Andros.", "Battleground.")
                .WithTextLine("If The Citadel has 11 or more damage, remove it from the game (do not collect its victory points).")
                .WithTextLine("Response: After The Citadel leaves play as an explored location, remove stage 4 from the quest deck, if able.")
                .WithVictoryPoints(3)
                .WithInfo(33, 1, Artist.Michael_Rasmussen);
            addLocation("The Approach", EncounterSet.TheSiegeOfCairAndros, 2, 7)
                .WithTraits("Cair Andros.", "Battleground.")
                .WithTextLine("If the Approach has 7 or more damage, remove it from the game (do not collect its victory points).")
                .WithTextLine("Response: After The Approach leaves play as an explored location, remove stage 3 from the quest deck, if able.")
                .WithVictoryPoints(2)
                .WithInfo(34, 1, Artist.Titus_Lunter);
            addLocation("The Banks", EncounterSet.TheSiegeOfCairAndros, 1, 3)
                .WithTraits("Cair Andros.", "Battleground.")
                .WithTextLine("If The Banks has 3 or more damage, remove it from the game (do not collect its victory points).")
                .WithTextLine("Response: After The Banks leaves play as an explored location, remove stage 2 from the quest deck, if able.")
                .WithVictoryPoints(1)
                .WithInfo(35, 1, Artist.David_Lecossu);
            addTreachery("Orc Assault", EncounterSet.TheSiegeOfCairAndros)
                .WithTextLine("When Revealed: Each character gets -2 Attack and -2 Defense until the end of the round.")
                .WithShadow("Shadow: Deal 2 damage to all Battleground locations in play.")
                .WithInfo(36, 2, Artist.Darek_Zabrocki);
            addEnemy("Pickpocket", EncounterSet.StreetsOfGondor, 28, 3, 1, 0, 2)
                .WithTraits("Brigand.")
                .WithTextLine("Forced: When Pickpocket attacks, the defending player discards 1 resource from one of his heroes' resource pools and 1 card at random from his hand.")
                .WithShadow("Shadow: Defending player discards 1 of his attachments. (Discard all of his attachments instead if undefended.)")
                .WithInfo(37, 3, Artist.Asahi);
            addLocation("City Street", EncounterSet.StreetsOfGondor, 2, 2)
                .WithTraits("City.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("While City Street is in the staging area, players cannot travel to a location that does not have the title City Street.")
                .WithShadow("Shadow: attacking enemy gets +2 Attack.")
                .WithInfo(38, 3, Artist.Stu_Barnes);
            addLocation("Market Square", EncounterSet.StreetsOfGondor, 3, 1)
                .WithTraits("City.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Travel: Each player must spend 1 resource from one of his heroes' resource pools to travel here.")
                .WithShadow("Shadow: Defending player discards all resources in his heroes' resource pools.")
                .WithInfo(39, 2, Artist.Sara_Biddle);
            addTreachery("Lost in the City", EncounterSet.StreetsOfGondor)
                .WithTextLine("When Revealed: Each player must search the encounter deck and discard pile for 1 City location and add it to the staging area, if able. Shuffle the encounter deck. This effect cannot be canceled.")
                .WithShadow("Shadow: Defending player discards his hand.")
                .WithEasyModeQuantity(0)
                .WithInfo(40, 1, Artist.Dleoblack);
            addTreachery("Local Trouble", EncounterSet.StreetsOfGondor)
                .WithTextLine("When Revealed: Attach this card to the hero with the highest threat cost without a copy of Local Trouble attached. (Counts as a Condition attachment with the text: 'When attached hero exhausts, readies, or triggers an ability, raise its controller's threat by 1.')")
                .WithFlavorLine("...they all got an uncomfortable feeling that they were being watched with disapproval, deepening to dislike and even enmity. -The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(41, 2, Artist.Ryan_Barger);
            addEnemy("Zealous Traitor", EncounterSet.Brigands, 17, 2, 3, 2, 2)
                .WithTraits("Brigand.")
                .WithTextLine("Forced: When Zealous Traitor engages a player, that player must deal 1 damage to each ally he controls. (2 damage instead if Zealous Traitor was not optionally engaged.)")
                .WithInfo(42, 3, Artist.David_Gaillet);
            addEnemy("Lossarnach Bandit", EncounterSet.Brigands, 24, 3, 3, 3, 3)
                .WithTraits("Brigand.")
                .WithTextLine("Forced: When Lossarnach Bandit engages a player, that player discards 1 resource from each of his heroes' resource pools. (2 resources instead if Lossarnach Bandit was not optionally engaged.)")
                .WithInfo(43, 2, Artist.Dan_Masso);
            addEnemy("Umbar Assassin", EncounterSet.Brigands, 40, 4, 5, 1, 5)
                .WithTraits("Brigand.")
                .WithKeywords("Archery 2.")
                .WithTextLine("Archery 2.")
                .WithTextLine("Forced: When Umbar Assassin engages a player, that player must deal 3 damage to a hero he controls. (Discard that hero instead if Umbar Assassin was not optionally engaged.)")
                .WithEasyModeQuantity(0)
                .WithInfo(44, 1, Artist.Greg_Opalinski);
            addTreachery("Lurking in Shadows", EncounterSet.Brigands)
                .WithTextLine("When Revealed: Return all Brigand enemies engaged with players to the staging area. If this effect returned no Brigand enemies to the staging area, Lurking in Shadows gains surge.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after it attacks.")
                .WithInfo(45, 2, Artist.Sabin_Boykinov);
            addLocation("Overgrown Trail", EncounterSet.BroodingForest, 4, 6)
                .WithTraits("Forest.")
                .WithTextLine("Action: Exhaust a Ranger character to place 3 progress tokens on Overgrown Trail.")
                .WithShadow("Shadow: Remove X progress tokens from the current quest, where X is the attacking enemy's Threat.")
                .WithEasyModeQuantity(1)
                .WithInfo(46, 3, Artist.Trudi_Castle);
            addLocation("Secluded Glade", EncounterSet.BroodingForest, 3, 3)
                .WithTraits("Forest.")
                .WithTextLine("Immune to player card effects.")
                .WithShadow("Shadow: Remove X progress tokens from the current quest, where X is the attacking enemy's Threat.")
                .WithFlavorLine("\"...the garden of Gondor now desolate kept still a dishevelled dryad loveliness.\" -The Two Towers")
                .WithInfo(47, 3, Artist.Trudi_Castle);
            addTreachery("Lost Companion", EncounterSet.BroodingForest)
                .WithTextLine("When Revealed: Each player removes 1 character he controls from the quest, if able. Then, if any player has no characters committed to the quest, remove all characters from the quest.")
                .WithFlavorLine("\"Seven companions we had: one we lost at Moria, the others we left at Parth Galen above Rauros...\" -Frodo Baggins, The Two Towers")
                .WithEasyModeQuantity(0)
                .WithInfo(48, 2, Artist.Magali_Villeneuve);
            addEnemy("Morgul Spider", EncounterSet.CreaturesOfTheForest, 25, 3, 4, 1, 5)
                .WithTraits("Creature.", "Spider.")
                .WithTextLine("When Revealed: Until the end of the round, Morgul Spider gets +1 Attack for each character not currently committed to a quest.")
                .WithFlavorLine("Far and wide her lesser broods, bastards of the miserable mates, her own offspring, that she slew, spread from glen to glen... -The Two Towers")
                .WithEasyModeQuantity(1)
                .WithInfo(49, 3, Artist.Dean_Spencer);
            addEnemy("Forest Bat", EncounterSet.CreaturesOfTheForest, 18, 1, 1, 1, 1)
                .WithTraits("Creature.")
                .WithTextLine("When Revealed: The first player deals 2 damage to a questing hero and removes that hero from the quest.")
                .WithShadow("Shadow: Defending player raises his threat by X where X is the attacking enemy's Threat.")
                .WithInfo(50, 3, Artist.Aurelien_Hubert);
            addTreachery("Watcher in the Wood", EncounterSet.CreaturesOfTheForest)
                .WithTextLine("When Revealed: Raise each player's threat by the number of questing characters. (If the current quest has the battle or siege keyword, Watcher in the Wood gains surge.)")
                .WithShadow("Shadow: Each player raises his threat by the number of enemies engaged with him.")
                .WithEasyModeQuantity(0)
                .WithInfo(51, 2, Artist.Igor_Kieryluk);
            addEnemy("Southron Mercenaries", EncounterSet.Southrons, 35, 2, 3, 2, 4)
                .WithTraits("Harad.")
                .WithKeywords("Archery X.")
                .WithTextLine("Archery X.")
                .WithTextLine("X is the number of players in the game.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. (+3 Attack instead if it has the Harad trait.)")
                .WithInfo(52, 3, Artist.Emile_Denis);
            addEnemy("Haradrim Elite", EncounterSet.Southrons, 27, 3, 4, 3, 3)
                .WithTraits("Harad.")
                .WithTextLine("Forced: When Haradrim Elite enters play, it makes an immediate attack from the staging area against the first player.")
                .WithShadow("Shadow: This enemy attacks again after this attack resolves. (Deal a new shadow card for that attack.)")
                .WithInfo(53, 2, Artist.Adam_Lane);
            addEnemy("Mûmak", EncounterSet.Southrons, 38, 4, 7, 3, 12)
                .WithTraits("Harad.", "Creature.")
                .WithTextLine("No attachments can be attached to Mûmak.")
                .WithTextLine("Mûmak cannot take more than 3 damage each round.")
                .WithFlavorLine("\"His upturned hornlike tusks were bound with bands of gold and dripped with blood.\" -The Two Towers")
                .WithEasyModeQuantity(0)
                .WithInfo(54, 1, Artist.Piya_Wannachaiwong);
            addTreachery("Southron Support", EncounterSet.Southrons)
                .WithKeywords("Doomed 3.")
                .WithTextLine("Doomed 3.")
                .WithTextLine("When Revealed: Each player must search the encounter deck and discard pile for 1 Harad enemy and add it to the staging area, if able. Shuffle the encounter deck.")
                .WithFlavorLine("... wild Southron men with red banners, shouting with harsh tongues, surging up, overtaking the retreat. -The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(55, 2, Artist.C_B_Sorge);
            addEnemy("Lieutenant of Mordor", EncounterSet.MordorElite, 33, 2, 5, 2, 5)
                .WithTraits("Mordor.")
                .WithTextLine("Allies cannot defend against Lieutenant of Mordor.When Revealed: Resolve the 'when revealed' effect on the topmost treachery card in the encounter discard pile, if able. This effect cannot be canceled.")
                .WithVictoryPoints(3)
                .WithInfo(56, 1, Artist.Jim_Pavelec);
            addEnemy("Orc Arbalesters", EncounterSet.MordorElite, 35, 2, 1, 2, 5)
                .WithTraits("Mordor.", "Orc.")
                .WithKeywords("Archery X.")
                .WithTextLine("Archery X.")
                .WithTextLine("X is the number of different resource icons (Leadership, Tactics, Spirit, or Lore) on heroes in play.")
                .WithShadow("Shadow: attacking enemy gets +2 Attack.")
                .WithInfo(57, 3, Artist.Timo_Karhula);
            addEnemy("Orc Vanguard", EncounterSet.MordorElite, 40, 2, 8, 3, 5)
                .WithTraits("Mordor.", "Orc.")
                .WithTextLine("While Orc Vanguard is in the staging area, resources cannot be spent from the resource pools of heroes who have a Leadership, Spirit, or Lore resource icon.")
                .WithShadow("Shadow: Deal the attacking enemy two additional shadow cards.")
                .WithEasyModeQuantity(0)
                .WithInfo(58, 2, Artist.Lin_Bo);
            addLocation("Orc War Camp", EncounterSet.MordorElite, 5, 2)
                .WithTraits("Mordor.")
                .WithTextLine("If an Orc enemy is in play, progress tokens cannot be placed on Orc War Camp while it is in the staging area.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack for each shadow card dealt to it.")
                .WithEasyModeQuantity(0)
                .WithInfo(59, 2, Artist.Emilio_Rodriguez);
            addTreachery("The Master's Malice", EncounterSet.MordorElite)
                .WithTextLine("When Revealed: Each player chooses 1 sphere of influence (Leadership, Tactics, Spirit, or Lore). Each character a player controls that does not belong to his chosen sphere takes 3 damage.")
                .WithFlavorLine("\"I doubt not that the days of Gondor are numbered, and the walls of Minas Tirith are doomed, so great is His strength and malice.\" -Damrod, The Two Towers")
                .WithEasyModeQuantity(0)
                .WithInfo(60, 2, Artist.Marcia_GeorgeBogdan);
            addTreachery("The Power of Mordor", EncounterSet.MordorElite)
                .WithKeywords("Doomed 3.")
                .WithTextLine("Doomed 3.")
                .WithTextLine("When Revealed: Count the number of encounter cards in the staging area and shuffle them into the encounter deck. Reveal an equal number of cards from the encounter deck and add them to the staging area. This effect cannot be canceled.")
                .WithErrata()
                .WithInfo(61, 1, Artist.Ryan_Barger);
            addEnemy("Orc Rabble", EncounterSet.RavagingOrcs, 28, 2, 1, 1, 3)
                .WithTraits("Mordor.", "Orc.")
                .WithTextLine("Forced: When Orc Rabble is dealt a shadow card, it gets +2 Attack until the end of the phase.")
                .WithShadow("Shadow: Deal the attacking enemy an additional shadow card for each player in the game.")
                .WithEasyModeQuantity(0)
                .WithInfo(62, 3, Artist.David_A_Nash);
            addEnemy("Orc Arsonist", EncounterSet.RavagingOrcs, 30, 3, 3, 2, 3)
                .WithTraits("Mordor.", "Orc.")
                .WithTextLine("Forced: When Orc Arsonist engages a player, deal 1 shadow card to each enemy engaged with that player.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. Deal it another shadow card.")
                .WithInfo(63, 3, Artist.David_Kegg);
            addTreachery("Scourge of Mordor", EncounterSet.RavagingOrcs)
                .WithTextLine("When Revealed: Each player discards the top card of his deck. Until the end of the phase, raise the total Threat in the staging area by X, where X is the total cost of all cards discarded by this effect.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. Deal it another shadow card.")
                .WithInfo(64, 2, Artist.Caravan_Studio);
            addQuest("The Leaping Fish", EncounterSet.PerilInPelargir, 1, 'A', 6)
                .WithSlugSuffix("Quest")
                .WithKeywords("Battle.")
                .WithTextLine("Battle.")
                .WithTextLine("Setup: Search the encounter deck for The Leaping Fish and Alcaron's ~Scroll. Make The Leaping Fish the active location and attach Alcaron's ~Scroll to a hero.")
                .WithFlavorLine("The White Council has sent you by ship to Gondor to help fight the threat of Mordor. Upon arrival in the port city of Pelargir, you are greeted by Lord Alcaron who takes you to The Leaping Fish where you can speak privately.")
                .WithOppositeTextLine("When Revealed: Each player must search the encounter deck for a copy of Harbor Thug and add it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavorLine("Inside the tavern, Lord Alcaron looks nervously toward the door as he hands you a scroll bearing the seal of Gondor. He asks that you deliver it to Faramir in Ithilen, but the brigands who just entered look intent on taking it from you")
                .WithIncludedEncounterSets(EncounterSet.StreetsOfGondor, EncounterSet.Brigands)
                .WithInfo(65, 1, Artist.Darek_Zabrocki);
            addQuest("Fighting in the Streets", EncounterSet.PerilInPelargir, 2, 'A', 13)
                .WithKeywords("Battle.")
                .WithTextLine("Battle.")
                .WithFlavorLine("During the fight in the tavern, one of your adversaries managed to grab Alcaron's Scroll and flee outside. You chase the thief into the street where you are surrounded by a gang of his fellow brigands. You must fight your way through the mob and recover the scroll!")
                .WithOppositeTextLine("When Revealed: Attach Alcaron's ~Scroll to the highest engagement cost enemy in play, if able. Otherwise, add Alcaron's Scroll to the staging area.")
                .WithIncludedEncounterSets(EncounterSet.StreetsOfGondor, EncounterSet.Brigands)
                .WithInfo(66, 1, Artist.Ben_Zweifel);
            addQuest("Escape to the Quays", EncounterSet.PerilInPelargir, 3, 'A', 15)
                .WithTextLine("When Revealed: Each player searches the encounter deck and discard pile for 1 enemy and adds it to the staging area.")
                .WithFlavorLine("You've recovered the scroll but are still outnumbered by your determined foes. Lord Alcaron shouts for you to escape and deliver the scroll before he flees to summon the city guard. If you can get to your ship, you can escape the clutches of these desperate thugs...")
                .WithOppositeTextLine("Enemies cannot be optionally engaged.")
                .WithOppositeTextLine("Forced: The first enemy revealed from the encounter deck each round makes an immediate attack against the player who controls Alcaron's Scroll from the staging area.")
                .WithOppositeTextLine("The players cannot defeat this stage unless Alcaron's ~Scroll is attached to a hero. If the players defeat this stage, they have won the game.")
                .WithIncludedEncounterSets(EncounterSet.StreetsOfGondor, EncounterSet.Brigands)
                .WithInfo(67, 1, Artist.Jeff_Lee_Johnson);
            addQuest("Ambush in Ithilien", EncounterSet.IntoIthilien, 1, 'A', 15)
                .WithKeywords("Battle.")
                .WithTextLine("Battle.")
                .WithTextLine("Setup: Add Celador to the staging area. Search the encounter deck for a copy of Ithilien Road and make it the active location. Each player must search the encounter deck for a copy of Southron Company and add it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("You've arrived in Ithilien with a sealed message for Faramir, only to learn that he has gone north to defend Cair Andros from massing enemy forces.")
                .WithOppositeTextLine("If the players complete this stage with Celador in the staging area, advance to stage 3A (bypassing stage 2).")
                .WithOppositeFlavorLine("Faramir has left a company of rangers in Ithilien, tasked on ambushing Southrons as the march toward Cair Andros. Their captain, Celador, offers to lead you to Cair Andros after the approaching enemy is destroyed...")
                .WithIncludedEncounterSets(EncounterSet.BroodingForest, EncounterSet.CreaturesOfTheForest, EncounterSet.Southrons)
                .WithInfo(68, 1, Artist.Jeff_Lee_Johnson);
            addQuest("Southron Counter-attack", EncounterSet.IntoIthilien, 2, 'A', 9)
                .WithKeywords("Siege.", "Archery X.")
                .WithTextLine("Siege. Archery X.")
                .WithFlavorLine("The Southron army was larger and better prepared than the rangers anticipated, and now your dwindling company is painfully overmatched. Your only option is a disciplined withdrawl to Cair Andros, before being overwhelmed by the enemy reinforcements hurrying up the road to join the fight.")
                .WithOppositeTextLine("X is the number of players in the game.")
                .WithOppositeTextLine("After this stage is completed advance to stage 4A (bypassing stage 3).")
                .WithIncludedEncounterSets(EncounterSet.BroodingForest, EncounterSet.CreaturesOfTheForest, EncounterSet.Southrons)
                .WithInfo(69, 1, Artist.Magali_Villeneuve);
            addQuest("The Hidden Way", EncounterSet.IntoIthilien, 3, 'A', 12)
                .WithOppositeTextLine("When Revealed: The first player takes contorl of all Ranger objectives in the staging area.")
                .WithOppositeTextLine("Enemies do not make engagement checks and cannot be optionally engaged.")
                .WithIncludedEncounterSets(EncounterSet.BroodingForest, EncounterSet.CreaturesOfTheForest, EncounterSet.Southrons)
                .WithInfo(70, 1, Artist.Ilich_Henriquez);
            addQuest("Approaching Cair Andros", EncounterSet.IntoIthilien, 4, 'A', 15)
                .WithFlavorLine("The island fortress of Cair Andros rises from the middle of the Anduin. From a distance all is quiet, but as you near the island and night approaches a raucous cry is heard on the wind. The horns of Mordor sound in response. The enemy is moving on Cair Andros, and the assault will soon begin. You must reach it before all hope is lost.")
                .WithOppositeTextLine("If any players threat is 37 or higher, Approaching Cair Andros gains Siege.")
                .WithOppositeTextLine("Forced: At the end of each round, raise each player's threat by 2.")
                .WithOppositeTextLine("If the players defeat this stage, they have won the game.")
                .WithIncludedEncounterSets(EncounterSet.BroodingForest, EncounterSet.CreaturesOfTheForest, EncounterSet.Southrons)
                .WithInfo(71, 1, Artist.Emrah_Elmasli);
            addQuest("The Defense", EncounterSet.TheSiegeOfCairAndros, 1, 'A', 9)
                .WithKeywords("Siege.")
                .WithTextLine("Siege.")
                .WithTextLine("Setup: Add The Approach, The Citadel, and The Banks to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("The island fortress of Cair Andros, which guards Gondor's northernmost causeways over the river Anduin, is under siege! Battering rams rumble up the eastern causeway and rafts filled with Orcs float across the river toward the lightly defended northern banks.")
                .WithOppositeTextLine("Players must deal damage from undefended attacks to the lowest Threat Battleground location in play. If there are no Battleground locations in play, immediate advance to the next stage.")
                .WithOppositeFlavorLine("The assault is relentless, and the defenders grow weary. The tide is slowly but surely turning against you...")
                .WithIncludedEncounterSets(EncounterSet.Southrons, EncounterSet.RavagingOrcs, EncounterSet.MordorElite)
                .WithInfo(72, 1, Artist.Lin_Bo);
            addQuest("Reinforcing the Banks", EncounterSet.TheSiegeOfCairAndros, 2, 'A', 9)
                .WithFlavorLine("As smoke and rending cries fill the air, rafts of Orcs beach their crafts all along the northern banks. You must reach the shore and drive them back into the river before a solid foothold can be established.")
                .WithOppositeTextLine("Reveal 1 additional card from the encounter deck and add it to the staging area during the staging step each round.")
                .WithIncludedEncounterSets(EncounterSet.Southrons, EncounterSet.RavagingOrcs, EncounterSet.MordorElite)
                .WithInfo(73, 1, Artist.Timo_Karhula);
            addQuest("Breakthrough at the Approach", EncounterSet.TheSiegeOfCairAndros, 3, 'A', 7)
                .WithKeywords("Battle.")
                .WithTextLine("Battle.")
                .WithFlavorLine("With a crashing boom the eastern gate shatters. A ram has broken through, and the pressing host of Orcs pour into the courtyard beyond. Engage them in hand-to-hand combat and secure the gate!")
                .WithOppositeTextLine("Forced: After the players quest unsuccessfully, instead of raising threat each player must choose and discard 1 character he controls.")
                .WithIncludedEncounterSets(EncounterSet.Southrons, EncounterSet.RavagingOrcs, EncounterSet.MordorElite)
                .WithInfo(74, 1, Artist.Lin_Bo);
            addQuest("Breakthrough at the Citadel", EncounterSet.TheSiegeOfCairAndros, 4, 'A', 5)
                .WithKeywords("Siege.")
                .WithTextLine("Siege.")
                .WithFlavorLine("Orc scramblers have infiltrated the island and climbed over the walls. They fought to the western gate, and the gate fell. Now a new host of enemies that were lying in wait are breaching the Citadel itself!")
                .WithOppositeTextLine("Breakthrough at the Citadel adds 5 Threat to the staging area.")
                .WithIncludedEncounterSets(EncounterSet.Southrons, EncounterSet.RavagingOrcs, EncounterSet.MordorElite)
                .WithInfo(75, 1, Artist.Darek_Zabrocki);
            addQuest("The Last Battle", EncounterSet.TheSiegeOfCairAndros, 5, 'A', 15)
                .WithKeywords("Siege.")
                .WithTextLine("Siege.")
                .WithOppositeTextLine("When Revealed: Reveal 1 card per player from the encounter deck and add it to the staging area.")
                .WithOppositeTextLine("If the players have collected 4 or more victory points, The Last Battle gains Battle and loses Siege.")
                .WithOppositeTextLine("If the players defeat this stage, they have won the game.")
                .WithIncludedEncounterSets(EncounterSet.Southrons, EncounterSet.RavagingOrcs, EncounterSet.MordorElite)
                .WithInfo(76, 1, Artist.Darek_Zabrocki);
        }
    }
}
