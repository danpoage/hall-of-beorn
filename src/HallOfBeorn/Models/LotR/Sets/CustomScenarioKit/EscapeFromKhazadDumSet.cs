using System;

namespace HallOfBeorn.Models.LotR.Sets.CustomScenarioKit
{
    public class EscapeFromKhazadDumSet
        : CardSet
    {
        private const string setName = "Escape from Khazad-dûm";
        private const string emptySetName = "";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "EfKD";
            SetType = Models.SetType.Custom_Scenario_Kit;
            Cycle = "Custom Scenario Kit";
            Number = 3012;

            addHero("Gandalf", 14, Sphere.Neutral, 3, 3, 3, 5)
                .WithTraits("Istari.")
                .WithTextLine("Play with the top card of your deck faceup. Once per phase, you may play the top card of your deck as if it was in your hand. When playing a card this way, Gandalf is considered to have the printed Leadership, Lore, Tactics, and Spirit icons.")
                .WithInfo(2, 1, Artist.Rafal_Hrynkiewicz);
            addHero("Elrond", 13, Sphere.Lore, 3, 2, 3, 4)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("You may spend resources from Elrond's resource pool to pay for Spirit, Leadership, and Tactics allies.")
                .WithTextLine("Response: After a character is healed by another card effect, heal 1 damage on it.")
                .WithInfo(128, 1, Artist.Magali_Villeneuve);
            addHero("Arwen Undómiel", 9, Sphere.Spirit, 3, 1, 2, 3)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("Action: Discard a card from your hand to add 1 resource to a Noldor hero's resource pool, or to Aragorn's resource pool. (Limit once per round.)")
                .WithInfo(140, 1, Artist.Magali_Villeneuve);
            addHero("Beregond", 10, Sphere.Tactics, 0, 1, 4, 4)
                .WithTraits("Gondor.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Lower the cost to play Weapon and Armor attachments on Beregond by 2.")
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addHero("Sam Gamgee", 8, Sphere.Leadership, 3, 1, 1, 3)
                .WithTraits("Hobbit.")
                .WithTextLine("Response: After you engage an enemy with a higher engagement cost than your threat, ready Sam Gamgee. He gets +1 Willpower, +1 Attack and +1 Defense until the end of the round.")
                .WithInfo(2, 1, Artist.Alexandre_Dainche);

            addQuest("Out of the Depths", EncounterSet.EscapeFromKhazadDum, 1, 'A', 10)
                .WithFlavorLine("You entered Moria with the hope of finding Mithril, but you have become lost underground instead. Below the ancient mansions of the Dwarves, untold dangers lurk in the darkness.")
                .WithTextLine("Setup: Add Dark Pit to the staging area. The opposing team searches the encounter deck for one different 0-cost enemy or location per player and adds them to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("Surrounded by utter black and running low on supplies, you must find your way out of Khazad-dûm before it's too late.")
                .WithOppositeTextLine("Forced: When Dark Pit is explored, flip it over and set Durin's Bane aside, out of play. Each player searches the top 5 cards of his deck for a card, adds it to his hand, and shuffles his deck.")
                .WithOppositeTextLine("This stage cannot be defeated while Dark Pit is in play.")
                .WithInfo(1, 1, Artist.Anthony_Palumbo);
            addQuest("Search for an Exit", EncounterSet.EscapeFromKhazadDum, 2, 'A', 10)
                .WithOppositeTitle("Old One Lair")
                .WithFlavorLine("The Mines of Moria are vast beyond your imagination. Though you feel that you are making progress, one wrong turn could mean disaster.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 1 or less (cost 2 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("When Revealed: The opposing team searchs the encounter deck and discard pile for an enemy with cost 2 or less, adds it to the staging area, and places a resources on it. Shuffle the encounter deck.")
                .WithOppositeTextLine("The enemy with a resource on it is immune to player card effects, and progress cannot be placed on this stage while that enemy is in play.")
                .WithInfo(3, 1, Artist.Cristi_Balanescu);
            addQuest("Search for an Exit", EncounterSet.EscapeFromKhazadDum, 2, 'A', 15)
                .WithOppositeTitle("A Wrong Turn")
                .WithFlavorLine("The Mines of Moria are vast beyond your imagination. Though you feel that you are making progress, one wrong turn could mean disaster.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 1 or less (cost 2 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("When Revealed: Each player chooses 1 card in his hand and shuffles the rest into his deck.")
                .WithBackArtist(Artist.David_Lecossu)
                .WithInfo(4, 1, Artist.Cristi_Balanescu);
            addQuest("Search for an Exit", EncounterSet.EscapeFromKhazadDum, 2, 'A', 20)
                .WithOppositeTitle("A Way Up")
                .WithFlavorLine("The Mines of Moria are vast beyond your imagination. Though you feel that you are making progress, one wrong turn could mean disaster.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 1 or less (cost 2 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("Add the active location's Threat to the staging area.")
                .WithOppositeTextLine("During the travel phase, the players must travel, if able.")
                .WithBackArtist(Artist.Ben_Zweifel)
                .WithInfo(5, 1, Artist.Cristi_Balanescu);
            addQuest("Nearing the Gate", EncounterSet.EscapeFromKhazadDum, 3, 'A', 10)
                .WithOppositeTitle("The Bridge of Khazad-dûm")
                .WithFlavorLine("Your spirits rise as you are drawing near to the East Gate of Moria. But then a huge, dark shape rises in front of you and bursts into flames: a Balrog! Durin's Bane blocks your escape.")
                .WithTextLine("When Revealed: Add the set-aside Durin's Bane to the staging area. It cannot take damage this round. If there is more than 1 player, it makes an immediate attack against the first player.")
                .WithOppositeTextLine("No more than 5 progress can be placed here each round.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, Durin's Bane makes an attack against the first player. Any undefended or excess damage dealt by this attack must be placed here.")
                .WithOppositeTextLine("If this stage has damage on it equal to or greater than its quest points, the players lose the game. If this stage is defeated the players win the game.")
                .WithBackArtist(Artist.Silver_Saaremael)
                .WithInfo(7, 1, Artist.Ben_Zweifel);
            addQuest("Nearing the Gate", EncounterSet.EscapeFromKhazadDum, 3, 'A', 15)
                .WithOppositeTitle("Last Lord of Moria")
                .WithFlavorLine("Your spirits rise as you are drawing near to the East Gate of Moria. But then a huge, dark shape rises in front of you and bursts into flames: a Balrog! Durin's Bane blocks your escape.")
                .WithTextLine("When Revealed: Add the set-aside Durin's Bane to the staging area. It cannot take damage this round. If there is more than 1 player, it makes an immediate attack against the first player.")
                .WithOppositeTextLine("Durin's Bane engages the first player.")
                .WithOppositeTextLine("Durin's Bane cannot take more than X damage per round, where X is the number of progress tokens on this stage.")
                .WithOppositeTextLine("This stage cannot be defeated while Durin's Bane is in play. If the players defeat this stage, they win the game.")
                .WithBackArtist(Artist.Dmitry_Burmak)
                .WithInfo(8, 1, Artist.Ben_Zweifel);
            addQuest("Nearing the Gate", EncounterSet.EscapeFromKhazadDum, 3, 'A', 20)
                .WithOppositeTitle("The Rear Guard")
                .WithFlavorLine("Your spirits rise as you are drawing near to the East Gate of Moria. But then a huge, dark shape rises in front of you and bursts into flames: a Balrog! Durin's Bane blocks your escape.")
                .WithTextLine("When Revealed: Add the set-aside Durin's Bane to the staging area. It cannot take damage this round. If there is more than 1 player, it makes an immediate attack against the first player.")
                .WithOppositeTextLine("Each player's threat cannot be reduced by player card effects.")
                .WithOppositeTextLine("Durin's Bane is considered to be engaged with each player and attacks each player in turn order during the combat phase. (Deal and resolve a shadow card for each attack.)")
                .WithOppositeTextLine("If the players defeat this stage, they win the game.")
                .WithBackArtist(Artist.Jason_Juta)
                .WithInfo(9, 1, Artist.Ben_Zweifel);
            addLocation("Dark Pit", EncounterSet.EscapeFromKhazadDum, 1, 1)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Travel: The opposing team searches the top 5 cards of the encounter deck for a card with cost 1 or less (cost 2 or less instead if there are 2 or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. Its 'when revealed' effects cannot be canceled.")
                .WithInfo(10, 1, Artist.Igor_Kieryluk);
            addEnemy("Durin's Bane", EncounterSet.EscapeFromKhazadDum, 50, 4, 8, 3, 15)
                .WithUnique()
                .WithTraits("Balrog.")
                .WithTextLine("Immuned to player card effects.")
                .WithTextLine("Cannot be optionally engaged.")
                .WithTextLine("Forced: After Durin's Bane attacks and destroys a character you control, raise your threat by 2 and heal 2 damage from Durin's Bane.")
                .WithVictoryPoints(5)
                .WithInfo(11, 1, Artist.Magali_Villeneuve);

            addEnemy("Black Bats", emptySetName, 23, 1, 3, 1, 2)
                .WithSetNumberAndCost(15, 0)
                .WithTraits("Creature.")
                .WithTextLine("When Revealed: Eithe raise each player's threat by 2, or reveal an additional encounter card.")
                .WithShadow("Shadow: Either raise your threat by 2, or this attack is considered undefended.")
                .WithInfo(12, 3, Artist.Lukasz_Jaskolski);
            addLocation("Nest of Vermin", emptySetName, 3, 5)
                .WithSetNumberAndCost(15, 2)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("While Nest of Vermin is in the staging area, each Creature enemy gets +1 Threat.")
                .WithTextLine("Forced: When Nest of Vermin is explored, the opposing team searches the encounter deck and discard pile for a Creature enemy with cost 1 or less and adds it to the staging area. Shuffle the encounter deck.")
                .WithInfo(13, 1, Artist.Jokubas_Uoginitas);
            addTreachery("Swarm of Bats", emptySetName)
                .WithSetNumberAndCost(15, 1)
                .WithTextLine("When Revealed: Each character gets -1 Willpower until the end of the phase.")
                .WithShadow("Shadow: Each character you control gets -1 Attack and -1 Defense until the end of the phase.")
                .WithInfo(14, 1, Artist.Nicholas_Gregory);

            addEnemy("Cave Spider", emptySetName, 28, 2, 3, 1, 5)
                .WithSetNumberAndCost(16, 1)
                .WithTraits("Spider.")
                .WithTextLine("Forced: When Cave Spider attacks, either remove 2 progress from the main quest, or Cave Spider gets +2 Attack for this attack.")
                .WithShadow("Shadow: Either remove 2 progress from the main quest or attacking enemy gets +2 Attack.")
                .WithInfo(15, 2, Artist.Allison_Theus);
            addLocation("The Mountain's Roots", emptySetName, Card.VALUE_X, 4)
                .WithSetNumberAndCost(16, 0)
                .WithTraits("Underground.")
                .WithTextLine("X is 1 more than the stage number of the main quest.")
                .WithTextLine("Travel: Each player discards the top X cards of his deck.")
                .WithInfo(16, 2, Artist.Stu_Barnes);
            addTreachery("Watchful Eyes", emptySetName)
                .WithSetNumberAndCost(16, 1)
                .WithTextLine("When Revealed: The opposing team attaches Watchful Eyes to a hero. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Forced: If attached hero is exhausted at the end of the combat phase, reveal 1 card from the encounter deck.\")")
                .WithInfo(17, 1, Artist.Tiziano_Baracchi);

            addEnemy("Cave-troll", emptySetName, 36, 2, 5, 1, 6)
                .WithSetNumberAndCost(17, 1)
                .WithTraits("Troll.")
                .WithTextLine("Cannot have non-objective player card attachments.")
                .WithTextLine("Allies cannot be declared as attackers or defenders against Cave-troll.")
                .WithInfo(18, 1, Artist.Timo_Karhula);
            addLocation("Twisting Passage", emptySetName, 2, 2)
                .WithSetNumberAndCost(17, 0)
                .WithTraits("Underground.")
                .WithTextLine("When Revealed: Discard the top card of the encounter deck. If that card is a location, add it to the staging area.")
                .WithInfo(19, 2, Artist.Ben_Zweifel);
            addTreachery("Undisturbed Bones", emptySetName)
                .WithSetNumberAndCost(17, 1)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Attach to the main quest. (Counts as a Condition attachment with the text, \"Forced: When a 'when revealed' effect would be canceled, discard Undisturbed Bones instead.\")")
                .WithInfo(20, 2, Artist.Carolina_Eade);

            addEnemy("Old Stone-troll", emptySetName, 33, 1, 6, 1, 8)
                .WithSetNumberAndCost(18, 1)
                .WithTraits("Troll.")
                .WithTextLine("Cannot have non-objective player card attachments.")
                .WithTextLine("Forced: After Old Stone-troll attachs and destroys a character you control, raise your threat by 1 for each excess point of damage dealt.")
                .WithInfo(21, 1, Artist.Sandara_Tang);
            addLocation("Frightful Den", emptySetName, 4, 4)
                .WithSetNumberAndCost(18, 2)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("While Frightful Den is in the staging area, each Troll enemy gets -10 engagement cost.")
                .WithTextLine("Forced: When Frightful Den is explored, the opposing team searches the encounter deck and discard pile for a Troll enemy with cost 1 or less and adds it to the staging area. Shuffle the encounter deck.")
                .WithInfo(22, 1, Artist.Jose_Vega);
            addTreachery("Deep Deep Dark", emptySetName)
                .WithSetNumberAndCost(18, 0)
                .WithTextLine("When Revealed: Each player must choose: either raise your threat by 1 for each character you control, or discard a character you control.")
                .WithShadow("Shadow: Raise your threat by 1 for each enemy engaged with you.")
                .WithInfo(23, 3, Artist.Rafal_Hrynkiewicz);

            addEnemy("Rock Adder", emptySetName, 18, 2, 1, 0, 3)
                .WithSetNumberAndCost(19, 0)
                .WithTraits("Creature.")
                .WithTextLine("Players cannot declare defenders against Rock Adder.")
                .WithShadow("Shadow: If this attack is undefended, attacking enemy gets +2 Attack.")
                .WithInfo(24, 2, Artist.Allison_Theus);
            addLocation("Bottomless Chasm", emptySetName, 2, 6)
                .WithSetNumberAndCost(19, 1)
                .WithTraits("Underground.")
                .WithTextLine("When faced with the option to travel, the player must choose Bottomless Chasm, if able.")
                .WithShadow("Shadow: Attacking enemy gets +2 Defense until the end of the phase.")
                .WithInfo(25, 2, Artist.Jake_Bullock);
            addTreachery("Lost and Alone", emptySetName)
                .WithSetNumberAndCost(19, 1)
                .WithTextLine("When Revealed: The opposing team chooses a questing charactert controlled by each player and removes them from the quest.")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithInfo(26, 1, Artist.David_Chen);

            addEnemy("Hobgoblin", emptySetName, 30, 3, 5, 2, 5)
                .WithSetNumberAndCost(20, 2)
                .WithTraits("Orc.", "Goblin.")
                .WithTextLine("Forced: After Hobgobling engages a player, it cannot take damage until the end of the round.")
                .WithShadow("Shadow: Attacking enemy cannot take damage this phase.")
                .WithInfo(27, 1, Artist.Martin_de_Diego_Sadaba);
            addLocation("Western Hall", emptySetName, 3, 4)
                .WithSetNumberAndCost(20, 1)
                .WithTraits("Underground.")
                .WithTextLine("Travel: Discard the top card of the encounter deck. Raise each player's threat by X, where X is that card's printed Threat.")
                .WithShadow("Shadow: If this attack destroys a character, reveal the top card of the encounter deck.")
                .WithInfo(28, 1, Artist.Michael_Rasmussen);
            addTreachery("New Devilry", emptySetName)
                .WithSetNumberAndCost(20, 0)
                .WithTextLine("When Revealed: Until the end of the round, treat each character's text box as if it were blank, except for Traits.")
                .WithShadow("Shadow: Until the end of the phase, treat the defending character's text box as blank, except for Traits.")
                .WithInfo(29, 3, Artist.Ben_Zweifel);

            addEnemy("Unspeakable Thing", emptySetName, 34, 2, 2, 2, 5)
                .WithSetNumberAndCost(21, 1)
                .WithTextLine("Forced: When Unspeakable Thing attacks you, discard the top card of your deck. Unspeakable thing gets +X Attack for this attack, where X is the discarded card's printed cost.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithInfo(30, 2, Artist.Florian_Devos);
            addLocation("Lightless Grotto", emptySetName, 2, 3)
                .WithSetNumberAndCost(21, 0)
                .WithTraits("Underground.")
                .WithTextLine("While Lightless Grotto is in the staging area, non-unique enemies in the staging area cannot take damage.")
                .WithTextLine("Travel: The first player chooses an enemy in the staging area and engages it.")
                .WithInfo(31, 2, Artist.Ivan_Dixon);
            addTreachery("Many Roads", emptySetName)
                .WithSetNumberAndCost(21, 1)
                .WithTextLine("When Revealed: The opposing team searches the encounter deck and discard pile for a different 0-cost location per player and adds them to the staging area. Shuffle the encounter deck.")
                .WithShadow("Shadow: The opposing team shuffles a location from the encounter discard pile into the encounter deck.")
                .WithInfo(32, 1, Artist.Stu_Barnes);

            addEnemy("Shadow Dweller", emptySetName, 36, 3, 5, 3, 6)
                .WithSetNumberAndCost(22, 2)
                .WithTraits("Creature.")
                .WithTextLine("Cannot have non-objective player card attachments or take non-combat damage.")
                .WithTextLine("Forced: When Shadow Dweller attacks you, discard the top card of your deck and assign X damage among character you control, where X is the discarded card's cost.")
                .WithInfo(33, 1, Artist.Mark_Bulahao);
            addLocation("Branching Paths", emptySetName, 0, 3)
                .WithSetNumberAndCost(22, 0)
                .WithTraits("Underground.")
                .WithTextLine("Branching Paths gets +1 Threat for each location in the staging area. (Limit +3 Threat.)")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithInfo(34, 3, Artist.David_A_Nash);
            addTreachery("Fatigue", emptySetName)
                .WithSetNumberAndCost(22, 1)
                .WithTextLine("When Revealed: Each player exhausts a character he controls. Until the end of the round, characters cannot be readied by player card effects.")
                .WithShadow("Shadow: Remove the defending character from the attack. A different defending character may be declared.")
                .WithInfo(35, 1, Artist.Charles_Urbach);

            addEnemy("Elder Nameless Thing", emptySetName, 38, 3, 5, 3, 9)
                .WithSetNumberAndCost(23, 3)
                .WithUnique()
                .WithTraits("Creature.")
                .WithTextLine("Cannot be optionally engaged.")
                .WithTextLine("While Elder ~Nameless Thing is in the staging area, it gains: \"Forced: After players have committed characters to the quest, Elder ~Nameless Thing makes an attack against the first player.")
                .WithInfo(36, 1, Artist.Allison_Theus);
            addLocation("Silent Caverns", emptySetName, 2, 3)
                .WithSetNumberAndCost(23, 0)
                .WithTraits("Underground.")
                .WithTextLine("While Silent Caverns is in the staging area, each player's threat cannot be reduced by more than 1 each round.")
                .WithTextLine("Travel: Raise each player's threat by 2.")
                .WithInfo(37, 2, Artist.Trudi_Castle);
            addTreachery("Dark Places", emptySetName)
                .WithSetNumberAndCost(23, 0)
                .WithTextLine("When Revealed: Raise each player's threat by X, where X is the threat of the active location. If there is no active location, Dark Places gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the stage number of the main quest.")
                .WithInfo(38, 2, Artist.Igor_Burlakov);

            addEnemy("Orc Horn Blower", emptySetName, 45, 2, 4, 3, 5)
                .WithSetNumberAndCost(24, 1)
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("Forced: At the beginning of the combat phase, deal each engaged enemy an additional shadow card.")
                .WithShadow("Shadow: Deal attacking enemy 2 additional shadow cards.")
                .WithInfo(39, 2, Artist.Ilich_Henriquez);
            addLocation("Goblin Dungeon", emptySetName, 2, 5)
                .WithSetNumberAndCost(24, 1)
                .WithTraits("Underground.")
                .WithTextLine("When Revealed: The opposing team chooses an ally, discards all tokens from it, and places it faceup as a guarded objective. When Goblin Dungeon is explored, return that ally to its owner's control exhausted.")
                .WithInfo(40, 1, Artist.Leanna_Crossan);
            addTreachery("Deep Fissure", emptySetName)
                .WithSetNumberAndCost(24, 0)
                .WithTextLine("When Revealed: Each player deals 1 damage to a questing character he controls and removes that character from the quest.")
                .WithShadow("Shadow: Deal 1 damage to a character you control.")
                .WithInfo(41, 2, Artist.Pedro_Amato);

            addEnemy("Black Uruks", emptySetName, 30, 3, 3, 2, 5)
                .WithSetNumberAndCost(25, 1)
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("While Black Uruks is attacking, it gets +1 Attack for each shadow card dealt for this attack.")
                .WithShadow("Shadow: The opposing team searches the top 5 cards of the encounter deck for a card and deals it to attacking enemy as a shadow card.")
                .WithInfo(42, 2, Artist.Jake_Murray);
            addLocation("Dreadful Gap", emptySetName, 2, 4)
                .WithSetNumberAndCost(25, 0)
                .WithTraits("Underground.")
                .WithTextLine("While Dreadful Gap is in the staging area, progress cannot be placed on other locations in the staging area.")
                .WithTextLine("Travel: The opposing team chooses a card in the encounter discard pile and shuffles it into the encounter deck.")
                .WithInfo(43, 2, Artist.Stu_Barnes);
            addTreachery("Orcish Howls", emptySetName)
                .WithSetNumberAndCost(25, 1)
                .WithTextLine("When Revealed: Exhaust X characters, where X is the number of Uruk enemies in play. If there are no Uruk enemies in play, Orcish Howls gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it is an Uruk).")
                .WithInfo(44, 1, Artist.Noah_Bradley);

            addEnemy("Orc Raiders", emptySetName, 28, 2, 2, 1, 3)
                .WithSetNumberAndCost(26, 0)
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("Forced: After Orc Raider engages a player, deal it a shadow card.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. Deal it an additional shadow card.")
                .WithInfo(45, 2, Artist.Mark_Tarrisse);
            addLocation("The Great Bridge", emptySetName, 4, 5)
                .WithSetNumberAndCost(26, 3)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("While The Great Bridge is in the staging area, no more than 1 character can be declared as an attacker against each enemy.")
                .WithTextLine("Forced: When The Great Bridge is explored, reveal 1 encounter card per player.")
                .WithInfo(46, 1, Artist.Emilio_Rodriguez);
            addTreachery("Vast and Intricate", emptySetName)
                .WithSetNumberAndCost(26, 0)
                .WithTextLine("When Revealed: The opposing team attaches Vast and Intricate to a non-unique location in the staging area. If there are no non-unique locations in the staging area, Vast and Intricate gains surge. (Counts as a Condition attachment with the text: \"Attached location gets +2 Threat and is immune to player card effects.\")")
                .WithInfo(47, 2, Artist.Eric_Braddock);

            addEnemy("Chieftain of the Pit", emptySetName, 35, 3, 5, 3, 8)
                .WithSetNumberAndCost(27, 3)
                .WithUnique()
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("Cannot have non-objective player card attachments or take non-combat damage.")
                .WithTextLine("Shadow effects cannot be canceled.")
                .WithTextLine("Forced: When Chieftain of the Pit attacks, deal it an additional shadow card.")
                .WithInfo(48, 1, Artist.John_Stanko);
            addLocation("Forked Passage", emptySetName, 1, 5)
                .WithSetNumberAndCost(27, 0)
                .WithTraits("Underground.")
                .WithTextLine("While Forked Passage is in the staging area, raise each player's threat by 1 additional point during the refresh phase.")
                .WithTextLine("Travel: Raise each player's threat by 1.")
                .WithInfo(49, 2, Artist.Davis_Engel);
            addTreachery("Chance Encounter", emptySetName)
                .WithSetNumberAndCost(27, 0)
                .WithTextLine("When Revealed: The highest Attack enemy in the staging area makes an attack against the first player. If no attack is made this way, Chance Encounter gains surge.")
                .WithShadow("Shadow: If attacking enemy is unique, it makes an additional attack against you after this one.")
                .WithInfo(50, 2, Artist.Magali_Villeneuve);

            addEnemy("Nameless Thing", emptySetName, 33, 1, 1, 1, 4)
                .WithSetNumberAndCost(28, 1)
                .WithTraits("Creature.")
                .WithTextLine("Forced: After ~Nameless Thing enters play, the first player attaches the top card of his deck to it faceup as a guarded attached. ~Nameless Thing gets +X Threat, +X Attack, and +X Defense, where X is that card's printed cost. When ~Nameless Thing leaves play, discard that card.")
                .WithInfo(51, 2, Artist.Timo_Karhula);
            addLocation("Mithril Lode", emptySetName, 3, 5)
                .WithSetNumberAndCost(28, 0)
                .WithTraits("Underground.")
                .WithTextLine("While Mitril Lode is the active location, it gains: \"Response: When Mithril Lode is explored, each player adds 1 resource to the resource pool of a hero he controls.")
                .WithInfo(52, 2, Artist.Cristi_Balanescu);
            addTreachery("A Foe Beyond", emptySetName)
                .WithSetNumberAndCost(28, 1)
                .WithTextLine("When Revealed: The opposing team chooses an attachment controlled by a player and discards it. If no attachment is discarded this way, A Foe Beyond gains surge.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithInfo(53, 1, Artist.Ilich_Henriquez);
        }
    }
}