﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class MountGundabadSet : CardSet
    {
        private const string setName = "Mount Gundabad";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "MG";
            Number = 54;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            IsSpoiler = true;

            addHero("Bilbo Baggins", 9, Sphere.Tactics, 1, 1, 2, 2)
                .WithTraits("Hobbit.", "Burglar.")
                .WithText("Response: After Bilbo ~Baggins commits to the quest, choose an enemy in the staging area. Until the end of the phase, Bilbo ~Baggins gets +X Willpower where X is that enemy's Threat. If the players quest successfully, deal 1 damage to that enemy (2 damage instead if it is guarding a card).")
                .WithInfo(112, 1, Artist.Tropa_Entertainment);
            addAlly("Greenwood Defender", 3, Sphere.Leadership, false, 0, 0, 2, 3)
                .WithTraits("Silvan.", "Warrior.")
                .WithText("Response: After Greenwood Defender enters play, it does not exhaust to defend until the end of the round.")
                .WithFlavor("...after the coming of Men they took ever more and more to the gloaming and the dusk.\r\n-The Hobbit")
                .WithInfo(113, 3, Artist.Unknown);
            addEvent("Elf Guide", 0, Sphere.Leadership)
                .WithText("Action: Return a Silvan ally you control to your hand to choose a hero. Add 1 resource to that hero's pool.")
                .WithFlavor("...soon Haldir turned aside into the trees and halted on the bank of the river under their shadows.\r\n-The Fellowship of the Ring")
                .WithInfo(114, 3, Artist.John_Howe);
            addAlly("Gaffer Gamgee", 2, Sphere.Lore, true, 1, 1, 0, 1)
                .WithTraits("Hobbit.")
                .WithText("Combat Action: Return Gaffer Gamgee to your hand to choose an enemy with engagement cost higher than your threat. Until the end of the round, that enemy cannot attack you.")
                .WithFlavor("\"Why? Why's none of my business, or yours.\"\r\n-The Fellowship of the Ring")
                .WithInfo(115, 3, Artist.Romana_Kendelic);
            addEvent("Drinking Song", 0, Sphere.Lore)
                .WithTraits("Song.")
                .WithText("Action: Count the number of cards in your hand and shuffle your hand into your deck. Then, draw an equal number of cards. Draw 1 additional card if you control a unique Hobbit character.")
                .WithFlavor("Ho! Ho! Ho! to the bottle I go\r\nTo heal my heart and drown my woe.\r\n-The Fellowship of the Ring")
                .WithInfo(116, 3, Artist.Romana_Kendelic);
            addAttachment("Sting", 0, Sphere.Tactics, true)
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Guarded (enemy).", "Restricted.")
                .WithText("Attach to a Hobbit hero.\r\nAttached hero gets +1 Willpower, +1 Attack, and +1 Defense.\r\nResponse: After attached hero is declared as an attacker or defender against an enemy, deal 1 damage to that enemy.")
                .WithTemplate("<p class='main-text'>{keyword:Guarded (enemy)}.</p><p class='main-text'>Attach to a {trait:Hobbit.@Hobbit} hero. {keyword:Restricted}</p><p class='main-text'>Attach hero gets +1 {Willpower}, +1 {Attack}, and +1 {Defense}.</p><p class='main-text'><b>Response:</b> After attached hero is declared as an attacker or defender against an enemy, deal 1 damage to that enemy.</p>")
                .WithInfo(117, 3, Artist.Tropa_Entertainment);
            addAttachment("Round Shield", 0, Sphere.Tactics, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a character. Restricted.\r\nResponse: After a shadow effect is triggered during combat, exhaust Round Shield to give attached character +2 Defense for this attack.")
                .WithInfo(118, 3, Artist.Sara_Biddle);
            addAlly("Erebor Toymaker", 3, Sphere.Spirit, false, 2, 0, 0, 2)
                .WithTraits("Dwarf.", "Craftsman.")
                .WithText("Response: After you play ~Erebor Toymaker from your hand, reduce the cost of the next attachment played this phase by 2.")
                .WithFlavor("There were toys the like of which they had never seen before, all beautiful and some obviously magical.\r\n-The Fellowship of the Ring")
                .WithInfo(119, 3, Artist.Ryan_Valle);
            addAttachment("Armor of Erebor", 2, Sphere.Spirit, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dale or Dwarf character.\r\nAttached character gets +1 Defense and gains sentinel.")
                .WithFlavor("\"We make good armour and keen swords, but we cannot again make mail or blade to match those that were made before the dragon came.\"\r\n-Glóin, The Fellowship of the Ring")
                .WithInfo(120, 3, Artist.Alexander_Kozachenko);
            addEvent("The Shirefolk", 0, Sphere.Neutral)
                .WithText("Play only if each of your heroes is a Hobbit.\r\nAction: Reduce your threat by 4.")
                .WithFlavor("\"If more of us valued food and cheer and song above hoarded gold, it would be a merrier world.\"\r\n-Thorin Oakenshield, The Hobbit")
                .WithInfo(121, 3, Artist.Carmen_Cianelli);

            addLocation("The First Forge", setName, 1, 1)
                .WithUnique()
                .WithTraits("Underground.")
                .WithText("Immune to player card effects.\r\nForced: After The First ~Forge becomes the active location, exhaust the hero with Wormsbane attached. That hero cannot ready while The First ~Forge is the active location.\r\nResponse: After the First Forge is explored, flip Wormsbane to its Reforged side and attach it to any hero.")
                .WithVictoryPoints(1)
                .WithInfo(122, 1, Artist.Tomasz_Jedruszek);
            addLocation("Dagnir's Hoard", setName, 7, 7)
                .WithUnique()
                .WithTraits("Undergound.")
                .WithText("Forced: When Dagnir's Hoard is explored, Dagnir returns to the staging area and makes an immediate attack against each player in turn order.\r\nResponse: After Dagnir's Hoard is explored, each player may search his deck for an Item attachment, add it to his hand, and shuffle his deck.")
                .WithVictoryPoints(1)
                .WithInfo(123, 1, Artist.Nele_Diel);
            addLocation("Throat of the Mountain", setName, 4, 4)
                .WithUnique()
                .WithTraits("Underground.", "Dark.")
                .WithText("Response: When Throat of the ~Mountain is explored, search the quest deck for a quest card and make it the current main quest. Then, flip it over. Shuffle the rest of the quest deck.")
                .WithFlavor("At the end of the hall the floor vanished and fell to an unknown depth.\r\n-The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithInfo(124, 1, Artist.Lucas_Staniec);
            addEnemy("Dagnir", setName, 50, Card.VALUE_X, 7, 5, 20)
                .WithUnique()
                .WithTraits("Dragon.")
                .WithKeywords("Indestructible.")
                .WithText("Immune to player card effects. X is 1 more than the number of quest cards in the victory display.\r\nCannot take more than X damage each round.\r\nWhile there are 5 or more quest cards in the victory display, Dagnir cannot leave the staging area and is considered to be engaged with each player.")
                .WithTemplate("<p class='main-text'>{keyword:Indestructible.} Immune to player card effects. X is 1 more than the number of quest cards in the victory display.</p><p class='main-text'>Cannot take more than X damage each round.</p><p class='main-text'>While there are 5 or more quest cards in the victory display, {self} cannot leave the staging area and is considered to be engaged with each player.</p>")
                .WithInfo(125, 1, Artist.Antonio_Jose_Manzanedo);
            addEnemy("Guardian of Gundabad", setName, 39, 3, 4, 1, 5)
                .WithTraits("Orc.", "Goblin.")
                .WithText("While there are 3 or more quest cards in the victory display, ~Guardian of Gundabad gets +2 Defense.")
                .WithShadow("Shadow: Attacking enemy gets +2 Defense until the end of the phase.")
                .WithInfo(126, 3, Artist.Martin_de_Diego_Sadaba);
            addEnemy("Dagnir's Slave", setName, 26, 2, 3, 2, 3)
                .WithTraits("Orc.", "Goblin.")
                .WithText("Dagnir cannot take damage from non-quest effects.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if Dagnir is engaged with you).")
                .WithEasyModeQuantity(2)
                .WithInfo(127, 3, Artist.Rafal_Hrynkiewicz);
            addEnemy("Deep-dweller", setName, 32, 2, 3, 1, 4)
                .WithTraits("Creature.", "Spider.")
                .WithText("Forced: When Deep-dweller engages you, it makes an immediate attack.\r\nForced: After Deep-dweller take any amount of damage (and survives), return it to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(128, 2, Artist.Guillaume_Ducos);
            addLocation("Mines of Gundabad", setName, 3, 3)
                .WithTraits("Underground.", "Dark.")
                .WithKeywords("Deep.")
                .WithText("Dagnir gets -10 engagement cost.")
                .WithShadow("Shadow: If attacking enemy is Dagnir, the defending player must assign X damage among characters he controls, where X is 1 more than the number of quest cards in the victory display.")
                .WithTemplate("<p class='main-text'>{keyword:Deep.}</p><p class='main-text'>Dagnir gets -10 engagement cost.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If attacking enemy is Dagnir, the defending player must assign X damage among characters he controls, where X is 1 more than the number of quest cards in the victory display.</p>")
                .WithEasyModeQuantity(2)
                .WithInfo(129, 3, Artist.Mariusz_Gandzel);
            addLocation("Narrow Stair", setName, 2, 3)
                .WithTraits("Underground.")
                .WithKeywords("Deep.")
                .WithText("When faced with the option to travel, the players must travel to Narrow Stair.")
                .WithShadow("Shadow: Until the end of the round, defending character cannot be readied by player card effects.")
                .WithTemplate("<p class='main-text'>{keyword:Deep.}</p><p class='main-text'>When faced with the option to travel, the players must travel to {self}.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Until the end of the round, defending character cannot be readied by player card effects.</p>")
                .WithEasyModeQuantity(1)
                .WithInfo(130, 2, Artist.Mariusz_Gandzel);
            addLocation("Desecrated Ruins", setName, 2, 4)
                .WithTraits("Underground.", "Dark.")
                .WithKeywords("Deep.")
                .WithText("While there are 3 or more quest cards in the victory display, Desecrated Ruins gets +2 Threat.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, each player discards a random card from his hand.")
                .WithTemplate("<p class='main-text'>{keyword:Deep.} While there are 3 or more quest cards in the victory display, {self} gets +2 {Threat}.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Attacking enemy gets +1 {Attack}. If this attack destroys a character, each player discards a random card from his hand.</p>")
                .WithInfo(131, 2, Artist.Mariusz_Gandzel);
            addTreachery("Wilderland's Bane", setName)
                .WithText("When Revealed: Dagnir makes an immediate attack against each engaged player. If no attacks were made this way, Dagnir gets -30 engagement cost until the end of the round.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(0)
                .WithInfo(132, 2, Artist.Jokubas_Uoginitas);
            addTreachery("Suffocating Shadows", setName)
                .WithText("When Revealed: Each player assigns X damage among allies he controls, where X is 1 more than the number of quest cards in the victory display.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if there are 3 or more quests in the victory display).")
                .WithInfo(133, 2, Artist.Jokubas_Uoginitas);
            addQuest("The Side Door", setName, 1, 'A', Card.VALUE_NA)
                .WithFlavor("Mount Gundabad rises before you, and the Dragon, Dagnir, waits within.")
                .WithText("Setup: Add Dagnir to the staging area and set The First Forge aside, out of play. Create the Caves deck and the quest deck (see insert). Attach Wormsbane to a hero, Broken side face-up. Shuffle the encounter deck and discard cards from the top until X locations have been discarded, where X is 1 less than the number of players in the game. Add those locations to the staging area.")
                .WithOppositeFlavor("It doesn't take you long to discover Urdug's secret entrance, and with a turn from Durin's Key the way into Mount Gundabad lies open before you. You must find Durin's Forge, repair Wormsbane, and use it to kill Dagnir.")
                .WithOppositeText("Forced: At the end of the planning phase, the first player looks at the top 2 cards of the quest deck and chooses 1 to place on the bottom of the quest deck. Then, add The Side Door to the victory display and advance to the top stage 2A of the quest deck.")
                .WithVictoryPoints(1)
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.DeepUnderground, EncounterSet.AfraidOfTheDark, EncounterSet.LostCaves, EncounterSet.DragonMight)
                .WithInfo(134, 1, Artist.Andreas_Adamek);
            addQuest("Exploring Gundabad", setName, 2, 'A', 3)
                .WithOppositeTitle("The Upper Levels")
                .WithFlavor("The interior of Gundabad is dark and  vast. Only by exploring the mines can you find your way.")
                .WithText("When Revealed: Return Dagnir to the staging area.\r\nIf Exploring Gundabad is the current main quest, do not flip it over until the beginning of the quest phase.")
                .WithOppositeText("Forced: After characters are committed to the quest, raise each player's threat by 1.\r\nForced: When this stage is defeated, shuffle The First ~Forge into the Caves deck.\r\nAt the end of the combat phase, the players may bypass this stage.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.DeepUnderground, EncounterSet.AfraidOfTheDark, EncounterSet.LostCaves, EncounterSet.DragonMight)
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Jose_Vega)
                .WithInfo(135, 1, Artist.David_Keen);
            addQuest("Exploring Gundabad", setName, 2, 'A', 3)
                .WithOppositeTitle("The Lower Deeps")
                .WithBackStageLetter('C')
                .WithFlavor("The interior of Gundabad is dark and  vast. Only by exploring the mines can you find your way.")
                .WithText("When Revealed: Return Dagnir to the staging area.\r\nIf Exploring Gundabad is the current main quest, do not flip it over until the beginning of the quest phase.")
                .WithOppositeText("The 'when revealed' effects of the first treachery revealed each round cannot be canceled.\r\nForced: When this stage is defeated, search the Caves deck for a location and make it the active location. Shuffle the Caves deck.\r\nAt the end of the combat phase, the players may bypass this stage.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.DeepUnderground, EncounterSet.AfraidOfTheDark, EncounterSet.LostCaves, EncounterSet.DragonMight)
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.David_Keen)
                .WithInfo(137, 1, Artist.David_Keen);
            addQuest("Exploring Gundabad", setName, 2, 'A', 5)
                .WithOppositeTitle("Frenzied Warrens")
                .WithBackStageLetter('D')
                .WithFlavor("The interior of Gundabad is dark and  vast. Only by exploring the mines can you find your way.")
                .WithText("When Revealed: Return Dagnir to the staging area.\r\nIf Exploring Gundabad is the current main quest, do not flip it over until the beginning of the quest phase.")
                .WithOppositeText("Forced: After characters are committed to the quest, discard the top 5 cards of the encounter deck. Add a random enemy discarded this way to the staging area.\r\nForced: When this stage is defeated, reduce each player's threat by 5.\r\nAt the end of the combat phase, the players may bypass this stage.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.DeepUnderground, EncounterSet.AfraidOfTheDark, EncounterSet.LostCaves, EncounterSet.DragonMight)
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Martin_de_Diego_Sadaba)
                .WithInfo(138, 1, Artist.David_Keen);
            addQuest("Exploring Gundabad", setName, 2, 'A', 7)
                .WithOppositeTitle("Dagnir's Wrath")
                .WithBackStageLetter('E')
                .WithFlavor("The interior of Gundabad is dark and  vast. Only by exploring the mines can you find your way.")
                .WithText("When Revealed: Return Dagnir to the staging area.\r\nIf Exploring Gundabad is the current main quest, do not flip it over until the beginning of the quest phase.")
                .WithOppositeText("Forced: After characters are committed to the quest, Dagnir makes an immediate attack against each player with 6 or more characters.\r\nForced: When this stage is defeated, deal 5 damage to Dagnir. This damage is not limited by Dagnir's text, and does not count toward her X value.\r\nAt the end of the combat phase, the players may bypass this stage.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.DeepUnderground, EncounterSet.AfraidOfTheDark, EncounterSet.LostCaves, EncounterSet.DragonMight)
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Jokubas_Uoginitas)
                .WithInfo(139, 1, Artist.David_Keen);
            addQuest("Exploring Gundabad", setName, 2, 'A', 4)
                .WithOppositeTitle("Foreboding Darkness")
                .WithBackStageLetter('F')
                .WithFlavor("The interior of Gundabad is dark and  vast. Only by exploring the mines can you find your way.")
                .WithText("When Revealed: Return Dagnir to the staging area.\r\nIf Exploring Gundabad is the current main quest, do not flip it over until the beginning of the quest phase.")
                .WithOppositeText("Each player cannot play more than 1 card each phase.\r\nForced: When this stage is defeated, the first player looks at the top 2 cards of the quest deck and chooses 1 to place on the bottom of the quest deck. Then, flip over the top card of the quest deck.\r\nAt the end of the combat phase, the players may bypass this stage.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.DeepUnderground, EncounterSet.AfraidOfTheDark, EncounterSet.LostCaves, EncounterSet.DragonMight)
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.David_Keen)
                .WithInfo(140, 1, Artist.David_Keen);
            addQuest("Exploring Gundabad", setName, 2, 'A', 6)
                .WithOppositeTitle("Imminent Pursuit")
                .WithBackStageLetter('G')
                .WithFlavor("The interior of Gundabad is dark and  vast. Only by exploring the mines can you find your way.")
                .WithText("When Revealed: Return Dagnir to the staging area.\r\nIf Exploring Gundabad is the current main quest, do not flip it over until the beginning of the quest phase.")
                .WithOppositeText("Forced: After characters are committed to the quest, each player must deal 2 damage to a questing character he controls.\r\nForced: When this stage is defeated, discard a non-unique enemy from play.\r\nAt the end of the combat phase, the players may bypass this stage.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.DeepUnderground, EncounterSet.AfraidOfTheDark, EncounterSet.LostCaves, EncounterSet.DragonMight)
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Nikolas_Hagialas)
                .WithInfo(141, 1, Artist.David_Keen);
            addQuest("Exploring Gundabad", setName, 2, 'A', Card.VALUE_NA)
                .WithOppositeTitle("The Great Worm")
                .WithBackStageLetter('H')
                .WithFlavor("The interior of Gundabad is dark and  vast. Only by exploring the mines can you find your way.")
                .WithText("When Revealed: Return Dagnir to the staging area.\r\nIf Exploring Gundabad is the current main quest, do not flip it over until the beginning of the quest phase.")
                .WithOppositeText("Dagnir gets -5 engagement cost for each character the first player controls.\r\nResponse: After a player resolve an attack against Dagnir, if Dagnir has no hit points remaining, that player may discard a Reforged Wormsbane he controls to add Dagnir to the victory display. Then, the players win the game.\r\nAt the end of the combat phase, if there are 4 or fewer quests in the victory display, the players must bypass this stage.")
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.DeepUnderground, EncounterSet.AfraidOfTheDark, EncounterSet.LostCaves, EncounterSet.DragonMight)
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Antonio_Jose_Manzanedo)
                .WithInfo(142, 1, Artist.David_Keen);
            addObjective("Wormsbane", setName)
                .WithUnique()
                .WithSuffix("Broken")
                .WithTraits("Artifact.", "Weapon.", "Broken.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a hero.\r\nAttached hero gets +1 Attack.\r\nIf attached hero leaves play, the players lose the game.")
                .WithFlavor("...they tell that he slew Scatha, the great Dragon of Ered Mithrin, and the land had peace from the long-worms afterwards.\r\n-The Return of the King")
                .WithTemplate("<p class='main-text'>Attach to a hero. {keyword:Restricted.}</p><p class='main-text'>Attached hero gets +1 {Attack}.</p><p class='main-text'><b>If attached hero leaves play, the players lose the game.</b></p><p class='flavor-text'>...they tell that he slew Scatha, the great Dragon of Ered Mithrin, and the land had peace from the long-worms afterwards.<br>&ndash;The Return of the King</p>")
                .WithInfo(143, 1, Artist.Sebastian_Zakrzewski);
            addObjective("Wormsbane", setName)
                .WithUnique()
                .WithSuffix("Reforged")
                .WithTraits("Artifact.", "Weapon.", "Reforged.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a hero.\r\nAttached hero gets +X Attack, where X is 1 more than the number of quest cards in the victory display.\r\nIf attached hero leaves play, the players lose the game.")
                .WithTemplate("<p class='main-text'>Attach to a hero. {keyword:Restricted.}</p><p class='main-text'>Attached hero gets +X {Attack}, where X is 1 more than the number of quest cards in the victory display.</p><p class='main-text'><b>If attached hero leaves play, the players lose the game.</b></p><p class='flavor-text'>...they tell that he slew Scatha, the great Dragon of Ered Mithrin, and the land had peace from the long-worms afterwards.<br>&ndash;The Return of the King</p>")
                .WithInfo(144, 1, Artist.Sebastian_Zakrzewski);
        }
    }
}