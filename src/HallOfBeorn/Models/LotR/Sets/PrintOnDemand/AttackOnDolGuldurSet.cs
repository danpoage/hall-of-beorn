﻿using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class AttackOnDolGuldurSet : CardSet
    {
        private const string setName = "Attack on Dol Guldur";
        private const string alternateName = "Assault on Dol Guldur";

        protected override void Initialize()
        {
            Name = setName;
            AlternateName = alternateName;
            Abbreviation = "AoDG";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "Fellowship";
            Number = 3008;

            addQuest("Assault on the Golden Wood", setName, 1, 'A', Card.VALUE_NA)
                .WithFlavor("The Dark Lord of Mordor has declared war across Middle-earth. His Nazgûl lead the Morgul host against Minas Tirith in the south, while Easterlings lay siege to Erebor in the north. And in a move long-prepared, the armies of Dol Guldur cross the Anduin to assault Lórien...")
                .WithTextLine("Setup: Set Host of Lórien and all 4 Lieutenant enemies aside, out of play. Add Power of Lórien and 1 copy of Dol Guldur Marauder per player to the staging area. Shuffle the encounter deck.")
                .WithOppositeTextLine("Forced: At the end of the round, place 1 resource here and move all progress from this stage to Power of Lórien. If there are 3 resources here, advance to stage 2A.")
                .WithOppositeTextLine("Response: At the end of the round, raise each player's threat by 1 to choose a stage. Each player at that stage draws 1 card and adds 1 resource to a hero's resource pool.")
                .WithInfo(1, 1, Artist.Stanislav_Dikolenko);
            addQuest("Crossing the Anduin", setName, 2, 'A', Card.VALUE_NA)
                .WithFlavorLine("Three times Lórien had been assailed from Dol Guldur, but besides the valour of the eleven people of that land, the power that dwelt there was too great for any to overcome...")
                .WithFlavorLine("-The Return of the King")
                .WithText("When Revealed: The first player may remove 10 progress from Power of Lórien to take control of the set-aside Host of Lórien. Then, he may remove an additional 20 progress from Power of Lórien to place it in his play area under his control, otherwise discard it.")
                .WithOppositeFlavorLine("Though grievous harm was done to the fair woods on the borders, the assaults were driven back; and when the Shadow passed, Celeborn came forth and led the host of Lórien over Anduin in many boats.")
                .WithOppositeFlavorLine("-The Return of the King")
                .WithOppositeText("When Revealed: Each player searches the encounter deck and discard pile for a Dol Guldur location and adds it to the staging area. Shuffle the encounter deck. Advance to a stage 3 of your choice. If you are playing epic multiplayer mode, each team must choose a different stage.")
                .WithInfo(2, 1, Artist.Alvaro_Calvo_Escudero);
            addQuest("The Siege of Dol Guldur", setName, 3, 'A', Card.VALUE_NA)
                .WithFlavor("Sauron took Amon Lanc from the Elves at the beginning of the Third Age. Now the Elves lay siege to reclaim the fortress and cleanse the forest.")
                .WithText("When Revealed: Remove all tokens from the Lieutenant enemy at this stage and set it aside, out of play. Add the set aside Bane of Amon Lanc to the staging area, unless it is in a victory display. If Dol Guldur's city strength is 5 or lower (10 or lower if playing epic multiplayer mode), Bane of Amon Lanc makes an immediate attack against each player in turn order.")
                .WithOppositeTextLine("Bane of Amon Lanc gets -1 engagement cost for each progress token on this stage.")
                .WithOppositeTextLine("Forced: At the end of the round, remove 5 progress from this stage or increase Dol Guldur's city strength by 3. The first player may remove an additional 5 progress to reduce Dol Guldur's city strength by 3.")
                .WithInfo(3, 1, Artist.Alvaro_Calvo_Escudero);
            addQuest("The Tower of Sorcery", setName, 3, 'C', Card.VALUE_NA)
                .WithFlavor("Though Sauron moved his seat of power to Barad-dûr, the fortress of Dol Guldur remains a stronghold of dark sorcery.")
                .WithText("When Revealed: Remove all tokens from the Lieutenant enemy at this stage and set it aside, out of play. Add the set aside Sorcerer of Dol Guldur to the staging area, unless it is in a victory display. If Dol Guldur's city strength is 5 or lower (10 or lower if playing epic multiplayer mode), Sorcerer of Dol Guldur makes an immediate attack against each player in turn order.")
                .WithOppositeTextLine("Sorcerer of Dol Guldur gets -1 engagement cost for each progress token on this stage.")
                .WithOppositeTextLine("Forced: At the end of the round, remove 5 progress from this stage or each player at each stage discards all but 1 card from his hand. The first player may remove an additional 5 progress from this stage to choose a player at any stage. That player searches his deck for a card, adds it to his hand, and shuffles his deck.")
                .WithInfo(4, 1, Artist.Julian_Kok);
            addQuest("Battle Under the Trees", setName, 3, 'E', Card.VALUE_NA)
                .WithFlavor("A sortie from Dol Guldur charges into the woods that surround the fortress in an attempt to divide the Elves and break the siege.")
                .WithText("When Revealed: Remove all tokens from the Lieutenant enemy at this stage and set it aside, out of play. Add the set aside Chieftain Morlug to the staging area, unless it is in a victory display. If Dol Guldur's city strength is 5 or lower (10 or lower if playing epic multiplayer mode), Chieftain Morlug makes an immediate attack against each player in turn order.")
                .WithOppositeTextLine("Chieftain Morlug gets -1 engagement cost for each progress token on this stage.")
                .WithOppositeTextLine("Forced: At the end of the round, remove 5 progress from this stage or each player at each stage discards cards from the top of the encounter deck until an enemy is discarded and puts it into play engaged with him. (If the last card of the encounter deck is discarded resolving this effect, shuffle the discard pile back into the encounter deck.) The first player may remove an additional 5 progress from this stage to choose a non-unique enemy at any stage and destroy it.")
                .WithInfo(5, 1, Artist.Carlos_Palma_Cruchaga);
            addQuest("Dungeons of the Necromancer", setName, 3, 'G', Card.VALUE_NA)
                .WithFlavorLine("Amidst the battle, you gain entrance into the dungeons beneath Dol Guldur. You slip inside to release what captives you can, but an evil creature awaits.")
                .WithText("When Revealed: Remove all tokens from the Lieutenant enemy at this stage and set it aside, out of play. Add the set aside Dungeon Dweller to the staging area, unless it is in a victory display. If Dol Guldur's city strength is 5 or lower (10 or lower if playing epic multiplayer mode), Dungeon Dweller makes an immediate attack against each player in turn order.")
                .WithOppositeTextLine("Dungeon Dweller gets -1 engagement cost for each progress token on this stage.")
                .WithOppositeTextLine("Forced: At the end of the round, remove 5 progress from this stage or each player at each stage discards an ally he controls. The first player may remove an additional 5 progress from this stage to choose a player at any stage. That player searches the top 10 cards of his deck for an ally an puts it into play.")
                .WithInfo(6, 1, Artist.Alvaro_Calvo_Escudero);
            addObjective("Dol Guldur", setName)
                .WithUnique()
                .WithTraits("City.", "Stronghold.")
                .WithText("While the players are at stage 3, Dol Guldur gains: \"Forced: At the end of the round, after resolving the Forced effect on each stage 3 in play, reduce Dol Guldur's city strength by X, where X is the total siege value of each location explored and each enemy destroyed at each stage this round.\"")
                .WithInfo(7, 1, Artist.Guillaume_Ducos);
            addObjective("Power of Lórien", setName)
                .WithTraits("Lórien.")
                .WithTextLine("While you control Power of Lórien, it gains: \"Response: Add Power of Lórien to the victory display to cancel and discard an encounter card just revealed from the encounter deck.\"")
                .WithFlavorLine("\"...do not think that only by singing amid the trees, nor even by the slender arrows of elven-bows, is this land of Lothlórien maintained and defended...\"")
                .WithFlavorLine("-Galadriel, The Fellowship of the Ring")
                .WithInfo(8, 1, Artist.Katy_Grierson);
            addObjectiveAlly("Host of Lórien", setName, 3, 3, 3, 6)
                .WithTraits("Silvan.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithTextLine("Ranged. Sentinel.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Does not exhaust to quest.")
                .WithTextLine("If Host of Lórien leaves play, remove it from the game.")
                .WithInfo(9, 1, Artist.Stanislav_Dikolenko);
            addEnemy("Bane of Amon Lanc", setName, 45, 3, 5, 3, 9)
                .WithUnique()
                .WithTraits("Lieutenant.", "Troll.", "Olog-hai.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Immune to player card effects.")
                .WithTextLine("Forced: When Bane of Amon Lanc attacks you, discard a random card from your hand. Bane of Amon Lanc gets +X Attack for this attack, where X is that card's printed cost.")
                .WithVictoryPoints(5)
                .WithInfo(10, 1, Artist.Alexander_Kozachenko);
            addEnemy("Sorcerer of Dol Guldur", setName, 45, 3, 6, 2, 9)
                .WithUnique()
                .WithTraits("Lieutenant.", "Sorcerer.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Immune to player card effects.")
                .WithTextLine("Forced: When Sorcerer of Dol Guldur attacks you, discard the top card of your deck. Then, discard each copy of that card from play.")
                .WithFlavorLine("\"A great kind and sorcerer he was of old, and now he wields a deadly fear.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithVictoryPoints(5)
                .WithInfo(11, 1, Artist.Gabriel_Verdon);
            addEnemy("Chieftain Morlug", setName, 45, 3, 3, 4, 8)
                .WithUnique()
                .WithTraits("Lieutenant.", "Orc.", "Uruk.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Immune to player card effects.")
                .WithTextLine("Forced: When Chieftain Morlug attacks you, discard cards from the top of the encounter deck until an enemy is discarded and put it into play engaged with you.")
                .WithVictoryPoints(5)
                .WithInfo(12, 1, Artist.Ivan_Dixon);
            addEnemy("Dungeon Dweller", setName, 45, 3, 4, 3, 8)
                .WithUnique()
                .WithTraits("Lieutenant.", "Spider.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible.")
                .WithTextLine("Forced: When Dungeon Dweller attacks you, discard an ally you control.")
                .WithFlavorLine("Sauron would send her prisoners that he had no better uses for: he would have them driven to her hold, and report brought back to him of the play she made.")
                .WithFlavorLine("-The Two Towers")
                .WithVictoryPoints(5)
                .WithInfo(13, 1, Artist.Guillaume_Ducos);
            addEnemy("Host of Dol Guldur", setName, 40, 254, 8, 4, 12)
                .WithTraits("Orc.")
                .WithKeywords("Archery X.")
                .WithTextLine("Archery X.")
                .WithTextLine("X is the number of players.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: At the end of the encounter phase, if Host of Dol Guldur is in the staging area, remove X progress from the main quest.")
                .WithSiegePoints(4)
                .WithInfo(14, 2, Artist.Joel_Hustak);
            addEnemy("Mirkwood Olog-hai", setName, 34, 4, 6, 4, 9)
                .WithTraits("Troll.", "Olog-hai.")
                .WithText("Forced: After Mirkwood Olog-hai attacks and destroys a character, remove 1 progress from the main quest for each excess point of damage.")
                .WithShadow("Shadow: Either remove 2 progress from the main quest, or return attacking enemy to the staging area.")
                .WithSiegePoints(3)
                .WithInfo(15, 2, Artist.Ivan_Dixon);
            addEnemy("Beast of Taur-nu-Fuin", setName, 31, 3, 5, 3, 5)
                .WithTraits("Creature.", "Werewolf.")
                .WithTextLine("Beast of Taur-nu-Fuin cannot have attachments and its shadow cards cannot be canceled.")
                .WithTextLine("Forced: When Beast of Taur-nu-Fuin attacks, either remove 2 progress from the main quest or deal it an additional shadow card.")
                .WithSiegePoints(2)
                .WithInfo(16, 2, Artist.Guillaume_Ducos);
            addEnemy("Amon Lanc Archer", setName, 36, 2, 4, 1, 4)
                .WithTraits("Orc.")
                .WithKeywords("Archery 2.")
                .WithTextLine("Archery 2.")
                .WithTextLine("Forced: After Amon Lanc Archer engages you, either remove 2 progress from the main quest, or deal 2 damage to an ally you control.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithSiegePoints(1)
                .WithInfo(17, 3, Artist.Rafal_Hrynkiewicz);
            addEnemy("Dol Guldur Marauder", setName, 24, 2, 3, 1, 3)
                .WithTraits("Orc.")
                .WithTextLine("Dol Guldur Marauder gets +1 Attack and +1 Defense for each resource on it.")
                .WithTextLine("Forced: When Dol Guldur Marauder attacks, either remove 1 progress from the main quest or place 1 resource on Dol Guldur Marauder.")
                .WithSiegePoints(1)
                .WithInfo(18, 4, Artist.Joel_Hustak);
            addEnemy("Battle Warg", setName, 18, 1, 3, 2, 2)
                .WithTraits("Creature.", "Warg.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: After Battle Warg engages you, either remove 1 progress from the main quest or discard an attachment you control.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithSiegePoints(1)
                .WithInfo(19, 3, Artist.Guillaume_Ducos);
            addLocation("Gate of Dol Guldur", setName, 2, 4)
                .WithTraits("Dol Guldur.")
                .WithText("While Gate of Dol Guldur is in the staging area, it gains: \"The player cannot travel or place progress here unless they are at stage 3B. Each player's threat cannot be reduced by more than 1 each round by player card effects.\"")
                .WithFlavorLine("\"Before you could get round it in the South, you would get into the land of the Necromancer...\"")
                .WithFlavorLine("-Gandalf, The Hobbit")
                .WithSiegePoints(2)
                .WithInfo(20, 2, Artist.Katy_Grierson);
            addLocation("The Sorcerer's Tower", setName, 2, 4)
                .WithTraits("Dol Guldur.")
                .WithText("While The Sorcerer's Tower is in the staging area, it gains: \"The players cannot travel or place progress here unless they are at stage 3D. Forced: After a 'when revealed' effect is canceled, reveal the top card of the encounter deck.\"")
                .WithFlavorLine("\"I don't advise you to go anywhere near the places overlooked by his dark tower!\"")
                .WithFlavorLine("-Gandalf, The Hobbit")
                .WithSiegePoints(2)
                .WithInfo(21, 2, Artist.Julian_Kok);
            addLocation("The Shadow Road", setName, 2, 4)
                .WithTraits("Dol Guldur.")
                .WithTextLine("The Shadow Road gets +2 Threat for each facedown card attached to it.")
                .WithTextLine("While The Shadow Road is in the staging area, it gains: \"The players cannot travel or place progress here unless they are at stage 3F. Forced: After an event is played during the quest phase, attach it facedown to The Shadow Road.\"")
                .WithSiegePoints(2)
                .WithInfo(22, 2, Artist.Katy_Grierson);
            addLocation("Dungeon Door", setName, 2, 4)
                .WithTraits("Dol Guldur.")
                .WithText("While Dungeon Door is in the staging area, it gains: \"The players cannot travel or place progress here unless they are at stage 3H. No more than 1 damage can be healed from each character each round.\"")
                .WithFlavorLine("\"I alone of you have been in the dungeons of the Dark Lord, and only in his older and lesser dwelling...\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithSiegePoints(2)
                .WithInfo(23, 2, Artist.Stanislav_Dikolenko);
            addLocation("Forest Battleground", setName, 1, 5)
                .WithTraits("Forest.")
                .WithTextLine("Forest Battleground gets +1 Threat for each ally controlled by the player with the most allies.")
                .WithTextLine("Forced: When Forest Battleground is explored, each player searches the encounter deck and discard pile for an Orc enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithInfo(24, 2, Artist.Carlos_Palma_Cruchaga);
            addLocation("Blackened Woods", setName, 3, 3)
                .WithTraits("Forest.")
                .WithText("Forced: When Blackened Woods is explored, discard the top card of the encounter deck and raise each player's threat by X, where X is that card's printed Threat.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, remove 3 progress from the main quest.")
                .WithInfo(25, 3, Artist.Alyn_Spiller);
            addTreachery("Servant of Sauron", setName)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: The enemy in the staging area with the highest engagement cost makes an immediate attack against the first player.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(26, 3, Artist.Alexander_Kozachenko);
            addTreachery("Power Sevenfold", setName)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player must choose: either search the encounter deck and discard pile for a Dol Guldur location and add it to the staging area, or search the encounter deck and discard pile for an Orc enemy and put it into play engaged with him.")
                .WithInfo(27, 2, Artist.Carlos_Palma_Cruchaga);
            addTreachery("The Necromancer's Rage", setName)
                .WithText("When Revealed: Deal 1 damage to each exhausted character. Until the end of the phase, each damaged character gets -1 Willpower.")
                .WithShadow("Shadow: Deal 1 damage to the defending character. Until the end of the phase, the defending character gets -1 Defense for each damage on it.")
                .WithInfo(28, 2, Artist.Stanislav_Dikolenko);
            addTreachery("Fear and Despair", setName)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player exhausts a character he controls. Until the end of the round, characters cannot be readied by player card effects.")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithInfo(29, 2, Artist.Gabriel_Verdon);
            addTreachery("Fastness of Mirkwood", setName)
                .WithText("When Revealed: No more than 5 progress can be placed on the current quest this round. If Dol Guldur's city strength is 5 or lower, Fastness of Mirkwood gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack and +1 Defense until the end of the phase (+2 Attack and +2 Defense instead if at least 5 progress is on the quest).")
                .WithInfo(30, 2, Artist.Katy_Grierson);
            addCampaign("Standard Game Mode", setName, "Standard Game Mode")
                .WithText("Setup: Add Dol Guldur to the staging area, attach a threat dial to it, and set its value to 5. Then, increase it's value by 5 for each player. For the rest of the game, that threat dial is the siege tracker and it displays the city strength of Dol Guldur. Flip this card over.")
                .WithFlavorLine("\"...we were drawing nigh to Dol Guldur, and that is still a very evil place; we do not go that way.\"")
                .WithFlavorLine("-Legolas, The Fellowship of the Ring")
                .WithOppositeTextLine("While Dol Guldur's city strength is 0, each Lieutenant enemy loses indestructible.")
                .WithOppositeTextLine("While the players are at stage 3, this card gains: \"Forced: After resolving the Forced effect on Dol Guldur, randomly select a stage 3 that was not in play this round and resolve its Forced effect. Then, discard all progress from the current stage 3 and advance to a new stage 3 of your choice.\"")
                .WithOppositeTextLine("At the end of the round, if Dol Guldur's city strength is 0 and there are no Lieutenant enemies in play, Dol Guldur is captured and the players win the game.")
                .WithOppositeFlavor("After the fall of the Dark Tower and the passing of Sauron the Shadow was lifted from the hearts of all who opposed him, but fear and despair fell upon his servants and allies. -The Return of the King")
                .WithInfo(31, 1, Artist.Alvaro_Calvo_Escudero);
            addCampaign("Epic Multiplayer Mode", setName, "Epic Multiplayer Mode")
                .WithText("Setup: Create 3 separate staging area, each with its own quest deck and encounter deck. Divide the players into 3 teams, one for each staging area. One team puts Dol Guldur into play in their staging area, attaches a threat dial to it, and sets its value to 5. Then, increase its value by 5 for each player at each stage. For the rest of the game, that threat dial is the siege tracker and it displays the city strength of Dol Guldur. Each other team removes their copy of Dol Guldur. Each other team removes their copy of Dol Guldur from the game. Flip this card over.")
                .WithFlavorLine("...there was long battle under the trees and great ruin of fire...")
                .WithFlavorLine("-The Return of the King")
                .WithOppositeTextLine("While Dol Guldur's city strength is 0, each Lieutenant enemy loses indestructible.")
                .WithOppositeTextLine("While the players are at stage 3, this card gains: \"Forced: After resolving the Forced effect on Dol Guldur, the team with Dol Guldur in their staging area resolves the forced effect on the stage 3 that was not in play at any stage this round. Then, each team discards all progress from their stage 3 and advances to a new stage 3 of their choice. Each team must choose a different stage.\"")
                .WithOppositeTextLine("Response: At the end of the round, a player who controls Host of Lórien or Power of Lórien may give control of that card to another player at any stage.")
                .WithOppositeTextLine("If the last player at a stage is eliminated, the siege falls and the entire group loses the game. At the end of the round, if Dol Guldur's city strength is 0 and there are no Lieutenant enemies in play at each stage, Dol Guldur is captured and the players win the game.")
                .WithOppositeFlavorLine("They took Dol Guldur, and Galadriel threw down its walls and laid bare its pits, and the forest was cleared.")
                .WithOppositeFlavorLine("-The Return of the King")
                .WithInfo(32, 1, Artist.Carlos_Palma_Cruchaga);
            addHero("Celeborn", 11, Sphere.Leadership, 3, 2, 2, 4)
                .WithTraits("Silvan.", "Noble.")
                .WithText("Response: After a Silvan ally enters play, that ally gets +1 Willpower, +1 Attack, and +1 Defense until the end of the round.")
                .WithPromotion()
                .WithInfo(1, 1, Artist.Drazenka_Kimpel);
            addHero("Galadriel", 9, Sphere.Spirit, 4, 0, 0, 4)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("Galadriel cannot quest, attack or defend. Allies you control do not exhaust to commit to the quest during the round they enter play.")
                .WithTextLine("Action: Exhaust Galadriel to choose a player. That player reduces his threat by 1 and draws 1 card. (Limit once per round.)")
                .WithPromotion()
                .WithInfo(112, 1, Artist.Drazenka_Kimpel);
        }
    }
}
