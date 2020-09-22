using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class TheHuntForTheDreadnaughtSet
        : CardSet
    {
        public const string setName = "The Hunt for the Dreadnaught";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "THftD";
            SetType = Models.SetType.Scenario_Deck;
            Cycle = "Scenario Deck";
            Number = 4001;

            IsSpoiler = true;

            addShipObjective("Eithiliant", EncounterSet.TheHuntForTheDreadnaught, true, 5, 3, 3, 13)
                .WithTraits("Basic.", "Grey Havens.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Each hero you control gets +1 Willpower.")
                .WithTextLine("Setup: Choose a hero you control. Until the end of the game, that hero gains the printed Traits of another hero you control.")
                .WithFlavor("The Eithiliant, or \"The Rainbow Spearpoint,\", is an extremely swift elvent schooner featuring a swan motif.")
                .WithSideLetter()
                .WithInfo(6, 1, Artist.Alexander_Chelyshev);
            addShipObjective("Silent Mist", EncounterSet.TheHuntForTheDreadnaught, true, 4, 3, 4, 14)
                .WithTraits("Basic.", "Gondor.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Your starting hand size is 8 cards.")
                .WithTextLine("Action: Play an event from your hand with a cost 3 or more, reducing its cost by 1.")
                .WithFlavor("An exquisite work of elven craftsmanship, the number Silent Mist bear the symbol of the Star of Eärendil on its foresail.")
                .WithSideLetter()
                .WithInfo(7, 1, Artist.Alexander_Chelyshev);
            addShipObjective("Pride of Lebennin", EncounterSet.TheHuntForTheDreadnaught, true, 3, 2, 5, 16)
                .WithTraits("Basic.", "Gondor.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Each hero you control gets +1 Defense.")
                .WithTextLine("Forced: When you draw your starting hand, draw 5 additional cards, then shuffle 5 cards from your hand into your deck. You cannot take a mulligan.")
                .WithSideLetter()
                .WithInfo(8, 1, Artist.JB_Casacop);

            addShipEnemy("Dreadnaught", EncounterSet.TheHuntForTheDreadnaught, 0, 4, 7, 4, Card.VALUE_ASTERISK)
                .WithUnique()
                .WithTraits("Elite.", "Corsair.", "Ship.")
                .WithKeywords("Archery 1 Per Player.")
                .WithTextLine("Archery 1 Per Player. Immune to player card effects. Cannot take more than 5 damage per player each round.")
                .WithTextLine("*The Dreadnaught has global hit point value (15 hit points for each player among all groups).")
                .WithTextLine("Forced: At the end of the round if the Dreadnaught has less than half of its starting hit pints, flip it over.")
                .WithFlavor("Able to fight numerous ships at once with its ramming prow and bllistae, the Dreadnaught's potency is truly unparalleled.")
                .WithSideLetter()
                .WithInfo(13, 1, Artist.Joshua_Cairos);
 

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
                .WithTextLine("Forced: After Ramming ~Ship engaged you, it gets +4 Attack until the end of the round.")
                .WithShadow("Shadow: Put the top card of the Corsair deck into play engaged with you and deal it 1 shadow card.")
                .WithInfo(30, 2, Artist.Igor_Artyomenko);

            addLocation("Belfalas Shipyard", EncounterSet.TheHuntForTheDreadnaught, 4, 6)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("Response: After Belfalas Shipyard is explored as the active location, the players as a group spend 5 resources to heal 5 damage from a Ship objective in any group. Ready that Ship and flip it to its Upgraded side.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack and gains Pillage 3.")
                .WithInfo(34, 2, Artist.Unknown);
        }
    }
}