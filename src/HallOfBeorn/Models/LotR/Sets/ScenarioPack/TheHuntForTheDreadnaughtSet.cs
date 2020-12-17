﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.ScenarioPack
{
    public class TheHuntForTheDreadnaughtSet
        : CardSet
    {
        public const string setName = "The Hunt for the Dreadnaught";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "THftD";
            SetType = Models.SetType.Scenario_Pack;
            Cycle = "Scenario Pack";
            Number = 4001;

            addGenConSetup("Easy Mode", EncounterSet.TheHuntForTheDreadnaught)
                .WithTextLine("Setup:")
                .WithTextLine("• Players prepare their fleet.")
                .WithTextLine("• Prepare the Corsair deck.")
                .WithTextLine("• Set the following enemies aside: all 7 unique enemies (including the Dreadnaught), 2 copies of Black Sails, and 1 copy of Corsair Warship.")
                .WithTextLine("• Add the Cobas Haven loction to the staging area. Shuffle the encounter deck.")
                .WithTextLine("• Add 1 resource to each hero's resource pool.")
                .WithTextLine("• Flip this card over and place it next to the quest deck.")
                .WithOppositeTextLine("Each player draws 1 additional card during the resource phase.")
                .WithOppositeTextLine("Quest Action: Deal 10 damage to a non-unique enemy engaged with a player in any group. (Group limit once per game.)")
                .WithOppositeTextLine("If a player controls no ship-objective, that player is eliminated from the game.")
                .WithOppositeFlavorLine("And looking thither they cried in dismay; for black against the glittering stream they beheld a fleet of borne up on the wind: dromunds, and ships of great draught with many oars, and with black sails bellying in the breeze.")
                .WithOppositeFlavorLine("-The Return of the King")
                .WithInfo(1, 1, Artist.Joshua_Cairos);
            addGenConSetup("Standard Mode", EncounterSet.TheHuntForTheDreadnaught)
                .WithTextLine("Setup:")
                .WithTextLine("• Players prepare their fleet.")
                .WithTextLine("• Prepare the Corsair deck.")
                .WithTextLine("• Set the following enemies aside: all 7 unique enemies (including the Dreadnaught).")
                .WithTextLine("• Shuffle the encounter deck and discard cards from the top until 2 locations are discarded (3 locations instead if there are 3 or more players). Add those locations to the staging area.")
                .WithTextLine("• Flip this card over and place it next to the quest deck.")
                .WithOppositeTextLine("Quest Action: Deal 10 damage to a non-unique enemy engaged with a player in any group. (Group limit once per game.)")
                .WithOppositeTextLine("If a player controls no ship-objective, that player is eliminated from the game.")
                .WithOppositeFlavorLine("And looking thither they cried in dismay; for black against the glittering stream they beheld a fleet of borne up on the wind: dromunds, and ships of great draught with many oars, and with black sails bellying in the breeze.")
                .WithOppositeFlavorLine("-The Return of the King")
                .WithInfo(2, 1, Artist.Joshua_Cairos);
            addGenConSetup("Hard Mode", EncounterSet.TheHuntForTheDreadnaught)
                .WithTextLine("Setup:")
                .WithTextLine("• Players prepare their fleet.")
                .WithTextLine("• Prepare the Corsair deck.")
                .WithTextLine("• Set the following enemies aside: all 7 unique enemies (including the Dreadnaught).")
                .WithTextLine("• Add 3 Tolfalas Landing locations to the staging area (3 Tolfalas Landing locations and 2 Wicked Cove locations if there are 3 or more players). Shuffle the encounter deck.")
                .WithTextLine("• Flip this card over and place it next to the quest deck.")
                .WithOppositeTextLine("Each player's threat cannot be reduced by more than 1 each round.")
                .WithOppositeTextLine("Forced: After a character is healed or readied by a player card effect, its controller raises their threat by 1.")
                .WithOppositeTextLine("If a player controls no ship-objective, that player is eliminated from the game.")
                .WithOppositeFlavorLine("And looking thither they cried in dismay; for black against the glittering stream they beheld a fleet of borne up on the wind: dromunds, and ships of great draught with many oars, and with black sails bellying in the breeze.")
                .WithOppositeFlavorLine("-The Return of the King")
                .WithInfo(3, 1, Artist.Joshua_Cairos);
            addQuest("Searching the High Seas", EncounterSet.TheHuntForTheDreadnaught, 1, 'A', Card.VALUE_ASTERISK)
                .WithFlavorLine("The vicious Corsairs of Umbar have been pillaging the Gondorian coastline for months, and rumors are swirling that they've built the most devastating and gigantic ship ever known: The Dreadnaught. Many are suspicious of such extraordinary reports but, if true, the massive enemy is unlike any you've faced before. It will take an equally-colossal effort to take down such a potent foe. No others can bear such a difficult task, so it's up to the heroes to assemble a formidable fleet, and then scour the seas for the mighty warship.")
                .WithOppositeTextLine("*This stage has a global quest point value of 8 per player among all groups.")
                .WithOppositeTextLine("No more than 5 progress per player can be placed on this stage each round.")
                .WithOppositeTextLine("The players can only advance at the end of the quest phase.")
                .WithInfo(4, 1, Artist.David_Frasheski);
            addQuest("Destroy the Dreadnaught", EncounterSet.TheHuntForTheDreadnaught, 2, 'A', Card.VALUE_NA)
                .WithFlavorLine("In the distance, you see a ship like no other: dozens of ominous black sails tower above the churning sea and prow of a fearsome serpent's head slices through the waves at an alarming speed. The rumors are true. You are awestruck at the extraordinary size and imtimidating presence of the Dreadnaught. You resolve to sink the menacing behemoth at all costs.")
                .WithTextLine("When Revealed: Add the set-aside Dreadnaught enemy to the staging area, Elite side faceup.")
                .WithOppositeTextLine("No more than 5 progress per player can be placed on this stage each round.")
                .WithOppositeTextLine("Action: Remove 5 progress per player from this stage to choose any group to shuffle 1 set aside Gondorian Warship card into their encounter deck.")
                .WithOppositeTextLine("Response: When the Dreadnaught attacks you, raise your threat by 4 to cancel the attack.")
                .WithOppositeTextLine("When the Dreadnaught is destroyed, the players win the game.")
                .WithInfo(5, 1, Artist.Joshua_Cairos);

            addShipObjective("Eithiliant", EncounterSet.TheHuntForTheDreadnaught, true, 5, 3, 3, 13)
                .WithTraits("Grey Havens.", "Ship.", "Basic.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Each hero you control gets +1 Willpower.")
                .WithTextLine("Setup: Choose a hero you control. Until the end of the game, that hero gains the printed Traits of another hero you control.")
                .WithFlavor("The Eithiliant, or \"The Rainbow Spearpoint,\", is an extremely swift elvent schooner featuring a swan motif.")
                .WithSideA()
                .WithInfo(6, 1, Artist.Alexander_Chelyshev);
            addShipObjective("Eithiliant", EncounterSet.TheHuntForTheDreadnaught, true, 6, 4, 4, 15)
                .WithSlugSuffix("Upgraded")
                .WithTraits("Grey Havens.", "Ship.", "Upgraded.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Each hero you control gets +2 Willpower.")
                .WithTextLine("Response: After Eithiliant flips, shuffle up to 6 cards from your discard pile into your deck. Place 6 progress on a location in any group.")
                .WithSideB()
                .WithInfo(6, 1, Artist.Alexander_Chelyshev);

            addShipObjective("Golden Wing", EncounterSet.TheHuntForTheDreadnaught, true, 2, 5, 3, 15)
                .WithTraits("Grey Havens.", "Ship.", "Basic.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithTextLine("Immune to player card effects. Ranged. Sentinel.")
                .WithTextLine("Each hero you control gets +1 hit point.")
                .WithTextLine("Reduce your threat by 3. Choose a hero you control. Until the end of the game, that hero gains ranged.")
                .WithFlavorLine("The Golden Wing is equipped with a massive ballista.")
                .WithSideA()
                .WithInfo(7, 1, Artist.David_Frasheski);
            addShipObjective("Golden Wing", EncounterSet.TheHuntForTheDreadnaught, true, 3, 6, 4, 18)
                .WithSlugSuffix("Upgraded")
                .WithTraits("Grey Havens.", "Ship.", "Upgraded.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithTextLine("Immune to player card effects. Ranged. Sentinel.")
                .WithTextLine("Each hero you control gains +2 hit points and gains ranged.")
                .WithTextLine("Response: After Golden Wing flips, deal 6 damage to an enemy in any group.")
                .WithSideB()
                .WithInfo(7, 1, Artist.David_Frasheski);
            
            addShipObjective("Pride of Lebennin", EncounterSet.TheHuntForTheDreadnaught, true, 3, 2, 5, 16)
                .WithTraits("Gondor.", "Ship.", "Basic.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Each hero you control gets +1 Defense.")
                .WithTextLine("Forced: When you draw your starting hand, draw 5 additional cards, then shuffle 5 cards from your hand into your deck. You cannot take a mulligan.")
                .WithSideA()
                .WithInfo(8, 1, Artist.JB_Casacop);
            addShipObjective("Pride of Lebennin", EncounterSet.TheHuntForTheDreadnaught, true, 4, 3, 6, 19)
                .WithSlugSuffix("Upgraded")
                .WithTraits("Gondor.", "Ship.", "Upgraded.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Each hero you control gets +2 Defense.")
                .WithTextLine("Response: After Pride of Lebennin flips, heal 2 damage from a character. Choose up to 2 cards from the encounter discard pile and add them to the victory display.")
                .WithSideB()
                .WithInfo(8, 1, Artist.JB_Casacop);

            addShipObjective("Silent Mist", EncounterSet.TheHuntForTheDreadnaught, true, 4, 3, 4, 14)
                .WithTraits("Gondor.", "Ship.", "Basic.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Your starting hand size is 8 cards.")
                .WithTextLine("Action: Play an event from your hand with a cost 3 or more, reducing its cost by 1.")
                .WithFlavor("An exquisite work of elven craftsmanship, the number Silent Mist bear the symbol of the Star of Eärendil on its foresail.")
                .WithSideA()
                .WithInfo(9, 1, Artist.Alexander_Chelyshev);
            addShipObjective("Silent Mist", EncounterSet.TheHuntForTheDreadnaught, true, 5, 4, 5, 17)
                .WithSlugSuffix("Upgraded")
                .WithTraits("Gondor.", "Ship.", "Upgraded.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Response: After Silent Mist flips, choose up to 2 events from your discard pile and/or your collection and add them to your hand (following deckbuilding rules).")
                .WithTextLine("Action: Play an event from your hand with cost 3 or more, reducing its cost by 2.")
                .WithSideB()
                .WithInfo(9, 1, Artist.Alexander_Chelyshev);

            addShipObjective("Swan Ship of Dol Amroth", EncounterSet.TheHuntForTheDreadnaught, true, 3, 4, 3, 17)
                .WithTraits("Gondor.", "Ship.", "Basic.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Setup: Add 1 resource to each of your heroes' resource pools.")
                .WithTextLine("Action: Spend 2 resources to ready a character. (Limit once per round.)")
                .WithFlavorLine("The wealth of Gondor financed the construction of impressive ships which inspired all who sailed them.")
                .WithSideA()
                .WithInfo(10, 1, Artist.Carlos_Palma_Cruchaga);
            addShipObjective("Swan Ship of Dol Amroth", EncounterSet.TheHuntForTheDreadnaught, true, 4, 5, 4, 20)
                .WithSlugSuffix("Upgraded")
                .WithTraits("Gondor.", "Ship.", "Upgraded.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Response: After Swan Ship of Dol Amroth flips, add 2 resources to a hero's resource pool. Ready a card.")
                .WithTextLine("Action: Spend 1 resource to ready a card. (Limit once per round.)")
                .WithSideB()
                .WithInfo(10, 1, Artist.Carlos_Palma_Cruchaga);

            addShipObjective("Twilight's Call", EncounterSet.TheHuntForTheDreadnaught, true, 3, 4, 4, 18)
                .WithTraits("Grey Havens.", "Ship.", "Basic.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("The first card you play each round does not require a resource match.")
                .WithTextLine("Action: Play an ally or attachment from your hand. (Limit once per round.)")
                .WithFlavorLine("Exceptionally agile for its size. Twilight's Call is adept at launching surprise attacks as daylight fades.")
                .WithSideA()
                .WithInfo(11, 1, Artist.Carlos_Palma_Cruchaga);
            addShipObjective("Twilight's Call", EncounterSet.TheHuntForTheDreadnaught, true, 4, 5, 5, 22)
                .WithSlugSuffix("Upgraded")
                .WithTraits("Grey Havens.", "Ship.", "Upgraded.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Each card you play does not require a resource match.")
                .WithTextLine("Response: After Twilight's Call flips, draw 3 cards.")
                .WithTextLine("Action: Play an ally or attachment from your hand.")
                .WithSideB()
                .WithInfo(11, 1, Artist.Carlos_Palma_Cruchaga);

            addShipObjective("Gondorian Warship", EncounterSet.TheHuntForTheDreadnaught, false, 3, 5, 4, 10)
                .WithTraits("Gondor.", "Ship.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithTextLine("Immune to player card effects. Ranged. Sentinel.")
                .WithTextLine("When Revealed: Choose a player. That player gains control of Gondorian Warship.")
                .WithTextLine("Forced: When Gondorian Warship is destroyed, set it aside, out of play.")
                .WithShadow("Shadow: Deal 5 damage to attacking enemy.")
                .WithInfo(12, 4, Artist.Hyungyung_Bae);
            addShipEnemy("Dreadnaught", EncounterSet.TheHuntForTheDreadnaught, 0, 4, 7, 4, Card.VALUE_ASTERISK)
                .WithUnique()
                .WithTraits("Elite.", "Corsair.", "Ship.")
                .WithKeywords("Archery 1 Per Player.")
                .WithTextLine("Archery 1 Per Player. Immune to player card effects. Cannot take more than 5 damage per player each round.")
                .WithTextLine("*The Dreadnaught has global hit point value (15 hit points for each player among all groups).")
                .WithTextLine("Forced: At the end of the round if the Dreadnaught has less than half of its starting hit pints, flip it over.")
                .WithFlavor("Able to fight numerous ships at once with its ramming prow and bllistae, the Dreadnaught's potency is truly unparalleled.")
                .WithSideA()
                .WithInfo(13, 1, Artist.Joshua_Cairos);
            addShipEnemy("Dreadnaught", EncounterSet.TheHuntForTheDreadnaught, 0, 3, 5, 3, Card.VALUE_ASTERISK)
                .WithSlugSuffix("Damaged")
                .WithUnique()
                .WithTraits("Corsair.", "Ship.", "Damaged.")
                .WithKeywords("Massive.")
                .WithTextLine("Massive. Immune to player card effects. Cannot take more than 5 damage per player each round.")
                .WithTextLine("*The Dreadnaught has a global hit point value of 15 per player among all groups.")
                .WithTextLine("Forced: After the Dreadnaught flips, each player puts 1 set-aside unique Corsair enemy into play at random engaged with them.")
                .WithFlavorLine("With the Dreadnaught weakened and in peril, its enraged crew begins boarding your ship in a final attempt to sieze victory.")
                .WithVictoryPoints(99)
                .WithSideB()
                .WithInfo(13, 1, Artist.Hyungyung_Bae);
            addEnemy("Captain of the Haven", EncounterSet.TheHuntForTheDreadnaught, 31, 3, 8, 5, 7)
                .WithUnique()
                .WithTraits("Corsair.", "Pillager.", "Elite.")
                .WithKeywords("Pillage 8.")
                .WithTextLine("Immune to player card effects. Pillage 8.")
                .WithTextLine("Engaged player cannot attack the Dreadnaught.")
                .WithTextLine("Forced: At the end of the combat phase, if engaged player has no cards in their deck, that player is eliminated from the game.")
                .WithVictoryPoints(10)
                .WithInfo(14, 1, Artist.Borja_Pindado);
            addEnemy("Commander of the Dreadnaught", EncounterSet.TheHuntForTheDreadnaught, 39, 5, 5, 2, 9)
                .WithUnique()
                .WithTraits("Corsair.", "Elite.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Engaged player cannot attack the Dreadnaught.")
                .WithTextLine("Forced: After Commander of the Dreadnaught attacks you, the Dreadnaught attacks you.")
                .WithFlavorLine("If the Dreadnaught is fated to go under, its commander will surely try to take his foes down with it.")
                .WithVictoryPoints(10)
                .WithInfo(15, 1, Artist.Borja_Pindado);
            addEnemy("Descendant of Castamir", EncounterSet.TheHuntForTheDreadnaught, 42, 1, 3, 2, 5)
                .WithUnique()
                .WithTraits("Corsair.", "Elite.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Engaged player cannot attack the Dreadnaught.")
                .WithTextLine("Forced: After Descendant of Castamir engages you, put the top 2 cards of the Corsair deck into play engaged with you and deal each of them 1 shadow card.")
                .WithVictoryPoints(10)
                .WithInfo(16, 1, Artist.Tony_Foti);
            addEnemy("Hydraken", EncounterSet.TheHuntForTheDreadnaught, 41, 4, 4, 4, 6)
                .WithUnique()
                .WithTraits("Corsair.", "Elite.")
                .WithTextLine("Immune to player cards effects.")
                .WithTextLine("Engaged player cannot attack the Dreadnaught.")
                .WithTextLine("Forced: After Hydraken attacks, he makes an additional attack. Deal him 2 additional shadow cards for this attack and engaged player raises their threat by 4. (Limit once per round.)")
                .WithVictoryPoints(10)
                .WithInfo(17, 1, Artist.Martin_de_Diego_Sadaba);
            addEnemy("Ophidian", EncounterSet.TheHuntForTheDreadnaught, 34, 2, 6, 1, 8)
                .WithUnique()
                .WithTraits("Corsair.", "Elite.")
                .WithTextLine("Immune to player card effects. No more than 1 character can attack Ophidian each round.")
                .WithTextLine("Engaged player cannot attack the Dreadnaught.")
                .WithTextLine("Forced: When a character defends against Ophidian, deal 2 damage to that character.")
                .WithVictoryPoints(10)
                .WithInfo(18, 1, Artist.Tony_Foti);
            addEnemy("Varjax", EncounterSet.TheHuntForTheDreadnaught, 35, 6, 7, 3, 6)
                .WithUnique()
                .WithTraits("Corsair.", "Elite.")
                .WithKeywords("Archery 3.")
                .WithTextLine("Archery 3. Immune to player card effects.")
                .WithTextLine("Engaged player cannot attack the Dreadnaught.")
                .WithTextLine("For each point of excess combat damage dealt by Varjax, defending player deals 1 damage to a Ship they control.")
                .WithVictoryPoints(10)
                .WithInfo(19, 1, Artist.Martin_de_Diego_Sadaba);
            addEnemy("Brash Corsair", EncounterSet.TheHuntForTheDreadnaught, 16, 3, 3, 4, 3)
                .WithTraits("Corsair.")
                .WithTextLine("Forced: When engaged player exhausts a Ship objective, Brash Corsair attacks that player.")
                .WithFlavorLine("'The Corsair of Umbar!' men shouted. 'The Corsairs of Umbar! Look! The Corsairs of Umbar are coming!'")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(20, 1, Artist.Suzanne_Helmigh);
            addEnemy("Corsair Plunderer", EncounterSet.TheHuntForTheDreadnaught, 12, 1, 2, 3, 1)
                .WithTraits("Corsair.", "Pillager.")
                .WithKeywords("Pillage 2.")
                .WithTextLine("Pillage 2. (After this enemy attacks you, discard the top 2 cards of your deck.)")
                .WithTextLine("Forced: After an event card is discarded from your deck by Corsair Plunderer's Pillage keyword, discard an attachment you control.")
                .WithInfo(21, 3, Artist.Lin_Hsiang);
            addEnemy("Daring Buccaneer", EncounterSet.TheHuntForTheDreadnaught, 23, 3, 3, 2, 2)
                .WithTraits("Corsair.", "Pillager.")
                .WithKeywords("Pillage 3.")
                .WithTextLine("Pillage 3. (After this enemy attacks you, discard the top 3 cards of your deck.)")
                .WithTextLine("Forced: After an event card is discarded from your deck by Daring Buccaneer's Pillage keyword, deal 1 damage to a character you control.")
                .WithTemplate("<p class='main-text'>Pillage 3. <i>(After this enemy attacks you, discard the top 3 cards of your deck.)</i></p><p class='main-text'><b>Forced:</b> After an event card is discarded from your deck by Daring Buccaneer's Pillage keyword, deal 1 damage to a character you control.</p>")
                .WithInfo(22, 3, Artist.Lin_Hsiang);
            addEnemy("Fierce Marauder", EncounterSet.TheHuntForTheDreadnaught, 19, 2, 3, 2, 3)
                .WithTraits("Corsair.", "Pillager.")
                .WithKeywords("Pillage 3.")
                .WithTextLine("Pillage 3. (After this enemy attacks you, discard the top 3 cards of your deck.)")
                .WithTextLine("Forced: After an event card is discarded from your deck by Fierce Marauder's Pillage keyword, discard 1 resource from the resource pool of a hero you control.")
                .WithInfo(23, 3, Artist.Lin_Hsiang);
            addEnemy("Southron Sailor", EncounterSet.TheHuntForTheDreadnaught, 28, 0, 2, 1, 4)
                .WithTraits("Corsair.")
                .WithTextLine("While Southron Sailor is engaged with you, each Ship enemy engaged with you contributes its Threat to the total Threat in the staging area.")
                .WithFlavorLine("\"There is a great fleet drawing near to the mouths of the Anduin, manned by the corsairs of Umbar in the South.\"")
                .WithFlavorLine("-Beregond, The Return of the King")
                .WithInfo(24, 2, Artist.Leanna_Teneycke);
            addEnemy("Umbar Captain", EncounterSet.TheHuntForTheDreadnaught, 40, 4, 5, 3, 5)
                .WithTraits("Corsair.")
                .WithTextLine("Engaged player cannot attack Ship enemies.")
                .WithFlavorLine("...the strength of the rebels in Umbar was a great peril to Gondor...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(25, 1, Artist.David_Kegg);
            addShipEnemy("Black Sails", EncounterSet.TheHuntForTheDreadnaught, 37, 4, 6, 2, 10)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithTextLine("Boarding 2. Cannot have attachments.")
                .WithTextLine("While Black Sails is in the staging area, it gains Archery 3.")
                .WithShadow("Shadow: If attacking enemy is a Ship, return it to the staging area after this attack.")
                .WithInfo(26, 2, Artist.Imad_Awan);
            addShipEnemy("Corsair Skiff", EncounterSet.TheHuntForTheDreadnaught, 24, 1, 2, 2, 5)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge. Cannot have attachments.")
                .WithTextLine("Forced: When Corsair Skiff engages you from the staging area, eithe raise your threat by 3 or it gains Bording 1.")
                .WithInfo(27, 2, Artist.Michael_Rasmussen);
            addShipEnemy("Corsair Skirmisher", EncounterSet.TheHuntForTheDreadnaught, 28, 3, 4, 4, 6)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithTextLine("Boarding 1. Immune to player card effects.")
                .WithTextLine("Response: After ~Corsair Skirmisher is destroyed as an enemy, the engaged player may discard allies they control with a total of at least 3 Willpower to take control of Corsair Skirmisher as a ship-objective with Willpower equal to its Threat. (It loses the ship-enemy card type and gaines the ship-objective card type).")
                .WithInfo(28, 1, Artist.Mariusz_Gandzel);
            addShipEnemy("Corsair Warship", EncounterSet.TheHuntForTheDreadnaught, 44, 3, 8, 4, 9)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 3.")
                .WithTextLine("Boarding 3. Cannot have attachments.")
                .WithTextLine("While Corsair Warship is in the staging area, it cannot be damaged and gains Archery 4.")
                .WithFlavorLine("...ships of great draught with many oars, and with black sails bellying in the breeze.")
                .WithFlavorLine("-The Return of the King")
                .WithVictoryPoints(6)
                .WithInfo(29, 1, Artist.Michael_Rasmussen);
            addShipEnemy("Ramming Ship", EncounterSet.TheHuntForTheDreadnaught, 28, 4, 4, 3, 8)
                .WithTraits("Corsair.", "Ship.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: After Ramming ~Ship engages you, it gets +4 Attack until the end of the round.")
                .WithShadow("Shadow: Put the top card of the Corsair deck into play engaged with you and deal it 1 shadow card.")
                .WithInfo(30, 1, Artist.Igor_Artyomenko);
            addShipEnemy("Slave Ship", EncounterSet.TheHuntForTheDreadnaught, 32, 3, 7, 5, 5)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithTextLine("Boarding 1. Cannot have attachments.")
                .WithTextLine("For each point of damage that is dealt to a Ship objective by Slave Ship's attack, deal 1 point of damage to a non-Ship character controlled by the defending player, as well.")
                .WithInfo(31, 1, Artist.Lukasz_Jaskolski);
            addShipEnemy("War Galley", EncounterSet.TheHuntForTheDreadnaught, 33, 3, 5, 2, 7)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Archery 2.", "Boarding 1.")
                .WithTextLine("Archery 2. Boarding 1. Cannot have attachments.")
                .WithTextLine("Forced: When War Galley engages you from the staging area, either raise your threat by 4 or it gains Boarding 1.")
                .WithInfo(32, 3, Artist.Alexander_Chelyshev);
            addShipEnemy("Sea Monster", EncounterSet.TheHuntForTheDreadnaught, 26, 2, 4, 0, 11)
                .WithTraits("Creature.")
                .WithTextLine("Ship objectives may attack and defend against Sea Monster.")
                .WithTextLine("When Revealed: Deal 4 damage to the Ship enemy or Ship objective with the fewest remaining hit points.")
                .WithInfo(33, 2, Artist.Logan_Feliciano);
            addLocation("Belfalas Shipyard", EncounterSet.TheHuntForTheDreadnaught, 4, 6)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("Response: After Belfalas Shipyard is explored as the active location, the players as a group spend 5 resources to heal 5 damage from a Ship objective in any group. Ready that Ship and flip it to its Upgraded side.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack and gains Pillage 3.")
                .WithInfo(34, 2, Artist.Hai_Hoang);
            addLocation("Cobas Haven", EncounterSet.TheHuntForTheDreadnaught, 2, 4)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("While Cobas Haven is the active location, reduce the Boading value on each Ship enemy by 1.")
                .WithFlavorLine("But beyond, in the great fief of Belfalas, dwelt Prince Imrahil in his castle of Dol Amroth by the sea.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(35, 1, Artist.Simon_Dominic);
            addLocation("Isle of Fortune", EncounterSet.TheHuntForTheDreadnaught, 3, 5)
                .WithTraits("Ocean.")
                .WithTextLine("Isle of Fortune enters play with 1 resource per player on it.")
                .WithTextLine("Forced: After a Ship enemy enters play, discard 1 resource from Isle of Fortune.")
                .WithTextLine("Response: When Isle of Fortune is explored as the active location, move each resource on it to a hero's resource pool.")
                .WithInfo(36, 3, Artist.David_Frasheski);
            addLocation("Mouths of Anduin", EncounterSet.TheHuntForTheDreadnaught, 2, 5)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("While Mouths of Anduin is in the staging area, is gains: \"Forced: After a 'when revealed' effect is canceled, reveal the top card of the encounter deck.\"")
                .WithShadow("Shadow: If this attack is undefended, reveal the top card of the encounter deck.")
                .WithInfo(37, 3, Artist.Logan_Feliciano);
            addLocation("Tolfalas Landing", EncounterSet.TheHuntForTheDreadnaught, 2, 5)
                .WithTraits("Ocean.")
                .WithTextLine("While Tofalas Landing is in the staging area, it gains: \"Forced: After a player draws any number of cards from a player card effect, that player raises their threat by that number.\"")
                .WithShadow("Shadow: Raise your threat by 1 (3 instead if you have 5 or more cards in hand).")
                .WithInfo(38, 3, Artist.Logan_Feliciano);
            addLocation("Wicked Cove", EncounterSet.TheHuntForTheDreadnaught, 2, 4)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("Each location in the staging area is immune to player card effects.")
                .WithShadow("Shadow: Until the end of the round, attacking enemy is immune to player card effects and gets +2 Defense.")
                .WithInfo(39, 3, Artist.Darek_Zabrocki);
            addTreachery("Ballista Barrage", EncounterSet.TheHuntForTheDreadnaught)
                .WithTraits("Attack.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1. (Raise each players threat by 1.)")
                .WithTextLine("When Revealed: Until the end of the round, each Ship enemy gains Archery 2.")
                .WithShadow("Shadow: Assign 2 damage among characters you control (3 damage instead if there are 10 or more cards in your discard pile).")
                .WithInfo(40, 3, Artist.Lin_Hsiang);
            addTreachery("Boarding Party", EncounterSet.TheHuntForTheDreadnaught)
                .WithTextLine("When Revealed: Each player puts the top card of the Corsair deck into play engaged with them.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if you control an exhausted Ship objective).")
                .WithInfo(41, 1, Artist.Darek_Zabrocki);
            addTreachery("Grappled!", EncounterSet.TheHuntForTheDreadnaught)
                .WithTextLine("When Revealed: Attach to a Ship objective. (Counts as a Condition attachment with the text: \"Attached objective cannot ready. Action: Exhaust 3 characters to discard Grappled!\")")
                .WithShadow("Shadow: If defending character is a Ship attach Grappled! to it.")
                .WithInfo(42, 1, Artist.Federico_Musetti);
            addTreachery("Out of the Mist", EncounterSet.TheHuntForTheDreadnaught)
                .WithTraits("Attack.")
                .WithTextLine("When Revealed: The enemy with the highest engagement cost engages the first player and attacks them. If no attack is made this way, Out of the Mist gains surge.")
                .WithShadow("Shadow: Either raise your threat by 4 or attacking enemy makes an additional attack.")
                .WithInfo(43, 3, Artist.Imad_Awan);
            addTreachery("Overworked", EncounterSet.TheHuntForTheDreadnaught)
                .WithTraits("Hazard.")
                .WithTextLine("When Revealed: Until the end of the round, treat the text box of each non-Ship ally as blank, except for Traits. If a player controls 7 or more allies, Overworked gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if you control 7 or more allies).")
                .WithInfo(44, 2, Artist.JB_Casacop);
            addTreachery("Taking on Water", EncounterSet.TheHuntForTheDreadnaught)
                .WithTextLine("When Revealed: Attach to a Ship objective. (Counts as a Condition attachment with the text: \"Forced: When attached objective exhausts, deal 2 damage to it. Action: Exhaust 3 characters to discard Taking on Water.\")")
                .WithShadow("Shadow: If defending character is a Ship, attach Taking on Water to it.")
                .WithInfo(45, 2, Artist.Ignacio_Bazan_Lazcano);
            addTreachery("Violent Tempest", EncounterSet.TheHuntForTheDreadnaught)
                .WithTraits("Weather.")
                .WithTextLine("When Revealed: Deal 1 damage to each enemy. Each player assigns X among characters they control. X is the number of exhausted characters they control.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(46, 3, Artist.Carlos_Palma_Cruchaga);
            addContract("A Perilous Voyage")
                .WithTextLine("Your minimum deck size is 100 cards.")
                .WithTextLine("Your threat cannot be reduced by player card effects.")
                .WithTextLine("Action: Exhaust this card and raise your threat by 1 to look at the top 2 cards of your deck, draw 1, and place the other on the bottom of your deck.")
                .WithTextLine("Forced: When you would be eliminated by reaching your threat elimination level, flip this card over instead.")
                .WithOppositeTextLine("Your threat cannot be reduced by non-contract player card effects.")
                .WithOppositeTextLine("Heroes you control do not exhaust to quest.")
                .WithOppositeTextLine("Forced: When this card is flipped to this side, reduce your threat by 10. ~Search your deck for a card and either add it to your hand or play it, reducing its cost by 3. Shuffle your deck.")
                .WithOppositeFlavorLine("Thus came Aragorn... borne upon a wind from the Sea to the kingdom of Gondor...")
                .WithOppositeFlavorLine("-The Return of the King")
                .WithInfo(47, 1, Artist.Imad_Awan);
        }
    }
}