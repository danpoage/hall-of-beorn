using System;

namespace HallOfBeorn.Models.LotR.Sets.CustomScenarioKit
{
    public class TheWizardsQuestSet : CardSet
    {
        private const string setName = "The Wizard's Quest";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TWQ";
            SetType = Models.SetType.Custom_Scenario_Kit;
            Cycle = "Custom Scenario Kit";
            Number = 3009;

            addQuest("Radagast's Request", setName, 1, 'A', 10)
                .WithFlavorLine("Concerned about the growing darkness in southern Mirkwood, Radagast sent an Eagle to spy on Dol Guldur. When the Eagle returned with an evil wound, the Wizard sent word to the White Council and asked for heroes to investigate.")
                .WithTextLine("Setup: Add Rhosgobel to the staging area. The opposing team searches the encounter deck for one different 0 cost enemy or 0 cost location per player and adds them to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("You are on your way to Rhosgobel in answer to Radagast's summons, but the deepening shadows of Mirkwood threaten to envelope you before you even reach the Wizard's sanctuary.")
                .WithOppositeTextLine("Forced: When Rhosgobel is explored, flip it over and add Rider of Mirkwood to the staging area.")
                .WithOppositeTextLine("This stage cannot be defeated while Rhosgobel is in play.")
                .WithInfo(1, 1, Artist.Unknown);
            
            addQuest("Mirkwood Forest", setName, 2, 'A', 5)
                .WithFlavorLine("Radagast asks that you travel to Dol Guldur to measure the Enemy's strength there. The Anduin vale is too closely watched, so you make your way through the perils of Mirkwood forest.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with 1 or less (cost 2 or less if there are two or more players), set it aside, and shufles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTitle("A Fork in the Road")
                .WithOppositeTextLine("When Revealed: The opposing team searches the encounter deck and discard pile for a location with cost 2 or less, adds it to the staging area, and places a resource on it. Shuffle the encounter deck.")
                .WithOppositeTextLine("The location with a resource on it is immune to player card effects and the players cannot travel to it while this stage has any quest points remaining. This stage cannot be defeated while the location with a resource on it is in play.")
                .WithBackArtist(Artist.Ben_Zweifel)
                .WithInfo(3, 1, Artist.Jeff_Lee_Johnson);
            addQuest("Mirkwood Forest", setName, 2, 'A', 20)
                .WithFlavorLine("Radagast asks that you travel to Dol Guldur to measure the Enemy's strength there. The Anduin vale is too closely watched, so you make your way through the perils of Mirkwood forest.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with 1 or less (cost 2 or less if there are two or more players), set it aside, and shufles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTitle("Carried Away")
                .WithOppositeTextLine("When Revealed: The opposing team chooses an ally controlled by each player and places them faceup under this stge as guarded objectives with blank text boxes.")
                .WithOppositeTextLine("Players cannot play or put into play any ally that shares a title with an ally guarded by this stage. When this stage is defeated, return each guarded ally to its owner's hand.")
                .WithBackArtist(Artist.Unknown)
                .WithInfo(4, 1, Artist.Jeff_Lee_Johnson);
            addQuest("Mirkwood Forest", setName, 2, 'A', 5)
                .WithFlavorLine("Radagast asks that you travel to Dol Guldur to measure the Enemy's strength there. The Anduin vale is too closely watched, so you make your way through the perils of Mirkwood forest.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with 1 or less (cost 2 or less if there are two or more players), set it aside, and shufles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTitle("A New Terror Abroad")
                .WithOppositeTextLine("This stage gets +5 quest points per player.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, Rider of Mirkwood makes an immediate attack against the first player.")
                .WithBackArtist(Artist.Unknown)
                .WithInfo(5, 1, Artist.Jeff_Lee_Johnson);
            
            addQuest("The Necromancer's Tower", setName, 3, 'A', 20)
                .WithFlavorLine("The dark form of Dol Guldur rises up ahead. The servants of the Enemy patrol the surrounding woods. You must take great care to gather what information you can and return with news to Rhosgobel before it's too late.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (3 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTitle("The Tower of Sorcery")
                .WithOppositeTextLine("Forced: After the players have committed characters to the quest, discard cards from the top of the encounter deck until a treachery is discarded. Reveal that treachery.")
                .WithOppositeTextLine("If the players defeat this stage, they win the game.")
                .WithBackArtist(Artist.Julian_Kok)
                .WithInfo(7, 1, Artist.Ben_Zweifel);
            addQuest("The Necromancer's Tower", setName, 3, 'A', 15)
                .WithFlavorLine("The dark form of Dol Guldur rises up ahead. The servants of the Enemy patrol the surrounding woods. You must take great care to gather what information you can and return with news to Rhosgobel before it's too late.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (3 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTitle("Dungeons of the Necromancer")
                .WithOppositeTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck. Each player discards from the top of the encounter deck until he discards an enemy, adds that enemy to the staging area, and attached a hero he controls to it as a guarded objective (discard all tokens from the chosen hero).")
                .WithOppositeTextLine("If there is an unguarded hero in the staging area, return it to its owner's control, exhausted. This stage cannot be defeated while there is a guarded objective in play. If the players defeat this stage, they win the game.")
                .WithBackArtist(Artist.Alvaro_Calvo_Escudero)
                .WithInfo(8, 1, Artist.Ben_Zweifel);
            addQuest("The Necromancer's Tower", setName, 3, 'A', 10)
                .WithFlavorLine("The dark form of Dol Guldur rises up ahead. The servants of the Enemy patrol the surrounding woods. You must take great care to gather what information you can and return with news to Rhosgobel before it's too late.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 2 or less (3 or less if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithOppositeTitle("Return to Rhosgobel")
                .WithTextLine("Rider of Mirkwood's engagement cost is considered to be 0.")
                .WithTextLine("The number of damage tokens on Rider of Mirkwood cannot exceed the number of progress tokens on this stage.")
                .WithTextLine("Players cannot defeat this stage while Rider of Mirkwood is in play. If the players defeat this stage, they win the game.")
                .WithInfo(9, 1, Artist.Ben_Zweifel);
            
            addLocation("Rhosgobel", setName, 1, 1)
                .WithUnique()
                .WithTraits("Forest.", "Village.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Response: After the players travel to Rhosgobel, add 1 resource to each hero's pool and each player draws 1 card.")
                .WithInfo(10, 1, Artist.Ben_Zweifel);
            addEnemy("Rider of Mirkwood", setName, 50, Card.VALUE_X, 6, 3, 10)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("X is 1 more than the stage number of the main quest.")
                .WithTextLine("Cannot leave the staging area unless the players are at stage 3B.")
                .WithVictoryPoints(6)
                .WithSideB()
                .WithInfo(11, 1, Artist.John_Howe);

            addEnemy("Nazgûl of Dol Guldur", string.Empty, 36, 3, 6, 3, 9)
                .WithSetNumberAndCost(15, 3)
                .WithUnique()
                .WithTraits("Nazgûl.")
                .WithTextLine("Cannot have non-objective player card attachments or take non-combat damage.")
                .WithTextLine("Forced: After Nazgûl of Dol Guldur attacks you, either return it to the staging area or raise your threat by 3.")
                .WithInfo(12, 1, Artist.David_A_Nash);
            addLocation("Necromancer's Pass", string.Empty, 2, 2)
                .WithSetNumberAndCost(15, 0)
                .WithTraits("Dol Guldur.")
                .WithTextLine("When Revealed: The first player chooses a card in his hand. The opposing team looks at the first player's hand and chooses a different card to place faceup under Necromancer's Pass as a guarded objective. While Necromancer's Pass is guarding a card, copies of that card cannot be played. When Necromancer's Pass is explored, return the guarded card to its owner's hand.")
                .WithInfo(13, 2, Artist.Daryl_Mandryk);
            addTreachery("Pursued by Shadow", string.Empty)
                .WithSetNumberAndCost(15, 0)
                .WithTextLine("When Revealed: The highest Attack enemy in the staging area makes an immediate attack against the first player. If no attack is made this way, Pursued by Shadow gains surge.")
                .WithShadow("Shadow: If attacking enemy is uniquie, it makes an additional attack against you after this one.")
                .WithInfo(14, 2, Artist.Matthew_Starbuck);
            addEnemy("Bane of Amon Lanc", string.Empty, 37, 3, 7, 1, 9)
                .WithSetNumberAndCost(16, 3)
                .WithUnique()
                .WithTraits("Troll.")
                .WithTextLine("Cannot have non-objective player card attachments.")
                .WithTextLine("Forced: After Bane of Amon Lanc attacks and destroys an ally, the defending player discards 1 card from his hand for each excess point of damage dealt by this attack.")
                .WithInfo(15, 1, Artist.Alexander_Kozachenko);
            addLocation("Oak-wood Grove", string.Empty, 2, 5)
                .WithSetNumberAndCost(16, 0)
                .WithTraits("Forest.")
                .WithTextLine("While Oak-wood Grove is in the staging area, progress cannot be placed on other locations in the staging area.")
                .WithTextLine("Travel: Each player exhausts a character.")
                .WithInfo(16, 2, Artist.Unknown);
            addTreachery("Smoking Blood", string.Empty)
                .WithSetNumberAndCost(16, 0)
                .WithTextLine("When Revealed: The opposing team attached Smoking Blood to a Troll enemu. If they cannot, Smoking Blood gains surge.(Counts as a Condition attachment with the text: \"Limit 1 per enemy. Forced: When attached enemy is dealt enough damage to destroy it, cancel the damage and discard Smoking Blood instead.\")")
                .WithInfo(17, 2, Artist.Magali_Villeneuve);
            addEnemy("Forest Flies", string.Empty, 6, 2, 1, 1, 6)
                .WithSetNumberAndCost(17, 0)
                .WithTraits("Creature.", "Insect.")
                .WithTextLine("Forced: When Forest Flies attacks, raise the defending player's threat by 1.")
                .WithShadow("Shadow: Raise your threat by 1 for each enemy engaged with you.")
                .WithInfo(18, 2, Artist.Rafal_Hrynkiewicz);
            addLocation("Twilight Hall", string.Empty, 0, 6)
                .WithSetNumberAndCost(17, 3)
                .WithUnique()
                .WithTraits("Forest.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Twilight Hall gets +1 Threat for each character controlled by the first player.")
                .WithTextLine("Forced: When Twilight Hall is explored, reveal 1 encounter card per player.")
                .WithInfo(19, 1, Artist.Katy_Grierson);
            addTreachery("Swarming Mosquitoes", string.Empty)
                .WithSetNumberAndCost(17, 0)
                .WithTextLine("When Revealed: Each player deals X damage to a character he controls, where X is 1 more than the stage number of the main quest.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character has an attachment).")
                .WithInfo(20, 2, Artist.Owen_William_Weber);
            addEnemy("Goblin Sniper", string.Empty, 38, 2, 4, 2, 5)
                .WithSetNumberAndCost(18, 2)
                .WithTraits("Orc.", "Goblin.")
                .WithTextLine("Cannot be optionally engaged.")
                .WithTextLine("Forced: At the end of the combat phase, easy player deals 1 damage to a hero he controls.")
                .WithShadow("Shadow: Defending character does not count it's Defense.")
                .WithInfo(21, 1, Artist.Unknown);
            addLocation("Pine Slopes", string.Empty, 2, 4)
                .WithSetNumberAndCost(18, 0)
                .WithTraits("Mountain.", "Forest.")
                .WithTextLine("When Revealed: Each Pine Slopes +2 Threat until the end of the phase.")
                .WithTextLine("Travel: Raise your threat by 1 for each Pine Slopes in the staging area.")
                .WithInfo(22, 3, Artist.Unknown);
            addTreachery("Under the Shadow", string.Empty)
                .WithSetNumberAndCost(18, 1)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Attach to the main quest. (Counts as a condition attachment with the text: \"Each player cannot play more than 1 card each phase.\")")
                .WithInfo(23,1, Artist.Igor_Kieryluk);
            addEnemy("Necromancer's Warg", string.Empty, 21, 2, 2, 1, 2)
                .WithSetNumberAndCost(19, 0)
                .WithTraits("Warg.")
                .WithTextLine("Forced: After Necromancer's Warg engages you, deal 1 damage to a character you control.")
                .WithShadow("Shadow: If you are engaged with an Orc enemy and a Warg enemy, discard a character you control.")
                .WithInfo(24, 1, Artist.Guillaume_Ducos);
            addEnemy("Dol Guldur Beastmaster", string.Empty, 35, 2, 4, 2, 5)
                .WithSetNumberAndCost(19, 2)
                .WithTraits("Orc.")
                .WithTextLine("Forced: After Dol Guldur Beastmaster engages you, the opposing team searches the encounter deck and discard pile for a Necromancer's Warg and puts it into play engaged with you. Shuffle the enconter deck.")
                .WithInfo(25, 1, Artist.David_Lecossu);
            addLocation("Watched Path", string.Empty, 3, 1)
                .WithSetNumberAndCost(19, 0)
                .WithTraits("Forest.")
                .WithTextLine("Forced: When Watched Path is explored, discard the top card of the encounter deck. If the discarded card is an enemy, add it to the staging area.")
                .WithInfo(26, 2, Artist.Jose_Vega);
            addTreachery("Evil Storm", string.Empty)
                .WithSetNumberAndCost(19, 1)
                .WithTraits("Weather.")
                .WithTextLine("When Revealed: Each player deals 1 damage to a questing character he controls. Until the end of the phase, each damaged character gets -1 Willpower and cannot be healed.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(27, 1, Artist.Tom_Garden);
            addEnemy("Spider of Dol Guldur", string.Empty, 35, 3, 5, 2, 6)
                .WithSetNumberAndCost(20, 2)
                .WithTraits("Spider.")
                .WithTextLine("Forced: After Spider of Dol Guldur attacks and destroys an ally, return it to the staging area.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(28, 1, Artist.Andrew_Ryan);
            addLocation("Patch of Midnight", string.Empty, 4, 4)
                .WithSetNumberAndCost(20, 1)
                .WithTraits("Forest.")
                .WithTextLine("Forced: At the beginning of the staging step, discard Patch of Midnight and reveal the top card of the encounter deck.")
                .WithShadow("Shadow: If this attack destroys a character, reveal the top card of the encounter deck.")
                .WithInfo(29, 1, Artist.Unknown);
            addTreachery("Eyes in the Dark", string.Empty)
                .WithSetNumberAndCost(20, 0)
                .WithTextLine("When Revealed: The opposing team chooses a questing character controlled by each player. Ready each chosen character and remove them from the quest.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, raise each player's threat by 1.")
                .WithInfo(30, 3, Artist.Unknown);
            addEnemy("Eastern Crows", string.Empty, 11, 1, 2, 0, 2)
                .WithSetNumberAndCost(21, 0)
                .WithTraits("Creature.")
                .WithTextLine("While there is a copy of Eastern Crows in the discard pile, Eastern Crows gains surge.")
                .WithInfo(31, 3, Artist.Matthew_Starbuck);
            addLocation("The Sorcerer's Tower", string.Empty, 4, 4)
                .WithSetNumberAndCost(21, 2)
                .WithUnique()
                .WithTraits("Dol Guldur.")
                .WithTextLine("While The Sorcerer's Tower is in the staging area, each treachery gains Doomed 1.")
                .WithTextLine("Forced: When the Sorcerer's Tower is explored, shuffle the encounter discard pile into the encounter deck and discard cards from the top until a treachery is discarded. Resolve the 'when revealed' effects on that treachery.")
                .WithInfo(32, 1, Artist.Julian_Kok);
            addTreachery("Power Sevenfold", string.Empty)
                .WithSetNumberAndCost(21, 1)
                .WithTextLine("When Revealed: The opposing team chooses any number of non-unique encounter cards in play. Discard the chosen cards and reveal an equal number of cards from the top of the encounter deck.")
                .WithShadow("Shadow: Either reveal an encounter card, or treat this attack as undefended.")
                .WithInfo(33, 1, Artist.Carlos_Palma_Cruchaga);
            addEnemy("Hill Troll", string.Empty, 33, 1, 6, 2, 8)
                .WithSetNumberAndCost(22, 1)
                .WithTraits("Troll.")
                .WithTextLine("Cannot have non-objective palyer card attachments.")
                .WithInfo(34, 2, Artist.Florian_Stitz);
            addLocation("Troll Cave", string.Empty, 3, 5)
                .WithSetNumberAndCost(22, 1)
                .WithTraits("Forest.", "Cave.")
                .WithTextLine("Response: After the players travel to Troll Cave, each player draws 1 card.")
                .WithTextLine("Travel: The opposing team searches the top 5 cards of the encounter deck for a Hill Troll and adds it to the staging area, if able. Shuffle the encounter deck.")
                .WithInfo(35, 1, Artist.Unknown);
            addTreachery("Befouled Equipment", string.Empty)
                .WithSetNumberAndCost(22, 0)
                .WithTextLine("When Revealed: Attach to the character with the most attachments without Befouled Equipment attached. (Counts as a Condition attachment with the text: \"Forced: At the end of the round, discard an attachment from attached character. Befouled Equipment cannot be discarded this way unless it is the only attachment on attached character.\")")
                .WithInfo(36, 2, Artist.Ed_Mattinian);
            addEnemy("Hunting Warg", string.Empty, 32, 2, 3, 2, 4)
                .WithSetNumberAndCost(23, 1)
                .WithTraits("Warg.")
                .WithTextLine("Forced: After Hunting Warg engages a player, it makes an immediate attack. If Hunting Warg is dealt a shadow card with no shadow effect for this attack, it gets +2 Attack until the end of the phase.")
                .WithInfo(37, 2, Artist.Aurelien_Hubert);
            addLocation("Hunter's Lookout", string.Empty, 3, 4)
                .WithSetNumberAndCost(23, 1)
                .WithTraits("Mountain.", "Forest.")
                .WithTextLine("While Hunter's Lookout is in the staging area, it gains: \"Forced: At the end of the round, raise each player's threat by 1 for each enemy in the staging area.\"")
                .WithTextLine("Travel: The highest Attack enemy in the staging area makes an immediate attack against the first player.")
                .WithInfo(38, 1, Artist.Unknown);
            addTreachery("Restless Hunters", string.Empty)
                .WithSetNumberAndCost(23, 0)
                .WithTextLine("When Revealed: Return each engaged enemy to the staging area. If no enemies were returned this way, Restless Hunters gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, return attacking enemy to the staging area.")
                .WithInfo(39, 2, Artist.Adam_Lane);
            addEnemy("Dol Guldur Orcs", string.Empty, 24, 2, 3, 1, 4)
                .WithSetNumberAndCost(24, 0)
                .WithTraits("Orc.")
                .WithTextLine("When Revealed: Each player deals 1 damage to a character he controls.")
                .WithShadow("Shadow: Defending character gets -1 Defense for each damage on it.")
                .WithInfo(40, 2, Artist.Unknown);
            addLocation("The Shadow Road", string.Empty, 3, 3)
                .WithSetNumberAndCost(24, 1)
                .WithTraits("Forest.", "Road.")
                .WithTextLine("While The Shadow Road is in the staging area, it gains: \"Forced: After a player optionally engages an enemy, he deals 1 damage to a character he controls.\"")
                .WithTextLine("Travel: Each player deals 1 damage to a character he controls.")
                .WithInfo(41, 1, Artist.Katy_Grierson); 
            addTreachery("The Necromancer's Reach", string.Empty)
                .WithSetNumberAndCost(24, 1)
                .WithTextLine("When Revealed: Deal 1 damage to each exhausted character.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character is damaged).")
                .WithInfo(42, 2, Artist.Anna_Christenson);
            addEnemy("Ravenous Spider", string.Empty, 34, 3, 4, 2, 5)
                .WithSetNumberAndCost(25, 1)
                .WithTraits("Spider.")
                .WithTextLine("Forced: After Ravenous Spider attacks and destroys a character, the defending player exhausts a character he controls.")
                .WithShadow("Shadow: If this attack destroys a character, exhaust a character you control.")
                .WithInfo(43, 1, Artist.Alvaro_Calvo_Escudero);
            addLocation("Forest Gate", string.Empty, 1, 5)
                .WithSetNumberAndCost(25, 0)
                .WithTraits("Forest.")
                .WithTextLine("Forest Gate gets +1 Threat for each enemy in the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each enemy engaged with you.")
                .WithInfo(44, 2, Artist.Unknown);
            addTreachery("Nightfall", string.Empty)
                .WithSetNumberAndCost(25, 1)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Attach to the first player's threat dial. (Counts as a Condition attachment with the text: \"Forced: Raise your threat by an additional point during the refresh phase.\")")
                .WithInfo(45, 2, Artist.David_Lecossu);
            addEnemy("Venomous Spider", string.Empty, 28, 2, 3, 2, 4)
                .WithSetNumberAndCost(26, 1)
                .WithTraits("Spider.")
                .WithTextLine("Forced: After Venomous Spider attacks and damages a character, that character cannot ready until the end of the round.")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithInfo(46, 2, Artist.Florian_Devos);
            addLocation("Pitch-dark Thicket", string.Empty, 2, 3)
                .WithSetNumberAndCost(26, 0)
                .WithTraits("Forest.")
                .WithTextLine("While Pitch-dark Thicket is in the staging area, enemies in the staging area cannot take damage.")
                .WithShadow("Shadow: If attacking enemy was engaged this round, it cannot take damage until the end of the round.")
                .WithInfo(47, 2, Artist.Unknown);
            addTreachery("Fastness of Mirkwood", string.Empty)
                .WithSetNumberAndCost(26, 1)
                .WithTextLine("When Revealed: The opposing team searches the encounter deck and discard pile for one different 0 cost location per player (limit 2) and adds them to the staging area. Shuffle the encounter deck.")
                .WithShadow("Shadow: If this attack destroys a character, return the active location to the staging area.")
                .WithInfo(48, 1, Artist.Katy_Grierson);
            addEnemy("Dark Bats", string.Empty, 20, 2, 3, 1, 2)
                .WithSetNumberAndCost(27, 0)
                .WithTraits("Creature.")
                .WithTextLine("Forced: After Dark Bats attacks and damages a character, reveal the top card of the encounter deck. Then, discard Dark Bats.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. Deal it an additional shadow card.")
                .WithInfo(49, 2, Artist.Aurelien_Hubert);
            addLocation("Forest Stream", string.Empty, 2, 5)
                .WithSetNumberAndCost(27, 1)
                .WithTraits("Forest.", "River.")
                .WithTextLine("While Forest Stream is in the staging area, it gains: \"Forced: At the end of the round, remove 2 progress from the main quest.\"")
                .WithTextLine("Travel: Raise each player's threat by 2.")
                .WithInfo(50, 2, Artist.Trudi_Castle);
            addTreachery("Treacherous Fog", string.Empty)
                .WithSetNumberAndCost(27, 1)
                .WithTraits("Weather.")
                .WithTextLine("When Revealed: Until the end of the phase, each enemy and location in the staging area gets +2 Threat.")
                .WithShadow("Shadow: Each enemy engaged with you gets +1 Attack and +1 Defense until the end of the phase.")
                .WithInfo(51, 1, Artist.David_Lecossu);
            addEnemy("Howling Warg", string.Empty, 23, 1, 2, 1, 3)
                .WithSetNumberAndCost(28, 0)
                .WithTraits("Warg.")
                .WithTextLine("When Revealed: Discard the top card of the encounter deck. If that card has the Warg trait, reveal it and add it to the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it has the the Warg trait).")
                .WithInfo(52, 3, Artist.Dylan_Pierpont);
            addLocation("The Wargs' Glade", string.Empty, 3, 5)
                .WithSetNumberAndCost(28, 2)
                .WithUnique()
                .WithTraits("Forest.")
                .WithTextLine("While The Wargs' Glade is in the staging area, the first Warg enemy revealed each round gains surge.")
                .WithTextLine("Forced: When The Wargs' Glade is explored, the opposing team searches the encounter deck and discard pile for a non-unique Warg enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithInfo(53, 1, Artist.Michael_Rasmussen);
            addTreachery("Weighed Down", string.Empty)
                .WithSetNumberAndCost(28, 1)
                .WithTextLine("When Revealed: Exhaust each character with an attachment. If no character is exhausted this way, Weighed Down gains surge.")
                .WithShadow("Shadow: Discard an attachment from the defending character.")
                .WithInfo(54, 1, Artist.Unknown);
            
            addHero("Glorfindel", 12, Sphere.Lore, 3, 3, 1, 5)
                .WithTraits("Noble.", "Noldor.", "Warrior.")
                .WithTextLine("Action: Pay 1 resource from Glorfindel's pool to heal 1 damage on any character. (Limit once per round.)")
                .WithFlavorLine("\"You saw him for a moment as he is upon the other side: one of the mighty of the firstborn.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithYear(2018)
                .WithPromotion()
                .WithInfo(111, 1, Artist.Audrey_Hotte);
        }
    }
}