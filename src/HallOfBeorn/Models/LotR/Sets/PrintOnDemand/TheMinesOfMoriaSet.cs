using System;
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
        }
    }
}