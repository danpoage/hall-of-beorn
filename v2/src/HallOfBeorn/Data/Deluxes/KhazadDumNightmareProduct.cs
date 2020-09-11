using System;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data.Deluxes
{
    public static class KhazadDumNightmareProduct
    {
        public static ProductBuilder Builder()
        {
            var builder = new ProductBuilder(ProductNames.KhazadDumNightmareDecks, ProductCodes.KhazadDumNightmareDecks, new DateTime(2014, 6, 2));

            var pitCardSet = builder.NightmareDeck(CardSetNames.IntoThePitNightmare, CardSetAbbreviations.IntoThePitNightmare, 2009);
            var pit = pitCardSet.EncounterSet(EncounterSetNames.IntoThePitNightmare);

            pit.addNightmareSetup()
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("Forced: After ~Cave Torch exhausts, place 1 damage token on this card. Then, if there are 5 or more damage tokens on this card, remove ~Cave Torch from the game.")
                .WithFlavor("All about them as they lay hung the darkness, hollow and immense, and they were oppressed by the lonliness and vastness of the dolven halls and endlessly branching stairs and passages.")
                .WithFlavor("-The Fellowship of the Ring")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for the Into the Pit scenario.")
                .WithOppositeTextLine("Remove the following cards, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("1x ~Goblin Patrol")
                .WithOppositeTextLine("2x Stairs of Náin")
                .WithOppositeTextLine("2x ~Goblin Follower")
                .WithOppositeTextLine("2x Crumbling Ruin")
                .WithOppositeTextLine("3x ~Cave In")
                .WithOppositeTextLine("2x Fouled Well")
                .WithOppositeTextLine("2x ~Goblin Tunnels")
                .WithOppositeTextLine("5x ~Goblin Swordsman")
                .WithOppositeTextLine("Add the new quest card in this Nightmare Deck to the normal quest deck, in stage order. Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Into the Pit encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artists.Guillaume_Ducos);
            pit.addQuest("Goblin Ambush", 2, 'A', Stats.VALUE_X)
                .WithFlavor("You hear the sounds of many scampering feet. As you move closer to investiage, you find your party set upon on all sides by a patrol of Orcs!")
                .WithTextLine("When Revealed: The first player must search the encounter deck and discard pile for X Orc enemies and add them to the staging area, where X is 1 plus the number of players in the game. One of these choices must be Patrol Sentry and one must be Patrol Leader, if able.")
                .WithOppositeTextLine("X is 1 plus the number of players in the game.")
                .WithOppositeTextLine("Forced: After an enemy is defeated, place 1 progress on this stage.")
                .WithOppositeTextLine("Progress cannot be placed on ~Goblin Ambush expect by the above effect.")
                .WithInfo(2, 1, Artists.Jason_Ward);
            pit.addEnemy("Patrol Sentry", 20, 1, 4, 3, 5)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Forced: After Cave Torch exhausts, Patrol Sentry makes an immediate attack against the engaged player, if able.")
                .WithShadow("Shadow: Add Patrol Sentry to the staging area.")
                .WithInfo(3, 4, Artists.Guillaume_Ducos);
            pit.addEnemy("Goblin Lurker", 50, 3, 2, 2, 4)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Cannot be optionally engaged.")
                .WithTextLine("If the active location is a Dark location, Goblin Lurker gets +3 Attack and -40 engagement cost.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if the active location is a Dark location.)")
                .WithInfo(4, 3, Artists.Piya_Wannachaiwong);
            pit.addEnemy("Shadow Dweller", 0, 1, 7, 7, 8)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Shadow Dweller does not make engagement checks while ~Cave Torch is in play.")
                .WithShadow("Shadow: Shuffle Shadow Dweller back into the encounter deck.")
                .WithInfo(5, 2, Artists.Mark_Bulahao);
            pit.addLocation("Twisting Shadows", Stats.VALUE_X, Stats.VALUE_X)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("X is the number of Dark locations in play.")
                .WithTextLine("When Revealed: Remove all progress from each Dark location in play.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each Dark location in play.")
                .WithInfo(6, 3, Artists.Michael_Rasmussen);
            pit.addLocation("Narrow Fissure", 3, 1)
                .WithTraits("Underground.", "Hazard.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("Each Dark location in play gets +2 quest points.")
                .WithTextLine("While Cave Torch is ready, progress cannot be placed on Narrow Fissure.")
                .WithFlavor("There were fissures and chasms in the walls...")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(7, 3, Artists.Katy_Grierson);
            pit.addTreachery("Shadow-fall")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Attach to a non-Dark location in play. (Counts as a Condition attachment with the text: \"Attached location gains the Dark trait and gets +3 quest points.\")")
                .WithShadow("Shadow: Attacking enemy gets +3 Defense this phase.")
                .WithInfo(8, 3, Artists.Anthony_Feliciano);

            var sevenCardSet = builder.NightmareDeck(EncounterSetNames.TheSeventhLevelNightmare, CardSetAbbreviations.TheSeventhLevelNightmare, 2010);
            var seven = sevenCardSet.EncounterSet(EncounterSetNames.TheSeventhLevelNightmare);

            seven.addNightmareSetup()
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("Setup: Set Overseer Maurûl and Chamber of Records aside, out of play.")
                .WithTextLine("Forced: When stage 2B is revealed, make Chamber of Records the active location (returning any currently active location to the staging area) and add Overseer Maurûl to the staging area. Then, shuffle all copies of Balin's Doom in the encounter discard pile back into the encounter deck.")
                .WithFlavor("\"They seem to have made a last stand by both doors,\" he said; \"but there were not many left by that time. So ended the attempt to retake Moria! It was valiant but foolish.\".")
                .WithFlavor("-Gandalf, The Fellowship of the Ring")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for The Seventh Level scenario.")
                .WithOppositeTextLine("Remove the following cards, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("2x Plundered Armoury")
                .WithOppositeTextLine("2x Hidden ~Threat")
                .WithOppositeTextLine("2x Upper Hall")
                .WithOppositeTextLine("2x ~Goblin ~Scout")
                .WithOppositeTextLine("2x ~Goblin Swordsman")
                .WithOppositeTextLine("2x ~Goblin Spearman")
                .WithOppositeTextLine("Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Seventh Level encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithOppositeTextLine("Does not stack")
                .WithOppositeTextLine("Some cards have passive abilities with the text \"This ability does not stack with...\" While two or more effects that do not stack with one another are active, only one of them will affect the game state.")
                .WithInfo(1, 1, Artists.Mark_Bulahao);
            seven.addEnemy("Overseer Maurûl", 20, 3, 3, 3, 12)
                .WithUnique()
                .WithTraits("Mordor.", "Orc.")
                .WithTextLine("Overseer Maurûl gets +X Threat, +X Attack, and +X Defense, where X is the highest number of resources on a Goblin enemy in play.")
                .WithTextLine("The Players cannot win the game unless Overseer Maurûl is in the victory display.")
                .WithVictoryPoints(5)
                .WithInfo(2, 1, Artists.Aurelien_Hubert);
            seven.addLocation("Chamber of Records", 5, 8)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Each Goblin enemy with at least 1 resource on it is immune to player events.")
                .WithTextLine("Forced: When a Goblin enemy engages a player, add 2 resources to that enemy.")
                .WithFlavor("\"Now, I fear, we must say farewell to Balin son of Fundin.\"")
                .WithFlavor("-Gandalf, The Fellowship of the Ring")
                .WithVictoryPoints(5)
                .WithInfo(3, 1, Artists.Juan_Carlos_Barquet);
            seven.addEnemy("Orc Taskmaster", 44, 1, 4, 4, 6)
                .WithTraits("Mordor.", "Orc.")
                .WithTextLine("When Revealed: Add 1 resource to each Goblin enemy in play.")
                .WithTextLine("Forced: When a Goblin enemy with at least 1 resource on it is dealt any amount of damage, remove 1 resource from that enemy and cancel all damage just dealt to it.")
                .WithInfo(4, 2, Artists.Guillaume_Ducos);
            seven.addEnemy("Goblin Skirmisher", 15, 2, 4, 2, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Each Goblin enemy gets +1 Attack for each resource on it. This ability does not stack with other copies of ~Goblin Skirmisher.")
                .WithShadow("Shadow: Deal X damage to the defending character. X is the number of resources on attacking enemy.")
                .WithInfo(5, 3, Artists.Rick_Price);
            seven.addEnemy("Pit Goblin", 36, 3, 2, 1, 4)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("When Revealed: Add 2 resources to Pit Goblin.")
                .WithShadow("Shadow: If attacking enemy is a Goblin, add 1 resource to it.")
                .WithInfo(6, 2, Artists.Alvaro_Calvo_Escudero);
            seven.addLocation("Deep-Mines", 2, 6)
                .WithTraits("Ungerground.")
                .WithTextLine("Forced: When a Goblin enemy enters play, add 1 resource to that enemy if Deep-Mines is in the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. Then, if attacking enemy is a Goblin, deal it another shadow card.")
                .WithInfo(7, 3, Artists.Trudi_Castle);
            seven.addLocation("Western Hall", 4, 4)
                .WithTraits("Underground.")
                .WithTextLine("Each Goblin in play gets +1 Threat for each resource on it. This ability does not stack with other copies of Western Hall")
                .WithFlavor("Away beyond the shadows at the western end of the hall there came cries and horn-calls.")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(8, 2, Artists.Michael_Rasmussen);
            seven.addTreachery("Balin's Doom")
                .WithKeywords("Surge.", "Doomed 1.")
                .WithTextLine("Surge. Doomed 1.")
                .WithTextLine("When Revealed: Add 1 resource to each Goblin enemy in play.")
                .WithShadow("Shadow: If attacking enemy is a Goblin, add 1 resource to it.")
                .WithInfo(9, 3, Artists.Sebastian_Giacobino);
            seven.addTreachery("Beats and Echoes")
                .WithTextLine("When Revealed: Reveal the top X cards of the encounter deck, adding all enemies to the staging area. Discard the other revealed cards without resolving them. X is 2 plus the number of players not engaged with a Goblin enemy.")
                .WithFlavor("Eachoes ran along as they hurried forward; and there seemed to be the sound of many footfalls following their own.")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(10, 2, Artists.Mark_Bulahao);

            var flightCardSet = builder.NightmareDeck(CardSetNames.FlightFromMoriaNightmare, CardSetAbbreviations.FlightFromMoriaNightmare, 2011);
            var flight = flightCardSet.EncounterSet(EncounterSetNames.FlightFromMoriaNightmare);

            flight.addNightmareSetup()
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("When a quest card is bypassed, shuffle it into the quest deck instead of placing it on the bottom.")
                .WithTextLine("While the ~Escape from Darkness quest card is in play, the Refresh Action on Abandoned ~Tools can only be triggered once each round.")
                .WithFlavor("\"Fly! This is a foe beyond any of you.\".")
                .WithFlavor("-Gandalf, The Fellowship of the Ring")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for the Flight from Moria scenario.")
                .WithOppositeTextLine("Remove the following cards, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("1x Blocked by ~Shadow")
                .WithOppositeTextLine("1x New Devilry")
                .WithOppositeTextLine("3x Stray ~Goblin")
                .WithOppositeTextLine("2x The Mountains' Roots")
                .WithOppositeTextLine("3x Chance Encounter")
                .WithOppositeTextLine("2x ~Goblin ~Archer")
                .WithOppositeTextLine("1x ~Goblin Spearman")
                .WithOppositeTextLine("2x Plundered Armoury")
                .WithOppositeTextLine("3x ~Cave In")
                .WithOppositeTextLine("2x ~Dark and Dreadful")
                .WithOppositeTextLine("Shuffle the new stage 2 quest cards in this Nightmare Deck into the quest deck along with the rest of the scenario's stage 2 quest cards, leaving stage 1A on top of the quest deck. Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Flight from Moria encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artists.Mark_Behm);
            flight.addQuest("Search for an Exit", 2, 'A', 5)
                .WithOppositeTitle("Pursued by Shadow")
                .WithSlugSuffix("Pursued by Shadow")
                .WithFlavor("As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, your must escape from the Black Pit...")
                .WithTextLine("While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.")
                .WithOppositeTextLine("Forced: At the end of the round, shuffle the discard pile into the encounter deck and discard the top 5 cards. Resolve the \"when revealed\" effects of each copy of A Foe Beyond discarded by this effect.")
                .WithOppositeTextLine("No more than 1 progress can be placed on this stage each round. If the players defeat this stage, they win the game.")
                .WithOppositeTextLine("Players may bypass this quest card at the end of the combat phase.")
                .WithBackArtist(Artists.Gabriel_Verdon)
                .WithInfo(2, 1, Artists.Cristi_Balanescu);
            flight.addQuest("Search for an Exit", 2, 'A', null)
                .WithOppositeTitle("Blocked by Flame")
                .WithSlugSuffix("Blocked by Flame")
                .WithFlavor("As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, your must escape from the Black Pit...")
                .WithTextLine("While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.")
                .WithOppositeTextLine("The ~Nameless Fear attacks each player in turn order during the combat phase (deal and discard a shadow card for each attack). Characters are eligible to attack The ~Nameless Fear while it is in the staging area.")
                .WithOppositeTextLine("If The ~Nameless Fear has 10 or more damage on it, remove all damage from it and advance to the next stage. Players may bypass this quest card at the end of the combat phase.")
                .WithVictoryPoints(1)
                .WithBackArtist(Artists.Alvaro_Calvo_Escudero)
                .WithInfo(3, 1, Artists.Cristi_Balanescu);
            flight.addQuest("Search for an Exit", 2, 'A', 1)
                .WithOppositeTitle("Ghâsh!")
                .WithSlugSuffix("Ghash")
                .WithFlavor("As the presence draws near, doubt and fear surround you like a vast shadow. You must find daylight, your must escape from the Black Pit...")
                .WithTextLine("While Search for an Exit is the active quest card, only flip it to side 2B at the beginning of the staging step.")
                .WithOppositeFlavor("\"As I stood there I could hear orc-voices on the other side: at any moment I though they would burst it open. I could not hear what was said; they seemed to be talking in their own hideous language. All I caught was ghâsh: that is 'fire'.\"")
                .WithOppositeFlavor("-Gandalf, The Fellowship of the Ring")
                .WithOppositeTextLine("When Revealed: Deal 1 damage to each questing character.")
                .WithOppositeTextLine("Players may bypass this quest card at the end of the combat phase.")
                .WithVictoryPoints(1)
                .WithBackArtist(Artists.Mark_Behm)
                .WithInfo(4, 1, Artists.Cristi_Balanescu);
            flight.addEnemy("Swarming Goblins", 10, 1, 3, 1, 6)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("While you are engaged with Swarming Goblins, it gains: \"Forced: When a quest card is bypassed, search the encounter discard pile for a copy of ~Goblin Spearman and put it into play engaged with you.\"")
                .WithInfo(5, 3, Artists.Mark_Behm);
            flight.addEnemy("Coal-Black Orc", 34, Stats.VALUE_X, Stats.VALUE_X, 3, 5)
                .WithTraits("Orc.")
                .WithTextLine("X is the number of victory points in the victory display.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack. X is the number of victory points in the victory display.")
                .WithInfo(6, 3, Artists.Jason_Ward);
            flight.addLocation("Shadowed Corridor", 4, 6)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("As an additional cost to bypass a quest card, each player must raise his threat by 2.")
                .WithShadow("Shadow: If the defending character is a hero, discard all resources in its resource pool. Deal attacking enemy another shadow card for each resource discarded in this way.")
                .WithInfo(7, 4, Artists.Ilich_Henriquez);
            flight.addTreachery("Dismay and Fear")
                .WithTextLine("When Revealed: Choose and remove characters from the quest until the total Willpower of characters removed from the quest is equal to or higher than The ~Nameless Fear's Threat.")
                .WithShadow("Shadow: Discard each attachment you control with a cost less than The ~Nameless Fear's Threat.")
                .WithInfo(8, 3, Artists.Dleoblack);
            flight.addTreachery("An Evil Fortune")
                .WithTraits("Shadow.", "Flame.")
                .WithKeywords("Surge.", "Doomed 1.")
                .WithTextLine("Surge. Doomed 1.")
                .WithTextLine("When Revealed: Add this card to the victory display.")
                .WithShadow("Shadow: If this attack destroys a character, add this card to the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(9, 3, Artists.Mark_Behm);

            return builder;
        }
    }
}
