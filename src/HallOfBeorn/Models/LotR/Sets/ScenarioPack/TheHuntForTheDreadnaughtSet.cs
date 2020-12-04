using System;
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
                .WithTraits("Basic.", "Gondor.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Each hero you control gets +1 Defense.")
                .WithTextLine("Forced: When you draw your starting hand, draw 5 additional cards, then shuffle 5 cards from your hand into your deck. You cannot take a mulligan.")
                .WithSideA()
                .WithInfo(8, 1, Artist.JB_Casacop);
            addShipObjective("Silent Mist", EncounterSet.TheHuntForTheDreadnaught, true, 4, 3, 4, 14)
                .WithTraits("Basic.", "Gondor.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Your starting hand size is 8 cards.")
                .WithTextLine("Action: Play an event from your hand with a cost 3 or more, reducing its cost by 1.")
                .WithFlavor("An exquisite work of elven craftsmanship, the number Silent Mist bear the symbol of the Star of Eärendil on its foresail.")
                .WithSideA()
                .WithInfo(9, 1, Artist.Alexander_Chelyshev);

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

            addEnemy("Daring Buccaneer", EncounterSet.TheHuntForTheDreadnaught, 23, 3, 3, 2, 2)
                .WithTraits("Corsair.", "Pillager.")
                .WithKeywords("Pillage 3.")
                .WithTextLine("Pillage 3. (After this enemy attacks you, discard the top 3 cards of your deck.)")
                .WithTextLine("Forced: After an event card is discarded fro engaged player's deck by Daring Buccaneer's Pillage keyword, that player deals 1 damage to a character they control.")
                .WithTemplate("<p class='main-text'>Pillage 3. <i>(After this enemy attacks you, discard the top 3 cards of your deck.)</i></p><p class='main-text'><b>Forced:</b> After an event card is discarded fro engaged player's deck by Daring Buccaneer's Pillage keyword, that player deals 1 damage to a character they control.</p>")
                .WithInfo(22, 2, Artist.Unknown);

            addEnemy("Southron Sailor", EncounterSet.TheHuntForTheDreadnaught, 28, 0, 2, 1, 4)
                .WithTraits("Corsair.")
                .WithTextLine("While Southron Sailor is engaged with you, each Ship enemy engaged with you contributes its Threat to the total Threat in the staging area.")
                .WithFlavorLine("\"There is a great fleet drawing near to the mouths of the Anduin, manned by the corsairs of Umbar in the South.\"")
                .WithFlavorLine("-Beregond, The Return of the King")
                .WithInfo(24, 2, Artist.Leanna_Teneycke);

            addShipEnemy("Black Sails", EncounterSet.TheHuntForTheDreadnaught, 37, 4, 6, 2, 10)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithTextLine("Boarding 2. Cannot have attachments.")
                .WithTextLine("While Black Sails is in the staging area, it gains Archery 3.")
                .WithShadow("Shadow: If attacking enemy is a Ship, return it to the staging area after this attack.")
                .WithInfo(26, 2, Artist.Imad_Awan);

            addShipEnemy("Corsair Skirmisher", EncounterSet.TheHuntForTheDreadnaught, 28, 3, 4, 4, 6)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithTextLine("Boarding 1. Immune to player card effects.")
                .WithTextLine("Response: After ~Corsair Skirmisher is destroyed as an enemy, the engaged player may discard allies they control with a total of at least 3 Willpower to take control of Corsair Skirmisher as a ship-objective with Willpower equal to its Threat. (It loses the ship-enemy card type and gaines the ship-objective card type).")
                .WithInfo(28, 2, Artist.Mariusz_Gandzel);

            addShipEnemy("Ramming Ship", EncounterSet.TheHuntForTheDreadnaught, 28, 4, 4, 3, 8)
                .WithTraits("Corsair.", "Ship.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: After Ramming ~Ship engages you, it gets +4 Attack until the end of the round.")
                .WithShadow("Shadow: Put the top card of the Corsair deck into play engaged with you and deal it 1 shadow card.")
                .WithInfo(30, 2, Artist.Igor_Artyomenko);

            addLocation("Belfalas Shipyard", EncounterSet.TheHuntForTheDreadnaught, 4, 6)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("Response: After Belfalas Shipyard is explored as the active location, the players as a group spend 5 resources to heal 5 damage from a Ship objective in any group. Ready that Ship and flip it to its Upgraded side.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack and gains Pillage 3.")
                .WithInfo(34, 2, Artist.Unknown);

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