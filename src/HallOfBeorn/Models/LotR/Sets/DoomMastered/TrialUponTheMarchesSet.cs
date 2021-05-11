using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models.LotR.Sets.DoomMastered
{
    public class TrialUponTheMarchesSet : CardSet
    {
        private const string setName = "Trial Upon the Marches";
        private const string cycleName = "Doom Mastered";

        protected override void addCard(LotRCard card)
        {
            card.WithAges(Age.First_Age);
            base.addCard(card);
        }

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TUtM";
            Number = 9002;
            SetType = Models.SetType.First_Age;
            Cycle = cycleName;

            addObjective("Deeds of Daring", setName)
                .WithTraits("Feat.")
                .WithTextLine("While Deeds of Darin is in the victory display, heroes gets +1 Attack when attacking alone.")
                .WithTextLine("Response: After the players complete the attached quest, add Deeds of Daring to the victory display.")
                .WithTextLine("Forced: After an ally is declared as a defender or attacker, remove Deeds of Daring from play if it is not in the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(188, 1, Artist.Alan_Lathwell);
            addObjective("Mighty in Arms", setName)
                .WithTraits("Feat.")
                .WithTextLine("While Mighty in Arms is in the victory display, each enemy gets -1 Defense.")
                .WithTextLine("Response: After a player deals more than 5 damage to an enemy in a single round, add Mighty in Arms to the victory display.")
                .WithTextLine("Forced: After the players complete the attached quest, remove Mighty in Arms from play if it is not in the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(189, 1, Artist.Greg_Taylor);
            addEnemy("Orc Raiding Party", EncounterSet.TrialUponTheMarches, 40, 3, 5, 4, 8)
                .WithTraits("Orc.")
                .WithKeywords("Raid.")
                .WithTextLine("Raid. Cannot leave play unless destroyed.")
                .WithTextLine("While the current quest stage is Rescue the Settlement, Orc Raiding Party can only be engaged by quest card effects.")
                .WithFlavorLine("A few fought their way through and came to Brethil, but many were slain or captured; and the Orcs passed on to the homesteads, and sacked them and burned them.")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(190, 2, Artist.Han_Park);
            addEnemy("Orc Marauders", EncounterSet.TrialUponTheMarches, 28, 2, 3, 2, 5)
                .WithTraits("Orc.")
                .WithKeywords("Raid.")
                .WithTextLine("Raid.")
                .WithTextLine("While Orc Marauders is engaged with a player, that player cannot make optional engagements.")
                .WithShadow("Shadow: Return a different enemy engaged with the defending player to the staging area.")
                .WithInfo(191, 2, Artist.Alexander_Nanitchkov);
            addEnemy("Colossal Orc", EncounterSet.TrialUponTheMarches, 35, 1, 4, 2, 6)
                .WithTraits("Orc.")
                .WithKeywords("Raid.")
                .WithTextLine("Raid.")
                .WithTextLine("Colossal Orc gets +1 Threat for each damage token on him.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if the attacking enemy has at least 1 damage token.)")
                .WithInfo(192, 1, Artist.Anssiart);
            addEnemy("Orc Archer", EncounterSet.TrialUponTheMarches, 45, 2, 2, 2, 3)
                .WithTraits("Orc.")
                .WithKeywords("Archery 2.")
                .WithTextLine("Archery 2.")
                .WithTextLine("Forced: When resolving the archery keyword on this card, discard the top 2 cards of the first player's deck.")
                .WithShadow("Shadow: If this attack deals damage, discard the top 2 cards of the first player's deck.")
                .WithInfo(193, 2, Artist.Alexandr_Sumerky);
            addEnemy("Orc Follower", EncounterSet.TrialUponTheMarches, 15, 2, null, null, 4)
                .WithTraits("Orc.")
                .WithKeywords("Raid.")
                .WithTextLine("Raid.")
                .WithTextLine("X is twice the number of enemies engaged with you.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. (+2 Attack instead if there is more than 1 enemy engaged with the defending player.)")
                .WithInfo(194, 2, Artist.Lius_Lasahido);
            addEnemy("Angband Assassin", EncounterSet.TrialUponTheMarches, 20, 2, 3, 2, 3)
                .WithTraits("Orc.")
                .WithKeywords("Raid.")
                .WithTextLine("Raid.")
                .WithTextLine("Forced: After Angband Assassin engages you, discard an ally you control, if able.")
                .WithShadow("Shadow: If the defending character is an ally, discard if after the attack resolves.")
                .WithInfo(195, 1, Artist.Alex_Ruiz);
            addEnemy("Azrat", EncounterSet.TrialUponTheMarches, 38, 3, 6, 4, 9)
                .WithUnique()
                .WithTraits("Orc.", "Veteran.")
                .WithKeywords("Raid.", "Relentless.")
                .WithTextLine("Raid. Relentless.")
                .WithTextLine("Forced: When Azrat is damaged by an attack, discard the top card of the attacking player's deck. Reduce the damage by the cost of the discarded card and deal that damage to one attacking character instead.")
                .WithInfo(196, 1, Artist.Aleksi_Briclot);
            addEnemy("Orc Burner", EncounterSet.TrialUponTheMarches, 30, 4, 3, 2, 4)
                .WithTraits("Orc.")
                .WithKeywords("Raid.")
                .WithTextLine("Raid.")
                .WithTextLine("Forced: After Orc Burner engages a player, discard the top card of that player's deck and deal X damage to characters controlled by that player. X is the cost of the discarded card.")
                .WithInfo(197, 2, Artist.Nathan_Rosario);
            addLocation("Hidden Grove", EncounterSet.TrialUponTheMarches, 2, 6)
                .WithTraits("Forest.")
                .WithTextLine("While Hidden Grove is the active location, the first player may declare one attack before enemy attacks are resolved.\r\nTravel: Trigger all raid keywords on cards in play as if it were the end of the round.")
                .WithInfo(198, 2, Artist.Unknown);
            addLocation("March Outpost", EncounterSet.TrialUponTheMarches, 3, 3)
                .WithTraits("Forest.", "Outpost.")
                .WithTextLine("While March Outpost is the active location, engaged enemies do not trigger the raid keyword.\r\nTravel: Each engaged enemy makes an immediate attack, if able.")
                .WithInfo(199, 2, Artist.Tyler_Edlin);
            addLocation("Raider Camp", EncounterSet.TrialUponTheMarches, 4, 2)
                .WithTraits("Forest.", "Camp.")
                .WithTextLine("Travel: Discard cards from the top of the encounter deck until X Orc enemies are discarded. X is the number of players. Add each enemy discarded this way to the staging area.\r\nResponse: After Raider Camp leaves play as the active location, each player may return 1 card from his discard pile to his hand.")
                .WithInfo(200, 2, Artist.Julia_Alekseeva);
            addLocation("Burning Abode", EncounterSet.TrialUponTheMarches, 3, 4)
                .WithTraits("Forest.", "Dwelling.")
                .WithTextLine("Forced: At the end of the round, each player must discard the top card of his deck. If the discarded card is an ally, deal 1 Corruption to a hero controlled by that player.")
                .WithFlavorLine("...and the Orcs passwed on to the homesteads, and sacked and burned them.")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(201, 1, Artist.Unknown);
            addLocation("March Road", EncounterSet.TrialUponTheMarches, 2, 5)
                .WithTraits("Forest.", "Road.")
                .WithTextLine("While March Road is in the staging area, enemies use their Attack instead of their Threat when the raid keyword triggers.")
                .WithInfo(202, 2, Artist.Felicks);
            addTreachery("Crooked Blades", EncounterSet.TrialUponTheMarches)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Deal 1 damage to all characters with at least 1 damage.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. (+3 Attack instead if the defending character has at least 1 damage.)")
                .WithInfo(203, 1, Artist.Sean_O_Daniels);
            addTreachery("Renewed Grief", EncounterSet.TrialUponTheMarches)
                .WithTextLine("When Revealed: The first player attaches Renewed Grief to a hero he controls. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Forced: At the beginning of each quest phase, either deal 1 Corruption to the attached hero or the attached hero gets -2 Willpower, -2 Attack and -2 Defense until the end of the round.\")")
                .WithInfo(204, 2, Artist.Martin_Pastyrik);
            addTreachery("An Ill Fate", EncounterSet.TrialUponTheMarches)
                .WithTextLine("When Revealed: Each player must discard an ally from his hand, if able, and discard X cards from the top of his deck. X is the cost of the discarded ally. If any player did not discard an ally, An Ill Fate gains surge.")
                .WithShadow("Shadow: If this attack destroys an ally, discard the top X cards of the defending player's deck. X is the cost of that ally.")
                .WithInfo(205, 1, Artist.Katerina_Konstantinoudi);
            addTreachery("Mirth of Morgoth", EncounterSet.TrialUponTheMarches)
                .WithTextLine("When Revealed: Remove a hero from the quest and place that hero in the staging area. Each enemy in the staging area makes an attack against that hero during the combat phase. That hero can only declare attack and defend against enemies in the staging area. This effect lasts until the end of the round.")
                .WithInfo(206, 2, Artist.Sergey_Musin);
            addTreachery("Orcish Mischief", EncounterSet.TrialUponTheMarches)
                .WithTextLine("When Revealed: Each player must discard an attachment from his hand. Orc enemies gets +X Attack until the end of the round. X is the attachment with the highest cost discarded in this way. If any player did not discard an attachment, Orcish Mischief gains surge.")
                .WithInfo(207, 2, Artist.Marius_Bota);
            addTreachery("Orc Infiltration", EncounterSet.TrialUponTheMarches)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Shuffle the enemy in play with the lowest Threat into the first player's deck. When that enemy is revealed, discarded, or drawn, it engages the first player and makes an immediate attack.")
                .WithFlavorLine("Suddenly a watchman gave a call, and leaping up they saw three hooded shapes, grey-clad, going stealthy among the stones.")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(208, 2, Artist.John_Howe);
            addObjective("Not So High Is Your Destiny", EncounterSet.TrialUponTheMarches)
                .WithBurden()
                .WithTraits("Doom.")
                .WithTextLine("Setup: Add Not So High Is Your Destiny to the staging area. Each player must place 1 Corruption on the hero with the lowest Willpower he controls. The player who controls the hero with Curse of Morgoth attached must place 1 Corruption on that hero instead.")
                .WithFlavorLine("\"But you are overbold to speak so to the father of Lúthien. Not so high is your destiny, I think...\"")
                .WithFlavorLine("-Melian, The Children of Húrin")
                .WithInfo(209, 1, Artist.Elena_Kukanova);
            addAttachment("Greatness is in You", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Doom.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to the hero with Curse of Morgoth attached.")
                .WithTextLine("Action: Add Greatness Is In You to the victory display to ready the attached hero. That hero does not exhaust to attack or defend until the end of the round.")
                .WithInfo(210, 1, Artist.Jason_Yong_Wee_Seng);
            addTreachery("For Good Or For Ill", EncounterSet.TrialUponTheMarches)
                .WithBurden()
                .WithTraits("Doom.")
                .WithKeywords("Surge.", "Doomed 4.")
                .WithTextLine("Surge. Doomed 4.")
                .WithTextLine("Setup: Shuffle For Good Or For Ill into the encounter deck.")
                .WithTextLine("When Revealed: If there are no Corruption tokens on the hero with Curse of Morgoth attached, cancel the effects of all keywords on this card. Otherwise, resolve keywords as normal.")
                .WithFlavorLine("\"...your fate is twined with that of the Elven-folk, for good or for ill. Beware of yourself, lest it be ill.\"")
                .WithFlavorLine("-Melian, The Children of Húrin")
                .WithInfo(211, 1, Artist.Neerachar_Sophol);
            addQuest("Preparing for Battle", EncounterSet.TrialUponTheMarches, 1, 'A', Card.VALUE_NA)
                .WithFlavorLine("While the Girdle of Melian has long protected Doriath, the marches are a contested region where the Elven-warriors of Thingol wage unceasing war against the Orcs of Morgoth. Since the disatrous Battle of Unnumbered Tears, the noose grows ever tighter. Every year, the Orcs grow more bold and seize upon any opportunity to waylay those who find themselves without guard or aid. Thingol has tasked you with joining the march-wardens of Doriath. It is here where you will prove your mettle by standing against those who would seek the destruction of Menegroth and all that is fair and light...")
                .WithOppositeTextLine("When Revealed: Set the Unscated, Deeds of Daring, and Mighty in Arms objectives aside, out of play. Set Azrat, Weapon of Morgoth, and all copies of Orc Raiding Party aside, out of play. Each player searches the top 10 cards of his deck for an attachment and places it faceup, if able. The first player chooses one faceup attachment and attaches it to an eligible hero. Shuffle all other faceup attachments back into their respective decks. Then, advance to a random stage 2A.")
                .WithInfo(212, 1, Artist.Unknown);
            addQuest("Repel the Incursion", EncounterSet.TrialUponTheMarches, 2, 'A', 14)
                .WithFlavorLine("A war party of Orcs is mounting a large assault on one of the main fortifications of the marches. You must repel their advance and prevent them from breaking through.")
                .WithTextLine("When Revealed: Choose one of the remaining set aside objectives and attach it to the quest. Discard cards from the top of th encounter deck until X enemies are discarded. X is equal to the number of players in the game. Add each enemy discarded this way to the staging area.")
                .WithTextLine("If there are no enemies in the staging area at the end of the quest phase, discard cards from the encounter deck until an enemy is discarded. Add that enemy to the staging area.")
                .WithTextLine("Forced: After the first player discards any number of cards from the raid keyword, place 1 damage on this stage. If there are 6 damage tokens on this stage, the players have lost the game.")
                .WithTextLine("While these is at least 1 enemy in play, the players cannot defeat this stage. When the players defeat this stage, remove it from play and advance to a random stage 2A. If only one stage 2 quest remains, adsvance to stage 3A, instead.")
                .WithInfo(213, 1, Artist.Unknown);
            addQuest("Rescue the Settlement", EncounterSet.TrialUponTheMarches, 2, 'A', 5)
                .WithFlavorLine("A band of Orcs has launched a raid against a settlement of Thingol's people on the edge of Doriath. You must rescue those who live there from a terrible fate of death or slavery.")
                .WithTextLine("When Revealed: Choose one of the remaining set aside objectives and attach it to the quest. Each player must add 1 copy of Orc Raiding Party to the staging area.")
                .WithOppositeTextLine("Encounter Action: Discard 5 progress tokens from this stage to engage 1 copy of Orc Raiding Party in the staging area.")
                .WithOppositeTextLine("Forced: After a player discards at least 1 ally from the raid keyword, deal 1 Corruption to  a hero controlled by that player.")
                .WithOppositeTextLine("While there is at least 1 Orc Raiding Party in play, the players cannot defeat this stage. If there are no copies of Orc Raiding Party in play, immediately remove this stage from play and advance to a random stage 2A. If only one stage 2 quest remains, advance to stage 3A, instead.")
                .WithInfo(214, 1, Artist.Unknown);
            addQuest("Destroy the War Engine", EncounterSet.TrialUponTheMarches, 2, 'A', Card.VALUE_NA)
                .WithFlavorLine("Scouts have reported that a huge engine of war has been brought down from Angband. This weapon could bring untold destruction to Doriath and the lands around. You must find this weapon and destroy it at all costs.")
                .WithTextLine("When Revealed: Choose one of the remaining set aside objectives and attach it to the quest. Add Weapon of Morgoth to the staging area.")
                .WithOppositeTextLine("Response: After the players quest successfully, Weapon of Morgoth gains the text: \"The first player may declare attacks against Weapon of Morgoth during the combat phase as if it were an enemy. When making attacks this way, treat its Threat as Defense. Limit 5 damage per round. When Weapon of Morgoth takes damage equal to or greater than its quest points, it is destroyed and removed from the game.\" This effect lasts until the end of the the round.")
                .WithOppositeTextLine("After Weapon of Morgoth is destroyed, advance to the next stahe. When the players defeat this stage, remove it from play and advance to a random stage 2A. If only one stage 2 quest remains, advance to stage 3A, instead.")
                .WithInfo(215, 1, Artist.Unknown); //Karl Kopinski
            addQuest("A Final Proving", EncounterSet.TrialUponTheMarches, 3, 'A', 15)
                .WithFlavorLine("The march-wardens speak of one Orc warrior with fear, a veteran of countless battles who has claimed many Elven lives over the years: Azrat. This orc has come to command a large band of Orcs and they have set their sights on eliminating the march-wardens once and for all...")
                .WithTextLine("When Revealed: Choose one of the remaining set aside objective and attach it to the quest. Add Azrat to the staging area. If there are fewer than X enemies in play, discard cards from the top of the encounter deck, add each enemy discarded this way to the staging area, until X enemies are in play. X is the number of players.")
                .WithOppositeFlavorLine("It appears your own reputation has grown among the Orcs just as Azrat's has among the Elves. The fearsome Orc seeks you out as the battle rages.")
                .WithOppositeTextLine("Forced: At the end of the round, discard X cards from the top of the encounter deck. X is the number of players in the game. Add each enemy discarded this way to the staging area.")
                .WithOppositeTextLine("While Azrat is in play, the players cannot defeat this stage. When the players defeat this stage, they have won the game.")
                .WithInfo(216, 1, Artist.Unknown); //Derk Venemann
            addScenario(setName, 1, cycleName)
                .WithTextLine("Raid")
                .WithTextLine("At the end of the round, if one or more encounter cards in the staging have the raid keyword, discard the top X cards from the first player's deck. X is equal to the highest threat among these encounter cards. When an enemy with the raid keyword is engaged with a player at the end of the round, that player must discard the top X cards of his deck. X is equal to the enemy's threat strength. If a player ever has 0 cards left in his deck, he is eliminated from the game.")
                .WithOppositeTextLine("Ransom")
                .WithOppositeTextLine("When a character with the Ransom keyword enters play, the player who controls it may discard a number of resources from the resource pools of heroes they control equal to the Ransom value. If they choose not to satisfy this requirement, then that player card loses the \"ally\" trait and gains the \"enemy\" trait, immediately engaging the player who played it. Its threat is equal to its willpower and its engagement cost is 0. If this enemy is defeated, remove all damage from it and return it to the player's control as an ally.")
                .WithOppositeTextLine("Relentless")
                .WithOppositeTextLine("An enemy with Relentless cannot have its attack canceled or be prevented from attacking ny any player card effect. It still can be targeted by other effects that do not specifically prevent attacks.")
                .WithInfo(216, 1, Artist.Unknown); //Karl Kopinski
            addCampaign(setName, EncounterSet.TrialUponTheMarches, cycleName)
                .WithTextLine("You are playing Campaign Mode.")
                .WithTextLine("Setup: The players have earned the Curse of Morgoth burden. Attach Curse of Morgoth and Greatness Is In You to a hero. Add Not So High Is Your Destiny to the staging area. Shuffle For Good or For Ill into the encounter deck.")
                .WithOppositeTextLine("Resolution: Add Curse of Morgoth to the campaign pool. If there are 3 or more victory points in the victory display, add Greatness Is In You to the campaign pool. If there are 0 victory points in the victory display, add Not So High If Your Destiny to the campaign pool. If there are 1 or 2 victory points in the victory display, add For Good or For Ill to the campaign pool. Victory points from player cards do not count for this purpose.")
                .WithInfo(217, 1, Artist.Unknown); //Derk Venneman
            addHero("Beleg Strongbow", 10, Sphere.Lore, 2, 3, 1, 5)
                .WithTraits("Teleri.", "Ranger.", "Scout.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Action: Remove a progress token from a location in play or the current quest stage to lower the cost of the next card your play from your hand this round by 1. (Limit once per round.)")
                .WithFlavorLine("...for he dwelt ever on the marches of Doriath, and he was the greatest woodsman of those days.")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(218, 1, Artist.Elena_Kukanova);
            addAlly("Outlaw Scout", 0, Sphere.Mastery, false, 0, 2, 1, 2)
                .WithTraits("Gaurwaith.", "Scout.")
                .WithKeywords("Ransom 2.")
                .WithTextLine("Action: Discard Outlaw Scout to look at the top 2 cards of the encounter deck. You may discard 1 of them.")
                .WithInfo(219, 3, Artist.Maria_Nikolopoulou);
            addAlly("Knight of the Sword", 2, Sphere.Tactics, false, 0, 2, 1, 2)
                .WithTraits("Teleri.", "Warrior.")
                .WithText("Knight of the Sword gets +1 Attack when attacking an enemy with an engagement cost lower than your threat.")
                .WithInfo(220, 3, Artist.Ali_Kasapoglu);
            addAlly("Doriath Messenger", 1, Sphere.Lore, false, 1, 0, 1, 1)
                .WithTraits("Teleri.")
                .WithTextLine("Action: Spend 1 Lore resource to give control of Doriath Messenger to another player. That player draws 1 card. (Limit once per round.)")
                .WithInfo(221, 3, Artist.Blake_Henriksen);
            addAlly("Household Guard", 3, Sphere.Leadership, false, 1, 2, 2, 2)
                .WithTraits("Edain.", "House of Hador.")
                .WithTextLine("While a character with the Noble trait is defending, Household Guard gains: \"Response: Deal 1 damage to Household Guard to cancel a shadow effect just triggered. (Limit one per game.)\"")
                .WithInfo(222, 3, Artist.Jake_Bullock);
            addAlly("Petty-dwarf Survivor", 0, Sphere.Mastery, false, 1, 0, 0, 1)
                .WithTraits("Dwarf.")
                .WithTextLine("Raise the cost to play Petty-dwarf Survivor by 1 for each Noldor hero you control.")
                .WithFlavorLine("Nonetheless, as all the Dwarf-kind, they were far stronger than their stature promised, and they could cling to life in great hardship.")
                .WithFlavorLine("-The Children of Húrin")
                .WithInfo(223, 3, Artist.Jerad_S_Marantz);
            addAttachment("Elven Training", 0, Sphere.Lore, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Attached hero gets +1 Attack for each resource token on Elven Training.")
                .WithTextLine("Planning Action: Exhaust attached hero and discard a card from your hand to add 1 resource token to Elven Training. (Limit once per round.)")
                .WithInfo(224, 3, Artist.Elena_Kukanova);
            addAttachment("Camp of the Faithful", 0, Sphere.Spirit, true)
                .WithTraits("Refuge.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Exhaust attached hero to attach Camp of the Faithful to a non-unique location in play. While attached to a location, Camp of the Faithful gains: \"Treat attached location's printed text box as blank, except for traits.\"")
                .WithInfo(225, 3, Artist.Neerachar_Sophol);
            addAttachment("Hardened", 0, Sphere.Mastery, false)
                .WithTraits("Condition.")
                .WithText("Attach to a hero with Corruption equal to his Willpower. Limit 1 per hero.")
                .WithTextLine("Corruption cannot be removed from attached hero.")
                .WithTextLine("Response: After a treachery resolves, exhaust Hardened to draw one card.")
                .WithInfo(226, 3, Artist.Thomas_Rouillard);
            addEvent("A Dangerous Man", 1, Sphere.Tactics)
                .WithTextLine("Action: Exhaust a hero you control to choose a non-unique enemy worth no victory points engaged with you. If the Attack of that enemy is lower than the Attack of the exhausted hero, add A Dangerous Man to the victory display to add that enemy to the victory display.")
                .WithFlavorLine("\"I am not a chicken-heart, as men know; but I am not your match\"")
                .WithFlavorLine("-Androg, The Children of Húrin")
                .WithVictoryPoints(1)
                .WithInfo(227, 3, Artist.Catherine_Karina_Chmiel);
            addObjective("Curse of Morgoth", EncounterSet.TrialUponTheMarches)
                .WithBurden()
                .WithTraits("Curse.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to a hero.")
                .WithTextLine("Forced: After the attached hero takes Corruption, discard the top card of the encounter deck. If it is a treachery card, the attached hero becomes corrupted until the end of the round.")
                .WithTextLine("If the attached hero leaves play, the players have lost the game.")
                .WithInfo(229, 1, Artist.Alan_Lee);
        }
    }
}
