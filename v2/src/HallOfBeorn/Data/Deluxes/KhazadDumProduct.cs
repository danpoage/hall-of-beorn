using System;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data.Deluxes
{
    public static class KhazadDumProduct
    {
        public static ProductBuilder Builder()
        {
            var builder = new ProductBuilder(ProductNames.KhazadDum, ProductCodes.KhazadDum, new DateTime(2011,1, 6));

            var kd = builder.DeluxeExpansion(CardSetNames.KhazadDum, CardSetAbbreviations.KhazadDum, 8);

            kd.addHero("Dwalin", 9, Sphere.Spirit, 1, 2, 2, 4)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After Dwalin attacks and destroys an Orc enemy, lower your threat by 2.")
                .WithInfo(1, 1, Artists.Tony_Foti);
            kd.addHero("Bifur", 7, Sphere.Lore, 2, 1, 2, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("Action: Pay 1 resource from a hero's resource pool to add 1 resource to Bifur's resource pool. Any player may trigger this ability. (Limit once per round.)")
                .WithFlavor("\"And winter comes after autumn.\" - Bifur, The Hobbit")
                .WithInfo(2, 1, Artists.Magali_Villeneuve);
            kd.addAttachment("Narvi's Belt", 2, Sphere.Leadership, true)
                .WithTraits("Item.")
                .WithTextLine("Attach to a Dwarf hero.")
                .WithTextLine("Action: Exhaust Narvi's Belt to give attached hero a Leadership, Lore, Tactics, or Spirit icon until the end of the phase.")
                .WithErrata()
                .WithInfo(3, 3, Artists.Carolina_Eade);
            kd.addEvent("Durin's Song", 1, Sphere.Leadership)
                .WithTraits("Song.")
                .WithTextLine("Action: Choose a Dwarf hero. That hero gets +2 Willpower, +2 Attack, and +2 Defense until the end of the round.")
                .WithFlavor("A king he was on carven throne")
                .WithFlavor("In many-pillared halls of stone")
                .WithFlavor("With golden roof and silver floor,")
                .WithFlavor("And runes of power upon the door.")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(4, 3, Artists.Cristi_Balanescu);
            kd.addEvent("Ever Onward", 3, Sphere.Leadership)
                .WithTextLine("Response: After players quest unsuccessfully, choose a player. That player does not raise his threat.")
                .WithInfo(5, 3, Artists.Dleoblack);
            kd.addAlly("Veteran of Nanduhirion", 4, Sphere.Tactics, false, 0, 3, 2, 3)
                .WithTraits("Dwarf.", "Warrior.")
                .WithTextLine("Veteran of Nanduhirion enters play with 1 damage on it.")
                .WithFlavor("With cries of \"Moria!\" and \"Dain, Dain!\" the dwarves of the Iron Hills plunged in... -The Hobbit")
                .WithInfo(6, 3, Artists.Dleoblack);
            kd.addAttachment("Dwarrowdelf Axe", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Dwarf character. Restricted.")
                .WithTextLine("Attached character gets +1 Attack.")
                .WithTextLine("Response: After attached character attacks, deal 1 damage to the defending enemy.")
                .WithFlavor("\"We make good armour and keen swords, but we cannot again make mail or blade to match those that were made before the dragon came.\" -Glóin, The Fellowship of the Ring")
                .WithInfo(7, 3, Artists.Carolina_Eade);
            kd.addEvent("Khazâd! Khazâd!", 0, Sphere.Tactics)
                .WithTextLine("Action: Choose a Dwarf character. Until the end of the phase, that character gets +3 Attack.")
                .WithFlavor("Down from the wall leapt Gimli with a fierce cry the echoed in the cliffs. \"Khazâd! Khazâd!\" He soon had work enough.")
                .WithFlavor("-The Two Towers")
                .WithTemplate("<p><b>Action:</b> Choose a {trait-character:Dwarf.@Dwarf} character. Until the end of the phase, that character gets +3 {Attack}.</p><p class='flavor-text'>Down from the wall leapt Gimli with a fierce cry the echoed in the cliffs. &quot;Khazâd! Khazâd!&quot; He soon had work enough.<br>&ndash;The Two Towers</p>")
                .WithInfo(8, 3, Artists.Igor_Kieryluk);
            kd.addAlly("Zigil Miner", 2, Sphere.Spirit, false, 1, 1, 1, 1)
                .WithTraits("Dwarf.")
                .WithTextLine("Action: Exhaust Zigil Miner and name a number to discard the top 2 cards of your deck. If at least one of those cards has cost equal to the named number, choose a hero you control. For each card that matches the named number, add 1 resource to that hero's resource pool.")
                .WithErrata()
                .WithInfo(9, 3, Artists.Magali_Villeneuve);
            kd.addEvent("Untroubled by Darkness", 2, Sphere.Spirit)
                .WithTextLine("Action: Each Dwarf character gets +1 Willpower until the end of the phase. (+2 Willpower instead if the active location is an Underground or Dark location.)")
                .WithInfo(10, 3, Artists.Tiziano_Baracchi);
            kd.addAlly("Erebor Record Keeper", 1, Sphere.Lore, false, 1, 0, 0, 1)
                .WithTraits("Dwarf.")
                .WithTextLine("Erebor ~Record Keeper cannot attack or defend.")
                .WithTextLine("Action: Exhaust Erebor ~Record Keeper and pay 1 Lore resource to choose and ready a Dwarf character.")
                .WithInfo(11, 3, Artists.Andrew_Johanson);
            kd.addEvent("Ancestral Knowledge", 1, Sphere.Lore)
                .WithTextLine("Action: Exhaust a Dwarf character to place 2 progress tokens on the active location. (4 progress tokens instead if it is an Underground or Mountain location.)")
                .WithFlavor("\"There is a land where our fathers worked of old...\"")
                .WithFlavor("Gimli, The Fellowship of the Ring")
                .WithInfo(12, 3, Artists.Cristi_Balanescu);
            kd.addAttachment("Boots from Erebor", 0, Sphere.Neutral, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a Dwarf or Hobbit character. Limit 1 Boots from Erebor per character.")
                .WithTextLine("Attached character gets +1 hit point.")
                .WithInfo(13, 3, Artists.Carolina_Eade);

            var pit = kd.EncounterSet(EncounterSetNames.IntoThePit);
            pit.addEnemy("Patrol Leader", 30, 3, 4, 3, 4)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Forced: Before Patrol Leader is dealt damage, discard the top card of the encounter deck. If the discarded card is an enemy, cancel that damage.")
                .WithShadow("Shadow: Cancel all damage dealt to this enemy.")
                .WithEasyModeQuantity(1)
                .WithInfo(14, 2, Artists.David_A_Nash);
            pit.addTreachery("Signs of Conflict")
                .WithKeywords("Doomed 2.", "Surge.")
                .WithTextLine("Doomed 2. Surge.")
                .WithShadow("Shadow: Defending player raises his threat by 2.")
                .WithEasyModeQuantity(2)
                .WithInfo(15, 5, Artists.Cristi_Balanescu);
            pit.addLocation("East-gate", 7, 7)
                .WithUnique()
                .WithTraits("Gate.")
                .WithTextLine("Immune to card effects.")
                .WithTextLine("Players cannot optionally engage enemies and no engagement checks are made.Forced: After East-gate leaves play as an explored location, add First Hall to the staging area.")
                .WithVictoryPoints(1)
                .WithInfo(16, 1, Artists.Cristi_Balanescu);
            pit.addLocation("First Hall", 2, 2)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("Travel: Each player must raise his threat by 3 to travel here.Forced: After First Hall leaves play as an explored location, add Bridge of Khazad-dum to the staging area.")
                .WithVictoryPoints(1)
                .WithInfo(17, 1, Artists.Michael_Rasmussen);
            pit.addLocation("Bridge of Khazad-dûm", 3, 3)
                .WithUnique()
                .WithTraits("Underground.", "Bridge.")
                .WithTextLine("While Bridge of Khazad-dûm is the active location, players cannot play cards.")
                .WithVictoryPoints(2)
                .WithInfo(18, 1, Artists.Lin_Bo);
            pit.addLocation("Stairs of Náin", 2, 4)
                .WithTraits("Underground.")
                .WithTextLine("Travel: The first player must exhaust 1 character he controls to travel here.")
                .WithShadow("Shadow: Defending player must choose and exhaust 1 character he controls.")
                .WithInfo(19, 2, Artists.Lin_Bo);

            var sev = kd.EncounterSet(EncounterSetNames.TheSeventhLevel);
            sev.addEnemy("Cave-troll", 33, 4, 6, 4, 7)
                .WithTraits("Troll.")
                .WithTextLine("For each excess point of combat damage dealt by Cave-troll (damage that is dealt beyond the remaining hit points of the character damaged by its attack) you must damage another character you control.")
                .WithVictoryPoints(2)
                .WithEasyModeQuantity(1)
                .WithInfo(20, 2, Artists.Timo_Karhula);
            sev.addEnemy("Orc Horn Blower", 45, 2, 1, 1, 3)
                .WithTraits("Orc.", "Summoner.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Reveal 1 card from the encounter deck and add it to the staging area.")
                .WithEasyModeQuantity(0)
                .WithInfo(21, 1, Artists.Ilich_Henriquez);
            sev.addTreachery("Hidden Threat")
                .WithTextLine("When Revealed: Each player must raise his threat by 1 for each enemy in the staging area. Then, the last player discards an attachment he controls.")
                .WithInfo(22, 2, Artists.Ryan_Barger);
            sev.addLocation("Upper Hall", 3, 4)
                .WithTraits("Underground.")
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithFlavor("High up above the eastern archway through a shaft near the roof came a long pale gleam; and across the hall through the northern arch light also glimmered faint and distantly.")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(23, 3, Artists.David_Lecossu);
            sev.addObjective("Book of Mazarbul")
                .WithUnique()
                .WithTraits("Item.", "Artifact.")
                .WithKeywords("Restricted.")
                .WithTextLine("Restricted.")
                .WithTextLine("Action: Exhaust a hero to claim this objective. Then, attach Book of Mazarbul to that hero. (If detached, return Book of Mazarbul to the staging area.)Attached hero cannot attack and does not exhaust to commit to a quest.")
                .WithInfo(24, 1, Artists.Sara_Biddle);

            var flight = kd.EncounterSet(EncounterSetNames.FlightFromMoria);
            flight.addEnemy("The Nameless Fear", 50, Stats.VALUE_X, Stats.VALUE_X, Stats.VALUE_X, 27)
                .WithUnique()
                .WithTraits("Flame.", "Shadow.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("The Nameless Fear cannot engage or be engaged.")
                .WithTextLine("X is the number of victory points in the victory display.")
                .WithInfo(25, 1, Artists.Timo_Karhula);
            flight.addTreachery("New Devilry")
                .WithTextLine("When Revealed: If the players are not on stage 1, shuffle the current quest card into the quest deck, then reveal a new quest card. Otherwise, New Devilry gains surge.")
                .WithShadow("Shadow: If this attack is undefended, raise your threat by The Nameless Fear's Threat.")
                .WithInfo(26, 3, Artists.Ben_Zweifel);
            flight.addTreachery("Shadow of Fear")
                .WithTextLine("When Revealed: The first player attaches Shadow of Fear to one of his heroes. (Counts as a Condition attachment with the text: 'Limit 1 per hero. Attached hero cannot exhaust or ready and its text box is treated as if it were blank. Action: Pay 3 resources from attached hero's pool to discard this card.')")
                .WithEasyModeQuantity(1)
                .WithInfo(27, 3, Artists.Gabrielle_Portal);
            flight.addTreachery("A Foe Beyond")
                .WithTextLine("When Revealed: The last player deals damage equal to The ~Nameless Fear's attack to a hero he controls. This effect cannot be canceled.")
                .WithShadow("Shadow: Deal damage equal to The ~Nameless Fear's Attack to the defending character.")
                .WithEasyModeQuantity(1)
                .WithInfo(28, 4, Artists.Ilich_Henriquez);
            flight.addObjective("Abandoned Tools")
                .WithTraits("Tools.")
                .WithKeywords("Guarded.", "Restricted.")
                .WithTextLine("Guarded. Restricted.")
                .WithTextLine("Action: Exhaust a hero to claim this objective if it has no encounters attached. Then, attach Abandoned ~Tools to that hero. (If detached, return Abandoned ~Tools to the staging area.)")
                .WithInfo(29, 1, Artists.Stu_Barnes);

            var plunder = kd.EncounterSet(EncounterSetNames.PlunderingGoblins);
            plunder.addEnemy("Chieftain of the Pit", 27, 2, 5, 2, 4)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("When Revealed: Chieftain of the Pit gets +3 Attack until the end of the round.")
                .WithShadow("Shadow: attacking enemy attacks again after this attack. Deal it another shadow card for the next attack.")
                .WithEasyModeQuantity(0)
                .WithInfo(30, 1, Artists.John_Stanko);
            plunder.addEnemy("Goblin Spearman", 15, 2, 2, 2, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Goblin Spearman gets +2 Attack if its attack is undefended.")
                .WithShadow("Shadow: Add Goblin Spearman to the staging area.")
                .WithInfo(31, 5, Artists.Salvador_Trakal);
            plunder.addEnemy("Goblin Archer", 48, 2, 1, 3, 1)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Players cannot optionally engaged Goblin Archer.")
                .WithTextLine("Characters with ranged are eligible to attack Goblin Archer while it is in the staging area.Forced: After an enemy is revealed from the encounter deck, the first player must deal 1 damage to 1 character he controls.")
                .WithInfo(32, 2, Artists.Salvador_Trakal);
            plunder.addTreachery("Undisturbed Bones")
                .WithTextLine("When Revealed: Each player must deal X damage to 1 ally he controls. X is the number of allies he controls.")
                .WithShadow("Shadow: If the defending character is an ally, discard it from play.")
                .WithEasyModeQuantity(1)
                .WithInfo(33, 3, Artists.Carolina_Eade);
            plunder.addLocation("Plundered Armoury", 3, 2)
                .WithTraits("Underground.")
                .WithTextLine("While Plundered Armoury is in the staging area, enemies get +1 Attack.Response: After Plundered Armoury leaves play as an explored location, each player may attach a Weapon or Armour attachment from his hand to 1 character he controls.")
                .WithInfo(34, 2, Artists.Michael_Rasmussen);

            var twist = kd.EncounterSet(EncounterSetNames.TwistsAndTurns);
            twist.addEnemy("Goblin Follower", 33, 1, 3, 2, 4)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("When Revealed: Goblin Follower engages the last player.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if attacking the last player.)")
                .WithInfo(35, 4, Artists.Salvador_Trakal);
            twist.addLocation("Branching Paths", 1, 3)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("While Branching Paths is in the staging area, each Dark location gets +1 Threat.Forced: After Branching Paths leaves play as an explored location, look at the top 3 cards of the encounter deck. Players must choose 1 of those to reveal and add to the staging area, moving the other 2 to the bottom of the deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(36, 3, Artists.David_A_Nash);
            twist.addLocation("Lightless Passage", 4, 4)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("Travel: Players must exhaust a Cave Torch to travel here.")
                .WithShadow("Shadow: Cancel all combat damage dealt to attacking enemy.")
                .WithEasyModeQuantity(1)
                .WithInfo(37, 2, Artists.Stu_Barnes);
            twist.addLocation("Zigil Mineshaft", 5, 5)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("Action: Raise each player's threat by 1 to place 1 progress token on Zigil Mineshaft.")
                .WithEasyModeQuantity(1)
                .WithInfo(38, 3, Artists.David_Lecossu);
            twist.addTreachery("Many Roads")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Shuffle all locations in the encounter discard pile back into the encounter deck.")
                .WithInfo(39, 1, Artists.Stu_Barnes);
            twist.addTreachery("Burning Low")
                .WithTextLine("When Revealed: Each enemy and location currently in the staging area gets +1 Threat until the end of the phase. (+3 Threat instead if it is a Dark location.) Players may exhaust a Cave Torch to cancel this effect.")
                .WithShadow("Shadow: attacking enemy gets +2 Attack.")
                .WithInfo(40, 3, Artists.Anthony_Palumbo);
            twist.addObjective("Cave Torch")
                .WithTraits("Light.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Action: Exhaust Cave Torch to place up to 3 progress tokens on a Dark location.Forced: After Cave Torch exhausts, discard the top card of the encounter deck. If that card is an enemy, add it to the staging area.")
                .WithTemplate("<p>Attach to a {type:Hero@hero}. {keyword:Restricted.}</p><p><b>Action:</b> Exhaust self to place up to 3 progress on a {trait:Dark.@Dark} location.</p><p><b>Forced:</b> After {self} exhausts, discard the top card of the encounter deck. If that card is an enemy, add it to the staging area.</p>")
                .WithInfo(41, 1, Artists.David_Lecossu);

            var deeps = kd.EncounterSet(EncounterSetNames.DeepsOfMoria);
            deeps.addEnemy("Great Cave-troll", 38, 2, 7, 3, 10)
                .WithTraits("Troll.")
                .WithTextLine("Immune to ranged damage.")
                .WithTextLine("No attachments can be played on Great Cave-troll.")
                .WithVictoryPoints(3)
                .WithEasyModeQuantity(0)
                .WithInfo(42, 2, Artists.David_A_Nash);
            deeps.addEnemy("Orc Drummer", 50, 1, 1, 3, 1)
                .WithTraits("Orc.", "Summoner.")
                .WithTextLine("While Orc Drummer is in the staging area, each enemy gets +X Threat. X is the number of players in the game.")
                .WithEasyModeQuantity(0)
                .WithInfo(43, 1, Artists.David_A_Nash);
            deeps.addEnemy("Stray Goblin", 29, Stats.VALUE_X, 0, 2, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("X is the number of players in the game.")
                .WithShadow("Shadow: attacking enemy gets +X Attack. X is the number of players in the game.")
                .WithInfo(44, 3, Artists.Mike_Capprotti);
            deeps.addTreachery("Chance Encounter")
                .WithTextLine("When Revealed: Put the top enemy in the encounter discard pile into play, engaged with the first player. If this effect put no enemies into play, Chance Encounter gains surge.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. (+3 Attack instead if engaged with the first player.)")
                .WithInfo(45, 3, Artists.Magali_Villeneuve);
            deeps.addTreachery("Massing in the Deep")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Reveal X additional cards from the encounter deck and add them to the staging area. X is the number of players in the game.")
                .WithShadow("Shadow: attacking enemy gets +X Attack. X is the number of players in the game.")
                .WithEasyModeQuantity(0)
                .WithInfo(46, 2, Artists.Noah_Bradley);
            deeps.addLocation("The Mountains' Roots", Stats.VALUE_X, Stats.VALUE_X)
                .WithTraits("Underground.")
                .WithTextLine("X is the number of players in the game.")
                .WithShadow("Shadow: attacking enemy gets +X Attack. X is the number of players in the game.")
                .WithInfo(47, 3, Artists.Stu_Barnes);

            var hazards = kd.EncounterSet(EncounterSetNames.HazardsOfThePit);
            hazards.addTreachery("Cave In")
                .WithTraits("Hazard.")
                .WithTextLine("When Revealed: Remove all progress tokens from the current quest card and active location. If Cave In removed no progress tokens, it gains surge.")
                .WithInfo(48, 3, Artists.Winona_Nelson);
            hazards.addTreachery("Crumbling Ruin")
                .WithTraits("Hazard.")
                .WithTextLine("When Revealed: Each player must exhaust a character and discard the top card of his deck, if able. If the printed cost of the discarded card is equal to or higher than the remaining hit points of the exhausted character, discard the exhausted character.")
                .WithEasyModeQuantity(0)
                .WithInfo(49, 2, Artists.Magali_Villeneuve);
            hazards.addTreachery("Dark and Dreadful")
                .WithTextLine("When Revealed: Deal 1 damage to each exhausted character. (2 damage instead if the active location is a Dark location.)")
                .WithShadow("Shadow: Deal 1 damage to the defending character. (Attacking enemy gets +2 Attack instead if this attack is undefended.)")
                .WithEasyModeQuantity(1)
                .WithInfo(50, 2, Artists.Igor_Kieryluk);
            hazards.addTreachery("Sudden Pitfall")
                .WithTraits("Hazard.")
                .WithTextLine("When Revealed: The first player must discard 1 questing character he controls, if able. This effect cannot be canceled.")
                .WithShadow("Shadow: Discard the defending character from play.")
                .WithEasyModeQuantity(0)
                .WithInfo(51, 1, Artists.Jake_Murray);
            hazards.addLocation("Dreadful Gap", 2, Stats.VALUE_X)
                .WithTraits("Underground.", "Hazard.")
                .WithTextLine("When Revealed: Immediately travel to Dreadful Gap. If another location is currently active, return it to the staging area.X is the number of characters in play.")
                .WithVictoryPoints(3)
                .WithEasyModeQuantity(0)
                .WithInfo(52, 1, Artists.Stu_Barnes);
            hazards.addLocation("Fouled Well", 3, 5)
                .WithTraits("Underground.", "Dark.", "Hazard.")
                .WithTextLine("When Revealed: Each player may choose and discard 1 card at random from his hand. If all players did not discard 1 card, Fouled Well gains surge.")
                .WithInfo(53, 3, Artists.David_Lecossu);

            var misty = kd.EncounterSet(EncounterSetNames.MistyMountains);
            misty.addEnemy("Black Uruks", 32, 2, 3, 3, 2)
                .WithTraits("Uruk.", "Orc.")
                .WithTextLine("When Revealed: The first player must choose and discard an attachment from a questing character, if able.")
                .WithShadow("Shadow: If this attack is undefended, deal 2 additional shadow cards to attacking enemy.")
                .WithInfo(54, 4, Artists.Jake_Murray);
            misty.addEnemy("Mountain Warg", 30, 2, 4, 2, 4)
                .WithTraits("Creature.")
                .WithTextLine("If Mountain Warg is dealt a shadow card with no effect, return Mountain Warg to the staging area after it attacks.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if a Mountain is the active location.)")
                .WithEasyModeQuantity(2)
                .WithInfo(55, 3, Artists.Allison_Theus);
            misty.addTreachery("Bitter Wind")
                .WithTextLine("When Revealed: The first player must discard 3 resources from each hero he controls.")
                .WithShadow("Shadow: Defending player must discard 2 resources from each hero he controls.")
                .WithInfo(56, 3, Artists.Anthony_Palumbo);
            misty.addLocation("Knees of the Mountain", 2, 3)
                .WithTraits("Mountain.")
                .WithTextLine("While Knees of the Mountain is in the staging area, it gains: 'Forced: After an enemy engages a player, it gets +1 Attack until the end of the round.'")
                .WithInfo(57, 1, Artists.Stacey_Diana_Clark);
            misty.addLocation("Turbulent Waters", 3, 2)
                .WithTraits("Mountain.")
                .WithTextLine("While Turbulent Waters is the active location, players cannot optionally engage enemies.")
                .WithEasyModeQuantity(1)
                .WithInfo(58, 2, Artists.David_Lecossu);
            misty.addLocation("Warg Lair", 1, 3)
                .WithTraits("Mountain.")
                .WithTextLine("When Revealed: Search the encounter deck and discard pile for 1 copy of Mountain Warg and add it to the staging area, if able. Shuffle the encounter deck.Response: After Warg Lair leaves play as an explored location, each player draws 1 card.")
                .WithInfo(59, 2, Artists.Roman_V_Papsuev);

            var goblins = kd.EncounterSet(EncounterSetNames.GoblinsOfTheDeep);
            goblins.addEnemy("Goblin Scout", 37, 3, 1, 0, 2)
                .WithTraits("Goblin.", "Orc.", "Scout.")
                .WithTextLine("Each player with a threat of 25 or higher cannot optionally engage Goblin Scout.")
                .WithInfo(60, 3, Artists.Winona_Nelson);
            goblins.addEnemy("Goblin Swordsman", 20, 1, 3, 1, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Goblin Swordsman gets +2 Attack if its attack is undefended.")
                .WithShadow("Shadow: Add Goblin Swordsman to the staging area.")
                .WithInfo(61, 5, Artists.Winona_Nelson);
            goblins.addTreachery("Watchful Eyes")
                .WithTextLine("When Revealed: The first player attaches Watchful Eyes to one of his heroes. (Counts as a Condition attachment with the text: 'Limit 1 per hero. Forced: If attached hero is exhausted at the end of the combat phase, reveal 1 card from the encounter deck and add it to the staging area.')")
                .WithEasyModeQuantity(0)
                .WithInfo(62, 3, Artists.Tiziano_Baracchi);
            goblins.addLocation("Goblin Tunnels", 2, 7)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("While Goblin Tunnels is in the staging area, it gains: 'Forced: After a Goblin is revealed from the encounter deck, remove a progress token from the current quest card.'")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. (+3 Attack instead if attacking enemy is a Goblin.)")
                .WithInfo(63, 2, Artists.Michael_Rasmussen);

            pit.addQuest("Entering the Mines", 1, 'A', 7)
                .WithTextLine("Setup: Search the encounter deck for East-gate and Cave Torch. Put East-gate into play as the active location, and have the first player attach Cave Torch to a hero of his choice. Set First Hall and Bridge of Khazad-dum aside, out of play. Shuffle the encounter deck.")
                .WithFlavor("You have been sent by the White Council to Moria, to deliver a message to Balin and his Dwarven colony. No one has heard from him in a while.")
                .WithOppositeTextLine("When Revealed: Reveal 1 encounter card per player, and add it to the staging area.")
                .WithOppositeTextLine("Player cannot advance to the next stage of the scenario unless Bridge of Khazad-dum is in their victory display.")
                .WithOppositeFlavor("The doors of the East-gate hang crooked on their henges. The darkness inside the doorway is still and impenetrable, shutting out the last beams of a sinking sun.")
                .WithIncludedEncounterSets(EncounterSetNames.TwistsAndTurns, EncounterSetNames.HazardsOfThePit, EncounterSetNames.GoblinsOfTheDeep)
                .WithInfo(64, 1, Artists.Ben_Zweifel);
            pit.addQuest("Goblin Patrol", 2, 'A', 11)
                .WithFlavor("The skeletons of Dwarves and Orcs lie undisturbed, but you have discovered no recent sign of the Dwarven colony. The sound of scampering feet travels to your ears, and you move in that direction to investigate. There is a patrol of Goblins, marching in a loose formation through the shadows.")
                .WithOppositeTextLine("If there are no enemies in play, immediately advance to the next stage of the scenario. (Players can also advance by placing 11 progress tokens on ~Goblin Patrol.)")
                .WithIncludedEncounterSets(EncounterSetNames.TwistsAndTurns, EncounterSetNames.HazardsOfThePit, EncounterSetNames.GoblinsOfTheDeep)
                .WithInfo(65, 1, Artists.Ilich_Henriquez);
            pit.addQuest("A Way Up", 3, 'A', 12)
                .WithOppositeTextLine("If players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSetNames.TwistsAndTurns, EncounterSetNames.HazardsOfThePit, EncounterSetNames.GoblinsOfTheDeep)
                .WithInfo(66, 1, Artists.Ben_Zweifel);

            sev.addQuest("Search for the Chamber", 1, 'A', 15)
                .WithTextLine("Setup: Search the encounter deck for Book of Mazarbul, and have the first player attach it to a hero of his choice. Shuffle the encounter deck.")
                .WithFlavor("You are investigating the Seventh Level of Moria, searching for the Chamber of Records and any signs of Balin's Colony. In the heavy twilight of a hall, a bulky tome is discovered in the grip of a Dwarf skeleton. You carefully take possession of the book. Perhaps it will give you some answers...")
                .WithOppositeTextLine("When Revealed: Reveal 1 encounter card per player, and add it to the staging area.")
                .WithOppositeFlavor("The Dwarven runes of the book appear to hold a detailed record of the fledgling colony. But there is some Elvish script at the end which seems out of place...")
                .WithIncludedEncounterSets(EncounterSetNames.GoblinsOfTheDeep, EncounterSetNames.PlunderingGoblins)
                .WithInfo(67, 1, Artists.Cristi_Balanescu);
            sev.addQuest("The Fate of Balin", 2, 'A', 17)
                .WithOppositeTextLine("If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSetNames.GoblinsOfTheDeep, EncounterSetNames.PlunderingGoblins)
                .WithInfo(68, 1, Artists.Ben_Zweifel);
            flight.addQuest("A Presence in the Dark", 1, 'A', null)
                .WithTextLine("Setup: Prepare the quest deck. Add The Nameless Fear to the staging area. Remove all copies of A Foe Beyond from the encounter deck. Then, shuffle 1 copy of A Foe Beyond per player back into the encounter deck.")
                .WithFlavor("You have discovered the fate of the Dwarven colony, and seek to leave Moria. But exiting may not be as simple as entering...")
                .WithOppositeTextLine("When Revealed: Reveal 1 encounter card per player, and add it to the staging area. Then, add A Presence in the Dark to your victory display.")
                .WithOppositeFlavor("As you leave Moria, the air grows thick and drums begin to roll from the deeps. A man-shape shadow, yet greater, masses at the end of the hall, and begins to head straight for you.")
                .WithVictoryPoints(2)
                .WithIncludedEncounterSets(EncounterSetNames.HazardsOfThePit, EncounterSetNames.DeepsOfMoria, EncounterSetNames.PlunderingGoblins)
                .WithInfo(69, 1, Artists.Igor_Kieryluk);
            flight.addQuest("Search for an Exit", 2, 'A', 5)
                .WithOppositeTitle("Heading Down")
                .WithSlugSuffix("Heading Down")
                .WithTextLine("While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.")
                .WithFlavor("As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...")
                .WithOppositeTextLine("Forced: If Heading Up is in the player's victory display at the end of any quest phase, shuffle Heading Up back into the quest deck. Players may bypass this quest card at the end of the combat phase.")
                .WithOppositeFlavor("It looks like you may have to head back up the other way.")
                .WithVictoryPoints(1)
                .WithBackArtist(Artists.Magali_Villeneuve)
                .WithIncludedEncounterSets(EncounterSetNames.HazardsOfThePit, EncounterSetNames.DeepsOfMoria, EncounterSetNames.PlunderingGoblins)
                .WithInfo(70, 1, Artists.Cristi_Balanescu);
            flight.addQuest("Search for an Exit", 2, 'A', 7)
                .WithOppositeTitle("Heading Up")
                .WithSlugSuffix("Heading Up")
                .WithTextLine("While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.")
                .WithFlavor("As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...")
                .WithOppositeTextLine("Forced: If Heading Down is in the player's victory display at the end of any quest phase, shuffle Heading DOwn back into the quest deck.")
                .WithOppositeFlavor("Perhaps if you climbed this pile of rocks, there would be a way out...")
                .WithVictoryPoints(1)
                .WithBackArtist(Artists.Magali_Villeneuve)
                .WithIncludedEncounterSets(EncounterSetNames.HazardsOfThePit, EncounterSetNames.DeepsOfMoria, EncounterSetNames.PlunderingGoblins)
                .WithInfo(71, 1, Artists.Cristi_Balanescu);
            flight.addQuest("Search for an Exit", 2, 'A', 1)
                .WithOppositeTitle("A Wrong Turn")
                .WithSlugSuffix("A Wrong Turn")
                .WithTextLine("While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.")
                .WithFlavor("As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...")
                .WithOppositeTextLine("When Revealed: Reveal 1 encounter card per players, and add it to the staging area. Players may bypass this quest at the end of the combat phase.")
                .WithVictoryPoints(2)
                .WithBackArtist(Artists.David_Lecossu)
                .WithIncludedEncounterSets(EncounterSetNames.HazardsOfThePit, EncounterSetNames.DeepsOfMoria, EncounterSetNames.PlunderingGoblins)
                .WithInfo(72, 1, Artists.Cristi_Balanescu);
            flight.addQuest("Search for an Exit", 2, 'A', 3)
                .WithOppositeTitle("Narrow Paths")
                .WithSlugSuffix("Narrow Paths")
                .WithTextLine("While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.")
                .WithFlavor("As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...")
                .WithOppositeTextLine("When Revealed: Each player chooses 1 questing character he controls. Each questing character not chosen does not count its willpower until the end of the turn. Forced: After placing the 1st progress token on Narrow Paths, search the encounter deck and discard pile for Abandoned Tools and add it to the staging area, if able. Players may bypas this quest card at the end of the combat phase.")
                .WithVictoryPoints(1)
                .WithBackArtist(Artists.Ilich_Henriquez)
                .WithIncludedEncounterSets(EncounterSetNames.HazardsOfThePit, EncounterSetNames.DeepsOfMoria, EncounterSetNames.PlunderingGoblins)
                .WithInfo(73, 1, Artists.Cristi_Balanescu);
            flight.addQuest("Search for an Exit", 2, 'A', null)
                .WithOppositeTitle("Hasty Council")
                .WithSlugSuffix("Hasty Council")
                .WithTextLine("While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.")
                .WithFlavor("As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...")
                .WithOppositeTextLine("When Revealed: Shuffle all copies of A Foe Beyond from the encounter discard pile back into the encounter deck. Reveal the top 2 cards of the quest deck. Choose 1 to become the active quest (flipped to side 2B) and put the other on the bottom of the quest deck. Then, add Hasty Council to your victory display.")
                .WithOppositeFlavor("You pause momentarily to consider your options...")
                .WithVictoryPoints(2)
                .WithBackArtist(Artists.Stacey_Diana_Clark)
                .WithIncludedEncounterSets(EncounterSetNames.HazardsOfThePit, EncounterSetNames.DeepsOfMoria, EncounterSetNames.PlunderingGoblins)
                .WithInfo(74, 1, Artists.Cristi_Balanescu);
            flight.addQuest("Search for an Exit", 2, 'A', 9)
                .WithOppositeTitle("Blocked By Shadow")
                .WithSlugSuffix("Blocked By Shadow")
                .WithTextLine("While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.")
                .WithFlavor("As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...")
                .WithOppositeTextLine("When Revealed: The first player chooses 1 of the following:")
                .WithOppositeTextLine("• Each player discards 1 card from the top of the encounter deck. If the card is a treachery card, the discarding player is eliminated from the game.")
                .WithOppositeTextLine("• Reveals the next quest card, putting Blocked by ~Shadow on the bottom of the quest deck.")
                .WithOppositeTextLine("Players may bypass this quest card at the end of the combat phase. If the players defeat this stage, they escape and win the game.")
                .WithBackArtist(Artists.Magali_Villeneuve)
                .WithIncludedEncounterSets(EncounterSetNames.HazardsOfThePit, EncounterSetNames.DeepsOfMoria, EncounterSetNames.PlunderingGoblins)
                .WithInfo(75, 1, Artists.Cristi_Balanescu);
            flight.addQuest("Search for an Exit", 2, 'A', 4)
                .WithOppositeTitle("Escape from Darkness")
                .WithSlugSuffix("Escape from Darkness")
                .WithTextLine("While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.")
                .WithFlavor("As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, you must escape from the Black Pit...")
                .WithOppositeTextLine("Abandoned ~Tools gains: \"Refresh Action: Exhaust attached hero to put a progress token on ~Escape from Darkness.\"")
                .WithOppositeTextLine("Players may bypass this quest card at the end of the combat phase. Progress tokens cannot be placed on Escape from Darkness except by Abandoned Tools. If the players defeat this stage, they escape and win the game.")
                .WithOppositeFlavor("There is a weakness in the walls. You can practically taste the freedom beyond.")
                .WithBackArtist(Artists.Magali_Villeneuve)
                .WithIncludedEncounterSets(EncounterSetNames.HazardsOfThePit, EncounterSetNames.DeepsOfMoria, EncounterSetNames.PlunderingGoblins)
                .WithInfo(76, 1, Artists.Cristi_Balanescu);

            return builder;
        }
    }
}
