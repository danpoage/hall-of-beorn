﻿/* Generated CardSet class: The Voice of Isengard */

using System;

namespace HallOfBeorn.Models.LotR.Sets.TheVoiceOfIsengard
{
    public class TheVoiceOfIsengardSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Voice of Isengard";
            Abbreviation = "VoI";
            Number = 22;
            SetType = Models.SetType.Deluxe_Expansion;

            addHero("Éomer", 10, Sphere.Tactics, 1, 3, 2, 4)
                .WithTraits("Rohan.", "Noble.", "Warrior.")
                .WithTextLine("Response: After a character leaves play, Éomer gets +2 Attack until the end of the round. (Limit once per round.)")
                .WithFlavorLine("\"I am named Éomer son of Éomund, and am called the Third Marshal of Riddermark.\" -The Two Towers")
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addHero("Gríma", 9, Sphere.Lore, 2, 1, 2, 3)
                .WithSlugSuffix("Hero")
                .WithTraits("Rohan.", "Isengard.")
                .WithTextLine("Action: Lower the cost of the next card you play from your hand this round by 1. That card gains Doomed 1. (Limit once per round.)")
                .WithFlavorLine("\"Let your counsellor Gríma keep all things till your return - and I pray that we may see it, though no wise man will deem it hopeful.\" -The Two Towers")
                .WithInfo(2, 1, Artist.Matt_Stewart);
            addAlly("Saruman", 3, Sphere.Neutral, true, 3, 5, 4, 4)
                .WithTraits("Istari.", "Isengard.")
                .WithKeywords("Doomed 3.")
                .WithTextLine("At the end of the round, discard Saruman from play.")
                .WithTextLine("Response: After Saruman enters play, choose a non-unique enemy or location in the staging area. While Saruman is in play, the chosen enemy or location is considered to be out of play.")
                .WithInfo(3, 3, Artist.Matt_Stewart);
            addAlly("Orthanc Guard", 2, Sphere.Leadership, false, 1, 0, 2, 2)
                .WithTraits("Isengard.")
                .WithTextLine("Response: After you raise your threat from the Doomed keyword, ready Orthanc Guard.")
                .WithFlavorLine("\"...the keepers of the gate were on the watch for me and told me that Saruman awaited me.\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(4, 3, Artist.Adam_Lane);
            addAlly("Isengard Messenger", 2, Sphere.Lore, false, 1, 0, 1, 2)
                .WithTraits("Isengard.")
                .WithTextLine("Response: After you raise your threat from the Doomed keyword, Isengard Messenger gets +1 Willpower until the end of the round. (Limit twice per round.)")
                .WithFlavorLine("\"I have an urgent errand,\" he said. \"My news is evil.\" -Radagast, The Fellowship of the Ring")
                .WithInfo(5, 3, Artist.Cristi_Balanescu);
            addAlly("Westfold Outrider", 2, Sphere.Tactics, false, 0, 2, 1, 2)
                .WithTraits("Rohan.", "Scout.")
                .WithTextLine("Action: Discard Westfold Outrider to choose an enemy not engaged with you. Engage the chosen enemy.")
                .WithFlavorLine("\"Erkenbrand of Westfold has drawn off those men he could gather towards his fastness at Helm's Deep. The rest are scattered.\"-Rider of Rohan, The Two Towers")
                .WithInfo(6, 3, Artist.Diego_Gisbert_Llorens);
            addAlly("Westfold Horse-breeder", 1, Sphere.Spirit, false, 1, 0, 0, 1)
                .WithTraits("Rohan.")
                .WithTextLine("Response: After Westfold Horse-breeder enters play, search the top 10 cards of your deck for a Mount attachment and add it to your hand. Shuffle your deck.")
                .WithFlavorLine("\"They love their horses next to their kin.\" -Boromir, The Fellowship of the Ring")
                .WithInfo(7, 3, Artist.Mike_Capprotti);
            addAttachment("Rohan Warhorse", 1, Sphere.Tactics, false)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Tactics or Rohan hero.")
                .WithTextLine("Response: After attached hero participates in an attack that destroys an enemy, exhaust Rohan Warhorse to ready attached hero.")
                .WithFlavorLine("Their horses were of great stature, strong and clean-limbed... -The Two Towers")
                .WithInfo(8, 3, Artist.Jeff_Lee_Johnson);
            addAttachment("Silver Lamp", 2, Sphere.Spirit, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a Spirit hero.")
                .WithTextLine("While attached hero is ready, shadow cards dealt to enemies engaged with you are dealt face up. ~(Shadow card effects are still resolved when resolving enemy attacks.)")
                .WithFlavorLine("...one of them uncovered a small lamp that gave out a slender silver beam. -The Fellowship of the Ring")
                .WithInfo(9, 3, Artist.Owen_William_Weber);
            addAttachment("Keys of Orthanc", 1, Sphere.Neutral, true)
                .WithTraits("Item.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Response: After you raise your threat from the Doomed keyword, exhaust Keys of Othanc to add 1 resource to attached hero's resource pool.")
                .WithFlavorLine("\"He has the Key of Orthanc\" -Gandalf, The Two Towers")
                .WithInfo(10, 3, Artist.Magali_Villeneuve);
            addEvent("Legacy of Númenor", 0, Sphere.Leadership)
                .WithKeywords("Doomed 4.")
                .WithTextLine("Action: Add 1 resource to each hero's resource pool.")
                .WithFlavorLine("\"...in the midst of that valley is a tower of stone called Orthanc. It was not made by Saruman, but by the Men of Númenor long ago: and it is very tall and has many secrets...\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(11, 3, Artist.Matt_Stewart);
            addEvent("Deep Knowledge", 0, Sphere.Lore)
                .WithKeywords("Doomed 2.")
                .WithTextLine("Action: Each player draws 2 cards.")
                .WithFlavorLine("\"His knowledge is deep, but his pride has grown with it...\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(12, 3, Artist.Titus_Lunter);
            addEvent("The Wizards's Voice", 0, Sphere.Tactics)
                .WithTraits("Spell.")
                .WithKeywords("Doomed 3.")
                .WithTextLine("Action: Each player chooses 1 enemy engaged with him. Until the end of the phase, each chosen enemy cannot attack the player that chose it.")
                .WithFlavorLine("...it was a delight to hear the voice speaking, all that it said seemed wise and reasonable... -The Two Towers")
                .WithInfo(13, 3, Artist.Andrew_Johanson);
            addEvent("Power of Orthanc", 0, Sphere.Spirit)
                .WithTraits("Spell.")
                .WithKeywords("Doomed 2.")
                .WithTextLine("Action: Each player may choose and discard a Condition attachment from play.")
                .WithFlavorLine("\"But Saruman has long studied the arts of the Enemy himself, and thus we have often been able to forestall him.\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(14, 3, Artist.Cristi_Balanescu);
            addEvent("The Seeing-stone", 0, Sphere.Neutral)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Action: Search your deck for a card with the Doomed keyword and add it to your hand. Shuffle your deck.")
                .WithFlavorLine("\"...alone it could do nothing but see small images of things far off and days remote.\" -Gandalf, The Two Towers")
                .WithInfo(15, 3, Artist.Rafal_Hrynkiewicz);
            addObjectiveAlly("Gríma", EncounterSet.TheFordsOfIsen, 2, 1, 2, 3)
                .WithUnique()
                .WithSlugSuffix("Objective-Ally")
                .WithTraits("Rohan.")
                .WithTextLine("If free of encounters, the first player gains control of Gríma.")
                .WithTextLine("Action: Exhaust Gríma to draw a card.")
                .WithTextLine("If Gríma leaves play, the players lose the game.")
                .WithFlavorLine("Behind him cringing between two other men, came Gríma the Wormtongue. -The Two Towers")
                .WithInfo(16, 1, Artist.Nacho_Molina);
            addLocation("The Islet", EncounterSet.TheFordsOfIsen, 1, 1)
                .WithUnique()
                .WithTraits("River.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("While Iselet is the active location, each Dunland enemy in play gets +1 Threat.")
                .WithFlavorLine("There were three lines of flat stepping-stones across the stream, and between them fords for horses, that went from either brink to a bare eyot in the midst. -The Two Towers")
                .WithInfo(17, 1, Artist.Alyn_Spiller);
            addLocation("Fords of Isen", EncounterSet.TheFordsOfIsen, 3, 4)
                .WithTraits("River.")
                .WithTextLine("While Fords of Isen is in the staging area, players cannot gain resources from card effects.")
                .WithTextLine("Forced: After Fords of Isen becomes the active location, each player with fewer than 5 cards in his hand draws cards until he has 5 in his hand.")
                .WithFlavorLine("The road dipped between rising turf-banks, carving its way through the terraces to the river's edge, and up again upon the further side. -The Two Towers")
                .WithInfo(18, 3, Artist.Michael_Rasmussen);
            addLocation("The King's Road", EncounterSet.TheFordsOfIsen, 2, 2)
                .WithTraits("Road.")
                .WithTextLine("While any player has 3 or more cards in hand, The King's Road gets +3 quest points.")
                .WithTextLine("While any player has 5 or more cards in hand, The King's Road gains: \"When faced with the option to travel, the players must travel to The King's Road, if able.\"")
                .WithInfo(19, 2, Artist.Michael_Rasmussen);
            addLocation("Gap of Rohan", EncounterSet.TheFordsOfIsen, 2, 3)
                .WithTraits("Valley.")
                .WithTextLine("While Gap of Rohan is in the staging area, Dunland enemies get +1 Attack.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, remove 1 time counter from the current quest.")
                .WithEasyModeQuantity(2)
                .WithInfo(20, 4, Artist.Michael_Rasmussen);
            addTreachery("Pillaging and Burning", EncounterSet.TheFordsOfIsen)
                .WithTextLine("When Revealed: Each player draws a card. Each player raises his threat by 1 for each card in his hand.")
                .WithShadow("Shadow: Defending player discards an attachment he controls (each attachment he controls instead if this attack is undefended).")
                .WithEasyModeQuantity(1)
                .WithInfo(21, 2, Artist.Sabin_Boykinov);
            addTreachery("Down from the Hills", EncounterSet.TheFordsOfIsen)
                .WithTextLine("When Revealed: Each player must choose: Either remove 1 time counter from the current quest, or search the encounter deck and discard pile for a Dunland enemy, reveal it, and add it to the staging area. Shuffle the encounter deck. If any player has 5 or more cards in hand, this effect cannot be canceled.")
                .WithEasyModeQuantity(0)
                .WithInfo(22, 1, Artist.David_Horne);
            addTreachery("Ill Tidings", EncounterSet.TheFordsOfIsen)
                .WithTextLine("When Revealed: The first player draws this card into his hand. Ill Tidings cannot leave that player's hand. Then, if the first player has 5 or more cards in his hand, Ill Tidings gains surge.")
                .WithFlavorLine("\"Troubles follow you like crows, and ever the oftener the wrose.\" -Gríma, The Two Towers")
                .WithInfo(23, 2, Artist.John_Gravato);
            addEnemy("Mugash", EncounterSet.ToCatchAnOrc, 1, 4, 7, 4, 8)
                .WithUnique()
                .WithSlugSuffix("Enemy")
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: After Mugash is defeated, the first player attaches him to a hero he controls and exhausts that hero. (Counts as a Captive attachment with the text: \"Attached hero cannot ready. If attached hero leaves play, the players lose the game.\")")
                .WithInfo(24, 1, Artist.Brent_Hollowel);
            addEnemy("Mugash's Guard", EncounterSet.ToCatchAnOrc, 40, 3, 6, 3, 6)
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("While a player controls a hero with Mugash attached, Mugash's Guard engages that player.")
                .WithTextLine("Forced: After Mugash's Guard destroys a character, if Mugash is attached to a hero, return Mugash to the staging area.")
                .WithVictoryPoints(3)
                .WithInfo(25, 3, Artist.Rafal_Hrynkiewicz);
            addEnemy("Methedras Orc", EncounterSet.ToCatchAnOrc, 30, 3, 5, 3, 5)
                .WithTraits("Orc.")
                .WithTextLine("Forced: When Methedras ~Orc attacks, the defending player shuffles 1 random card from his hand into his out-of-play deck.")
                .WithShadow("Shadow: If this attack destroys a character, remove 1 time counter from the current quest.")
                .WithInfo(26, 3, Artist.Rafal_Hrynkiewicz);
            addLocation("Methedras", EncounterSet.ToCatchAnOrc, 2, 3)
                .WithTraits("Mountain.")
                .WithTextLine("While Methedras is the active location, each location in the staging area gets +1 Threat.")
                .WithTextLine("Forced: When Methedras leaves play as an explored location, each player Searches 3.")
                .WithFlavorLine("Beyond there glimmered far away, as if floating on a grey cloud, the white head of tall Methedras, the last peak of the Misty Mountains. -The Two Towers")
                .WithInfo(27, 4, Artist.Stacey_Diana_Clark);
            addLocation("Orc Cave", EncounterSet.ToCatchAnOrc, 3, 4)
                .WithTraits("Mountain.", "Cave.")
                .WithTextLine("Forced: After ~Orc Cave leaves play as an explored location, the first player Searches 5.")
                .WithTextLine("Travel: Discard the top X cards of the encounter deck to travel here. X is the number of players in the game. Add each Orc enemy discarded this way to the staging area.")
                .WithInfo(28, 3, Artist.Michael_Rasmussen);
            addLocation("Mugash's Lair", EncounterSet.ToCatchAnOrc, 4, 2)
                .WithTraits("Mountain.", "Cave.")
                .WithTextLine("Forced: At the beginning of the encounter phase, reveal the top card of each player's out-of-play deck. Add each revealed enemy to the staging area and discard the rest.")
                .WithShadow("Shadow: Defending player discards an attachment he controls.")
                .WithInfo(29, 2, Artist.Michael_Rasmussen);
            addTreachery("Orc Territory", EncounterSet.ToCatchAnOrc)
                .WithTextLine("When Revealed: Each player searches the encounter deck and discard pile for a location and adds it to the staging area. If the total Threat in the staging area is less than the total Willpower of all characters committed to the quest, each Orc enemy engaged with a player makes an immediate attack.")
                .WithEasyModeQuantity(0)
                .WithInfo(30, 2, Artist.Joel_Hustak);
            addObjective("Mugash", EncounterSet.IntoFangorn)
                .WithUnique()
                .WithSlugSuffix("Objective")
                .WithTraits("Orc.", "Uruk.")
                .WithKeywords("Guarded.")
                .WithTextLine("Action: Exhaust a hero to claim this objective when it is free of encounters. Attach Mugash to that hero.")
                .WithTextLine("Forced: After attached hero takes damage, return Mugash to the top of the encounter deck.")
                .WithInfo(31, 1, Artist.Brent_Hollowel);
            addLocation("Edge of Fangorn", EncounterSet.IntoFangorn, 2, 2)
                .WithUnique()
                .WithTraits("Forest.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Travel: Search the encounter deck and discard pile for a Huorn enemy and add it to the staging area to travel here (2 Huorn enemies instead if there are 3 or more players in the game).")
                .WithFlavorLine("\"...we are on the very edge of Fangorn, and it is perilous to touch the trees of that wood, it is said.\"")
                .WithFlavorLine("-Aragorn, The Two Towers")
                .WithVictoryPoints(1)
                .WithInfo(32, 1, Artist.Ben_Zweifel);
            addEnemy("Dark-Hearted Huorn", EncounterSet.IntoFangorn, 1, 2, 4, 4, 5)
                .WithTraits("Huorn.")
                .WithKeywords("Hinder.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: At the beginning of each resource phase, the engaged player must raise his threat by 2.")
                .WithFlavorLine("\"There is a great power in them, and they seem able to wrap themselves in shadow...\" -Merry, The Two Towers")
                .WithEasyModeQuantity(3)
                .WithInfo(33, 4, Artist.Mike_Nash);
            addEnemy("Angry Huorn", EncounterSet.IntoFangorn, 38, 3, 5, 4, 8)
                .WithTraits("Huorn.")
                .WithKeywords("Hinder.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: At the beginning of each resource phase, Angry Huorn attacks the engaged player.")
                .WithFlavorLine("\"I should be terrified of meeting them, if there were no true Ents about to look after them.\" -Merry, The Two Towers")
                .WithEasyModeQuantity(2)
                .WithInfo(34, 3, Artist.Jim_Pavelec);
            addEnemy("Deadly Huorn", EncounterSet.IntoFangorn, 34, 2, 3, 4, 6)
                .WithTraits("Huorn.")
                .WithKeywords("Hinder.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: At the beginning of each resource phase, the engaged player must deal 3 damage to a character he controls.")
                .WithFlavorLine("\"We could not see them, of course, but the whole air was full of creaking.\" -Merry, The Two Towers")
                .WithEasyModeQuantity(2)
                .WithInfo(35, 3, Artist.Mike_Nash);
            addLocation("Heart of Fangorn", EncounterSet.IntoFangorn, 3, 3)
                .WithTraits("Forest.")
                .WithTextLine("While Heart of Fangorn is in the staging area, each player cannot refresh more than 5 characters during the refresh phase.")
                .WithShadow("Attacking enemy makes an additional attack after this one.")
                .WithInfo(36, 3, Artist.Alyn_Spiller);
            addTreachery("The Forest's Malice", EncounterSet.IntoFangorn)
                .WithTextLine("When Revealed: Each Huorn enemy engaged with a player makes an immediate attack. If no attack was made as a result of this effect, each player must search encounter deck and discard pile for a Huorn enemu and pit it into play engaged with him. This effect cannot be canceled.")
                .WithEasyModeQuantity(1)
                .WithInfo(37, 4, Artist.Cristi_Balanescu);
            addEnemy("Orc Skirmisher", EncounterSet.MistyMountainOrcs, 33, 3, 4, 2, 4)
                .WithTraits("Orc.")
                .WithTextLine("Forced: After ~Orc Skirmisher engages a player, that player must either deal 3 damage to a character he controls, or remove 1 time counter from the current quest.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithInfo(38, 3, Artist.Diego_Gisbert_Llorens);
            addEnemy("Orc Hunter", EncounterSet.MistyMountainOrcs, 35, 2, 3, 1, 3)
                .WithTraits("Orc.")
                .WithTextLine("When Revealed: Either reveal an additional encounter card, or remove 1 time counter from the current quest.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(39, 3, Artist.Diego_Gisbert_Llorens);
            addEnemy("Orc Hound", EncounterSet.MistyMountainOrcs, 20, 1, 2, 1, 2)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithTextLine("Forced: After ~Orc Hound engages a player, that player must exhaust a character he controls.")
                .WithEasyModeQuantity(1)
                .WithInfo(40, 2, Artist.Ilich_Henriquez);
            addTreachery("Orc Hunting Party", EncounterSet.MistyMountainOrcs)
                .WithTextLine("When Revealed: Deal each Orc enemy in play a shadow card. Each Orc enemy gets -15 engagement cost until the end of the round. If there are no Orc enemies in the staging area, Orc Hunting Party gains surge.")
                .WithFlavorLine("'The scouts have come back at last,' said an Orc close at hand. -The Two Towers")
                .WithInfo(41, 2, Artist.Rafal_Hrynkiewicz);
            addEnemy("Dunland Prowler", EncounterSet.DunlandRaiders, 30, 1, 2, 3, 3)
                .WithTraits("Dunland.")
                .WithTextLine("While any player has 3 or more cards in hand, ~Dunland Prowler gains surge.")
                .WithTextLine("While any player has 5 or more cards in hand, ~Dunland Powler gets +1 Threat.")
                .WithFlavorLine("...the wild men of the Dunland fells. -The Two Towers")
                .WithInfo(42, 3, Artist.Jason_Ward);
            addEnemy("Dunlending Bandit", EncounterSet.DunlandRaiders, 33, 2, 1, 2, 4)
                .WithTraits("Dunland.")
                .WithTextLine("While engaged with a player, Dunlending Bandit gets +1 Attack for each card in that player's hand.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending player has at least 3 cards in his hand).")
                .WithInfo(43, 2, Artist.Ilich_Henriquez);
            addEnemy("Dunland Raider", EncounterSet.DunlandRaiders, 35, 3, 5, 3, 5)
                .WithTraits("Dunland.")
                .WithTextLine("Forced: After ~Dunland Raider engages a player, that player must deal X damage divided among characters he controls where X equals the number of cards in his hand.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithEasyModeQuantity(0)
                .WithInfo(44, 2, Artist.Jason_Ward);
            addTreachery("Old Hatreds", EncounterSet.DunlandRaiders)
                .WithKeywords("Surge.")
                .WithTextLine("When Revealed: Attach to the current quest. (Counts as a Condition attachment with the text: \"Forced: After a player draws an number of cards, raise his threat by 1.\")")
                .WithFlavorLine("\"They hate us, and they are glad; for our doom seems certain to them.\" -Gamling, The Two Towers")
                .WithEasyModeQuantity(1)
                .WithInfo(45, 2, Artist.Ilich_Henriquez);
            addEnemy("Dunland Tribesman", EncounterSet.DunlandWarriors, 37, 0, 4, 2, 3)
                .WithTraits("Dunland.")
                .WithTextLine("When Revealed: Each player draws a card.")
                .WithTextLine("Forced: After a player draws any number of cards, ~Dunland Tribesman gets +1 Threat until the end of the round.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithInfo(46, 2, Artist.David_Horne);
            addEnemy("Dunland Chieftain", EncounterSet.DunlandWarriors, 35, 3, 5, 3, 6)
                .WithTraits("Dunland.")
                .WithTextLine("Forced: After ~Dunland Chieftain engages a player, discard X cards from the top of the encounter deck where X is the number of cards in the engages player's hand. Put the topmost Dunland enemy discarded this way into play engaged with that player.")
                .WithEasyModeQuantity(0)
                .WithInfo(47, 2, Artist.Jim_Pavelec);
            addEnemy("Dunland Berserker", EncounterSet.DunlandWarriors, 25, 2, 2, 1, 4)
                .WithTraits("Dunland.")
                .WithTextLine("Forced: After the engaged player draws any number of cards. Dunland Berserker makes an immediate attack.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack after this one.")
                .WithInfo(48, 3, Artist.Alvaro_Calvo_Escudero);
            addTreachery("Wild Men of Dunland", EncounterSet.DunlandWarriors)
                .WithKeywords("Surge.")
                .WithTextLine("When Revealed: Attach to the current quest. (Counts as a Condition attachment with the text: \"Forced: After a player draws any number of cards, that player deals 1 damage to a character he controls.\")")
                .WithFlavorLine("\"I looked on the hillmen and they seemed over large for me...\" -Gimli, The Two Towers")
                .WithEasyModeQuantity(1)
                .WithInfo(49, 2, Artist.Alvaro_Calvo_Escudero);
            addLocation("Ancient Forest", EncounterSet.AncientForest, 2, 5)
                .WithSlugSuffix("Location")
                .WithTraits("Forest.")
                .WithTextLine("While Ancient ~Forest is in the staging area, each Forest location in the staging area gets +1 Threat and +3 quest points. This ability does not stack with other copies of Ancient ~Forest.")
                .WithShadow("Shadow: Defending player exhausts a character he controls.")
                .WithEasyModeQuantity(1)
                .WithInfo(50, 3, Artist.Ben_Zweifel);
            addLocation("Tangled Woods", EncounterSet.AncientForest, 2, 4)
                .WithTraits("Forest.")
                .WithTextLine("While Tangled ~Woods is in the staging area, each Forest location in plays gains: \"Travel: Exhaust a hero to travel here.\" This ability does not stack with other copies of Tangled ~Woods.")
                .WithFlavorLine("The forest was dark and close. -The Two Towers")
                .WithInfo(51, 3, Artist.Michael_Rasmussen);
            addTreachery("Turned Around", EncounterSet.AncientForest)
                .WithTextLine("When Revealed: Either remove 1 time counter from a card in play, or return the active location to the staging area.")
                .WithShadow("Shadow: If this attack is undefended, return the active location to the staging area.")
                .WithInfo(52, 3, Artist.Darek_Zabrocki);
            addEnemy("Prowling Wolf", EncounterSet.BrokenLands, 28, 3, 1, 1, 3)
                .WithTraits("Creature.")
                .WithTextLine("While engaged with a player, Prowling Wolf gets +1 Attack for each location in the staging area.")
                .WithShadow("Shadow: Defending player exhausts a character he controls.")
                .WithInfo(53, 3, Artist.Piya_Wannachaiwong);
            addLocation("Broken Lands", EncounterSet.BrokenLands, 2, 6)
                .WithSlugSuffix("Location")
                .WithTraits("Highlands.")
                .WithTextLine("While Broken Lands is in the staging area, progress cannot be placed on locations in the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each location in the staging area.")
                .WithInfo(54, 3, Artist.Joel_Hustak);
            addTreachery("Take Cover!", EncounterSet.BrokenLands)
                .WithKeywords("Surge.")
                .WithTextLine("When Revealed: Either deal 1 damage to each exhausted character, or remove 1 time counter from the current quest.")
                .WithFlavorLine("Out of the darkness arrows whistled. -The Two Towers")
                .WithEasyModeQuantity(2)
                .WithInfo(55, 3, Artist.Sandra_Duchiewicz);
            addTreachery("Low on Provisions", EncounterSet.WearyTravelers)
                .WithTextLine("When Revealed: Each player must assign X damage among characters he controls, where X is the number of characters he controls.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character is undamaged.)")
                .WithEasyModeQuantity(2)
                .WithInfo(56, 3, Artist.Regis_Moulun);
            addTreachery("Off Track", EncounterSet.WearyTravelers)
                .WithKeywords("Surge.")
                .WithTextLine("When Revealed: Attach to a location in play. (Counts as a Condition attachment with the text: \"Limit 1 per location. Attached location gets +2 quest points and Gain: 'Forced: Remove an additional time counter from the current quest at the end of each refresh phase, if able.'\")")
                .WithInfo(57, 2, Artist.Sarah_Morris);
            addTreachery("In Need of Rest", EncounterSet.WearyTravelers)
                .WithTextLine("When Revealed: Remove a hero from the quest and attach In Need of Rest to that hero. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Forced: After a time counter is removed from the current quest, attached hero takes 1 damage.\")")
                .WithFlavorLine("I have just about enough strength left to find some hole away up there. And then I must rest a little.")
                .WithFlavorLine("-Frodo, The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(58, 2, Artist.Sara_Betsy);
            addQuest("Fight at the Fords", EncounterSet.TheFordsOfIsen, 1, 'A', 6)
                .WithKeywords("Time 5.")
                .WithTextLine("Setup: Add The Islet to the staging area and attach Gríma to that location. Each player searches the encounter deck for 1 different Dunland enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("Riding north to the Gap of Rohan, you come upon a battle at the Fords of Isen. A Small number of Rohirrim have taken a defensive position, on the islet in the river's center where a large force of wild Dunlending assails them. You must move swifty lest the river run red with blood of Rohan...")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, discard Gríma from play.")
                .WithOppositeTextLine("The players cannot advance unless the first player controls Gríma.")
                .WithIncludedEncounterSets(EncounterSet.DunlandWarriors, EncounterSet.DunlandRaiders)
                .WithInfo(59, 1, Artist.Cristi_Balanescu);
            addQuest("Dunlending Attack", EncounterSet.TheFordsOfIsen, 2, 'A', 14)
                .WithKeywords("Time 2.")
                .WithFlavorLine("After driving the Wild Men back from the islet, you are surprised to find king Théoden's personal advisor, Gríma Wormtongue, among the men defending the fords. He tells you that he was on his way to Isengard when he was caught in the attack. Before he can say more of his errand, the Dunlendings redouble their assault. \"Save me!\" Gríma cries as he shrinks behind you. The life of the king's counselor is in your hands...")
                .WithOppositeTextLine("When Revealed: Each player searches the encounter deck and discard pile for 1 different Dunland enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, each player assigns X damage among characters he controls where X is the number of cards in his hand. Place 2 time counters on this stage.")
                .WithIncludedEncounterSets(EncounterSet.DunlandWarriors, EncounterSet.DunlandRaiders)
                .WithInfo(60, 1, Artist.Cristi_Balanescu);
            addQuest("Hold the Fords", EncounterSet.TheFordsOfIsen, 3, 'A', 16)
                .WithKeywords("Time 3.")
                .WithTextLine("When Revealed: Each player searches the encounter deck and discard pile for 1 different Dunland enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("The Dunlendings' assault is relentless and your arms grow weary. \"Take me to Isengard!\" Gríma pleads, but you will not abandon the defense. You will either break the will of the enemy, or give your life in a heroic last stand...")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, discard the top X cards from the encounter deck. X is the number of cards in the first player's hand. Add each enemy discarded this way to the staging area. Put 3 time counters on this stage.")
                .WithOppositeTextLine("While there is at least 1 enemy in play, the players cannot defeat this stage. If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.DunlandWarriors, EncounterSet.DunlandRaiders)
                .WithInfo(61, 1, Artist.Adam_Lane);
            addQuest("Orders from Orthanc", EncounterSet.ToCatchAnOrc, 1, 'A', null)
                .WithTextLine("Setup: Each player removes the top 20 cards of his deck and places them aside, as an out-of-play deck. The first player takes Mugash plus 1 Mugash's Guard for each other player in the game and randomly shuffles one facedown into each player's out-of-play deck. Place any remaining copies of Mugash's Guard aside, out of play.")
                .WithFlavorLine("Saruman has tasked you with a dangerous mission: journey up the Misty Mountains' southern peack in search of the Orc, Mugash, and capture him alive.")
                .WithOppositeTextLine("When Revealed: Each player searches the encounter deck for a Mountain location and adds it to the staging area. Shuffle the encounter deck. Then, advance to stage 2.")
                .WithOppositeFlavorLine("Mugash and his Orcs have been raiding the surrounding coutryside from their hidden lair in Methedras, and carrying loot and captives back into the mountains. It's time to put an end to this menace...")
                .WithIncludedEncounterSets(EncounterSet.MistyMountainOrcs, EncounterSet.BrokenLands)
                .WithInfo(62, 1, Artist.Ilich_Henriquez);
            addQuest("Searching for Mugash", EncounterSet.ToCatchAnOrc, 2, 'A', null)
                .WithKeywords("Time 2.")
                .WithFlavorLine("Orcs prowl the mountainside on the lookout for intruders. A single horn-call from one of the sentries would have every Orc in Methedras scurrying out of their holes to fight. You must move carefully to avoid detection while you search for their captain...")
                .WithOppositeTextLine("Forced: After the last time counter is removed for this stage, shuffle the discard pile into the encounter deck and reveal 2 encounter cards per player. Place 2 time counters on this stage.")
                .WithOppositeTextLine("Response: After questing successfully, cancel all progress that would be placed on this stage. Then, place 1 time counter on this stage. Or, if Mugash is in play, advance to stage 3.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountainOrcs, EncounterSet.BrokenLands)
                .WithInfo(63, 1, Artist.Sebastian_Giacobino);
            addQuest("The Wizard's Prize", EncounterSet.ToCatchAnOrc, 3, 'A', 15)
                .WithKeywords("Time 3.")
                .WithFlavorLine("You've found Mugash, but the Orc captain won't be taken without a fight! He howls and rages against you with the ferocity of a cornered animal. All the commotion is sure to draw more Orcs to the fray, yet you must subdue the huge Uruk before you can retreat down the mountain...")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, return Mugash to the staging area and reveal X encounter cards. X is the number of players in the game minus 1. Place 3 time counters on this stage.")
                .WithOppositeTextLine("Progress cannot be placed on this stage unless Mugash is attached to a hero.")
                .WithOppositeTextLine("If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountainOrcs, EncounterSet.BrokenLands)
                .WithInfo(64, 1, Artist.Adam_Lane);
            addQuest("Into the Woods", EncounterSet.IntoFangorn, 1, 'A', 9)
                .WithKeywords("Time 4.")
                .WithTextLine("Setup: Add Edge of Fangorn to the staging area and attach Mugash to that location. Shuffle the encounter deck. Reveal X additional encounter cards where X equals the number of players in the game minus 1.")
                .WithFlavorLine("You've captured the Orc captain, Mugash, in the mountains above Isengard. But as you make your way down Methedras, your captive escaped and flees east into Fangorn.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, shuffle Mugash into the encounter deck and advance to stage 3.")
                .WithOppositeTextLine("The players cannot advance to stage 2 unless Mugash is attached to a hero.")
                .WithOppositeFlavorLine("You pursue Mugash into the ancient forest to find that the trees themselves seems to be attacking him. Without thinking, your at the tree branches to rescue your captive. That is when you first sense your own peril...")
                .WithIncludedEncounterSets(EncounterSet.AncientForest, EncounterSet.WearyTravelers)
                .WithInfo(65, 1, Artist.Cristi_Balanescu);
            addQuest("Escape from Fangorn", EncounterSet.IntoFangorn, 2, 'A', 12)
                .WithKeywords("Time 4.")
                .WithTextLine("When Revealed: Each player searches the encounter deck and discard pile for a Huorn enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("You've rescued Mugash from the trees, but your sense the forest itself seethes with anger toward you. The thankless Orc struggles against you and the tree branches grasp at you. It's going to be a hard fight to get out of Fangorn with your captive...")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, shuffle Mugash into the encounter deck and advance to stage 3A.")
                .WithOppositeTextLine("The players cannot defeat this stage unless Mugash is attached to a hero.")
                .WithOppositeTextLine("If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.AncientForest, EncounterSet.WearyTravelers)
                .WithInfo(66, 1, Artist.Alexandre_Dainche);
            addQuest("The Angry Forest", EncounterSet.IntoFangorn, 3, 'A', null)
                .WithKeywords("Time 3.")
                .WithFlavorLine("Mugash has disappeared deeper into the woods. As you continue to search for him, the trees close in around you and you can feel their roots and limbs shaking with anger. Their branches rattle like a raging temptest, but without any wind. You're beginning to regret the decision to enter Fangorn. You need to find Mugash and get out...")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, discard the top 5 cards of the encounter deck. Each player must choose an enemy or objective in the discard pile, reveal it and add it to the staging area. Place 3 time counters on this stage.")
                .WithOppositeTextLine("Forced: After placing progress here, if there is at least 6 progress on this stage and Mugash is attached to a hero, advance to stage 2A.")
                .WithIncludedEncounterSets(EncounterSet.AncientForest, EncounterSet.WearyTravelers)
                .WithInfo(67, 1, Artist.Alyn_Spiller);
        }
    }
}
