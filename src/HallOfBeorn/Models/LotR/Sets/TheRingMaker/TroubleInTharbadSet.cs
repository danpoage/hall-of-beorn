/* Generated CardSet class: Trouble in Tharbad */

using System;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TroubleInTharbadSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Trouble in Tharbad";
            Abbreviation = "TiT";
            Number = 25;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";

            addHero("Haldir of Lórien", 9, Sphere.Lore, 2, 3, 1, 3)
                .WithTraits("Silvan.", "Ranger.", "Scout.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Combat Action: If you have not engaged an enemy this round, exhaust Haldir of Lórien to declare him as an attacker (and resolve his attack) against an enemy not engaged with you. Limit once per round.")
                .WithFlavorLine("\"We allow no strangers to spy out the secrets of the Naith...\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Haldir-of-Lorien-Lore-Hero-1")
                .WithInfo(56, 1, Artist.Sebastian_Giacobino);
            addAlly("Herald of Anórien", 2, Sphere.Leadership, false, 1, 0, 1, 1)
                .WithTraits("Gondor.")
                .WithTextLine("You may give Herald of Anórien doomed 2 when you play it from your hand. If you do, it gains: \"Response: After you play Herald of Anórien, choose a player. That player may put into play 1 ally from his hand with a printed cost 2 or lower.\"")
                .WithFlavorLine("\"Send the heralds forth! Let them summon all who dwell nigh!\" -Théoden, The Two Towers")
                .WithInfo(57, 3, Artist.Adam_Lane);
            addAttachment("O Lórien!", 1, Sphere.Leadership, true)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Exhaust O Lorien! to lower the cost of the next Silvan ally played this phase by 1 (to a minimum of 1).")
                .WithFlavorLine("\"I sang of leaves, of leaves of gold, and")
                .WithFlavorLine("leaves of gold there grew:")
                .WithFlavorLine("Of wind I sang, a wind there came and in the")
                .WithFlavorLine("branches blew.\" -Galadriel, The Fellowship of the Ring")
                .WithInfo(58, 3, Artist.Carolina_Eade);
            addAlly("Gwaihir", 5, Sphere.Tactics, true, 2, 3, 1, 4)
                .WithTraits("Creature.", "Eagle.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Response: After Gwaihir enters play, search your discard pile for an Eagle ally and put it into play under your control. At the end of the round, if that ally is still in play, add it to your hand.")
                .WithFlavorLine("\"The North Wind blows, but we shall outfly it.\" -Gwaihir, The Return of the King")
                .WithInfo(59, 3, Artist.Jake_Murray);
            addEvent("Pursuing the Enemy", 0, Sphere.Tactics)
                .WithTextLine("Action: Return a Silvan ally you control to your hand to choose a player. Deal 1 damage to each enemy engaged with that player.")
                .WithFlavorLine("The marauding orcs had been waylaid and almost all destroyed; the remnant had fled westward towards the mountains, and were being pursued. -The Fellowship of the Ring")
                .WithInfo(60, 3, Artist.Cristi_Balanescu);
            addEvent("Courage Awakened", 1, Sphere.Spirit)
                .WithTextLine("Action: Choose a hero. That hero gets +2 Willpower until the end of the phase. Then, if your threat is 20 or less and this is the first time you played a copy of Courage Awakened this round, return this card to your hand instead of discarding it.")
                .WithFlavorLine("But the courage that had been awakened in him was now too strong: he could not leave his friends so easily. -The Fellowship of the Ring")
                .WithInfo(61, 3, Artist.Romana_Kendelic);
            addEvent("Free to Choose", 0, Sphere.Spirit)
                .WithTextLine("Response: After your threat is raised by an encounter card effect, reduce your threat by an equal amount.")
                .WithFlavorLine("Suddenly he was aware of himself again. Frodo, neither the Voice nor the Eye; free to choose, and with one remaining instant in which to do so. -The Fellowship of the Ring")
                .WithInfo(62, 3, Artist.Romana_Kendelic);
            addAlly("Galadhrim Minstrel", 2, Sphere.Lore, false, 1, 0, 0, 1)
                .WithTraits("Silvan.", "Minstrel.")
                .WithTextLine("Response: After Galadhrim Minstrel enters play, search the top five cards of your deck for an event card and add it to your hand. Shuffle the other cards back into your deck.")
                .WithFlavorLine("...the language was that of Elven-song and spoke of things little known on Middle-earth. -The Fellowship of the Ring")
                .WithInfo(63, 3, Artist.Arden_Beckwith);
            addAttachment("Lembas", 1, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithTextLine("Play only if you control a Noldor or Silvan hero. Attach to a hero.")
                .WithTextLine("Action: Discard Lembas to ready attached hero and heal 3 damage from it.")
                .WithFlavorLine("\"...it is more strengthing than any food made by Men, and it is more pleasant than cram, by all accounts. -Lórien Elf, The Fellowship of the Ring")
                .WithInfo(64, 3, Artist.Sara_Biddle);
            addAlly("Defender of the Naith", 3, Sphere.Neutral, false, 0, 1, 2, 2)
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: After a Silvan ally you control leaves play, ready Defender of the Naith.")
                .WithFlavorLine("\"We have been keeping watch on the rivers, ever since we saw a great troop of Orcs going North toward Moria...\" -Haldir, The Fellowship of the Ring")
                .WithInfo(65, 3, Artist.Christine_Griffin);
            addQuest("Double Dealings", EncounterSet.TroubleInTharbad, 1, 'A', null)
                .WithTextLine("Setup: Set Bellach and The Crossing at Tharbad aside, out of play. Search the encounter deck for 1 copy of Spy From Mordor per player, and add them to the staging area. Make The Empty Mug the active location. The first player takes control of Nalir, as an ally. Shuffle the encounter deck.")
                .WithFlavorLine("Your meeting with Nalir is interrupted by a host of Orcs led by a man, Bellach. In the ensuing chaos, you manage to escape with the Dwarf but the Orcs pursue. Outnumbered, you must throw the Orcs off your trail if you hope to escape...")
                .WithOppositeTextLine("Time 4.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this quest, reduce each player's threat elmination level by 10 for the remainder of the game. Then, place 4 time counters on this stage.")
                .WithOppositeTextLine("Forced: After one or more progress is placed on this quest, cancell all progress and reduce each players threat by an equal amount.")
                .WithOppositeTextLine("When all players have 0 threat, immediately proceed to stage 2.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountainOrcs)
                .WithInfo(66, 1, Artist.Mariusz_Gandzel);
            addQuest("Escape from Tharbad", EncounterSet.TroubleInTharbad, 2, 'A', null)
                .WithTextLine("When Revealed: Add Bellach and The Crossing at Tharbad to the staging area. Then shuffle the encounter discard discard pile into the encounter deck and discard cards from the encounter deck until X Orc enemies have been discarded, where X is the number of players in the game. Add all discarded Orc enemies to the staging area.")
                .WithFlavorLine("You've eluded the Orcs and you make haste for the river crossing. If you can get across, perhaps you can escape. But, Bellach has cleverly set a patrol at the ford, and you are quickly spotted. You make a dash for the river...")
                .WithOppositeTextLine("Time 3.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from the quest, either raise each player's threat by 3 or Bellach makes an immediate attack against Nalir. Then, place 3 time counters on this stage.")
                .WithOppositeTextLine("Progress that would be placed on this quest are instead placed on The Crossing at Tharbad.")
                .WithOppositeTextLine("Forced: After a character leaves play, raise its controller's threat by 2.")
                .WithIncludedEncounterSets(EncounterSet.MistyMountainOrcs)
                .WithInfo(67, 1, Artist.Ben_Zweifel);
            addObjectiveAlly("Nalir", EncounterSet.TroubleInTharbad, 0, 1, 2, 3)
                .WithUnique()
                .WithTraits("Dwarf.")
                .WithTextLine("The first player gains control of Nalir.")
                .WithTextLine("Forced: At the beginning of the refresh phase, raise your threat by 1 for each player in the game.")
                .WithTextLine("If Nalir leaves play, the players lose the game.")
                .WithInfo(68, 1, Artist.Mariusz_Gandzel);
            addLocation("The Empty Mug", EncounterSet.TroubleInTharbad, 1, 4)
                .WithUnique()
                .WithTraits("City.")
                .WithTextLine("Players cannot reduce their threat.")
                .WithTextLine("While The Empty Mug is in the victory display, the current quest gains \"Forced: After a player card effect reduces a player's threat, remove it from the game.\"")
                .WithVictoryPoints(4)
                .WithInfo(69, 1, Artist.Darek_Zabrocki);
            addEnemy("Bellach", EncounterSet.TroubleInTharbad, 50, Card.VALUE_X, 5, 4, 7)
                .WithUnique()
                .WithTraits("Mordor.", "Spy.")
                .WithTextLine("X is the number of players in the game.")
                .WithTextLine("Orc and Creature enemies get -30 engagement cost and +1 Threat.")
                .WithTextLine("Forced: When Bellach is destroyed, shuffle him into the encounter deck.")
                .WithInfo(70, 1, Artist.Rafal_Hrynkiewicz);
            addLocation("The Crossing at Tharbad", EncounterSet.TroubleInTharbad, 2, 10)
                .WithUnique()
                .WithTraits("City.", "Ruins.", "River.")
                .WithTextLine("Immune to player card effects. Cannot leave the staging area.")
                .WithTextLine("The Crossing at Tharbad gets +2 quest points for each player in the game.")
                .WithTextLine("When The Crossing at Tharbad is explored, the players win the game.")
                .WithInfo(71, 1, Artist.Alyn_Spiller);
            addEnemy("Spy from Mordor", EncounterSet.TroubleInTharbad, 40, 2, 3, 2, 4)
                .WithTraits("Mordor.", "Orc.", "Spy.")
                .WithTextLine("Forced: When Spy from Modor attacks, remove 1 time counter from the current quest.")
                .WithFlavorLine("\"Some spying breed of Orc, I guess, or a creature of theirs.\" -Faramir, The Two Towers")
                .WithInfo(72, 4, Artist.Jose_Vega);
            addEnemy("Bellach's Marauder", EncounterSet.TroubleInTharbad, 30, 3, 5, 4, 5)
                .WithTraits("Orc.")
                .WithTextLine("While Bellach's Marauder is engaged with a player, it gains: \"Forced: After a time counter is removed from the current quest, deal Bellach's Marauder 2 shadow cards.\"")
                .WithShadow("Shadow: Remove 1 time counter from the current quest.")
                .WithEasyModeQuantity(1)
                .WithInfo(73, 2, Artist.Alexander_Kozachenko);
            addLocation("Streets of Tharbad", EncounterSet.TroubleInTharbad, 3, 1)
                .WithTraits("City.", "Road.")
                .WithTextLine("Progress cannot be placed on Streets of Tharbad while it is in the staging area.")
                .WithTextLine("While Streets of Tharbad is the active location, enemies get -20 engagement cost.")
                .WithFlavorLine("As soon as his back was turned, a dark figure climbed quickly in over the gate and melted into the shadows of the village street. -The Fellowship of the Ring")
                .WithInfo(74, 2, Artist.Nate_Abell);
            addLocation("Tharbad Hideout", EncounterSet.TroubleInTharbad, 1, 1)
                .WithTraits("City.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("While Tharbad Hideout is the active location, time counters cannot be removed from the current quest.")
                .WithTextLine("Forced: At the beginning of the quest phase, place 1 progress on Tharbad Hideout.")
                .WithInfo(75, 2, Artist.Nate_Abell);
            addLocation("Ruins of the Second Age", EncounterSet.TroubleInTharbad, 1, 5)
                .WithTraits("City.", "Ruins.")
                .WithTextLine("While ~Ruins of the Second Age is in the staging area, City locations get +1 Threat. While ~Ruins of the Second Age is the active location, deal engaged enemies 1 additional shadow card at the beginning of the combat phase.")
                .WithFlavorLine("...as far as Tharbad, where the old North Road crossed the river by a ruined town. -The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(76, 2, Artist.Nate_Abell);
            addLocation("Seedy Inn", EncounterSet.TroubleInTharbad, 3, 3)
                .WithTraits("City.")
                .WithTextLine("Travel: Search the encounter deck and discard pile for a Spy enemy and add it to the staging area. Shuffle the encounter deck.")
                .WithShadow("Shadow: Raise the defending player's threat by X, where X is the amount of damage dealt by this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(77, 2, Artist.Claudio_Pozas);
            addLocation("Hidden Alleyway", EncounterSet.TroubleInTharbad, 3, 5)
                .WithTraits("City.")
                .WithTextLine("Travel: Raise each player's threat by X to travel here. X is the number of enemies in play.")
                .WithTextLine("Forced: After traveling to Hidden Alleyway, add 1 time counter to the current quest.")
                .WithInfo(78, 2, Artist.Jose_Vega);
            addLocation("Decrepit Rooftops", EncounterSet.TroubleInTharbad, 2, 3)
                .WithTraits("City.")
                .WithTextLine("While Decrepit Rooftops is the active location, enemies get +1 Threat and do not make engagement checks.")
                .WithTextLine("Forced: After traveling to Decrepit Rooftops, return all engaged enemies to the staging area.")
                .WithInfo(79, 2, Artist.Jose_Vega);
            addTreachery("Constant Tail", EncounterSet.TroubleInTharbad)
                .WithTextLine("When Revealed: Return all engaged enemies to the staging area. Then, the first player either removes 1 time counter from the current quest or each Spy enemy in the staging area gets +2 Threat until the end of the phase.")
                .WithFlavorLine("Concealment was no longer possible, and they could only hope that no enemy or spy was observing them. -The Fellowship of the Ring")
                .WithInfo(80, 2, Artist.Jason_Ward);
            addTreachery("Conspicuous Lot", EncounterSet.TroubleInTharbad)
                .WithTextLine("When Revealed: Each player raises his threat by 1 for each ally he controls. Then, if any player's threat is 20 or less, this card gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. (+2 Attack instead if the defending player's threat is 20 or less).")
                .WithEasyModeQuantity(1)
                .WithInfo(81, 2, Artist.Jake_Murray);
            addTreachery("Cornered", EncounterSet.TroubleInTharbad)
                .WithTextLine("When Revealed: The first player either removes 1 time counter from the current quest or each enemy gets -20 engagement cost and +1 Attack until the end of the round.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending player's threat is 20 or less).")
                .WithInfo(82, 2, Artist.Aurelien_Hubert);
            addTreachery("Get That Dwarf!", EncounterSet.TroubleInTharbad)
                .WithTextLine("When Revealed: The enemy in the staging area with the highest Attack engages the first player and makes an immediate attack against Nalir. If there are no enemies in the staging area, Get That Dwarf! gains surge.")
                .WithShadow("Shadow: If this attack is undefended, deal 2 damage to Nalir.")
                .WithEasyModeQuantity(1)
                .WithInfo(83, 2, Artist.Ellyson_Ferrari_Lifante);
        }
    }
}
