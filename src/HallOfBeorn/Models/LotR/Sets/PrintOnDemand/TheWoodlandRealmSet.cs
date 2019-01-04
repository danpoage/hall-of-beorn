using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class TheWoodlandRealmSet : CardSet
    {
        private const string setName = "The Woodland Realm";
        private string emptySetName = string.Empty;

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TWR";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "GenCon";
            Number = 3010;

            addHero("Éowyn", 9, Sphere.Spirit, 4, 1, 1, 3)
                .WithTraits("Noble.", "Rohan.")
                .WithText("Action: Discard 1 card from your hand to give Éowyn +1 Willpower until the end of the phase. This effect may be triggered by each player once each round.")
                .WithInfo(7, 1, Artist.Audrey_Hotte);

            addQuest("Captured by Spiders", setName, 1, 'A', 10)
                .WithFlavor("You are traveling through Mirkwood forest in search of The Elvenking's hidden halls, when you hear a desperate cry for help from a dark path of woods.")
                .WithText("Setup: Add Spider Den to the staging area. The opposing team searches the encounter deck for one different 0 cost enemy or 0 cost location per player and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("The cries are those of an Elf who has been captured within a spider den. You must rescue him!")
                .WithOppositeText("Forced: When Spider Den is explored, flip it over and put Mendor into play under the first player's control, ready.\r\nThis stage cannot be defeated unless the first player controls Mendor.")
                .WithInfo(1, 1, Artist.Ben_Zweifel);
            addQuest("A Chosen Path", setName, 2, 'A', 20)
                .WithOppositeTitle("Lost in the Dark")
                .WithFlavor("The Elf you rescued is Mendor, a servant of the Elvenking. He offers to guide you to the hidden kingdom, yet even Mendor struggles to keep his way as night settles over Mirkwood.")
                .WithText("When Revealed: The opposing teach searches the top 5 cards of the encounter deck for a card with cost 1 or less (2 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeText("The first treachery revealed each round gains Doomed 1 and its 'when revealed' effects cannot be canceled.\r\nForced: After characters are committed to the quest, no more than 5 progress can be placed here this round (10 progress instead if Mendor is committed to the quest).")
                .WithBackArtist(Artist.Adam_Lane)
                .WithInfo(3, 1, Artist.Yoann_Boissonnet);
            addQuest("A Chosen Path", setName, 2, 'A', 20)
                .WithOppositeTitle("\"Don't Leave the Path\"")
                .WithFlavor("The Elf you rescued is Mendor, a servant of the Elvenking. He offers to guide you to the hidden kingdom, yet even Mendor struggles to keep his way as night settles over Mirkwood.")
                .WithText("When Revealed: The opposing teach searches the top 5 cards of the encounter deck for a card with cost 1 or less (2 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeText("Progress cannot be placed on locations in the staging area.\r\nDuring the travel phase, the players must travel to a location, if able.\r\nForced: After characters are committed to the quest, no more than 5 progress can be placed here this round (10 progress instead if Mendor is committed to the quest).")
                .WithBackArtist(Artist.Ben_Zweifel)
                .WithInfo(4, 1, Artist.Yoann_Boissonnet);
            addQuest("A Chosen Path", setName, 2, 'A', 20)
                .WithOppositeTitle("Ambushed at Night")
                .WithFlavor("The Elf you rescued is Mendor, a servant of the Elvenking. He offers to guide you to the hidden kingdom, yet even Mendor struggles to keep his way as night settles over Mirkwood.")
                .WithText("When Revealed: The opposing teach searches the top 5 cards of the encounter deck for a card with cost 1 or less (2 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeText("Each enemy in the staging area gets -10 engagement cost, cannot be optionally engaged and cannot take damage.\r\nForced: After characters are committed to the quest, no more than 5 progress can be placed here this round (10 progress instead if Mendor is committed to the quest).")
                .WithBackArtist(Artist.Nikolas_Hagialas)
                .WithInfo(5, 1, Artist.Yoann_Boissonnet);
            addQuest("On the Trail", setName, 3, 'A', 15)
                .WithOppositeTitle("The Forest of Great Fear")
                .WithFlavor("Dawn comes and and pale streaks of light penetrate the dark forest, giving Mendor the light he needs to navigate. The Elf leads you with renewed confidence, but danger still lies between you and the safety of Thranduil's halls.")
                .WithText("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (3 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeText("When Revealed: The opposing team searches the encounter deck and discard pile for an enemy, adds it to the staging area, the places a resource on an enemy in play with cost 2 or higher. While this stage is in play, the enemy with a resource gets +2 Attack, +2 Defense, and is immune to player card effects.\r\nThis stage cannot be defeated while the enemy witha resource is in play. When this stage is defeated, the players win the game.")
                .WithBackArtist(Artist.Martin_de_Diego_Sadaba)
                .WithInfo(7, 1, Artist.Carolina_Eade);
            addQuest("On the Trail", setName, 3, 'A', Card.VALUE_X)
                .WithOppositeTitle("To the Elvenking's Halls")
                .WithFlavor("Dawn comes and and pale streaks of light penetrate the dark forest, giving Mendor the light he needs to navigate. The Elf leads you with renewed confidence, but danger still lies between you and the safety of Thranduil's halls.")
                .WithText("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (3 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeText("X is equal to the threat level of the player with the highest threat level.\r\nEach player's threat cannot be reduced by more than 1 each round.\r\nForced: After the players quest successfully, if 10 or more progress was placed here this phase, reveal the top card of the encounter deck.\r\nIf the players defeat this stage, they win the game.")
                .WithBackArtist(Artist.Timo_Karhula)
                .WithInfo(8, 1, Artist.Carolina_Eade);
            addQuest("On the Trail", setName, 3, 'A', 20)
                .WithOppositeTitle("Escape from Taur-nu-Fuin")
                .WithFlavor("Dawn comes and and pale streaks of light penetrate the dark forest, giving Mendor the light he needs to navigate. The Elf leads you with renewed confidence, but danger still lies between you and the safety of Thranduil's halls.")
                .WithText("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (3 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeText("Forced: At the beginning of the quest phase, discard cards from the top of the encounter deck until a location is discarded. Add that location to the staging area.\r\nIf the players defeat this stage, they win the game.")
                .WithBackArtist(Artist.Katy_Grierson)
                .WithInfo(9, 1, Artist.Carolina_Eade);
            addLocation("Spider Den", setName, 1, 1)
                .WithUnique()
                .WithTraits("Forest.")
                .WithText("Immune to player card effects.\r\nTravel: The opposing team searches the encounter deck and discard pile for a 0 cost enemy and adds it to the staging area, if able (1 cost or less if there are two or more players). Shuffle the encounter deck.")
                .WithInfo(10, 1, Artist.Jokubas_Uoginitas);
            addObjectiveAlly("Mendor", setName, 2, 2, 2, 5)
                .WithUnique()
                .WithTraits("Silvan.", "Scout.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithText("The first player gains control of Mendor.\r\nIf Mendor leaves play, the players lose the game.")
                .WithInfo(11, 1, Artist.Cris_Griffin);

            addEnemy("Ungoliant's Spawn", emptySetName, 38, 3, 6, 3, 8)
                .WithSetNumberAndCost(1, 3)
                .WithUnique()
                .WithTraits("Spider.")
                .WithText("Cannot have non-objective player card attachments or take non-combat damage.\r\nWhile Ungoliant's Spawn is in the staging area, characters cannot be readied by player card effects.")
                .WithInfo(12, 1, Artist.Andrew_Olson);
            addLocation("Forest Grove", emptySetName, Card.VALUE_X, Card.VALUE_X)
                .WithSetNumberAndCost(1, 0)
                .WithTraits("Forest.")
                .WithText("X is 1 more than the stage number of the main quest.\r\nTravel: Each player deals X damage to a character he controls.")
                .WithInfo(13, 2, Artist.Anna_Mohrbacher);
            addTreachery("Despair", emptySetName)
                .WithSetNumberAndCost(1, 0)
                .WithText("When Revealed: Until the end of the round, treat each character's printed text box as if it were blank (except for Traits).")
                .WithShadow("Shadow: Treat the defending character's text box as if it were blank until the end of the phase (except for Traits).")
                .WithInfo(14, 2, Artist.Marc_Scheff);
            addEnemy("Chieftain Ufthak", emptySetName, 36, 3, 6, 3, 6)
                .WithSetNumberAndCost(2, 3)
                .WithUnique()
                .WithTraits("Orc.")
                .WithText("Cannot have non-objective player card attachments or take non-combat damage.\r\nForced: After Chieftain Ufthak engages you, the opposing team searches the encounter deck and discard pile for an Orc enemy of cost 1 or less and puts it into play engaged with you. Shuffle the encounter deck.")
                .WithInfo(15, 1, Artist.Mathias_Kollros);
            addLocation("Abandoned Camp", emptySetName, 2, 2)
                .WithSetNumberAndCost(2, 0)
                .WithTraits("Forest.")
                .WithText("Forced: When Abandoned Camp leaves play as an explored location, the opposing team chooses a card in the encounter discard pile and shuffles it into the encounter deck.")
                .WithInfo(16, 2, Artist.Dana_Li);
            addTreachery("Gathering Gloom", emptySetName)
                .WithSetNumberAndCost(2, 0)
                .WithText("When Revealed: Each player raises his threat by X, where X is 1 more than the stage number of the main quest.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if your threat is 35 or higher)")
                .WithInfo(17, 2, Artist.Borja_Pindado);
            addEnemy("Black Forest Bats", emptySetName, 13, 1, 2, 1, 3)
                .WithSetNumberAndCost(3, 0)
                .WithTraits("Creature.")
                .WithText("When Revealed: The opposing team chooses a questing character. Remove that character from the quest.")
                .WithShadow("Shadow: Shuffle Black Forest Bats into the encounter deck.")
                .WithInfo(18, 2, Artist.Aurelien_Hubert);
            addLocation("Enchanted Steam", emptySetName, 2, 6)
                .WithSetNumberAndCost(3, 3)
                .WithText("While Enchanted Steam is in the staging area, progress cannot be placed on the main quest.\r\nTravel: Each player exhausts a hero he controls. Those heroes cannot ready while Enchanted Stream is the active location.")
                .WithInfo(19, 1, Artist.Ben_Zweifel);
            addTreachery("Exhaustion", emptySetName)
                .WithSetNumberAndCost(3, 0)
                .WithText("When Revealed: Each player exhausts a character he controls. Until the end of the round, characters cannot be readied by player card effects.")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithInfo(20, 2, Artist.Marco_Caradonna);
            addEnemy("Spiders of Mirkwood", emptySetName, 22, 2, 2, 1, 2)
                .WithSetNumberAndCost(4, 0)
                .WithTraits("Spider.")
                .WithText("Forced: After Spiders of Mirkwood engages you, exhaust a character you control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it has the Spider trait).")
                .WithInfo(21, 3, Artist.Andrew_Ryan);
            addLocation("The Spiders' Ring", emptySetName, 4, 4)
                .WithSetNumberAndCost(4, 2)
                .WithUnique()
                .WithTraits("Forest.")
                .WithText("While The Spiders' Ring is in the staging area, each Spider enemy gets +1 Threat.\r\nForced: When The Spiders' Ring is explored, the opposing team searches the encounter deck and discard pile for a non-unique Spider enemy and adds it to the staging area.")
                .WithInfo(22, 1, Artist.Andrew_Johanson);
            addTreachery("Caught in a Web", emptySetName)
                .WithSetNumberAndCost(4, 1)
                .WithText("When Revealed: The opposing team attaches Caught in a Web to a hero and exhausts that hero. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Attached hero cannot ready unless its controller first spends 2 resource from its pool.\")")
                .WithInfo(23, 1, Artist.Daryl_Mandryk);
            addEnemy("Wolf Rider", emptySetName, 23, 2, 2, 2, 2)
                .WithSetNumberAndCost(5, 0)
                .WithTraits("Orc.")
                .WithText("When Revealed: If there is another Orc enemy in the staging area, Wolf Rider gains surge.")
                .WithShadow("Shadow: If attacking enemy is an Orc, put Wolf Rider into play engaged with you.")
                .WithInfo(24, 3, Artist.Alexandru_Sabo);
            addLocation("The Goblins' Cave", emptySetName, 3, 5)
                .WithSetNumberAndCost(5, 2)
                .WithUnique()
                .WithTraits("Mountain.", "Cave.")
                .WithText("While The Goblins' Cave is in the staging area, each Orc enemy gets +1 Attack.\r\nForced: When The Goblin's Cave is explored, the opposing team searches the encounter deck and discard pile for a non-unique Orc enemy and adds it to the staging area.")
                .WithInfo(25, 1, Artist.David_Demaret);
            addTreachery("Driven by Shadow", emptySetName)
                .WithSetNumberAndCost(5, 1)
                .WithText("When Revealed: The opposing team attaches Driven by Shadow to an enemy and returns it to the staging area. (Counts as a Condition attachment with the text: \"Limit 1 per enemy. Attached enemy gets +2 Threat, +2 Attack, +2 Defense and is immune to player card effects.\") If there is no enemy in play, Driven by Shadow gains surge.")
                .WithInfo(26, 1, Artist.Alexandru_Sabo);
        }
    }
}