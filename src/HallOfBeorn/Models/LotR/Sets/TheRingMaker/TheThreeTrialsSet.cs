/* Generated CardSet class: The Three Trials */

using System;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TheThreeTrialsSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Three Trials";
            Abbreviation = "TTT";
            Number = 24;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";

            addHero("Idraen", 11, Sphere.Spirit, 2, 3, 2, 4)
                .WithTraits("Dúnedain.", "Ranger.", "Scout.")
                .WithTextLine("Response: After a location is explored, ready Idraen.")
                .WithFlavorLine("\"Where now are the Dúnedain, Elessar, Elessar? Why do thy kinsfolk wander afar?\" -Galadriel, The Two Towers")
                .WithInfo(25, 1, Artist.Jake_Murray);
            addAlly("Rivendell Scout", 2, Sphere.Leadership, false, 1, 1, 0, 2)
                .WithTraits("Noldor.", "Scout.")
                .WithKeywords("Secrecy 2.")
                .WithTextLine("Secrecy 2.")
                .WithFlavorLine("\"Elrond is sending Elves, and they will get in touch with the Rangers, and maybe with Thranduil's folk in Mirkwood.\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(26, 3, Artist.Ilich_Henriquez);
            addEvent("Feigned Voices", 0, Sphere.Leadership)
                .WithTextLine("Combat Action: Return a Silvan ally you control to your hand to choose an enemy engaged with a player. That enemy cannot attack that player this phase.")
                .WithFlavorLine("\"The three of us could not challenge a hundred, so we went ahead and spoke with feigned voices, leading them on into the wood.\" -Haldir, The Fellowship of the Ring")
                .WithInfo(27, 3, Artist.Sara_Betsy);
            addAlly("Rúmil", 4, Sphere.Tactics, true, 2, 2, 1, 2)
                .WithTraits("Silvan.", "Scout.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After you play Rúmil from your hand, choose an enemy engaged with a player. Deal X damage to that enemy where X is the number of ranged characters you control.")
                .WithFlavorLine("...the Company set out again, guided now by Haldir and his brother Rúmil. -The Fellowship of the Ring")
                .WithInfo(28, 3, Artist.Melanie_Maier);
            addAttachment("Elven Mail", 2, Sphere.Tactics, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Noldor or Silvan character. Restricted.")
                .WithTextLine("Attached character gets +2 hit points and gains sentinel.")
                .WithFlavorLine("...they were tall and and clad in grey mail, and from their shoulders hung long white cloaks. -The Fellowship of the Ring")
                .WithInfo(29, 3, Artist.Sara_Betsy);
            addAlly("Greyflood Wanderer", 3, Sphere.Spirit, false, 2, 1, 0, 2)
                .WithTraits("Dúnedain.", "Scout.")
                .WithTextLine("You may give Greyflood Wanderer doomed 2 when you play from your hand. If you do, it gains: \"Response: After you play Greyflood Wanderer, place 1 progress token on each location in play.\"")
                .WithFlavorLine("...others had gone west, and with the help of Aragorn and the Rangers had searched the lands far down the Greyflood... -The Fellowship of the Ring")
                .WithInfo(30, 3, Artist.Arden_Beckwith);
            addAttachment("Warden of Arnor", 1, Sphere.Spirit, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Scout hero.")
                .WithTextLine("While attached character is committed to the quest, place 1 progress on the first location revealed by the encounter deck each round.")
                .WithFlavorLine("\"I have had a hard life and a long: and the leagues that lie between here and Gondor are a small part in the count of my journeys.\" -Aragorn, The Fellowship of the Ring")
                .WithInfo(31, 3, Artist.Melanie_Maier);
            addEvent("Message from Elrond", 0, Sphere.Lore)
                .WithTextLine("Action: Choose a player. That player may choose 1 card from his hand and add it to another player's hand. At the end of the round, if the chosen card is in that player's hand or in play, shuffle it into its owner's deck.")
                .WithFlavorLine("\"But we have heard rumours of your coming, for the messengers of Elrond passed by Lórien on the way home up the Dimrill Stair. -Haldir, The Fellowship of the Ring")
                .WithInfo(32, 3, Artist.Arden_Beckwith);
            addEvent("Noiseless Movement", 1, Sphere.Lore)
                .WithTextLine("Action: Choose an enemy in the staging area. That enemy does not make engagement checks this round. Then, if your threat is 20 or less and this is the first time you played a copy of Noiseless Movement this round, return this card to your hand instead of discarding it.")
                .WithFlavorLine("...the woodland folk were altogether noiseless in their movements. -The Fellowship of the Ring")
                .WithInfo(33, 3, Artist.Jordy_Lakiere);
            addAttachment("Leaf Brooch", 1, Sphere.Neutral, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("The first event card you play each round that matches attached hero's printed sphere gains secrecy 1.")
                .WithFlavorLine("Each cloak was fastened about the neck with a brooch like a green leaf veined with silver. -The Fellowship of the Ring")
                .WithInfo(34, 3, Artist.Jason_Ward);
            addQuest("The Trials Begin", EncounterSet.TheThreeTrials, 1, 'A', null)
                .WithTextLine("Setup: Set aside all 3 Guardian enemies, all 3 Key objectives, all 3 Barrow locations, and Hallowed Circle.")
                .WithFlavorLine("At the edge of a cursed forest, the Boar Shaman explains that you must undertake three trials in order to recover the Antlered Crown, or face death. Each trial will test your worthiness. Guardian spirits watch over three sacred swords, protecting them from the undeserving.")
                .WithOppositeTextLine("When Revealed: The players advance to a stage 2A quest of their choice.")
                .WithOppositeFlavorLine("Three ancient barrows mark the locations for the trials, each the resting place of a different guardian spirit. The Boar Clan waits at the forest's edge for any sign of your victory... or your death. Your only option is to press onward, heading towards the site of one of the three trials...")
                .WithIncludedEncounterSets(EncounterSet.AncientForest)
                .WithInfo(35, 1, Artist.Dleoblack);
            addQuest("The Trial of Strength", EncounterSet.TheThreeTrials, 2, 'A', null)
                .WithTextLine("When Revealed: Randomly choose 1 of the remaining set aside Guardian enemies and 1 of the remaining set aside Barrow locations, reveal them, and add them to the staging area. Find the set aside Key objective that shares a Trait with the just revealed Guardian enemy and attach it to that enemy.")
                .WithFlavorLine("A rotting corpse guards the inner chamber of this barrow, holding in its grasp a worn sword that looks like one of the keys the Boar Shaman described to you. When you reach for the key, the guardian springs to life and attacks you!")
                .WithOppositeTextLine("Each Guardian enemy engages the first player. Barrow locations cannot be the active location and are immune to player card effects.")
                .WithOppositeTextLine("When the players control the current trial's Key objective, add all Barrow locations in play to the victory display and immediately advance to a stage 2A of the players' choice. If all stage 2 quests have been defeated, advance to stage 3A, instead.")
                .WithIncludedEncounterSets(EncounterSet.AncientForest)
                .WithInfo(36, 1, Artist.Matt_Bradbury);
            addQuest("The Trial of Perseverance", EncounterSet.TheThreeTrials, 2, 'A', null)
                .WithTextLine("When Revealed: Randomly choose 1 of the remaining set aside Barrow locations and add it to the staging area. Then, randomly choose 1 of the remaining set aside Key objectives and attach it to that Barrow location. Find the set aside Guardian enemy that shares a Trait with the Key objective in play and reveal it, adding it to the staging area.")
                .WithFlavorLine("A huge barrow towers before you, cold mist enveloping the entrance. The key is somewhere inside, but a heavy chill fills you with dread and unease...")
                .WithOppositeTextLine("Each Guardian enemy engages the first player. Guardian enemies cannot be damaged or leave play except by quest effect.")
                .WithOppositeTextLine("When the players control the current trial's Key objective, add all Guardian enemies in play to the victory display and immediately advance to a stage 2A of the players' choice. If all stage 2 quests have been defeated, advance to stage 3A, instead.")
                .WithIncludedEncounterSets(EncounterSet.AncientForest)
                .WithInfo(37, 1, Artist.Silver_Saaremael);
            addQuest("The Trial of Intuition", EncounterSet.TheThreeTrials, 2, 'A', null)
                .WithTextLine("When Revealed: Randomly choose 1 of the remaining set aside Guardian enemies and 1 of the remaining set aside Barrow locations, reveal them, and add them to the staging area. Shuffle the encounter discard pile into the encounter deck. Find the set aside Key objective that shares a Trait with the just revealed Guardian enemy and suffle it into the bottom 10 cards of the encounter deck.")
                .WithFlavorLine("You have found the barrow where the trial should take place, but the key cannot be found. You are sure the key's guardian is watching you... Where is the key?")
                .WithOppositeTextLine("Each Guardian enemy engages the first player. Any time players would place progress on this quest, discard an equal number of cards from the encounter deck instead. (Progress is placed on the active location before triggering this effect.)")
                .WithOppositeTextLine("When the players control the current trial's Key objective, add all Guardian enemies and Barrow locations in play to the victory display and immediately advance to a stage 2A of the players' choice. If all stage 2 quests have been defeated, advance to stage 3A, instead.")
                .WithIncludedEncounterSets(EncounterSet.AncientForest)
                .WithInfo(38, 1, Artist.Matt_Bradbury);
            addQuest("The Antlered Crown", EncounterSet.TheThreeTrials, 3, 'A', 1)
                .WithTextLine("When Revealed: Add Hallowed Circle to the staging area. Reveal each Guardian enemy in the victory display, adding them to the staging area.")
                .WithFlavorLine("You have finally completed the trials and recovered each key. None have made it this far before. You hasten to the hallowed circle in the center of the forest. All that's left is to insert the hilts of these swords into the marked stone the shaman described, and the Antlered Crown will be yours. As you advance, a thick fog gathers around you and growing dread tugs at your mind.")
                .WithOppositeTextLine("Each Guardian enemy engages the player who controls the Key objective with a Trait shared by that enemy.")
                .WithOppositeTextLine("Players cannot defeat this stage unless Hallowed Circle is in the victory display. If the players defeat this stage, they win the game.")
                .WithOppositeFlavorLine("Out of the fog, the angry guardian spirits emerge once more, determined to stop you from retrieving the crown. You desperately rush to the circle while fending them off.")
                .WithIncludedEncounterSets(EncounterSet.AncientForest)
                .WithInfo(39, 1, Artist.Claudio_Pozas);
            addEnemy("Boar's Guardian", EncounterSet.TheThreeTrials, 50, 1, 4, 4, 10)
                .WithUnique()
                .WithTraits("Guardian.", "Boar.")
                .WithKeywords("Time 2.")
                .WithTextLine("Cannot have non-Key attachments.")
                .WithTextLine("Time 2. Forced: After the last time counter is removed from Boar's Guardian, the engaged player must discard an ally he controls. Place 2 time counters on Boar's Guardian.")
                .WithVictoryPoints(3)
                .WithInfo(40, 1, Artist.Alexander_Kozachenko);
            addEnemy("Wolf's Guardian", EncounterSet.TheThreeTrials, 50, 2, 5, 3, 12)
                .WithUnique()
                .WithTraits("Guardian.", "Wolf.")
                .WithKeywords("Time 3.")
                .WithTextLine("Cannot have non-Key attachments.")
                .WithTextLine("Time 3. Forced: After the last time counter is removed from Wolf's Guardian, it makes an immediate attack against the engaged player. Place 3 time counters on Wolf's Guardian.")
                .WithVictoryPoints(3)
                .WithInfo(41, 1, Artist.Darek_Zabrocki);
            addEnemy("Raven's Guardian", EncounterSet.TheThreeTrials, 50, 3, 3, 5, 8)
                .WithUnique()
                .WithTraits("Guardian.", "Raven.")
                .WithKeywords("Time 4.")
                .WithTextLine("Cannot have non-Key attachments.")
                .WithTextLine("Time 4. Forced: After the last time counter is removed from Raven's Guardian, deal 1 damage to each character controlled by the engaged player. Place 4 time counters on Raven's Guardian.")
                .WithVictoryPoints(3)
                .WithInfo(42, 1, Artist.Darek_Zabrocki);
            addObjective("Key of the Boar", EncounterSet.TheThreeTrials)
                .WithUnique()
                .WithTraits("Item.", "Key.", "Boar.")
                .WithTextLine("If unattached, the first player must claim Key of the Boar and attach it to a hero he controls.")
                .WithTextLine("If Key of the Boar is discarded, add it to the staging area.")
                .WithShadow("Shadow: Shuffle Key of the Boar back into the encounter deck.")
                .WithInfo(43, 1, Artist.Ellyson_Ferrari_Lifante);
            addObjective("Key of the Wolf", EncounterSet.TheThreeTrials)
                .WithUnique()
                .WithTraits("Item.", "Key.", "Wolf.")
                .WithTextLine("If unattached, the first player must claim Key of the Wolf and attach it to a hero he controls.")
                .WithTextLine("If Key of the Wolf is discarded, add it to the staging area.")
                .WithShadow("Shadow: Shuffle Key of the Wolf back into the encounter deck.")
                .WithInfo(44, 1, Artist.Ellyson_Ferrari_Lifante);
            addObjective("Key of the Raven", EncounterSet.TheThreeTrials)
                .WithUnique()
                .WithTraits("Item.", "Key.", "Raven.")
                .WithTextLine("If unattached, the first player must claim Key of the Raven and attach it to a hero he controls.")
                .WithTextLine("If Key of the Raven is discarded, add it to the staging area.")
                .WithShadow("Shadow: Shuffle Key of the Raven back into the encounter deck.")
                .WithInfo(45, 1, Artist.Ellyson_Ferrari_Lifante);
            addLocation("Hill Barrow", EncounterSet.TheThreeTrials, 4, 6)
                .WithTraits("Barrow.", "Forest.", "Hills.")
                .WithTextLine("Forced: When a Guardian enemy attacks, deal it 1 additional shadow card.")
                .WithFlavorLine("They heard of the Great Barrows, and the green mounds, and the stone-rings upon the hills and in the hollows among the hills. -The Fellowship of the Ring")
                .WithVictoryPoints(2)
                .WithInfo(46, 1, Artist.Jose_Vega);
            addLocation("Cave Barrow", EncounterSet.TheThreeTrials, 3, 8)
                .WithTraits("Barrow.", "Forest.", "Hills.")
                .WithTextLine("The players, as a group, cannot have more than 5 allies in play. (If there are more than 5 allies in play, discard allies until only 5 remain.)")
                .WithFlavorLine("Raising himself on one arm he looked, and saw now in the pale light that they were in a kind of passage which behind them turned a corner. -The Fellowship of the Ring")
                .WithInfo(47, 1, Artist.Jose_Vega);
            addLocation("Stone Barrow", EncounterSet.TheThreeTrials, 2, 10)
                .WithTraits("Barrow.", "Forest.", "Hills.")
                .WithTextLine("Forced: After a Guardian enemy attacks, raise each player's threat by X, where X is that enemy's Threat.")
                .WithFlavorLine("Stone rings grinned out of the ground like broken teeth in the moonlight. -The Fellowship of the Ring")
                .WithVictoryPoints(2)
                .WithInfo(48, 1, Artist.Jose_Vega);
            addLocation("Hallowed Circle", EncounterSet.TheThreeTrials, Card.VALUE_X, 12)
                .WithUnique()
                .WithTraits("Forest.", "Hills.")
                .WithTextLine("Immune to player card effects. X is the number of players in the game.")
                .WithTextLine("Travel: The players must exhaust 3 Key objectives.")
                .WithTextLine("Forced: After the players travel here, each engaged Guardian enemy makes an immediate attack.")
                .WithVictoryPoints(5)
                .WithInfo(49, 1, Artist.Jose_Vega);
            addEnemy("Spirit of the Wild", EncounterSet.TheThreeTrials, 28, 1, 1, 2, 4)
                .WithTraits("Undead.", "Spirit.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Spirit of the Wild gets +1 Threat and +1 Attack for each Key objectives the players control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each Key objective the players control.")
                .WithEasyModeQuantity(4)
                .WithInfo(50, 5, Artist.Alexander_Kozachenko);
            addLocation("Cursed Forest", EncounterSet.TheThreeTrials, 3, 3)
                .WithTraits("Forest.")
                .WithTextLine("Travel: Search the encounter deck and discard pile for a Spirit enemy and add it to the staging area.")
                .WithShadow("Shadow: If this attack destroys a character, remove a time counter from an enemy, if able.")
                .WithInfo(51, 2, Artist.Anthony_Feliciano);
            addLocation("Grim Foothills", EncounterSet.TheThreeTrials, Card.VALUE_X, 3)
                .WithTraits("Hills.")
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("X is the number of players in the game.")
                .WithTextLine("While Grim Foothills is in the staging area, progress must be placed on Grim Foothills before it can be placed on the active location.")
                .WithEasyModeQuantity(2)
                .WithInfo(52, 3, Artist.Michael_Rasmussen);
            addTreachery("Curse of the Wild Men", EncounterSet.TheThreeTrials)
                .WithTextLine("When Revealed: Deal 1 damage to each non-unique character in play. If the players control 3 Key objectives, Curse of the Wild Men gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 AQttack for each Key objective the players control.")
                .WithEasyModeQuantity(1)
                .WithInfo(53, 2, Artist.Jason_Ward);
            addTreachery("The Guardian's Fury", EncounterSet.TheThreeTrials)
                .WithTextLine("When Revealed: Each Guardian enemy makes an attack. If there are no Guardian enemies in play, reveal a random Guardian enemy from the victory display, and add it to the staging area.")
                .WithShadow("If the attacking enemy is a Guardian, it makes an additional attack after this one.")
                .WithEasyModeQuantity(0)
                .WithInfo(54, 2, Artist.Darek_Zabrocki);
            addTreachery("Wild Tenacity", EncounterSet.TheThreeTrials)
                .WithTextLine("When Revealed: Remove X time counters from each enemy in play with the time keyword, where X is the number of players.")
                .WithShadow("Shadow: If attacking enemy is a Guardian, deal it 2 additional shadow cards for this attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(55, 3, Artist.Darek_Zabrocki);
        }
    }
}
