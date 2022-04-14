using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.ScenarioPack
{
    public class TheDarkOfMirkwoodSet
        : CardSet
    {
        public const string setName = "The Dark of Mirkwood";
        public const string setOath = "The Oath (Campaign)";
        public const string setGoblins = "The Goblins (Campaign)";
        public const string setCaves = "The Caves of Nibin-Dûm (Campaign)";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TDoM";
            SetType = Models.SetType.Scenario_Pack;
            Cycle = "Scenario Pack";
            Number = 4002;

            addQuest("After the Raid", setOath, 1, 'A', 9)
                .WithFlavor("Marauding Goblins have raided a woodman village on the eaves of Mirkwood forest. The Goblins killed the guards and took many of the villages captive. Those left behind beg you to rescue their loved ones.")
                .WithText("Setup: ~Search the encounter deck for 1 copy of The Eaves of ~Mirkwood and ~Goblin Troop. Add The Eaves of ~Mirkwood to the staging area and set ~Goblin Troop aside, out of play. Shuffle of the encounter deck.")
                .WithOppositeFlavor("You swear an oath to the survivors that you will rescue the captured woodmen and bring justice to the Goblins who attacked them, then you enter Mirkwood forest to find their trail.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblinsCampaign)
                .WithInfo(1, 1, Artist.Stanislav_Dikolenko);
            addQuest("Mirkwood Forest", setOath, 2, 'A', 12)
                .WithFlavor("The Goblins' trail leads you deeper into the dark forest of Mirkwood. The enemy has a significant lead, but the sign of their passing is easy to follow. You may yet overtake them if you press on.")
                .WithOppositeText("When Revealed: Each player searches the encounter deck and discard pile for a Forest location and adds it to the staging area. Shuffle the encounter deck. This stage cannot be defeated unless at least 1 copy of ~Goblin Trail is in the vitory display.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblinsCampaign)
                .WithInfo(2, 1, Artist.Jeff_Lee_Johnson);
            addQuest("The Rearguard", setOath, 3, 'A', 6)
                .WithText("When Revealed: The first player adds the set-aside ~Goblin Troop to the staging area. Each other player searches the encounter deck and discard pile for a Goblin enemy and adds it to the staging area.")
                .WithOppositeFlavor("The Goblins are aware of your pursuit and form a rearguard to confront you while the others retreat to their secret hideaway. You must defeat this troop before you can continue your chanse.")
                .WithOppositeText("This stage cannot be defeated while Goblin Troop is in play. When this stage is defeated, the heroes discover the trail to the Goblins' secret lair and the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblinsCampaign)
                .WithInfo(3, 1, Artist.Stanislav_Dikolenko);
            addQuest("The Dark of Nibin-Dûm", setCaves, 1, 'A', 8)
                .WithFlavor("You have pursued the Goblins that attacked a woodman village to the mountains of Mirkwood. The trail leads over a steep ridge where you discover the forgotten Dwarf home of Nibin-Dûm. You light a torch and enter in.")
                .WithText("Setup: ~Search the encounter deck for ~Goblin ~Chieftain, Cracked Pillar, and ~Cave ~Torch. Set ~Goblin ~Chieftain and Cracked Pillar aside, out of play. The first player attached ~Cave ~Torch to one of his heroes. Shuffle the encounter deck.")
                .WithOppositeFlavor("The Dwarves abandonded Nibin-Dûm after an earthquake collapsed part of the mine, but it seems these Goblins have since adopted it as their home. The flickering light of your torch reveals a network of dark passages and you set about searching for signs of the enemy.")
                .WithOppositeText("When Revealed: Each player searches the encounter deck for a different location and adds it to the staging area. Shuffle the encounter deck.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblinsCampaign)
                .WithInfo(4, 1, Artist.Jason_Jenicke);
            addQuest("Surprise Attack", setCaves, 2, 'A', 0)
                .WithFlavor("As you search the caves of Nibin-Dûm you are ambushed by Goblins!")
                .WithText("When Revealed: Add ~Goblin Chieftain to the staging area. Each player searches the encounter deck and discard pile for a different enemy of his choice and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("The Goblins are led by a large chieftain who whips them into a frenzy. His soldiers attack you with reckless savagery and you struggle to gain the upper hand.")
                .WithOppositeText("During the encounter phase, treat each enemy's engagement cost as if it were 0.\r\nThe stage gets +4 quest points for each enemy in play.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblinsCampaign)
                .WithInfo(5, 1, Artist.Stanislav_Dikolenko);
            addQuest("The Chasm", setCaves, 3, 'A', Card.VALUE_NA)
                .WithFlavor("The Goblins retreat down a dark tunnel, and you chase them into a large hall of many pillars. A wide chasm runs the width of the hall and the Goblins race across on a large plank. Their chieftain casts the plan into the depths of the chasm and disappeats, leaving you stranded on the other side.")
                .WithText("When Revealed: Set ~Goblin ~Chieftain aside, out of play. Add Cracked Pillar to the staging area.")
                .WithOppositeFlavor("As you search for a way across, you see that one tall pillar near the edge of the chasm has cracked where it meets the ceiling. If you topple the pillar, it could serve to bridge the gap.")
                .WithOppositeText("Forced: Reveal an additional encounter card during the quest phase.\r\nProgress cannot be placed on Cracked Pillar while it is in the staging area.\r\nAfter Cracked Pillar leaves play as an explored location, advance to stage 4A.")
                .WithIncludedEncounterSets(EncounterSet.TheGoblinsCampaign)
                .WithInfo(6, 1, Artist.Stanislav_Dikolenko);
            addQuest("Oathkeepers", setCaves, 4, 'A', 8)
                .WithFlavor("You've made it across the chasm and resumed the chase. The Goblins rally around their chieftain outside the dungeons where the woodmen villagers are being held. You must defeat the big Goblin if you are to fulfill your oath and rescue the captives.")
                .WithText("When Revealed: Add ~Goblin ~Chieftain to the staging area.")
                .WithOppositeText("While there are at least 8 progress tokens on this stage, ~Goblin ~Chieftain loses the text: \"Cannot take damage.\"\r\nThis stage cannot be defeated while ~Goblin ~Chieftain is in play. When this stage is defeated, the heroes rescue the captives, fulfilling their oaths, and the players win the game!")
                .WithIncludedEncounterSets(EncounterSet.TheGoblinsCampaign)
                .WithInfo(7, 1, Artist.Alexander_Kozachenko);

            addEnemy("Spiders of Mirkwood", setOath, 18, 3, 2, 2, 4)
                .WithTraits("Spider.")
                .WithText("While it is engaged with you, Spiders of Mirkwood gets +1 Attack for each exhausted character you control.")
                .WithShadow("Shadow: Choose and exhaust 1 character you control. If this attack was undefended, also deal that character 2 damage.")
                .WithEasyModeQuantity(0)
                .WithInfo(8, 2, Artist.Andrew_Ryan);
            addEnemy("Great Spider", setOath, 34, 2, 3, 1, 3)
                .WithTraits("Spider.")
                .WithText("Forced: After Gret Spider engages you, exhaust a character you control.")
                .WithShadow("Shadow: Deal 1 damage to an exhausted character you control.")
                .WithInfo(9, 2, Artist.Matt_Stewart);
            addLocation("The Eaves of Mirkwood", setOath, 2, 2)
                .WithTraits("Forest.")
                .WithText("While The Eaves of Mirkwood is the active location, encounter card effects cannot be canceled.")
                .WithFlavor("By the afternoon they had reached the eaves of Mirkwood, and were resting almost beneath the great overhanging boughs of its outer trees.\r\n-The Hobbit")
                .WithInfo(10, 2, Artist.Timo_Karhula);
            addLocation("Tangled Grove", setOath, Card.VALUE_X, 3)
                .WithTraits("Forest.")
                .WithText("X is the number of locations in the staging area.\r\nTravel: Each player must discard 1 random card from his hand to travel here.")
                .WithEasyModeQuantity(0)
                .WithInfo(11, 2, Artist.John_Howe);
            addLocation("Forest Gate", setOath, 2, 4)
                .WithTraits("Forest.")
                .WithText("Response: After you travel to Forest Gate, the first player draws 2 cards.")
                .WithFlavor("Soon the light in the gate was like a little bright hole far behind, and the quiet was so deep that their feet seemed to thump along while the trees leaned over them and listened.\r\n-The Hobbit")
                .WithInfo(12, 2, Artist.Ben_Zweifel);
            addLocation("Spider Den", setOath, 4, 4)
                .WithTraits("Forest.")
                .WithText("Quest Action: Search the encounter deck and discard pile for a Spider enemy and put it into play engaged with you to discard Spider Den. (Any player may trigger this effect.)")
                .WithInfo(13, 2, Artist.Jokubas_Uoginitas);
            addLocation("Goblin Trail", setOath, 3, 6)
                .WithTraits("Forest.")
                .WithText("Travel: Reveal the top card of the encounter deck to travel here.\r\nResponse: When Goblin Trail leaves play as an explored location, place 6 progress on the current quest.")
                .WithVictoryPoints(3)
                .WithInfo(14, 2, Artist.Jokubas_Uoginitas);
            addLocation("Abandoned Camp", setOath, 2, 3)
                .WithTraits("Forest.")
                .WithTextLine("Response: After the players travel to Abandoned Camp, the first player discards the top card of their deck, If that card is any ally, put it into play under their control.")
                .WithTextLine("Travel: Discard the top card of the encounter deck. If that card is an enemy, add it to the staging area.")
                .WithInfo(15, 1, Artist.Dana_Li);
            addTreachery("Driven by Shadow", setOath)
                .WithText("When Revealed: Each enemy and each location currently in the staging area gets +1 Threat until the end of the phase. If there are no cards in the staging area, Driven by Shadow gains surge.")
                .WithShadow("Shadow: Choose and discard 1 attachment from the defending character. (If this attack is undefended, discard all attachments you control.)")
                .WithInfo(16, 2, Artist.Alexandru_Sabo);
            addTreachery("Surprising Speed", setOath)
                .WithText("When Revealed: Each player returns 1 enemy engaged with him to the staging area. If no enemy was returned to the staging area this way, Surprising Speed gains surge and doomed 1.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. Return attacking enemy to the staging area after this attack.")
                .WithInfo(17, 2, Artist.Matthew_Cowdery);
            addTreachery("Caught in a Web", setOath)
                .WithText("When Revealed: The player with the highest threat level attached this card to one of his heroes. (Counts as a Condition attachment with the text: \"Attached hero does not ready during the refresh phase unless you pay 2 resources from that hero's pool.\")")
                .WithEasyModeQuantity(0)
                .WithInfo(18, 1, Artist.Daryl_Mandryk);

            addEnemy("Goblin Troop", setGoblins, 35, 3, 5, 3, 6)
                .WithTraits("Goblin.", "Orc.")
                .WithText("Cannot have attachments.\r\nWhile Goblin Troop is engaged with you, each other Goblin enemy engaged with you gets +1 Attack and +1 Defense.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithInfo(19, 1, Artist.Matt_Stewart);
            addEnemy("Goblin Sniper", setGoblins, 48, 2, 2, 0, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithText("During the encounter phase, players cannot optionally engage Goblin Sniper if there are other enemies in the staging area.\r\nForced: If Goblin Sniper is in the staging area at the end of the combat phase, each player deals 1 point of damage to 1 character he controls.")
                .WithInfo(20, 2, Artist.Alexandr_Shaldin);
            addEnemy("Goblin Runners", setGoblins, 20, 1, 3, 1, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithFlavor("Shadow: Attacking enemy makes an additional attack immediately after this one. (Deal a new shadow card for that attack.)")
                .WithEasyModeQuantity(0)
                .WithInfo(21, 2, Artist.Stephane_Gantiez);
            addEnemy("Goblintown Scavengers", setGoblins, 12, 1, 1, 0, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithText("When Revealed: Discard the top card of each player's deck. Until the end of the phase, increase Goblintown Savengers' Threat by the total printed cost of all cards discarded in this way.")
                .WithInfo(22, 2, Artist.Jarreau_Wimberly);
            addEnemy("Wild Wargs", setGoblins, 28, 2, 2, 1, 3)
                .WithTraits("Creature.", "Warg.")
                .WithTextLine("Forced: After Wild Wargs engages you, discard the top card of the encounter deck. If that card is a Goblin enemy, put it into play engaged with you.")
                .WithFlavor("\"Where the Warg howls, there the Orc prowls.\"")
                .WithInfo(23, 1, Artist.Piya_Wannachaiwong);
            addTreachery("Goblins are Upon You!", setGoblins)
                .WithText("When Revealed: Each player must search the encounter deck and discard pile for a Goblin enemy and put it into play, engaged with him. Then, shuffle the encounter deck. (This effect cannot be canceled.)")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each Goblin enemy engaged with you.")
                .WithEasyModeQuantity(0)
                .WithInfo(24, 1, Artist.Diego_Gisbert_Llorens);
            addTreachery("Eyes in the Dark", setGoblins)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player must choose: Either raise your threat by 1 for each questing character you control, or discard a questing character you control.")
                .WithShadow("Shadow: If this attack is undefended, discard an ally you control.")
                .WithInfo(25, 2, Artist.Sam_Lamont);
            addTreachery("Obsidian Arrows", setGoblins)
                .WithTextLine("When Revealed: Deal 2 damage to a character you control.")
                .WithShadow("Shadow: Deal 1 damage to a character you control.")
                .WithInfo(26, 2, Artist.Aurelien_Hubert);

            addEnemy("Goblin Chieftain", setCaves, 40, Card.VALUE_X, Card.VALUE_X, Card.VALUE_X, 8)
                .WithUnique()
                .WithTraits("Goblin.", "Orc.")
                .WithText("X is the stage number of the quest.\r\nCannot take damage. Cannot have attachments.\r\nForced: After Goblin Chieftain attacks, either remove X progress from the quest, or return it to the staging area.")
                .WithInfo(27, 1, Artist.Alexander_Kozachenko);
            addLocation("Cracked Pillar", setCaves, 2, 2)
                .WithUnique()
                .WithTraits("Underground.")
                .WithText("While Cracked Pillar is in the staging area, it gains: \"The first player may declare an attack against Cracked Pillar during the combat phase as if it was an enemy engaged with him. Use Cracked Pillar's Threat as its Defense during this attack.\"\r\nTravel: Remove 4 damage from Cracked Pillar to travel here.")
                .WithInfo(28, 1, Artist.Leanna_Crossan);
            addObjective("Cave Torch", setCaves)
                .WithTraits("Light.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Action: Exhause Cave Torch to place up to 3 progress tokens on a Dark location.")
                .WithTextLine("Forced: After Cave Torch exhausts, discard the top card of the encounter deck. If that card is an enemy, add it to the staging area.")
                .WithInfo(29, 1, Artist.David_Lecossu);
            addEnemy("Great Cave-troll", setCaves, 36, 3, 6, 4, 6)
                .WithTraits("Troll.")
                .WithText("Cannot have attachments.\r\nFor each point of excess combat damage dealt by Great Cave-troll (damage that is dealt beyond the remaining hit points of the character damaged by its attack) remove 1 progress from the current quest.")
                .WithEasyModeQuantity(0)
                .WithInfo(30, 2, Artist.Nicholas_Gregory);
            addEnemy("Cavern Warg", setCaves, 33, 2, 3, 2, 3)
                .WithTraits("Creature.", "Warg.")
                .WithText("Response: When Cavern Warg attacks you, exhaust Cave Torch to cancel the attack and return Cavern Warg to the staging area.")
                .WithShadow("Shadow: If this attack destroys a character, return attacking enemy to the staging area after this attack.")
                .WithInfo(31, 2, Artist.Stanislav_Dikolenko);
            addLocation("Goblin Tunnels", setCaves, 2, 7)
                .WithTraits("Underground.", "Dark.")
                .WithText("While Goblin Tunnels is in the staging area, it gains: \"Forced: After a Goblin is revealed from the encounter deck, remove a progress token from the current quest card.\"")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. (+3 Attack instead if attacking enemy is a Goblin.)")
                .WithInfo(32, 2, Artist.Michael_Rasmussen);
            addLocation("Lightless Passage", setCaves, 4, 4)
                .WithTraits("Underground.", "Dark.")
                .WithText("Travel: Players must exhaust a Cave Torch to travel here.")
                .WithShadow("Shadow: Cancel all combat damage dealt to attacking enemy.")
                .WithInfo(33, 2, Artist.Stu_Barnes);
            addLocation("Branching Paths", setCaves, 1, 3)
                .WithTraits("Underground.", "Dark.")
                .WithText("While Branching Paths is in the staging area, each Dark location gets +1 Threat.\r\nForced: After Branching Paths leaves play as an explored location, look at the top 3 cards of the encounter deck. Players must choose 1 of those to reveal and add to the staging area, moving the other 2 to the bottom of the deck.")
                .WithEasyModeQuantity(0)
                .WithInfo(34, 2, Artist.David_A_Nash);
            addLocation("Collapsed Mine", setCaves, 2, 6)
                .WithTraits("Underground.", "Dark.")
                .WithText("While Collapsed Mine is in the staging area, no more than 4 progress can be placed on the quest each round.")
                .WithShadow("Shadow: Raise your threat by 1 for each point of damage dealt by this attack.")
                .WithInfo(35, 2, Artist.Leanna_Crossan);
            addLocation("Goblin Dungeon", setCaves, 3, 5)
                .WithTraits("Underground.")
                .WithText("Travel: Reveal the top card of the encounter deck to travel here.\r\nResponse: After Goblin Dungeon leaves play as an explored location, the first player searches the top 5 cards of his deck for an ally and puts it into play under his control. Shuffle the rest of the searched cards back into his deck.")
                .WithInfo(36, 2, Artist.Leanna_Crossan);
            addLocation("Crumbling Stairs", setCaves, 3, 3)
                .WithTraits("Underground.")
                .WithTextLine("While Crumbling Stairs is in the staging area, progress cannot be placed on it.")
                .WithTextLine("Forced: When Crumbling Stairs leaves play as an explored location, discard the top card of the encounter deck. If the discarded card is a location, put it into play as the active location.")
                .WithInfo(37, 1, Artist.Alyn_Spiller);
            addTreachery("Crumbling Ruin", setCaves)
                .WithText("When Revealed: Each player must exhaust a character and discard the top card of his deck, if able. If the printed cost of the discarded card is equal to or higher than the remaining hit points of the exhausted character, discard the exhausted character.")
                .WithInfo(38, 2, Artist.Magali_Villeneuve);
            addTreachery("Lost in the Dark", setCaves)
                .WithText("When Revealed: The player who controls Cave Torch must choose: Either exhaust Cave Torch, or progress cannot be placed on the quest until the end of the phase. (Progress can still be placed on the active location.)")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(39, 2, Artist.Nicholas_Gregory);
            addTreachery("Watchful Eyes", setCaves)
                .WithText("When Revealed: The first player attaches Watchful Eyes to one of his heroes. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Forced: If attached hero is exhausted at the end of the combat phase, reveal 1 card from the encounter deck and add it to the staging area.\")")
                .WithEasyModeQuantity(0)
                .WithInfo(40, 1, Artist.Tiziano_Baracchi);
            addEnemy("Stalking Goblin", setOath, 10, 2, 2, 2, 2)
                .WithBurden()
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Forced: After Stalking Goblin engages you, search the encounter deck, discard pile, and your collection (in that order) for a Goblin Sniper and add it to the staging area. Shuffle the encounter deck.")
                .WithShadow("Shadow: Add Stalking Goblin to the staging area.")
                .WithInfo(41, 1, Artist.JB_Casacop);
            addTreachery("Shiny Distraction", setCaves)
                .WithBurden()
                .WithTraits("Treasure.")
                .WithKeywords("Surge.", "Doomed 1.")
                .WithTextLine("When Revealed: Each player may add 1 resource to each of their heroes' pools. Each player that does raises their threat by 5.")
                .WithInfo(42, 1, Artist.Andreas_Zafiratos);
            addTreachery("Guilty Conscience", setCaves)
                .WithBurden()
                .WithKeywords("Surge.")
                .WithTextLine("When Revealed: Attach to the hero with the highest threat cost. (Counts as an Adaptation attachment with the text: \"Forced: Raise your threat by 2 at the end of the round. Action: Spend 2 resources from attached hero's pool to discard this card.\")")
                .WithInfo(43, 1, Artist.Lin_Hsiang);
            addAttachment("The Fervor of Lore", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Adaptation.")
                .WithKeywords("Setup.")
                .WithTextLine("Setup. Attach to a hero.")
                .WithTextLine("Attached hero gains the Lore resource icon.")
                .WithTextLine("Action: Choose and discard 3 cards from your hand to heal all damage from a hero. (Limit once per campaign. Record in the Campaign Log when used.)")
                .WithInfo(44, 1, Artist.Drazenka_Kimpel);
            addAttachment("The Might of Tactics", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Adaptation.")
                .WithKeywords("Setup.")
                .WithTextLine("Setup. Attach to a hero.")
                .WithTextLine("Attached hero gains the Tactics resource icon.")
                .WithTextLine("Action: Deal 1 damage to the attached hero to deal 3 damage to an enemy engaged with you. (Limit once per campaign. Record in the Campaign Log when used.)")
                .WithInfo(45, 1, Artist.JB_Casacop);
            addAttachment("The Power of Spirit", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Adaptation.")
                .WithKeywords("Setup.")
                .WithTextLine("Setup. Attach to a hero.")
                .WithTextLine("Attached hero gains the Spirit resource icon.")
                .WithTextLine("Action: Exhaust the attached hero to place 3 progress on a location. (Limit once per campaign. Record in Campaign Log when used.)")
                .WithInfo(46, 1, Artist.Drazenka_Kimpel);
            addAttachment("The Secret of Leadership", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Adaptation.")
                .WithKeywords("Setup.")
                .WithTextLine("Setup. Attach to a hero.")
                .WithTextLine("Attached hero gains the Leadership resource icon.")
                .WithTextLine("Action: Spend 1 resource the attached hero's recource pool to ready a hero. (Limit once per campaign. Record in Campaign Log when used.)")
                .WithInfo(47, 1, Artist.Borja_Pindado);
            addEvent("No Time to Waste!", 0, Sphere.Neutral)
                .WithBoon()
                .WithTextLine("When playing this card, choose one:")
                .WithTextLine("Quest Action: Remove \"No Time to Waste!\" from the game and from the Campaign Pool to reduce each player's threat by 3. Reveal the top card of the encounter deck.")
                .WithTextLine("Quest Action: Draw 1 card.")
                .WithInfo(48, 4, Artist.Borja_Pindado);
            addEvent("Ranger Sense", 0, Sphere.Neutral)
                .WithBoon()
                .WithTextLine("When playing this card, choose one:")
                .WithTextLine("Action: Remove Ranger Sense from the game and from the Campaign Pool to look at the top 4 cards of your deck. Add 1 to your hand and put the rest back in any order.")
                .WithTextLine("Action: Draw 1 card.")
                .WithInfo(49, 4, Artist.Andreas_Zafiratos);
            addCampaign("The Oath", setOath, "Mirkwood Paths")
                .WithTextLine("You are playing Campaign Mode.")
                .WithTextLine("Setup: Each player chooses 1 Adaptation boon attachment and attaches it to one of their heroes. Shuffle the Stalking Goblin burden enemy into the encounter deck. Add Stalking Goblin and each attached Adaptation to the Campaign Pool.")
                .WithTextLine("Forced: At the end of each round, place 1 resource token here.")
                .WithOppositeTextLine("Resolution: If there are 6 or more resource tokens here, the thought of the captured villagers suffering weighs heavily on you. Add the Guilty Conscience treachery burden to the Campaign Pool.")
                .WithOppositeFlavorLine("You have defeated the enemy rearguard, but the rest have escaped into the Mountains of Mirkwood with their prisoners. You must track the goblins to their hold if you are to fulfill your oath.")
                .WithInfo(50, 1, Artist.Stanislav_Dikolenko);
            addCampaign("The Caves of Nibin-Dûm", setCaves, "Mirkwood Paths")
                .WithTextLine("You are playing Campaign Mode.")
                .WithTextLine("Setup: Each player adds a copy of the \"No Time to Waste!\" boon to their hand after drawing their starting hand (including taking a mulligan). Add each copy of \"No Time to Waste!\" in a player's hand to the Campaign Pool. Shuffle the Shiny Distraction burden into the encounter deck and add it to the Campaign Pool.")
                .WithFlavorLine("That, of course, is the dangerous part about caves: you don't know how far they go back...")
                .WithFlavorLine("-The Hobbit")
                .WithOppositeTextLine("Resolution: Check the final threat of the player with the highest threat: If it is under 40, you have rescued a retired Ranger who shares his wisdom with you. Each player may add 1 copy of Ranger Sense to their deck and to the Campaign Pool. At the start of your next campaign, each player may also shuffle 1 copy of Ranger Sense into their deck and add it to the Campaign Pool.")
                .WithOppositeFlavorLine("You have rescued the captives and fulfilled your oath. What Goblins remain flee in terror of your wrath, and your return journey is untroubled. The villagers who survived thank you endlessly for returning them to their village. They invited you to stay and live among them in honor, but your allegiance is to other lords and many journeys still await you. After a good night's rest, you depart in the morning.")
                .WithInfo(51, 1, Artist.Jason_Jenicke);
        }
    }
}