using System;

namespace HallOfBeorn.Models.LotR.Sets.CustomScenarioKit
{
    public class TheWoodlandRealmSet : CardSet
    {
        private const string setName = "The Woodland Realm";
        private string emptySetName = string.Empty;

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TWR";
            SetType = Models.SetType.Custom_Scenario_Kit;
            Cycle = "Custom Scenario Kit";
            Number = 3010;

            addHero("Éowyn", 9, Sphere.Spirit, 4, 1, 1, 3)
                .WithTraits("Noble.", "Rohan.")
                .WithTextLine("Action: Discard 1 card from your hand to give Éowyn +1 Willpower until the end of the phase. This effect may be triggered by each player once each round.")
                .WithPromotion()
                .WithInfo(0, 1, Artist.Audrey_Hotte);

            addQuest("Captured by Spiders", setName, 1, 'A', 10)
                .WithFlavorLine("You are traveling through Mirkwood forest in search of The Elvenking's hidden halls, when you hear a desperate cry for help from a dark path of woods.")
                .WithTextLine("Setup: Add Spider Den to the staging area. The opposing team searches the encounter deck for one different 0 cost enemy or 0 cost location per player and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("The cries are those of an Elf who has been captured within a spider den. You must rescue him!")
                .WithOppositeTextLine("Forced: When Spider Den is explored, flip it over and put Mendor into play under the first player's control, ready.")
                .WithOppositeTextLine("This stage cannot be defeated unless the first player controls Mendor.")
                .WithInfo(1, 1, Artist.Ben_Zweifel);
            addQuest("A Chosen Path", setName, 2, 'A', 20)
                .WithOppositeTitle("Lost in the Dark")
                .WithFlavorLine("The Elf you rescued is Mendor, a servant of the Elvenking. He offers to guide you to the hidden kingdom, yet even Mendor struggles to keep his way as night settles over Mirkwood.")
                .WithTextLine("When Revealed: The opposing teach searches the top 5 cards of the encounter deck for a card with cost 1 or less (2 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("The first treachery revealed each round gains Doomed 1 and its 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("Forced: After characters are committed to the quest, no more than 5 progress can be placed here this round (10 progress instead if Mendor is committed to the quest).")
                .WithBackArtist(Artist.Adam_Lane)
                .WithInfo(3, 1, Artist.Yoann_Boissonnet);
            addQuest("A Chosen Path", setName, 2, 'A', 20)
                .WithOppositeTitle("\"Don't Leave the Path\"")
                .WithFlavorLine("The Elf you rescued is Mendor, a servant of the Elvenking. He offers to guide you to the hidden kingdom, yet even Mendor struggles to keep his way as night settles over Mirkwood.")
                .WithTextLine("When Revealed: The opposing teach searches the top 5 cards of the encounter deck for a card with cost 1 or less (2 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("Progress cannot be placed on locations in the staging area.")
                .WithOppositeTextLine("During the travel phase, the players must travel to a location, if able.")
                .WithOppositeTextLine("Forced: After characters are committed to the quest, no more than 5 progress can be placed here this round (10 progress instead if Mendor is committed to the quest).")
                .WithBackArtist(Artist.Ben_Zweifel)
                .WithInfo(4, 1, Artist.Yoann_Boissonnet);
            addQuest("A Chosen Path", setName, 2, 'A', 20)
                .WithOppositeTitle("Ambushed at Night")
                .WithFlavorLine("The Elf you rescued is Mendor, a servant of the Elvenking. He offers to guide you to the hidden kingdom, yet even Mendor struggles to keep his way as night settles over Mirkwood.")
                .WithTextLine("When Revealed: The opposing teach searches the top 5 cards of the encounter deck for a card with cost 1 or less (2 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("Each enemy in the staging area gets -10 engagement cost, cannot be optionally engaged and cannot take damage.")
                .WithOppositeTextLine("Forced: After characters are committed to the quest, no more than 5 progress can be placed here this round (10 progress instead if Mendor is committed to the quest).")
                .WithBackArtist(Artist.Nikolas_Hagialas)
                .WithInfo(5, 1, Artist.Yoann_Boissonnet);
            addQuest("On the Trail", setName, 3, 'A', 15)
                .WithOppositeTitle("The Forest of Great Fear")
                .WithFlavorLine("Dawn comes and and pale streaks of light penetrate the dark forest, giving Mendor the light he needs to navigate. The Elf leads you with renewed confidence, but danger still lies between you and the safety of Thranduil's halls.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (3 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("When Revealed: The opposing team searches the encounter deck and discard pile for an enemy, adds it to the staging area, the places a resource on an enemy in play with cost 2 or higher. While this stage is in play, the enemy with a resource gets +2 Attack, +2 Defense, and is immune to player card effects.")
                .WithOppositeTextLine("This stage cannot be defeated while the enemy witha resource is in play. When this stage is defeated, the players win the game.")
                .WithBackArtist(Artist.Martin_de_Diego_Sadaba)
                .WithInfo(7, 1, Artist.Carolina_Eade);
            addQuest("On the Trail", setName, 3, 'A', Card.VALUE_X)
                .WithOppositeTitle("To the Elvenking's Halls")
                .WithFlavorLine("Dawn comes and and pale streaks of light penetrate the dark forest, giving Mendor the light he needs to navigate. The Elf leads you with renewed confidence, but danger still lies between you and the safety of Thranduil's halls.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (3 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("X is equal to the threat level of the player with the highest threat level.")
                .WithOppositeTextLine("Each player's threat cannot be reduced by more than 1 each round.")
                .WithOppositeTextLine("Forced: After the players quest successfully, if 10 or more progress was placed here this phase, reveal the top card of the encounter deck.")
                .WithOppositeTextLine("If the players defeat this stage, they win the game.")
                .WithBackArtist(Artist.Timo_Karhula)
                .WithInfo(8, 1, Artist.Carolina_Eade);
            addQuest("On the Trail", setName, 3, 'A', 20)
                .WithOppositeTitle("Escape from Taur-nu-Fuin")
                .WithFlavorLine("Dawn comes and and pale streaks of light penetrate the dark forest, giving Mendor the light he needs to navigate. The Elf leads you with renewed confidence, but danger still lies between you and the safety of Thranduil's halls.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (3 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, discard cards from the top of the encounter deck until a location is discarded. Add that location to the staging area.")
                .WithOppositeTextLine("If the players defeat this stage, they win the game.")
                .WithBackArtist(Artist.Katy_Grierson)
                .WithInfo(9, 1, Artist.Carolina_Eade);
            addLocation("Spider Den", setName, 1, 1)
                .WithUnique()
                .WithTraits("Forest.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Travel: The opposing team searches the encounter deck and discard pile for a 0 cost enemy and adds it to the staging area, if able (1 cost or less if there are two or more players). Shuffle the encounter deck.")
                .WithInfo(10, 1, Artist.Jokubas_Uoginitas);
            addObjectiveAlly("Mendor", setName, 2, 2, 2, 5)
                .WithUnique()
                .WithTraits("Silvan.", "Scout.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithTextLine("Ranged. Sentinel.")
                .WithTextLine("The first player gains control of Mendor.")
                .WithTextLine("If Mendor leaves play, the players lose the game.")
                .WithSideB()
                .WithInfo(11, 1, Artist.Cris_Griffin);

            addEnemy("Ungoliant's Spawn", emptySetName, 38, 3, 6, 3, 8)
                .WithSetNumberAndCost(1, 3)
                .WithUnique()
                .WithTraits("Spider.")
                .WithTextLine("Cannot have non-objective player card attachments or take non-combat damage.")
                .WithTextLine("While Ungoliant's Spawn is in the staging area, characters cannot be readied by player card effects.")
                .WithInfo(12, 1, Artist.Andrew_Olson);
            addLocation("Forest Grove", emptySetName, Card.VALUE_X, Card.VALUE_X)
                .WithSetNumberAndCost(1, 0)
                .WithTraits("Forest.")
                .WithTextLine("X is 1 more than the stage number of the main quest.")
                .WithTextLine("Travel: Each player deals X damage to a character he controls.")
                .WithInfo(13, 2, Artist.Anna_Mohrbacher);
            addTreachery("Despair", emptySetName)
                .WithSetNumberAndCost(1, 0)
                .WithTextLine("When Revealed: Until the end of the round, treat each character's printed text box as if it were blank (except for Traits).")
                .WithShadow("Shadow: Treat the defending character's text box as if it were blank until the end of the phase (except for Traits).")
                .WithInfo(14, 2, Artist.Marc_Scheff);
            addEnemy("Chieftain Ufthak", emptySetName, 36, 3, 6, 3, 6)
                .WithSetNumberAndCost(2, 3)
                .WithUnique()
                .WithTraits("Orc.")
                .WithTextLine("Cannot have non-objective player card attachments or take non-combat damage.")
                .WithTextLine("Forced: After Chieftain Ufthak engages you, the opposing team searches the encounter deck and discard pile for an Orc enemy of cost 1 or less and puts it into play engaged with you. Shuffle the encounter deck.")
                .WithInfo(15, 1, Artist.Mathias_Kollros);
            addLocation("Abandoned Camp", emptySetName, 2, 2)
                .WithSetNumberAndCost(2, 0)
                .WithTraits("Forest.")
                .WithTextLine("Forced: When Abandoned Camp leaves play as an explored location, the opposing team chooses a card in the encounter discard pile and shuffles it into the encounter deck.")
                .WithInfo(16, 2, Artist.Dana_Li);
            addTreachery("Gathering Gloom", emptySetName)
                .WithSetNumberAndCost(2, 0)
                .WithTextLine("When Revealed: Each player raises his threat by X, where X is 1 more than the stage number of the main quest.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if your threat is 35 or higher)")
                .WithInfo(17, 2, Artist.Borja_Pindado);
            addEnemy("Black Forest Bats", emptySetName, 13, 1, 2, 1, 3)
                .WithSetNumberAndCost(3, 0)
                .WithTraits("Creature.")
                .WithTextLine("When Revealed: The opposing team chooses a questing character. Remove that character from the quest.")
                .WithShadow("Shadow: Shuffle Black Forest Bats into the encounter deck.")
                .WithInfo(18, 2, Artist.Aurelien_Hubert);
            addLocation("Enchanted Stream", emptySetName, 2, 6)
                .WithUnique()
                .WithTraits("Forest.", "River.")
                .WithSetNumberAndCost(3, 3)
                .WithTextLine("While Enchanted ~Stream is in the staging area, progress cannot be placed on the main quest.")
                .WithTextLine("Travel: Each player exhausts a hero he controls. Those heroes cannot ready while Enchanted ~Stream is the active location.")
                .WithInfo(19, 1, Artist.Ben_Zweifel);
            addTreachery("Exhaustion", emptySetName)
                .WithSetNumberAndCost(3, 0)
                .WithTextLine("When Revealed: Each player exhausts a character he controls. Until the end of the round, characters cannot be readied by player card effects.")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithInfo(20, 2, Artist.Marco_Caradonna);
            addEnemy("Spiders of Mirkwood", emptySetName, 22, 2, 2, 1, 2)
                .WithSetNumberAndCost(4, 0)
                .WithTraits("Spider.")
                .WithTextLine("Forced: After Spiders of Mirkwood engages you, exhaust a character you control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it has the Spider trait).")
                .WithInfo(21, 3, Artist.Andrew_Ryan);
            addLocation("The Spiders' Ring", emptySetName, 4, 4)
                .WithSetNumberAndCost(4, 2)
                .WithUnique()
                .WithTraits("Forest.")
                .WithTextLine("While The Spiders' Ring is in the staging area, each Spider enemy gets +1 Threat.")
                .WithTextLine("Forced: When The Spiders' Ring is explored, the opposing team searches the encounter deck and discard pile for a non-unique Spider enemy and adds it to the staging area.")
                .WithInfo(22, 1, Artist.Andrew_Johanson);
            addTreachery("Caught in a Web", emptySetName)
                .WithSetNumberAndCost(4, 1)
                .WithTextLine("When Revealed: The opposing team attaches Caught in a Web to a hero and exhausts that hero. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Attached hero cannot ready unless its controller first spends 2 resource from its pool.\")")
                .WithInfo(23, 1, Artist.Daryl_Mandryk);
            addEnemy("Wolf Rider", emptySetName, 23, 2, 2, 2, 2)
                .WithSetNumberAndCost(5, 0)
                .WithTraits("Orc.")
                .WithTextLine("When Revealed: If there is another Orc enemy in the staging area, Wolf Rider gains surge.")
                .WithShadow("Shadow: If attacking enemy is an Orc, put Wolf Rider into play engaged with you.")
                .WithInfo(24, 3, Artist.Alexandru_Sabo);
            addLocation("The Goblins' Caves", emptySetName, 3, 5)
                .WithSetNumberAndCost(5, 2)
                .WithUnique()
                .WithTraits("Mountain.", "Cave.")
                .WithTextLine("While The Goblins' Caves is in the staging area, each Orc enemy gets +1 Attack.")
                .WithTextLine("Forced: When The Goblin's Caves is explored, the opposing team searches the encounter deck and discard pile for a non-unique Orc enemy and adds it to the staging area.")
                .WithInfo(25, 1, Artist.David_Demaret);
            addTreachery("Driven by Shadow", emptySetName)
                .WithSetNumberAndCost(5, 1)
                .WithTextLine("When Revealed: The opposing team attaches Driven by Shadow to an enemy and returns it to the staging area. (Counts as a Condition attachment with the text: \"Limit 1 per enemy. Attached enemy gets +2 Threat, +2 Attack, +2 Defense and is immune to player card effects.\") If there is no enemy in play, Driven by Shadow gains surge.")
                .WithInfo(26, 1, Artist.Alexandru_Sabo);
            addEnemy("Beast of Taur-nu-Fuin", emptySetName, 28, 3, 3, 1, 8)
                .WithSetNumberAndCost(6, 2)
                .WithTraits("Creature.")
                .WithTextLine("Beast of Taur-nu-Fuin gets +1 Attack for each damage on it.")
                .WithTextLine("Forced: When Beast of Taur-nu-Fuin is dealt a shadow card with no shadow effect, deal 1 damage to it and the defending character.")
                .WithInfo(27, 1, Artist.Guillaume_Ducos);
            addLocation("Dark Black Woods", emptySetName, 1, 4)
                .WithSetNumberAndCost(6, 0)
                .WithTraits("Forest.")
                .WithTextLine("Dark Black Woods gets +1 Threat for each Dark Black Woods in the staging area.")
                .WithTextLine("Travel: Each player must discard 1 card from his hand for each Dark Black Woods in the staging area.")
                .WithInfo(28, 3, Artist.Leanna_Crossan);
            addTreachery("Wind-whipped Rain", emptySetName)
                .WithSetNumberAndCost(6, 1)
                .WithTraits("Weather.")
                .WithTextLine("When Revealed: Each player must choose: either choose 1 card from his hand and discard the rest, or assign X damage among characters he controls, where X is the number of cards in his hand.")
                .WithShadow("Shadow: Discard 1 random card from your hand.")
                .WithInfo(29, 1, Artist.Blake_Henriksen);
            addEnemy("Giant Spider", emptySetName, 30, 3, 3, 2, 5)
                .WithSetNumberAndCost(7, 1)
                .WithTraits("Spider.")
                .WithTextLine("When Revealed: Each player exhausts a character he controls.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(30, 2, Artist.Rafal_Hrynkiewicz);
            addLocation("Giant Web", emptySetName, 2, 4)
                .WithSetNumberAndCost(7, 0)
                .WithTraits("Forest.")
                .WithTextLine("When Revealed: Make Giant Web the active location. Return any previous location to the staging area.")
                .WithInfo(31, 2, Artist.Trudi_Castle);
            addTreachery("Eyes of the Forest", emptySetName)
                .WithSetNumberAndCost(7, 1)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: The opposing team looks at each player's hand and discards 1 card from each.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the stage number of the current quest.")
                .WithInfo(32, 1, Artist.Yoann_Boissonnet);
            addEnemy("Mirkwood Patrol", emptySetName, 34, 3, 4, 3, 5)
                .WithSetNumberAndCost(8, 1)
                .WithTraits("Orc.")
                .WithTextLine("While Mirkwood Patrol is in the staging area, enemies cannot be optionally engaged.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it was engaged this round).")
                .WithInfo(33, 2, Artist.Matt_Stewart);
            addLocation("Mountains of Mirkwood", emptySetName, 2, 4)
                .WithSetNumberAndCost(8, 0)
                .WithTraits("Mountain.")
                .WithTextLine("While Mountains of ~Mirkwood is in the staging area, it gains: \"Forced: At the end of the round, raise each player's threat by 2.\"")
                .WithShadow("Shadow: Either raise your threat by 2, or the attacking enemy gets +2 Attack.")
                .WithInfo(34, 2, Artist.Ben_Zweifel);
            addTreachery("Hatred Rekindled", emptySetName)
                .WithSetNumberAndCost(8, 1)
                .WithTextLine("When Revealed: Each engaged enemy makes an immediate attack. If no attacks were made this way, Hatred Rekindled gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. Deal it an additional shadow card. That card's shadow effects cannot be canceled.")
                .WithInfo(35, 1, Artist.Adam_Lane);
            addEnemy("Wild Bear", emptySetName, 33, Card.VALUE_X, 4, Card.VALUE_X, 5)
                .WithSetNumberAndCost(9, 1)
                .WithTraits("Creature.")
                .WithTextLine("X is 1 more than the stage number of the main quest.")
                .WithShadow("Shadow: Attacking enemy gets +X Defense until the end of the phase, where X is the stage number of the main quest.")
                .WithInfo(36, 2, Artist.Salvador_Trakal);
            addLocation("Labyrinthine Woods", emptySetName, 2, 3)
                .WithSetNumberAndCost(9, 0)
                .WithTraits("Forest.")
                .WithTextLine("When Revealed: Until the end of the phase, each location in the staging area gets +1 Threat.")
                .WithShadow("Shadow: Each enemy engaged with you gets +1 Attack until the end of the phase.")
                .WithInfo(37, 2, Artist.Trudi_Castle);
            addTreachery("Vastness of Mirkwood", emptySetName)
                .WithSetNumberAndCost(9, 1)
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost equal to or less than the stage number of the main quest, sets it aside and shuffles the encounter deck. Then, reveal the set aside card.")
                .WithShadow("Shadow: If this attack destroys a character, reveal the top card of the encounter deck.")
                .WithInfo(38, 1, Artist.Katy_Grierson);
            addEnemy("Mirkwood Flock", emptySetName, 12, 1, 2, 1, 2)
                .WithTraits("Creature.")
                .WithSetNumberAndCost(10, 1)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithShadow("Shadow: Add Mirkwood Flock to the staging area.")
                .WithInfo(39, 2, Artist.Brandon_Leach);
            addLocation("The Eaves of Mirkwood", emptySetName, 2, 4)
                .WithSetNumberAndCost(10, 0)
                .WithTraits("Forest.")
                .WithTextLine("While The Eaves of Mirkwood is in the staging area, no more than 1 progress can be placed on each location in the staging area each round.")
                .WithTextLine("Travel: Each player discards 1 random card from his hand.")
                .WithInfo(40, 2, Artist.Timo_Karhula);
            addTreachery("Massing at Night", emptySetName)
                .WithSetNumberAndCost(10, 1)
                .WithTextLine("When Revealed: The opposing team searches the encounter deck and discard pile for one different 0 cost enemy per player (limit 2) and adds them to the staging area.")
                .WithShadow("Shadow: If this attack destroys a character, attacking enemy makes an additional attack against you after this one.")
                .WithInfo(41, 1, Artist.Mathias_Kollros);
            addEnemy("Wild Wargs", emptySetName, 25, 2, 3, 1, 3)
                .WithSetNumberAndCost(11, 1)
                .WithTraits("Warg.")
                .WithTextLine("Forced: After Wild Wargs is dealt a shadow card with no shadow effect, return it to the staging area.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after this attack.")
                .WithInfo(42, 2, Artist.Piya_Wannachaiwong);
            addLocation("Dry Watercourse", emptySetName, 2, 4)
                .WithSetNumberAndCost(11, 0)
                .WithTraits("Forest.")
                .WithTextLine("While Dry Watercourse in in the staging area, each player cannot reduce his threat by more than 1 each round.")
                .WithTextLine("Travel: Raise each player's threat by 1.")
                .WithInfo(43, 2, Artist.Bill_Corbett);
            addTreachery("Turned Around", emptySetName)
                .WithSetNumberAndCost(11, 1)
                .WithTextLine("When Revealed: Remove 5 progress tokens from the main quest and attach Turned Around to it. (Counts as a Condition attachment with the text: \"Attached quest gets +5 quest points.\")")
                .WithInfo(44, 1, Artist.Darek_Zabrocki);
            addEnemy("Pack of Wargs", emptySetName, 36, 3, 4, 2, 6)
                .WithTraits("Warg.")
                .WithSetNumberAndCost(12, 1)
                .WithTextLine("Cannot have non-objective player card attachments or take non-combat damage.")
                .WithTextLine("Forced: After Pack of Wargs is dealt a shadow card with no shadow effect, it makes an additional attack after this one. Do not deal it a shadow card for this attack.")
                .WithInfo(45, 1, Artist.Lukasz_Jaskolski);
            addLocation("Dark-wood Grove", emptySetName, 3, 4)
                .WithSetNumberAndCost(12, 1)
                .WithTraits("Forest.")
                .WithTextLine("While Dark-wood Grove is in the staging area, it gains: \"Forced: After a 'when revealed' effect is canceled, raise each player's threat by 3.\"")
                .WithTextLine("Travel: Reveal the top card of the encounter deck.")
                .WithInfo(46, 2, Artist.Trudi_Castle);
            addTreachery("Lost and Witless", emptySetName)
                .WithSetNumberAndCost(12, 0)
                .WithTextLine("When Revealed: Each player reveals his hand and discards each ally card revealed this way.")
                .WithShadow("Shadow: If this attack is undefended, discard an ally you control.")
                .WithInfo(47, 2, Artist.Romana_Kendelic);
            addEnemy("Wicked Spider", emptySetName, 34, 2, 4, 2, 4)
                .WithSetNumberAndCost(13, 1)
                .WithTraits("Spider.")
                .WithTextLine("Forced: After Wicked Spider engages you, discard an exhausted character you control.")
                .WithShadow("Shadow: Attacking enemy cannot take damage this phase.")
                .WithInfo(48, 1, Artist.Aurelien_Hubert);
            addLocation("Old Forest Road", emptySetName, 4, 4)
                .WithTraits("Forest.")
                .WithSetNumberAndCost(13, 1)
                .WithTextLine("Response: After the players travel to Old Forest Road, the first player discards the top card of his deck. If that card is an ally, he puts it into play.")
                .WithTextLine("Travel: Discard the top card of the encounter deck, if that card is an enemy, add it to the staging area.")
                .WithInfo(49, 2, Artist.Ben_Zweifel);
            addTreachery("A Frightened Beast", emptySetName)
                .WithSetNumberAndCost(13, 0)
                .WithTextLine("When Revealed: Each player must choose: either raise your threat by 1 for each questing character you control, or discard a questing character you control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, raise each player's threat by 1.")
                .WithInfo(50, 2, Artist.David_A_Nash);
            addEnemy("Ambushing Orcs", emptySetName, 30, 2, 3, 1, 4)
                .WithSetNumberAndCost(14, 1)
                .WithTraits("Orc.")
                .WithTextLine("When Revealed: Ambushing Orcs makes an immediate attack against the first player.")
                .WithShadow("Shadow: Engaged the lowest engagement cost enemy in the staging area and deal it a shadow card.")
                .WithInfo(51, 1, Artist.Darek_Zabrocki);
            addLocation("Mirkwood Path", emptySetName, 3, 1)
                .WithSetNumberAndCost(14, 0)
                .WithTraits("Forest.")
                .WithTextLine("Forced: When Mirkwood Path is explored, discard the top card of the encounter deck. If that card is a location, add it to the staging area.")
                .WithInfo(52, 2, Artist.Trudi_Castle);
            addTreachery("Wasted Provisions", emptySetName)
                .WithSetNumberAndCost(14, 1)
                .WithTextLine("When Revealed: Each player discards each resource from each of his heroes' resource pools and raises his threat by 1 for each resource he discarded this way. If no resources were discarded this way, Wasted Provisions gains surge.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithInfo(53, 2, Artist.David_A_Nash);
        }
    }
}