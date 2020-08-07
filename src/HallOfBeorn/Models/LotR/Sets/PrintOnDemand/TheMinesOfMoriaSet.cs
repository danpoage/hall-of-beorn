﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class TheMinesOfMoriaSet
        : CardSet
    {
        public const string setName = "The Mines of Moria";
        private const string emptySetName = "";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TMoM";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "GenCon";
            Number = 3011;

            addQuest("To the West-door", EncounterSet.TheMinesOfMoria, 1, 'A', 5)
                .WithFlavor("It has been years since there was news of Balin's expedition to Moria, but in recent months there have been rumors of growing darkness there. You traveled to the Mines to investigate these tidings. Upon reaching the Doors of Durin, you are surprised to find a foul-smelling pool at its feet, and a fell creature blocking your way.")
                .WithTextLine("Setup: Each player adds 1 resource to each of his heroes' resource pools. Add The Watcher to the staging area.")
                .WithOppositeTextLine("While this stage has at least 5 progress on it, The Watcher is considered to be engaged with each player and attacks each player in turn order during the combat phase. (Deal and resolve a shadow card for each attack.)")
                .WithOppositeTextLine("Forced: When The Watcher is defeated, flip it over and add Chamber of Mazarbul to the staging area.")
                .WithOppositeTextLine("This stage cannot be defeated while The Watcher is in play.")
                .WithInfo(1, 1, Artist.Ben_Zweifel);
            addQuest("Journey in the Black Pit", EncounterSet.TheMinesOfMoria, 2, 'A', 20)
                .WithOppositeTitle("A Presence in the Dark")
                .WithFlavor("Once inside the mine it becomes obvious that the rumors were true: evil things move through the darkness all around you. With the way behind you blocked by that horrible creature, your only option is to press forward.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 1 or less (2 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("Forced: At the beginning of the staging step, the opposing team looks at the top 2 cards of the encounter deck, puts 1 on the bottom, and puts the other back on top.")
                .WithBackArtist(Artist.Igor_Kieryluk)
                .WithInfo(3, 1, Artist.David_A_Nash);
            addQuest("Journey in the Black Pit", EncounterSet.TheMinesOfMoria, 2, 'A', 20)
                .WithOppositeTitle("The Long Dark of Moria")
                .WithFlavor("Once inside the mine it becomes obvious that the rumors were true: evil things move through the darkness all around you. With the way behind you blocked by that horrible creature, your only option is to press forward.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 1 or less (2 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("When Revealed: The opposing team searches the encounter deck and discard pile for one different 0 cost location per player and adds them to the staging area. Shuffle the encounter deck.")
                .WithBackArtist(Artist.Juan_Carlos_Barquet)
                .WithInfo(4, 1, Artist.David_A_Nash);
            addQuest("Journey in the Black Pit", EncounterSet.TheMinesOfMoria, 2, 'A', 20)
                .WithOppositeTitle("Narrow Paths")
                .WithFlavor("Once inside the mine it becomes obvious that the rumors were true: evil things move through the darkness all around you. With the way behind you blocked by that horrible creature, your only option is to press forward.")
                .WithTextLine("When Revealed: The opposing team chooses an attachment controlled by each player and places them faceup under this stage as guarded objectives with blank text boxes. Players cannot play or put into play any attachment that shares a title with an attachment guarded by this stage. When this stage is defeated, return each guarded attachment to its owner's hand.")
                .WithOppositeTextLine("When Revealed: The opposing team searches the encounter deck and discard pile for one different 0 cost location per player and adds them to the staging area. Shuffle the encounter deck.")
                .WithBackArtist(Artist.Ilich_Henriquez)
                .WithInfo(5, 1, Artist.David_A_Nash);
            addQuest("Search for the Chamber", EncounterSet.TheMinesOfMoria, 3, 'A', 10)
                .WithOppositeTitle("Drums in the Deep")
                .WithFlavor("Your journey through Moria has been marked by all manner of terrible hazards, but you've discovered no sign of Balin's company. You hope that you might find some record of the Dwarven colony in the Chamber of Mazarbul.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (cost 3 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("Enemies cannot take damage while Chamber of Mazarbul is in the staging area.")
                .WithOppositeTextLine("When Revealed: The opposing team searches the encounter deck and discard pile for an enemy and adds it to the staging area.")
                .WithOppositeTextLine("This stage cannot be defeated while an enemy is in play. When this stage is defeated, the players win the game.")
                .WithBackArtist(Artist.Nate_Abell)
                .WithInfo(7, 1, Artist.Cristi_Balanescu);
            addQuest("Search for the Chamber", EncounterSet.TheMinesOfMoria, 3, 'A', 20)
                .WithOppositeTitle("The Fate of Balin")
                .WithFlavor("Your journey through Moria has been marked by all manner of terrible hazards, but you've discovered no sign of Balin's company. You hope that you might find some record of the Dwarven colony in the Chamber of Mazarbul.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (cost 3 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("Forced: At the beginning of the staging step, the first player must choose: either reveal an additional encounter card this phase, or no more than 5 progress can be placed here this phase.")
                .WithOppositeTextLine("This stage cannot be defeated while Chamber of Mazarbul is in play. When this stage is defeated, the players win the game.")
                .WithBackArtist(Artist.Ben_Zweifel)
                .WithInfo(8, 1, Artist.Cristi_Balanescu);
            addQuest("Search for the Chamber", EncounterSet.TheMinesOfMoria, 3, 'A', 15)
                .WithOppositeTitle("Continuing Eastward")
                .WithFlavor("Your journey through Moria has been marked by all manner of terrible hazards, but you've discovered no sign of Balin's company. You hope that you might find some record of the Dwarven colony in the Chamber of Mazarbul.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (cost 3 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("Each location in the staging area gets +1 Threat and +3 quest points.")
                .WithOppositeTextLine("Forced: When the active location is explored, reveal the top card of the encounter deck.")
                .WithOppositeTextLine("This stage cannot be defeated while Chamber of Mazarbul is in play. When this stage is defeated, the players win the game.")
                .WithBackArtist(Artist.David_A_Nash)
                .WithInfo(9, 1, Artist.Cristi_Balanescu);
            addEnemy("The Watcher", EncounterSet.TheMinesOfMoria, 50, 2, 4, 1, 4)
                .WithUnique()
                .WithTraits("Creature.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Cannot be optionally engaged.")
                .WithTextLine("The Watcher gets +2 Threat and +4 hit points per player.")
                .WithInfo(10, 1, Artist.Matthew_Starbuck);
            addLocation("Chamber of Mazarbul", EncounterSet.TheMinesOfMoria, Card.VALUE_X, 5)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("X is 1 more than the stage number of the main quest.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("The players cannot travel here unless they are at stage 3B.")
                .WithTextLine("Travel: Each player discards 1 random card from his hand.")
                .WithVictoryPoints(5)
                .WithInfo(11, 1, Artist.Emilio_Rodriguez);

            addEnemy("Savage Werewolf", emptySetName, 32, 3, 5, 2, 6)
                .WithSetNumberAndCost(1, 2)
                .WithTraits("Creature.", "Werewolf.")
                .WithTextLine("Forced: After Savage Werewolf is dealt a shadow card with no shadow effect, it makes an additional attack after this one. (Do not deal it a shadow card.)")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(12, 1, Artist.Stanislav_Dikolenko);
            addLocation("Many-pillared Hall", emptySetName, 1, 4)
                .WithSetNumberAndCost(1, 0)
                .WithTraits("Underground.")
                .WithTextLine("Many-pillared Hall gets +1 Threat for each copy of Many-pillared Hall in the staging area.")
                .WithShadow("Shadow: Discard an attachment from the defending character.")
                .WithInfo(13, 3, Artist.Jose_Vega);
            addTreachery("Shadow of Fear", emptySetName)
                .WithSetNumberAndCost(1, 1)
                .WithTextLine("When Revealed: The opposing team attached Shadow of Fear to a hero. (Counts as a Condition attachment with the text: \"Treat attached hero's text box as if it were blank, except for Traits.\")")
                .WithInfo(14, 1, Artist.Gabrielle_Portal);

            addEnemy("Deep-dweller", emptySetName, 23, 2, 3, 2, 3)
                .WithSetNumberAndCost(2, 0)
                .WithTraits("Spider.")
                .WithTextLine("When Revealed: Return each engaged Spider enemy to the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it is a Spider).")
                .WithInfo(15, 2, Artist.Guillaume_Ducos);
            addLocation("Darkened Stairway", emptySetName, 3, 4)
                .WithSetNumberAndCost(2, 1)
                .WithTraits("Underground.")
                .WithTextLine("While Darkened Stairway is in the staging area, it gains: \"Forced: After a 'when revealed' effect is canceled, reveal the top card of the encounter deck.\"")
                .WithTextLine("Travel: Discard the top card of the encounter deck. If that card is a treachery, resolve its 'when revealed' effect.")
                .WithInfo(16, 2, Artist.Nate_Abell);
            addTreachery("We Cannot Get Out", emptySetName)
                .WithSetNumberAndCost(2, 1)
                .WithTextLine("When Revealed: Until the end of the phase, add X Threat to the staging area, where X is the number of characters controlled by the player with the most characters.")
                .WithShadow("Shadow: Assign X damage among characters you control, where X is the number of enemies engaged with you.")
                .WithInfo(17, 1, Artist.Nate_Abell);

            addEnemy("Spider Broodling", emptySetName, 18, 2, 2, 1, 2)
                .WithSetNumberAndCost(3, 0)
                .WithTraits("Spider.")
                .WithTextLine("Forced: After Spider Broodling engages you, remove 2 progress from the main quest.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, remove 2 progress from the main quest.")
                .WithInfo(18, 3, Artist.Sergey_Glushakov);
            addLocation("Spider Burrow", emptySetName, 4, 4)
                .WithSetNumberAndCost(3, 2)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("While Spider Burrow is in the staging area, each Spider enemy gets +1 Defense.")
                .WithTextLine("Forced: When Spider Burrow is explored, the opposing team searches the encounter deck and discard pile for a Spider enemy with cost 1 or less and adds it to the staging area. Shuffle the encounter deck.")
                .WithInfo(19, 1, Artist.Jokubas_Uoginitas);
            addTreachery("Grabbed by Spiders", emptySetName)
                .WithSetNumberAndCost(3, 1)
                .WithTextLine("When Revealed: Remove X characters from the quest, where X is the number of Spider enemies in play. If there are no Spider enemies in play, Grabbed by Spiders gains surge.")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithInfo(20, 1, Artist.Rafal_Hrynkiewicz);

            addEnemy("Moria Bats", emptySetName, 13, 1, 3, 1, 3)
                .WithSetNumberAndCost(4, 1)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithShadow("Shadow: Shuffle Moria Bats into the enocunter deck.")
                .WithInfo(21, 2, Artist.Cristi_Balanescu);
            addLocation("Ancient Guardroom", emptySetName, 2, 5)
                .WithSetNumberAndCost(4, 1)
                .WithTraits("Underground.")
                .WithTextLine("Ancient Guardroom gets +1 Threat for each resource on it.")
                .WithTextLine("Forced: After an event is played, place 1 resource here.")
                .WithTextLine("Travel: Assign X damage among characters in play, where X is Ancient Guardroom's Threat.")
                .WithInfo(22, 1, Artist.Pedro_Amato);
            addTreachery("Denizen of the Deep", emptySetName)
                .WithSetNumberAndCost(4, 0)
                .WithTextLine("When Revealed: The opposing team attaches Denizen of the Deep to a non-unique enemy and returns it to the staging area. If there are no non-unique enemies in play, Denizens of the Deep gains surge. (Counts as Condition attachment with the text: \"Attached enemy gets +1 Threat, +1 Attack, +1 Defense and is immune to player card effects.)")
                .WithInfo(23, 2, Artist.Jon_Bosco);

            addEnemy("Werewolf", emptySetName, 40, 2, 4, 1, 4)
                .WithSetNumberAndCost(5, 0)
                .WithTraits("Creature.", "Werewolf.")
                .WithTextLine("Werewolf gets -10 engagement cost while there is an active location.")
                .WithInfo(24, 2, Artist.Jon_Bosco);
            addLocation("Fouled Well", emptySetName, 3, 4)
                .WithSetNumberAndCost(5, 1)
                .WithTraits("Underground.")
                .WithTextLine("While Fouled Well is in the staging area, characters cannot be readied by player card effects.")
                .WithTextLine("Travel: Each player exhausts a character.")
                .WithInfo(25, 1, Artist.David_Lecossu);
            addTreachery("Cave In", emptySetName)
                .WithSetNumberAndCost(5, 1)
                .WithTextLine("When Revealed: Return the active location to the staging area. Each player assigns X damage among characters he controls, where X is the Threat of that location. If no location is returned to the staging area this way, Cave In gains surge.")
                .WithShadow("Shadow: If this attack destroys a character, return the active location to the staging area.")
                .WithInfo(26, 2, Artist.Winona_Nelson);

            addEnemy("Hive Guardian", emptySetName, 30, 3, 5, 2, 6)
                .WithSetNumberAndCost(6, 2)
                .WithTraits("Spider.")
                .WithTextLine("Forced: After Hive Guardian attacks and destroys an ally, return Hive Guardian to the staging area.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after this attack.")
                .WithInfo(27, 1, Artist.Sandara_Tang);
            addLocation("Abandoned Mines", emptySetName, 2, 2)
                .WithSetNumberAndCost(6, 0)
                .WithTraits("Underground.")
                .WithTextLine("While Abandoned Mines is in the staging area, progress cannot be placed here.")
                .WithShadow("Shadow: If attacking enemy was engaged this round, it cannot take damage this phase.")
                .WithInfo(28, 3, Artist.Paulo_Puggioni);
            addTreachery("Sudden Pitfall", emptySetName)
                .WithSetNumberAndCost(6, 1)
                .WithTextLine("When Revealed: The opposing team chooses and discards an ally. If no ally was discarded this way, Sudden Pitfall gains surge.")
                .WithShadow("Shadow: Either discard an ally you control, or attacking enemy cannot take damage this phase.")
                .WithInfo(29, 1, Artist.Jake_Murray);

            addEnemy("Web-spinner", emptySetName, 24, 2, 4, 2, 4)
                .WithSetNumberAndCost(7, 1)
                .WithTraits("Spider.")
                .WithTextLine("When Revealed: Either no more than 4 progress can be placed on the current quest this phase, or Web-spinner gains surge.")
                .WithShadow("Shadow: If this attack destroys a character, return attacking enemy to the staging area.")
                .WithInfo(30, 2, Artist.Aurelien_Hubert);
            addLocation("Cobwebbed Cavern", emptySetName, 2, 4)
                .WithSetNumberAndCost(7, 0)
                .WithTraits("Underground.")
                .WithTextLine("Travel: Remove 2 progress from the main quest.")
                .WithShadow("Shadow: Remove 2 progress from the main quest.")
                .WithInfo(31, 2, Artist.Leanna_Crossan);
            addTreachery("Foul Air", emptySetName)
                .WithSetNumberAndCost(7, 1)
                .WithTextLine("When Revealed: The first player must choose: either deal 1 damage to each character committed to the quest, or raise each player's threat by 1 and end the quest phase without resolving the quest.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(32, 1, Artist.Jasper_Sandner);
        }
    }
}