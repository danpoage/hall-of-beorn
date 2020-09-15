/* Generated CardSet class: The Nîn-in-Eilph */

using System;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TheNinInEilphSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Nîn-in-Eilph";
            AlternateName = "Nin-in-Eilph";
            Abbreviation = "NiE";
            Number = 26;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";

            addHero("Mablung", 10, Sphere.Tactics, 2, 2, 2, 4)
                .WithTraits("Gondor.", "Ranger.")
                .WithTextLine("Response: After you engage an enemy, add 1 resource to Mablung's resource pool. (Limit once per phase.)")
                .WithFlavorLine("But the Captains of the West were well warned by their scouts, skilled men from Henneth Annûn led by Mablung...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(84, 1, Artist.Sebastian_Giacobino);
            addEvent("Follow Me!", 1, Sphere.Leadership)
                .WithTextLine("Action: Take control of the first player token and draw 1 card.")
                .WithFlavorLine("\"Come! I will lead you now!\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithInfo(85, 3, Artist.Ilich_Henriquez);
            addEvent("Tighten Our Belts", 0, Sphere.Leadership)
                .WithTextLine("Refresh Action: Choose a player. Each hero that player controls that did not spend any resources this round gains 1 resource. Only 1 copy of Tighten Our Belts can be played by the players each round.")
                .WithFlavorLine("There was nothing now to be done but to tighten the belts round their empty stomachs, and hoist their empty sacks and packs... -The Hobbit")
                .WithInfo(86, 3, Artist.Matt_Stawicki);
            addAlly("Galadhon Archer", 2, Sphere.Tactics, false, 0, 2, 0, 1)
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After Galadhon Archer enters play, deal 1 damage to an enemy not engaged with you.")
                .WithFlavorLine("\"...they say that you breathe so loud that they could shoot you in the dark.\" -Legolas, The Fellowship of the Ring")
                .WithInfo(87, 3, Artist.Sara_K_Diesel);
            addAttachment("Bow of the Galadhrim", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Silvan character with the ranged keyword. Restricted.")
                .WithTextLine("Attached character gets +1 Attack. (+2 Attack instead if attacking an enemy not engaged with you.)")
                .WithFlavorLine("...longer and stronger than the bows of Mirkwood, and strung with a string of elf-hair. -The Fellowship of the Ring")
                .WithInfo(88, 3, Artist.Sara_Biddle);
            addAlly("Celduin Traveler", 3, Sphere.Spirit, false, 2, 0, 1, 2)
                .WithTraits("Dale.", "Scout.")
                .WithKeywords("Secrecy 2.")
                .WithTextLine("Secrecy 2.")
                .WithTextLine("Response: After Celduin Traveler enters play, look at the top card of the encounter deck. If it is a location, you may discard it.")
                .WithFlavorLine("In two days going they rowed right up the Long Lake and passed out into the River Running... -The Hobbit")
                .WithInfo(89, 3, Artist.Melanie_Maier);
            addEvent("Island Amid Perils", 0, Sphere.Spirit)
                .WithTextLine("Action: Return a Silvan ally you control to your hand to reduce your threat by X where X is the printed cost of the ally returned to your hand.")
                .WithFlavorLine("\"...we dare not by our own trust endanger our land. We live now upon an island amid many perils...\"")
                .WithFlavorLine("-Haldir, The Fellowship of the Ring")
                .WithInfo(90, 3, Artist.Magali_Villeneuve);
            addAlly("Mirkwood Pioneer", 2, Sphere.Lore, false, 1, 0, 0, 2)
                .WithTraits("Woodman.")
                .WithTextLine("You may give Mirkwood Pioneer doomed 1 when you play it from your hand. If you do it gains: \"Response: After you play Mirkwood Pioneer, choose a card in the staging area. Until the end of the round, the chosen card does not contribute its Threat.\"")
                .WithInfo(91, 3, Artist.Melanie_Maier);
            addAttachment("Wingfoot", 1, Sphere.Lore, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Ranger hero.")
                .WithTextLine("Response: After attached hero commits to a quest, name enemy, location or treachery. If a card of the named type is revealed during this quest phase, exhaust Wingfoot to ready attached hero.")
                .WithFlavorLine("\"Wingfoot I name you. This deed of the three friends should be sung in many a hall. Forty leagues and five you have measured ere the forth day is ended!\"")
                .WithFlavorLine("-Éomer, The Two Towers")
                .WithErrata(1)
                .WithInfo(92, 3, Artist.Gabriel_Verdon);
            addAttachment("Defender of the West", 1, Sphere.Neutral, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a non-objective unique ally in play.")
                .WithTextLine("The first player gains control of attached ally.")
                .WithTextLine("Damage from undefended attacks against you may be assigned to attached ally.")
                .WithFlavorLine("\"...if by life or death I can save you, I will.\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithInfo(93, 3, Artist.Romana_Kendelic);
            addQuest("Fleeing from Tharbad", EncounterSet.TheNinInEilph, 1, 'A', 0)
                .WithTextLine("Setup: The first player takes control of Nalir. Set the Ancient Marsh-dweller aside, out of play. Each player searches the encounter deck for a different location and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("You've entered the vast marshlands of the Nin-in-Eilph with Nalir in order to escape Bellach and his Orcs. Now, you must cross the swamp in order to reach Hollin on the other side.")
                .WithOppositeTextLine("When Revealed: Advance to a random stage 2A.")
                .WithOppositeFlavorLine("No traveller has entered the Nîn-in-Eilph for an age and there is no path through the shifting marshland. You must find your own way across the treacherous bog.")
                .WithIncludedEncounterSets(EncounterSet.WearyTravelers)
                .WithInfo(94, 1, Artist.Igor_Kieryluk);
            addQuest("Through the Marsh", EncounterSet.TheNinInEilph, 2, 'A', 13)
                .WithOppositeTitle("No End in Sight")
                .WithSlugSuffix("No End in Sight")
                .WithTextLine("When Revealed: Raise each player's threat by 1.")
                .WithFlavorLine("As you trudge through endless swamp, you begin to wonder if you will ever reach the other side.")
                .WithOppositeTextLine("Time 3.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, advance to a different stage 2A at random. Return this stage to the quest deck.")
                .WithOppositeTextLine("Player card effects cannot be used to gain resources or draw cards.")
                .WithOppositeTextLine("Forced: When the players defeat this stage, advance to a random stage 3A.")
                .WithIncludedEncounterSets(EncounterSet.WearyTravelers)
                .WithInfo(95, 1, Artist.Mariusz_Gandzel);
            addQuest("Through the Marsh", EncounterSet.TheNinInEilph, 2, 'A', 13)
                .WithOppositeTitle("A Weary Passage")
                .WithSlugSuffix("A Weary Passage")
                .WithTextLine("When Revealed: Raise each player's threat by 1.")
                .WithFlavorLine("As you trudge through endless swamp, you begin to wonder if you will ever reach the other side.")
                .WithOppositeTextLine("Time 3.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, advance to a different stage 2A at random. Return this stage to the quest deck.")
                .WithOppositeTextLine("In order to commit characters to the quest, a player must first discard a card at random from his hand.")
                .WithOppositeTextLine("Forced: When the players defeat this stage, advance to a random stage 3A.")
                .WithIncludedEncounterSets(EncounterSet.WearyTravelers)
                .WithInfo(96, 1, Artist.Mariusz_Gandzel);
            addQuest("Through the Marsh", EncounterSet.TheNinInEilph, 2, 'A', 13)
                .WithOppositeTitle("A Forgotten Land")
                .WithSlugSuffix("A Forgotten Land")
                .WithTextLine("When Revealed: Raise each player's threat by 1.")
                .WithFlavorLine("As you trudge through endless swamp, you begin to wonder if you will ever reach the other side.")
                .WithOppositeTextLine("Time 3.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, advance to a different stage 2A at random. Return this stage to the quest deck.")
                .WithOppositeTextLine("Each player cannot play more than 1 card each round.")
                .WithOppositeTextLine("Forced: When the players defeat this stage, advance to a random stage 3A.")
                .WithIncludedEncounterSets(EncounterSet.WearyTravelers)
                .WithInfo(97, 1, Artist.Mariusz_Gandzel);
            addQuest("Lost in the Swanfleet", EncounterSet.TheNinInEilph, 3, 'A', 16)
                .WithOppositeTitle("Impassable Marshland")
                .WithSlugSuffix("Impassable Marshland")
                .WithTextLine("When Revealed: Raise each player's threat by 1. Add Ancient Marsh-dweller to the staging area (from out of play or engaged with a player) and heal all damage from it.")
                .WithFlavorLine("Lost as you are, your presence in the marsh has not gone unnoticed. An ancient and foul swamp creature stalks your company...")
                .WithOppositeTextLine("Time 3.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, advance to a different stage 3A at random. Return this stage to the quest deck.")
                .WithOppositeTextLine("Each location in play gets +1 Threat.")
                .WithOppositeFlavorLine("Despite the size of the creatures hunting you, the swamp itself is your worst enemy. The ground sinks down beneath you and the mud pulls the boots off your feet. Every step forward is a struggle...")
                .WithIncludedEncounterSets(EncounterSet.WearyTravelers)
                .WithInfo(98, 1, Artist.Silver_Saaremael);
            addQuest("Lost in the Swanfleet", EncounterSet.TheNinInEilph, 3, 'A', 16)
                .WithOppositeTitle("A Treacherous Swamp")
                .WithSlugSuffix("A Treacherous Swamp")
                .WithTextLine("When Revealed: Raise each player's threat by 1. Add Ancient Marsh-dweller to the staging area (from out of play or engaged with a player) and heal all damage from it.")
                .WithFlavorLine("Lost as you are, your presence in the marsh has not gone unnoticed. An ancient and foul swamp creature stalks your company...")
                .WithOppositeTextLine("Time 3.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, advance to a different stage 3A at random. Return this stage to the quest deck.")
                .WithOppositeTextLine("Each player cannot ready more than 5 characters during the refresh phase.")
                .WithOppositeFlavorLine("After wandering aimlessly for so long, harried by foul creatues, your resolve begins to waver and your companions collapse from exhaustion. If you cannot find a way across, the swamp will erase all evidence of your passage...")
                .WithIncludedEncounterSets(EncounterSet.WearyTravelers)
                .WithInfo(99, 1, Artist.Silver_Saaremael);
            addQuest("Lost in the Swanfleet", EncounterSet.TheNinInEilph, 3, 'A', 16)
                .WithOppositeTitle("Creatures of a Forgotten Age")
                .WithSlugSuffix("Creatures of a Forgotten Age")
                .WithTextLine("When Revealed: Raise each player's threat by 1. Add Ancient Marsh-dweller to the staging area (from out of play or engaged with a player) and heal all damage from it.")
                .WithFlavorLine("Lost as you are, your presence in the marsh has not gone unnoticed. An ancient and foul swamp creature stalks your company...")
                .WithOppositeTextLine("Time 3.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, advance to a different stage 3A at random. Return this stage to the quest deck.")
                .WithOppositeTextLine("Each enemy in the staging area gets -20 engagement cost.")
                .WithOppositeFlavorLine("As if the swamp itself was not bad enough, its foul denizens swarm around you, their serpentine forms slithering through the murky water that rises to your waist...")
                .WithIncludedEncounterSets(EncounterSet.WearyTravelers)
                .WithInfo(100, 1, Artist.Silver_Saaremael);
            addQuest("Out of the Swamp", EncounterSet.TheNinInEilph, 4, 'A', null)
                .WithTextLine("When Revealed: Add Ancient Marsh-dweller to the staging area (from out of play or engaged with a player) and heal all damage on it. Then Ancient Marsh-dweller makes an attack against each player in player order.")
                .WithFlavorLine("Beyond all hope, you have reached the edge of the swamp! You can see the gentle rise of the hills in the distance, but the huge marsh-dweller that has pursued your company now lies between you and dry land.")
                .WithOppositeTextLine("Time 2.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, Ancient Marsh-dweller makes an attack against each player in order. Place 2 time counters on this stage.")
                .WithOppositeTextLine("When Ancient Marsh-dweller is defeated, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.WearyTravelers)
                .WithInfo(101, 1, Artist.Rafal_Hrynkiewicz);
            addObjectiveAlly("Nalir", EncounterSet.TheNinInEilph, 0, 1, 2, 3)
                .WithUnique()
                .WithTraits("Dwarf.")
                .WithTextLine("The first player gains control of Nalir.")
                .WithTextLine("Forced: At the beginning of the refresh phase, raise your threat by 1 for each player in the game.")
                .WithTextLine("If Nalir leaves play, the players lose the game.")
                .WithInfo(102, 1, Artist.Mariusz_Gandzel);
            addEnemy("Ancient Marsh-dweller", EncounterSet.TheNinInEilph, 45, 3, 6, 4, 9)
                .WithUnique()
                .WithTraits("Creature.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Ancient Marsh-dweller gets +1 Threat and +1 Attack for each resource token on it.")
                .WithTextLine("Forced: After any number of time counters are removed from the current quest, place a resource token here.")
                .WithVictoryPoints(5)
                .WithInfo(103, 1, Artist.Tom_Garden);
            addEnemy("Giant Swamp Adder", EncounterSet.TheNinInEilph, 35, 3, 3, 3, 6)
                .WithTraits("Creature.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Forced: After any number of time counters are removed from the current quest, ~Giant ~Swamp Adder attacks the engaged player.")
                .WithFlavorLine("There were also abominable creatures haunting the reeds and tussocks... -The Fellowship of the Ring")
                .WithEasyModeQuantity(3)
                .WithInfo(104, 4, Artist.Dmitry_Prosvirnin);
            addEnemy("Neekerbreekers", EncounterSet.TheNinInEilph, 20, 2, 1, 1, 6)
                .WithTraits("Creature.", "Insect.")
                .WithTextLine("Forced: After any number of time counters are removed from the current quest, the engaged player must deal 2 damage to an ally he controls.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(105, 3, Artist.Dmitry_Prosvirnin);
            addLocation("Fen of Reeds", EncounterSet.TheNinInEilph, 2, 3)
                .WithTraits("Marsh.")
                .WithTextLine("While Fen of Reeds is in the staging area, it gains: \"Forced: After the players advance to a quest stage, each player must exhaust a character he controls.\"")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each time counter on the quest.")
                .WithEasyModeQuantity(2)
                .WithInfo(106, 3, Artist.Anthony_Feliciano);
            addLocation("Finger of Glanduin", EncounterSet.TheNinInEilph, 3, 3)
                .WithTraits("River.", "Marsh.")
                .WithTextLine("While Finger of Glanduin is in the staging area, it gains : \"Forced: At the end of each round, remove 1 progress from each location in play.\"")
                .WithShadow("Shadow: If this attack destroys a character remove all progress from the current quest.")
                .WithInfo(107, 3, Artist.Anthony_Feliciano);
            addLocation("Hidden Eyot", EncounterSet.TheNinInEilph, 3, 4)
                .WithTraits("Marsh.")
                .WithTextLine("Response: After Hidden Eyot leaves play as an explored location, place 2 time counters on the current quest.")
                .WithTextLine("Travel: Each player must exhaust a character he controls to travel here.")
                .WithInfo(108, 2, Artist.Titus_Lunter);
            addLocation("Sinking Bog", EncounterSet.TheNinInEilph, 1, 5)
                .WithTraits("Marsh.")
                .WithTextLine("While Sinking Bog is in the staging area, each character gets -1 Willpower, -1 Attack, and -1 Defense for each Item attached to it. This ability does not stack with other copies of Sinking Bog.")
                .WithShadow("Shadow: Defending character gets -1 Defense for this attack for each attachment attached to it.")
                .WithInfo(109, 3, Artist.Ben_Zweifel);
            addTreachery("Shifting Marshland", EncounterSet.TheNinInEilph)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Remove 1 time counter from the current quest.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack after this one.")
                .WithEasyModeQuantity(2)
                .WithInfo(110, 3, Artist.Rick_Price);
            addTreachery("Remnants of Elder Days", EncounterSet.TheNinInEilph)
                .WithTextLine("When Revealed: Each player must search the encounter deck or discard pile for a Creature enemy and put it into play engaged with him. Shuffle the encounter deck. This effect cannot be canceled.")
                .WithFlavorLine("\"An evil of the Ancient World it seemed, such as I have never seen before...\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithEasyModeQuantity(0)
                .WithInfo(111, 1, Artist.Mark_Bulahao);
        }
    }
}
